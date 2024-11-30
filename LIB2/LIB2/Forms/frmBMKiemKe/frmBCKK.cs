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
    public partial class frmBCKK : MaterialForm
    {
        public UserRole currentRole;
        public string Username { get; set; }

        private DataTable tblBCKK;
        private DataTable tblCTBCKK;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        public frmBCKK()
        {
            InitializeComponent();

            InitializeListView();
            InitializeListViewCT();

            LoadData();

            cboTimKiem.Items.Add("Mã báo cáo");
            cboTimKiem.Items.Add("Nhân viên lập");
            cboTimKiem.Items.Add("Nhân viên duyệt");
            cboTimKiem.Items.Add("Ngày lập");
            cboTimKiem.Items.Add("Ngày duyệt");

            string fillComboPKK = "SELECT * FROM PhieuKiemKe";
            DatabaseLayer.FillCombo(fillComboPKK, cboMaPKK, "MaPhieuKiemKe", "MaPhieuKiemKe");
            cboMaPKK.SelectedItem = null;

            string fillComboDMSC = "SELECT * FROM DMSuaChua";
            DatabaseLayer.FillCombo(fillComboDMSC, cboMaDMSC, "MaDMSuaChua", "MaDMSuaChua");
            cboMaDMSC.SelectedItem = null;

            string fillComboDMBT = "SELECT * FROM DMBoiThuong";
            DatabaseLayer.FillCombo(fillComboDMBT, cboMaDMBT, "MaDMBoiThuong", "MaDMBoiThuong");
            cboMaDMBT.SelectedItem = null;
        }

        private void InitializeListView()
        {
            listViewBCKK.FullRowSelect = true;
            listViewBCKK.MultiSelect = false;
            listViewBCKK.UseCompatibleStateImageBehavior = false;
            listViewBCKK.View = View.Details;

            listViewBCKK.Columns.Add("MaBCKiemKe", "Mã báo cáo");

            listViewBCKK.Columns.Add("MaNVLap", "Mã nhân viên lập");
            listViewBCKK.Columns.Add("TenNVLap", "Tên nhân viên lập");
            listViewBCKK.Columns.Add("MaNVDuyet", "Mã nhân viên duyệt");
            listViewBCKK.Columns.Add("TenNVDuyet", "Tên nhân viên duyệt");

            listViewBCKK.Columns.Add("NgayLap", "Ngày lập");
            listViewBCKK.Columns.Add("NgayDuyet", "Ngày duyệt");

            listViewBCKK.Columns.Add("TGBD", "TG bắt đầu");
            listViewBCKK.Columns.Add("TGKT", "TG kết thúc");
        }

        private void InitializeListViewCT()
        {
            listViewCTBCKK.FullRowSelect = true;
            listViewCTBCKK.MultiSelect = false;
            listViewCTBCKK.UseCompatibleStateImageBehavior = false;
            listViewCTBCKK.View = View.Details;

            listViewCTBCKK.Columns.Add("MaTL", "Mã kho");
            listViewCTBCKK.Columns.Add("TenTL", "Tên kho");
            listViewCTBCKK.Columns.Add("SoLuong", "Số lượng");
        }

        private void frmBCKK_Load(object sender, EventArgs e)
        {
            txtMaBCKK.Enabled = false;

            btnXoa.Enabled = false;
            btnLuu.Enabled = false;

            btnHuy.Enabled = false;
            btnIn.Enabled = false;

            btnThemKho.Enabled = false;
            btnXoaKho.Enabled = false;

            txtMaKho.Enabled = false;
            txtTenKho.Enabled = false;
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
            int col8Width = 100;
            int col9Width = 100;

            listViewBCKK.Columns[0].Width = col1Width;
            listViewBCKK.Columns[1].Width = col2Width;
            listViewBCKK.Columns[2].Width = col3Width;
            listViewBCKK.Columns[3].Width = col4Width;

            listViewBCKK.Columns[4].Width = col5Width;
            listViewBCKK.Columns[5].Width = col6Width;
            listViewBCKK.Columns[6].Width = col7Width;
            listViewBCKK.Columns[7].Width = col8Width;
            listViewBCKK.Columns[8].Width = col9Width;
        }

        private void AdjustColumnWidthCT()
        {
            int totalWidth = listViewCTBCKK.ClientSize.Width;
            double col1Percentage = 0.3;
            double col2Percentage = 0.4;
            double col3Percentage = 0.3;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);

            listViewCTBCKK.Columns[0].Width = col1Width;
            listViewCTBCKK.Columns[1].Width = col2Width;
            listViewCTBCKK.Columns[2].Width = col3Width;
        }

        public void LoadData()
        {
            try
            {
                if (isSearching)
                    tblBCKK = BCKKDAL.GetBCKKBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblBCKK = BCKKDAL.GetAllBCKK();

                LoadListView();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDataCT(string maBCKK)
        {
            try
            {
                tblCTBCKK = BCKKDAL.GetCTBCKK(maBCKK);

                LoadListViewCT();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadListView()
        {
            ClearListView(listViewBCKK);

            foreach (DataRow row in tblBCKK.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaBCKiemKe"].ToString());
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

                DateTime TGBD;
                if (DateTime.TryParse(row["TGBD"].ToString(), out TGBD))
                {
                    string TGBDFormatted = TGBD.ToString("dd/MM/yyyy");

                    item.SubItems.Add(TGBDFormatted);
                }
                else
                {
                    item.SubItems.Add("");
                }

                DateTime TGKT;
                if (DateTime.TryParse(row["TGKT"].ToString(), out TGKT))
                {
                    string TGKTFormatted = TGKT.ToString("dd/MM/yyyy");

                    item.SubItems.Add(TGKTFormatted);
                }
                else
                {
                    item.SubItems.Add("");
                }

                item.Tag = new
                {
                    MaPhieuKiemKe = row["MaPhieuKiemKe"].ToString(),
                    MaDMSuaChua = row["MaDMSuaChua"].ToString(),
                    MaDMBoiThuong = row["MaDMBoiThuong"].ToString(),

                    SoTLXepNhamKho = row["SoTLXepNhamKho"].ToString(),
                    SoTLMat = row["SoTLMat"].ToString(),
                    TongTienTLMat = row["TongTienTLMat"].ToString(),

                    SoTLSuaChua = row["SoTLSuaChua"].ToString(),
                    SoTLBoiThuong = row["SoTLBoiThuong"].ToString(),
                    TongTienBoiThuong = row["TongTienBoiThuong"].ToString()
                };

                listViewBCKK.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void LoadListViewCT()
        {
            ClearListView(listViewCTBCKK);

            foreach (DataRow row in tblCTBCKK.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaKho"].ToString());
                item.SubItems.Add(row["TenKho"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());

                listViewCTBCKK.Items.Add(item);
            }

            AdjustColumnWidthCT();
        }

        private void ClearListView(MaterialListView listView)
        {
            listView.Items.Clear();
        }

        private void listViewBCKK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaKho.Focus();
                return;
            }

            if (tblBCKK.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewBCKK.SelectedItems.Count > 0)
            {
                txtMaKho.Enabled = true;
                txtSoLuong.Enabled = true;

                btnThemKho.Enabled = true;

                ListViewItem selectedItem = listViewBCKK.SelectedItems[0];
                txtMaBCKK.Text = selectedItem.SubItems[0].Text;
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

                string TGBDStr = selectedItem.SubItems[7].Text;
                DateTime TGBD;
                if (DateTime.TryParse(TGBDStr, out TGBD))
                {
                    txtTGBD.Text = TGBD.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtTGBD.Text = "";
                }

                string TGKTStr = selectedItem.SubItems[8].Text;
                DateTime TGKT;
                if (DateTime.TryParse(TGKTStr, out TGKT))
                {
                    txtTGKT.Text = TGKT.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtTGKT.Text = "";
                }

                var tagData = (dynamic)selectedItem.Tag;
                if (tagData != null)
                {
                    cboMaPKK.SelectedIndex = cboMaPKK.FindStringExact(tagData.MaPhieuKiemKe?.ToString() ?? "");
                    cboMaDMSC.SelectedIndex = cboMaDMSC.FindStringExact(tagData.MaDMSuaChua?.ToString() ?? "");
                    cboMaDMBT.SelectedIndex = cboMaDMBT.FindStringExact(tagData.MaDMBoiThuong?.ToString() ?? "");

                    txtSoTLXNK.Text = tagData.SoTLXepNhamKho?.ToString() ?? "";
                    txtSoTLMat.Text = tagData.SoTLMat?.ToString() ?? "";
                    txtTongTienTLMat.Text = tagData.TongTienTLMat?.ToString() ?? "";

                    txtSoTLSC.Text = tagData.SoTLSuaChua?.ToString() ?? "";
                    txtSoTLBT.Text = tagData.SoTLBoiThuong?.ToString() ?? "";
                    txtTongTienBT.Text = tagData.TongTienBoiThuong?.ToString() ?? "";
                }

                string maBCKK = txtMaBCKK.Text.Trim();
                LoadDataCT(maBCKK);

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

                ClearListView(listViewCTBCKK);

                txtMaKho.Enabled = false;
                txtSoLuong.Enabled = false;

                btnThemKho.Enabled = false;
                btnXoaKho.Enabled = false;

                btnDuyet.Enabled = false;
            }
        }

        private void listViewCTBCKK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThemKho.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaKho.Focus();
                return;
            }

            if (tblCTBCKK.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewCTBCKK.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCTBCKK.SelectedItems[0];
                txtMaKho.Text = selectedItem.SubItems[0].Text;
                txtTenKho.Text = selectedItem.SubItems[1].Text;
                txtSoLuong.Text = selectedItem.SubItems[2].Text;

                btnXoaKho.Enabled = true;
            }
            else
            {
                ResetValuesCT();

                btnXoaKho.Enabled = false;
            }
        }

        private void ResetValues()
        {
            txtMaBCKK.Text = "";

            txtMaNVLap.Text = NhanVienDAL.GetMaNVByUsername(Username);
            txtMaNVDuyet.Text = "";
            txtNgayLap.Text = "";
            txtNgayDuyet.Text = "";

            txtTGBD.Text = "";
            txtTGKT.Text = "";

            cboMaPKK.SelectedItem = null;
            cboMaDMSC.SelectedItem = null;
            cboMaDMBT.SelectedItem = null;

            txtSoTLXNK.Text = "";
            txtSoTLMat.Text = "";
            txtTongTienTLMat.Text = "";

            txtSoTLSC.Text = "";
            txtSoTLBT.Text = "";
            txtTongTienBT.Text = "";
        }

        private void ResetValuesCT()
        {
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            txtSoLuong.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaBCKK.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã báo cáo kiểm kê");
                txtMaBCKK.Focus();
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
                Functions.HandleWarning("Bạn phải nhập ngày lập báo cáo");
                txtNgayLap.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTGBD.Text))
            {
                Functions.HandleWarning("Bạn phải nhập thời gian bắt đầu kiểm kê");
                txtTGBD.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTGKT.Text))
            {
                Functions.HandleWarning("Bạn phải nhập thời gian kết thúc kiểm kê");
                txtTGKT.Focus();
                return false;
            }

            if (cboMaPKK.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn mã phiếu kiểm kê");
                cboMaPKK.Focus();
                return false;
            }

            if (cboMaDMSC.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn mã danh mục sửa chữa");
                cboMaDMSC.Focus();
                return false;
            }

            if (cboMaDMBT.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn mã danh mục bồi thường");
                cboMaDMBT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoTLXNK.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số tài liệu xếp nhầm kho");
                txtSoTLXNK.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoTLMat.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số tài liệu mất");
                txtSoTLMat.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTongTienTLMat.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tổng tiền tài liệu mất");
                txtTongTienTLMat.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoTLSC.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số tài liệu sửa chữa");
                txtSoTLSC.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoTLBT.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số tài liệu bồi thường");
                txtSoTLBT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTongTienBT.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tổng tiền bồi thường");
                txtTongTienBT.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateInputCT()
        {
            if (string.IsNullOrWhiteSpace(txtMaKho.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã kho");
                txtMaKho.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenKho.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên kho");
                txtTenKho.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số lượng");
                txtSoLuong.Focus();
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

            txtMaKho.Enabled = true;
            txtSoLuong.Enabled = true;
            btnThemKho.Enabled = true;

            ResetValues();
            ResetValuesCT();

            LoadDataCT("");

            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime today = DateTime.Now;

            string newMaBCKK = BCKKDAL.InsertEmptyBCKK();
            txtMaBCKK.Text = newMaBCKK;

            txtMaKho.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maBCKK = txtMaBCKK.Text.Trim();

            ResetValuesCT();
            ResetValues();

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnIn.Enabled = false;

            txtMaBCKK.Enabled = false;

            txtMaKho.Enabled = false;
            txtSoLuong.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maBCKK))
            {
                BCKKDAL.DeleteEmptyBCKK(maBCKK);
            }

            LoadDataCT("");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maBCKK = txtMaBCKK.Text.Trim();

            if (!string.IsNullOrEmpty(maBCKK))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        BCKKDAL.DeleteCTBCKK(maBCKK);
                        BCKKDAL.DeleteBCKK(maBCKK);

                        Functions.HandleInfo("Xóa báo cáo kiểm kê thành công");
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
                        Functions.HandleError("Lỗi khi xóa báo cáo kiểm kê: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maBCKK = txtMaBCKK.Text.Trim();

            if (!BCKKDAL.CheckMaBCKKExists(maBCKK))
            {
                if (ValidateInput())
                {
                    string maNVLap = txtMaNVLap.Text.Trim();

                    DateTime ngayLap;
                    if (!DateTime.TryParse(txtNgayLap.Text.Trim(), out ngayLap))
                    {
                        Functions.HandleWarning("Ngày lập báo cáo không hợp lệ");
                        txtNgayLap.Focus();
                        return;
                    }

                    DateTime TGBD;
                    if (!DateTime.TryParse(txtTGBD.Text.Trim(), out TGBD))
                    {
                        Functions.HandleWarning("Thời gian bắt đầu kiểm kê không hợp lệ");
                        txtTGBD.Focus();
                        return;
                    }

                    DateTime TGKT;
                    if (!DateTime.TryParse(txtTGKT.Text.Trim(), out TGKT))
                    {
                        Functions.HandleWarning("Thời gian kết thúc kiểm kê không hợp lệ");
                        txtTGKT.Focus();
                        return;
                    }

                    string maPKK = cboMaPKK.SelectedValue.ToString();
                    string maDMSC = cboMaDMSC.SelectedValue.ToString();
                    string maDMBT = cboMaDMBT.SelectedValue.ToString();

                    int soTLXNK = Convert.ToInt32(txtSoTLXNK.Text);
                    int soTLMat = Convert.ToInt32(txtSoTLMat.Text);
                    int tongTienTLMat = Convert.ToInt32(txtTongTienTLMat.Text);

                    int soTLSC = Convert.ToInt32(txtSoTLSC.Text);
                    int soTLBT = Convert.ToInt32(txtSoTLBT.Text);
                    int tongTienBT = Convert.ToInt32(txtTongTienBT.Text);

                    try
                    {
                        BCKKDAL.UpdateBCKK(maBCKK, maNVLap, maPKK, maDMSC, maDMBT, ngayLap, TGBD, TGKT, 
                            soTLXNK, soTLMat, tongTienTLMat, soTLSC, soTLBT, tongTienBT);

                        Functions.HandleInfo("Lưu báo cáo kiểm kê thành công");
                        LoadData();
                        LoadDataCT("");

                        ResetValues();
                        ResetValuesCT();

                        btnThem.Enabled = true;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                        btnLuu.Enabled = false;
                        btnIn.Enabled = false;

                        txtMaKho.Enabled = false;
                        txtSoLuong.Enabled = false;
                        btnThemKho.Enabled = false;
                        btnXoaKho.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi thêm báo cáo kiểm kê: " + ex.Message);
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                string maBCKK = txtMaBCKK.Text;
                DataTable tblThongTinBCKK, tblThongTinCTBCKK;

                tblThongTinBCKK = BCKKDAL.GetThongTinBCKK(maBCKK);
                tblThongTinCTBCKK = BCKKDAL.GetCTBCKK(maBCKK);

                // Tạo và hiển thị trong Excel
                // ExcelHelper.CreateBillThue(tblThongTinBCKK, tblThongTinBCKK);
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi: " + ex.Message);
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            string maNVDuyet = NhanVienDAL.GetMaNVByUsername(Username);
            string maBCKK = txtMaBCKK.Text.Trim();

            DateTime ngayDuyet = DateTime.Now;

            try
            {
                BCKKDAL.DuyetBCKK(maBCKK, maNVDuyet, ngayDuyet);

                Functions.HandleInfo("Duyệt báo cáo kiểm kê thành công");
                LoadData();
                LoadDataCT("");

                ResetValues();
                ResetValuesCT();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi duyệt báo cáo kiểm kê: " + ex.Message);
            }
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            string maBCKK = txtMaBCKK.Text.Trim();

            if (ValidateInputCT())
            {
                string maKho = txtMaKho.Text.Trim();
                int soLuong = Convert.ToInt32(txtSoLuong.Text);

                if (BCKKDAL.CheckMaKho(maBCKK, maKho))
                {
                    Functions.HandleWarning("Kho này đã có trong báo cáo kiểm kê, vui lòng chọn kho khác hoặc xoá");
                    ResetValuesCT();
                    txtMaKho.Focus();
                    return;
                }

                try
                {
                    BCKKDAL.InsertKhoCTBCKK(maBCKK, maKho, soLuong);
                    Functions.HandleInfo("Thêm chi tiết báo cáo kiểm kê thành công");

                    LoadDataCT(maBCKK);
                    ResetValuesCT();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm chi tiết báo cáo kiểm kê: " + ex.Message);
                }
            }
        }

        private void btnXoaKho_Click(object sender, EventArgs e)
        {
            string maBCKK = txtMaBCKK.Text.Trim();
            string maKho = txtMaKho.Text.Trim();

            if (!string.IsNullOrEmpty(maBCKK) && !string.IsNullOrEmpty(maKho))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        BCKKDAL.DeleteKhoCTBCKK(maBCKK, maKho);
                        Functions.HandleInfo("Xóa kho trong báo cáo kiểm kê thành công");

                        LoadDataCT(maBCKK);
                        ResetValuesCT();
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa kho: " + ex.Message);
                    }
                }
            }
        }

        private void txtMaKho_TextChanged(object sender, EventArgs e)
        {
            string maKho = txtMaKho.Text.Trim();

            if (!string.IsNullOrEmpty(maKho))
            {
                string tenKho = KhoDAL.GetTenKhoByMa(maKho);
                if (!string.IsNullOrEmpty(tenKho))
                {
                    txtTenKho.Text = tenKho;
                }
            }
            else
            {
                txtTenKho.Text = "";
            }
        }

        private void cboMaDMSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaDMSC.SelectedItem != null)
            {
                string maDMSC = cboMaDMSC.SelectedValue.ToString();

                int soTL = DMSCDAL.GetSoTLByMa(maDMSC);

                txtSoTLSC.Text = soTL.ToString();
            }
            else
            {
                txtSoTLSC.Text = String.Empty;
            }
        }

        private void cboMaDMBT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaDMBT.SelectedItem != null)
            {
                string maDMBT = cboMaDMBT.SelectedValue.ToString();

                var DMBTInfo = DMBTDAL.GetSLTongTienBTByMa(maDMBT);
                if (DMBTInfo != null)
                {
                    txtSoTLBT.Text = DMBTInfo.Item1;
                    txtTongTienBT.Text = DMBTInfo.Item2;
                }
                else
                {
                    txtSoTLBT.Text = string.Empty;
                    txtTongTienBT.Text = string.Empty;
                }
            }
            else
            {
                txtSoTLBT.Text = string.Empty;
                txtTongTienBT.Text = string.Empty;
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

        private void txtSoTLXNK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTLMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTongTienTLMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTLSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTLBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTongTienBoiThuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
