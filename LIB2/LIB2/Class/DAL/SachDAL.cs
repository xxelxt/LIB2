using LIB2.Database;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LIB2.DAL
{
    internal class SachDAL
    {
        private static readonly string TableName = "Sach";

        public static DataTable GetAllSach()
        {
            string sql = @"SELECT 
                            S.MaSach, 
                            S.TenSach, 
                            STRING_AGG(TG.TenTG, ', ') AS TenTacGia, 
                            S.MaNXB, 
                            S.MaKho, 
                            S.MaNN, 
                            S.MaNganh, 
                            S.MaLV, 
                            S.NamXB, 
                            S.SoTrang, 
                            S.SoLuong, 
                            S.DonGia, 
                            LAP.MaLoaiAP 
                        FROM 
                            Sach S 
                        INNER JOIN 
                            TaiLieu TL ON TL.MaTL = S.MaSach 
                        INNER JOIN 
                            LoaiAnPham LAP ON TL.MaLoaiAP = LAP.MaLoaiAP 
                        INNER JOIN 
                            TacGiaSach TGS ON TGS.MaSach = S.MaSach 
                        INNER JOIN 
                            TacGia TG ON TG.MaTG = TGS.MaTG 
                        GROUP BY 
                            S.MaSach, S.TenSach, S.MaNXB, S.MaKho, S.MaNN, S.MaNganh, S.MaLV, 
                            S.NamXB, S.SoTrang, S.SoLuong, S.DonGia, LAP.MaLoaiAP;";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetSachBySearch(string searchOption, string searchKeyword)
        {
            string sql = @"SELECT 
                            S.MaSach, 
                            S.TenSach, 
                            STRING_AGG(TG.TenTG, ', ') AS TenTacGia, 
                            S.MaNXB, 
                            S.MaKho, 
                            S.MaNN, 
                            S.MaNganh, 
                            S.MaLV, 
                            S.NamXB, 
                            S.SoTrang, 
                            S.SoLuong, 
                            S.DonGia, 
                            LAP.MaLoaiAP 
                        FROM 
                            Sach S 
                        INNER JOIN 
                            TaiLieu TL ON TL.MaTL = S.MaSach 
                        INNER JOIN 
                            LoaiAnPham LAP ON TL.MaLoaiAP = LAP.MaLoaiAP 
                        INNER JOIN 
                            TacGiaSach TGS ON TGS.MaSach = S.MaSach 
                        INNER JOIN 
                            TacGia TG ON TG.MaTG = TGS.MaTG ";

            switch (searchOption)
            {
                case "Mã sách":
                    sql += $"WHERE MaSach LIKE '%{searchKeyword}%' ";
                    break;
                case "Tên sách":
                    sql += $"WHERE TenSach LIKE N'%{searchKeyword}%' ";
                    break;
                case "Loại sách":
                    sql += $"WHERE LAP.TenLoaiAP LIKE N'%{searchKeyword}%' ";
                    break;
                case "Lĩnh vực":
                    sql += $"INNER JOIN LinhVuc LV ON S.MaLV = LV.MaLV WHERE LV.TenLV LIKE N'%{searchKeyword}%' ";
                    break;
                case "Tác giả":
                    sql += $"WHERE TG.TenTG LIKE N'%{searchKeyword}%'";
                    break;
                case "Ngôn ngữ":
                    sql += $"INNER JOIN NgonNgu NN ON S.MaNN = NN.MaNN WHERE NN.TenNN LIKE N'%{searchKeyword}%' ";
                    break;
                case "Kho":
                    sql += $"INNER JOIN Kho ON Kho.MaKho = S.MaSach WHERE Kho.TenKho LIKE N'%{searchKeyword}%' ";
                    break;
                case "Ngành":
                    sql += $"INNER JOIN Nganh N ON Sach.MaNganh = N.MaNganh WHERE N.TenNganh LIKE N'%{searchKeyword}%' ";
                    break;
                default:
                    throw new ArgumentException("Không có tuỳ chọn tìm kiếm");
            }

            sql += " AND S.SoLuong > 0 ";

            sql += @" GROUP BY 
                        S.MaSach, S.TenSach, S.MaNXB, S.MaKho, S.MaNN, S.MaNganh, S.MaLV, 
                        S.NamXB, S.SoTrang, S.SoLuong, S.DonGia, LAP.MaLoaiAP";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetTacGiaSach(string maSach)
        {
            string query = @"SELECT TG.MaTG, TG.TenTG 
                           FROM TacGia TG 
                           INNER JOIN TacGiaSach TGS ON TG.MaTG = TGS.MaTG 
                           WHERE TGS.MaSach = @MaSach;";

            SqlParameter[] queryParams = {
                new SqlParameter("@MaSach", maSach)
            };

            return DatabaseLayer.GetDataToTable(query, queryParams);
        }

        public static string InsertEmptySach()
        {
            string maTL = TaiLieuDAL.InsertEmptyTaiLieu(); 
            
            string sqlInsert = "INSERT INTO " + TableName + " (MaSach, TenSach, NamXB, SoTrang, SoLuong, DonGia) " +
                $"VALUES ('{maTL}', 'null', 2001, 1, 0, 0)";

            DatabaseLayer.RunSql(sqlInsert);
            return maTL;
        }

        public static void DeleteEmptySach(string maSach)
        {
            string sqlCheck = "SELECT TenSach FROM " + TableName + " WHERE MaSach = @MaSach";
            SqlParameter[] param = { new SqlParameter("@MaSach", maSach) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tenSach = dt.Rows[0]["TenSach"].ToString();

                if (tenSach != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaSach = @MaSach";
            SqlParameter[] deleteParams = { new SqlParameter("@MaSach", maSach) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);

            TaiLieuDAL.DeleteEmptyTaiLieu(maSach);
        }

        public static void UpdateSach(string maSach, string tenSach, string maNXB, string maKho, string maNN, string maNganh, string maLV, 
            int namXB, int soTrang, int soLuong, int gia, string maLoaiAP)
        {
            if (!TaiLieuDAL.UpdateLoaiAnPham(maSach, maLoaiAP))
            {
                return;
            }

            string sqlUpdate = @"
                UPDATE Sach  
                SET 
                    TenSach = @TenSach, 
                    MaNXB = @MaNXB, 
                    MaKho = @MaKho, 
                    MaNN = @MaNN, 
                    MaNganh = @MaNganh, 
                    MaLV = @MaLV, 
                    NamXB = @NamXB, 
                    SoTrang = @SoTrang, 
                    SoLuong = @SoLuong, 
                    Gia = @Gia
                WHERE MaSach = @MaSach";

            SqlParameter[] updateParams = {
                new SqlParameter("@TenSach", tenSach),
                new SqlParameter("@MaNXB", maNXB),
                new SqlParameter("@MaKho", maKho),
                new SqlParameter("@MaNN", maNN),
                new SqlParameter("@MaNganh", maNganh),
                new SqlParameter("@MaLV", maLV),
                new SqlParameter("@NamXB", namXB),
                new SqlParameter("@SoTrang", soTrang),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@Gia", gia),
                new SqlParameter("@MaSach", maSach)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeleteSach(string maSach)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaSach = @MaSach";
            SqlParameter[] deleteParams = { new SqlParameter("@MaSach", maSach) };

            int rowsAffected = DatabaseLayer.RunSqlDelWithResult(sqlDelete, deleteParams);

            if (rowsAffected > 0)
            {
                TaiLieuDAL.DeleteTaiLieu(maSach);
            }
        }

        public static int GetSoLuong(string maSach)
        {
            string sql = "SELECT SoLuong FROM Sach WHERE MaSach = @MaSach";
            SqlParameter[] param = { new SqlParameter("@MaSach", maSach) };

            DataTable dt = DatabaseLayer.GetDataToTable(sql, param);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["SoLuong"].ToString());
            }
            return 0;
        }

        public static void GiamSoLuong(string maSach, int soLuongMuon)
        {
            string sql = $"UPDATE Sach SET SoLuong = SoLuong - {soLuongMuon} WHERE MaSach = @MaSach";
            SqlParameter[] param = { new SqlParameter("@MaSach", maSach) };

            DatabaseLayer.RunSql(sql, param);
        }

        public static void TangSoLuong(string maSach, int soLuongMuon)
        {
            string sql = $"UPDATE Sach SET SoLuong = SoLuong + {soLuongMuon} WHERE MaSach = @MaSach";
            SqlParameter[] param = { new SqlParameter("@MaSach", maSach) };

            DatabaseLayer.RunSql(sql, param);
        }

        public static int GetGiaSach(string maSach)
        {
            string sql = "SELECT DonGia FROM Sach WHERE MaSach = @MaSach";
            SqlParameter[] param = { new SqlParameter("@MaSach", maSach) };

            DataTable dt = DatabaseLayer.GetDataToTable(sql, param);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["DonGia"].ToString());
            }
            return 0;
        }

        public static string GetTenSachByMa(string maSach)
        {
            string query = "SELECT TenSach FROM Sach WHERE MaSach = @MaSach";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSach", maSach)
            };

            DataTable dt = DatabaseLayer.GetDataToTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["TenSach"].ToString();
            }

            return string.Empty;
        }

        public static void DeleteAllTacGiaByMaSach(string maSach)
        {
            string sqlDelete = "DELETE FROM TacGiaSach WHERE MaSach = @MaSach";
            SqlParameter[] deleteParams = { new SqlParameter("@MaSach", maSach) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void AddTacGiaToSach(string maSach, string maTG)
        {
            string sqlInsert = @"INSERT INTO TacGiaSach (MaSach, MaTG) VALUES (@MaSach, @MaTG);";

            SqlParameter[] insertParams = {
                new SqlParameter("@MaSach", maSach),
                new SqlParameter("@MaTG", maTG)
            };

            DatabaseLayer.RunSql(sqlInsert, insertParams);
        }
    }
}
