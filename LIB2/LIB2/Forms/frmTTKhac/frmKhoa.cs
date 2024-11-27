using LIB2.Class;
using LIB2.DAL;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmKhoa : MaterialForm
    {
        private DataTable tblKhoa;

        private bool isSearching = false;
        private string currentSearchKeyword = "";

        public frmKhoa()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();
        }

        private void InitializeListView()
        {
            listViewKhoa.FullRowSelect = true;
            listViewKhoa.MultiSelect = false;
            listViewKhoa.UseCompatibleStateImageBehavior = false;
            listViewKhoa.View = View.Details;

            listViewKhoa.Columns.Add("MaKhoa", "Mã khoa");
            listViewKhoa.Columns.Add("TenKhoa", "Tên khoa");
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            txtMaKhoa.Enabled = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewKhoa.ClientSize.Width;
            double col1Percentage = 0.3;
            double col2Percentage = 0.7;
            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);

            listViewKhoa.Columns[0].Width = col1Width;
            listViewKhoa.Columns[1].Width = col2Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblKhoa = KhoaDAL.GetKhoaBySearch(currentSearchKeyword);
                else
                    tblKhoa = KhoaDAL.GetAllKhoa();

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

            foreach (DataRow row in tblKhoa.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaKhoa"].ToString());
                item.SubItems.Add(row["TenKhoa"].ToString());
                listViewKhoa.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewKhoa.Items.Clear();
        }

        private void listViewKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaKhoa.Focus();
                return;
            }

            if (tblKhoa.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewKhoa.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewKhoa.SelectedItems[0];
                txtMaKhoa.Text = selectedItem.SubItems[0].Text;
                txtTenKhoa.Text = selectedItem.SubItems[1].Text;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                txtMaKhoa.Text = "";
                txtTenKhoa.Text = "";
            }
        }

        private void ResetValues()
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã khoa");
                txtMaKhoa.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên khoa");
                txtTenKhoa.Focus();
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
            txtTenKhoa.Focus();

            string newMaKhoa = KhoaDAL.InsertEmptyKhoa();
            txtMaKhoa.Text = newMaKhoa;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewKhoa.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }

            if (ValidateInput())
            {
                string maKhoa = txtMaKhoa.Text.Trim();
                string tenKhoa = txtTenKhoa.Text.Trim();

                try
                {
                    KhoaDAL.UpdateKhoa(maKhoa, tenKhoa);
                    Functions.HandleInfo("Cập nhật khoa thành công");
                    LoadData();
                    ResetValues();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi cập nhật khoa: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();

            if (!string.IsNullOrEmpty(maKhoa))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        KhoaDAL.DeleteKhoa(maKhoa);
                        Functions.HandleInfo("Xóa khoa thành công");
                        LoadData();
                        ResetValues();

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa khoa: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string maKhoa = txtMaKhoa.Text.Trim();
                string tenKhoa = txtTenKhoa.Text.Trim();

                try
                {
                    KhoaDAL.UpdateKhoa(maKhoa, tenKhoa);
                    Functions.HandleInfo("Thêm khoa thành công");
                    LoadData();
                    ResetValues();

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    txtMaKhoa.Enabled = false;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm khoa: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();

            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaKhoa.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maKhoa))
            {
                KhoaDAL.DeleteEmptyKhoa(maKhoa);
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
