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
    public partial class frmKhoaLuan : MaterialForm
    {
        private DataTable tblKhoaLuan;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        public frmKhoaLuan()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();

            string fillComboSqlNN = "SELECT * FROM Nganh;";
            DatabaseLayer.FillCombo(fillComboSqlNN, cboMaNganh, "MaNganh", "TenNganh");

            string fillComboSqlKho = "SELECT * FROM Kho;";
            DatabaseLayer.FillCombo(fillComboSqlKho, cboMaKho, "MaKho", "TenKho");

            string fillComboSqlLAP = "SELECT * FROM LoaiAnPham;";
            DatabaseLayer.FillCombo(fillComboSqlLAP, cboMaLoai, "MaLoaiAP", "TenLoaiAP");

            cboMaNganh.SelectedItem = null;
            cboMaKho.SelectedItem = null;
            cboMaLoai.SelectedItem = null;

            cboTimKiem.Items.Add("Mã tài liệu");
            cboTimKiem.Items.Add("Tên đề tài");
            cboTimKiem.Items.Add("Người thực hiện");
            cboTimKiem.Items.Add("Người hướng dẫn");
            cboTimKiem.Items.Add("Loại ấn phẩm");
            cboTimKiem.Items.Add("Kho");
            cboTimKiem.Items.Add("Ngành");
        }

        private void InitializeListView()
        {
            listViewTL.FullRowSelect = true;
            listViewTL.MultiSelect = false;
            listViewTL.UseCompatibleStateImageBehavior = false;
            listViewTL.View = View.Details;

            listViewTL.Columns.Add("MaTL", "Mã tài liệu");
            listViewTL.Columns.Add("TenDeTai", "Tên đề tài");
            listViewTL.Columns.Add("NguoiThucHien", "Người thực hiện");
            listViewTL.Columns.Add("NguoiHuongDan", "Người hướng dẫn");
            listViewTL.Columns.Add("NamHT", "Năm hoàn thành");
            listViewTL.Columns.Add("TomTat", "Tóm tắt");
            listViewTL.Columns.Add("SoLuong", "Số lượng");
            listViewTL.Columns.Add("MaKho", "Kho");
            listViewTL.Columns.Add("MaNganh", "Ngành");
            listViewTL.Columns.Add("MaLoaiAP", "Loại ấn phẩm");
        }

        private void frmKhoaLuan_Load(object sender, EventArgs e)
        {
            txtMaTL.Enabled = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewTL.ClientSize.Width;
            double col1Percentage = 0.1;
            double col2Percentage = 0.2;
            double col3Percentage = 0.15;
            double col4Percentage = 0.15;
            double col5Percentage = 0.15;
            double col6Percentage = 0.3;
            double col7Percentage = 0.1;
            double col8Percentage = 0.1;
            double col9Percentage = 0.1;
            double col10Percentage = 0.15;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);
            int col5Width = (int)(totalWidth * col5Percentage);
            int col6Width = (int)(totalWidth * col6Percentage);
            int col7Width = (int)(totalWidth * col7Percentage);
            int col8Width = (int)(totalWidth * col8Percentage);
            int col9Width = (int)(totalWidth * col9Percentage);
            int col10Width = (int)(totalWidth * col10Percentage);

            listViewTL.Columns[0].Width = col1Width;
            listViewTL.Columns[1].Width = col2Width;
            listViewTL.Columns[2].Width = col3Width;
            listViewTL.Columns[3].Width = col4Width;
            listViewTL.Columns[4].Width = col5Width;
            listViewTL.Columns[5].Width = col6Width;
            listViewTL.Columns[6].Width = col7Width;
            listViewTL.Columns[7].Width = col8Width;
            listViewTL.Columns[8].Width = col9Width;
            listViewTL.Columns[9].Width = col10Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblKhoaLuan = KhoaLuanDAL.GetKhoaLuanBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblKhoaLuan = KhoaLuanDAL.GetAllKhoaLuan();

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

            foreach (DataRow row in tblKhoaLuan.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaTL"].ToString());
                item.SubItems.Add(row["TenDeTai"].ToString());
                item.SubItems.Add(row["NguoiThucHien"].ToString());
                item.SubItems.Add(row["NguoiHuongDan"].ToString());

                item.SubItems.Add(row["NamHT"].ToString());
                item.SubItems.Add(row["TomTat"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());

                item.SubItems.Add(row["MaKho"].ToString());
                item.SubItems.Add(row["MaNganh"].ToString());
                item.SubItems.Add(row["MaLoaiAP"].ToString());

                listViewTL.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewTL.Items.Clear();
        }

        private void listViewTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaTL.Focus();
                return;
            }

            if (tblKhoaLuan.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewTL.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTL.SelectedItems[0];
                txtMaTL.Text = selectedItem.SubItems[0].Text;
                txtTenTL.Text = selectedItem.SubItems[1].Text;
                txtNguoiTH.Text = selectedItem.SubItems[2].Text;
                txtNguoiHD.Text = selectedItem.SubItems[3].Text;

                txtNamHT.Text = selectedItem.SubItems[4].Text;
                txtTomTat.Text = selectedItem.SubItems[5].Text;
                txtSoLuong.Text = selectedItem.SubItems[6].Text;

                cboMaKho.Text = DatabaseLayer.GetFieldValues("SELECT TenKho FROM Kho WHERE MaKho = N'" + selectedItem.SubItems[7].Text + "';");
                cboMaNganh.Text = DatabaseLayer.GetFieldValues("SELECT TenNganh FROM Nganh WHERE MaNganh = N'" + selectedItem.SubItems[8].Text + "';");
                cboMaLoai.Text = DatabaseLayer.GetFieldValues("SELECT TenLoaiAP FROM LoaiAnPham WHERE MaLoaiAP = N'" + selectedItem.SubItems[9].Text + "';");

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                ResetValues();

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        private void ResetValues()
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            txtNguoiTH.Text = "";
            txtNguoiHD.Text = "";

            txtNamHT.Text = "";
            txtSoLuong.Text = "";
            txtTomTat.Text = "";

            cboMaLoai.SelectedItem = null;
            cboMaKho.SelectedItem = null;
            cboMaNganh.SelectedItem = null;

        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaTL.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã tài liệu");
                txtMaTL.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtTenTL.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên tài liệu");
                txtTenTL.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiTH.Text))
            {
                Functions.HandleWarning("Bạn phải nhập người thực hiện");
                txtNguoiTH.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiHD.Text))
            {
                Functions.HandleWarning("Bạn phải nhập người hướng dẫn");
                txtNguoiHD.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNamHT.Text))
            {
                Functions.HandleWarning("Bạn phải nhập năm hoàn thành");
                txtNamHT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số lượng");
                txtSoLuong.Focus();
                return false;
            }

            if (cboMaLoai.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn nhà xuất bản");
                cboMaLoai.Focus();
                return false;
            }

            if (cboMaKho.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn kho");
                cboMaKho.Focus();
                return false;
            }

            if (cboMaNganh.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn ngành");
                cboMaNganh.Focus();
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
            txtTenTL.Focus();

            string newMaTL = KhoaLuanDAL.InsertEmptyKhoaLuan();
            txtMaTL.Text = newMaTL;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewTL.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }

            if (ValidateInput())
            {
                string maTL = txtMaTL.Text.Trim();
                string tenTL = txtTenTL.Text.Trim();
                string nguoiTH = txtNguoiTH.Text.Trim();
                string nguoiHD = txtNguoiHD.Text.Trim();

                int namHT = Convert.ToInt32(txtNamHT.Text.Trim());
                string tomTat = txtTomTat.Text.Trim();
                int soLuong = Convert.ToInt32(txtSoLuong.Text.Trim());

                string maKho = cboMaKho.SelectedValue.ToString();
                string maNganh = cboMaNganh.SelectedValue.ToString();
                string maLoaiAP = cboMaLoai.SelectedValue.ToString();

                try
                {
                    KhoaLuanDAL.UpdateKhoaLuan(maTL, tenTL, nguoiTH, nguoiHD, namHT, tomTat, soLuong, maKho, maNganh, maLoaiAP);
                    Functions.HandleInfo("Cập nhật tài liệu thành công");
                    LoadData();
                    ResetValues();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi cập nhật tài liệu: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTL = txtMaTL.Text.Trim();

            if (!string.IsNullOrEmpty(maTL))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        KhoaLuanDAL.DeleteKhoaLuan(maTL);
                        Functions.HandleInfo("Xóa tài liệu thành công");
                        LoadData();
                        ResetValues();

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa tài liệu: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string maTL = txtMaTL.Text.Trim();
                string tenTL = txtTenTL.Text.Trim();
                string nguoiTH = txtNguoiTH.Text.Trim();
                string nguoiHD = txtNguoiHD.Text.Trim();

                int namHT = Convert.ToInt32(txtNamHT.Text.Trim());
                string tomTat = txtTomTat.Text.Trim();
                int soLuong = Convert.ToInt32(txtSoLuong.Text.Trim());

                string maKho = cboMaKho.SelectedValue.ToString();
                string maNganh = cboMaNganh.SelectedValue.ToString();
                string maLoaiAP = cboMaLoai.SelectedValue.ToString();

                try
                {
                    KhoaLuanDAL.UpdateKhoaLuan(maTL, tenTL, nguoiTH, nguoiHD, namHT, tomTat, soLuong, maKho, maNganh, maLoaiAP);
                    Functions.HandleInfo("Thêm tài liệu thành công");
                    LoadData();
                    ResetValues();

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    txtMaTL.Enabled = false;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm tài liệu: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maTL = txtMaTL.Text.Trim();

            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaTL.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maTL))
            {
                KhoaLuanDAL.DeleteEmptyKhoaLuan(maTL);
            }
            LoadData();
        }

        private void PerformSearch()
        {
            currentSearchOption = cboTimKiem.Text;
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

        private void txtNamHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
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