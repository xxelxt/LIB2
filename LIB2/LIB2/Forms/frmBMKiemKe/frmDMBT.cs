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
    public partial class frmDMBT : MaterialForm
    {
        public string Username { get; set; }

        private DataTable tblDMBT;
        private DataTable tblCTDMBT;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        private int counterTL = 0;
        private int counterTT = 0;

        public frmDMBT()
        {
            InitializeComponent();

            InitializeListView();
            InitializeListViewCT();

            LoadData();

            cboTimKiem.Items.Add("Mã danh mục");
            cboTimKiem.Items.Add("Nhân viên lập");
            cboTimKiem.Items.Add("Ngày lập");
        }

        private void InitializeListView()
        {
            listViewDMBT.FullRowSelect = true;
            listViewDMBT.MultiSelect = false;
            listViewDMBT.UseCompatibleStateImageBehavior = false;
            listViewDMBT.View = View.Details;

            listViewDMBT.Columns.Add("MaDMBoiThuong", "Mã danh mục");
            listViewDMBT.Columns.Add("MaNVLap", "Mã nhân viên lập");
            listViewDMBT.Columns.Add("TenNVLap", "Tên nhân viên lập");
            listViewDMBT.Columns.Add("NgayLap", "Ngày lập");
            listViewDMBT.Columns.Add("TongSoTL", "Tổng số tài liệu");
            listViewDMBT.Columns.Add("TongTien", "Tổng tiền");
        }

        private void InitializeListViewCT()
        {
            listViewCTDMBT.FullRowSelect = true;
            listViewCTDMBT.MultiSelect = false;
            listViewCTDMBT.UseCompatibleStateImageBehavior = false;
            listViewCTDMBT.View = View.Details;

            listViewCTDMBT.Columns.Add("MaTL", "Mã tài liệu");
            listViewCTDMBT.Columns.Add("TenTL", "Tên tài liệu");
            listViewCTDMBT.Columns.Add("SoLuong", "Số lượng");
            listViewCTDMBT.Columns.Add("DonGia", "Đơn giá");
        }

        private void frmDMBT_Load(object sender, EventArgs e)
        {
            txtMaDMBT.Enabled = false;

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

            txtTongSoTL.Enabled = false;
            txtTongTienBT.Enabled = false;
        }

        private void AdjustColumnWidth()
        {
            int col1Width = 150;
            int col2Width = 150;
            int col3Width = 150;
            int col4Width = 150;
            int col5Width = 150;
            int col6Width = 150;

            listViewDMBT.Columns[0].Width = col1Width;
            listViewDMBT.Columns[1].Width = col2Width;
            listViewDMBT.Columns[2].Width = col3Width;
            listViewDMBT.Columns[3].Width = col4Width;
            listViewDMBT.Columns[4].Width = col5Width;
            listViewDMBT.Columns[5].Width = col6Width;
        }

        private void AdjustColumnWidthCT()
        {
            int totalWidth = listViewCTDMBT.ClientSize.Width;
            double col1Percentage = 0.2;
            double col2Percentage = 0.4;
            double col3Percentage = 0.2;
            double col4Percentage = 0.2;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);

            listViewCTDMBT.Columns[0].Width = col1Width;
            listViewCTDMBT.Columns[1].Width = col2Width;
            listViewCTDMBT.Columns[2].Width = col3Width;
            listViewCTDMBT.Columns[3].Width = col4Width;
        }

        public void LoadData()
        {
            try
            {
                if (isSearching)
                    tblDMBT = DMBTDAL.GetDMBTBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblDMBT = DMBTDAL.GetAllDMBT();

                LoadListView();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDataCT(string maDMBT)
        {
            try
            {
                tblCTDMBT = DMBTDAL.GetCTDMBT(maDMBT);

                LoadListViewCT();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadListView()
        {
            ClearListView(listViewDMBT);

            foreach (DataRow row in tblDMBT.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaDMBoiThuong"].ToString());
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

                item.SubItems.Add(row["TongSoTL"].ToString());
                item.SubItems.Add(row["TongTien"].ToString());

                listViewDMBT.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void LoadListViewCT()
        {
            ClearListView(listViewCTDMBT);

            foreach (DataRow row in tblCTDMBT.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaTL"].ToString());
                item.SubItems.Add(row["TenTL"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(row["DonGia"].ToString());

                listViewCTDMBT.Items.Add(item);
            }

            AdjustColumnWidthCT();
        }

        private void ClearListView(MaterialListView listView)
        {
            listView.Items.Clear();
        }

        private void listViewDMBT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaTL.Focus();
                return;
            }

            if (tblDMBT.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewDMBT.SelectedItems.Count > 0)
            {
                txtMaTL.Enabled = true;
                txtSoLuong.Enabled = true;

                btnThemTL.Enabled = true;

                ListViewItem selectedItem = listViewDMBT.SelectedItems[0];
                txtMaDMBT.Text = selectedItem.SubItems[0].Text;
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

                txtTongSoTL.Text = selectedItem.SubItems[4].Text;
                counterTL = Convert.ToInt32(txtTongSoTL.Text);

                txtTongTienBT.Text = selectedItem.SubItems[5].Text;
                counterTT = Convert.ToInt32(txtTongTienBT.Text);

                string maDMBT = txtMaDMBT.Text.Trim();
                LoadDataCT(maDMBT);

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

                ClearListView(listViewCTDMBT);

                txtMaTL.Enabled = false;
                txtSoLuong.Enabled = false;

                btnThemTL.Enabled = false;
                btnXoaTL.Enabled = false;
            }
        }

        private void listViewCTDMBT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThemTL.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaTL.Focus();
                return;
            }

            if (tblCTDMBT.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewCTDMBT.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCTDMBT.SelectedItems[0];
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
            txtMaDMBT.Text = "";
            txtMaNV.Text = NhanVienDAL.GetMaNVByUsername(Username);
            txtNgayLap.Text = "";

            txtTongSoTL.Text = "";
            counterTL = 0;
            txtTongTienBT.Text = "";
            counterTT = 0;
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
            if (string.IsNullOrWhiteSpace(txtMaDMBT.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã danh mục bồi thường");
                txtMaDMBT.Focus();
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
                Functions.HandleWarning("Bạn phải nhập ngày lập danh mục");
                txtNgayLap.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTongSoTL.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tổng số tài liệu");
                txtTongSoTL.Focus();
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

            string newMaDMBT = DMBTDAL.InsertEmptyDMBT();
            txtMaDMBT.Text = newMaDMBT;

            txtMaTL.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maDMBT = txtMaDMBT.Text.Trim();

            ResetValuesCT();
            ResetValues();

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnIn.Enabled = false;

            txtMaDMBT.Enabled = false;

            txtMaTL.Enabled = false;
            txtSoLuong.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maDMBT))
            {
                DMBTDAL.DeleteEmptyDMBT(maDMBT);
            }

            LoadDataCT("");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDMBT = txtMaDMBT.Text.Trim();

            if (!string.IsNullOrEmpty(maDMBT))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        DMBTDAL.DeleteCTDMBT(maDMBT);
                        DMBTDAL.DeleteDMBT(maDMBT);

                        Functions.HandleInfo("Xóa danh mục bồi thường thành công");
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
                        Functions.HandleError("Lỗi khi xóa danh mục bồi thường: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maDMBT = txtMaDMBT.Text.Trim();

            if (!DMBTDAL.CheckMaDMBTExists(maDMBT))
            {
                if (ValidateInput())
                {
                    string maNV = txtMaNV.Text.Trim();

                    DateTime ngayLap;
                    if (!DateTime.TryParse(txtNgayLap.Text.Trim(), out ngayLap))
                    {
                        Functions.HandleWarning("Ngày lập danh mục không hợp lệ");
                        txtNgayLap.Focus();
                        return;
                    }

                    int tongSoTL = Convert.ToInt32(txtTongSoTL.Text);
                    int tongTienBT = Convert.ToInt32(txtTongTienBT.Text);

                    try
                    {
                        DMBTDAL.UpdateDMBT(maDMBT, maNV, ngayLap, tongSoTL, tongTienBT);
                        Functions.HandleInfo("Lưu danh mục bồi thường thành công");
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
                        Functions.HandleError("Lỗi khi thêm danh mục bồi thường: " + ex.Message);
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                string maDMBT = txtMaDMBT.Text.Trim();
                DataTable tblThongTinDMBT = DMBTDAL.GetThongTinDMBT(maDMBT);
                DataTable tblThongTinCTDMBT = DMBTDAL.GetCTDMBT(maDMBT);

                if (tblThongTinDMBT.Rows.Count > 0)
                {
                    string dateTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string outputPath = @"E:\" + maDMBT + "_" + dateTime + ".pdf";
                    ExportToPDF.exportDMBT(tblThongTinDMBT, tblThongTinCTDMBT, outputPath);
                    Functions.HandleInfo($"Đã lưu danh mục bồi thường tại: {outputPath}");

                }
                else
                {
                    Functions.HandleInfo("Không tìm thấy danh mục bồi thường nào");
                }
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi: " + ex.Message);
            }
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            string maDMBT = txtMaDMBT.Text.Trim();

            if (ValidateInputCT())
            {
                string maTL = txtMaTL.Text.Trim();
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                int donGia = Convert.ToInt32(txtDonGia.Text);

                if (DMBTDAL.CheckMaTaiLieu(maDMBT, maTL))
                {
                    Functions.HandleWarning("Tài liệu này đã có trong danh mục bồi thường, vui lòng chọn tài liệu khác hoặc xoá");
                    ResetValuesCT();
                    txtMaTL.Focus();
                    return;
                }

                try
                {
                    DMBTDAL.InsertTaiLieuCTDMBT(maDMBT, maTL, soLuong, donGia);
                    
                    counterTL += soLuong;
                    txtTongSoTL.Text = counterTL.ToString();
                    counterTT += soLuong * donGia;
                    txtTongTienBT.Text = counterTL.ToString();
                    
                    Functions.HandleInfo("Thêm chi tiết danh mục bồi thường thành công");

                    LoadDataCT(maDMBT);
                    ResetValuesCT();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm chi tiết danh mục bồi thường: " + ex.Message);
                }
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            string maDMBT = txtMaDMBT.Text.Trim();
            string maTL = txtMaTL.Text.Trim();
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            int donGia = Convert.ToInt32(txtDonGia.Text);

            if (!string.IsNullOrEmpty(maDMBT) && !string.IsNullOrEmpty(maTL))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        DMBTDAL.DeleteTaiLieuCTDMBT(maDMBT, maTL);

                        counterTL -= soLuong;
                        txtTongSoTL.Text = counterTL.ToString();
                        counterTT -= soLuong * donGia;
                        txtTongTienBT.Text = counterTL.ToString();

                        Functions.HandleInfo("Xóa tài liệu trong danh mục bồi thường thành công");

                        LoadDataCT(maDMBT);
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
