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
    public partial class frmMuonTra : MaterialForm
    {
        private DataTable tblMuonTra;
        private DataTable tblCTMuonTra;

        public bool isAdding = false;
        public bool isEditing = false;

        public frmMuonTra()
        {
            InitializeComponent();
            InitializeListView();

            string fillComboSqlVP = "SELECT * FROM ViPham;";
            DatabaseLayer.FillCombo(fillComboSqlVP, cboViPham, "MaVP", "TenVP");

            cboViPham.SelectedItem = null;
        }

        private void InitializeListView()
        {
            listViewMT.FullRowSelect = true;
            listViewMT.MultiSelect = false;
            listViewMT.UseCompatibleStateImageBehavior = false;
            listViewMT.View = View.Details;

            listViewMT.Columns.Add("MaMuonTra", "Mã mượn trả");
            listViewMT.Columns.Add("TenSach", "Tên sách");
            listViewMT.Columns.Add("SoLuong", "Số lượng");
            listViewMT.Columns.Add("TTTra", "Trạng thái trả");
            listViewMT.Columns.Add("GhiChu", "Ghi chú");
        }

        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            txtMaMT.Enabled = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;

            btnHuy.Enabled = false;

            btnThemSach.Enabled = false;
            btnSuaSach.Enabled = false;
            btnXoaSach.Enabled = false;

            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGhiChu.Enabled = false;
            rdoChuaTra.Enabled = false;
            rdoDaTra.Enabled = false;

            btnThemVP.Enabled = false;

            chkViPham.Enabled = false;

            txtSoTienPhat.Enabled = false;

            ResetThongTinBanDoc();
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewMT.ClientSize.Width;
            double col1Percentage = 0.2;
            double col2Percentage = 0.3;
            double col3Percentage = 0.1;
            double col4Percentage = 0.2;
            double col5Percentage = 0.2;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);
            int col5Width = (int)(totalWidth * col5Percentage);

            listViewMT.Columns[0].Width = col1Width;
            listViewMT.Columns[1].Width = col2Width;
            listViewMT.Columns[2].Width = col3Width;
            listViewMT.Columns[3].Width = col4Width;
            listViewMT.Columns[4].Width = col5Width;
        }

        private void txtMaBD_TextChanged(object sender, EventArgs e)
        {
            string maBD = txtMaBD.Text.Trim();

            if (!string.IsNullOrEmpty(maBD))
            {
                if (PhatDAL.GetStatusPhatByMaBanDoc(maBD))
                {
                    Functions.HandleWarning("Bạn đọc chưa hoàn thành phạt");
                    return;
                }

                try
                {
                    DataTable dt = BanDocDAL.GetBanDocByMa(maBD);

                    if (dt.Rows.Count > 0)
                    {
                        lblTenBD.Text = dt.Rows[0]["TenBD"].ToString();
                        lblKhoas.Text = dt.Rows[0]["Khoa"].ToString();
                        lblEmail.Text = dt.Rows[0]["Email"].ToString();
                        lblSDT.Text = dt.Rows[0]["SDT"].ToString();
                        lblKhoa.Text = dt.Rows[0]["TenKhoa"].ToString();
                        lblLopNC.Text = dt.Rows[0]["LopNC"].ToString();

                        if (DateTime.TryParse(dt.Rows[0]["NgaySinh"].ToString(), out DateTime ngaySinh))
                        {
                            lblNgaySinh.Text = ngaySinh.ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            lblNgaySinh.Text = "Không xác định";
                        }

                        if (!isAdding && !isEditing)
                        {
                            FillThongTinMuonTra(maBD);
                            FillThongTinCTMuonTra(maBD);
                        }

                        btnLuu.Enabled = true;
                        btnHuy.Enabled = true;
                    }
                    else
                    {
                        ResetThongTinBanDoc();
                    }
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi tải thông tin bạn đọc: " + ex.Message);
                    ResetThongTinBanDoc();
                }
            }
            else
            {
                ResetThongTinBanDoc();
            }
        }

        private void FillThongTinMuonTra(string maBD)
        {
            DataTable dt = MuonTraDAL.GetMuonTraByMaBanDoc(maBD);

            if (dt.Rows.Count > 0)
            {
                txtMaMT.Text = dt.Rows[0]["MaMuonTra"].ToString();

                string ngayMuonStr = dt.Rows[0]["TGMuon"].ToString();
                DateTime ngayMuon;
                if (DateTime.TryParse(ngayMuonStr, out ngayMuon))
                {
                    txtNgayMuon.Text = ngayMuon.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtNgayMuon.Text = "";
                }

                string ngayTraStr = dt.Rows[0]["TGTra"].ToString();
                DateTime ngayTra;
                if (DateTime.TryParse(ngayTraStr, out ngayTra))
                {
                    txtNgayTra.Text = ngayTra.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtNgayTra.Text = "";
                }
            }
            else
            {
                txtMaMT.Text = string.Empty;
                txtNgayMuon.Text = string.Empty;
                txtNgayTra.Text = string.Empty;
            }
        }

        private void FillThongTinCTMuonTra(string maBD)
        {
            try
            {
                tblCTMuonTra = MuonTraDAL.GetCTMuonTraByMaBanDoc(maBD);

                LoadListView();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDataCT(string maMT)
        {
            try
            {
                tblCTMuonTra = MuonTraDAL.GetCTMuonTra(maMT); ;

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

            foreach (DataRow row in tblCTMuonTra.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaTL"].ToString());
                item.SubItems.Add(row["TenSach"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());

                string ttTra = "";
                if (row["TTTra"] != null && row["TTTra"] != DBNull.Value)
                {
                    bool ttValue = Convert.ToBoolean(row["TTTra"]);
                    ttTra = ttValue ? "Đã trả" : "Chưa/không trả";
                }
                else
                {
                    ttTra = "";
                }

                item.SubItems.Add(ttTra);
                item.SubItems.Add(row["GhiChu"].ToString());

                listViewMT.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void listViewMT_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (btnThem.Enabled == false)
            //{
            //    Functions.HandleInfo("Đang ở chế độ thêm mới");
            //    txtMaSach.Focus();
            //    return;
            //}

            //if (btnThemSach.Enabled == false)
            //{
            //    Functions.HandleInfo("Đang ở chế độ thêm mới");
            //    txtMaSach.Focus();
            //    return;
            //}

            if (tblCTMuonTra.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewMT.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewMT.SelectedItems[0];
                txtMaSach.Text = selectedItem.SubItems[0].Text;
                txtTenSach.Text = selectedItem.SubItems[1].Text;
                txtSoLuong.Text = selectedItem.SubItems[2].Text;

                if (selectedItem.SubItems[3].Text == "Đã trả")
                {
                    rdoDaTra.Checked = true;
                    rdoChuaTra.Checked = false;
                }
                else if (selectedItem.SubItems[3].Text == "Chưa/không trả")
                {
                    rdoDaTra.Checked = false;
                    rdoChuaTra.Checked = true;
                }

                txtGhiChu.Text = selectedItem.SubItems[4].Text;

                rdoChuaTra.Enabled = true;
                rdoDaTra.Enabled = true;

                btnSuaSach.Enabled = true;
                btnXoaSach.Enabled = true;

                btnThemVP.Enabled = true;
                chkViPham.Enabled = true;

                txtSoLuong.Enabled = false;

                if (!isAdding)
                {
                    btnThemSach.Enabled = false;
                }
            }
            else
            {
                ResetValuesCT();
                ResetValuesVP();

                btnSuaSach.Enabled = false;
                btnXoaSach.Enabled = false;

                btnThemVP.Enabled = false;
                chkViPham.Enabled = false;

                txtSoLuong.Enabled = true;

                if (!isAdding)
                {
                    btnThemSach.Enabled = false;
                }
            }
        }

        private void ClearListView()
        {
            listViewMT.Items.Clear();
        }

        private void ResetValues()
        {
            txtMaMT.Text = "";
            txtNgayMuon.Text = "";
            txtNgayTra.Text = "";
            txtMaBD.Text = "";
        }

        private void ResetValuesCT()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
            rdoDaTra.Checked = false;
            rdoChuaTra.Checked = false;
        }

        private void ResetValuesVP()
        {
            chkViPham.Checked = false;
            txtSoTienPhat.Text = "";
        }

        private void ResetThongTinBanDoc()
        {
            lblTenBD.Text = string.Empty;
            lblKhoas.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblSDT.Text = string.Empty;
            lblKhoa.Text = string.Empty;
            lblLopNC.Text = string.Empty;
            lblNgaySinh.Text = string.Empty;
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaMT.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã mượn trả");
                txtMaThue.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtNgayMuon.Text))
            {
                Functions.HandleWarning("Bạn phải nhập ngày mượn");
                txtNgayMuon.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNgayTra.Text))
            {
                Functions.HandleWarning("Bạn phải nhập ngày trả");
                txtNgayTra.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMaBD.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã bạn đọc");
                txtMaBD.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateInputCT()
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã sách");
                txtMaSach.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên sách");
                txtTenSach.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số lượng");
                txtSoLuong.Focus();
                return false;
            }

            if (!rdoDaTra.Checked && !rdoChuaTra.Checked)
            {
                Functions.HandleWarning("Bạn phải chọn tình trạng trả sách");
                rdoChuaTra.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            isAdding = true;

            btnHuy.Enabled = true;
            btnLuu.Enabled = true;

            txtMaSach.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGhiChu.Enabled = true;
            btnThemSach.Enabled = true;

            rdoChuaTra.Enabled = true;
            rdoDaTra.Enabled = true;

            ResetValues();
            ResetValuesCT();
            ResetValuesVP();

            ClearListView();

            string maMuonTra = DatabaseLayer.CreateKey("MT");
            txtMaMT.Text = maMuonTra;
            txtNgayMuon.Text = DateTime.Now.ToString("dd/MM/yyyy");

            DateTime ngayTra = DateTime.Now.AddDays(10);
            txtNgayTra.Text = ngayTra.ToString("dd/MM/yyyy");

            MuonTraDAL.InsertEmptyMuonTra(maMuonTra);

            txtMaBD.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maMT = txtMaMT.Text.Trim();

            if (!MuonTraDAL.CheckMaMuonTraExists(maMT))
            {
                if (ValidateInput())
                {
                    string maBD = txtMaBD.Text.Trim();

                    DateTime ngayMuon;
                    if (!DateTime.TryParse(txtNgayMuon.Text.Trim(), out ngayMuon))
                    {
                        Functions.HandleWarning("Ngày mượn không hợp lệ");
                        txtNgayMuon.Focus();
                        return;
                    }

                    DateTime ngayTra;
                    if (!DateTime.TryParse(txtNgayTra.Text.Trim(), out ngayTra))
                    {
                        Functions.HandleWarning("Ngày trả không hợp lệ");
                        txtNgayTra.Focus();
                        return;
                    }

                    try
                    {
                        MuonTraDAL.UpdateMuonTra(maMT, maBD, ngayMuon, ngayTra);

                        Functions.HandleInfo("Thêm mượn trả thành công");
                        ClearListView();

                        ResetValues();
                        ResetValuesCT();
                        ResetValuesVP();

                        btnThem.Enabled = true;
                        btnHuy.Enabled = false;
                        btnLuu.Enabled = false;

                        txtMaSach.Enabled = false;
                        btnThemSach.Enabled = false;
                        btnSuaSach.Enabled = false;
                        btnXoaSach.Enabled = false;
                        rdoChuaTra.Enabled = false;
                        rdoDaTra.Enabled = false;

                        btnThemVP.Enabled = false;

                        chkViPham.Checked = false;
                        chkViPham.Enabled = false;

                        isAdding = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi thêm mượn trả: " + ex.Message);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maMT = txtMaMT.Text.Trim();

            ResetValuesVP();
            ResetValuesCT();
            ResetValues();

            btnThem.Enabled = true;
            isAdding = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            txtMaMT.Enabled = false;

            txtMaSach.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGhiChu.Enabled = false;
            rdoChuaTra.Enabled = false;
            rdoDaTra.Enabled = false;

            btnThemSach.Enabled = false;

            if (!string.IsNullOrEmpty(maMT))
            {
                MuonTraDAL.DeleteEmptyMuonTra(maMT);
            }

            ClearListView();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            string maMT = txtMaMT.Text.Trim();

            if (ValidateInputCT())
            {
                string maSach = txtMaSach.Text.Trim();
                bool tinhTrang = rdoDaTra.Checked;
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                string ghiChu = txtGhiChu.Text.Trim();

                // Kiểm tra xem mã sách đã có trong chi tiết mượn chưa
                if (MuonTraDAL.CheckMaTaiLieuExists(maMT, maSach))
                {
                    Functions.HandleWarning("Sách này đã có trong danh sách mượn, vui lòng chọn sách khác hoặc xoá");
                    ResetValuesCT();
                    txtMaSach.Focus();
                    return;
                }

                // Kiểm tra số lượng sách còn đủ để cho mượn không
                int soLuongCon = SachDAL.GetSoLuong(maSach);
                if (soLuongCon < 1)
                {
                    Functions.HandleWarning("Sách này hiện không còn cuốn để cho mượn");
                    ResetValuesCT();
                    txtMaSach.Focus();
                    return;
                }

                if (soLuongCon < soLuong)
                {
                    Functions.HandleWarning("Sách này hiện không còn đủ cuốn để cho mượn");
                    txtSoLuong.Focus();
                    return;
                }

                try
                {
                    MuonTraDAL.InsertSachCTMuonTra(maMT, maSach, soLuong, tinhTrang, ghiChu);
                    Functions.HandleInfo("Thêm chi tiết mượn trả thành công");

                    if (tinhTrang)
                    {
                        SachDAL.TangSoLuong(maSach, soLuong);
                    }
                    else
                    {
                        SachDAL.GiamSoLuong(maSach, soLuong);
                    }

                    LoadDataCT(maMT);
                    ResetValuesCT();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm chi tiết mượn trả: " + ex.Message);
                }
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            string maMT = txtMaMT.Text.Trim();

            bool tinhTrangCu = listViewMT.SelectedItems[0].SubItems[3].Text == "Đã trả" ? true : false;
            
            if (ValidateInputCT())
            {
                string maSach = txtMaSach.Text.Trim();
                bool tinhTrang = rdoDaTra.Checked;
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                string ghiChu = txtGhiChu.Text.Trim();

                try
                {
                    MuonTraDAL.UpdateSachCTMuonTra(maMT, maSach, soLuong, tinhTrang, ghiChu);
                    Functions.HandleInfo("Sửa chi tiết mượn sách thành công");

                    if (tinhTrang == true && tinhTrangCu == false)
                    {
                        SachDAL.TangSoLuong(maSach, soLuong);
                    }
                    else if (tinhTrang == false && tinhTrangCu == true)
                    {
                        SachDAL.GiamSoLuong(maSach, soLuong);
                    }

                    LoadDataCT(maMT);
                    ResetValuesCT();

                    txtSoLuong.Enabled = true;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi sửa chi tiết mượn trả: " + ex.Message);
                }
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            string maMT = txtMaMT.Text.Trim();
            string maSach = txtMaSach.Text.Trim();
            int soLuong = Convert.ToInt32(txtSoLuong.Text.Trim());

            bool tinhTrang = listViewMT.SelectedItems[0].SubItems[3].Text == "Đã trả" ? true : false;

            if (!string.IsNullOrEmpty(maMT) && !string.IsNullOrEmpty(maSach))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        MuonTraDAL.DeleteSachCTMuonTra(maMT, maSach);
                        Functions.HandleInfo("Xóa sách thành công");

                        if (!tinhTrang)
                        {
                            SachDAL.TangSoLuong(maSach, soLuong);
                        }

                        LoadDataCT(maMT);
                        ResetValuesCT();

                        txtSoLuong.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa sách: " + ex.Message);
                    }
                }
            }
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text.Trim();

            if (!string.IsNullOrEmpty(maSach))
            {
                string sachInfo = SachDAL.GetTenSachByMa(maSach);
                if (sachInfo != null)
                {
                    txtTenSach.Text = sachInfo;
                }
                else
                {
                    txtTenSach.Text = string.Empty;
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chkViPham_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViPham.Checked)
            {
                cboViPham.Enabled = true;
            }
            else
            {
                cboViPham.Enabled = false;
            }
        }

        private void btnOpenList_Click(object sender, EventArgs e)
        {
            var childFormMuonTraList = new frmMuonTraList();
            childFormMuonTraList.Show();
        }

        private void btnThemVP_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text.Trim();
            string maBD = txtMaBD.Text.Trim();
            string maMT = txtMaMT.Text.Trim();

            if (!String.IsNullOrEmpty(maSach) && !String.IsNullOrEmpty(maBD))
            {
                int gia = SachDAL.GetGiaSach(maSach);

                string tenVP = cboViPham.Text.Trim();
                DataTable VP = ViPhamDAL.GetViPhamByTenVP(tenVP);

                if (VP.Rows.Count > 0)
                {
                    string maVP = VP.Rows[0]["MaVP"].ToString();
                    int soPhanTram = Convert.ToInt32(VP.Rows[0]["SoPhanTram"].ToString());
                    int soTienCoDinh = Convert.ToInt32(VP.Rows[0]["SoTienCoDinh"].ToString());
                    int soTienPhat = (int)(gia * soPhanTram / 100) + soTienCoDinh;

                    if (chkViPham.Checked)
                    {
                        try
                        {
                            PhatDAL.InsertPhat(maBD, maVP, DateTime.Now, soTienPhat, false);
                            Functions.HandleInfo("Thêm vi phạm thành công");

                            LoadDataCT(maMT);
                            ResetValuesVP();
                        }
                        catch (Exception ex)
                        {
                            Functions.HandleError("Lỗi khi thêm vi phạm: " + ex.Message);
                        }
                    }
                    else
                    {
                        Functions.HandleWarning("Bạn phải tick chọn hộp vi phạm trước khi thêm");
                    }
                }
                else
                {
                    Functions.HandleWarning("Không tìm thấy vi phạm");
                }
            }
        }

        private void cboViPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text.Trim();
            string maBD = txtMaBD.Text.Trim();

            if (!String.IsNullOrEmpty(maSach) && !String.IsNullOrEmpty(maBD))
            {
                int gia = SachDAL.GetGiaSach(maSach);

                string tenVP = cboViPham.Text.Trim();
                DataTable VP = ViPhamDAL.GetViPhamByTenVP(tenVP);

                if (VP.Rows.Count > 0)
                {
                    string maVP = VP.Rows[0]["MaVP"].ToString();
                    int soPhanTram = Convert.ToInt32(VP.Rows[0]["SoPhanTram"].ToString());
                    int soTienCoDinh = Convert.ToInt32(VP.Rows[0]["SoTienCoDinh"].ToString());
                    int soTienPhat = (int)(gia * soPhanTram / 100) + soTienCoDinh;

                    txtSoTienPhat.Text = soTienPhat.ToString();
                }
                else
                {
                    Functions.HandleWarning("Không tìm thấy vi phạm");
                }
            }
        }
    }
}