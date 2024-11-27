using LIB2.Class;
using LIB2.DAL;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmNhaXuatBan : MaterialForm
    {
        private DataTable tblNhaXuatBan;

        private bool isSearching = false;
        private string currentSearchKeyword = "";

        public frmNhaXuatBan()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();
        }

        private void InitializeListView()
        {
            listViewNXB.FullRowSelect = true;
            listViewNXB.MultiSelect = false;
            listViewNXB.UseCompatibleStateImageBehavior = false;
            listViewNXB.View = View.Details;

            listViewNXB.Columns.Add("MaNXB", "Mã nhà xuất bản");
            listViewNXB.Columns.Add("TenNXB", "Tên nhà xuất bản");
            listViewNXB.Columns.Add("DiaChi", "Địa chỉ");
            listViewNXB.Columns.Add("Email", "Email");
            listViewNXB.Columns.Add("SDT", "Số điện thoại");
            listViewNXB.Columns.Add("Fax", "Fax");
        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            txtMaNXB.Enabled = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewNXB.ClientSize.Width;
            double col1Percentage = 0.1;
            double col2Percentage = 0.2;
            double col3Percentage = 0.3;
            double col4Percentage = 0.16;
            double col5Percentage = 0.13;
            double col6Percentage = 0.13;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);
            int col5Width = (int)(totalWidth * col5Percentage);
            int col6Width = (int)(totalWidth * col6Percentage);

            listViewNXB.Columns[0].Width = col1Width;
            listViewNXB.Columns[1].Width = col2Width;
            listViewNXB.Columns[2].Width = col3Width;
            listViewNXB.Columns[3].Width = col4Width;
            listViewNXB.Columns[4].Width = col5Width;
            listViewNXB.Columns[5].Width = col6Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblNhaXuatBan = NhaXuatBanDAL.GetNhaXuatBanBySearch(currentSearchKeyword);
                else
                    tblNhaXuatBan = NhaXuatBanDAL.GetAllNhaXuatBan();

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

            foreach (DataRow row in tblNhaXuatBan.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaNXB"].ToString());
                item.SubItems.Add(row["TenNXB"].ToString());
                item.SubItems.Add(row["DiaChi"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["SDT"].ToString());
                item.SubItems.Add(row["Fax"].ToString());
                listViewNXB.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewNXB.Items.Clear();
        }

        private void listViewNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaNXB.Focus();
                return;
            }

            if (tblNhaXuatBan.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewNXB.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewNXB.SelectedItems[0];
                txtMaNXB.Text = selectedItem.SubItems[0].Text;
                txtTenNXB.Text = selectedItem.SubItems[1].Text;
                txtDiaChi.Text = selectedItem.SubItems[2].Text;
                txtEmail.Text = selectedItem.SubItems[3].Text;
                txtSDT.Text = selectedItem.SubItems[4].Text;
                txtFax.Text = selectedItem.SubItems[5].Text;

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
            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtFax.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaNXB.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã nhà xuất bản");
                txtMaNXB.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtTenNXB.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên nhà xuất bản");
                txtTenNXB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                Functions.HandleWarning("Bạn phải nhập địa chỉ");
                txtDiaChi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                Functions.HandleWarning("Bạn phải nhập email");
                txtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                Functions.HandleWarning("Email không hợp lệ, vui lòng nhập lại");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số điện thoại");
                txtSDT.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return System.Text.RegularExpressions.Regex.IsMatch(email, emailRegex);
            }
            catch
            {
                return false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;

            btnLuu.Enabled = true;
            ResetValues();

            txtTenNXB.Focus();

            string newMaNXB = NhaXuatBanDAL.InsertEmptyNhaXuatBan();
            txtMaNXB.Text = newMaNXB;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewNXB.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }

            if (ValidateInput())
            {
                string maNXB = txtMaNXB.Text.Trim();
                string tenNXB = txtTenNXB.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string email = txtEmail.Text.Trim();

                string SDT = txtSDT.Text.Trim().Replace(" ", "");
                string fax = txtFax.Text.Trim().Replace(" ", "");

                try
                {
                    if (!string.IsNullOrEmpty(fax))
                    {
                        NhaXuatBanDAL.UpdateNhaXuatBan(maNXB, tenNXB, diaChi, email, SDT, fax);
                    }
                    else
                    {
                        NhaXuatBanDAL.UpdateNhaXuatBan(maNXB, tenNXB, diaChi, email, SDT);
                    }
                    Functions.HandleInfo("Cập nhật nhà xuất bản thành công");
                    LoadData();
                    ResetValues();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi cập nhật nhà xuất bản: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNXB = txtMaNXB.Text.Trim();

            if (!string.IsNullOrEmpty(maNXB))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        NhaXuatBanDAL.DeleteNhaXuatBan(maNXB);
                        Functions.HandleInfo("Xóa nhà xuất bản thành công");
                        LoadData();
                        ResetValues();

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa nhà xuất bản: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string maNXB = txtMaNXB.Text.Trim();
                string tenNXB = txtTenNXB.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string email = txtEmail.Text.Trim();

                string SDT = txtSDT.Text.Trim().Replace(" ", "");
                string fax = txtFax.Text.Trim().Replace(" ", "");

                try
                {
                    if (!string.IsNullOrEmpty(fax))
                    {
                        NhaXuatBanDAL.UpdateNhaXuatBan(maNXB, tenNXB, diaChi, email, SDT, fax);
                    }
                    else
                    {
                        NhaXuatBanDAL.UpdateNhaXuatBan(maNXB, tenNXB, diaChi, email, SDT);
                    }
                    Functions.HandleInfo("Thêm nhà xuất bản thành công");
                    LoadData();
                    ResetValues();

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    txtMaNXB.Enabled = false;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm nhà xuất bản: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maNXB = txtMaNXB.Text.Trim();

            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNXB.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maNXB))
            {
                NhaXuatBanDAL.DeleteEmptyNhaXuatBan(maNXB);
            }
            LoadData();
        }

        private void PerformSearch()
        {
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
    }
}
