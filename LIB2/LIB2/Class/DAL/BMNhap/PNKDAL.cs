using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class PNKDAL
    {
        private static readonly string TableName = "PhieuNhapKho";
        private static readonly string TableCTName = "CTPhieuNhapKho";

        public static DataTable GetAllPNK()
        {
            string sql = $@"SELECT P.MaPhieuNhapKho, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet, P.NguonNhap, P.TrangThai 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetCTPNK(string maPNK)
        {
            string sql = $@"SELECT 
                            CT.MaPhieuNhapKho, 
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
                        WHERE CT.MaPhieuNhapKho = @MaPNK;";

            SqlParameter[] param = { new SqlParameter("@MaPNK", maPNK) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }

        public static DataTable GetThongTinPNK(string maPNK)
        {
            string sql = $@"SELECT P.MaPhieuNhapKho, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet, P.NguonNhap, P.TrangThai 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV 
                            WHERE P.MaPhieuNhapKho = @MaPNK";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaPNK", maPNK)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParams);
        }

        public static DataTable GetPNKBySearch(string searchOption, string searchKeyword)
        {
            string sql = $@"SELECT P.MaPhieuNhapKho, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet, P.NguonNhap, P.TrangThai 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV ";

            DateTime parsedDate;
            bool isDate = DateTime.TryParseExact(searchKeyword, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            switch (searchOption)
            {
                case "Mã phiếu":
                    sql += $"WHERE P.MaPhieuNhapKho LIKE '%{searchKeyword}%'";
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

        public static void DeletePNK(string maPNK)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaPhieuNhapKho = @MaPNK";
            SqlParameter[] deleteParams = { new SqlParameter("@MaPNK", maPNK) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void DeleteCTPNK(string maPNK)
        {
            string sqlDelete = "DELETE FROM " + TableCTName + " WHERE MaPhieuNhapKho = @MaPNK";
            SqlParameter[] deleteParams = { new SqlParameter("@MaPNK", maPNK) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool CheckMaPNKExists(string maPNK)
        {
            string sql = "SELECT MaPhieuNhapKho FROM " + TableName + " + WHERE MaPhieuNhapKho = @MaPNK";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaPNK", maPNK)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static string InsertEmptyPNK()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (NgayLap, NguonNhap) VALUES ('01/01/2000', 'null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaPNK();
        }

        public static string GetLastMaPNK()
        {
            string sql = "SELECT TOP 1 MaPhieuNhapKho FROM " + TableName + " ORDER BY MaPhieuNhapKho DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaPhieuNhapKho"].ToString();
        }

        public static void DeleteEmptyPNK(string maPNK)
        {
            string sqlCheck = "SELECT NgayLap FROM " + TableName + " WHERE MaPhieuNhapKho = @MaPNK AND NgayLap = '01/01/2000'";

            SqlParameter[] sqlParams = { new SqlParameter("@MaPNK", maPNK) };

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

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaPhieuNhapKho = @MaPNK";
            string sqlDeleteCT = "DELETE FROM " + TableCTName + " WHERE MaPhieuNhapKho = @MaPNK";

            SqlParameter[] parameters = { new SqlParameter("@MaPNK", maPNK) };
            SqlParameter[] parametersCT = { new SqlParameter("@MaPNK", maPNK) };

            DatabaseLayer.RunSqlDel(sqlDeleteCT, parametersCT);
            DatabaseLayer.RunSqlDel(sqlDelete, parameters);
        }

        public static void UpdatePNK(string maPNK, string maNVLap, DateTime ngayLap, string nguonNhap)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVLap = @MaNVLap, NgayLap = @NgayLap, NguonNhap = @NguonNhap WHERE MaPhieuNhapKho = @MaPNK";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVLap", maNVLap),
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@NguonNhap", nguonNhap),
                new SqlParameter("@MaPNK", maPNK)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DuyetPNK(string maPNK, string maNVDuyet, DateTime ngayDuyet, bool trangThai)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVDuyet = @MaNVDuyet, NgayDuyet = @NgayDuyet, TrangThai = @TrangThai WHERE MaPhieuNhapKho = @MaPNK";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVDuyet", maNVDuyet),
                new SqlParameter("@NgayDuyet", ngayDuyet),
                new SqlParameter("TrangThai", trangThai),
                new SqlParameter("@MaPNK", maPNK)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void KhongDuyetPNK(string maPNK, string maNVDuyet, bool trangThai)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVDuyet = @MaNVDuyet, TrangThai = @TrangThai WHERE MaPhieuNhapKho = @MaPNK";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVDuyet", maNVDuyet),
                new SqlParameter("TrangThai", trangThai),
                new SqlParameter("@MaPNK", maPNK)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void InsertTaiLieuCTPNK(string maPNK, string maTL, int soLuong, int gia)
        {
            string sql = "INSERT INTO " + TableCTName + " (MaPhieuNhapKho, MaTL, SoLuong, DonGia) VALUES (@MaPNK, @MaTL, @SoLuong, @DonGia)";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaPNK", maPNK),
                new SqlParameter("@MaTL", maTL),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@DonGia", gia)
            };

            DatabaseLayer.RunSql(sql, sqlParams);
        }

        public static bool CheckMaTaiLieu(string maPNK, string maTL)
        {
            string sql = "SELECT MaTL FROM " + TableCTName + " WHERE MaPhieuNhapKho = @MaPNK AND MaTL = @MaTL";
            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaPNK", maPNK),
                new SqlParameter("@MaTL", maTL)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static void DeleteTaiLieuCTPNK(string maPNK, string maTL)
        {
            string sql = "DELETE FROM " + TableCTName + " WHERE MaPhieuNhapKho = @MaPNK AND MaTL = @MaTL";

            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaPNK", maPNK),
                new SqlParameter("@MaTL", maTL)
            };

            DatabaseLayer.RunSqlDel(sql, sqlParams);
        }
    }
}
