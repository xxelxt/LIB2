using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class PLDAL
    {
        private static readonly string TableName = "PhieuLoi";
        private static readonly string TableCTName = "CTPhieuLoi";

        public static DataTable GetAllPL()
        {
            string sql = $@"SELECT P.MaPhieuLoi, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet, P.NguonNhap, P.TrangThai 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetCTPL(string maPL)
        {
            string sql = $@"SELECT 
                            CT.MaPhieuLoi, 
                            CT.MaTL, 
                            COALESCE(S.TenSach, TC.TieuDe, BL.TenDeTai) AS TenTL, 
                            CT.SoLuong, 
                            CT.LoiTaiLieu, 
                            CT.DonGia 
                        FROM 
                            {TableCTName} CT 
                        LEFT JOIN TaiLieu TL ON CT.MaTL = TL.MaTL 
                        LEFT JOIN Sach S ON TL.MaTL = S.MaSach 
                        LEFT JOIN TapChiBao TC ON TL.MaTL = TC.MaTL 
                        LEFT JOIN BaiLuan BL ON TL.MaTL = BL.MaTL
                        WHERE CT.MaPhieuLoi = @MaPL;";

            SqlParameter[] param = { new SqlParameter("@MaPL", maPL) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }

        public static DataTable GetThongTinPL(string maPL)
        {
            string sql = $@"SELECT P.MaPhieuLoi, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet, P.NguonNhap, P.TrangThai 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV 
                            WHERE P.MaPhieuLoi = @MaPL";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaPL", maPL)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParams);
        }

        public static DataTable GetPLBySearch(string searchOption, string searchKeyword)
        {
            string sql = $@"SELECT P.MaPhieuLoi, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet, P.NguonNhap, P.TrangThai 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV ";

            DateTime parsedDate;
            bool isDate = DateTime.TryParseExact(searchKeyword, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            switch (searchOption)
            {
                case "Mã phiếu":
                    sql += $"WHERE P.MaPhieuLoi LIKE '%{searchKeyword}%'";
                    break;
                case "Nhân viên lập":
                    sql += $"WHERE NV1.TenNV LIKE N'%{searchKeyword}%'";
                    break;
                case "Nhân viên duyệt":
                    sql += $"WHERE NV2.TenNV LIKE N'%{searchKeyword}%'";
                    break;
                case "Ngày lập":
                    if (isDate)
                    {
                        sql += $"WHERE CONVERT(date, P.NgayLap, 103) = CONVERT(date, '{parsedDate:dd/MM/yyyy}', 103)";
                    }
                    else
                    {
                        throw new ArgumentException("Ngày lập không hợp lệ");
                    }
                    break;
                case "Ngày duyệt":
                    if (isDate)
                    {
                        sql += $"WHERE CONVERT(date, P.NgayDuyet, 103) = CONVERT(date, '{parsedDate:dd/MM/yyyy}', 103)";
                    }
                    else
                    {
                        throw new ArgumentException("Ngày duyệt không hợp lệ");
                    }
                    break;
                default:
                    throw new ArgumentException("Không có tuỳ chọn tìm kiếm");
            }

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static void DeletePL(string maPL)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaPhieuLoi = @MaPL";
            SqlParameter[] deleteParams = { new SqlParameter("@MaPL", maPL) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void DeleteCTPL(string maPL)
        {
            string sqlDelete = "DELETE FROM " + TableCTName + " WHERE MaPhieuLoi = @MaPL";
            SqlParameter[] deleteParams = { new SqlParameter("@MaPL", maPL) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool CheckMaPLExists(string maPL)
        {
            string sql = "SELECT MaPhieuLoi FROM " + TableName + " + WHERE MaPhieuLoi = @MaPL";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaPL", maPL)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static string InsertEmptyPL()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (NgayLap, NguonNhap) VALUES ('01/01/2000', 'null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaPL();
        }

        public static string GetLastMaPL()
        {
            string sql = "SELECT TOP 1 MaPhieuLoi FROM " + TableName + " ORDER BY MaPhieuLoi DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaPhieuLoi"].ToString();
        }

        public static void DeleteEmptyPL(string maPL)
        {
            string sqlCheck = "SELECT NgayLap FROM " + TableName + " WHERE MaPhieuLoi = @MaPL AND NgayLap = '01/01/2000'";

            SqlParameter[] sqlParams = { new SqlParameter("@MaPL", maPL) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, sqlParams);

            if (dt.Rows.Count > 0)
            {
                DateTime ngayLap;
                if (!DateTime.TryParse(dt.Rows[0]["NgayLap"].ToString(), out ngayLap) || ngayLap != new DateTime(2000, 1, 1))
                {
                    return;
                }
            }
            else
            {
                return;
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaPhieuLoi = @MaPL";
            string sqlDeleteCT = "DELETE FROM " + TableCTName + " WHERE MaPhieuLoi = @MaPL";

            SqlParameter[] parameters = { new SqlParameter("@MaPL", maPL) };
            SqlParameter[] parametersCT = { new SqlParameter("@MaPL", maPL) };

            DatabaseLayer.RunSqlDel(sqlDeleteCT, parametersCT);
            DatabaseLayer.RunSqlDel(sqlDelete, parameters);
        }

        public static void UpdatePL(string maPL, string maNVLap, DateTime ngayLap, string nguonNhap)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVLap = @MaNVLap, NgayLap = @NgayLap, NguonNhap = @NguonNhap WHERE MaPhieuLoi = @MaPL";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVLap", maNVLap),
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@NguonNhap", nguonNhap),
                new SqlParameter("@MaPL", maPL)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DuyetPL(string maPL, string maNVDuyet, DateTime ngayDuyet, bool trangThai)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVDuyet = @MaNVDuyet, NgayDuyet = @NgayDuyet, TrangThai = @TrangThai WHERE MaPhieuLoi = @MaPL";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVDuyet", maNVDuyet),
                new SqlParameter("@NgayDuyet", ngayDuyet),
                new SqlParameter("TrangThai", trangThai),
                new SqlParameter("@MaPL", maPL)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void KhongDuyetPL(string maPL, string maNVDuyet, bool trangThai)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVDuyet = @MaNVDuyet, TrangThai = @TrangThai WHERE MaPhieuLoi = @MaPL";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVDuyet", maNVDuyet),
                new SqlParameter("TrangThai", trangThai),
                new SqlParameter("@MaPL", maPL)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void InsertTaiLieuCTPL(string maPL, string maTL, int soLuong, string loiTL, int gia)
        {
            string sql = "INSERT INTO " + TableCTName + " (MaPhieuLoi, MaTL, SoLuong, LoiTaiLieu, DonGia) VALUES (@MaPL, @MaTL, @SoLuong, @LoiTL, @DonGia)";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaPL", maPL),
                new SqlParameter("@MaTL", maTL),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@LoiTL", loiTL),
                new SqlParameter("@DonGia", gia)
            };

            DatabaseLayer.RunSql(sql, sqlParams);
        }

        public static bool CheckMaTaiLieu(string maPL, string maTL)
        {
            string sql = "SELECT MaTL FROM " + TableCTName + " WHERE MaPhieuLoi = @MaPL AND MaTL = @MaTL";
            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaPL", maPL),
                new SqlParameter("@MaTL", maTL)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static void DeleteTaiLieuCTPL(string maPL, string maTL)
        {
            string sql = "DELETE FROM " + TableCTName + " WHERE MaPhieuLoi = @MaPL AND MaTL = @MaTL";

            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaPL", maPL),
                new SqlParameter("@MaTL", maTL)
            };

            DatabaseLayer.RunSqlDel(sql, sqlParams);
        }
    }
}
