using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class PhatDAL
    {
        private static readonly string TableName = "Phat";

        public static DataTable GetAllPhat()
        {
            string sql = @"SELECT P.MaPhat, P.MaBD, BD.TenBD, P.MaVP, VP.TenVP, P.TGGhiNhan, P.SoTienPhat, P.TTHT 
                           FROM Phat P 
                           INNER JOIN BanDoc BD ON BD.MaBD = P.MaBD 
                           INNER JOIN ViPham VP ON VP.MaVP = P.MaVP ";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetPhatBySearch(string searchOption, string searchKeyword)
        {
            string sql = @"SELECT P.MaPhat, P.MaBD, BD.TenBD, P.MaVP, VP.TenVP, P.TGGhiNhan, P.SoTienPhat, P.TTHT 
                           FROM Phat P 
                           INNER JOIN BanDoc BD ON BD.MaBD = P.MaBD 
                           INNER JOIN ViPham VP ON VP.MaVP = P.MaVP ";

            switch (searchOption)
            {
                case "Mã phạt":
                    sql += $"WHERE P.MaPhat LIKE '%{searchKeyword}%' ";
                    break;
                case "Mã bạn đọc":
                    sql += $"WHERE P.MaBD LIKE N'%{searchKeyword}%' ";
                    break;
                case "Vi phạm":
                    sql += $"WHERE VP.TenVP LIKE N'%{searchKeyword}%' ";
                    break;
                case "Đã thực hiện phạt":
                    sql += $"WHERE VP.TTHT = 1 ";
                    break;
                case "Chưa thực hiện phạt":
                    sql += $"WHERE VP.TTHT = 0 ";
                    break;
                default:
                    throw new ArgumentException("Không có tuỳ chọn tìm kiếm");
            }

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static void InsertPhat(string maBD, string maVP, DateTime TGGhiNhan, int soTienPhat, bool TTHT = false)
        {
            string sqlInsert = "INSERT INTO " + TableName + "(MaBD, MaVP, TGGhiNhan, SoTienPhat, TTHT) VALUES (@MaBD, @MaVP, @TGGhiNhan, @SoTienPhat, @TTHT)";

            SqlParameter[] insertParams = {
                new SqlParameter("@MaBD", maBD),
                new SqlParameter("@MaVP", maVP),
                new SqlParameter("@TGGhiNhan", TGGhiNhan),
                new SqlParameter("@SoTienPhat", soTienPhat),
                new SqlParameter("@TTHT", TTHT)
            };

            DatabaseLayer.RunSql(sqlInsert, insertParams);
        }

        public static void UpdateTTHTPhat(string maPhat, bool TTHT)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TTHT = @TTHT WHERE MaPhat = @MaPhat";
            SqlParameter[] updateParams = {
                new SqlParameter("@TTHT", TTHT),
                new SqlParameter("@MaPhat", maPhat)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeletePhat(string maPhat)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaPhat = @MaPhat";
            SqlParameter[] deleteParams = { new SqlParameter("@MaPhat", maPhat) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool GetStatusPhatByMaBanDoc(string maBD)
        {
            string sql = "SELECT P.* FROM Phat P WHERE P.MaBD = @MaBD AND P.TTHT = 0";

            SqlParameter[] param = { new SqlParameter("@MaBD", maBD) };

            int rowsAffected = DatabaseLayer.GetDataToTable(sql, param).Rows.Count;

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }
    }
}