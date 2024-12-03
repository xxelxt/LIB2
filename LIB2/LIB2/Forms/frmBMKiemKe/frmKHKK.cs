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
    public partial class frmKHKK : MaterialForm
    {
        public UserRole currentRole;
        public string Username { get; set; }

        private DataTable tblKHKK;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        public frmKHKK()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();

            cboTimKiem.Items.Add("Mã kế hoạch");
            cboTimKiem.Items.Add("Nhân viên lập");
            cboTimKiem.Items.Add("Nhân viên duyệt");
            cboTimKiem.Items.Add("Ngày lập");
            cboTimKiem.Items.Add("Ngày duyệt");
        }

        private void InitializeListView()
        {
            listViewKHKK.FullRowSelect = true;
            listViewKHKK.MultiSelect = false;
            listViewKHKK.UseCompatibleStateImageBehavior = false;
            listViewKHKK.View = View.Details;

            listViewKHKK.Columns.Add("MaKHKK", "Mã báo cáo");
            listViewKHKK.Columns.Add("MaNVLap", "Mã nhân viên lập");
            listViewKHKK.Columns.Add("TenNVLap", "Tên nhân viên lập");
            listViewKHKK.Columns.Add("MaNVDuyet", "Mã nhân viên duyệt");
            listViewKHKK.Columns.Add("TenNVDuyet", "Tên nhân viên duyệt");

            listViewKHKK.Columns.Add("NgayLap", "Ngày lập");
            listViewKHKK.Columns.Add("NgayDuyet", "Ngày duyệt");

            listViewKHKK.Columns.Add("DuongDan", "Đường dẫn tới file");
            listViewKHKK.Columns.Add("TrangThai", "Trạng thái duyệt");
        }

        private void frmKHKK_Load(object sender, EventArgs e)
        {
            txtMaKHKK.Enabled = false;

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
            btnKhongDuyet.Enabled = false;

            btnAddFile.Enabled = false;
            btnOpenFile.Enabled = false;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewKHKK.ClientSize.Width;

            double col1Percentage = 0.1;
            double col2Percentage = 0.1;
            double col3Percentage = 0.15;
            double col4Percentage = 0.1;

            double col5Percentage = 0.15;
            double col6Percentage = 0.1;
            double col7Percentage = 0.1;
            double col8Percentage = 0.2;
            double col9Percentage = 0.15;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);

            int col5Width = (int)(totalWidth * col5Percentage);
            int col6Width = (int)(totalWidth * col6Percentage);
            int col7Width = (int)(totalWidth * col7Percentage);
            int col8Width = (int)(totalWidth * col8Percentage);
            int col9Width = (int)(totalWidth * col9Percentage);

            listViewKHKK.Columns[0].Width = col1Width;
            listViewKHKK.Columns[1].Width = col2Width;
            listViewKHKK.Columns[2].Width = col3Width;
            listViewKHKK.Columns[3].Width = col4Width;

            listViewKHKK.Columns[4].Width = col5Width;
            listViewKHKK.Columns[5].Width = col6Width;
            listViewKHKK.Columns[6].Width = col7Width;
            listViewKHKK.Columns[7].Width = col8Width;
            listViewKHKK.Columns[8].Width = col9Width;
        }

        public void LoadData()
        {
            try
            {
                if (isSearching)
                    tblKHKK = KHKKDAL.GetKHKKBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblKHKK = KHKKDAL.GetAllKHKK();

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

            foreach (DataRow row in tblKHKK.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaKHKiemKe"].ToString());
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

                item.SubItems.Add(row["DuongDan"].ToString());

                string trangThai = "";
                if (row["TrangThai"] != null && row["TrangThai"] != DBNull.Value)
                {
                    bool trangThaiValue = Convert.ToBoolean(row["TrangThai"]);
                    trangThai = trangThaiValue ? "Đã duyệt" : "Không duyệt";
                }
                else
                {
                    trangThai = "";
                }

                item.SubItems.Add(trangThai);

                listViewKHKK.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewKHKK.Items.Clear();
        }

        private void listViewKHKK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaKHKK.Focus();
                return;
            }

            if (tblKHKK.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewKHKK.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewKHKK.SelectedItems[0];
                txtMaKHKK.Text = selectedItem.SubItems[0].Text;
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

                txtFile.Text = selectedItem.SubItems[7].Text;

                btnLuu.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
                btnIn.Enabled = true;

                btnAddFile.Enabled = true;
                btnOpenFile.Enabled = true;

                if (currentRole == UserRole.Admin)
                {
                    btnKhongDuyet.Enabled = true;

                    if (string.IsNullOrEmpty(txtNgayDuyet.Text))
                    {
                        btnDuyet.Enabled = true;
                    }
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
                btnKhongDuyet.Enabled = false;

                btnAddFile.Enabled = false;
                btnOpenFile.Enabled = false;
            }
        }

        private void ResetValues()
        {
            txtMaKHKK.Text = "";
            txtMaNVLap.Text = NhanVienDAL.GetMaNVByUsername(Username);
            txtMaNVDuyet.Text = "";
            txtNgayLap.Text = "";
            txtNgayDuyet.Text = "";
            txtFile.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaKHKK.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã nhân viên");
                txtMaKHKK.Focus();
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

            if (string.IsNullOrWhiteSpace(txtFile.Text))
            {
                Functions.HandleWarning("Bạn phải tải lên file");
                txtFile.Focus();
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

            btnAddFile.Enabled = true;
            btnOpenFile.Enabled = true;

            ResetValues();

            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime today = DateTime.Now;

            string newMaKHKK = KHKKDAL.InsertEmptyKHKK();
            txtMaKHKK.Text = newMaKHKK;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maKHKK = txtMaKHKK.Text.Trim();

            ResetValues();

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnIn.Enabled = false;

            txtMaKHKK.Enabled = false;

            btnAddFile.Enabled = false;
            btnOpenFile.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maKHKK))
            {
                KHKKDAL.DeleteEmptyKHKK(maKHKK);
            }

            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKHKK = txtMaKHKK.Text.Trim();

            if (!string.IsNullOrEmpty(maKHKK))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        KHKKDAL.DeleteKHKK(maKHKK);
                        Functions.HandleInfo("Xóa báo cáo kiểm kê thành công");
                        LoadData();
                        ResetValues();

                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                        btnIn.Enabled = false;

                        btnAddFile.Enabled = false;
                        btnOpenFile.Enabled = false;
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
            string maKHKK = txtMaKHKK.Text.Trim();

            if (!KHKKDAL.CheckMaKHKKExists(maKHKK))
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

                    string filePath = txtFile.Text.Trim();
                    string targetDirectory = @"C:\Users\Elt\Desktop\Quản lý dự án CNTT\LIB2\Excel\KiemKe\KeHoachKiemKe";
                    string newFilePath = "";

                    try
                    {
                        if (!System.IO.Directory.Exists(targetDirectory))
                        {
                            System.IO.Directory.CreateDirectory(targetDirectory);
                        }

                        if (System.IO.File.Exists(filePath))
                        {
                            string fileName = System.IO.Path.GetFileName(filePath);
                            newFilePath = System.IO.Path.Combine(targetDirectory, fileName);

                            System.IO.File.Copy(filePath, newFilePath, true);

                            txtFile.Text = newFilePath;
                        }
                        else
                        {
                            Functions.HandleError("Tệp không tồn tại: " + filePath);
                            return;
                        }

                        KHKKDAL.UpdateKHKK(maKHKK, maNVLap, ngayLap, filePath);
                        Functions.HandleInfo("Lưu Kế hoạch kiểm kê thành công");
                        LoadData();
                        ResetValues();

                        btnThem.Enabled = true;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                        btnLuu.Enabled = false;
                        btnIn.Enabled = false;

                        btnAddFile.Enabled = false;
                        btnOpenFile.Enabled = false;
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
                string maKHKK = txtMaKHKK.Text;
                DataTable tblThongTinKHKK, tblThongTinCTKHKK;

                tblThongTinKHKK = BCKKDAL.GetThongTinBCKK(maKHKK);
                tblThongTinCTKHKK = BCKKDAL.GetCTBCKK(maKHKK);

                // Tạo và hiển thị trong Excel
                // ExcelHelper.CreateBillThue(tblThongTinKHKK, tblThongTinKHKK);
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi: " + ex.Message);
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            string maNVDuyet = NhanVienDAL.GetMaNVByUsername(Username);
            string maKHKK = txtMaKHKK.Text.Trim();

            DateTime ngayDuyet = DateTime.Now;

            try
            {
                KHKKDAL.DuyetKHKK(maKHKK, maNVDuyet, ngayDuyet, true);

                Functions.HandleInfo("Duyệt báo cáo thanh lọc thành công");
                LoadData();
                ResetValues();

                btnAddFile.Enabled = false;
                btnOpenFile.Enabled = false;
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi duyệt báo cáo thanh lọc: " + ex.Message);
            }
        }

        private void btnKhongDuyet_Click(object sender, EventArgs e)
        {
            string maNVDuyet = NhanVienDAL.GetMaNVByUsername(Username);
            string maKHKK = txtMaKHKK.Text.Trim();

            try
            {
                KHKKDAL.KhongDuyetKHKK(maKHKK, maNVDuyet, false);

                Functions.HandleInfo("Không duyệt báo cáo thanh lọc thành công");
                LoadData();
                ResetValues();

                btnAddFile.Enabled = false;
                btnOpenFile.Enabled = false;
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi không duyệt báo cáo thanh lọc: " + ex.Message);
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Tệp Word|*.docx",
                Title = "Mở tệp Word"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtFile.Text = filePath;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = txtFile.Text.Trim();

                if (string.IsNullOrWhiteSpace(filePath))
                {
                    Functions.HandleWarning("Không có tệp nào được chỉ định.");
                    return;
                }

                if (!System.IO.File.Exists(filePath))
                {
                    Functions.HandleError("Tệp không tồn tại: " + filePath);
                    return;
                }

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi mở tệp: " + ex.Message);
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