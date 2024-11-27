using LIB2.Database;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class NganhDAL
    {
        private static readonly string TableName = "Nganh";

        public static DataTable GetAllNganh()
        {
            string sql = @"SELECT * FROM Nganh";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetNganhBySearch(string search)
        {
            string sql = @"SELECT * FROM Nganh WHERE MaNganh LIKE '%" + search + "%' OR TenNganh LIKE N'%" + search + "%'";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyNganh()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (TenNganh) VALUES ('null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaNganh();
        }

        public static string GetLastMaNganh()
        {
            string sql = "SELECT TOP 1 MaNganh FROM " + TableName + " ORDER BY MaNganh DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaNganh"].ToString();
        }

        public static void DeleteEmptyNganh(string maNganh)
        {
            string sqlCheck = "SELECT TenNganh FROM " + TableName + " WHERE MaNganh = @MaNganh";
            SqlParameter[] param = { new SqlParameter("@MaNganh", maNganh) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tenNganh = dt.Rows[0]["TenNganh"].ToString();

                if (tenNganh != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaNganh = @MaNganh";
            SqlParameter[] deleteParams = { new SqlParameter("@MaNganh", maNganh) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void UpdateNganh(string maNganh, string tenNganh)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TenNganh = @TenNganh WHERE MaNganh = @MaNganh";
            SqlParameter[] updateParams = {
                new SqlParameter("@TenNganh", tenNganh),
                new SqlParameter("@MaNganh", maNganh)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeleteNganh(string maNganh)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaNganh = @MaNganh";
            SqlParameter[] deleteParams = { new SqlParameter("@MaNganh", maNganh) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }
    }
}
