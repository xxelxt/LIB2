using LIB2.Database;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class NhaXuatBanDAL
    {
        private static readonly string TableName = "NhaXuatBan";

        public static DataTable GetAllNhaXuatBan()
        {
            string sql = @"SELECT * FROM NhaXuatBan";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetNhaXuatBanBySearch(string search)
        {
            string sql = @"SELECT * FROM NhaXuatBan WHERE MaNXB LIKE '%" + search + "%' OR TenNXB LIKE N'%" + search + "%'";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyNhaXuatBan()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (TenNXB, DiaChi, Email, SDT) VALUES ('null', 'null', 'null', 'null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaNXB();
        }

        public static string GetLastMaNXB()
        {
            string sql = "SELECT TOP 1 MaNXB FROM " + TableName + " ORDER BY MaNXB DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaNXB"].ToString();
        }

        public static void DeleteEmptyNhaXuatBan(string maNXB)
        {
            string sqlCheck = "SELECT TenNXB FROM " + TableName + " WHERE MaNXB = @MaNXB";
            SqlParameter[] param = { new SqlParameter("@MaNXB", maNXB) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tenNXB = dt.Rows[0]["TenNXB"].ToString();

                if (tenNXB != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaNXB = @MaNXB";
            SqlParameter[] deleteParams = { new SqlParameter("@MaNXB", maNXB) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void UpdateNhaXuatBan(string maNXB, string tenNXB, string diaChi, string email, string SDT, string fax = null)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TenNXB = @TenNXB, DiaChi = @DiaChi, Email = @Email, SDT = @SDT";

            List<SqlParameter> updateParams = new List<SqlParameter>
            {
                new SqlParameter("@TenNXB", tenNXB),
                new SqlParameter("@MaNXB", maNXB),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@Email", email),
                new SqlParameter("@SDT", SDT)
            };

            if (fax == null)
            {
                sqlUpdate += " WHERE MaNXB = @MaNXB";
            }
            else
            {
                sqlUpdate += ", Fax = @Fax WHERE MaNXB = @MaNXB";
                updateParams.Add(new SqlParameter("@Fax", fax));
            }

            DatabaseLayer.RunSql(sqlUpdate, updateParams.ToArray());
        }

        public static void DeleteNhaXuatBan(string maNXB)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaNXB = @MaNXB";
            SqlParameter[] deleteParams = { new SqlParameter("@MaNXB", maNXB) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }
    }
}
