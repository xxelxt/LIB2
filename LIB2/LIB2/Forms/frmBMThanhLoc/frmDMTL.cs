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
    public partial class frmDMTL : MaterialForm
    {
        public UserRole currentRole;
        public string Username { get; set; }

        private DataTable tblDMTL;
        private DataTable tblCTDMTL;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        public frmDMTL()
        {
            InitializeComponent();

            InitializeListView();
            InitializeListViewCT();

            LoadData();

            cboTimKiem.Items.Add("Mã danh mục");
            cboTimKiem.Items.Add("Nhân viên lập");
            cboTimKiem.Items.Add("Nhân viên duyệt");
            cboTimKiem.Items.Add("Ngày lập");
            cboTimKiem.Items.Add("Ngày duyệt");
        }

        private void InitializeListView()
        {
            listViewDMTL.FullRowSelect = true;
            listViewDMTL.MultiSelect = false;
            listViewDMTL.UseCompatibleStateImageBehavior = false;
            listViewDMTL.View = View.Details;

            listViewDMTL.Columns.Add("MaDMThanhLoc", "Mã danh mục");

            listViewDMTL.Columns.Add("MaNVLap", "Mã nhân viên lập");
            listViewDMTL.Columns.Add("TenNVLap", "Tên nhân viên lập");
            listViewDMTL.Columns.Add("MaNVDuyet", "Mã nhân viên duyệt");
            listViewDMTL.Columns.Add("TenNVDuyet", "Tên nhân viên duyệt");

            listViewDMTL.Columns.Add("NgayLap", "Ngày lập");
            listViewDMTL.Columns.Add("NgayDuyet", "Ngày duyệt");
        }

        private void InitializeListViewCT()
        {
            listViewCTDMTL.FullRowSelect = true;
            listViewCTDMTL.MultiSelect = false;
            listViewCTDMTL.UseCompatibleStateImageBehavior = false;
            listViewCTDMTL.View = View.Details;

            listViewCTDMTL.Columns.Add("MaTL", "Mã tài liệu");
            listViewCTDMTL.Columns.Add("TenTL", "Tên tài liệu");
            listViewCTDMTL.Columns.Add("SoLuong", "Số lượng");
            listViewCTDMTL.Columns.Add("DonGia", "Đơn giá");
            listViewCTDMTL.Columns.Add("LyDoThanhLoc", "Lý do thanh lọc");
            listViewCTDMTL.Columns.Add("PhuongAnXuLy", "Phương án xử lý");
        }

        private void frmDMTL_Load(object sender, EventArgs e)
        {
            txtMaDMTL.Enabled = false;

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

            listViewDMTL.Columns[0].Width = col1Width;
            listViewDMTL.Columns[1].Width = col2Width;
            listViewDMTL.Columns[2].Width = col3Width;
            listViewDMTL.Columns[3].Width = col4Width;

            listViewDMTL.Columns[4].Width = col5Width;
            listViewDMTL.Columns[5].Width = col6Width;
            listViewDMTL.Columns[6].Width = col7Width;
        }

        private void AdjustColumnWidthCT()
        {
            int totalWidth = listViewCTDMTL.ClientSize.Width;
            double col1Percentage = 0.15;
            double col2Percentage = 0.3;
            double col3Percentage = 0.15;
            double col4Percentage = 0.15;

            double col5Percentage = 0.25;
            double col6Percentage = 0.25;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);
            int col5Width = (int)(totalWidth * col5Percentage);
            int col6Width = (int)(totalWidth * col6Percentage);

            listViewCTDMTL.Columns[0].Width = col1Width;
            listViewCTDMTL.Columns[1].Width = col2Width;
            listViewCTDMTL.Columns[2].Width = col3Width;
            listViewCTDMTL.Columns[3].Width = col4Width;
            listViewCTDMTL.Columns[4].Width = col5Width;
            listViewCTDMTL.Columns[5].Width = col6Width;
        }

        public void LoadData()
        {
            try
            {
                if (isSearching)
                    tblDMTL = DMTLDAL.GetDMTLBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblDMTL = DMTLDAL.GetAllDMTL();

                LoadListView();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDataCT(string maDMTL)
        {
            try
            {
                tblCTDMTL = DMTLDAL.GetCTDMTL(maDMTL);

                LoadListViewCT();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadListView()
        {
            ClearListView(listViewDMTL);

            foreach (DataRow row in tblDMTL.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaDMThanhLoc"].ToString());
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

                listViewDMTL.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void LoadListViewCT()
        {
            ClearListView(listViewCTDMTL);

            foreach (DataRow row in tblCTDMTL.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaTL"].ToString());
                item.SubItems.Add(row["TenTL"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(row["DonGia"].ToString());
                item.SubItems.Add(row["LyDoThanhLoc"].ToString());
                item.SubItems.Add(row["PhuongAnXuLy"].ToString());

                listViewCTDMTL.Items.Add(item);
            }

            AdjustColumnWidthCT();
        }

        private void ClearListView(MaterialListView listView)
        {
            listView.Items.Clear();
        }

        private void listViewDMTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaTL.Focus();
                return;
            }

            if (tblDMTL.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewDMTL.SelectedItems.Count > 0)
            {
                txtMaTL.Enabled = true;
                txtSoLuong.Enabled = true;
                txtDonGia.Enabled = true;

                btnThemTL.Enabled = true;

                ListViewItem selectedItem = listViewDMTL.SelectedItems[0];
                txtMaDMTL.Text = selectedItem.SubItems[0].Text;
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

                string maDMTL = txtMaDMTL.Text.Trim();
                LoadDataCT(maDMTL);

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

                ClearListView(listViewCTDMTL);

                txtMaTL.Enabled = false;
                txtSoLuong.Enabled = false;
                txtDonGia.Enabled = false;

                btnThemTL.Enabled = false;
                btnXoaTL.Enabled = false;

                btnDuyet.Enabled = false;
            }
        }

        private void listViewCTDMTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThemTL.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaTL.Focus();
                return;
            }

            if (tblCTDMTL.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewCTDMTL.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCTDMTL.SelectedItems[0];
                txtMaTL.Text = selectedItem.SubItems[0].Text;
                txtTenTL.Text = selectedItem.SubItems[1].Text;
                txtSoLuong.Text = selectedItem.SubItems[2].Text;
                txtDonGia.Text = selectedItem.SubItems[3].Text;
                txtLyDoTL.Text = selectedItem.SubItems[4].Text;
                txtPAXuLy.Text = selectedItem.SubItems[5].Text;

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
            txtMaDMTL.Text = "";
            txtMaNVLap.Text = NhanVienDAL.GetMaNVByUsername(Username);
            txtMaNVDuyet.Text = "";
            txtNgayLap.Text = "";
            txtNgayDuyet.Text = "";
        }

        private void ResetValuesCT()
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtLyDoTL.Text = "";
            txtPAXuLy.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaDMTL.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã danh mục thanh lọc");
                txtMaDMTL.Focus();
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
                Functions.HandleWarning("Bạn phải nhập ngày lập danh mục");
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

            if (string.IsNullOrWhiteSpace(txtLyDoTL.Text))
            {
                Functions.HandleWarning("Bạn phải nhập lý do thanh lọc");
                txtLyDoTL.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPAXuLy.Text))
            {
                Functions.HandleWarning("Bạn phải nhập phương án xử lý");
                txtPAXuLy.Focus();
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

            string newMaDMTL = DMTLDAL.InsertEmptyDMTL();
            txtMaDMTL.Text = newMaDMTL;

            txtMaTL.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maDMTL = txtMaDMTL.Text.Trim();

            ResetValuesCT();
            ResetValues();

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnIn.Enabled = false;

            txtMaDMTL.Enabled = false;

            txtMaTL.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maDMTL))
            {
                DMTLDAL.DeleteEmptyDMTL(maDMTL);
            }

            LoadDataCT("");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDMTL = txtMaDMTL.Text.Trim();

            if (!string.IsNullOrEmpty(maDMTL))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        DMTLDAL.DeleteCTDMTL(maDMTL);
                        DMTLDAL.DeleteDMTL(maDMTL);

                        Functions.HandleInfo("Xóa danh mục thanh lọc thành công");
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
                        Functions.HandleError("Lỗi khi xóa danh mục thanh lọc: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maDMTL = txtMaDMTL.Text.Trim();

            if (!DMTLDAL.CheckMaDMTLExists(maDMTL))
            {
                if (ValidateInput())
                {
                    string maNVLap = txtMaNVLap.Text.Trim();

                    DateTime ngayLap;
                    if (!DateTime.TryParse(txtNgayLap.Text.Trim(), out ngayLap))
                    {
                        Functions.HandleWarning("Ngày lập danh mục không hợp lệ");
                        txtNgayLap.Focus();
                        return;
                    }

                    try
                    {
                        DMTLDAL.UpdateDMTL(maDMTL, maNVLap, ngayLap);

                        Functions.HandleInfo("Lưu danh mục thanh lọc thành công");
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
                        Functions.HandleError("Lỗi khi thêm danh mục thanh lọc: " + ex.Message);
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                string maDMTL = txtMaDMTL.Text;
                DataTable tblThongTinDMTL, tblThongTinCTDMTL;

                tblThongTinDMTL = DMTLDAL.GetThongTinDMTL(maDMTL);
                tblThongTinCTDMTL = DMTLDAL.GetCTDMTL(maDMTL);

                // Tạo và hiển thị trong Excel
                // ExcelHelper.CreateBillThue(tblThongTinDMTL, tblThongTinDMTL);
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi: " + ex.Message);
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            string maNVDuyet = NhanVienDAL.GetMaNVByUsername(Username);
            string maDMTL = txtMaDMTL.Text.Trim();

            DateTime ngayDuyet = DateTime.Now;

            try
            {
                DMTLDAL.DuyetDMTL(maDMTL, maNVDuyet, ngayDuyet);

                Functions.HandleInfo("Duyệt danh mục thanh lọc thành công");
                LoadData();
                LoadDataCT("");

                ResetValues();
                ResetValuesCT();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi duyệt danh mục thanh lọc: " + ex.Message);
            }
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            string maDMTL = txtMaDMTL.Text.Trim();

            if (ValidateInputCT())
            {
                string maTL = txtMaTL.Text.Trim();
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                int donGia = Convert.ToInt32(txtDonGia.Text);

                string lyDo = txtLyDoTL.Text.Trim();
                string phuongAn = txtPAXuLy.Text.Trim();

                if (DMTLDAL.CheckMaTaiLieu(maDMTL, maTL))
                {
                    Functions.HandleWarning("Tài liệu này đã có trong danh mục thanh lọc, vui lòng chọn tài liệu khác hoặc xoá");
                    ResetValuesCT();
                    txtMaTL.Focus();
                    return;
                }

                try
                {
                    DMTLDAL.InsertTaiLieuCTDMTL(maDMTL, maTL, soLuong, donGia, lyDo, phuongAn);
                    Functions.HandleInfo("Thêm chi tiết danh mục thanh lọc thành công");

                    LoadDataCT(maDMTL);
                    ResetValuesCT();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm chi tiết danh mục thanh lọc: " + ex.Message);
                }
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            string maDMTL = txtMaDMTL.Text.Trim();
            string maTL = txtMaTL.Text.Trim();

            if (!string.IsNullOrEmpty(maDMTL) && !string.IsNullOrEmpty(maTL))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        DMTLDAL.DeleteTaiLieuCTDMTL(maDMTL, maTL);
                        Functions.HandleInfo("Xóa tài liệu trong danh mục thanh lọc thành công");

                        LoadDataCT(maDMTL);
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