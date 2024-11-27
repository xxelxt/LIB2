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
    public partial class frmMuonTraList : MaterialForm
    {
        private DataTable tblMuonTra;

        private bool isSearching = false;
        private string currentSearchKeyword = "";
        private string currentSearchOption = "";

        public frmMuonTraList()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();

            cboTimKiem.Items.Add("Mã mượn trả");
            cboTimKiem.Items.Add("Mã bạn đọc");
            cboTimKiem.Items.Add("Ngày mượn");
            cboTimKiem.Items.Add("Ngày trả");
        }

        private void InitializeListView()
        {
            listViewMTList.FullRowSelect = true;
            listViewMTList.MultiSelect = false;
            listViewMTList.UseCompatibleStateImageBehavior = false;
            listViewMTList.View = View.Details;

            listViewMTList.Columns.Add("MaMuonTra", "Mã mượn trả");
            listViewMTList.Columns.Add("MaBD", "Mã bạn đọc");
            listViewMTList.Columns.Add("TenBD", "Tên bạn đọc");
            listViewMTList.Columns.Add("TGMuon", "Thời gian mượn");
            listViewMTList.Columns.Add("TGTra", "Thời gian trả");
        }

        private void frmMuonTraList_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnHuy.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewMTList.ClientSize.Width;
            double col1Percentage = 0.2;
            double col2Percentage = 0.2;
            double col3Percentage = 0.2;
            double col4Percentage = 0.2;
            double col5Percentage = 0.2;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);
            int col5Width = (int)(totalWidth * col5Percentage);

            listViewMTList.Columns[0].Width = col1Width;
            listViewMTList.Columns[1].Width = col2Width;
            listViewMTList.Columns[2].Width = col3Width;
            listViewMTList.Columns[3].Width = col4Width;
            listViewMTList.Columns[4].Width = col5Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblMuonTra = MuonTraDAL.GetMuonTraBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblMuonTra = MuonTraDAL.GetAllMuonTra();

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

            foreach (DataRow row in tblMuonTra.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaMuonTra"].ToString());
                item.SubItems.Add(row["MaBD"].ToString());
                item.SubItems.Add(row["TenBD"].ToString());

                DateTime TGMuon;
                if (DateTime.TryParse(row["TGMuon"].ToString(), out TGMuon))
                {
                    string TGMuonFormatted = TGMuon.ToString("dd/MM/yyyy");

                    item.SubItems.Add(TGMuonFormatted);
                }
                else
                {
                    item.SubItems.Add("");
                }

                DateTime TGTra;
                if (DateTime.TryParse(row["TGTra"].ToString(), out TGTra))
                {
                    string TGTraFormatted = TGTra.ToString("dd/MM/yyyy");

                    item.SubItems.Add(TGTraFormatted);
                }
                else
                {
                    item.SubItems.Add("");
                }

                listViewMTList.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewMTList.Items.Clear();
        }

        private void listViewMTList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblMuonTra.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewMTList.SelectedItems.Count > 0)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewMTList.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }

            ListViewItem selectedItem = listViewMTList.SelectedItems[0];
            string maMT = selectedItem.SubItems[0].Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewMTList.SelectedItems[0];
            string maMT = selectedItem.SubItems[0].Text;

            if (!string.IsNullOrEmpty(maMT))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        MuonTraDAL.DeleteCTMuonTra(maMT);
                        MuonTraDAL.DeleteMuonTra(maMT);
                        Functions.HandleInfo("Xóa mượn trả thành công");
                        LoadData();

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

        private void btnHuy_Click(object sender, EventArgs e)
        {
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
    }
}
