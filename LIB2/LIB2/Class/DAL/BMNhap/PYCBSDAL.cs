using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Markup;

namespace LIB2.DAL
{
    internal class PYCBSDAL
    {
        private static readonly string TableName = "PhieuYCBS";
        private static readonly string TableCTName = "CTPhieuYCBS";

        public static DataTable GetAllPYCBS()
        {
            string sql = $@"SELECT P.MaPhieuYCBS, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet, P.TrangThai 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetCTPYCBS(string maPYCBS)
        {
            string sql = $@"SELECT 
                                CT.MaPhieuYCBS, 
                                CT.TenTL, 
                                CT.TacGia, 
                                CT.NhaXuatBan, 
                                CT.NamXuatBan, 
                                CT.MoTa, 
                                CT.LoaiAnPham, 
                                CT.SoLuong, 
                                CT.MucDoYC
                            FROM 
                                {TableCTName} CT
                            WHERE CT.MaPhieuYCBS = @MaPYCBS;";

            SqlParameter[] param = { new SqlParameter("@MaPYCBS", maPYCBS) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }

        public static DataTable GetThongTinPYCBS(string maPYCBS)
        {
            string sql = $@"SELECT P.MaPhieuYCBS, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet, P.TrangThai 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV 
                            WHERE P.MaPhieuYCBS = @MaPYCBS";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaPYCBS", maPYCBS)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParams);
        }

        public static DataTable GetPYCBSBySearch(string searchOption, string searchKeyword)
        {
            string sql = $@"SELECT P.MaPhieuYCBS, P.MaNVLap, NV1.TenNV AS TenNVLap, P.MaNVDuyet, NV2.TenNV AS TenNVDuyet, P.NgayLap, P.NgayDuyet, P.TrangThai 
                            FROM {TableName} P 
                            INNER JOIN NhanVien NV1 ON P.MaNVLap = NV1.MaNV 
                            LEFT JOIN NhanVien NV2 ON P.MaNVDuyet = NV2.MaNV ";

            DateTime parsedDate;
            bool isDate = DateTime.TryParseExact(searchKeyword, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            switch (searchOption)
            {
                case "Mã phiếu":
                    sql += $"WHERE P.MaPhieuYCBS LIKE '%{searchKeyword}%'";
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

        public static void DeletePYCBS(string maPYCBS)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaPhieuYCBS = @MaPYCBS";
            SqlParameter[] deleteParams = { new SqlParameter("@MaPYCBS", maPYCBS) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void DeleteCTPYCBS(string maPYCBS)
        {
            string sqlDelete = "DELETE FROM " + TableCTName + " WHERE MaPhieuYCBS = @MaPYCBS";
            SqlParameter[] deleteParams = { new SqlParameter("@MaPYCBS", maPYCBS) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool CheckMaPYCBSExists(string maPYCBS)
        {
            string sql = "SELECT MaPhieuYCBS FROM " + TableName + " + WHERE MaPhieuYCBS = @MaPYCBS";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaPYCBS", maPYCBS)
            };

            return DatabaseLayer.CheckKey(sql, sqlParams);
        }

        public static string InsertEmptyPYCBS()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (NgayLap) VALUES ('01/01/2000')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaPYCBS();
        }

        public static string GetLastMaPYCBS()
        {
            string sql = "SELECT TOP 1 MaPhieuYCBS FROM " + TableName + " ORDER BY MaPhieuYCBS DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaPhieuYCBS"].ToString();
        }

        public static void DeleteEmptyPYCBS(string maPYCBS)
        {
            string sqlCheck = "SELECT NgayLap FROM " + TableName + " WHERE MaPhieuYCBS = @MaPYCBS AND NgayLap = '01/01/2000'";

            SqlParameter[] sqlParams = { new SqlParameter("@MaPYCBS", maPYCBS) };

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

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaPhieuYCBS = @MaPYCBS";
            string sqlDeleteCT = "DELETE FROM " + TableCTName + " WHERE MaPhieuYCBS = @MaPYCBS";

            SqlParameter[] parameters = { new SqlParameter("@MaPYCBS", maPYCBS) };
            SqlParameter[] parametersCT = { new SqlParameter("@MaPYCBS", maPYCBS) };

            DatabaseLayer.RunSqlDel(sqlDeleteCT, parametersCT);
            DatabaseLayer.RunSqlDel(sqlDelete, parameters);
        }

        public static void UpdatePYCBS(string maPYCBS, string maNVLap, DateTime ngayLap)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVLap = @MaNVLap, NgayLap = @NgayLap WHERE MaPhieuYCBS = @MaPYCBS";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVLap", maNVLap),
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@MaPYCBS", maPYCBS)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DuyetPYCBS(string maPYCBS, string maNVDuyet, DateTime ngayDuyet, bool trangThai)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVDuyet = @MaNVDuyet, NgayDuyet = @NgayDuyet, TrangThai = @TrangThai WHERE MaPhieuYCBS = @MaPYCBS";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVDuyet", maNVDuyet),
                new SqlParameter("@NgayDuyet", ngayDuyet),
                new SqlParameter("TrangThai", trangThai),
                new SqlParameter("@MaPYCBS", maPYCBS)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void KhongDuyetPYCBS(string maPYCBS, string maNVDuyet, bool trangThai)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaNVDuyet = @MaNVDuyet, TrangThai = @TrangThai WHERE MaPhieuYCBS = @MaPYCBS";
            SqlParameter[] updateParams =
            {
                new SqlParameter("@MaNVDuyet", maNVDuyet),
                new SqlParameter("TrangThai", trangThai),
                new SqlParameter("@MaPYCBS", maPYCBS)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void InsertTaiLieuCTPYCBS(string maPYCBS, string tenTL, string tacGia, string nhaXB, int namXB, string moTa, string loaiAnPham, int soLuong, string mucDoYC)
        {
            string sql = "INSERT INTO " + TableCTName + " (MaPhieuYCBS, TenTL, TacGia, NhaXuatBan, NamXuatBan, MoTa, LoaiAnPham, SoLuong, MucDoYC) " +
                "VALUES (@MaPYCBS, @TenTL, @TacGia, @NhaXB, @NamXB, @MoTa, @LoaiAnPham, @SoLuong, @MucDoYC)";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaPYCBS", maPYCBS),
                new SqlParameter("@TenTL", tenTL),
                new SqlParameter("@TacGia", tacGia),
                new SqlParameter("@NhaXB", nhaXB),
                new SqlParameter("@NamXB", namXB),
                new SqlParameter("@MoTa", moTa),
                new SqlParameter("@LoaiAnPham", loaiAnPham),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@MucDoYC", mucDoYC)
            };

            DatabaseLayer.RunSql(sql, sqlParams);
        }


        public static void DeleteTaiLieuCTPYCBS(string maPYCBS, string tenTL)
        {
            string sql = "DELETE FROM " + TableCTName + " WHERE MaPhieuYCBS = @MaPYCBS AND TenTL = @TenTL";

            SqlParameter[] sqlParams =
            {
                new SqlParameter("@MaPYCBS", maPYCBS),
                new SqlParameter("@TenTL", tenTL)
            };

            DatabaseLayer.RunSqlDel(sql, sqlParams);
        }
    }
}