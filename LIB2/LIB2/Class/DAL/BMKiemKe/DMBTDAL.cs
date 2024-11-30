using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class DMBTDAL
    {
        private static readonly string TableName = "DMBoiThuong";
        private static readonly string TableCTName = "CTDMBoiThuong";

        public static DataTable GetAllDMBT()
        {
            string sql = $"SELECT P.MaDMBoiThuong, P.MaNVLap, NV.TenNV AS TenNVLap, P.NgayLap, P.TongSoTL, P.TongTien FROM {TableName} P INNER JOIN NhanVien NV ON P.MaNVLap = NV.MaNV";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetCTDMBT(string maDMBT)
        {
            string sql = $@"SELECT 
                            CT.MaDMBoiThuong, 
                            CT.MaTL, 
                            COALESCE(S.TenSach, TC.TieuDe, BL.TenDeTai) AS TenTL, 
                            CT.SoLuong, 
                            CT.DonGia 
                        FROM 
                            {TableCTName} CT 
                        LEFT JOIN TaiLieu TL ON CT.MaTL = TL.MaTL 
                        LEFT JOIN Sach S ON TL.MaTL = S.MaSach 
                        LEFT JOIN TapChiBao TC ON TL.MaTL = TC.MaTL 
                        LEFT JOIN BaiLuan BL ON TL.MaTL = BL.MaTL
                        WHERE CT.MaDMBoiThuong = @MaDMBT;";

            SqlParameter[] param = { new SqlParameter("@MaDMBT", maDMBT) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }

        public static DataTable GetThongTinDMBT(string maDMBT)
        {
            string sql = $"SELECT P.MaDMBoiThuong, P.MaNVLap, NV.TenNV AS TenNVLap, P.NgayLap, P.TongSoTL, P.TongTien FROM {TableName} P INNER JOIN NhanVien NV ON P.MaNVLap = NV.MaNV WHERE P.MaDMBoiThuong = @MaDMBT";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaDMBT", maDMBT)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParams);
        }

        public static DataTable GetDMBTBySearch(string searchOption, string searchKeyword)
        {
            string sql = $"SELECT P.MaDMBoiThuong, P.MaNVLap, NV.TenNV AS TenNVLap, P.NgayLap, P.TongSoTL, P.TongTien FROM {TableName} P INNER JOIN NhanVien NV ON P.MaNVLap = NV.MaNV ";

            DateTime parsedDate;
            bool isDate = DateTime.TryParseExact(searchKeyword, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            switch (searchOption)
            {
                case "Mã danh mục":
                    sql += $"WHERE P.MaDMBoiThuong LIKE '%{searchKeyword}%'";
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

        public static void DeleteDMBT(string maDMBT)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaDMBoiThuong = @MaDMBT";
            SqlParameter[] deleteParams = { new SqlParameter("@MaDMBT", maDMBT) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void DeleteCTDMBT(string maDMBT)
        {
            string sqlDelete = "DELETE FROM " + TableCTName + " WHERE MaDMBoiThuong = @MaDMBT";
            SqlParameter[] deleteParams = { new SqlParameter("@MaDMBT", maDMBT) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool CheckMaDMBTExists(string maDMBT)
        {
            string sql = "SELECT MaDMBoiThuong FROM " + TableName + " + WHERE MaDMBoiThuong = @MaDMBT";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaDMBT", maDMBT)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static string InsertEmptyDMBT()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (NgayLap, TongSoTL, TongTien) VALUES ('01/01/2000', 0, 0)";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaDMBT();
        }

        public static string GetLastMaDMBT()
        {
            string sql = "SELECT TOP 1 MaDMBoiThuong FROM " + TableName + " ORDER BY MaDMBoiThuong DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaDMBoiThuong"].ToString();
        }

        public static void DeleteEmptyDMBT(string maDMBT)
        {
            string sqlCheck = "SELECT NgayLap FROM " + TableName + " WHERE MaDMBoiThuong = @MaDMBT AND NgayLap = '01/01/2000'";

            SqlParameter[] sqlParams = { new SqlParameter("@MaDMBT", maDMBT) };

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

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaDMBoiThuong = @MaDMBT";
            string sqlDeleteCT = "DELETE FROM " + TableCTName + " WHERE MaDMBoiThuong = @MaDMBT";

            SqlParameter[] parameters = { new SqlParameter("@MaDMBT", maDMBT) };
            SqlParameter[] parametersCT = { new SqlParameter("@MaDMBT", maDMBT) };

            DatabaseLayer.RunSqlDel(sqlDeleteCT, parametersCT);
            DatabaseLayer.RunSqlDel(sqlDelete, parameters);
        }

        public static void UpdateDMBT(string maDMBT, string maNV, DateTime ngayLap, int tongSoTL, int tongTien)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVLap = @MaNV, NgayLap = @NgayLap, TongSoTL = @TongSoTL, TongTien = @TongTien WHERE MaDMBoiThuong = @MaDMBT";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@TongSoTL", tongSoTL),
                new SqlParameter("@TongTien", tongTien),
                new SqlParameter("@MaDMBT", maDMBT)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void InsertTaiLieuCTDMBT(string maDMBT, string maTL, int soLuong, int gia)
        {
            string sql = "INSERT INTO " + TableCTName + " (MaDMBoiThuong, MaTL, SoLuong, DonGia) VALUES (@MaDMBT, @MaTL, @SoLuong, @DonGia)";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaDMBT", maDMBT),
                new SqlParameter("@MaTL", maTL),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@DonGia", gia)
            };

            DatabaseLayer.RunSql(sql, sqlParams);
        }

        public static bool CheckMaTaiLieu(string maDMBT, string maTL)
        {
            string sql = "SELECT MaTL FROM " + TableCTName + " WHERE MaDMBoiThuong = @MaDMBT AND MaTL = @MaTL";
            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaDMBT", maDMBT),
                new SqlParameter("@MaTL", maTL)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static void DeleteTaiLieuCTDMBT(string maDMBT, string maTL)
        {
            string sql = "DELETE FROM " + TableCTName + " WHERE MaDMBoiThuong = @MaDMBT AND MaTL = @MaTL";

            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaDMBT", maDMBT),
                new SqlParameter("@MaTL", maTL)
            };

            DatabaseLayer.RunSqlDel(sql, sqlParams);
        }

        public static Tuple<string, string> GetSLTongTienBTByMa(string maDMBT)
        {
            string query = $@"SELECT P.TongSoTL, P.TongTien FROM {TableName} P WHERE P.MaDMBoiThuong = @MaDMBT;";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDMBT", maDMBT)
            };

            DataTable dt = DatabaseLayer.GetDataToTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                string soTL = dt.Rows[0]["TongSoTL"].ToString();
                string tongTien = dt.Rows[0]["TongTien"].ToString();
                return Tuple.Create(soTL, tongTien);
            }

            return null;
        }
    }
}
