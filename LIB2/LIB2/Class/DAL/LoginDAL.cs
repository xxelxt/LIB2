using LIB2.Class.Types;
using LIB2.Database;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class LoginDAL
    {
        // UserRole? means it's a Nullable<UserRole>
        public static UserRole? TryLogin(string username, string password)
        {
            string sqlCheckKey = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";
            SqlParameter[] checkKeyParams = {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheckKey, checkKeyParams);

            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["Quyen"].Equals(1) ? UserRole.Admin : UserRole.User;
            }
            else
            {
                return null;
            };
        }
    }
}
