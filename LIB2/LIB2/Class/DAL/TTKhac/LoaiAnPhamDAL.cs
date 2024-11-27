using LIB2.Database;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class LoaiAnPhamDAL
    {
        private static readonly string TableName = "LoaiAnPham";

        public static DataTable GetAllLoaiAnPham()
        {
            string sql = @"SELECT * FROM LoaiAnPham";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetLoaiAnPhamBySearch(string search)
        {
            string sql = @"SELECT * FROM LoaiAnPham WHERE MaLoaiAP LIKE '%" + search + "%' OR TenLoaiAP LIKE N'%" + search + "%'";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyLoaiAnPham()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (TenLoaiAP) VALUES ('null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaLoaiAnPham();
        }

        public static string GetLastMaLoaiAnPham()
        {
            string sql = "SELECT TOP 1 MaLoaiAP FROM " + TableName + " ORDER BY MaLoaiAP DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaLoaiAP"].ToString();
        }

        public static void DeleteEmptyLoaiAnPham(string maLoaiAP)
        {
            string sqlCheck = "SELECT TenLoaiAP FROM " + TableName + " WHERE MaLoaiAP = @MaLoaiAP";
            SqlParameter[] param = { new SqlParameter("@MaLoaiAP", maLoaiAP) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tenLoaiAP = dt.Rows[0]["TenLoaiAP"].ToString();

                if (tenLoaiAP != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaLoaiAP = @MaLoaiAP";
            SqlParameter[] deleteParams = { new SqlParameter("@MaLoaiAP", maLoaiAP) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void UpdateLoaiAnPham(string maLoaiAP, string tenLoaiAP)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TenLoaiAP = @TenLoaiAP WHERE MaLoaiAP = @MaLoaiAP";
            SqlParameter[] updateParams = {
                new SqlParameter("@TenLoaiAP", tenLoaiAP),
                new SqlParameter("@MaLoaiAP", maLoaiAP)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeleteLoaiAnPham(string maLoaiAP)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaLoaiAP = @MaLoaiAP";
            SqlParameter[] deleteParams = { new SqlParameter("@MaLoaiAP", maLoaiAP) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }
    }
}
