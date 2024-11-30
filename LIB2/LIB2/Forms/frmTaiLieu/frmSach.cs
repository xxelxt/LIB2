using LIB2.Class;
using LIB2.DAL;
using LIB2.Database;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmSach : MaterialForm
    {
        private DataTable tblSach;
        private DataTable tblTGSach;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        public frmSach()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();

            string fillComboLoai = "SELECT * FROM LoaiAnPham";
            DatabaseLayer.FillCombo(fillComboLoai, cboMaLoai, "MaLoaiAP", "TenLoaiAP");
            cboMaLoai.SelectedItem = null;

            string fillComboNXB = "SELECT * FROM NhaXuatBan";
            DatabaseLayer.FillCombo(fillComboNXB, cboMaNXB, "MaNXB", "TenNXB");
            cboMaNXB.SelectedItem = null;

            string fillComboLV = "SELECT * FROM LinhVuc";
            DatabaseLayer.FillCombo(fillComboLV, cboMaLV, "MaLV", "TenLV");
            cboMaLV.SelectedItem = null;

            string fillComboNN = "SELECT * FROM NgonNgu";
            DatabaseLayer.FillCombo(fillComboNN, cboMaNN, "MaNN", "TenNN");
            cboMaNN.SelectedItem = null;

            string fillComboNganh = "SELECT * FROM Nganh";
            DatabaseLayer.FillCombo(fillComboNganh, cboMaNganh, "MaNganh", "TenNganh");
            cboMaNganh.SelectedItem = null;

            string fillComboKho = "SELECT * FROM Kho";
            DatabaseLayer.FillCombo(fillComboKho, cboMaKho, "MaKho", "TenKho");
            cboMaKho.SelectedItem = null;

            cboTimKiem.Items.Add("Mã sách");
            cboTimKiem.Items.Add("Tên sách");
            cboTimKiem.Items.Add("Loại sách");
            cboTimKiem.Items.Add("Lĩnh vực");
            cboTimKiem.Items.Add("Tác giả");
            cboTimKiem.Items.Add("Ngôn ngữ");
            cboTimKiem.Items.Add("Kho");
            cboTimKiem.Items.Add("Ngành");

            cboSoLuong.Items.Add("Mặc định");
            cboSoLuong.Items.Add("Tăng dần");
            cboSoLuong.Items.Add("Giảm dần");

            cboSoLuong.SelectedItem = "Mặc định";
            chkSoLuong.Checked = false;
            cboSoLuong.Enabled = false;
        }

        private void InitializeListView()
        {
            listViewTL.FullRowSelect = true;
            listViewTL.MultiSelect = false;
            listViewTL.UseCompatibleStateImageBehavior = false;
            listViewTL.View = View.Details;

            listViewTL.Columns.Add("MaSach", "Mã sách");
            listViewTL.Columns.Add("TenSach", "Tên sách");
            listViewTL.Columns.Add("TenTacGia", "Tác giả");

            listViewTL.Columns.Add("MaNXB", "Nhà xuất bản");
            listViewTL.Columns.Add("MaKho", "Kho");
            listViewTL.Columns.Add("MaNN", "Ngôn ngữ");
            listViewTL.Columns.Add("MaNganh", "Ngành");
            listViewTL.Columns.Add("MaLV", "Lĩnh vực");

            listViewTL.Columns.Add("NamXB", "Năm xuất bản");
            listViewTL.Columns.Add("SoTrang", "Số trang");
            listViewTL.Columns.Add("SoLuong", "Số lượng");
            listViewTL.Columns.Add("DonGia", "Giá sách");
            
            listViewTL.Columns.Add("MaLoaiAP", "Loại ấn phẩm");
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;

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
            double col3Percentage = 0.3;
            double col4Percentage = 0.08;
            double col5Percentage = 0.08;

            double col6Percentage = 0.08;
            double col7Percentage = 0.08;
            double col8Percentage = 0.08;
            double col9Percentage = 0.13;

            double col10Percentage = 0.1;
            double col11Percentage = 0.1;
            double col12Percentage = 0.1;
            double col13Percentage = 0.1;

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
            int col12Width = (int)(totalWidth * col12Percentage);
            int col13Width = (int)(totalWidth * col13Percentage);


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
            listViewTL.Columns[11].Width = col12Width;
            listViewTL.Columns[12].Width = col13Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblSach = SachDAL.GetSachBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblSach = SachDAL.GetAllSach();

                DataView dv = tblSach.DefaultView;

                string sortExpression = "";
                if (chkSoLuong.Checked && cboSoLuong.SelectedItem.ToString() != "Mặc định")
                {
                    sortExpression += "SoLuong " + (cboSoLuong.Text == "Tăng dần" ? "ASC" : "DESC");
                }

                if (!string.IsNullOrEmpty(sortExpression))
                {
                    dv.Sort = sortExpression;
                }

                tblSach = dv.ToTable();
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

            foreach (DataRow row in tblSach.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaSach"].ToString());
                item.SubItems.Add(row["TenSach"].ToString());
                item.SubItems.Add(row["TenTacGia"].ToString());

                item.SubItems.Add(row["MaNXB"].ToString());
                item.SubItems.Add(row["MaKho"].ToString());
                item.SubItems.Add(row["MaNN"].ToString());
                item.SubItems.Add(row["MaNganh"].ToString());
                item.SubItems.Add(row["MaLV"].ToString());

                item.SubItems.Add(row["SoTrang"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(row["DonGia"].ToString());

                item.SubItems.Add(row["MaLoai"].ToString());

                listViewTL.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewTL.Items.Clear();
        }

        private void listViewSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaSach.Focus();
                return;
            }

            if (tblSach.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewTL.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTL.SelectedItems[0];
                txtMaSach.Text = selectedItem.SubItems[0].Text;
                txtTenSach.Text = selectedItem.SubItems[1].Text;

                cboMaNXB.Text = DatabaseLayer.GetFieldValues("SELECT TenNXB FROM NhaXuatBan WHERE MaNXB = N'" + selectedItem.SubItems[3].Text + "';");
                cboMaKho.Text = DatabaseLayer.GetFieldValues("SELECT TenKho FROM Kho WHERE MaKho = N'" + selectedItem.SubItems[4].Text + "';");
                cboMaNN.Text = DatabaseLayer.GetFieldValues("SELECT TenNN FROM NgonNgu WHERE MaNN = N'" + selectedItem.SubItems[5].Text + "';");
                cboMaNganh.Text = DatabaseLayer.GetFieldValues("SELECT TenNganh FROM Nganh WHERE MaNganh = N'" + selectedItem.SubItems[6].Text + "';");
                cboMaLV.Text = DatabaseLayer.GetFieldValues("SELECT TenLV FROM LinhVuc WHERE MaLV = N'" + selectedItem.SubItems[7].Text + "';");

                txtNamXB.Text = selectedItem.SubItems[8].Text;
                txtSoTrang.Text = selectedItem.SubItems[9].Text;
                txtSoLuong.Text = selectedItem.SubItems[10].Text;
                txtGia.Text = selectedItem.SubItems[11].Text;

                cboMaLoai.Text = DatabaseLayer.GetFieldValues("SELECT TenLoaiAP FROM LoaiAnPham WHERE MaLoaiAP = N'" + selectedItem.SubItems[12].Text + "';");

                FillTacGiaArea(selectedItem.SubItems[0].Text);

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

        private void FillTacGiaArea(string maSach)
        {
            ResetValuesTG();

            tblTGSach = SachDAL.GetTacGiaSach(maSach);

            int maxFields = 10;

            for (int i = 0; i < maxFields; i++)
            {
                TextBox txtMaTG = this.Controls.Find($"txtMaTG{i + 1}", true).FirstOrDefault() as TextBox;
                TextBox txtTenTG = this.Controls.Find($"txtTenTG{i + 1}", true).FirstOrDefault() as TextBox;

                if (txtMaTG != null && txtTenTG != null)
                {
                    if (i < tblTGSach.Rows.Count)
                    {
                        txtMaTG.Text = tblTGSach.Rows[i]["MaTG"].ToString();
                        txtTenTG.Text = tblTGSach.Rows[i]["TenTG"].ToString();
                    }
                    else
                    {
                        txtMaTG.Text = string.Empty;
                        txtTenTG.Text = string.Empty;
                    }
                }
            }
        }

        private void ResetValues()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";

            cboMaNXB.SelectedItem = null;
            cboMaKho.SelectedItem = null;
            cboMaNN.SelectedItem = null;
            cboMaNganh.SelectedItem = null;
            cboMaLV.SelectedItem = null;
            cboMaLoai.SelectedItem = null;

            txtNamXB.Text = "";
            txtSoTrang.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";

            ResetValuesTG();
        }

        private void ResetValuesTG()
        {
            for (int i = 1; i <= 10; i++)
            {
                TextBox txtMaTG = this.Controls.Find($"txtMaTG{i}", true).FirstOrDefault() as TextBox;
                TextBox txtTenTG = this.Controls.Find($"txtTenTG{i}", true).FirstOrDefault() as TextBox;

                if (txtMaTG != null) txtMaTG.Text = string.Empty;
                if (txtTenTG != null) txtTenTG.Text = string.Empty;
            }
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã sách");
                txtMaSach.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên sách");
                txtTenSach.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenTG1.Text) && string.IsNullOrWhiteSpace(txtMaTG1.Text))
            {
                Functions.HandleWarning("Bạn phải nhập ít nhất 1 tác giả");
                txtTenTG1.Focus();
                return false;
            }

            if (cboMaLoai.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn loại sách");
                cboMaLoai.Focus();
                return false;
            }

            if (cboMaKho.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn kho");
                cboMaKho.Focus();
                return false;
            }

            if (cboMaNXB.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn nhà xuất bản");
                cboMaNXB.Focus();
                return false;
            }

            if (cboMaNN.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn ngôn ngữ");
                cboMaNN.Focus();
                return false;
            }

            if (cboMaLV.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn lĩnh vực");
                cboMaLV.Focus();
                return false;
            }

            if (cboMaNganh.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn ngành");
                cboMaNganh.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNamXB.Text))
            {
                Functions.HandleWarning("Bạn phải nhập năm xuất bản");
                txtNamXB.Focus();
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

            if (string.IsNullOrWhiteSpace(txtSoTrang.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số trang");
                txtSoTrang.Focus();
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
            txtTenSach.Focus();

            string newMaSach = SachDAL.InsertEmptySach();
            txtMaSach.Text = newMaSach;
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
                string maSach = txtMaSach.Text.Trim();
                string tenSach = txtTenSach.Text.Trim();

                string maLoai = cboMaLoai.SelectedValue.ToString();
                string maKho = cboMaKho.SelectedValue.ToString();
                string maNXB = cboMaNXB.SelectedValue.ToString();
                string maNN = cboMaNN.SelectedValue.ToString();
                string maNganh = cboMaNganh.SelectedValue.ToString();
                string maLV = cboMaLV.SelectedValue.ToString();

                int soLuong = Convert.ToInt32(txtSoLuong.Text.Trim());
                int gia = Convert.ToInt32(txtGia.Text.Trim());
                int namXB = Convert.ToInt32(txtNamXB.Text.Trim());
                int soTrang = Convert.ToInt32(txtSoTrang.Text.Trim());

                try
                {
                    SachDAL.UpdateSach(maSach, tenSach, maNXB, maKho, maNN, maNganh, maLV, namXB, soTrang, soLuong, gia, maLoai);
                    
                    SachDAL.DeleteAllTacGiaByMaSach(maSach);

                    for (int i = 1; i <= 10; i++)
                    {
                        TextBox txtMaTG = this.Controls.Find($"txtMaTG{i}", true).FirstOrDefault() as TextBox;
                        TextBox txtTenTG = this.Controls.Find($"txtTenTG{i}", true).FirstOrDefault() as TextBox;

                        if (txtMaTG != null && txtTenTG != null && !string.IsNullOrWhiteSpace(txtMaTG.Text))
                        {
                            string maTG = txtMaTG.Text.Trim();

                            SachDAL.AddTacGiaToSach(maSach, maTG);
                        }
                    }
                    
                    Functions.HandleInfo("Cập nhật sách thành công");
                    LoadData();
                    ResetValues();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi cập nhật sách: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text.Trim();

            if (!string.IsNullOrEmpty(maSach))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        SachDAL.DeleteSach(maSach);
                        Functions.HandleInfo("Xóa sách thành công");
                        LoadData();
                        ResetValues();

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa sách: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string maSach = txtMaSach.Text.Trim();
                string tenSach = txtTenSach.Text.Trim();

                string maLoai = cboMaLoai.SelectedValue.ToString();
                string maKho = cboMaKho.SelectedValue.ToString();
                string maNXB = cboMaNXB.SelectedValue.ToString();
                string maNN = cboMaNN.SelectedValue.ToString();
                string maNganh = cboMaNganh.SelectedValue.ToString();
                string maLV = cboMaLV.SelectedValue.ToString();

                int soLuong = Convert.ToInt32(txtSoLuong.Text.Trim());
                int gia = Convert.ToInt32(txtGia.Text.Trim());
                int namXB = Convert.ToInt32(txtNamXB.Text.Trim());
                int soTrang = Convert.ToInt32(txtSoTrang.Text.Trim());

                try
                {
                    SachDAL.UpdateSach(maSach, tenSach, maNXB, maKho, maNN, maNganh, maLV, namXB, soTrang, soLuong, gia, maLoai);

                    SachDAL.DeleteAllTacGiaByMaSach(maSach);

                    for (int i = 1; i <= 10; i++)
                    {
                        TextBox txtMaTG = this.Controls.Find($"txtMaTG{i}", true).FirstOrDefault() as TextBox;
                        TextBox txtTenTG = this.Controls.Find($"txtTenTG{i}", true).FirstOrDefault() as TextBox;

                        if (txtMaTG != null && txtTenTG != null && !string.IsNullOrWhiteSpace(txtMaTG.Text))
                        {
                            string maTG = txtMaTG.Text.Trim();

                            SachDAL.AddTacGiaToSach(maSach, maTG);
                        }
                    }

                    Functions.HandleInfo("Thêm sách thành công");
                    LoadData();
                    ResetValues();

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    txtMaSach.Enabled = false;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm sách: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text.Trim();

            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            txtMaSach.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maSach))
            {
                SachDAL.DeleteEmptySach(maSach);
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

        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cboSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkSoLuong.Checked)
            {
                LoadData();
            }
        }

        private void txtTenTG_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            if (currentTextBox != null)
            {
                string tenTG = currentTextBox.Text.Trim();

                // Tìm TextBox MaTG tương ứng
                string maTGTextBoxName = currentTextBox.Name.Replace("TenTG", "MaTG");
                TextBox correspondingMaTG = this.Controls.Find(maTGTextBoxName, true).FirstOrDefault() as TextBox;

                if (correspondingMaTG != null)
                {
                    if (!string.IsNullOrEmpty(tenTG))
                    {
                        correspondingMaTG.Text = TacGiaDAL.GetMaTacGiaByTen(tenTG);
                    }
                    else
                    {
                        correspondingMaTG.Text = string.Empty;
                    }
                }
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
