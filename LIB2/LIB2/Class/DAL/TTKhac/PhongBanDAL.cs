using LIB2.Database;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class PhongBanDAL
    {
        private static readonly string TableName = "PhongBan";

        public static DataTable GetAllPhongBan()
        {
            string sql = @"SELECT * FROM PhongBan";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetPhongBanBySearch(string search)
        {
            string sql = @"SELECT * FROM PhongBan WHERE MaPB LIKE '%" + search + "%' OR TenPB LIKE N'%" + search + "%'";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyPhongBan()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (TenPB) VALUES ('null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaPB();
        }

        public static string GetLastMaPB()
        {
            string sql = "SELECT TOP 1 MaPB FROM " + TableName + " ORDER BY MaPB DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaPB"].ToString();
        }

        public static void DeleteEmptyPhongBan(string maPB)
        {
            string sqlCheck = "SELECT TenPB FROM " + TableName + " WHERE MaPB = @MaPB";
            SqlParameter[] param = { new SqlParameter("@MaPB", maPB) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tenPB = dt.Rows[0]["TenPB"].ToString();

                if (tenPB != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaPB = @MaPB";
            SqlParameter[] deleteParams = { new SqlParameter("@MaPB", maPB) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void UpdatePhongBan(string maPB, string tenPB)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TenPB = @TenPB WHERE MaPB = @MaPB";
            SqlParameter[] updateParams = {
                new SqlParameter("@TenPB", tenPB),
                new SqlParameter("@MaPB", maPB)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeletePhongBan(string maPB)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaPB = @MaPB";
            SqlParameter[] deleteParams = { new SqlParameter("@MaPB", maPB) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }
    }
}
