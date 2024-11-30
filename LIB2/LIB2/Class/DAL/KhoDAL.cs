using LIB2.Database;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class KhoDAL
    {
        private static readonly string TableName = "Kho";

        public static DataTable GetAllKho()
        {
            string sql = @"SELECT * FROM Kho";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetKhoBySearch(string search)
        {
            string sql = @"SELECT * FROM Kho WHERE MaKho LIKE '%" + search + "%' OR TenKho LIKE N'%" + search + "%'";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyKho()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (TenKho, ViTriTang, GhiChu) VALUES ('null', -1, 'null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaKho();
        }

        public static string GetLastMaKho()
        {
            string sql = "SELECT TOP 1 MaKho FROM " + TableName + " ORDER BY MaKho DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaKho"].ToString();
        }

        public static void DeleteEmptyKho(string maKho)
        {
            string sqlCheck = "SELECT TenKho FROM " + TableName + " WHERE MaKho = @MaKho";
            SqlParameter[] param = { new SqlParameter("@MaKho", maKho) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tenKho = dt.Rows[0]["TenKho"].ToString();

                if (tenKho != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaKho = @MaKho";
            SqlParameter[] deleteParams = { new SqlParameter("@MaKho", maKho) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void UpdateKho(string maKho, string tenKho, int viTriTang, string ghiChu)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TenKho = @TenKho, ViTriTang = @ViTriTang, GhiChu = @GhiChu WHERE MaKho = @MaKho";
            SqlParameter[] updateParams = {
                new SqlParameter("@TenKho", tenKho),
                new SqlParameter("@MaKho", maKho),
                new SqlParameter("@ViTriTang", viTriTang),
                new SqlParameter("@GhiChu", ghiChu)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeleteKho(string maKho)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaKho = @MaKho";
            SqlParameter[] deleteParams = { new SqlParameter("@MaKho", maKho) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static string GetTenKhoByMa(string maKho)
        {
            string sql = "SELECT TenKho FROM " + TableName + " WHERE MaKho = @MaKho";
            SqlParameter[] param = { new SqlParameter("@MaKho", maKho) };

            DataTable dt = DatabaseLayer.GetDataToTable(sql, param);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["TenKho"].ToString();
        }
    }
}
