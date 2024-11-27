using LIB2.Database;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class NhaCungCapDAL
    {
        private static readonly string TableName = "NhaCungCap";

        public static DataTable GetAllNhaCungCap()
        {
            string sql = @"SELECT * FROM NhaCungCap";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetNhaCungCapBySearch(string search)
        {
            string sql = @"SELECT * FROM NhaCungCap WHERE MaNCC LIKE '%" + search + "%' OR TenNCC LIKE N'%" + search + "%'";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyNhaCungCap()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (TenNCC, DiaChi, Email, SDT, Fax) VALUES ('null', 'null', 'null', 'null', 'null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaNCC();
        }

        public static string GetLastMaNCC()
        {
            string sql = "SELECT TOP 1 MaNCC FROM " + TableName + " ORDER BY MaNCC DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaNCC"].ToString();
        }

        public static void DeleteEmptyNhaCungCap(string maNCC)
        {
            string sqlCheck = "SELECT TenNCC FROM " + TableName + " WHERE MaNCC = @MaNCC";
            SqlParameter[] param = { new SqlParameter("@MaNCC", maNCC) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tenNCC = dt.Rows[0]["TenNCC"].ToString();

                if (tenNCC != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaNCC = @MaNCC";
            SqlParameter[] deleteParams = { new SqlParameter("@MaNCC", maNCC) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void UpdateNhaCungCap(string maNCC, string tenNCC, string diaChi, string email, string SDT, string fax = null)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TenNCC = @TenNCC, DiaChi = @DiaChi, Email = @Email, SDT = @SDT";

            List<SqlParameter> updateParams = new List<SqlParameter>
            {
                new SqlParameter("@TenNCC", tenNCC),
                new SqlParameter("@MaNCC", maNCC),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@Email", email),
                new SqlParameter("@SDT", SDT)
            };

            if (fax == null)
            {
                sqlUpdate += " WHERE MaNCC = @MaNCC";
            }
            else
            {
                sqlUpdate += ", Fax = @Fax WHERE MaNCC = @MaNCC";
                updateParams.Add(new SqlParameter("@Fax", fax));
            }

            DatabaseLayer.RunSql(sqlUpdate, updateParams.ToArray());
        }

        public static void DeleteNhaCungCap(string maNCC)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaNCC = @MaNCC";
            SqlParameter[] deleteParams = { new SqlParameter("@MaNCC", maNCC) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }
    }
}
