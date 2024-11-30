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
    public partial class frmTapChi : MaterialForm
    {
        private DataTable tblTapChi;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        public frmTapChi()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();

            string fillComboSqlLAP = "SELECT * FROM LoaiAnPham;";
            DatabaseLayer.FillCombo(fillComboSqlLAP, cboMaLoai, "MaLoaiAP", "TenLoaiAP");

            string fillComboSqlNXB = "SELECT * FROM NhaXuatBan;";
            DatabaseLayer.FillCombo(fillComboSqlNXB, cboMaNXB, "MaNXB", "TenNXB");

            string fillComboSqlNN = "SELECT * FROM NgonNgu;";
            DatabaseLayer.FillCombo(fillComboSqlNN, cboMaNN, "MaNN", "TenNN");

            string fillComboSqlKho = "SELECT * FROM Kho;";
            DatabaseLayer.FillCombo(fillComboSqlKho, cboMaKho, "MaKho", "TenKho");

            cboMaLoai.SelectedItem = null;
            cboMaNXB.SelectedItem = null;
            cboMaNN.SelectedItem = null;
            cboMaKho.SelectedItem = null;

            cboTimKiem.Items.Add("Mã tài liệu");
            cboTimKiem.Items.Add("Tiêu đề");
            cboTimKiem.Items.Add("Loại ấn phẩm");
            cboTimKiem.Items.Add("Nhà xuất bản");
            cboTimKiem.Items.Add("Kho");
            cboTimKiem.Items.Add("Ngôn ngữ");

            cboSoLuong.Items.Add("Mặc định");
            cboSoLuong.Items.Add("Tăng dần");
            cboSoLuong.Items.Add("Giảm dần");

            cboSoLuong.SelectedItem = "Mặc định";

            cboNgayXB.Items.Add("Mặc định");
            cboNgayXB.Items.Add("Gần đây nhất");
            cboNgayXB.Items.Add("Xa đây nhất");

            cboNgayXB.SelectedItem = "Mặc định";

            chkSoLuong.Checked = false;
            chkNgayXB.Checked = false;

            cboSoLuong.Enabled = false;
            cboNgayXB.Enabled = false;
        }

        private void InitializeListView()
        {
            listViewTL.FullRowSelect = true;
            listViewTL.MultiSelect = false;
            listViewTL.UseCompatibleStateImageBehavior = false;
            listViewTL.View = View.Details;

            listViewTL.Columns.Add("MaTL", "Mã tài liệu");
            listViewTL.Columns.Add("TieuDe", "Tiêu đề");
            listViewTL.Columns.Add("NgayXB", "Ngày xuất bản");
            listViewTL.Columns.Add("SoRa", "Số ra");
            listViewTL.Columns.Add("SoTrang", "Số trang");
            listViewTL.Columns.Add("SoLuong", "Số lượng");
            listViewTL.Columns.Add("DonGia", "Đơn giá");
            listViewTL.Columns.Add("MaNXB", "Nhà xuất bản");
            listViewTL.Columns.Add("MaKho", "Kho");
            listViewTL.Columns.Add("MaNN", "Ngôn ngữ");
            listViewTL.Columns.Add("MaLoaiAP", "Loại ấn phẩm");
        }

        private void frmTapChi_Load(object sender, EventArgs e)
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
            double col4Percentage = 0.1;
            double col5Percentage = 0.1;
            double col6Percentage = 0.1;
            double col7Percentage = 0.1;
            double col8Percentage = 0.15;
            double col9Percentage = 0.1;
            double col10Percentage = 0.1;
            double col11Percentage = 0.15;

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
            int col11Width = (int)(totalWidth * col11Percentage);

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
            listViewTL.Columns[10].Width = col11Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblTapChi = TapChiDAL.GetTapChiBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblTapChi = TapChiDAL.GetAllTapChi();

                DataView dv = tblTapChi.DefaultView;

                string sortExpression = "";
                if (chkSoLuong.Checked && cboSoLuong.SelectedItem.ToString() != "Mặc định")
                {
                    sortExpression += "SoLuong " + (cboSoLuong.Text == "Tăng dần" ? "ASC" : "DESC");
                }

                if (chkNgayXB.Checked && cboNgayXB.SelectedItem.ToString() != "Mặc định")
                {
                    if (!string.IsNullOrEmpty(sortExpression))
                    {
                        sortExpression += ", ";
                    }
                    sortExpression += "NgayXB " + (cboNgayXB.Text == "Xa đây nhất" ? "ASC" : "DESC");
                }

                if (!string.IsNullOrEmpty(sortExpression))
                {
                    dv.Sort = sortExpression;
                }

                tblTapChi = dv.ToTable();
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

            foreach (DataRow row in tblTapChi.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaTL"].ToString());
                item.SubItems.Add(row["TieuDe"].ToString());

                DateTime ngayXB;
                if (DateTime.TryParse(row["NgayXB"].ToString(), out ngayXB))
                {
                    string ngayXBFormatted = ngayXB.ToString("dd/MM/yyyy");

                    item.SubItems.Add(ngayXBFormatted);
                }
                else
                {
                    item.SubItems.Add("");
                }

                item.SubItems.Add(row["SoRa"].ToString());
                item.SubItems.Add(row["SoTrang"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(row["DonGia"].ToString());

                item.SubItems.Add(row["MaNXB"].ToString());
                item.SubItems.Add(row["MaKho"].ToString());
                item.SubItems.Add(row["MaNN"].ToString());
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

            if (tblTapChi.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewTL.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTL.SelectedItems[0];
                txtMaTL.Text = selectedItem.SubItems[0].Text;
                txtTenTL.Text = selectedItem.SubItems[1].Text;

                string ngayXBStr = selectedItem.SubItems[2].Text;
                DateTime ngayXB;
                if (DateTime.TryParse(ngayXBStr, out ngayXB))
                {
                    txtNgayXB.Text = ngayXB.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtNgayXB.Text = "";
                }

                txtSoRa.Text = selectedItem.SubItems[3].Text;
                txtSoTrang.Text = selectedItem.SubItems[4].Text;
                txtSoLuong.Text = selectedItem.SubItems[5].Text;
                txtGia.Text = selectedItem.SubItems[6].Text;

                cboMaNXB.Text = DatabaseLayer.GetFieldValues("SELECT TenNXB FROM NhaXuatBan WHERE MaNXB = N'" + selectedItem.SubItems[7].Text + "';");
                cboMaKho.Text = DatabaseLayer.GetFieldValues("SELECT TenKho FROM Kho WHERE MaKho = N'" + selectedItem.SubItems[8].Text + "';");
                cboMaNN.Text = DatabaseLayer.GetFieldValues("SELECT TenNN FROM NgonNgu WHERE MaNN = N'" + selectedItem.SubItems[9].Text + "';");
                cboMaLoai.Text = DatabaseLayer.GetFieldValues("SELECT TenLoaiAP FROM LoaiAnPham WHERE MaLoaiAP = N'" + selectedItem.SubItems[10].Text + "';");

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

            txtNgayXB.Text = "";
            txtSoTrang.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
            txtSoRa.Text = "";

            cboMaLoai.SelectedItem = null;
            cboMaNXB.SelectedItem = null;
            cboMaKho.SelectedItem = null;
            cboMaNN.SelectedItem = null;

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

            if (string.IsNullOrWhiteSpace(txtNgayXB.Text))
            {
                Functions.HandleWarning("Bạn phải nhập ngày xuất bản");
                txtNgayXB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoRa.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số ra");
                txtSoRa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoTrang.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số trang");
                txtSoTrang.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số lượng");
                txtSoLuong.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGia.Text))
            {
                Functions.HandleWarning("Bạn phải nhập giá");
                txtGia.Focus();
                return false;
            }

            if (cboMaLoai.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn loại ấn phẩm");
                cboMaLoai.Focus();
                return false;
            }

            if (cboMaNXB.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn nhà xuất bản");
                cboMaNXB.Focus();
                return false;
            }

            if (cboMaKho.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn kho");
                cboMaKho.Focus();
                return false;
            }

            if (cboMaNN.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn ngôn ngữ");
                cboMaNN.Focus();
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

            string newMaTL = TapChiDAL.InsertEmptyTapChi();
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

                DateTime ngayXB;
                if (!DateTime.TryParse(txtNgayXB.Text, out ngayXB))
                {
                    Functions.HandleWarning("Ngày xuất bản không hợp lệ");
                    txtNgayXB.Focus();
                    return;
                }

                int soRa = Convert.ToInt32(txtSoRa.Text.Trim());
                int soTrang = Convert.ToInt32(txtSoTrang.Text.Trim());
                int soLuong = Convert.ToInt32(txtSoLuong.Text.Trim());
                int gia = Convert.ToInt32(txtGia.Text.Trim());

                string maNXB = cboMaNXB.SelectedValue.ToString();
                string maKho = cboMaKho.SelectedValue.ToString();
                string maNN = cboMaNN.SelectedValue.ToString();
                string maLoaiAP = cboMaLoai.SelectedValue.ToString();

                try
                {
                    TapChiDAL.UpdateTapChi(maTL, tenTL, ngayXB, soRa, soTrang, soLuong, gia, maNXB, maKho, maNN, maLoaiAP);
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
                        TapChiDAL.DeleteTapChi(maTL);
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

                DateTime ngayXB;
                if (!DateTime.TryParse(txtNgayXB.Text, out ngayXB))
                {
                    Functions.HandleWarning("Ngày xuất bản không hợp lệ");
                    txtNgayXB.Focus();
                    return;
                }

                int soRa = Convert.ToInt32(txtSoRa.Text.Trim());
                int soTrang = Convert.ToInt32(txtSoTrang.Text.Trim());
                int soLuong = Convert.ToInt32(txtSoLuong.Text.Trim());
                int gia = Convert.ToInt32(txtGia.Text.Trim());

                string maNXB = cboMaNXB.SelectedValue.ToString();
                string maKho = cboMaKho.SelectedValue.ToString();
                string maNN = cboMaNN.SelectedValue.ToString();
                string maLoaiAP = cboMaLoai.SelectedValue.ToString();

                try
                {
                    TapChiDAL.UpdateTapChi(maTL, tenTL, ngayXB, soRa, soTrang, soLuong, gia, maNXB, maKho, maNN, maLoaiAP);
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
                TapChiDAL.DeleteEmptyTapChi(maTL);
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

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoRa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chkSoLuong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoLuong.Checked)
            {
                cboSoLuong.Enabled = true;
            }
            else
            {
                cboSoLuong.Enabled = false;
            }

            LoadData();
        }

        private void chkNgayXB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNgayXB.Checked)
            {
                cboNgayXB.Enabled = true;
            }
            else
            {
                cboNgayXB.Enabled = false;
            }

            LoadData();
        }

        private void cboSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkSoLuong.Checked)
            {
                LoadData();
            }
        }

        private void cboNgayXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkNgayXB.Checked)
            {
                LoadData();
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