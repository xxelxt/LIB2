using LIB2.Class;
using LIB2.DAL;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using ExcelDataReader;
using System.IO;

namespace LIB2.Forms
{
    public partial class frmBanDocFile : MaterialForm
    {
        private DataTable tblBanDocFile;

        public frmBanDocFile()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {
            listViewBDFile.FullRowSelect = true;
            listViewBDFile.MultiSelect = false;
            listViewBDFile.UseCompatibleStateImageBehavior = false;
            listViewBDFile.View = View.Details;

            listViewBDFile.Columns.Add("MaBD", "Mã bạn đọc");
            listViewBDFile.Columns.Add("TenBD", "Tên bạn đọc");
            listViewBDFile.Columns.Add("NgaySinh", "Ngày sinh");
            listViewBDFile.Columns.Add("Khoa", "Khoá");
            listViewBDFile.Columns.Add("LopNC", "Lớp niên chế");
            listViewBDFile.Columns.Add("GioiTinh", "Giới tính");
            listViewBDFile.Columns.Add("Email", "Email");
            listViewBDFile.Columns.Add("SDT", "Số điện thoại");
            listViewBDFile.Columns.Add("TTRaVao", "Trạng thái ra vào");
            listViewBDFile.Columns.Add("MaKhoa", "Mã khoa");
        }

        private void frmBanDocFile_Load(object sender, EventArgs e)
        {
            txtFilePath.Enabled = false;
        }

        private void txtFilePath_Enter(object sender, EventArgs e)
        {
            if (txtFilePath.Text == "")
            {
                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
            }
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewBDFile.ClientSize.Width;
            double col1Percentage = 0.1;
            double col2Percentage = 0.2;
            double col3Percentage = 0.1;
            double col4Percentage = 0.1;
            double col5Percentage = 0.1;
            double col6Percentage = 0.15;
            double col7Percentage = 0.15;
            double col8Percentage = 0.15;
            double col9Percentage = 0.15;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);
            int col5Width = (int)(totalWidth * col5Percentage);
            int col6Width = (int)(totalWidth * col6Percentage);
            int col7Width = (int)(totalWidth * col7Percentage);
            int col8Width = (int)(totalWidth * col8Percentage);
            int col9Width = (int)(totalWidth * col9Percentage);

            listViewBDFile.Columns[0].Width = col1Width;
            listViewBDFile.Columns[1].Width = col2Width;
            listViewBDFile.Columns[2].Width = col3Width;
            listViewBDFile.Columns[3].Width = col4Width;
            listViewBDFile.Columns[4].Width = col5Width;
            listViewBDFile.Columns[5].Width = col6Width;
            listViewBDFile.Columns[6].Width = col7Width;
            listViewBDFile.Columns[7].Width = col8Width;
            listViewBDFile.Columns[8].Width = col9Width;
        }

        private void LoadListView()
        {
            ClearListView();

            foreach (DataRow row in tblBanDocFile.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaBD"].ToString());
                item.SubItems.Add(row["TenBD"].ToString());

                DateTime ngaySinh;
                if (DateTime.TryParse(row["NgaySinh"].ToString(), out ngaySinh))
                {
                    string ngaySinhFormatted = ngaySinh.ToString("dd/MM/yyyy");

                    item.SubItems.Add(ngaySinhFormatted);
                }
                else
                {
                    item.SubItems.Add("");
                }

                item.SubItems.Add(row["Khoa"].ToString());
                item.SubItems.Add(row["LopNC"].ToString());

                string gioiTinh = "";
                if (row["GioiTinh"] != null && row["GioiTinh"] != DBNull.Value)
                {
                    bool gioiTinhValue = Convert.ToBoolean(row["GioiTinh"]);
                    gioiTinh = gioiTinhValue ? "Nam" : "Nữ";
                }
                else
                {
                    gioiTinh = "";
                }

                item.SubItems.Add(gioiTinh);

                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["SDT"].ToString());

                string ttRaVao = "";
                if (row["TTRaVao"] != null && row["GioiTinh"] != DBNull.Value)
                {
                    bool ttRaVaoValue = Convert.ToBoolean(row["TTRaVao"]);
                    ttRaVao = ttRaVaoValue ? "Đang ở trong thư viện" : "Không ở trong thư viện";
                }
                else
                {
                    ttRaVao = "";
                }

                item.SubItems.Add(ttRaVao); 
                
                item.SubItems.Add(row["MaKhoa"].ToString());

                listViewBDFile.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewBDFile.Items.Clear();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Tệp Excel|*.xlsx",
                Title = "Mở tệp Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtFilePath.Text = filePath;

                try
                {
                    tblBanDocFile = ReadExcelToDataTable(filePath);
                    LoadListView();
                    btnLuu.Enabled = true;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }

        public static DataTable ReadExcelToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable();

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var config = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };

                    var result = reader.AsDataSet(config);
                    if (result.Tables.Count > 0)
                    {
                        dataTable = result.Tables[0];

                        dataTable.Columns.Add("TTRaVao", typeof(int));
                        foreach (DataRow row in dataTable.Rows)
                        {
                            row["TTRaVao"] = 0;
                        }

                        if (dataTable.Columns.Contains("TenKhoa"))
                        {
                            dataTable.Columns.Add("MaKhoa", typeof(string));

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string tenKhoa = row["TenKhoa"].ToString();

                                string maKhoa = KhoaDAL.GetMaKhoaByTenKhoa(tenKhoa);
                                row["MaKhoa"] = maKhoa;
                            }

                            dataTable.Columns.Remove("TenKhoa");
                        }
                    }
                }
            }

            return dataTable;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tblBanDocFile.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            bool isSuccess = SaveBanDocData(tblBanDocFile);

            if (isSuccess)
            {
                Functions.HandleInfo("Thêm bạn đọc thành công");
                ClearListView();
                txtFilePath.Text = "";
            }
        }

        private bool SaveBanDocData(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                string maBD = row["MaBD"].ToString();
                string tenBD = row["TenBD"].ToString();

                DateTime ngaySinh;
                if (!DateTime.TryParse(row["NgaySinh"].ToString(), out ngaySinh))
                {
                    Functions.HandleWarning("Ngày sinh không hợp lệ cho mã bạn đọc " + maBD);
                    return false;
                }

                string khoa = row["Khoa"].ToString();
                string lopNC = row["LopNC"].ToString();

                bool gioiTinh = row["GioiTinh"].ToString() == "Nam" ? true : false;
                string email = row["Email"].ToString();
                string sdt = row["SDT"].ToString();
                bool ttRaVao = row["TTRaVao"].ToString() == "Đang ở trong thư viện" ? true : false;
                string maKhoa = row["MaKhoa"].ToString();

                try
                {
                    BanDocDAL.InsertBanDoc(maBD, tenBD, ngaySinh, khoa, lopNC, gioiTinh, email, sdt, maKhoa, ttRaVao);
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm bạn đọc: " + ex.Message);
                    return false;
                }
            }

            return true;
        }
    }
}
