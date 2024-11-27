using LIB2.Class;
using LIB2.DAL;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmChucVu : MaterialForm
    {
        private DataTable tblChucVu;

        private bool isSearching = false;
        private string currentSearchKeyword = "";

        public frmChucVu()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();
        }

        private void InitializeListView()
        {
            listViewCV.FullRowSelect = true;
            listViewCV.MultiSelect = false;
            listViewCV.UseCompatibleStateImageBehavior = false;
            listViewCV.View = View.Details;

            listViewCV.Columns.Add("MaCV", "Mã chức vụ");
            listViewCV.Columns.Add("TenCV", "Tên chức vụ");
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            txtMaCV.Enabled = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewCV.ClientSize.Width;
            double col1Percentage = 0.3;
            double col2Percentage = 0.7;
            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);

            listViewCV.Columns[0].Width = col1Width;
            listViewCV.Columns[1].Width = col2Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblChucVu = ChucVuDAL.GetChucVuBySearch(currentSearchKeyword);
                else
                    tblChucVu = ChucVuDAL.GetAllChucVu();

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

            foreach (DataRow row in tblChucVu.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaCV"].ToString());
                item.SubItems.Add(row["TenCV"].ToString());
                listViewCV.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewCV.Items.Clear();
        }

        private void listViewCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaCV.Focus();
                return;
            }

            if (tblChucVu.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewCV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCV.SelectedItems[0];
                txtMaCV.Text = selectedItem.SubItems[0].Text;
                txtTenCV.Text = selectedItem.SubItems[1].Text;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                txtMaCV.Text = "";
                txtTenCV.Text = "";
            }
        }

        private void ResetValues()
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaCV.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã chức vụ");
                txtMaCV.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtTenCV.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên chức vụ");
                txtTenCV.Focus();
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
            txtTenCV.Focus();

            string newMaCV = ChucVuDAL.InsertEmptyChucVu();
            txtMaCV.Text = newMaCV;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewCV.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }

            if (ValidateInput())
            {
                string maCV = txtMaCV.Text.Trim();
                string tenCV = txtTenCV.Text.Trim();

                try
                {
                    ChucVuDAL.UpdateChucVu(maCV, tenCV);
                    Functions.HandleInfo("Cập nhật chức vụ thành công");
                    LoadData();
                    ResetValues();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi cập nhật chức vụ: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCV = txtMaCV.Text.Trim();

            if (!string.IsNullOrEmpty(maCV))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        ChucVuDAL.DeleteChucVu(maCV);
                        Functions.HandleInfo("Xóa chức vụ thành công");
                        LoadData();
                        ResetValues();

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa chức vụ: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string maCV = txtMaCV.Text.Trim();
                string tenCV = txtTenCV.Text.Trim();

                try
                {
                    ChucVuDAL.UpdateChucVu(maCV, tenCV);
                    Functions.HandleInfo("Thêm chức vụ thành công");
                    LoadData();
                    ResetValues();

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    txtMaCV.Enabled = false;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm chức vụ: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maCV = txtMaCV.Text.Trim();

            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaCV.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maCV))
            {
                ChucVuDAL.DeleteEmptyChucVu(maCV);
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
