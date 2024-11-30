using LIB2.Class;
using LIB2.DAL;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmNganh : MaterialForm
    {
        private DataTable tblNganh;

        private bool isSearching = false;
        private string currentSearchKeyword = "";

        public frmNganh()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();
        }

        private void InitializeListView()
        {
            listViewNganh.FullRowSelect = true;
            listViewNganh.MultiSelect = false;
            listViewNganh.UseCompatibleStateImageBehavior = false;
            listViewNganh.View = View.Details;

            listViewNganh.Columns.Add("MaNganh", "Mã ngành");
            listViewNganh.Columns.Add("TenNganh", "Tên ngành");
        }

        private void frmNganh_Load(object sender, EventArgs e)
        {
            txtMaNganh.Enabled = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewNganh.ClientSize.Width;
            double col1Percentage = 0.3;
            double col2Percentage = 0.7;
            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);

            listViewNganh.Columns[0].Width = col1Width;
            listViewNganh.Columns[1].Width = col2Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblNganh = NganhDAL.GetNganhBySearch(currentSearchKeyword);
                else
                    tblNganh = NganhDAL.GetAllNganh();

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

            foreach (DataRow row in tblNganh.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaNganh"].ToString());
                item.SubItems.Add(row["TenNganh"].ToString());
                listViewNganh.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewNganh.Items.Clear();
        }

        private void listViewNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaNganh.Focus();
                return;
            }

            if (tblNganh.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewNganh.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewNganh.SelectedItems[0];
                txtMaNganh.Text = selectedItem.SubItems[0].Text;
                txtTenNganh.Text = selectedItem.SubItems[1].Text;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                txtMaNganh.Text = "";
                txtTenNganh.Text = "";
            }
        }

        private void ResetValues()
        {
            txtMaNganh.Text = "";
            txtTenNganh.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaNganh.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã ngành");
                txtMaNganh.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtTenNganh.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên ngành");
                txtTenNganh.Focus();
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
            txtTenNganh.Focus();

            string newMaNganh = NganhDAL.InsertEmptyNganh();
            txtMaNganh.Text = newMaNganh;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewNganh.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }

            if (ValidateInput())
            {
                string maNganh = txtMaNganh.Text.Trim();
                string tenNganh = txtTenNganh.Text.Trim();

                try
                {
                    NganhDAL.UpdateNganh(maNganh, tenNganh);
                    Functions.HandleInfo("Cập nhật ngành thành công");
                    LoadData();
                    ResetValues();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi cập nhật ngành: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNganh = txtMaNganh.Text.Trim();

            if (!string.IsNullOrEmpty(maNganh))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        NganhDAL.DeleteNganh(maNganh);
                        Functions.HandleInfo("Xóa ngành thành công");
                        LoadData();
                        ResetValues();

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa ngành: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string maNganh = txtMaNganh.Text.Trim();
                string tenNganh = txtTenNganh.Text.Trim();

                try
                {
                    NganhDAL.UpdateNganh(maNganh, tenNganh);
                    Functions.HandleInfo("Thêm ngành thành công");
                    LoadData();
                    ResetValues();

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    txtMaNganh.Enabled = false;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm ngành: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maNganh = txtMaNganh.Text.Trim();

            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNganh.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maNganh))
            {
                NganhDAL.DeleteEmptyNganh(maNganh);
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
