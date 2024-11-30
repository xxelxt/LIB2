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
    public partial class frmPKK : MaterialForm
    {
        public string Username { get; set; }

        private DataTable tblPKK;
        private DataTable tblCTPKK;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        public frmPKK()
        {
            InitializeComponent();

            InitializeListView();
            InitializeListViewCT();

            LoadData();

            cboTimKiem.Items.Add("Mã phiếu");
            cboTimKiem.Items.Add("Nhân viên lập");
            cboTimKiem.Items.Add("Ngày lập");
        }

        private void InitializeListView()
        {
            listViewPKK.FullRowSelect = true;
            listViewPKK.MultiSelect = false;
            listViewPKK.UseCompatibleStateImageBehavior = false;
            listViewPKK.View = View.Details;

            listViewPKK.Columns.Add("MaPhieuKiemKe", "Mã phiếu");
            listViewPKK.Columns.Add("MaNVLap", "Mã nhân viên lập");
            listViewPKK.Columns.Add("TenNVLap", "Tên nhân viên lập");
            listViewPKK.Columns.Add("NgayLap", "Ngày lập");
        }

        private void InitializeListViewCT()
        {
            listViewCTPKK.FullRowSelect = true;
            listViewCTPKK.MultiSelect = false;
            listViewCTPKK.UseCompatibleStateImageBehavior = false;
            listViewCTPKK.View = View.Details;

            listViewCTPKK.Columns.Add("MaTL", "Mã tài liệu");
            listViewCTPKK.Columns.Add("TenTL", "Tên tài liệu");
            listViewCTPKK.Columns.Add("SoLuong", "Số lượng");
            listViewCTPKK.Columns.Add("DonGia", "Đơn giá");
        }

        private void frmPKK_Load(object sender, EventArgs e)
        {
            txtMaPKK.Enabled = false;

            btnXoa.Enabled = false;
            btnLuu.Enabled = false;

            btnHuy.Enabled = false;
            btnIn.Enabled = false;

            btnThemTL.Enabled = false;
            btnXoaTL.Enabled = false;

            txtMaTL.Enabled = false;
            txtTenTL.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;

            txtMaNV.Text = NhanVienDAL.GetMaNVByUsername(Username);
            txtMaNV.Enabled = false;
        }

        private void AdjustColumnWidth()
        {
            int col1Width = 150;
            int col2Width = 150;
            int col3Width = 150;
            int col4Width = 150;

            listViewPKK.Columns[0].Width = col1Width;
            listViewPKK.Columns[1].Width = col2Width;
            listViewPKK.Columns[2].Width = col3Width;
            listViewPKK.Columns[3].Width = col4Width;
        }

        private void AdjustColumnWidthCT()
        {
            int totalWidth = listViewCTPKK.ClientSize.Width;
            double col1Percentage = 0.2;
            double col2Percentage = 0.4;
            double col3Percentage = 0.2;
            double col4Percentage = 0.2;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);

            listViewCTPKK.Columns[0].Width = col1Width;
            listViewCTPKK.Columns[1].Width = col2Width;
            listViewCTPKK.Columns[2].Width = col3Width;
            listViewCTPKK.Columns[3].Width = col4Width;
        }

        public void LoadData()
        {
            try
            {
                if (isSearching)
                    tblPKK = PKKDAL.GetPKKBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblPKK = PKKDAL.GetAllPKK();

                LoadListView();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDataCT(string maPKK)
        {
            try
            {
                tblCTPKK = PKKDAL.GetCTPKK(maPKK);

                LoadListViewCT();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadListView()
        {
            ClearListView(listViewPKK);

            foreach (DataRow row in tblPKK.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaPhieuKiemKe"].ToString());
                item.SubItems.Add(row["MaNVLap"].ToString());
                item.SubItems.Add(row["TenNVLap"].ToString());

                DateTime ngayLap;
                if (DateTime.TryParse(row["NgayLap"].ToString(), out ngayLap))
                {
                    string ngayLapFormatted = ngayLap.ToString("dd/MM/yyyy");

                    item.SubItems.Add(ngayLapFormatted);
                }
                else
                {
                    item.SubItems.Add("");
                }

                listViewPKK.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void LoadListViewCT()
        {
            ClearListView(listViewCTPKK);

            foreach (DataRow row in tblCTPKK.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaTL"].ToString());
                item.SubItems.Add(row["TenTL"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(row["DonGia"].ToString());

                listViewCTPKK.Items.Add(item);
            }

            AdjustColumnWidthCT();
        }

        private void ClearListView(MaterialListView listView)
        {
            listView.Items.Clear();
        }

        private void listViewPKK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaTL.Focus();
                return;
            }

            if (tblPKK.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewPKK.SelectedItems.Count > 0)
            {
                txtMaTL.Enabled = true;
                txtSoLuong.Enabled = true;

                btnThemTL.Enabled = true;

                ListViewItem selectedItem = listViewPKK.SelectedItems[0];
                txtMaPKK.Text = selectedItem.SubItems[0].Text;
                txtMaNV.Text = selectedItem.SubItems[1].Text;

                string ngayLapStr = selectedItem.SubItems[3].Text;
                DateTime ngayLap;
                if (DateTime.TryParse(ngayLapStr, out ngayLap))
                {
                    txtNgayLap.Text = ngayLap.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtNgayLap.Text = "";
                }

                string maPKK = txtMaPKK.Text.Trim();
                LoadDataCT(maPKK);

                btnLuu.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
                btnIn.Enabled = true;
            }
            else
            {
                ResetValues();
                ResetValuesCT();

                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
                btnIn.Enabled = false;

                ClearListView(listViewCTPKK);

                txtMaTL.Enabled = false;
                txtSoLuong.Enabled = false;

                btnThemTL.Enabled = false;
                btnXoaTL.Enabled = false;
            }
        }

        private void listViewCTPKK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThemTL.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaTL.Focus();
                return;
            }

            if (tblCTPKK.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewCTPKK.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCTPKK.SelectedItems[0];
                txtMaTL.Text = selectedItem.SubItems[0].Text;
                txtTenTL.Text = selectedItem.SubItems[1].Text;
                txtSoLuong.Text = selectedItem.SubItems[2].Text;
                txtDonGia.Text = selectedItem.SubItems[3].Text;

                btnXoaTL.Enabled = true;
            }
            else
            {
                ResetValuesCT();

                btnXoaTL.Enabled = false;
            }
        }

        private void ResetValues()
        {
            txtMaPKK.Text = "";
            txtMaNV.Text = NhanVienDAL.GetMaNVByUsername(Username);
            txtNgayLap.Text = "";
        }

        private void ResetValuesCT()
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaPKK.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã phiếu kiểm kê");
                txtMaPKK.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã nhân viên");
                txtMaNV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNgayLap.Text))
            {
                Functions.HandleWarning("Bạn phải nhập ngày lập phiếu");
                txtNgayLap.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateInputCT()
        {
            if (string.IsNullOrWhiteSpace(txtMaTL.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã tài liệu");
                txtMaTL.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenTL.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên tài liệu");
                txtTenTL.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số lượng");
                txtSoLuong.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                Functions.HandleWarning("Bạn phải nhập đơn giá");
                txtDonGia.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnIn.Enabled = false;

            btnHuy.Enabled = true;
            btnLuu.Enabled = true;

            txtMaTL.Enabled = true;
            txtSoLuong.Enabled = true;
            btnThemTL.Enabled = true;

            ResetValues();
            ResetValuesCT();

            LoadDataCT("");

            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime today = DateTime.Now;

            string newMaPKK = PKKDAL.InsertEmptyPKK();
            txtMaPKK.Text = newMaPKK;

            txtMaTL.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maPKK = txtMaPKK.Text.Trim();

            ResetValuesCT();
            ResetValues();

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnIn.Enabled = false;

            txtMaPKK.Enabled = false;

            txtMaTL.Enabled = false;
            txtSoLuong.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maPKK))
            {
                PKKDAL.DeleteEmptyPKK(maPKK);
            }

            LoadDataCT("");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPKK = txtMaPKK.Text.Trim();

            if (!string.IsNullOrEmpty(maPKK))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        PKKDAL.DeleteCTPKK(maPKK);
                        PKKDAL.DeletePKK(maPKK);

                        Functions.HandleInfo("Xóa phiếu kiểm kê thành công");
                        LoadData();
                        LoadDataCT("");
                        ResetValues();
                        ResetValuesCT();

                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                        btnIn.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa phiếu kiểm kê: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maPKK = txtMaPKK.Text.Trim();

            if (!PKKDAL.CheckMaPKKExists(maPKK))
            {
                if (ValidateInput())
                {
                    string maNV = txtMaNV.Text.Trim();

                    DateTime ngayLap;
                    if (!DateTime.TryParse(txtNgayLap.Text.Trim(), out ngayLap))
                    {
                        Functions.HandleWarning("Ngày lập phiếu không hợp lệ");
                        txtNgayLap.Focus();
                        return;
                    }

                    try
                    {
                        PKKDAL.UpdatePKK(maPKK, maNV, ngayLap);

                        Functions.HandleInfo("Lưu phiếu kiểm kê thành công");
                        LoadData();
                        LoadDataCT("");

                        ResetValues();
                        ResetValuesCT();

                        btnThem.Enabled = true;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                        btnLuu.Enabled = false;
                        btnIn.Enabled = false;

                        txtMaTL.Enabled = false;
                        txtSoLuong.Enabled = false;
                        btnThemTL.Enabled = false;
                        btnXoaTL.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi thêm phiếu kiểm kê: " + ex.Message);
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                string maPKK = txtMaPKK.Text;
                DataTable tblThongTinPKK, tblThongTinCTPKK;

                tblThongTinPKK = PKKDAL.GetThongTinPKK(maPKK);
                tblThongTinCTPKK = PKKDAL.GetCTPKK(maPKK);

                // Tạo và hiển thị trong Excel
                // ExcelHelper.CreateBillThue(tblThongTinPKK, tblThongTinPKK);
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi: " + ex.Message);
            }
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            string maPKK = txtMaPKK.Text.Trim();

            if (ValidateInputCT())
            {
                string maTL = txtMaTL.Text.Trim();
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                int donGia = Convert.ToInt32(txtDonGia.Text);

                if (PKKDAL.CheckMaTaiLieu(maPKK, maTL))
                {
                    Functions.HandleWarning("Tài liệu này đã có trong phiếu kiểm kê, vui lòng chọn tài liệu khác hoặc xoá");
                    ResetValuesCT();
                    txtMaTL.Focus();
                    return;
                }

                try
                {
                    PKKDAL.InsertTaiLieuCTPKK(maPKK, maTL, soLuong, donGia);
                    Functions.HandleInfo("Thêm chi tiết phiếu kiểm kê thành công");

                    LoadDataCT(maPKK);
                    ResetValuesCT();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm chi tiết phiếu kiểm kê: " + ex.Message);
                }
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            string maPKK = txtMaPKK.Text.Trim();
            string maTL = txtMaTL.Text.Trim();

            if (!string.IsNullOrEmpty(maPKK) && !string.IsNullOrEmpty(maTL))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        PKKDAL.DeleteTaiLieuCTPKK(maPKK, maTL);
                        Functions.HandleInfo("Xóa tài liệu trong phiếu kiểm kê thành công");

                        LoadDataCT(maPKK);
                        ResetValuesCT();
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa tài liệu: " + ex.Message);
                    }
                }
            }
        }

        private void txtMaTL_TextChanged(object sender, EventArgs e)
        {
            string maTL = txtMaTL.Text.Trim();

            if (!string.IsNullOrEmpty(maTL))
            {
                var TLInfo = TaiLieuDAL.GetTenGiaTLByMa(maTL);
                if (TLInfo != null)
                {
                    txtTenTL.Text = TLInfo.Item1;
                    txtDonGia.Text = TLInfo.Item2;
                }
                else
                {
                    txtTenTL.Text = string.Empty;
                    txtDonGia.Text = string.Empty;
                }
            }
            else
            {
                txtTenTL.Text = string.Empty;
                txtDonGia.Text = string.Empty;
            }
        }

        private void PerformSearch()
        {
            currentSearchOption = cboTimKiem.Text;
            currentSearchKeyword = txtTimKiem.Text.Trim();
            isSearching = true;

            LoadData();
            LoadDataCT("");

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

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
