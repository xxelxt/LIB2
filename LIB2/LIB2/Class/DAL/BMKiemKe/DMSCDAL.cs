using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class DMSCDAL
    {
        private static readonly string TableName = "DMSuaChua";
        private static readonly string TableCTName = "CTDMSuaChua";

        public static DataTable GetAllDMSC()
        {
            string sql = $"SELECT P.MaDMSuaChua, P.MaNVLap, NV.TenNV AS TenNVLap, P.NgayLap, P.TongSoTL FROM {TableName} P INNER JOIN NhanVien NV ON P.MaNVLap = NV.MaNV";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetCTDMSC(string maDMSC)
        {
            string sql = $@"SELECT 
                            CT.MaDMSuaChua, 
                            CT.MaTL, 
                            COALESCE(S.TenSach, TC.TieuDe, BL.TenDeTai) AS TenTL, 
                            CT.SoLuong 
                        FROM 
                            {TableCTName} CT 
                        LEFT JOIN TaiLieu TL ON CT.MaTL = TL.MaTL 
                        LEFT JOIN Sach S ON TL.MaTL = S.MaSach 
                        LEFT JOIN TapChiBao TC ON TL.MaTL = TC.MaTL 
                        LEFT JOIN BaiLuan BL ON TL.MaTL = BL.MaTL
                        WHERE CT.MaDMSuaChua = @MaDMSC;";

            SqlParameter[] param = { new SqlParameter("@MaDMSC", maDMSC) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }

        public static DataTable GetThongTinDMSC(string maDMSC)
        {
            string sql = $"SELECT P.MaDMSuaChua, P.MaNVLap, NV.TenNV AS TenNVLap, P.NgayLap, P.TongSoTL FROM {TableName} P INNER JOIN NhanVien NV ON P.MaNVLap = NV.MaNV WHERE P.MaDMSuaChua = @MaDMSC";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaDMSC", maDMSC)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParams);
        }

        public static DataTable GetDMSCBySearch(string searchOption, string searchKeyword)
        {
            string sql = $"SELECT P.MaDMSuaChua, P.MaNVLap, NV.TenNV AS TenNVLap, P.NgayLap, P.TongSoTL FROM {TableName} P INNER JOIN NhanVien NV ON P.MaNVLap = NV.MaNV ";

            DateTime parsedDate;
            bool isDate = DateTime.TryParseExact(searchKeyword, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            switch (searchOption)
            {
                case "Mã danh mục":
                    sql += $"WHERE P.MaDMSuaChua LIKE '%{searchKeyword}%'";
                    break;
                case "Nhân viên lập":
                    sql += $"WHERE NV.TenNV LIKE N'%{searchKeyword}%'";
                    break;
                case "Ngày lập":
                    if (isDate)
                    {
                        sql += $"WHERE CONVERT(date, P.NgayLap, 103) = CONVERT(date, '{parsedDate:dd/MM/yyyy}', 103)";
                    }
                    else
                    {
                        throw new ArgumentException("Ngày lập không hợp lệ");
                    }
                    break;
                default:
                    throw new ArgumentException("Không có tuỳ chọn tìm kiếm");
            }

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static void DeleteDMSC(string maDMSC)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaDMSuaChua = @MaDMSC";
            SqlParameter[] deleteParams = { new SqlParameter("@MaDMSC", maDMSC) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void DeleteCTDMSC(string maDMSC)
        {
            string sqlDelete = "DELETE FROM " + TableCTName + " WHERE MaDMSuaChua = @MaDMSC";
            SqlParameter[] deleteParams = { new SqlParameter("@MaDMSC", maDMSC) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool CheckMaDMSCExists(string maDMSC)
        {
            string sql = "SELECT MaDMSuaChua FROM " + TableName + " + WHERE MaDMSuaChua = @MaDMSC";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaDMSC", maDMSC)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static string InsertEmptyDMSC()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (NgayLap, TongSoTL) VALUES ('01/01/2000', 0)";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaDMSC();
        }

        public static string GetLastMaDMSC()
        {
            string sql = "SELECT TOP 1 MaDMSuaChua FROM " + TableName + " ORDER BY MaDMSuaChua DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaDMSuaChua"].ToString();
        }

        public static void DeleteEmptyDMSC(string maDMSC)
        {
            string sqlCheck = "SELECT NgayLap FROM " + TableName + " WHERE MaDMSuaChua = @MaDMSC AND NgayLap = '01/01/2000'";

            SqlParameter[] sqlParams = { new SqlParameter("@MaDMSC", maDMSC) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, sqlParams);

            if (dt.Rows.Count > 0)
            {
                DateTime ngayLap;
                if (!DateTime.TryParse(dt.Rows[0]["NgayLap"].ToString(), out ngayLap) || ngayLap != new DateTime(2000, 1, 1))
                {
                    return;
                }
            }
            else
            {
                return;
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaDMSuaChua = @MaDMSC";
            string sqlDeleteCT = "DELETE FROM " + TableCTName + " WHERE MaDMSuaChua = @MaDMSC";

            SqlParameter[] parameters = { new SqlParameter("@MaDMSC", maDMSC) };
            SqlParameter[] parametersCT = { new SqlParameter("@MaDMSC", maDMSC) };

            DatabaseLayer.RunSqlDel(sqlDeleteCT, parametersCT);
            DatabaseLayer.RunSqlDel(sqlDelete, parameters);
        }

        public static void UpdateDMSC(string maDMSC, string maNV, DateTime ngayLap, int tongSoTL)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVLap = @MaNV, NgayLap = @NgayLap, TongSoTL = @TongSoTL WHERE MaDMSuaChua = @MaDMSC";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@TongSoTL", tongSoTL),
                new SqlParameter("@MaDMSC", maDMSC)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void InsertTaiLieuCTDMSC(string maDMSC, string maTL, int soLuong)
        {
            string sql = "INSERT INTO " + TableCTName + " (MaDMSuaChua, MaTL, SoLuong) VALUES (@MaDMSC, @MaTL, @SoLuong)";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaDMSC", maDMSC),
                new SqlParameter("@MaTL", maTL),
                new SqlParameter("@SoLuong", soLuong)
            };

            DatabaseLayer.RunSql(sql, sqlParams);
        }

        public static bool CheckMaTaiLieu(string maDMSC, string maTL)
        {
            string sql = "SELECT MaTL FROM " + TableCTName + " WHERE MaDMSuaChua = @MaDMSC AND MaTL = @MaTL";
            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaDMSC", maDMSC),
                new SqlParameter("@MaTL", maTL)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static void DeleteTaiLieuCTDMSC(string maDMSC, string maTL)
        {
            string sql = "DELETE FROM " + TableCTName + " WHERE MaDMSuaChua = @MaDMSC AND MaTL = @MaTL";

            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaDMSC", maDMSC),
                new SqlParameter("@MaTL", maTL)
            };

            DatabaseLayer.RunSqlDel(sql, sqlParams);
        }

        public static int GetSoTLByMa(string maDMSC)
        {
            string sql = $"SELECT P.TongSoTL FROM {TableName} P WHERE P.MaDMSuaChua = @MaDMSC";
            
            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaDMSC", maDMSC)
            };

            DataTable dt = DatabaseLayer.GetDataToTable(sql, sqlParams);

            if (dt.Rows.Count == 0)
            {
                return -1;
            }

            return Convert.ToInt32(dt.Rows[0]["TongSoTL"].ToString());
        }
    }
}
