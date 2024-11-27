using LIB2.Class;
using LIB2.DAL;
using LIB2.Database;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmBanDoc : MaterialForm
    {
        private DataTable tblBanDoc;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        public frmBanDoc()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();

            cboTimKiem.Items.Add("Mã bạn đọc");
            cboTimKiem.Items.Add("Tên bạn đọc");
            cboTimKiem.Items.Add("Lớp niên chế");
            cboTimKiem.Items.Add("Khoá");
            cboTimKiem.Items.Add("Khoa");
            cboTimKiem.Items.Add("Số điện thoại");
            cboTimKiem.Items.Add("Đang ở trong thư viện");
        }

        private void InitializeListView()
        {
            listViewBD.FullRowSelect = true;
            listViewBD.MultiSelect = false;
            listViewBD.UseCompatibleStateImageBehavior = false;
            listViewBD.View = View.Details;

            listViewBD.Columns.Add("MaBD", "Mã bạn đọc");
            listViewBD.Columns.Add("TenBD", "Tên bạn đọc");
            listViewBD.Columns.Add("NgaySinh", "Ngày sinh");
            listViewBD.Columns.Add("Khoa", "Khoá");
            listViewBD.Columns.Add("LopNC", "Lớp niên chế");
            listViewBD.Columns.Add("GioiTinh", "Giới tính");
            listViewBD.Columns.Add("Email", "Email");
            listViewBD.Columns.Add("SDT", "Số điện thoại");
            listViewBD.Columns.Add("TTRaVao", "Trạng thái ra vào");
            listViewBD.Columns.Add("MaKhoa", "Mã khoa");
        }

        private void frmBanDoc_Load(object sender, EventArgs e)
        {
            DisableAllFields();

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;

            btnHuy.Enabled = false;
        }

        private void DisableAllFields()
        {
            txtMaBD.Enabled = false;
            txtTenBD.Enabled = false;
            txtNgaySinh.Enabled = false;

            rdoNam.Enabled = false;
            rdoNu.Enabled = false;
            
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;

            txtKhoas.Enabled = false;
            txtKhoa.Enabled = false;
            txtLopNC.Enabled = false;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewBD.ClientSize.Width;
            double col1Percentage = 0.1;
            double col2Percentage = 0.2;
            double col3Percentage = 0.1;
            double col4Percentage = 0.1;
            double col5Percentage = 0.1;
            double col6Percentage = 0.15;
            double col7Percentage = 0.15;
            double col8Percentage = 0.15;
            double col9Percentage = 0.15;
            double col10Percentage = 0.15;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);
            int col5Width = (int)(totalWidth * col5Percentage);
            int col6Width = (int)(totalWidth * col6Percentage);
            int col7Width = (int)(totalWidth * col7Percentage);
            int col8Width = (int)(totalWidth * col8Percentage);
            int col9Width = (int)(totalWidth * col9Percentage);
            int col10Width = (int)(totalWidth * col10Percentage);

            listViewBD.Columns[0].Width = col1Width;
            listViewBD.Columns[1].Width = col2Width;
            listViewBD.Columns[2].Width = col3Width;
            listViewBD.Columns[3].Width = col4Width;
            listViewBD.Columns[4].Width = col5Width;
            listViewBD.Columns[5].Width = col6Width;
            listViewBD.Columns[6].Width = col7Width;
            listViewBD.Columns[7].Width = col8Width;
            listViewBD.Columns[8].Width = col9Width;
            listViewBD.Columns[9].Width = col10Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblBanDoc = BanDocDAL.GetBanDocBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblBanDoc = BanDocDAL.GetAllBanDoc();

                LoadListView();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadListView()
        {
            ClearListView();

            foreach (DataRow row in tblBanDoc.Rows)
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

                listViewBD.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewBD.Items.Clear();
        }

        private void listViewBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblBanDoc.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewBD.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewBD.SelectedItems[0];
                txtMaBD.Text = selectedItem.SubItems[0].Text;
                txtTenBD.Text = selectedItem.SubItems[1].Text;

                string ngaySinhStr = selectedItem.SubItems[2].Text;
                DateTime ngaySinh;
                if (DateTime.TryParse(ngaySinhStr, out ngaySinh))
                {
                    txtNgaySinh.Text = ngaySinh.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtNgaySinh.Text = "";
                }

                txtKhoas.Text = selectedItem.SubItems[3].Text;
                txtLopNC.Text = selectedItem.SubItems[4].Text;

                if (selectedItem.SubItems[5].Text == "Nam")
                {
                    rdoNam.Checked = true;
                    rdoNu.Checked = false;
                }
                else if (selectedItem.SubItems[5].Text == "Nữ")
                {
                    rdoNam.Checked = false;
                    rdoNu.Checked = true;
                }

                txtEmail.Text = selectedItem.SubItems[6].Text;
                txtSDT.Text = selectedItem.SubItems[7].Text;

                if (selectedItem.SubItems[8].Text == "Đang ở trong thư viện")
                {
                    lblRaVao.Text = "Đang ở trong thư viện";
                }
                else if (selectedItem.SubItems[8].Text == "Không ở trong thư viện")
                {
                    lblRaVao.Text = "Không ở trong thư viện";
                }

                txtKhoa.Text = BanDocDAL.GetTenKhoaByMaBanDoc(selectedItem.SubItems[0].Text);

                btnHuy.Enabled = true;
            }
            else
            {
                ResetValues();

                btnHuy.Enabled = false;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            var childFormBanDocFile = new frmBanDocFile();
            childFormBanDocFile.Show();
        }

        private void ResetValues()
        {
            txtMaBD.Text = "";
            txtTenBD.Text = "";

            txtNgaySinh.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtKhoa.Text = "";
            txtKhoas.Text = "";
            txtLopNC.Text = "";

            rdoNam.Checked = false;
            rdoNu.Checked = false;

            lblRaVao.Text = "Trạng thái ra vào";
        }

        private void PerformSearch()
        {
            currentSearchOption = cboTimKiem.Text;
            currentSearchKeyword = txtTimKiem.Text.Trim();
            isSearching = true;

            LoadData();

            btnHuy.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch();
                e.SuppressKeyPress = true;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập từ khóa tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "Đang ở trong thư viện")
            {
                txtTimKiem.Enabled = false;
                txtTimKiem.Text = "";
            }
            else
            {
                txtTimKiem.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();

            btnHuy.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            LoadData();
        }
    }
}