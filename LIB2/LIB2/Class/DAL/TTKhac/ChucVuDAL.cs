using LIB2.Database;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class ChucVuDAL
    {
        private static readonly string TableName = "ChucVu";

        public static DataTable GetAllChucVu()
        {
            string sql = @"SELECT * FROM ChucVu";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetChucVuBySearch(string search)
        {
            string sql = @"SELECT * FROM ChucVu WHERE MaCV LIKE '%" + search + "%' OR TenCV LIKE N'%" + search + "%'";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyChucVu()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (TenCV) VALUES ('null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaCV();
        }

        public static string GetLastMaCV()
        {
            string sql = "SELECT TOP 1 MaCV FROM " + TableName + " ORDER BY MaCV DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaCV"].ToString();
        }

        public static void DeleteEmptyChucVu(string maCV)
        {
            string sqlCheck = "SELECT TenCV FROM " + TableName + " WHERE MaCV = @MaCV";
            SqlParameter[] param = { new SqlParameter("@MaCV", maCV) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tenCV = dt.Rows[0]["TenCV"].ToString();

                if (tenCV != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaCV = @MaCV";
            SqlParameter[] deleteParams = { new SqlParameter("@MaCV", maCV) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void UpdateChucVu(string maCV, string tenCV)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TenCV = @TenCV WHERE MaCV = @MaCV";
            SqlParameter[] updateParams = {
                new SqlParameter("@TenCV", tenCV),
                new SqlParameter("@MaCV", maCV)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeleteChucVu(string maCV)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaCV = @MaCV";
            SqlParameter[] deleteParams = { new SqlParameter("@MaCV", maCV) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }
    }
}
