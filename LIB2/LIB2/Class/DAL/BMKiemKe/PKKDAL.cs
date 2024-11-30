using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class PKKDAL
    {
        private static readonly string TableName = "PhieuKiemKe";
        private static readonly string TableCTName = "CTPhieuKiemKe";

        public static DataTable GetAllPKK()
        {
            string sql = $"SELECT P.MaPhieuKiemKe, P.MaNVLap, NV.TenNV AS TenNVLap, P.NgayLap FROM {TableName} P INNER JOIN NhanVien NV ON P.MaNVLap = NV.MaNV";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetCTPKK(string maPKK)
        {
            string sql = $@"SELECT 
                            CT.MaPhieuKiemKe, 
                            CT.MaTL, 
                            COALESCE(S.TenSach, TC.TieuDe, BL.TenDeTai) AS TenTL, 
                            CT.SoLuong, 
                            CT.DonGia 
                        FROM 
                            {TableCTName} CT 
                        LEFT JOIN TaiLieu TL ON CT.MaTL = TL.MaTL 
                        LEFT JOIN Sach S ON TL.MaTL = S.MaSach 
                        LEFT JOIN TapChiBao TC ON TL.MaTL = TC.MaTL 
                        LEFT JOIN BaiLuan BL ON TL.MaTL = BL.MaTL
                        WHERE CT.MaPhieuKiemKe = @MaPKK;";

            SqlParameter[] param = { new SqlParameter("@MaPKK", maPKK) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }

        public static DataTable GetThongTinPKK(string maPKK)
        {
            string sql = $"SELECT P.MaPhieuKiemKe, P.MaNVLap, NV.TenNV AS TenNVLap, P.NgayLap FROM {TableName} P INNER JOIN NhanVien NV ON P.MaNVLap = NV.MaNV WHERE P.MaPhieuKiemKe = @MaPKK";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaPKK", maPKK)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParams);
        }

        public static DataTable GetPKKBySearch(string searchOption, string searchKeyword)
        {
            string sql = $"SELECT P.MaPhieuKiemKe, P.MaNVLap, NV.TenNV AS TenNVLap, P.NgayLap FROM {TableName} P INNER JOIN NhanVien NV ON P.MaNVLap = NV.MaNV ";

            DateTime parsedDate;
            bool isDate = DateTime.TryParseExact(searchKeyword, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            switch (searchOption)
            {
                case "Mã phiếu":
                    sql += $"WHERE P.MaPhieuKiemKe LIKE '%{searchKeyword}%'";
                    break;
                case "Nhân viên lập":
                    sql += $"WHERE NV.TenNV LIKE N'%{searchKeyword}%'";
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
                default:
                    throw new ArgumentException("Không có tuỳ chọn tìm kiếm");
            }

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static void DeletePKK(string maPKK)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaPhieuKiemKe = @MaPKK";
            SqlParameter[] deleteParams = { new SqlParameter("@MaPKK", maPKK) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void DeleteCTPKK(string maPKK)
        {
            string sqlDelete = "DELETE FROM " + TableCTName + " WHERE MaPhieuKiemKe = @MaPKK";
            SqlParameter[] deleteParams = { new SqlParameter("@MaPKK", maPKK) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool CheckMaPKKExists(string maPKK)
        {
            string sql = "SELECT MaPhieuKiemKe FROM " + TableName + " + WHERE MaPhieuKiemKe = @MaPKK";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaPKK", maPKK)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static string InsertEmptyPKK()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (NgayLap) VALUES ('01/01/2000')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaPKK();
        }

        public static string GetLastMaPKK()
        {
            string sql = "SELECT TOP 1 MaPhieuKiemKe FROM " + TableName + " ORDER BY MaPhieuKiemKe DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaPhieuKiemKe"].ToString();
        }

        public static void DeleteEmptyPKK(string maPKK)
        {
            string sqlCheck = "SELECT NgayLap FROM " + TableName + " WHERE MaPhieuKiemKe = @MaPKK AND NgayLap = '01/01/2000'";

            SqlParameter[] sqlParams = { new SqlParameter("@MaPKK", maPKK) };

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

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaPhieuKiemKe = @MaPKK";
            string sqlDeleteCT = "DELETE FROM " + TableCTName + " WHERE MaPhieuKiemKe = @MaPKK";

            SqlParameter[] parameters = { new SqlParameter("@MaPKK", maPKK) };
            SqlParameter[] parametersCT = { new SqlParameter("@MaPKK", maPKK) };

            DatabaseLayer.RunSqlDel(sqlDeleteCT, parametersCT);
            DatabaseLayer.RunSqlDel(sqlDelete, parameters);
        }

        public static void UpdatePKK(string maPKK, string maNV, DateTime ngayLap)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVLap = @MaNV, NgayLap = @NgayLap WHERE MaPhieuKiemKe = @MaPKK";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@MaPKK", maPKK)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void InsertTaiLieuCTPKK(string maPKK, string maTL, int soLuong, int gia)
        {
            string sql = "INSERT INTO " + TableCTName + " (MaPhieuKiemKe, MaTL, SoLuong, DonGia) VALUES (@MaPKK, @MaTL, @SoLuong, @DonGia)";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaPKK", maPKK),
                new SqlParameter("@MaTL", maTL),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@DonGia", gia)
            };

            DatabaseLayer.RunSql(sql, sqlParams);
        }

        public static bool CheckMaTaiLieu(string maPKK, string maTL)
        {
            string sql = "SELECT MaTL FROM " + TableCTName + " WHERE MaPhieuKiemKe = @MaPKK AND MaTL = @MaTL";
            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaPKK", maPKK),
                new SqlParameter("@MaTL", maTL)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static void DeleteTaiLieuCTPKK(string maPKK, string maTL)
        {
            string sql = "DELETE FROM " + TableCTName + " WHERE MaPhieuKiemKe = @MaPKK AND MaTL = @MaTL";

            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaPKK", maPKK),
                new SqlParameter("@MaTL", maTL)
            };

            DatabaseLayer.RunSqlDel(sql, sqlParams);
        }
    }
}
