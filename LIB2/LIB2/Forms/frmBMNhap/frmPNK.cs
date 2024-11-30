using LIB2.Class;
using LIB2.Class.Types;
using LIB2.DAL;
using LIB2.Database;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmPNK : MaterialForm
    {
        public UserRole currentRole; 
        public string Username { get; set; }

        private DataTable tblPNK;
        private DataTable tblCTPNK;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        public frmPNK()
        {
            InitializeComponent();

            InitializeListView();
            InitializeListViewCT();

            LoadData();

            cboTimKiem.Items.Add("Mã phiếu");
            cboTimKiem.Items.Add("Nhân viên lập");
            cboTimKiem.Items.Add("Nhân viên duyệt");
            cboTimKiem.Items.Add("Ngày lập");
            cboTimKiem.Items.Add("Ngày duyệt");

            cboNguon.Items.Add("Nhà cung cấp");
            cboNguon.Items.Add("Nhà xuất bản");
            cboNguon.Items.Add("Bạn đọc");
            cboNguon.Items.Add("Chương trình trao đổi");
        }

        private void InitializeListView()
        {
            listViewPNK.FullRowSelect = true;
            listViewPNK.MultiSelect = false;
            listViewPNK.UseCompatibleStateImageBehavior = false;
            listViewPNK.View = View.Details;

            listViewPNK.Columns.Add("MaPhieuNhapKho", "Mã phiếu");

            listViewPNK.Columns.Add("MaNVLap", "Mã nhân viên lập");
            listViewPNK.Columns.Add("TenNVLap", "Tên nhân viên lập");
            listViewPNK.Columns.Add("MaNVDuyet", "Mã nhân viên duyệt");
            listViewPNK.Columns.Add("TenNVDuyet", "Tên nhân viên duyệt");

            listViewPNK.Columns.Add("NgayLap", "Ngày lập");
            listViewPNK.Columns.Add("NgayDuyet", "Ngày duyệt");
            listViewPNK.Columns.Add("NguonNhap", "Nguồn nhập");
        }

        private void InitializeListViewCT()
        {
            listViewCTPNK.FullRowSelect = true;
            listViewCTPNK.MultiSelect = false;
            listViewCTPNK.UseCompatibleStateImageBehavior = false;
            listViewCTPNK.View = View.Details;

            listViewCTPNK.Columns.Add("MaTL", "Mã tài liệu");
            listViewCTPNK.Columns.Add("TenTL", "Tên tài liệu");
            listViewCTPNK.Columns.Add("SoLuong", "Số lượng");
            listViewCTPNK.Columns.Add("DonGia", "Đơn giá");
        }

        private void frmPNK_Load(object sender, EventArgs e)
        {
            txtMaPNK.Enabled = false;

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

            txtMaNVLap.Text = NhanVienDAL.GetMaNVByUsername(Username);
            txtMaNVLap.Enabled = false;

            txtMaNVDuyet.Enabled = false;
            txtNgayDuyet.Enabled = false;

            btnDuyet.Enabled = false;
        }

        private void AdjustColumnWidth()
        {
            int col1Width = 100;
            int col2Width = 100;
            int col3Width = 150;
            int col4Width = 100;

            int col5Width = 150;
            int col6Width = 100;
            int col7Width = 100;
            int col8Width = 100;

            listViewPNK.Columns[0].Width = col1Width;
            listViewPNK.Columns[1].Width = col2Width;
            listViewPNK.Columns[2].Width = col3Width;
            listViewPNK.Columns[3].Width = col4Width;

            listViewPNK.Columns[4].Width = col5Width;
            listViewPNK.Columns[5].Width = col6Width;
            listViewPNK.Columns[6].Width = col7Width;
            listViewPNK.Columns[7].Width = col8Width;
        }

        private void AdjustColumnWidthCT()
        {
            int totalWidth = listViewCTPNK.ClientSize.Width;
            double col1Percentage = 0.2;
            double col2Percentage = 0.4;
            double col3Percentage = 0.2;
            double col4Percentage = 0.2;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);

            listViewCTPNK.Columns[0].Width = col1Width;
            listViewCTPNK.Columns[1].Width = col2Width;
            listViewCTPNK.Columns[2].Width = col3Width;
            listViewCTPNK.Columns[3].Width = col4Width;
        }

        public void LoadData()
        {
            try
            {
                if (isSearching)
                    tblPNK = PNKDAL.GetPNKBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblPNK = PNKDAL.GetAllPNK();

                LoadListView();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDataCT(string maPNK)
        {
            try
            {
                tblCTPNK = PNKDAL.GetCTPNK(maPNK);

                LoadListViewCT();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadListView()
        {
            ClearListView(listViewPNK);

            foreach (DataRow row in tblPNK.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaPhieuNhapKho"].ToString());
                item.SubItems.Add(row["MaNVLap"].ToString());
                item.SubItems.Add(row["TenNVLap"].ToString());

                item.SubItems.Add(row["MaNVDuyet"].ToString());
                item.SubItems.Add(row["TenNVDuyet"].ToString());

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

                DateTime ngayDuyet;
                if (DateTime.TryParse(row["NgayDuyet"].ToString(), out ngayDuyet))
                {
                    string ngayDuyetFormatted = ngayDuyet.ToString("dd/MM/yyyy");

                    item.SubItems.Add(ngayDuyetFormatted);
                }
                else
                {
                    item.SubItems.Add("");
                }

                item.SubItems.Add(row["NguonNhap"].ToString());

                listViewPNK.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void LoadListViewCT()
        {
            ClearListView(listViewCTPNK);

            foreach (DataRow row in tblCTPNK.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaTL"].ToString());
                item.SubItems.Add(row["TenTL"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(row["DonGia"].ToString());

                listViewCTPNK.Items.Add(item);
            }

            AdjustColumnWidthCT();
        }

        private void ClearListView(MaterialListView listView)
        {
            listView.Items.Clear();
        }

        private void listViewPNK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaTL.Focus();
                return;
            }

            if (tblPNK.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewPNK.SelectedItems.Count > 0)
            {
                txtMaTL.Enabled = true;
                txtSoLuong.Enabled = true;
                txtDonGia.Enabled = true;

                btnThemTL.Enabled = true;

                ListViewItem selectedItem = listViewPNK.SelectedItems[0];
                txtMaPNK.Text = selectedItem.SubItems[0].Text;
                txtMaNVLap.Text = selectedItem.SubItems[1].Text;
                txtMaNVDuyet.Text = selectedItem.SubItems[3].Text;

                string ngayLapStr = selectedItem.SubItems[5].Text;
                DateTime ngayLap;
                if (DateTime.TryParse(ngayLapStr, out ngayLap))
                {
                    txtNgayLap.Text = ngayLap.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtNgayLap.Text = "";
                }

                string ngayDuyetStr = selectedItem.SubItems[6].Text;
                DateTime ngayDuyet;
                if (DateTime.TryParse(ngayDuyetStr, out ngayDuyet))
                {
                    txtNgayDuyet.Text = ngayDuyet.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtNgayDuyet.Text = "";
                }

                cboNguon.SelectedIndex = cboNguon.FindStringExact(selectedItem.SubItems[7].Text);

                string maPNK = txtMaPNK.Text.Trim();
                LoadDataCT(maPNK);

                btnLuu.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
                btnIn.Enabled = true;

                if (currentRole == UserRole.Admin && string.IsNullOrEmpty(txtMaNVDuyet.Text))
                {
                    btnDuyet.Enabled = true;
                }
            }
            else
            {
                ResetValues();
                ResetValuesCT();

                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
                btnIn.Enabled = false;

                ClearListView(listViewCTPNK);

                txtMaTL.Enabled = false;
                txtSoLuong.Enabled = false;
                txtDonGia.Enabled = false;

                btnThemTL.Enabled = false;
                btnXoaTL.Enabled = false;

                btnDuyet.Enabled = false;
            }
        }

        private void listViewCTPNK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThemTL.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaTL.Focus();
                return;
            }

            if (tblCTPNK.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewCTPNK.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCTPNK.SelectedItems[0];
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
            txtMaPNK.Text = "";
            txtMaNVLap.Text = NhanVienDAL.GetMaNVByUsername(Username);
            txtMaNVDuyet.Text = "";
            txtNgayLap.Text = "";
            txtNgayDuyet.Text = "";
            cboNguon.SelectedItem = null;
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
            if (string.IsNullOrWhiteSpace(txtMaPNK.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã phiếu nhập kho");
                txtMaPNK.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtMaNVLap.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã nhân viên");
                txtMaNVLap.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNgayLap.Text))
            {
                Functions.HandleWarning("Bạn phải nhập ngày lập phiếu");
                txtNgayLap.Focus();
                return false;
            }

            if (cboNguon.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn nguồn nhập");
                cboNguon.Focus();
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
            txtDonGia.Enabled = true;
            btnThemTL.Enabled = true;

            ResetValues();
            ResetValuesCT();

            LoadDataCT("");

            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime today = DateTime.Now;

            string newMaPNK = PNKDAL.InsertEmptyPNK();
            txtMaPNK.Text = newMaPNK;

            txtMaTL.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maPNK = txtMaPNK.Text.Trim();

            ResetValuesCT();
            ResetValues();

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnIn.Enabled = false;

            txtMaPNK.Enabled = false;

            txtMaTL.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maPNK))
            {
                PNKDAL.DeleteEmptyPNK(maPNK);
            }

            LoadDataCT("");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPNK = txtMaPNK.Text.Trim();

            if (!string.IsNullOrEmpty(maPNK))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        PNKDAL.DeleteCTPNK(maPNK);
                        PNKDAL.DeletePNK(maPNK);

                        Functions.HandleInfo("Xóa phiếu nhập kho thành công");
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
                        Functions.HandleError("Lỗi khi xóa phiếu nhập kho: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maPNK = txtMaPNK.Text.Trim();

            if (!PNKDAL.CheckMaPNKExists(maPNK))
            {
                if (ValidateInput())
                {
                    string maNVLap = txtMaNVLap.Text.Trim();

                    DateTime ngayLap;
                    if (!DateTime.TryParse(txtNgayLap.Text.Trim(), out ngayLap))
                    {
                        Functions.HandleWarning("Ngày lập phiếu không hợp lệ");
                        txtNgayLap.Focus();
                        return;
                    }

                    string nguonNhap = cboNguon.Text;

                    try
                    {
                        PNKDAL.UpdatePNK(maPNK, maNVLap, ngayLap, nguonNhap);

                        Functions.HandleInfo("Lưu phiếu nhập kho thành công");
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
                        txtDonGia.Enabled = false;
                        btnThemTL.Enabled = false;
                        btnXoaTL.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi thêm phiếu nhập kho: " + ex.Message);
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                string maPNK = txtMaPNK.Text;
                DataTable tblThongTinPNK, tblThongTinCTPNK;

                tblThongTinPNK = PNKDAL.GetThongTinPNK(maPNK);
                tblThongTinCTPNK = PNKDAL.GetCTPNK(maPNK);

                // Tạo và hiển thị trong Excel
                // ExcelHelper.CreateBillThue(tblThongTinPNK, tblThongTinPNK);
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi: " + ex.Message);
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            string maNVDuyet = NhanVienDAL.GetMaNVByUsername(Username);
            string maPNK = txtMaPNK.Text.Trim();

            DateTime ngayDuyet = DateTime.Now;

            try
            {
                PNKDAL.DuyetPNK(maPNK, maNVDuyet, ngayDuyet);

                Functions.HandleInfo("Duyệt phiếu nhập kho thành công");
                LoadData();
                LoadDataCT("");

                ResetValues();
                ResetValuesCT();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi duyệt phiếu nhập kho: " + ex.Message);
            }
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            string maPNK = txtMaPNK.Text.Trim();

            if (ValidateInputCT())
            {
                string maTL = txtMaTL.Text.Trim();
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                int donGia = Convert.ToInt32(txtDonGia.Text);

                if (PNKDAL.CheckMaTaiLieu(maPNK, maTL))
                {
                    Functions.HandleWarning("Tài liệu này đã có trong phiếu nhập kho, vui lòng chọn tài liệu khác hoặc xoá");
                    ResetValuesCT();
                    txtMaTL.Focus();
                    return;
                }

                try
                {
                    PNKDAL.InsertTaiLieuCTPNK(maPNK, maTL, soLuong, donGia);
                    Functions.HandleInfo("Thêm chi tiết phiếu nhập kho thành công");

                    LoadDataCT(maPNK);
                    ResetValuesCT();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm chi tiết phiếu nhập kho: " + ex.Message);
                }
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            string maPNK = txtMaPNK.Text.Trim();
            string maTL = txtMaTL.Text.Trim();

            if (!string.IsNullOrEmpty(maPNK) && !string.IsNullOrEmpty(maTL))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        PNKDAL.DeleteTaiLieuCTPNK(maPNK, maTL);
                        Functions.HandleInfo("Xóa tài liệu trong phiếu nhập kho thành công");

                        LoadDataCT(maPNK);
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
