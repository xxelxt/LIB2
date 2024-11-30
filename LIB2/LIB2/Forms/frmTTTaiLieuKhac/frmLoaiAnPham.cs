using LIB2.Class;
using LIB2.DAL;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmLoaiAnPham : MaterialForm
    {
        private DataTable tblLoaiAnPham;

        private bool isSearching = false;
        private string currentSearchKeyword = "";

        public frmLoaiAnPham()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();
        }

        private void InitializeListView()
        {
            listViewLoai.FullRowSelect = true;
            listViewLoai.MultiSelect = false;
            listViewLoai.UseCompatibleStateImageBehavior = false;
            listViewLoai.View = View.Details;

            listViewLoai.Columns.Add("MaLoaiAP", "Mã loại ấn phẩm");
            listViewLoai.Columns.Add("TenLoaiAP", "Tên loại ấn phẩm");
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            txtMaLoai.Enabled = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewLoai.ClientSize.Width;
            double col1Percentage = 0.3;
            double col2Percentage = 0.7;
            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);

            listViewLoai.Columns[0].Width = col1Width;
            listViewLoai.Columns[1].Width = col2Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblLoaiAnPham = LoaiAnPhamDAL.GetLoaiAnPhamBySearch(currentSearchKeyword);
                else
                    tblLoaiAnPham = LoaiAnPhamDAL.GetAllLoaiAnPham();

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

            foreach (DataRow row in tblLoaiAnPham.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaLoaiAP"].ToString());
                item.SubItems.Add(row["TenLoaiAP"].ToString());
                listViewLoai.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewLoai.Items.Clear();
        }

        private void listViewLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaLoai.Focus();
                return;
            }

            if (tblLoaiAnPham.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewLoai.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewLoai.SelectedItems[0];
                txtMaLoai.Text = selectedItem.SubItems[0].Text;
                txtTenLoai.Text = selectedItem.SubItems[1].Text;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                txtMaLoai.Text = "";
                txtTenLoai.Text = "";
            }
        }

        private void ResetValues()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã loại ấn phẩm");
                txtMaLoai.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên loại ấn phẩm");
                txtTenLoai.Focus();
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
            txtTenLoai.Focus();

            string newMaLoai = LoaiAnPhamDAL.InsertEmptyLoaiAnPham();
            txtMaLoai.Text = newMaLoai;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewLoai.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }

            if (ValidateInput())
            {
                string maLoai = txtMaLoai.Text.Trim();
                string tenLoai = txtTenLoai.Text.Trim();

                try
                {
                    LoaiAnPhamDAL.UpdateLoaiAnPham(maLoai, tenLoai);
                    Functions.HandleInfo("Cập nhật loại ấn phẩm thành công");
                    LoadData();
                    ResetValues();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi cập nhật loại ấn phẩm: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoai.Text.Trim();

            if (!string.IsNullOrEmpty(maLoai))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        LoaiAnPhamDAL.DeleteLoaiAnPham(maLoai);
                        Functions.HandleInfo("Xóa loại ấn phẩm thành công");
                        LoadData();
                        ResetValues();

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa loại ấn phẩm: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string maLoai = txtMaLoai.Text.Trim();
                string tenLoai = txtTenLoai.Text.Trim();

                try
                {
                    LoaiAnPhamDAL.UpdateLoaiAnPham(maLoai, tenLoai);
                    Functions.HandleInfo("Thêm loại ấn phẩm thành công");
                    LoadData();
                    ResetValues();

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    txtMaLoai.Enabled = false;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm loại ấn phẩm: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoai.Text.Trim();

            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaLoai.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maLoai))
            {
                LoaiAnPhamDAL.DeleteEmptyLoaiAnPham(maLoai);
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
