﻿using LIB2.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LIB2.DAL
{
    internal class TaiLieuDAL
    {
        private static readonly string TableName = "TaiLieu";

        public static string InsertEmptyTaiLieu()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (MaLoaiAP) VALUES (NULL)";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaTaiLieu();
        }

        public static string GetLastMaTaiLieu()
        {
            string sql = "SELECT TOP 1 MaTL FROM " + TableName + " ORDER BY MaTL DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaTL"].ToString();
        }

        public static void DeleteEmptyTaiLieu(string maTL)
        {
            string sqlCheck = "SELECT MaLoaiAP FROM " + TableName + " WHERE MaTL = @MaTL";
            SqlParameter[] param = { new SqlParameter("@MaTL", maTL) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string maLoaiAP = dt.Rows[0]["MaLoaiAP"].ToString();

                if (!String.IsNullOrEmpty(maLoaiAP))
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaTL = @MaTL";
            SqlParameter[] deleteParams = { new SqlParameter("@MaTL", maTL) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static bool UpdateLoaiAnPham(string maTL, string maLoaiAP)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET MaLoaiAP = @MaLoaiAP WHERE MaTL = @MaTL";
            SqlParameter[] updateParams = {
                new SqlParameter("@MaLoaiAP", maLoaiAP),
                new SqlParameter("@MaTL", maTL),
            };

            int rowsAffected = DatabaseLayer.RunSqlWithResult(sqlUpdate, updateParams);

            return rowsAffected > 0;
        }

        public static bool DeleteTaiLieu(string maTL)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaTL = @MaTL";
            SqlParameter[] deleteParams = { new SqlParameter("@MaTL", maTL) };

            int rowsAffected = DatabaseLayer.RunSqlDelWithResult(sqlDelete, deleteParams);

            return rowsAffected > 0;
        }

        public static Tuple<string, string> GetTenGiaTLByMa(string maTL)
        {
            string query = $@"SELECT 
                                CASE 
                                    WHEN S.TenSach IS NOT NULL THEN S.TenSach 
                                    WHEN TCB.TieuDe IS NOT NULL THEN TCB.TieuDe 
                                    WHEN BL.TenDeTai IS NOT NULL THEN BL.TenDeTai 
                                    ELSE ''
                                END AS TenTaiLieu, 
                                CASE 
                                    WHEN S.DonGia IS NOT NULL THEN S.DonGia 
                                    WHEN TCB.DonGia IS NOT NULL THEN TCB.DonGia 
                                    ELSE 0 
                                END AS Gia 
                            FROM TaiLieu TL 
                            LEFT JOIN Sach S ON TL.MaTL = S.MaSach 
                            LEFT JOIN TapChiBao TCB ON TL.MaTL = TCB.MaTL 
                            LEFT JOIN BaiLuan BL ON TL.MaTL = BL.MaTL 
                            WHERE TL.MaTL = @MaTL;";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaTL", maTL)
            };

            DataTable dt = DatabaseLayer.GetDataToTable(query, parameters);

            if (dt.Rows.Count > 0)
            {
                string tenTL = dt.Rows[0]["TenTaiLieu"].ToString();
                string donGia = dt.Rows[0]["Gia"].ToString();
                return Tuple.Create(tenTL, donGia);
            }

            return null;
        }
    }
}
