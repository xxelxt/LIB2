using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class BCKKDAL
    {
        private static readonly string TableName = "BCKiemKe";
        private static readonly string TableCTName = "CTBCKiemKe";

        public static DataTable GetAllBCKK()
        {
            string sql = $@"SELECT P.MaBCKiemKe, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.MaPhieuKiemKe, P.MaDMSuaChua, P.MaDMBoiThuong, P.NgayLap, P.NgayDuyet, P.TrangThai 
                                P.TGBD, P.TGKT, P.SoTLXepNhamKho, P.SoTLMat, P.TongTienTLMat, P.SoTLSuaChua, P.SoTLBoiThuong, P.TongTienBoiThuong 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV 
                            INNER JOIN PhieuKiemKe PKK ON P.MaPhieuKiemKe = PKK.MaPhieuKiemKe 
                            INNER JOIN DMSuaChua DMSC ON P.MaDMSuaChua = DMSC.MaDMSuaChua 
                            INNER JOIN DMBoiThuong DMBT ON P.MaDMBoiThuong = DMBT.MaDMBoiThuong ";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetCTBCKK(string maBCKK)
        {
            string sql = $@"SELECT 
                            CT.MaBCKiemKe, 
                            CT.MaKho, 
                            K.TenKho, 
                            CT.SoTL, 
                            CT.SoBanTL 
                        FROM 
                            {TableCTName} CT 
                        INNER JOIN Kho K ON CT.MaKho = K.MaKho 
                        WHERE CT.MaBCKiemKe = @MaBCKK;";

            SqlParameter[] param = { new SqlParameter("@MaBCKK", maBCKK) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }

        public static DataTable GetThongTinBCKK(string maBCKK)
        {
            string sql = $@"SELECT P.MaBCKiemKe, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.MaPhieuKiemKe, P.MaDMSuaChua, P.MaDMBoiThuong, P.NgayLap, P.NgayDuyet, P.TrangThai 
                                P.TGBD, P.TGKT, P.SoTLXepNhamKho, P.SoTLMat, P.TongTienTLMat, P.SoTLSuaChua, P.SoTLBoiThuong, P.TongTienBoiThuong 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV 
                            INNER JOIN PhieuKiemKe PKK ON P.MaPhieuKiemKe = PKK.MaPhieuKiemKe 
                            INNER JOIN DMSuaChua DMSC ON P.MaDMSuaChua = DMSC.MaDMSuaChua 
                            INNER JOIN DMBoiThuong DMBT ON P.MaDMBoiThuong = DMBT.MaDMBoiThuong 
                            WHERE P.MaBCKiemKe = @MaBCKK";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaBCKK", maBCKK)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParams);
        }

        public static DataTable GetBCKKBySearch(string searchOption, string searchKeyword)
        {
            string sql = $@"SELECT P.MaBCKiemKe, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.MaPhieuKiemKe, P.MaDMSuaChua, P.MaDMBoiThuong, P.NgayLap, P.NgayDuyet, P.TrangThai 
                                P.TGBD, P.TGKT, P.SoTLXepNhamKho, P.SoTLMat, P.TongTienTLMat, P.SoTLSuaChua, P.SoTLBoiThuong, P.TongTienBoiThuong 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV 
                            INNER JOIN PhieuKiemKe PKK ON P.MaPhieuKiemKe = PKK.MaPhieuKiemKe 
                            INNER JOIN DMSuaChua DMSC ON P.MaDMSuaChua = DMSC.MaDMSuaChua 
                            INNER JOIN DMBoiThuong DMBT ON P.MaDMBoiThuong = DMBT.MaDMBoiThuong ";

            DateTime parsedDate;
            bool isDate = DateTime.TryParseExact(searchKeyword, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            switch (searchOption)
            {
                case "Mã danh mục":
                    sql += $"WHERE P.MaBCKiemKe LIKE '%{searchKeyword}%'";
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

        public static void DeleteBCKK(string maBCKK)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaBCKiemKe = @MaBCKK";
            SqlParameter[] deleteParams = { new SqlParameter("@MaBCKK", maBCKK) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void DeleteCTBCKK(string maBCKK)
        {
            string sqlDelete = "DELETE FROM " + TableCTName + " WHERE MaBCKiemKe = @MaBCKK";
            SqlParameter[] deleteParams = { new SqlParameter("@MaBCKK", maBCKK) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool CheckMaBCKKExists(string maBCKK)
        {
            string sql = "SELECT MaBCKiemKe FROM " + TableName + " + WHERE MaBCKiemKe = @MaBCKK";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaBCKK", maBCKK)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static string InsertEmptyBCKK()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (NgayLap, TGBD, TGKT, SoTLXepNhamKho, SoTLMat, TongTienTLMat, " +
                "SoTLSuaChua, SoTLBoiThuong, TongTienBoiThuong) VALUES ('01/01/2000', '01/01/2000', '01/01/2000', 0, 0, 0, 0, 0, 0)";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaBCKK();
        }

        public static string GetLastMaBCKK()
        {
            string sql = "SELECT TOP 1 MaBCKiemKe FROM " + TableName + " ORDER BY MaBCKiemKe DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaBCKiemKe"].ToString();
        }

        public static void DeleteEmptyBCKK(string maBCKK)
        {
            string sqlCheck = "SELECT NgayLap FROM " + TableName + " WHERE MaBCKiemKe = @MaBCKK AND NgayLap = '01/01/2000'";

            SqlParameter[] sqlParams = { new SqlParameter("@MaBCKK", maBCKK) };

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

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaBCKiemKe = @MaBCKK";
            string sqlDeleteCT = "DELETE FROM " + TableCTName + " WHERE MaBCKiemKe = @MaBCKK";

            SqlParameter[] parameters = { new SqlParameter("@MaBCKK", maBCKK) };
            SqlParameter[] parametersCT = { new SqlParameter("@MaBCKK", maBCKK) };

            DatabaseLayer.RunSqlDel(sqlDeleteCT, parametersCT);
            DatabaseLayer.RunSqlDel(sqlDelete, parameters);
        }

        public static void UpdateBCKK(string maBCKK, string maNVLap, string maPKK, string maDMSC, string maDMBT,
            DateTime ngayLap, DateTime TGBD, DateTime TGKT,
            int soTLXepNham, int soTLMat, int tongTienTLMat, int soTLSuaChua, int soTLBoiThuong, int tongTienBoiThuong)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVLap = @MaNVLap, " +
                "MaPhieuKiemKe = @MaPKK, MaDMSuaChua = @MaDMSC, MaDMBoiThuong = @MaDMBT, " +
                "NgayLap = @NgayLap, TGBD = @TGBD, TGKT = @TGKT, " +
                "SoTLXepNhamKho = @SoTLXepNhamKho, SoTLMat = @SoTLMat, TongTienTLMat = @TongTienTLMat, " +
                "SoTLSuaChua = @SoTLSuaChua, SoTLBoiThuong = @SoTLBoiThuong, TongTienBoiThuong = @TongTienBoiThuong " +
                "WHERE MaBCKiemKe = @MaBCKK";

            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVLap", maNVLap),
                new SqlParameter("@MaPKK", maPKK),
                new SqlParameter("@MaDMSC", maDMSC),
                new SqlParameter("@MaDMBT", maDMBT),
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@TGBD", TGBD),
                new SqlParameter("@TGKT", TGKT),
                new SqlParameter("@SoTLXepNhamKho", soTLXepNham),
                new SqlParameter("@SoTLMat", soTLMat),
                new SqlParameter("@TongTienTLMat", tongTienTLMat),
                new SqlParameter("@SoTLSuaChua", soTLSuaChua),
                new SqlParameter("@SoTLBoiThuong", soTLBoiThuong),
                new SqlParameter("@TongTienBoiThuong", tongTienBoiThuong),
                new SqlParameter("@MaBCKK", maBCKK)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DuyetBCKK(string maBCKK, string maNVDuyet, DateTime ngayDuyet, bool trangThai)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVDuyet = @MaNVDuyet, NgayDuyet = @NgayDuyet, TrangThai = @TrangThai WHERE MaBCKiemKe = @MaBCKK";

            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVDuyet", maNVDuyet),
                new SqlParameter("@NgayDuyet", ngayDuyet),
                new SqlParameter("TrangThai", trangThai),
                new SqlParameter("@MaBCKK", maBCKK)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void KhongDuyetBCKK(string maBCKK, string maNVDuyet, bool trangThai)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVDuyet = @MaNVDuyet, TrangThai = @TrangThai WHERE MaBCKiemKe = @MaBCKK";

            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVDuyet", maNVDuyet),
                new SqlParameter("TrangThai", trangThai),
                new SqlParameter("@MaBCKK", maBCKK)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void InsertKhoCTBCKK(string maBCKK, string maKho, int soTL, int soBanTL)
        {
            string sql = "INSERT INTO " + TableCTName + " (MaBCKiemKe, MaKho, SoTL, SoBanTL) VALUES (@MaBCKK, @MaKho, @SoTL, @SoBanTL)";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaBCKK", maBCKK),
                new SqlParameter("@MaKho", maKho),
                new SqlParameter("@SoTL", soTL),
                new SqlParameter("@SoBanTL", soBanTL),
            };

            DatabaseLayer.RunSql(sql, sqlParams);
        }

        public static bool CheckMaKho(string maBCKK, string maKho)
        {
            string sql = "SELECT MaKho FROM " + TableCTName + " WHERE MaBCKiemKe = @MaBCKK AND MaKho = @MaKho";
            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaBCKK", maBCKK),
                new SqlParameter("@MaKho", maKho)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static void DeleteKhoCTBCKK(string maBCKK, string maKho)
        {
            string sql = "DELETE FROM " + TableCTName + " WHERE MaBCKiemKe = @MaBCKK AND MaKho = @MaKho";

            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaBCKK", maBCKK),
                new SqlParameter("@MaKho", maKho)
            };

            DatabaseLayer.RunSqlDel(sql, sqlParams);
        }
    }
}
