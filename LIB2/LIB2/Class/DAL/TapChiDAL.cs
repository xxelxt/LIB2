using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class TapChiDAL
    {
        private static readonly string TableName = "TapChiBao";

        public static DataTable GetAllTapChi()
        {
            string sql = @"SELECT TC.*, LAP.MaLoaiAP 
                           FROM TapChiBao TC 
                           INNER JOIN TaiLieu TL ON TL.MaTL = TC.MaTL 
                           INNER JOIN LoaiAnPham LAP ON TL.MaLoaiAP = LAP.MaLoaiAP;";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetTapChiBySearch(string searchOption, string searchKeyword)
        {
            string sql = @"SELECT TC.*, LAP.MaLoaiAP 
                           FROM TapChiBao TC 
                           INNER JOIN TaiLieu TL ON TL.MaTL = TC.MaTL 
                           INNER JOIN LoaiAnPham LAP ON TL.MaLoaiAP = LAP.MaLoaiAP ";

            switch (searchOption)
            {
                case "Mã tài liệu":
                    sql += $"WHERE TC.MaTL LIKE '%{searchKeyword}%'";
                    break;
                case "Tiêu đề":
                    sql += $"WHERE TC.TieuDe LIKE N'%{searchKeyword}%'";
                    break;
                case "Loại ấn phẩm":
                    sql += $"WHERE LAP.TenLoaiAP LIKE N'%{searchKeyword}%'";
                    break;
                case "Nhà xuất bản":
                    sql += $"INNER JOIN NhaXuatBan NXB ON TC.MaNXB = NXB.MaNXB WHERE NXB.TenNXB LIKE N'%{searchKeyword}%'";
                    break;
                case "Kho":
                    sql += $"INNER JOIN Kho ON TC.MaKho = Kho.MaKho WHERE Kho.TenKho LIKE N'%{searchKeyword}% " +
                           $"OR Kho.ViTriTang LIKE N'%{searchKeyword}% OR Kho.GhiChu LIKE N'%{searchKeyword}%'";
                    break;
                case "Ngôn ngữ":
                    sql += $"INNER JOIN NgonNgu NN ON TC.MaNN = NN.MaNN WHERE NgonNgu.TenNN LIKE N'%{searchKeyword}%'";
                    break;
                default:
                    throw new ArgumentException("Không có tuỳ chọn tìm kiếm");
            }

            sql += " AND TC.SoLuong > 0";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyTapChi()
        {
            string maTL = TaiLieuDAL.InsertEmptyTaiLieu();

            string sqlInsert = "INSERT INTO " + TableName + " (MaTL, TieuDe, NgayXB, SoRa, SoTrang, SoLuong, DonGia) " +
                               $"VALUES ('{maTL}', 'null', '01/01/2001', 0, 1, 0, 0)";

            DatabaseLayer.RunSql(sqlInsert);
            return maTL;
        }

        public static void DeleteEmptyTapChi(string maTL)
        {
            string sqlCheck = "SELECT TieuDe FROM " + TableName + " WHERE MaTL = @MaTL";
            SqlParameter[] param = { new SqlParameter("@MaTL", maTL) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tieuDe = dt.Rows[0]["TieuDe"].ToString();

                if (tieuDe != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaTL = @MaTL";
            SqlParameter[] deleteParams = { new SqlParameter("@MaTL", maTL) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);

            TaiLieuDAL.DeleteEmptyTaiLieu(maTL);
        }

        public static void UpdateTapChi(string maTL, string tieuDe, DateTime ngayXB, int soRa, int soTrang, int soLuong, int donGia,
            string maNXB, string maKho, string maNN, string maLoaiAP)
        {
            if (!TaiLieuDAL.UpdateLoaiAnPham(maTL, maLoaiAP))
            {
                return;
            }

            string sqlUpdate = @"
                UPDATE TapChiBao 
                SET 
                    TieuDe = @TieuDe, 
                    NgayXB = @NgayXB, 
                    SoRa = @SoRa, 
                    SoTrang = @SoTrang, 
                    SoLuong = @SoLuong, 
                    DonGia = @DonGia, 
                    MaNXB = @MaNXB, 
                    MaKho = @MaKho, 
                    MaNN = @MaNN 
                WHERE MaTL = @MaTL";

            SqlParameter[] updateParams = {
                new SqlParameter("@TieuDe", tieuDe),
                new SqlParameter("@NgayXB", ngayXB),
                new SqlParameter("@SoRa", soRa),
                new SqlParameter("@SoTrang", soTrang),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@DonGia", donGia),
                new SqlParameter("@MaNXB", maNXB),
                new SqlParameter("@MaKho", maKho),
                new SqlParameter("@MaNN", maNN),
                new SqlParameter("@MaTL", maTL)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeleteTapChi(string maTL)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaTL = @MaTL";
            SqlParameter[] deleteParams = { new SqlParameter("@MaTL", maTL) };

            int rowsAffected = DatabaseLayer.RunSqlDelWithResult(sqlDelete, deleteParams);

            if (rowsAffected > 0)
            {
                TaiLieuDAL.DeleteTaiLieu(maTL);
            }
        }
    }
}
