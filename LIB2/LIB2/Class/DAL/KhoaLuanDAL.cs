using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class KhoaLuanDAL
    {
        private static readonly string TableName = "BaiLuan";

        public static DataTable GetAllKhoaLuan()
        {
            string sql = @"SELECT KL.*, LAP.MaLoaiAP 
                           FROM BaiLuan KL 
                           INNER JOIN TaiLieu TL ON TL.MaTL = KL.MaTL 
                           INNER JOIN LoaiAnPham LAP ON TL.MaLoaiAP = LAP.MaLoaiAP;";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetKhoaLuanBySearch(string searchOption, string searchKeyword)
        {
            string sql = @"SELECT KL.*, LAP.MaLoaiAP 
                           FROM BaiLuan KL 
                           INNER JOIN TaiLieu TL ON TL.MaTL = KL.MaTL 
                           INNER JOIN LoaiAnPham LAP ON TL.MaLoaiAP = LAP.MaLoaiAP ";

            switch (searchOption)
            {
                case "Mã tài liệu":
                    sql += $"WHERE KL.MaTL LIKE '%{searchKeyword}%'";
                    break;
                case "Tên đề tài":
                    sql += $"WHERE KL.TenDeTai LIKE N'%{searchKeyword}%'";
                    break;
                case "Loại ấn phẩm":
                    sql += $"WHERE LAP.TenLoaiAP LIKE N'%{searchKeyword}%'";
                    break;
                case "Người thực hiện":
                    sql += $"WHERE KL.NguoiThucHien LIKE N'%{searchKeyword}%'";
                    break;
                case "Người hướng dẫn":
                    sql += $"WHERE KL.NguoiHuongDan LIKE N'%{searchKeyword}%'";
                    break;
                case "Kho":
                    sql += $"INNER JOIN Kho ON KL.MaKho = Kho.MaKho WHERE Kho.TenKho LIKE N'%{searchKeyword}% " +
                           $"OR Kho.ViTriTang LIKE N'%{searchKeyword}% OR Kho.GhiChu LIKE N'%{searchKeyword}%'";
                    break;
                case "Ngành":
                    sql += $"INNER JOIN Nganh N ON KL.MaNganh = N.MaNganh WHERE N.TenNganh LIKE N'%{searchKeyword}%'";
                    break;
                default:
                    throw new ArgumentException("Không có tuỳ chọn tìm kiếm");
            }

            sql += " AND KL.SoLuong > 0";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyKhoaLuan()
        {
            string maTL = TaiLieuDAL.InsertEmptyTaiLieu();

            string sqlInsert = "INSERT INTO " + TableName + " (MaTL, TenDeTai, NguoiThucHien, NguoiHuongDan, NamHT, SoLuong) " +
                               $"VALUES ('{maTL}', 'null', 'null', 'null', 2001, 1)";

            DatabaseLayer.RunSql(sqlInsert);
            return maTL;
        }

        public static void DeleteEmptyKhoaLuan(string maTL)
        {
            string sqlCheck = "SELECT TenDeTai FROM " + TableName + " WHERE MaTL = @MaTL";
            SqlParameter[] param = { new SqlParameter("@MaTL", maTL) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tenDeTai = dt.Rows[0]["tenDeTai"].ToString();

                if (tenDeTai != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaTL = @MaTL";
            SqlParameter[] deleteParams = { new SqlParameter("@MaTL", maTL) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);

            TaiLieuDAL.DeleteEmptyTaiLieu(maTL);
        }

        public static void UpdateKhoaLuan(string maTL, string tenDeTai, string nguoiThucHien, string nguoiHuongDan, int namHT, 
            string tomTat, int soLuong, string maKho, string maNganh, string maLoaiAP)
        {
            if (!TaiLieuDAL.UpdateLoaiAnPham(maTL, maLoaiAP))
            {
                return;
            }

            string sqlUpdate = @"
                UPDATE BaiLuan 
                SET 
                    TenDeTai = @TenDeTai, 
                    NguoiThucHien = @NguoiThucHien, 
                    NguoiHuongDan = @NguoiHuongDan, 
                    NamHT = @NamHT, 
                    TomTat = @TomTat, 
                    SoLuong = @SoLuong, 
                    MaKho = @MaKho, 
                    MaNganh = @MaNganh 
                WHERE MaTL = @MaTL";

            SqlParameter[] updateParams = {
                new SqlParameter("@TenDeTai", tenDeTai),
                new SqlParameter("@NguoiThucHien", nguoiThucHien),
                new SqlParameter("@NguoiHuongDan", nguoiHuongDan),
                new SqlParameter("@NamHT", namHT),
                new SqlParameter("@TomTat", tomTat),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@MaKho", maKho),
                new SqlParameter("@MaNganh", maNganh),
                new SqlParameter("@MaTL", maTL)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeleteKhoaLuan(string maTL)
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
