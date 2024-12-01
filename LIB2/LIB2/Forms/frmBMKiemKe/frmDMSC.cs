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
    public partial class frmDMSC : MaterialForm
    {
        public string Username { get; set; }

        private DataTable tblDMSC;
        private DataTable tblCTDMSC;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        private int counterTL = 0;

        public frmDMSC()
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
            listViewDMSC.FullRowSelect = true;
            listViewDMSC.MultiSelect = false;
            listViewDMSC.UseCompatibleStateImageBehavior = false;
            listViewDMSC.View = View.Details;

            listViewDMSC.Columns.Add("MaDMSuaChua", "Mã danh mục");
            listViewDMSC.Columns.Add("MaNVLap", "Mã nhân viên lập");
            listViewDMSC.Columns.Add("TenNVLap", "Tên nhân viên lập");
            listViewDMSC.Columns.Add("NgayLap", "Ngày lập");
            listViewDMSC.Columns.Add("TongSoTL", "Tổng số tài liệu");
        }

        private void InitializeListViewCT()
        {
            listViewCTDMSC.FullRowSelect = true;
            listViewCTDMSC.MultiSelect = false;
            listViewCTDMSC.UseCompatibleStateImageBehavior = false;
            listViewCTDMSC.View = View.Details;

            listViewCTDMSC.Columns.Add("MaTL", "Mã tài liệu");
            listViewCTDMSC.Columns.Add("TenTL", "Tên tài liệu");
            listViewCTDMSC.Columns.Add("SoLuong", "Số lượng");
        }

        private void frmDMSC_Load(object sender, EventArgs e)
        {
            txtMaDMSC.Enabled = false;

            btnXoa.Enabled = false;
            btnLuu.Enabled = false;

            btnHuy.Enabled = false;
            btnIn.Enabled = false;

            btnThemTL.Enabled = false;
            btnXoaTL.Enabled = false;

            txtMaTL.Enabled = false;
            txtTenTL.Enabled = false;
            txtSoLuong.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;

            txtMaNV.Text = NhanVienDAL.GetMaNVByUsername(Username);
            txtMaNV.Enabled = false;

            txtTongSoTL.Enabled = false;
        }

        private void AdjustColumnWidth()
        {
            int col1Width = 150;
            int col2Width = 150;
            int col3Width = 150;
            int col4Width = 150;
            int col5Width = 150;

            listViewDMSC.Columns[0].Width = col1Width;
            listViewDMSC.Columns[1].Width = col2Width;
            listViewDMSC.Columns[2].Width = col3Width;
            listViewDMSC.Columns[3].Width = col4Width;
            listViewDMSC.Columns[4].Width = col5Width;
        }

        private void AdjustColumnWidthCT()
        {
            int totalWidth = listViewCTDMSC.ClientSize.Width;
            double col1Percentage = 0.2;
            double col2Percentage = 0.6;
            double col3Percentage = 0.2;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);

            listViewCTDMSC.Columns[0].Width = col1Width;
            listViewCTDMSC.Columns[1].Width = col2Width;
            listViewCTDMSC.Columns[2].Width = col3Width;
        }

        public void LoadData()
        {
            try
            {
                if (isSearching)
                    tblDMSC = DMSCDAL.GetDMSCBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblDMSC = DMSCDAL.GetAllDMSC();

                LoadListView();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDataCT(string maDMSC)
        {
            try
            {
                tblCTDMSC = DMSCDAL.GetCTDMSC(maDMSC);

                LoadListViewCT();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadListView()
        {
            ClearListView(listViewDMSC);

            foreach (DataRow row in tblDMSC.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaDMSuaChua"].ToString());
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

                listViewDMSC.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void LoadListViewCT()
        {
            ClearListView(listViewCTDMSC);

            foreach (DataRow row in tblCTDMSC.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaTL"].ToString());
                item.SubItems.Add(row["TenTL"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());

                listViewCTDMSC.Items.Add(item);
            }

            AdjustColumnWidthCT();
        }

        private void ClearListView(MaterialListView listView)
        {
            listView.Items.Clear();
        }

        private void listViewDMSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaTL.Focus();
                return;
            }

            if (tblDMSC.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewDMSC.SelectedItems.Count > 0)
            {
                txtMaTL.Enabled = true;
                txtSoLuong.Enabled = true;

                btnThemTL.Enabled = true;

                ListViewItem selectedItem = listViewDMSC.SelectedItems[0];
                txtMaDMSC.Text = selectedItem.SubItems[0].Text;
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

                string maDMSC = txtMaDMSC.Text.Trim();
                LoadDataCT(maDMSC);

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

                ClearListView(listViewCTDMSC);

                txtMaTL.Enabled = false;
                txtSoLuong.Enabled = false;

                btnThemTL.Enabled = false;
                btnXoaTL.Enabled = false;
            }
        }

        private void listViewCTDMSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThemTL.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaTL.Focus();
                return;
            }

            if (tblCTDMSC.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewCTDMSC.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCTDMSC.SelectedItems[0];
                txtMaTL.Text = selectedItem.SubItems[0].Text;
                txtTenTL.Text = selectedItem.SubItems[1].Text;
                txtSoLuong.Text = selectedItem.SubItems[2].Text;

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
            txtMaDMSC.Text = "";
            txtMaNV.Text = NhanVienDAL.GetMaNVByUsername(Username);
            txtNgayLap.Text = "";
            txtTongSoTL.Text = "";
            counterTL = 0;
        }

        private void ResetValuesCT()
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            txtSoLuong.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaDMSC.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã danh mục sửa chữa");
                txtMaDMSC.Focus();
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

            string newMaDMSC = DMSCDAL.InsertEmptyDMSC();
            txtMaDMSC.Text = newMaDMSC;

            txtMaTL.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maDMSC = txtMaDMSC.Text.Trim();

            ResetValuesCT();
            ResetValues();

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnIn.Enabled = false;

            txtMaDMSC.Enabled = false;

            txtMaTL.Enabled = false;
            txtSoLuong.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maDMSC))
            {
                DMSCDAL.DeleteEmptyDMSC(maDMSC);
            }

            LoadDataCT("");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDMSC = txtMaDMSC.Text.Trim();

            if (!string.IsNullOrEmpty(maDMSC))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        DMSCDAL.DeleteCTDMSC(maDMSC);
                        DMSCDAL.DeleteDMSC(maDMSC);

                        Functions.HandleInfo("Xóa danh mục sửa chữa thành công");
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
                        Functions.HandleError("Lỗi khi xóa danh mục sửa chữa: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maDMSC = txtMaDMSC.Text.Trim();

            if (!DMSCDAL.CheckMaDMSCExists(maDMSC))
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

                    try
                    {
                        DMSCDAL.UpdateDMSC(maDMSC, maNV, ngayLap, tongSoTL);

                        Functions.HandleInfo("Lưu danh mục sửa chữa thành công");
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
                        Functions.HandleError("Lỗi khi thêm danh mục sửa chữa: " + ex.Message);
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                string maDMSC = txtMaDMSC.Text.Trim();
                DataTable tblThongTinDMSC = DMSCDAL.GetThongTinDMSC(maDMSC);
                DataTable tblThongTinCTDMSC = DMSCDAL.GetCTDMSC(maDMSC);

                if (tblThongTinDMSC.Rows.Count > 0)
                {
                    string dateTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string outputPath = @"E:\" + maDMSC + "_" + dateTime + ".pdf";
                    ExportToPDF.exportDMSC(tblThongTinDMSC, tblThongTinCTDMSC, outputPath);
                    Functions.HandleInfo($"Đã lưu danh mục sửa chữa tại: {outputPath}");

                }
                else
                {
                    Functions.HandleInfo("Không tìm thấy danh mục sửa chữa nào");
                }
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi: " + ex.Message);
            }
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            string maDMSC = txtMaDMSC.Text.Trim();

            if (ValidateInputCT())
            {
                string maTL = txtMaTL.Text.Trim();
                int soLuong = Convert.ToInt32(txtSoLuong.Text);

                if (DMSCDAL.CheckMaTaiLieu(maDMSC, maTL))
                {
                    Functions.HandleWarning("Tài liệu này đã có trong danh mục sửa chữa, vui lòng chọn tài liệu khác hoặc xoá");
                    ResetValuesCT();
                    txtMaTL.Focus();
                    return;
                }

                try
                {
                    DMSCDAL.InsertTaiLieuCTDMSC(maDMSC, maTL, soLuong);
                    counterTL += soLuong;
                    txtTongSoTL.Text = counterTL.ToString();
                    Functions.HandleInfo("Thêm chi tiết danh mục sửa chữa thành công");

                    LoadDataCT(maDMSC);
                    ResetValuesCT();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm chi tiết danh mục sửa chữa: " + ex.Message);
                }
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            string maDMSC = txtMaDMSC.Text.Trim();
            string maTL = txtMaTL.Text.Trim();
            int soLuong = Convert.ToInt32(txtSoLuong.Text.Trim());

            if (!string.IsNullOrEmpty(maDMSC) && !string.IsNullOrEmpty(maTL))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        DMSCDAL.DeleteTaiLieuCTDMSC(maDMSC, maTL);
                        counterTL -= soLuong;
                        txtTongSoTL.Text = counterTL.ToString();
                        Functions.HandleInfo("Xóa tài liệu trong danh mục sửa chữa thành công");

                        LoadDataCT(maDMSC);
                        ResetValuesCT();
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa sách: " + ex.Message);
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
                }
                else
                {
                    txtTenTL.Text = string.Empty;
                }
            }
            else
            {
                txtTenTL.Text = string.Empty;
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
    }
}
