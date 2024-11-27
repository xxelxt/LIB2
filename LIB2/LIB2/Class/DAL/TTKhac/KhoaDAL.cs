using LIB2.Database;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class KhoaDAL
    {
        private static readonly string TableName = "Khoa";

        public static DataTable GetAllKhoa()
        {
            string sql = @"SELECT * FROM Khoa";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetKhoaBySearch(string search)
        {
            string sql = @"SELECT * FROM Khoa WHERE MaKhoa LIKE '%" + search + "%' OR TenKhoa LIKE N'%" + search + "%'";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyKhoa()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (TenKhoa) VALUES ('null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaKhoa();
        }

        public static string GetLastMaKhoa()
        {
            string sql = "SELECT TOP 1 MaKhoa FROM " + TableName + " ORDER BY MaKhoa DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaKhoa"].ToString();
        }

        public static void DeleteEmptyKhoa(string maKhoa)
        {
            string sqlCheck = "SELECT TenKhoa FROM " + TableName + " WHERE MaKhoa = @MaKhoa";
            SqlParameter[] param = { new SqlParameter("@MaKhoa", maKhoa) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string TenKhoa = dt.Rows[0]["TenKhoa"].ToString();

                if (TenKhoa != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaKhoa = @MaKhoa";
            SqlParameter[] deleteParams = { new SqlParameter("@MaKhoa", maKhoa) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void UpdateKhoa(string maKhoa, string tenKhoa)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TenKhoa = @TenKhoa WHERE MaKhoa = @MaKhoa";
            SqlParameter[] updateParams = {
                new SqlParameter("@TenKhoa", tenKhoa),
                new SqlParameter("@MaKhoa", maKhoa)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeleteKhoa(string maKhoa)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaKhoa = @MaKhoa";
            SqlParameter[] deleteParams = { new SqlParameter("@MaKhoa", maKhoa) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static string GetMaKhoaByTenKhoa(string tenKhoa)
        {
            string query = "SELECT MaKhoa FROM Khoa WHERE TenKhoa = @TenKhoa";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenKhoa", tenKhoa)
            };

            DataTable dt = DatabaseLayer.GetDataToTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["MaKhoa"].ToString();
            }

            return string.Empty;
        }
    }
}
