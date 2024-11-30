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
    public partial class frmTaiKhoan : MaterialForm
    {
        private DataTable tblTaiKhoan;

        private bool isSearching = false;
        private string currentSearchKeyword = "";

        public frmTaiKhoan()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();

            string fillComboNV = "SELECT * FROM NhanVien";
            DatabaseLayer.FillCombo(fillComboNV, cboTenNV, "MaNV", "TenNV");
            cboTenNV.SelectedItem = null;
        }

        private void InitializeListView()
        {
            listViewTK.FullRowSelect = true;
            listViewTK.MultiSelect = false;
            listViewTK.UseCompatibleStateImageBehavior = false;
            listViewTK.View = View.Details;

            listViewTK.Columns.Add("TenDangNhap", "Tên đăng nhập");
            listViewTK.Columns.Add("Quyen", "Quyền sử dụng");
            listViewTK.Columns.Add("TenNV", "Nhân viên sử dụng");
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            DisableAllFields();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            cboPriv.Items.Add("Quản lý");
            cboPriv.Items.Add("Nhân viên");

            cboPriv.SelectedItem = null;
            cboPriv.Text = "";

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;

            txtMaNV.Enabled = false;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewTK.ClientSize.Width;

            double col1Percentage = 0.3;
            double col2Percentage = 0.3;
            double col3Percentage = 0.4;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);

            listViewTK.Columns[0].Width = col1Width;
            listViewTK.Columns[1].Width = col2Width;
            listViewTK.Columns[2].Width = col3Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblTaiKhoan = TaiKhoanDAL.GetTaiKhoanBySearch(currentSearchKeyword);
                else
                    tblTaiKhoan = TaiKhoanDAL.GetAllTaiKhoan();

                LoadListView();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // private Dictionary<string, string> passwordMap = new Dictionary<string, string>();

        private void LoadListView()
        {
            ClearListView();

            foreach (DataRow row in tblTaiKhoan.Rows)
            {
                ListViewItem item = new ListViewItem(row["TenDangNhap"].ToString());

                item.Tag = Tuple.Create(row["MatKhau"].ToString(), row["MaNV"].ToString());

                item.SubItems.Add(row["Quyen"].ToString());
                item.SubItems.Add(row["TenNV"].ToString());
                listViewTK.Items.Add(item);
            }

            AdjustColumnWidth();
        }
        private void ClearListView()
        {
            listViewTK.Items.Clear();
        }

        private void listViewTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtUsername.Focus();
                return;
            }

            if (tblTaiKhoan.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewTK.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTK.SelectedItems[0];
                txtUsername.Text = selectedItem.SubItems[0].Text;

                // Trích xuất MatKhau và MaNV từ Tag
                var tagData = selectedItem.Tag as Tuple<string, string>;
                if (tagData != null)
                {
                    txtPassword.Text = tagData.Item1;
                    txtMaNV.Text = tagData.Item2;
                }

                string maNV = selectedItem.Tag as string;
                txtMaNV.Text = maNV;

                string quyenValue = selectedItem.SubItems[1].Text;

                if (quyenValue == "1")
                {
                    cboPriv.SelectedItem = "Quản lý";
                }
                else if (quyenValue == "0")
                {
                    cboPriv.SelectedItem = "Nhân viên";
                }

                cboTenNV.Text = DatabaseLayer.GetFieldValues("SELECT TenNV FROM NhanVien WHERE MaNV = N'" + selectedItem.SubItems[2].Text + "';");

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                ResetValues();
            }
        }

        private void ResetValues()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cboPriv.SelectedItem = null;
            cboPriv.Text = "";

        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên đăng nhập");
                txtUsername.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mật khẩu");
                txtPassword.Focus();
                return false;
            }

            if (cboPriv.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn quyền sử dụng");
                cboPriv.Focus();
                return false;
            }

            if (cboTenNV.SelectedItem == null && string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                Functions.HandleWarning("Bạn phải chọn nhân viên sử dụng");
                cboTenNV.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;

            btnLuu.Enabled = true;
            ResetValues();
            EnableAllFields();
            txtUsername.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewTK.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }

            if (ValidateInput())
            {
                string username = txtUsername.Text.Trim();
                string password = Functions.ComputeSha256Hash(txtPassword.Text.Trim());
                string privStr = cboPriv.SelectedItem.ToString();

                string maNV = txtMaNV.Text.Trim();

                int priv = -1;

                if (privStr == "Quản lý")
                {
                    priv = 1;
                }
                else if (privStr == "Nhân viên")
                {
                    priv = 0;
                }

                try
                {
                    TaiKhoanDAL.UpdateTaiKhoan(username, password, priv, maNV);
                    TaiKhoanDAL.UpdateTKNhanVien(username, maNV);
                    Functions.HandleInfo("Cập nhật tài khoản thành công");
                    LoadData();
                    ResetValues();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi cập nhật tài khoản: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (!string.IsNullOrEmpty(username))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        TaiKhoanDAL.DeleteTaiKhoan(username);
                        Functions.HandleInfo("Xóa tài khoản thành công");
                        LoadData();
                        ResetValues();

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa tài khoản: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string username = txtUsername.Text.Trim();
                string password = Functions.ComputeSha256Hash(txtPassword.Text.Trim());
                string privStr = cboPriv.SelectedItem.ToString();

                string maNV = txtMaNV.Text.Trim();

                int priv = -1;

                if (privStr == "Quản lý")
                {
                    priv = 1;
                }
                else if (privStr == "Nhân viên")
                {
                    priv = 0;
                }

                try
                {
                    TaiKhoanDAL.InsertTaiKhoan(username, password, priv, maNV);
                    TaiKhoanDAL.UpdateTKNhanVien(username, maNV);
                    Functions.HandleInfo("Thêm tài khoản thành công");
                    LoadData();
                    ResetValues();

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    DisableAllFields();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm tài khoản: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            DisableAllFields();

            txtTimKiem.Text = "";
            isSearching = false;

            LoadData();
        }

        private void PerformSearch()
        {
            currentSearchKeyword = txtTimKiem.Text.Trim();
            isSearching = true;

            LoadData();

            btnHuy.Enabled = true;
        }

        private void DisableAllFields()
        {
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
        }

        private void EnableAllFields()
        {
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
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

        private void cboTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenNV.SelectedItem == null)
            {
                return;
            }

            string maNV = NhanVienDAL.GetMaNVByTenNV(cboTenNV.Text);
            txtMaNV.Text = maNV;
        }
    }
}
