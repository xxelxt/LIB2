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
    public partial class frmPhat : MaterialForm
    {
        private DataTable tblPhat;

        private bool isSearching = false;
        private string currentSearchOption = "";
        private string currentSearchKeyword = "";

        public frmPhat()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();

            cboTimKiem.Items.Add("Mã phạt");
            cboTimKiem.Items.Add("Mã bạn đọc");
            cboTimKiem.Items.Add("Vi phạm");
            cboTimKiem.Items.Add("Đã thực hiện phạt");
            cboTimKiem.Items.Add("Chưa thực hiện phạt");
        }

        private void InitializeListView()
        {
            listViewPhat.FullRowSelect = true;
            listViewPhat.MultiSelect = false;
            listViewPhat.UseCompatibleStateImageBehavior = false;
            listViewPhat.View = View.Details;

            listViewPhat.Columns.Add("MaPhat", "Mã phat");
            listViewPhat.Columns.Add("MaBD", "Mã bạn đọc");
            listViewPhat.Columns.Add("TenBD", "Tên bạn đọc");
            listViewPhat.Columns.Add("TenVP", "Tên vi phạm");
            listViewPhat.Columns.Add("TGGhiNhan", "Thời gian ghi nhận");
            listViewPhat.Columns.Add("SoTienPhat", "Số tiền phạt");
            listViewPhat.Columns.Add("TTHT", "Trạng thái thực hiện");
        }

        private void frmPhat_Load(object sender, EventArgs e)
        {
            DisabledAllFields();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnHuy.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void DisabledAllFields()
        {
            txtMaPhat.Enabled = false;

            txtMaBD.Enabled = false;
            txtTenBD.Enabled = false;

            txtViPham.Enabled = false;
            txtThoiGian.Enabled = false;

            txtSoTienPhat.Enabled = false;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewPhat.ClientSize.Width;
            double col1Percentage = 0.1;
            double col2Percentage = 0.1;
            double col3Percentage = 0.2;
            double col4Percentage = 0.2;
            double col5Percentage = 0.15;
            double col6Percentage = 0.1;
            double col7Percentage = 0.2;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);
            int col5Width = (int)(totalWidth * col5Percentage);
            int col6Width = (int)(totalWidth * col6Percentage);
            int col7Width = (int)(totalWidth * col7Percentage);

            listViewPhat.Columns[0].Width = col1Width;
            listViewPhat.Columns[1].Width = col2Width;
            listViewPhat.Columns[2].Width = col3Width;
            listViewPhat.Columns[3].Width = col4Width;
            listViewPhat.Columns[4].Width = col5Width;
            listViewPhat.Columns[5].Width = col6Width;
            listViewPhat.Columns[6].Width = col7Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblPhat = PhatDAL.GetPhatBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblPhat = PhatDAL.GetAllPhat();

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

            foreach (DataRow row in tblPhat.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaPhat"].ToString());
                item.SubItems.Add(row["MaBD"].ToString());
                item.SubItems.Add(row["TenBD"].ToString());
                item.SubItems.Add(row["TenVP"].ToString());

                DateTime TGGhiNhan;
                if (DateTime.TryParse(row["TGGhiNhan"].ToString(), out TGGhiNhan))
                {
                    string TGGhiNhanFormatted = TGGhiNhan.ToString("dd/MM/yyyy");

                    item.SubItems.Add(TGGhiNhanFormatted);
                }
                else
                {
                    item.SubItems.Add("");
                }

                item.SubItems.Add(row["SoTienPhat"].ToString());
                
                string TTHT = "";
                if (row["TTHT"] != null && row["TTHT"] != DBNull.Value)
                {
                    bool TTHTValue = Convert.ToBoolean(row["TTHT"]);
                    TTHT = TTHTValue ? "Đã thực hiện" : "Chưa thực hiện";
                }
                else
                {
                    TTHT = "";
                }

                item.SubItems.Add(TTHT);


                listViewPhat.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewPhat.Items.Clear();
        }

        private void listViewPhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblPhat.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewPhat.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewPhat.SelectedItems[0];
                txtMaPhat.Text = selectedItem.SubItems[0].Text;
                txtMaBD.Text = selectedItem.SubItems[1].Text;
                txtTenBD.Text = selectedItem.SubItems[2].Text;
                txtViPham.Text = selectedItem.SubItems[3].Text;

                string TGGhiNhanStr = selectedItem.SubItems[4].Text;
                DateTime TGGhiNhan;
                if (DateTime.TryParse(TGGhiNhanStr, out TGGhiNhan))
                {
                    txtThoiGian.Text = TGGhiNhan.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtThoiGian.Text = "";
                }

                txtSoTienPhat.Text = selectedItem.SubItems[5].Text;

                if (selectedItem.SubItems[6].Text == "Đã thực hiện")
                {
                    rdoTTDaTH.Checked = true;
                    rdoTTChuaTH.Checked = false;
                }
                else if (selectedItem.SubItems[6].Text == "Chưa thực hiện")
                {
                    rdoTTDaTH.Checked = false;
                    rdoTTChuaTH.Checked = true;
                }

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
            txtMaPhat.Text = "";
            txtMaBD.Text = "";
            txtTenBD.Text = "";
            txtViPham.Text = "";

            rdoTTDaTH.Checked = false;
            rdoTTChuaTH.Checked = false;

            txtThoiGian.Text = "";
            txtSoTienPhat.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewPhat.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }

            string maPhat = txtMaPhat.Text.Trim();
            bool TTHT = rdoTTDaTH.Checked;

            try
            {
                PhatDAL.UpdateTTHTPhat(maPhat, TTHT);
                Functions.HandleInfo("Cập nhật phạt thành công");
                LoadData();
                ResetValues();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi cập nhật phạt: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhat = txtMaPhat.Text.Trim();

            if (!string.IsNullOrEmpty(maPhat))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        PhatDAL.DeletePhat(maPhat);
                        Functions.HandleInfo("Xóa phạt thành công");
                        LoadData();
                        ResetValues();

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa phạt: " + ex.Message);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

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

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "Đã thực hiện phạt" || cboTimKiem.Text == "Chưa thực hiện phạt")
            {
                txtTimKiem.Enabled = false;
                txtTimKiem.Text = "";
            }
            else
            {
                txtTimKiem.Enabled = true;
            }
        }
    }
}
