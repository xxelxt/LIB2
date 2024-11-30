using LIB2.Class;
using LIB2.Class.Types;
using LIB2.DAL;
using LIB2.Database;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmPYCBS : MaterialForm
    {
        public UserRole currentRole;
        public string Username { get; set; }

        private DataTable tblPYCBS;
        private DataTable tblCTPYCBS;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        public frmPYCBS()
        {
            InitializeComponent();

            InitializeListView();
            InitializeListViewCT();

            LoadData();

            string fillComboLAP = "SELECT * FROM LoaiAnPham";
            DatabaseLayer.FillCombo(fillComboLAP, cboLoaiTL, "MaLoaiAP", "TenLoaiAP");
            cboLoaiTL.SelectedItem = null;

            cboTimKiem.Items.Add("Mã phiếu");
            cboTimKiem.Items.Add("Nhân viên lập");
            cboTimKiem.Items.Add("Nhân viên duyệt");
            cboTimKiem.Items.Add("Ngày lập");
            cboTimKiem.Items.Add("Ngày duyệt");

            cboMDYC.Items.Add("Cao");
            cboMDYC.Items.Add("Trung bình");
            cboMDYC.Items.Add("Thấp");
        }

        private void InitializeListView()
        {
            listViewPYCBS.FullRowSelect = true;
            listViewPYCBS.MultiSelect = false;
            listViewPYCBS.UseCompatibleStateImageBehavior = false;
            listViewPYCBS.View = View.Details;

            listViewPYCBS.Columns.Add("MaPhieuYCBS", "Mã phiếu");

            listViewPYCBS.Columns.Add("MaNVLap", "Mã nhân viên lập");
            listViewPYCBS.Columns.Add("TenNVLap", "Tên nhân viên lập");
            listViewPYCBS.Columns.Add("MaNVDuyet", "Mã nhân viên duyệt");
            listViewPYCBS.Columns.Add("TenNVDuyet", "Tên nhân viên duyệt");

            listViewPYCBS.Columns.Add("NgayLap", "Ngày lập");
            listViewPYCBS.Columns.Add("NgayDuyet", "Ngày duyệt");
        }

        private void InitializeListViewCT()
        {
            listViewCTPYCBS.FullRowSelect = true;
            listViewCTPYCBS.MultiSelect = false;
            listViewCTPYCBS.UseCompatibleStateImageBehavior = false;
            listViewCTPYCBS.View = View.Details;

            listViewCTPYCBS.Columns.Add("TenTL", "Tên tài liệu");
            listViewCTPYCBS.Columns.Add("TacGia", "Tác giả");
            listViewCTPYCBS.Columns.Add("NhaXuatBan", "Nhà xuất bản");

            listViewCTPYCBS.Columns.Add("NamXuatBan", "Năm xuất bản");
            listViewCTPYCBS.Columns.Add("MoTa", "Mô tả");
            listViewCTPYCBS.Columns.Add("LoaiAnPham", "Loại ấn phẩm");

            listViewCTPYCBS.Columns.Add("SoLuong", "Số lượng");
            listViewCTPYCBS.Columns.Add("MucDoYC", "Mức độ yêu cầu");
        }

        private void frmPYCBS_Load(object sender, EventArgs e)
        {
            txtMaPYCBS.Enabled = false;

            btnXoa.Enabled = false;
            btnLuu.Enabled = false;

            btnHuy.Enabled = false;
            btnIn.Enabled = false;

            btnThemTL.Enabled = false;
            btnXoaTL.Enabled = false;

            txtTenTL.Enabled = false;
            txtTenTG.Enabled = false;
            txtNhaXB.Enabled = false;

            txtNamXB.Enabled = false;
            txtMoTa.Enabled = false;
            cboLoaiTL.Enabled = false;

            cboMDYC.Enabled = false;
            txtSoLuong.Enabled = false;

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

            listViewPYCBS.Columns[0].Width = col1Width;
            listViewPYCBS.Columns[1].Width = col2Width;
            listViewPYCBS.Columns[2].Width = col3Width;
            listViewPYCBS.Columns[3].Width = col4Width;

            listViewPYCBS.Columns[4].Width = col5Width;
            listViewPYCBS.Columns[5].Width = col6Width;
            listViewPYCBS.Columns[6].Width = col7Width;
        }

        private void AdjustColumnWidthCT()
        {
            int totalWidth = listViewCTPYCBS.ClientSize.Width;
            double col1Percentage = 0.1;
            double col2Percentage = 0.2;
            double col3Percentage = 0.2;
            double col4Percentage = 0.1;

            double col5Percentage = 0.15;
            double col6Percentage = 0.1;
            double col7Percentage = 0.05;
            double col8Percentage = 0.1;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);

            int col5Width = (int)(totalWidth * col5Percentage);
            int col6Width = (int)(totalWidth * col6Percentage);
            int col7Width = (int)(totalWidth * col7Percentage);
            int col8Width = (int)(totalWidth * col8Percentage);

            listViewCTPYCBS.Columns[0].Width = col1Width;
            listViewCTPYCBS.Columns[1].Width = col2Width;
            listViewCTPYCBS.Columns[2].Width = col3Width;
            listViewCTPYCBS.Columns[3].Width = col4Width;

            listViewCTPYCBS.Columns[4].Width = col5Width;
            listViewCTPYCBS.Columns[5].Width = col6Width;
            listViewCTPYCBS.Columns[6].Width = col7Width;
            listViewCTPYCBS.Columns[7].Width = col8Width;
        }

        public void LoadData()
        {
            try
            {
                if (isSearching)
                    tblPYCBS = PYCBSDAL.GetPYCBSBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblPYCBS = PYCBSDAL.GetAllPYCBS();

                LoadListView();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDataCT(string maPYCBS)
        {
            try
            {
                tblCTPYCBS = PYCBSDAL.GetCTPYCBS(maPYCBS);

                LoadListViewCT();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadListView()
        {
            ClearListView(listViewPYCBS);

            foreach (DataRow row in tblPYCBS.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaPhieuYCBS"].ToString());
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

                listViewPYCBS.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void LoadListViewCT()
        {
            ClearListView(listViewCTPYCBS);

            foreach (DataRow row in tblCTPYCBS.Rows)
            {
                ListViewItem item = new ListViewItem(row["TenTL"].ToString());
                item.SubItems.Add(row["TacGia"].ToString());
                item.SubItems.Add(row["NhaXuatBan"].ToString());
                item.SubItems.Add(row["NamXuatBan"].ToString());

                item.SubItems.Add(row["MoTa"].ToString());
                item.SubItems.Add(row["LoaiAnPham"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(row["MucDoYC"].ToString());

                listViewCTPYCBS.Items.Add(item);
            }

            AdjustColumnWidthCT();
        }

        private void ClearListView(MaterialListView listView)
        {
            listView.Items.Clear();
        }

        private void listViewPYCBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtTenTL.Focus();
                return;
            }

            if (tblPYCBS.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewPYCBS.SelectedItems.Count > 0)
            {
                txtTenTL.Enabled = true;
                txtTenTG.Enabled = true;
                txtNhaXB.Enabled = true;

                txtNamXB.Enabled = true;
                txtMoTa.Enabled = true;
                cboLoaiTL.Enabled = true;

                cboMDYC.Enabled = true;
                txtSoLuong.Enabled = true;

                btnThemTL.Enabled = true;

                ListViewItem selectedItem = listViewPYCBS.SelectedItems[0];
                txtMaPYCBS.Text = selectedItem.SubItems[0].Text;
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

                string maPYCBS = txtMaPYCBS.Text.Trim();
                LoadDataCT(maPYCBS);

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

                ClearListView(listViewCTPYCBS);

                txtTenTL.Enabled = false;
                txtTenTG.Enabled = false;
                txtNhaXB.Enabled = false;

                txtNamXB.Enabled = false;
                txtMoTa.Enabled = false;
                cboLoaiTL.Enabled = false;

                cboMDYC.Enabled = false;
                txtSoLuong.Enabled = false;

                btnThemTL.Enabled = false;
                btnXoaTL.Enabled = false;

                btnDuyet.Enabled = false;
            }
        }

        private void listViewCTPYCBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThemTL.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtTenTL.Focus();
                return;
            }

            if (tblCTPYCBS.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewCTPYCBS.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCTPYCBS.SelectedItems[0];
                txtTenTL.Text = selectedItem.SubItems[0].Text;
                txtTenTG.Text = selectedItem.SubItems[1].Text;
                txtNhaXB.Text = selectedItem.SubItems[2].Text;
                txtNamXB.Text = selectedItem.SubItems[3].Text;
                txtMoTa.Text = selectedItem.SubItems[4].Text;
                cboLoaiTL.Text = DatabaseLayer.GetFieldValues("SELECT TenLoaiAP FROM LoaiAnPham WHERE MaLoaiAP = N'" + selectedItem.SubItems[5].Text + "';");
                txtSoLuong.Text = selectedItem.SubItems[6].Text;
                cboMDYC.SelectedIndex = cboMDYC.FindStringExact(selectedItem.SubItems[7].Text);

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
            txtMaPYCBS.Text = "";
            txtMaNVLap.Text = NhanVienDAL.GetMaNVByUsername(Username);
            txtMaNVDuyet.Text = "";
            txtNgayLap.Text = "";
            txtNgayDuyet.Text = "";
        }

        private void ResetValuesCT()
        {
            txtTenTL.Text = "";
            txtTenTG.Text = "";
            txtNhaXB.Text = "";
            txtNamXB.Text = "";
            txtMoTa.Text = "";
            txtSoLuong.Text = "";

            cboLoaiTL.SelectedItem = null;
            cboMDYC.SelectedItem = null;
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaPYCBS.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã phiếu yêu cầu bổ sung");
                txtMaPYCBS.Focus();
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

            return true;
        }

        private bool ValidateInputCT()
        {
            if (string.IsNullOrWhiteSpace(txtTenTL.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên tài liệu");
                txtTenTL.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenTG.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên tác giả");
                txtTenTG.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNhaXB.Text))
            {
                Functions.HandleWarning("Bạn phải nhập nhà xuất bản");
                txtNhaXB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNamXB.Text))
            {
                Functions.HandleWarning("Bạn phải nhập năm xuất bản");
                txtNamXB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mô tả");
                txtMoTa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số lượng");
                txtSoLuong.Focus();
                return false;
            }

            if (cboLoaiTL.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn loại ấn phẩm");
                cboLoaiTL.Focus();
                return false;
            }

            if (cboMDYC.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn mức độ yêu cầu");
                cboMDYC.Focus();
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

            txtTenTL.Enabled = true;
            txtTenTG.Enabled = true;
            txtNhaXB.Enabled = true;

            txtNamXB.Enabled = true;
            txtMoTa.Enabled = true;
            cboLoaiTL.Enabled = true;

            cboMDYC.Enabled = true;
            txtSoLuong.Enabled = true;

            btnThemTL.Enabled = true;

            ResetValues();
            ResetValuesCT();

            LoadDataCT("");

            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime today = DateTime.Now;

            string newMaPYCBS = PYCBSDAL.InsertEmptyPYCBS();
            txtMaPYCBS.Text = newMaPYCBS;

            txtTenTL.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maPYCBS = txtMaPYCBS.Text.Trim();

            ResetValuesCT();
            ResetValues();

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnIn.Enabled = false;

            txtMaPYCBS.Enabled = false;

            txtTenTL.Enabled = false;
            txtTenTG.Enabled = false;
            txtNhaXB.Enabled = false;

            txtNamXB.Enabled = false;
            txtMoTa.Enabled = false;
            cboLoaiTL.Enabled = false;

            cboMDYC.Enabled = false;
            txtSoLuong.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maPYCBS))
            {
                PYCBSDAL.DeleteEmptyPYCBS(maPYCBS);
            }

            LoadDataCT("");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPYCBS = txtMaPYCBS.Text.Trim();

            if (!string.IsNullOrEmpty(maPYCBS))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        PYCBSDAL.DeleteCTPYCBS(maPYCBS);
                        PYCBSDAL.DeletePYCBS(maPYCBS);

                        Functions.HandleInfo("Xóa phiếu yêu cầu bổ sung thành công");
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
                        Functions.HandleError("Lỗi khi xóa phiếu yêu cầu bổ sung: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maPYCBS = txtMaPYCBS.Text.Trim();

            if (!PYCBSDAL.CheckMaPYCBSExists(maPYCBS))
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

                    try
                    {
                        PYCBSDAL.UpdatePYCBS(maPYCBS, maNVLap, ngayLap);

                        Functions.HandleInfo("Lưu phiếu yêu cầu bổ sung thành công");
                        LoadData();
                        LoadDataCT("");

                        ResetValues();
                        ResetValuesCT();

                        btnThem.Enabled = true;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                        btnLuu.Enabled = false;
                        btnIn.Enabled = false;

                        txtTenTL.Enabled = false;
                        txtTenTG.Enabled = false;
                        txtNhaXB.Enabled = false;

                        txtNamXB.Enabled = false;
                        txtMoTa.Enabled = false;
                        cboLoaiTL.Enabled = false;

                        cboMDYC.Enabled = false;
                        txtSoLuong.Enabled = false;

                        btnThemTL.Enabled = false;
                        btnXoaTL.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi thêm phiếu yêu cầu bổ sung: " + ex.Message);
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                string maPYCBS = txtMaPYCBS.Text;
                DataTable tblThongTinPYCBS, tblThongTinCTPYCBS;

                tblThongTinPYCBS = PYCBSDAL.GetThongTinPYCBS(maPYCBS);
                tblThongTinCTPYCBS = PYCBSDAL.GetCTPYCBS(maPYCBS);

                // Tạo và hiển thị trong Excel
                // ExcelHelper.CreateBillThue(tblThongTinPYCBS, tblThongTinPYCBS);
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi: " + ex.Message);
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            string maNVDuyet = NhanVienDAL.GetMaNVByUsername(Username);
            string maPYCBS = txtMaPYCBS.Text.Trim();

            DateTime ngayDuyet = DateTime.Now;

            try
            {
                PYCBSDAL.DuyetPYCBS(maPYCBS, maNVDuyet, ngayDuyet);

                Functions.HandleInfo("Duyệt phiếu yêu cầu bổ sung thành công");
                LoadData();
                LoadDataCT("");

                ResetValues();
                ResetValuesCT();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi duyệt phiếu yêu cầu bổ sung: " + ex.Message);
            }
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            string maPYCBS = txtMaPYCBS.Text.Trim();

            if (ValidateInputCT())
            {
                string tenTL = txtTenTL.Text.Trim();
                string tenTG = txtTenTG.Text.Trim();
                string nhaXB = txtNhaXB.Text.Trim();

                int namXB = Convert.ToInt32(txtNamXB.Text);
                string moTa = txtMoTa.Text.Trim();
                string loaiTL = cboLoaiTL.SelectedValue.ToString();

                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                string mucDoYC = cboMDYC.Text;

                try
                {
                    PYCBSDAL.InsertTaiLieuCTPYCBS(maPYCBS, tenTL, tenTG, nhaXB, namXB, moTa, loaiTL, soLuong, mucDoYC);
                    Functions.HandleInfo("Thêm chi tiết phiếu yêu cầu bổ sung thành công");

                    LoadDataCT(maPYCBS);
                    ResetValuesCT();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm chi tiết phiếu yêu cầu bổ sung: " + ex.Message);
                }
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            string maPYCBS = txtMaPYCBS.Text.Trim();
            string tenTL = txtTenTL.Text.Trim();

            if (!string.IsNullOrEmpty(maPYCBS) && !string.IsNullOrEmpty(tenTL))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        PYCBSDAL.DeleteTaiLieuCTPYCBS(maPYCBS, tenTL);
                        Functions.HandleInfo("Xóa tài liệu trong phiếu yêu cầu bổ sung thành công");

                        LoadDataCT(maPYCBS);
                        ResetValuesCT();
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa tài liệu: " + ex.Message);
                    }
                }
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

        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
