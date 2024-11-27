using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.Design.WebControls;

namespace LIB2.DAL
{
    internal class DatPhongDAL
    {
        private static readonly string TableName = "DatPhong";
        private static readonly string TableCTName = "CTDatPhong";

        public static DataTable GetAllDatPhong()
        {
            string sql = $"SELECT DP.MaDP, DP.TGDat, DP.Phong, DP.CaSuDung, DP.TTSuDung FROM {TableName} DP;";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetDatPhongByMaDP(string maDP)
        {
            string sql = $"SELECT DP.MaDP, DP.TGDat, DP.Phong, DP.CaSuDung, DP.TTSuDung FROM {TableName} DP WHERE DP.MaDP = @MaDP;";

            SqlParameter[] param = { new SqlParameter("@MaDP", maDP) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }

        public static DataTable GetCTDatPhong(string maDP)
        {
            string sql = $"SELECT CT.MaBD, BD.TenBD FROM {TableCTName} CT INNER JOIN BanDoc BD ON CT.MaBD = BD.MaBD WHERE CT.MaDP = @MaDP";
            SqlParameter[] param = { new SqlParameter("@MaDP", maDP) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }

        public static DataTable GetDatPhongBySearch(string searchOption, string searchKeyword)
        {
            string sql = $"SELECT DP.MaDP, DP.TGDat, DP.Phong, DP.CaSuDung, DP.TTSuDung FROM {TableName} DP ";

            DateTime parsedDate;
            bool isDate = DateTime.TryParseExact(searchKeyword, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            switch (searchOption)
            {
                case "Mã đặt phòng":
                    sql += $"WHERE DP.MaDP LIKE '%{searchKeyword}%'";
                    break;
                case "Phòng":
                    sql += $"WHERE DP.Phong LIKE N'%{searchKeyword}%'";
                    break;
                case "Thời gian đặt":
                    if (isDate)
                    {
                        sql += $"WHERE CONVERT(date, DP.TGDat, 103) = CONVERT(date, '{parsedDate:dd/MM/yyyy}', 103)";
                    }
                    else
                    {
                        throw new ArgumentException("Thời gian đặt không hợp lệ");
                    }
                    break;
                case "Có sử dụng":
                    sql += $"WHERE DP.TTSuDung = 1";
                    break;
                case "Không sử dụng":
                    sql += $"WHERE DP.TTSuDung = 1";
                    break;
                default:
                    throw new ArgumentException("Không có tuỳ chọn tìm kiếm");
            }

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static void DeleteDatPhong(string maDP)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaDP = @MaDP";
            SqlParameter[] deleteParams = { new SqlParameter("@MaDP", maDP) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void DeleteCTDatPhong(string maDP)
        {
            string sqlDelete = "DELETE FROM " + TableCTName + " WHERE MaDP = @MaDP";
            SqlParameter[] deleteParams = { new SqlParameter("@MaDP", maDP) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool CheckMaDatPhongExists(string maDP)
        {
            string sql = "SELECT MaDP FROM " + TableName + " + WHERE MaDP = @MaDP";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaDP", maDP)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static string InsertEmptyDatPhong(string maDP)
        {
            string sqlInsert = "INSERT INTO " + TableName + " (MaDP, TGDat, CaSuDung, TTSuDung) VALUES (@MaDP, '01/01/2000', -1, -1)";
            SqlParameter[] insertParams = { new SqlParameter("@MaDP", maDP) };

            DatabaseLayer.RunSql(sqlInsert, insertParams);

            return GetLastMaDatPhong();
        }

        public static string GetLastMaDatPhong()
        {
            string sql = "SELECT TOP 1 MaDP FROM " + TableName + " ORDER BY MaDP DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaDP"].ToString();
        }

        public static void DeleteEmptyDatPhong(string maDP)
        {
            string sqlCheck = "SELECT CaSuDung FROM " + TableName + " WHERE MaDP = @MaDP AND CaSuDung = -1";

            SqlParameter[] sqlParams = { new SqlParameter("@MaDP", maDP) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, sqlParams);

            if (dt.Rows.Count > 0)
            {
                int caSuDung = Convert.ToInt32(dt.Rows[0]["CaSuDung"].ToString());

                if (caSuDung != -1)
                {
                    return;
                }
            }
            else
            {
                return;
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaDP = @MaDP";
            string sqlDeleteCT = "DELETE FROM " + TableCTName + " WHERE MaDP = @MaDP";

            SqlParameter[] parameters = { new SqlParameter("@MaDP", maDP) };
            SqlParameter[] parametersCT = { new SqlParameter("@MaDP", maDP) };

            DatabaseLayer.RunSqlDel(sqlDeleteCT, parametersCT);
            DatabaseLayer.RunSqlDel(sqlDelete, parameters);
        }

        public static void UpdateDatPhong(string maDP, DateTime TGDat, string phong, int caSuDung, bool TTSuDung)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TGDat = @TGDat, Phong = @Phong, CaSuDung = @CaSuDung, TTSuDung = @TTSuDung WHERE MaDP = @MaDP";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@TGDat", TGDat),
                new SqlParameter("@Phong", phong),
                new SqlParameter("@CaSuDung", caSuDung),
                new SqlParameter("@TTSuDung", TTSuDung),
                new SqlParameter("@MaDP", maDP)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void InsertCTDatPhong(string maDP, string maBD)
        {
            string sql = "INSERT INTO " + TableCTName + " (MaDP, MaBD) VALUES (@MaDP, @MaBD)";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaDP", maDP),
                new SqlParameter("@MaBD", maBD)
            };

            DatabaseLayer.RunSql(sql, sqlParams);
        }

        public static bool CheckMaBanDocDP(string maDP, string maBD)
        {
            string sql = "SELECT MaBD FROM " + TableCTName + " WHERE MaDP = @MaDP AND MaBD = @MaBD";
            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaDP", maDP),
                new SqlParameter("@MaBD", maBD)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static void DeleteCTDatPhong(string maDP, string maBD)
        {
            string sql = "DELETE FROM " + TableCTName + " WHERE MaDP = @MaDP AND MaBD = @MaBD";

            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaDP", maDP),
                new SqlParameter("@MaBD", maBD)
            };

            DatabaseLayer.RunSqlDel(sql, sqlParams);
        }
    }
}
