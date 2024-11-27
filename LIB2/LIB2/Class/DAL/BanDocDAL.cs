using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LIB2.DAL
{
    internal class BanDocDAL
    {
        private static readonly string TableName = "BanDoc";

        public static DataTable GetAllBanDoc()
        {
            string sql = @"SELECT * FROM BanDoc";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetBanDocBySearch(string searchOption, string searchKeyword)
        {
            string sql = @"SELECT BD.* FROM BanDoc BD ";

            switch (searchOption)
            {
                case "Mã bạn đọc":
                    sql += $"WHERE BD.MaBD LIKE '%{searchKeyword}%';";
                    break;
                case "Tên bạn đọc":
                    sql += $"WHERE BD.TenBD LIKE N'%{searchKeyword}%';";
                    break;
                case "Lớp niên chế":
                    sql += $"WHERE BD.LopNC LIKE N'%{searchKeyword}%';";
                    break;
                case "Khoá":
                    sql += $"WHERE BD.Khoa LIKE N'%{searchKeyword}%';";
                    break;
                case "Khoa":
                    sql += $"INNER JOIN Khoa ON Khoa.MaKhoa = BD.MaKhoa WHERE Khoa.TenKhoa LIKE N'%{searchKeyword}%';";
                    break;
                case "Số điên thoại":
                    sql += $"WHERE BD.SDT LIKE N'%{searchKeyword}%';";
                    break;
                case "Đang ở trong thư viện":
                    sql += $"WHERE BD.TTRaVao = 1;";
                    break;
                default:
                    throw new ArgumentException("Không có tuỳ chọn tìm kiếm");
            }

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static void InsertBanDoc(string maBD, string tenBD, DateTime ngaySinh, string khoa, string lopNC, bool gioiTinh, 
            string email, string SDT, string maKhoa, bool ttRaVao = false)
        {
            string sqlInsert = @"
                INSERT INTO BanDoc 
                (MaBD, TenBD, NgaySinh, Khoa, LopNC, GioiTinh, Email, SDT, TTRaVao, MaKhoa) 
                VALUES 
                (@MaBD, @TenBD, @NgaySinh, @Khoa, @LopNC, @GioiTinh, @Email, @SDT, @TTRaVao, @MaKhoa)";

            SqlParameter[] insertParams = {
                new SqlParameter("@MaBD", maBD),
                new SqlParameter("@TenBD", tenBD),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@Khoa", khoa),
                new SqlParameter("@LopNC", lopNC),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@Email", email),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@TTRaVao", ttRaVao),
                new SqlParameter("@MaKhoa", maKhoa)
            };

            DatabaseLayer.RunSql(sqlInsert, insertParams);
        }

        public static string GetTenKhoaByMaBanDoc(string maBD)
        {
            string query = "SELECT TenKhoa FROM Khoa K INNER JOIN BanDoc BD ON K.MaKhoa = BD.MaKhoa WHERE MaBD = @MaBD";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaBD", maBD)
            };

            DataTable dt = DatabaseLayer.GetDataToTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["TenKhoa"].ToString();
            }

            return string.Empty;
        }

        public static DataTable GetBanDocByMa(string maBD)
        {
            string sql = @"SELECT BD.*, K.TenKhoa FROM BanDoc BD INNER JOIN Khoa K ON K.MaKhoa = BD.MaKhoa WHERE MaBD = @MaBD";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaBD", maBD)
            };

            return DatabaseLayer.GetDataToTable(sql, parameters);
        }

        public static void CheckInOutBanDoc(string maBD, bool inOut)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TTRaVao = @TTRaVao WHERE MaBD = @MaBD";
            SqlParameter[] updateParams = {
                new SqlParameter("@TTRaVao", inOut),
                new SqlParameter("@MaBD", maBD)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static int GetSoBanDocTrongTV()
        {
            string query = "SELECT COUNT(MaBD) AS SoBD FROM BanDoc WHERE TTRaVao = 1;";

            DataTable dt = DatabaseLayer.GetDataToTable(query);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["SoBD"].ToString());
            }

            return -1;
        }
    }
}