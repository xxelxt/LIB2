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
    public partial class frmBCTL : MaterialForm
    {
        public UserRole currentRole;
        public string Username { get; set; }

        private DataTable tblBCTL;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        public frmBCTL()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();

            cboTimKiem.Items.Add("Mã báo cáo");
            cboTimKiem.Items.Add("Nhân viên lập");
            cboTimKiem.Items.Add("Nhân viên duyệt");
            cboTimKiem.Items.Add("Ngày lập");
            cboTimKiem.Items.Add("Ngày duyệt");

            string fillComboTL = "SELECT * FROM DMThanhLoc";
            DatabaseLayer.FillCombo(fillComboTL, cboMaDMTL, "MaDMThanhLoc", "MaDMThanhLoc");
            cboMaDMTL.SelectedItem = null;
        }

        private void InitializeListView()
        {
            listViewBCTL.FullRowSelect = true;
            listViewBCTL.MultiSelect = false;
            listViewBCTL.UseCompatibleStateImageBehavior = false;
            listViewBCTL.View = View.Details;

            listViewBCTL.Columns.Add("MaBCTL", "Mã báo cáo");
            listViewBCTL.Columns.Add("MaNVLap", "Mã nhân viên lập");
            listViewBCTL.Columns.Add("TenNVLap", "Tên nhân viên lập");
            listViewBCTL.Columns.Add("MaNVDuyet", "Mã nhân viên duyệt");
            listViewBCTL.Columns.Add("TenNVDuyet", "Tên nhân viên duyệt");

            listViewBCTL.Columns.Add("NgayLap", "Ngày lập");
            listViewBCTL.Columns.Add("NgayDuyet", "Ngày duyệt");

            listViewBCTL.Columns.Add("SoTLChuyenDoiMD", "Số TL chuyển đổi mục đích");
            listViewBCTL.Columns.Add("SoTLThanhLoc", "Số TL thanh lọc");
            listViewBCTL.Columns.Add("TongTien", "Tổng tiền");
        }

        private void frmBCTL_Load(object sender, EventArgs e)
        {
            txtMaBCTL.Enabled = false;

            btnXoa.Enabled = false;
            btnLuu.Enabled = false;

            btnHuy.Enabled = false;
            btnIn.Enabled = false;

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

            int col8Width = 150;
            int col9Width = 150;
            int col10Width = 150;

            listViewBCTL.Columns[0].Width = col1Width;
            listViewBCTL.Columns[1].Width = col2Width;
            listViewBCTL.Columns[2].Width = col3Width;
            listViewBCTL.Columns[3].Width = col4Width;

            listViewBCTL.Columns[4].Width = col5Width;
            listViewBCTL.Columns[5].Width = col6Width;
            listViewBCTL.Columns[6].Width = col7Width;

            listViewBCTL.Columns[7].Width = col8Width;
            listViewBCTL.Columns[8].Width = col9Width;
            listViewBCTL.Columns[9].Width = col10Width;
        }

        public void LoadData()
        {
            try
            {
                if (isSearching)
                    tblBCTL = BCTLDAL.GetBCTLBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblBCTL = BCTLDAL.GetAllBCTL();

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

            foreach (DataRow row in tblBCTL.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaBCThanhLoc"].ToString());
                item.SubItems.Add(row["MaNVLap"].ToString());
                item.SubItems.Add(row["TenNVLap"].ToString());

                item.SubItems.Add(row["MaNVDuyet"].ToString());
                item.SubItems.Add(row["TenNVDuyet"].ToString());

                item.Tag = new
                {
                    MaDMThanhLoc = row["MaDMThanhLoc"].ToString()
                };

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

                item.SubItems.Add(row["SoTLChuyenDoiMD"].ToString());
                item.SubItems.Add(row["SoTLThanhLoc"].ToString());
                item.SubItems.Add(row["TongTien"].ToString());

                listViewBCTL.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewBCTL.Items.Clear();
        }

        private void listViewBCTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaBCTL.Focus();
                return;
            }

            if (tblBCTL.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewBCTL.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewBCTL.SelectedItems[0];
                txtMaBCTL.Text = selectedItem.SubItems[0].Text;
                txtMaNVLap.Text = selectedItem.SubItems[1].Text;
                txtMaNVDuyet.Text = selectedItem.SubItems[3].Text;

                var tagData = (dynamic)selectedItem.Tag;
                if (tagData != null)
                {
                    cboMaDMTL.SelectedIndex = cboMaDMTL.FindStringExact(tagData.MaDMThanhLoc?.ToString() ?? "");
                }

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

                txtSoTLCDMD.Text = selectedItem.SubItems[7].Text;
                txtSoTLThanhLoc.Text = selectedItem.SubItems[8].Text;
                txtTongTien.Text = selectedItem.SubItems[9].Text;

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

                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
                btnIn.Enabled = false;

                btnDuyet.Enabled = false;
            }
        }

        private void ResetValues()
        {
            txtMaBCTL.Text = "";
            txtMaNVLap.Text = NhanVienDAL.GetMaNVByUsername(Username);
            txtMaNVDuyet.Text = "";
            txtNgayLap.Text = "";
            txtNgayDuyet.Text = "";

            cboMaDMTL.SelectedItem = null;

            txtSoTLCDMD.Text = "";
            txtSoTLThanhLoc.Text = "";
            txtTongTien.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaBCTL.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã nhân viên");
                txtMaBCTL.Focus();
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

            if (cboMaDMTL.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn mã danh mục bồi thường");
                cboMaDMTL.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoTLCDMD.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số tài liệu chuyển đổi mục đích");
                txtSoTLCDMD.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoTLThanhLoc.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số tài liệu thanh lọc");
                txtSoTLThanhLoc.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTongTien.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tổng tiền");
                txtTongTien.Focus();
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

            ResetValues();

            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime today = DateTime.Now;

            string newMaBCTL = BCTLDAL.InsertEmptyBCTL();
            txtMaBCTL.Text = newMaBCTL;

            txtSoTLCDMD.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maBCTL = txtMaBCTL.Text.Trim();

            ResetValues();

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnIn.Enabled = false;

            txtMaBCTL.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maBCTL))
            {
                BCTLDAL.DeleteEmptyBCTL(maBCTL);
            }

            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maBCTL = txtMaBCTL.Text.Trim();

            if (!string.IsNullOrEmpty(maBCTL))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        BCTLDAL.DeleteBCTL(maBCTL);
                        Functions.HandleInfo("Xóa báo cáo kiểm kê thành công");
                        LoadData();
                        ResetValues();

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
            string maBCTL = txtMaBCTL.Text.Trim();

            if (!BCTLDAL.CheckMaBCTLExists(maBCTL))
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

                    string maDMTL = cboMaDMTL.SelectedValue.ToString();
                    int soTLCDMD = Convert.ToInt32(txtSoTLCDMD.Text.Trim());
                    int soTLThanhLoc = Convert.ToInt32(txtSoTLThanhLoc.Text.Trim());
                    int tongTien = Convert.ToInt32(txtTongTien.Text.Trim());

                    try
                    {
                        BCTLDAL.UpdateBCTL(maBCTL, maNVLap, maDMTL, ngayLap, soTLCDMD, soTLThanhLoc, tongTien);
                        Functions.HandleInfo("Lưu báo cáo thanh lọc thành công");
                        LoadData();
                        ResetValues();

                        btnThem.Enabled = true;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                        btnLuu.Enabled = false;
                        btnIn.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi thêm báo cáo thanh lọc: " + ex.Message);
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                string maBCTL = txtMaBCTL.Text.Trim();
                DataTable tblThongTinBCTL = BCTLDAL.GetThongTinBCTL(maBCTL);

                string maDMTL = BCTLDAL.GetMaDMTLByMaBCTL(maBCTL);
                DataTable tblThongTinCTDMTL = DMTLDAL.GetCTDMTL(maDMTL);

                if (tblThongTinBCTL.Rows.Count > 0)
                {
                    string dateTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string outputPath = @"E:\" + maBCTL + "_" + dateTime + ".pdf";
                    ExportToPDF.exportBCTL(tblThongTinBCTL, tblThongTinCTDMTL, outputPath);
                    Functions.HandleInfo($"Đã lưu báo cáo thanh lọc tại: {outputPath}");

                }
                else
                {
                    Functions.HandleInfo("Không tìm thấy báo cáo thanh lọc nào");
                }
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi: " + ex.Message);
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            string maNVDuyet = NhanVienDAL.GetMaNVByUsername(Username);
            string maBCTL = txtMaBCTL.Text.Trim();

            DateTime ngayDuyet = DateTime.Now;

            try
            {
                BCTLDAL.DuyetBCTL(maBCTL, maNVDuyet, ngayDuyet);

                Functions.HandleInfo("Duyệt báo cáo thanh lọc thành công");
                LoadData();
                ResetValues();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi duyệt báo cáo thanh lọc: " + ex.Message);
            }
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

        private void txtSoTLCDMD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTLThanhLoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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