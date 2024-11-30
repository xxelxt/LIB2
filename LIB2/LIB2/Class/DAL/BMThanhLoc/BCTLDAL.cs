using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class BCTLDAL
    {
        private static readonly string TableName = "BCThanhLoc";

        public static DataTable GetAllBCTL()
        {
            string sql = $@"SELECT P.MaBCThanhLoc, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.MaDMThanhLoc, P.NgayLap, P.NgayDuyet, P.SoTLChuyenDoiMD, P.SoTLThanhLoc, P.TongTien 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV 
                            INNER JOIN DMThanhLoc DMTL ON P.MaDMThanhLoc = DMTL.MaDMThanhLoc";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetThongTinBCTL(string maBCTL)
        {
            string sql = $@"SELECT P.MaBCThanhLoc, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.MaDMThanhLoc, P.NgayLap, P.NgayDuyet, P.SoTLChuyenDoiMD, P.SoTLThanhLoc, P.TongTien 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV 
                            INNER JOIN DMThanhLoc DMTL ON P.MaDMThanhLoc = DMTL.MaDMThanhLoc 
                            WHERE P.MaBCThanhLoc = @MaBCTL";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaBCTL", maBCTL)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParams);
        }

        public static DataTable GetBCTLBySearch(string searchOption, string searchKeyword)
        {
            string sql = $@"SELECT P.MaBCThanhLoc, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.MaDMThanhLoc, P.NgayLap, P.NgayDuyet, P.SoTLChuyenDoiMD, P.SoTLThanhLoc, P.TongTien 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV 
                            INNER JOIN DMThanhLoc DMTL ON P.MaDMThanhLoc = DMTL.MaDMThanhLoc ";

            DateTime parsedDate;
            bool isDate = DateTime.TryParseExact(searchKeyword, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            switch (searchOption)
            {
                case "Mã báo cáo":
                    sql += $"WHERE P.MaBCThanhLoc LIKE '%{searchKeyword}%'";
                    break;
                case "Nhân viên lập":
                    sql += $"WHERE NV1.TenNV LIKE N'%{searchKeyword}%'";
                    break;
                case "Nhân viên duyệt":
                    sql += $"WHERE NV2.TenNV LIKE N'%{searchKeyword}%'";
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
                case "Ngày duyệt":
                    if (isDate)
                    {
                        sql += $"WHERE CONVERT(date, P.NgayDuyet, 103) = CONVERT(date, '{parsedDate:dd/MM/yyyy}', 103)";
                    }
                    else
                    {
                        throw new ArgumentException("Ngày duyệt không hợp lệ");
                    }
                    break;
                default:
                    throw new ArgumentException("Không có tuỳ chọn tìm kiếm");
            }

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static void DeleteBCTL(string maBCTL)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaBCThanhLoc = @MaBCTL";
            SqlParameter[] deleteParams = { new SqlParameter("@MaBCTL", maBCTL) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool CheckMaBCTLExists(string maBCTL)
        {
            string sql = "SELECT MaBCThanhLoc FROM " + TableName + " + WHERE MaBCThanhLoc = @MaBCTL";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaBCTL", maBCTL)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static string InsertEmptyBCTL()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (NgayLap, SoTLChuyenDoiMD, SoTLThanhLoc, TongTien) VALUES ('01/01/2000', 0, 0, 0)";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaBCTL();
        }

        public static string GetLastMaBCTL()
        {
            string sql = "SELECT TOP 1 MaBCThanhLoc FROM " + TableName + " ORDER BY MaBCThanhLoc DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaBCThanhLoc"].ToString();
        }

        public static void DeleteEmptyBCTL(string maBCTL)
        {
            string sqlCheck = "SELECT NgayLap FROM " + TableName + " WHERE MaBCThanhLoc = @MaBCTL AND NgayLap = '01/01/2000'";

            SqlParameter[] sqlParams = { new SqlParameter("@MaBCTL", maBCTL) };

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

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaBCThanhLoc = @MaBCTL";

            SqlParameter[] parameters = { new SqlParameter("@MaBCTL", maBCTL) };
            DatabaseLayer.RunSqlDel(sqlDelete, parameters);
        }

        public static void UpdateBCTL(string maBCTL, string maNVLap, string maDMTL, DateTime ngayLap, int soTLCD, int soTLTL, int tongTien)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVLap = @MaNVLap, MaDMThanhLoc = @MaDMTL, NgayLap = @NgayLap, " +
                "SoTLChuyenDoiMD = @SoTLCD, SoTLThanhLoc = @SoTLTL, TongTien = @TongTien WHERE MaBCThanhLoc = @MaBCTL";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVLap", maNVLap),
                new SqlParameter("@MaDMTL", maDMTL),
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@SoTLCD", soTLCD),
                new SqlParameter("@SoTLTL", soTLTL),
                new SqlParameter("@TongTien", tongTien),
                new SqlParameter("@MaBCTL", maBCTL)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DuyetBCTL(string maBCTL, string maNVDuyet, DateTime ngayDuyet)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVDuyet = @MaNVDuyet, NgayDuyet = @NgayDuyet WHERE MaBCThanhLoc = @MaBCTL";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVDuyet", maNVDuyet),
                new SqlParameter("@NgayDuyet", ngayDuyet),
                new SqlParameter("@MaBCTL", maBCTL)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }
    }
}
