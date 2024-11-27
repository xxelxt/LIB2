using LIB2.Class;
using LIB2.DAL;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmKho : MaterialForm
    {
        private DataTable tblKho;

        private bool isSearching = false;
        private string currentSearchKeyword = "";

        public frmKho()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();
        }

        private void InitializeListView()
        {
            listViewKho.FullRowSelect = true;
            listViewKho.MultiSelect = false;
            listViewKho.UseCompatibleStateImageBehavior = false;
            listViewKho.View = View.Details;

            listViewKho.Columns.Add("MaKho", "Mã kho");
            listViewKho.Columns.Add("TenKho", "Tên kho");
            listViewKho.Columns.Add("ViTriTang", "Vị trí tầng");
            listViewKho.Columns.Add("GhiChu", "Ghi chú");
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            txtMaKho.Enabled = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewKho.ClientSize.Width;
            double col1Percentage = 0.1;
            double col2Percentage = 0.4;
            double col3Percentage = 0.1;
            double col4Percentage = 0.4;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);

            listViewKho.Columns[0].Width = col1Width;
            listViewKho.Columns[1].Width = col2Width;
            listViewKho.Columns[2].Width = col3Width;
            listViewKho.Columns[3].Width = col4Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblKho = KhoDAL.GetKhoBySearch(currentSearchKeyword);
                else
                    tblKho = KhoDAL.GetAllKho();

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

            foreach (DataRow row in tblKho.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaKho"].ToString());
                item.SubItems.Add(row["TenKho"].ToString());
                item.SubItems.Add(row["ViTriTang"].ToString());
                item.SubItems.Add(row["GhiChu"].ToString());
                listViewKho.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewKho.Items.Clear();
        }

        private void listViewKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaKho.Focus();
                return;
            }

            if (tblKho.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewKho.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewKho.SelectedItems[0];
                txtMaKho.Text = selectedItem.SubItems[0].Text;
                txtTenKho.Text = selectedItem.SubItems[1].Text;
                txtViTriTang.Text = selectedItem.SubItems[2].Text;
                txtGhiChu.Text = selectedItem.SubItems[3].Text;

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
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            txtViTriTang.Text = "";
            txtGhiChu.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaKho.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã kho");
                txtMaKho.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtTenKho.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên kho");
                txtTenKho.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtViTriTang.Text))
            {
                Functions.HandleWarning("Bạn phải nhập vị trí tầng");
                txtViTriTang.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGhiChu.Text))
            {
                Functions.HandleWarning("Bạn phải nhập ghi chú (tài liệu được lưu trữ tại kho)");
                txtGhiChu.Focus();
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

            txtTenKho.Focus();

            string newMaKho = KhoDAL.InsertEmptyKho();
            txtMaKho.Text = newMaKho;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewKho.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }

            if (ValidateInput())
            {
                string maKho = txtMaKho.Text.Trim();
                string tenKho = txtTenKho.Text.Trim();

                int viTriTang = Convert.ToInt32(txtViTriTang.Text.Trim());
                string ghiChu = txtGhiChu.Text.Trim();

                try
                {
                    KhoDAL.UpdateKho(maKho, tenKho, viTriTang, ghiChu);
                    Functions.HandleInfo("Cập nhật kho thành công");
                    LoadData();
                    ResetValues();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi cập nhật kho: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKho = txtMaKho.Text.Trim();

            if (!string.IsNullOrEmpty(maKho))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        KhoDAL.DeleteKho(maKho);
                        Functions.HandleInfo("Xóa kho thành công");
                        LoadData();
                        ResetValues();

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa kho: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string maKho = txtMaKho.Text.Trim();
                string tenKho = txtTenKho.Text.Trim();

                int viTriTang = Convert.ToInt32(txtViTriTang.Text.Trim());
                string ghiChu = txtGhiChu.Text.Trim();

                try
                {
                    KhoDAL.UpdateKho(maKho, tenKho, viTriTang, ghiChu);
                    Functions.HandleInfo("Thêm kho thành công");
                    LoadData();
                    ResetValues();

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    txtMaKho.Enabled = false;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm kho: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maKho = txtMaKho.Text.Trim();

            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaKho.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maKho))
            {
                KhoDAL.DeleteEmptyKho(maKho);
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

        private void txtViTriTang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
