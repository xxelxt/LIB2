using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class KHKKDAL
    {
        private static readonly string TableName = "KHKiemKe";

        public static DataTable GetAllKHKK()
        {
            string sql = $@"SELECT P.MaKHKiemKe, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet, P.DuongDan, P.TrangThai 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetThongTinKHKK(string maKHKK)
        {
            string sql = $@"SELECT P.MaKHKiemKe, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet, P.DuongDan, P.TrangThai 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            L JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV 
                            WHERE P.MaKHKiemKe = @MaKHKK";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaKHKK", maKHKK)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParams);
        }

        public static DataTable GetKHKKBySearch(string searchOption, string searchKeyword)
        {
            string sql = $@"SELECT P.MaKHKiemKe, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet, P.DuongDan, P.TrangThai 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV ";

            DateTime parsedDate;
            bool isDate = DateTime.TryParseExact(searchKeyword, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            switch (searchOption)
            {
                case "Mã kế hoạch":
                    sql += $"WHERE P.MaKHKiemKe LIKE '%{searchKeyword}%'";
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

        public static void DeleteKHKK(string maKHKK)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaKHKiemKe = @MaKHKK";
            SqlParameter[] deleteParams = { new SqlParameter("@MaKHKK", maKHKK) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool CheckMaKHKKExists(string maKHKK)
        {
            string sql = "SELECT MaKHKiemKe FROM " + TableName + " + WHERE MaKHKiemKe = @MaKHKK";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaKHKK", maKHKK)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static string InsertEmptyKHKK()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (NgayLap, DuongDan) VALUES ('01/01/2000', 'null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaKHKK();
        }

        public static string GetLastMaKHKK()
        {
            string sql = "SELECT TOP 1 MaKHKiemKe FROM " + TableName + " ORDER BY MaKHKiemKe DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaKHKiemKe"].ToString();
        }

        public static void DeleteEmptyKHKK(string maKHKK)
        {
            string sqlCheck = "SELECT NgayLap FROM " + TableName + " WHERE MaKHKiemKe = @MaKHKK AND NgayLap = '01/01/2000'";

            SqlParameter[] sqlParams = { new SqlParameter("@MaKHKK", maKHKK) };

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

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaKHKiemKe = @MaKHKK";

            SqlParameter[] parameters = { new SqlParameter("@MaKHKK", maKHKK) };
            DatabaseLayer.RunSqlDel(sqlDelete, parameters);
        }

        public static void UpdateKHKK(string maKHKK, string maNVLap, DateTime ngayLap, string duongDan)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVLap = @MaNVLap, NgayLap = @NgayLap, DuongDan = @DuongDan WHERE MaKHKiemKe = @MaKHKK";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVLap", maNVLap),
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@DuongDan", duongDan),
                new SqlParameter("@MaKHKK", maKHKK)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DuyetKHKK(string maKHKK, string maNVDuyet, DateTime ngayDuyet, bool trangThai)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVDuyet = @MaNVDuyet, NgayDuyet = @NgayDuyet, TrangThai = @TrangThai WHERE MaKHKiemKe = @MaKHKK";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVDuyet", maNVDuyet),
                new SqlParameter("@NgayDuyet", ngayDuyet),
                new SqlParameter("TrangThai", trangThai),
                new SqlParameter("@MaKHKK", maKHKK)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void KhongDuyetKHKK(string maKHKK, string maNVDuyet, bool trangThai)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVDuyet = @MaNVDuyet, TrangThai = @TrangThai WHERE MaKHKiemKe = @MaKHKK";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVDuyet", maNVDuyet),
                new SqlParameter("TrangThai", trangThai),
                new SqlParameter("@MaKHKK", maKHKK)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }
    }
}
