using LIB2.Class;
using LIB2.DAL;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmPhongBan : MaterialForm
    {
        private DataTable tblPhongBan;

        private bool isSearching = false;
        private string currentSearchKeyword = "";

        public frmPhongBan()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();
        }

        private void InitializeListView()
        {
            listViewPB.FullRowSelect = true;
            listViewPB.MultiSelect = false;
            listViewPB.UseCompatibleStateImageBehavior = false;
            listViewPB.View = View.Details;

            listViewPB.Columns.Add("MaPB", "Mã phòng ban");
            listViewPB.Columns.Add("TenPB", "Tên phòng ban");
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            txtMaPB.Enabled = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewPB.ClientSize.Width;
            double col1Percentage = 0.3;
            double col2Percentage = 0.7;
            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);

            listViewPB.Columns[0].Width = col1Width;
            listViewPB.Columns[1].Width = col2Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblPhongBan = PhongBanDAL.GetPhongBanBySearch(currentSearchKeyword);
                else
                    tblPhongBan = PhongBanDAL.GetAllPhongBan();

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

            foreach (DataRow row in tblPhongBan.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaPB"].ToString());
                item.SubItems.Add(row["TenPB"].ToString());
                listViewPB.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewPB.Items.Clear();
        }

        private void listViewPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaPB.Focus();
                return;
            }

            if (tblPhongBan.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewPB.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewPB.SelectedItems[0];
                txtMaPB.Text = selectedItem.SubItems[0].Text;
                txtTenPB.Text = selectedItem.SubItems[1].Text;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                txtMaPB.Text = "";
                txtTenPB.Text = "";
            }
        }

        private void ResetValues()
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaPB.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã phòng ban");
                txtMaPB.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtTenPB.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên phòng ban");
                txtTenPB.Focus();
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
            txtTenPB.Focus();

            string newMaPB = PhongBanDAL.InsertEmptyPhongBan();
            txtMaPB.Text = newMaPB;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewPB.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }

            if (ValidateInput())
            {
                string maPB = txtMaPB.Text.Trim();
                string tenPB = txtTenPB.Text.Trim();

                try
                {
                    PhongBanDAL.UpdatePhongBan(maPB, tenPB);
                    Functions.HandleInfo("Cập nhật phòng ban thành công");
                    LoadData();
                    ResetValues();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi cập nhật phòng ban: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPB = txtMaPB.Text.Trim();

            if (!string.IsNullOrEmpty(maPB))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        PhongBanDAL.DeletePhongBan(maPB);
                        Functions.HandleInfo("Xóa phòng ban thành công");
                        LoadData();
                        ResetValues();

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa phòng ban: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string maPB = txtMaPB.Text.Trim();
                string tenPB = txtTenPB.Text.Trim();

                try
                {
                    PhongBanDAL.UpdatePhongBan(maPB, tenPB);
                    Functions.HandleInfo("Thêm phòng ban thành công");
                    LoadData();
                    ResetValues();

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    txtMaPB.Enabled = false;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm phòng ban: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maPB = txtMaPB.Text.Trim();

            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaPB.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maPB))
            {
                PhongBanDAL.DeleteEmptyPhongBan(maPB);
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
