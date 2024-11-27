using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class TaiKhoanDAL
    {
        private static readonly string TableName = "TaiKhoan";

        public static DataTable GetAllTaiKhoan()
        {
            string sql = @"SELECT TK.*, NV.MaNV, NV.TenNV FROM TaiKhoan TK INNER JOIN NhanVien NV ON TK.TenDangNhap = NV.TenDangNhap";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetTenDangNhap()
        {
            string sql = @"SELECT TenDangNhap FROM TaiKhoan";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetTaiKhoanBySearch(string search)
        {
            string sql = @"SELECT TK.*, NV.MaNV, NV.TenNV FROM TaiKhoan TK INNER JOIN NhanVien NV ON TK.TenDangNhap = NV.TenDangNhap 
                           WHERE TenDangNhap LIKE '%" + search + "%' OR NV.TenNV LIKE '%" + search + "%'";

            return DatabaseLayer.GetDataToTable(sql);
        }
        public static void InsertTaiKhoan(string username, string password, int priv, string maNV)
        {
            string sqlCheckKey = "SELECT TenDangNhap FROM " + TableName + " WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] checkKeyParams = { new SqlParameter("@TenDangNhap", username) };

            if (DatabaseLayer.CheckKey(sqlCheckKey, checkKeyParams))
            {
                throw new Exception("Tài khoản đã tồn tại");
            }

            string sqlInsert = "INSERT INTO " + TableName + " (TenDangNhap, MatKhau, Quyen) VALUES (@TenDangNhap, @MatKhau, @Quyen)";
            SqlParameter[] insertParams = {
                new SqlParameter("@TenDangNhap", username),
                new SqlParameter("@MatKhau", password),
                new SqlParameter("@Quyen", priv)
            };

            DatabaseLayer.RunSql(sqlInsert, insertParams);
        }

        public static void UpdateTaiKhoan(string username, string password, int priv, string maNV)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MatKhau = @MatKhau, Quyen = @Quyen WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] updateParams = {
                new SqlParameter("@MatKhau", password),
                new SqlParameter("@Quyen", priv),
                new SqlParameter("@TenDangNhap", username)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);

            string _maNV = maNV;
            string _username = username;

            UpdateTKNhanVien(username, maNV);
        }

        public static void DeleteTaiKhoan(string username)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] deleteParams = { new SqlParameter("@TenDangNhap", username) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void UpdateTKNhanVien(string username, string maNV)
        {
            string sqlUpdate = "UPDATE NhanVien SET TenDangNhap = @TenDangNhap WHERE MaNV = @MaNV";
            SqlParameter[] updateParams = {
                new SqlParameter("@TenDangNhap", username),
                new SqlParameter("@MaNV", maNV),
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }
    }
}
