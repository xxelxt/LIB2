using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class MuonTraDAL
    {
        private static readonly string TableName = "MuonTra";
        private static readonly string TableCTName = "CTMuonTra";

        public static DataTable GetAllMuonTra()
        {
            string sql = $"SELECT MT.MaMuonTra, MT.MaBD, BD.TenBD, MT.TGMuon, MT.TGTra FROM {TableName} MT INNER JOIN BanDoc BD ON MT.MaBD = BD.MaBD";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetCTMuonTra(string maMuonTra)
        {
            string sql = $"SELECT CT.MaTL, S.TenSach, CT.SoLuong, CT.TTTra, CT.GhiChu FROM {TableCTName} CT INNER JOIN Sach S ON CT.MaTL = S.MaSach WHERE CT.MaMuonTra = @MaMuonTra";
            SqlParameter[] param = { new SqlParameter("@MaMuonTra", maMuonTra) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }

        public static DataTable GetMuonTraBySearch(string searchOption, string searchKeyword)
        {
            string sql = $"SELECT MT.MaMuonTra, MT.MaBD, BD.TenBD, MT.TGMuon, MT.TGTra FROM {TableName} MT INNER JOIN BanDoc BD ON MT.MaBD = BD.MaBD ";

            DateTime parsedDate;
            bool isDate = DateTime.TryParseExact(searchKeyword, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            switch (searchOption)
            {
                case "Mã mượn trả":
                    sql += $"WHERE MT.MaMuonTra LIKE '%{searchKeyword}%'";
                    break;
                case "Mã bạn đọc":
                    sql += $"WHERE MT.MaBD LIKE N'%{searchKeyword}%'";
                    break;
                case "Ngày mượn":
                    if (isDate)
                    {
                        sql += $"WHERE CONVERT(date, MT.TGMuon, 103) = CONVERT(date, '{parsedDate:dd/MM/yyyy}', 103)";
                    }
                    else
                    {
                        throw new ArgumentException("Ngày mượn không hợp lệ");
                    }
                    break;
                case "Ngày trả":
                    if (isDate)
                    {
                        sql += $"WHERE CONVERT(date, MT.TGTra, 103) = CONVERT(date, '{parsedDate:dd/MM/yyyy}', 103)";
                    }
                    else
                    {
                        throw new ArgumentException("Ngày trả không hợp lệ");
                    }
                    break;
                default:
                    throw new ArgumentException("Không có tuỳ chọn tìm kiếm");
            }

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static void DeleteMuonTra(string maMuonTra)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaMuonTra = @MaMuonTra";
            SqlParameter[] deleteParams = { new SqlParameter("@MaMuonTra", maMuonTra) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void DeleteCTMuonTra(string maMuonTra)
        {
            string sqlDelete = "DELETE FROM " + TableCTName + " WHERE MaMuonTra = @MaMuonTra";
            SqlParameter[] deleteParams = { new SqlParameter("@MaMuonTra", maMuonTra) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool CheckMaMuonTraExists(string maMuonTra)
        {
            string sql = "SELECT MaMuonTra FROM " + TableName + " + WHERE MaMuonTra = @MaMuonTra";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaMuonTra", maMuonTra)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static string InsertEmptyMuonTra(string maMuonTra)
        {
            string sqlInsert = "INSERT INTO " + TableName + " (MaMuonTra, MaBD, TGMuon, TGTra) VALUES (@MaMuonTra, null, '01/01/2000', '01/02/2000')";
            SqlParameter[] insertParams = { new SqlParameter("@MaMuonTra", maMuonTra) };

            DatabaseLayer.RunSql(sqlInsert, insertParams);

            return GetLastMaMuonTra();
        }

        public static string GetLastMaMuonTra()
        {
            string sql = "SELECT TOP 1 MaMuonTra FROM " + TableName + " ORDER BY MaMuonTra DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaMuonTra"].ToString();
        }

        public static void DeleteEmptyMuonTra(string maMuonTra)
        {
            string sqlCheck = "SELECT MaBD FROM " + TableName + " WHERE MaMuonTra = @MaMuonTra AND MaBD = null";

            SqlParameter[] sqlParams = { new SqlParameter("@MaMuonTra", maMuonTra) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, sqlParams);

            if (dt.Rows.Count > 0)
            {
                string maBD = dt.Rows[0]["MaBD"].ToString();

                if (!String.IsNullOrEmpty(maBD))
                {
                    return;
                }
            }
            else
            {
                return;
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaMuonTra = @MaMuonTra";
            string sqlDeleteCT = "DELETE FROM " + TableCTName + " WHERE MaMuonTra = @MaMuonTra";

            SqlParameter[] parameters = { new SqlParameter("@MaMuonTra", maMuonTra) };
            SqlParameter[] parametersCT = { new SqlParameter("@MaMuonTra", maMuonTra) };

            DatabaseLayer.RunSqlDel(sqlDeleteCT, parametersCT);
            DatabaseLayer.RunSqlDel(sqlDelete, parameters);
        }

        public static void UpdateMuonTra(string maMuonTra, string maBD, DateTime TGMuon, DateTime TGTra)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaBD = @MaBD, TGMuon = @TGMuon, TGTra = @TGTra WHERE MaMuonTra = @MaMuonTra";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaMuonTra", maMuonTra),
                new SqlParameter("@MaBD", maBD),
                new SqlParameter("@TGMuon", TGMuon),
                new SqlParameter("@TGTra", TGTra)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void InsertSachCTMuonTra(string maMuonTra, string maTL, int soLuong, bool trangThai, string ghiChu)
        {
            string sql = "INSERT INTO " + TableCTName + " (MaMuonTra, MaTL, SoLuong, TTTra, GhiChu) VALUES (@MaMuonTra, @MaTL, @SoLuong, @TTTra, @GhiChu)";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaMuonTra", maMuonTra),
                new SqlParameter("@MaTL", maTL),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@TTTra", trangThai),
                new SqlParameter("@GhiChu", ghiChu)
            };

            DatabaseLayer.RunSql(sql, sqlParams);
        }

        public static bool CheckMaTaiLieuExists(string maMuonTra, string maTL)
        {
            string sql = "SELECT MaTL FROM " + TableCTName + " WHERE MaMuonTra = @MaMuonTra AND MaTL = @MaTL";
            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaMuonTra", maMuonTra),
                new SqlParameter("@MaTL", maTL)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static void UpdateSachCTMuonTra(string maMuonTra, string maTL, int soLuong, bool trangThai, string ghiChu)
        {
            string sql = "UPDATE " + TableCTName + " SET SoLuong = @SoLuong, TTTra = @TTTra, GhiChu = @GhiChu WHERE MaMuonTra = @MaMuonTra AND MaTL = @MaTL";

            SqlParameter[] sqlParams =
            {
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@TTTra", trangThai),
                new SqlParameter("@GhiChu", ghiChu),
                new SqlParameter("@MaMuonTra", maMuonTra),
                new SqlParameter("@MaTL", maTL)
            };

            DatabaseLayer.RunSql(sql, sqlParams);
        }

        public static void DeleteSachCTMuonTra(string maMuonTra, string maTL)
        {
            string sql = "DELETE FROM " + TableCTName + " WHERE MaMuonTra = @MaMuonTra AND MaTL = @MaTL";

            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaMuonTra", maMuonTra),
                new SqlParameter("@MaTL", maTL)
            };

            DatabaseLayer.RunSqlDel(sql, sqlParams);
        }

        public static DataTable GetMuonTraByMaBanDoc(string maBD)
        {
            string query = $@"SELECT TOP 1 MT.*
                                FROM MuonTra MT
                                WHERE MaBD = '{maBD}'
                                ORDER BY MaMuonTra DESC;";

            SqlParameter[] param = { new SqlParameter("@MaBD", maBD) };

            return DatabaseLayer.GetDataToTable(query, param);
        }

        public static string GetMaMuonTraGanNhatByMaBanDoc(string maBD)
        {
            string query = $@"SELECT TOP 1 MT.*
                                FROM MuonTra MT
                                WHERE MaBD = '{maBD}'
                                ORDER BY MaMuonTra DESC;";

            SqlParameter[] param = { new SqlParameter("@MaBD", maBD) };

            DataTable dt = DatabaseLayer.GetDataToTable(query, param);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["MaMuonTra"].ToString();
            }

            return string.Empty;
        }

        public static DataTable GetCTMuonTraByMaBanDoc(string maBD)
        {
            string maMTGanNhat = GetMaMuonTraGanNhatByMaBanDoc(maBD);

            string sql = $"SELECT CT.MaTL, S.TenSach, CT.SoLuong, CT.TTTra, CT.GhiChu FROM {TableCTName} CT INNER JOIN Sach S ON CT.MaTL = S.MaSach WHERE CT.MaMuonTra = @MaMuonTra";
            SqlParameter[] param = { new SqlParameter("@MaMuonTra", maMTGanNhat) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }
    }
}
