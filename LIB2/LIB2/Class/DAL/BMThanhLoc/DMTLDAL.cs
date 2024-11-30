using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class DMTLDAL
    {
        private static readonly string TableName = "DMThanhLoc";
        private static readonly string TableCTName = "CTDMThanhLoc";

        public static DataTable GetAllDMTL()
        {
            string sql = $@"SELECT P.MaDMThanhLoc, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetCTDMTL(string maDMTL)
        {
            string sql = $@"SELECT 
                            CT.MaDMThanhLoc, 
                            CT.MaTL, 
                            COALESCE(S.TenSach, TC.TieuDe, BL.TenDeTai) AS TenTL, 
                            CT.SoLuong, 
                            CT.DonGia, 
                            CT.LyDoThanhLoc, 
                            CT.PhuongAnXuLy 
                        FROM 
                            {TableCTName} CT 
                        LEFT JOIN TaiLieu TL ON CT.MaTL = TL.MaTL 
                        LEFT JOIN Sach S ON TL.MaTL = S.MaSach 
                        LEFT JOIN TapChiBao TC ON TL.MaTL = TC.MaTL 
                        LEFT JOIN BaiLuan BL ON TL.MaTL = BL.MaTL
                        WHERE CT.MaDMThanhLoc = @MaDMTL;";

            SqlParameter[] param = { new SqlParameter("@MaDMTL", maDMTL) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }

        public static DataTable GetThongTinDMTL(string maDMTL)
        {
            string sql = $@"SELECT P.MaDMThanhLoc, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV 
                            WHERE P.MaDMThanhLoc = @MaDMTL";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaDMTL", maDMTL)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParams);
        }

        public static DataTable GetDMTLBySearch(string searchOption, string searchKeyword)
        {
            string sql = $@"SELECT P.MaDMThanhLoc, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV ";

            DateTime parsedDate;
            bool isDate = DateTime.TryParseExact(searchKeyword, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            switch (searchOption)
            {
                case "Mã phiếu":
                    sql += $"WHERE P.MaDMThanhLoc LIKE '%{searchKeyword}%'";
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

        public static void DeleteDMTL(string maDMTL)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaDMThanhLoc = @MaDMTL";
            SqlParameter[] deleteParams = { new SqlParameter("@MaDMTL", maDMTL) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void DeleteCTDMTL(string maDMTL)
        {
            string sqlDelete = "DELETE FROM " + TableCTName + " WHERE MaDMThanhLoc = @MaDMTL";
            SqlParameter[] deleteParams = { new SqlParameter("@MaDMTL", maDMTL) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool CheckMaDMTLExists(string maDMTL)
        {
            string sql = "SELECT MaDMThanhLoc FROM " + TableName + " + WHERE MaDMThanhLoc = @MaDMTL";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaDMTL", maDMTL)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static string InsertEmptyDMTL()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (NgayLap) VALUES ('01/01/2000')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaDMTL();
        }

        public static string GetLastMaDMTL()
        {
            string sql = "SELECT TOP 1 MaDMThanhLoc FROM " + TableName + " ORDER BY MaDMThanhLoc DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaDMThanhLoc"].ToString();
        }

        public static void DeleteEmptyDMTL(string maDMTL)
        {
            string sqlCheck = "SELECT NgayLap FROM " + TableName + " WHERE MaDMThanhLoc = @MaDMTL AND NgayLap = '01/01/2000'";

            SqlParameter[] sqlParams = { new SqlParameter("@MaDMTL", maDMTL) };

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

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaDMThanhLoc = @MaDMTL";
            string sqlDeleteCT = "DELETE FROM " + TableCTName + " WHERE MaDMThanhLoc = @MaDMTL";

            SqlParameter[] parameters = { new SqlParameter("@MaDMTL", maDMTL) };
            SqlParameter[] parametersCT = { new SqlParameter("@MaDMTL", maDMTL) };

            DatabaseLayer.RunSqlDel(sqlDeleteCT, parametersCT);
            DatabaseLayer.RunSqlDel(sqlDelete, parameters);
        }

        public static void UpdateDMTL(string maDMTL, string maNVLap, DateTime ngayLap)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVLap = @MaNVLap, NgayLap = @NgayLap WHERE MaDMThanhLoc = @MaDMTL";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVLap", maNVLap),
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@MaDMTL", maDMTL)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DuyetDMTL(string maDMTL, string maNVDuyet, DateTime ngayDuyet)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVDuyet = @MaNVDuyet, NgayDuyet = @NgayDuyet WHERE MaDMThanhLoc = @MaDMTL";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVDuyet", maNVDuyet),
                new SqlParameter("@NgayDuyet", ngayDuyet),
                new SqlParameter("@MaDMTL", maDMTL)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void InsertTaiLieuCTDMTL(string maDMTL, string maTL, int soLuong, int gia, string lyDo, string phuongAn)
        {
            string sql = "INSERT INTO " + TableCTName + " (MaDMThanhLoc, MaTL, SoLuong, DonGia, LyDoThanhLoc, PhuongAnXuLy) VALUES (@MaDMTL, @MaTL, @SoLuong, @DonGia, @LyDo, @PhuongAn)";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaDMTL", maDMTL),
                new SqlParameter("@MaTL", maTL),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@DonGia", gia),
                new SqlParameter("@LyDo", lyDo),
                new SqlParameter("@PhuongAn", phuongAn)
            };

            DatabaseLayer.RunSql(sql, sqlParams);
        }

        public static bool CheckMaTaiLieu(string maDMTL, string maTL)
        {
            string sql = "SELECT MaTL FROM " + TableCTName + " WHERE MaDMThanhLoc = @MaDMTL AND MaTL = @MaTL";
            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaDMTL", maDMTL),
                new SqlParameter("@MaTL", maTL)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static void DeleteTaiLieuCTDMTL(string maDMTL, string maTL)
        {
            string sql = "DELETE FROM " + TableCTName + " WHERE MaDMThanhLoc = @MaDMTL AND MaTL = @MaTL";

            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaDMTL", maDMTL),
                new SqlParameter("@MaTL", maTL)
            };

            DatabaseLayer.RunSqlDel(sql, sqlParams);
        }
    }
}
