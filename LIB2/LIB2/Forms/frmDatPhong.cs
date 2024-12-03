using LIB2.Class;
using LIB2.DAL;
using LIB2.Database;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmDatPhong : MaterialForm
    {
        private DataTable tblDatPhong;
        private DataTable tblCTDatPhong;

        public bool isAdding = false;
        public bool isEditing = false;

        public frmDatPhong()
        {
            InitializeComponent();
            InitializeListView();

            string fillComboSqlVP = "SELECT * FROM ViPham;";
            DatabaseLayer.FillCombo(fillComboSqlVP, cboViPham, "MaVP", "TenVP");

            cboViPham.SelectedItem = null;

            cboCaSuDung.Items.Add("1");
            cboCaSuDung.Items.Add("2");
            cboCaSuDung.Items.Add("3");
            cboCaSuDung.Items.Add("4");
            cboCaSuDung.Items.Add("5");
            cboCaSuDung.Items.Add("6");
            cboCaSuDung.Items.Add("7");
            cboCaSuDung.Items.Add("8");
            cboCaSuDung.Items.Add("9");

            cboPhong.Items.Add("Tầng 2");
            cboPhong.Items.Add("Tầng 4");
            cboPhong.Items.Add("Tầng 6");
        }

        private void InitializeListView()
        {
            listViewDP.FullRowSelect = true;
            listViewDP.MultiSelect = false;
            listViewDP.UseCompatibleStateImageBehavior = false;
            listViewDP.View = View.Details;

            listViewDP.Columns.Add("MaBD", "Mã bạn đọc");
            listViewDP.Columns.Add("TenBD", "Tên bạn đọc");
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            txtMaDP.Enabled = true;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;

            btnHuy.Enabled = false;

            btnThemBD.Enabled = false;
            btnXoaBD.Enabled = false;

            txtMaBD.Enabled = false;

            btnThemVP.Enabled = false;

            chkViPham.Enabled = false;

            txtSoTienPhat.Enabled = false;

            ResetThongTinBanDoc();
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewDP.ClientSize.Width;
            double col1Percentage = 0.3;
            double col2Percentage = 0.7;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);

            listViewDP.Columns[0].Width = col1Width;
            listViewDP.Columns[1].Width = col2Width;
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
                        lblKhoa.Text = dt.Rows[0]["TenKhoa"].ToString();
                        lblLopNC.Text = dt.Rows[0]["LopNC"].ToString();
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

        private void LoadDataCT(string maDP)
        {
            try
            {
                tblCTDatPhong = DatPhongDAL.GetCTDatPhong(maDP); ;

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

            foreach (DataRow row in tblCTDatPhong.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaBD"].ToString());
                item.SubItems.Add(row["TenBD"].ToString());

                listViewDP.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void listViewDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (btnThem.Enabled == false)
            //{
            //    Functions.HandleInfo("Đang ở chế độ thêm mới");
            //    txtMaBD.Focus();
            //    return;
            //}

            //if (btnThemBD.Enabled == false)
            //{
            //    Functions.HandleInfo("Đang ở chế độ thêm mới");
            //    txtMaBD.Focus();
            //    return;
            //}

            if (tblCTDatPhong.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewDP.SelectedItems.Count > 0)
            {
                txtMaBD.Enabled = true;

                ListViewItem selectedItem = listViewDP.SelectedItems[0];
                txtMaBD.Text = selectedItem.SubItems[0].Text;

                string maBD = txtMaBD.Text;

                DataTable dt = BanDocDAL.GetBanDocByMa(maBD);

                if (dt.Rows.Count > 0)
                {
                    lblTenBD.Text = dt.Rows[0]["TenBD"].ToString();
                    lblKhoa.Text = dt.Rows[0]["TenKhoa"].ToString();
                    lblLopNC.Text = dt.Rows[0]["LopNC"].ToString();
                }
                else
                {
                    ResetThongTinBanDoc();
                }

                btnXoaBD.Enabled = true;

                btnThemVP.Enabled = true;
                chkViPham.Enabled = true;
            }
            else
            {
                ResetValuesCT();
                ResetValuesVP();

                txtMaBD.Enabled = false;

                btnXoaBD.Enabled = false;

                btnThemVP.Enabled = false;
                chkViPham.Enabled = false;
            }
        }

        private void ClearListView()
        {
            listViewDP.Items.Clear();
        }

        private void ResetValues()
        {
            txtMaDP.Text = "";
            txtTGDat.Text = "";

            cboCaSuDung.SelectedItem = null;
            cboPhong.SelectedItem = null;

            rdoCoSD.Checked = false;
            rdoKhongSD.Checked = false;
        }

        private void ResetValuesCT()
        {
            txtMaBD.Text = "";
        }

        private void ResetValuesVP()
        {
            chkViPham.Checked = false;
            txtSoTienPhat.Text = "";
        }

        private void ResetThongTinBanDoc()
        {
            lblTenBD.Text = string.Empty;
            lblKhoa.Text = string.Empty;
            lblLopNC.Text = string.Empty;
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaDP.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã mượn trả");
                txtMaThue.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtTGDat.Text))
            {
                Functions.HandleWarning("Bạn phải nhập thời gian đặt");
                txtMaBD.Focus();
                return false;
            }

            if (cboPhong.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn phòng");
                cboPhong.Focus();
                return false;
            }

            if (cboCaSuDung.SelectedItem == null)
            {
                Functions.HandleWarning("Bạn phải chọn ca sử dụng");
                cboPhong.Focus();
                return false;
            }

            if (!rdoCoSD.Checked && !rdoKhongSD.Checked)
            {
                Functions.HandleWarning("Bạn phải chọn tình trạng sử dụng");
                rdoCoSD.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateInputCT()
        {
            if (string.IsNullOrWhiteSpace(txtMaBD.Text) || string.IsNullOrWhiteSpace(lblTenBD.Text))
            {
                Functions.HandleWarning("Bạn phải nhập bạn đọc");
                txtMaBD.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaDP.Enabled = false; 
            
            btnThem.Enabled = false;
            isAdding = true;

            btnHuy.Enabled = true;
            btnLuu.Enabled = true;

            txtMaBD.Enabled = true;
            btnThemBD.Enabled = true;

            ResetValues();
            ResetValuesCT();
            ResetValuesVP();

            ClearListView();

            string maDatPhong = DatabaseLayer.CreateKey("DP");
            txtMaDP.Text = maDatPhong;
            txtTGDat.Text = DateTime.Now.ToString("dd/MM/yyyy");

            DatPhongDAL.InsertEmptyDatPhong(maDatPhong);

            txtMaBD.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maDP = txtMaDP.Text.Trim();

            if (!DatPhongDAL.CheckMaDatPhongExists(maDP))
            {
                if (ValidateInput())
                {
                    DateTime TGDat;
                    if (!DateTime.TryParse(txtTGDat.Text.Trim(), out TGDat))
                    {
                        Functions.HandleWarning("Thời gian đặt không hợp lệ");
                        txtTGDat.Focus();
                        return;
                    }

                    string phong = cboPhong.SelectedItem.ToString();
                    int caSuDung = Convert.ToInt32(cboCaSuDung.SelectedItem.ToString());

                    bool trangThai = rdoCoSD.Checked;

                    if (DatPhongDAL.GetDatPhongByPhongCaSuDung(phong, caSuDung, TGDat))
                    {
                        Functions.HandleWarning($"Phòng {phong} đã được đặt vào ca {caSuDung}, ngày {TGDat:dd/MM/yyyy}");
                        return;
                    }

                    try
                    {
                        DatPhongDAL.UpdateDatPhong(maDP, TGDat, phong, caSuDung, trangThai);

                        Functions.HandleInfo("Lưu thông tin đặt phòng thành công");
                        ClearListView();

                        ResetValues();
                        ResetValuesCT();
                        ResetValuesVP();

                        txtMaDP.Enabled = false;

                        btnThem.Enabled = true;
                        btnHuy.Enabled = false;
                        btnLuu.Enabled = false;

                        txtMaBD.Enabled = false;
                        btnThemBD.Enabled = false;
                        btnXoaBD.Enabled = false;

                        btnThemVP.Enabled = false;

                        chkViPham.Checked = false;
                        chkViPham.Enabled = false;

                        isAdding = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi thêm đặt phòng: " + ex.Message);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maDP = txtMaDP.Text.Trim();

            ResetValuesVP();
            ResetValuesCT();
            ResetValues();

            btnThem.Enabled = true;
            isAdding = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            txtMaDP.Enabled = true;

            txtMaBD.Enabled = false;

            btnThemBD.Enabled = false;

            if (!string.IsNullOrEmpty(maDP))
            {
                DatPhongDAL.DeleteEmptyDatPhong(maDP);
            }

            ClearListView();
        }

        private void btnThemBD_Click(object sender, EventArgs e)
        {
            string maBD = txtMaBD.Text.Trim();

            if (ValidateInputCT())
            {
                string maDP = txtMaDP.Text.Trim();

                if (DatPhongDAL.CheckMaBanDocDP(maDP, maBD))
                {
                    Functions.HandleWarning("Bạn đọc đã có trong danh sách sử dụng phòng này, vui lòng chọn bạn đọc khác hoặc xoá");
                    ResetValuesCT();
                    txtMaBD.Focus();
                    return;
                }

                try
                {
                    DatPhongDAL.InsertCTDatPhong(maDP, maBD);
                    Functions.HandleInfo("Thêm bạn đọc đặt phòng thành công");

                    LoadDataCT(maDP);
                    ResetValuesCT();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm chi tiết đặt phòng: " + ex.Message);
                }
            }
        }

        private void btnXoaBD_Click(object sender, EventArgs e)
        {
            string maDP = txtMaDP.Text.Trim();
            string maBD = txtMaBD.Text.Trim();

            if (!string.IsNullOrEmpty(maDP) && !string.IsNullOrEmpty(maBD))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        DatPhongDAL.DeleteCTDatPhong(maDP, maBD);
                        Functions.HandleInfo("Xóa bạn đọc khỏi đặt phòng thành công");

                        LoadDataCT(maDP);
                        ResetValuesCT();
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa sách: " + ex.Message);
                    }
                }
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
            var childFormDatPhongList = new frmDatPhongList();
            childFormDatPhongList.Show();
        }

        private void btnThemVP_Click(object sender, EventArgs e)
        {
            string maBD = txtMaBD.Text.Trim();

            if (!String.IsNullOrEmpty(maBD))
            {   
                string tenVP = cboViPham.Text.Trim();
                DataTable VP = ViPhamDAL.GetViPhamByTenVP(tenVP);

                if (VP.Rows.Count > 0)
                {
                    string maVP = VP.Rows[0]["MaVP"].ToString();
                    int soPhanTram = Convert.ToInt32(VP.Rows[0]["SoPhanTram"].ToString());
                    int soTienCoDinh = Convert.ToInt32(VP.Rows[0]["SoTienCoDinh"].ToString());
                    int soTienPhat = soTienCoDinh;

                    if (chkViPham.Checked)
                    {
                        try
                        {
                            PhatDAL.InsertPhat(maBD, maVP, DateTime.Now, soTienPhat, false);
                            Functions.HandleInfo("Thêm vi phạm thành công");
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
            string maBD = txtMaBD.Text.Trim();

            if (!String.IsNullOrEmpty(maBD))
            {
                string tenVP = cboViPham.Text.Trim();
                DataTable VP = ViPhamDAL.GetViPhamByTenVP(tenVP);

                if (VP.Rows.Count > 0)
                {
                    string maVP = VP.Rows[0]["MaVP"].ToString();
                    int soTienCoDinh = Convert.ToInt32(VP.Rows[0]["SoTienCoDinh"].ToString());
                    int soTienPhat = soTienCoDinh;

                    txtSoTienPhat.Text = soTienPhat.ToString();
                }
                else
                {
                    Functions.HandleWarning("Không tìm thấy vi phạm");
                }
            }
        }

        private void txtMaDP_TextChanged(object sender, EventArgs e)
        {
            string maDP = txtMaDP.Text.Trim();

            if (!String.IsNullOrEmpty(maDP))
            {
                try
                {
                    DataTable dt = DatPhongDAL.GetDatPhongByMaDP(maDP);

                    if (dt.Rows.Count > 0)
                    {
                        string TGDatStr = dt.Rows[0]["TGDat"].ToString();
                        DateTime TGDat;
                        if (DateTime.TryParse(TGDatStr, out TGDat))
                        {
                            txtTGDat.Text = TGDat.ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            txtTGDat.Text = "";
                        }

                        cboPhong.Text = dt.Rows[0]["Phong"].ToString();
                        cboCaSuDung.Text = dt.Rows[0]["CaSuDung"].ToString();

                        btnLuu.Enabled = true;
                        btnHuy.Enabled = true;

                        bool TTSuDung = Convert.ToBoolean(dt.Rows[0]["TTSuDung"].ToString());
                        if (TTSuDung)
                        {
                            rdoCoSD.Checked = true;
                            rdoKhongSD.Checked = false;
                        }
                        else
                        {
                            rdoCoSD.Checked = false; 
                            rdoKhongSD.Checked = true;
                        }

                        LoadDataCT(maDP);
                    }
                    else
                    {
                        ClearListView();
                        txtTGDat.Text = "";

                        cboCaSuDung.SelectedItem = null;
                        cboPhong.SelectedItem = null;

                        rdoCoSD.Checked = false;
                        rdoKhongSD.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi tải thông tin đặt phòng: " + ex.Message);
                    ResetThongTinBanDoc();
                }
            }
        }

        private void CheckPhong(string phong, int caSuDung, DateTime TGDat)
        {
            try
            {
                if (DatPhongDAL.GetDatPhongByPhongCaSuDung(phong, caSuDung, TGDat))
                {
                    Functions.HandleWarning($"Phòng {phong} đã được đặt vào ca {caSuDung}, ngày {TGDat:dd/MM/yyyy}");
                }
                else
                {
                    Functions.HandleInfo($"Phòng {phong} vẫn còn trống trong ca {caSuDung}, ngày {TGDat:dd/MM/yyyy}");
                }
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi kiểm tra phòng: " + ex.Message);
            }
        }

        private void btnKiemTraPhong_Click(object sender, EventArgs e)
        {
            string phong = cboPhong.Text.Trim();
            string caSuDung = cboCaSuDung.Text.Trim();

            if (!string.IsNullOrEmpty(phong) && !string.IsNullOrEmpty(caSuDung) && DateTime.TryParse(txtTGDat.Text.Trim(), out DateTime TGDat))
            {
                CheckPhong(phong, Convert.ToInt32(caSuDung), TGDat);
            }
        }
    }
}