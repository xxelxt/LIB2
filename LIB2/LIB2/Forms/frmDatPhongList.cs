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
    public partial class frmDatPhongList : MaterialForm
    {
        private DataTable tblDatPhong;

        private bool isSearching = false;
        private string currentSearchKeyword = "";
        private string currentSearchOption = "";

        public frmDatPhongList()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();

            cboTimKiem.Items.Add("Mã đặt phòng");
            cboTimKiem.Items.Add("Phòng");
            cboTimKiem.Items.Add("Thời gian đặt");
        }

        private void InitializeListView()
        {
            listViewDPList.FullRowSelect = true;
            listViewDPList.MultiSelect = false;
            listViewDPList.UseCompatibleStateImageBehavior = false;
            listViewDPList.View = View.Details;

            listViewDPList.Columns.Add("MaDP", "Mã đặt phòng");
            listViewDPList.Columns.Add("TGDat", "Thời gian đặt");
            listViewDPList.Columns.Add("Phong", "Phòng");
            listViewDPList.Columns.Add("CaSuDung", "Ca sử dụng");
            listViewDPList.Columns.Add("TTSuDung", "Trạng thái sử dụng");
        }

        private void frmDatPhongList_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnHuy.Enabled = false;

            txtTimKiem.Text = "Nhập từ khóa tìm kiếm";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewDPList.ClientSize.Width;
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

            listViewDPList.Columns[0].Width = col1Width;
            listViewDPList.Columns[1].Width = col2Width;
            listViewDPList.Columns[2].Width = col3Width;
            listViewDPList.Columns[3].Width = col4Width;
            listViewDPList.Columns[4].Width = col5Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblDatPhong = DatPhongDAL.GetDatPhongBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblDatPhong = DatPhongDAL.GetAllDatPhong();

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

            foreach (DataRow row in tblDatPhong.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaDP"].ToString());

                DateTime TGDat;
                if (DateTime.TryParse(row["TGDat"].ToString(), out TGDat))
                {
                    string TGDatFormatted = TGDat.ToString("dd/MM/yyyy");

                    item.SubItems.Add(TGDatFormatted);
                }
                else
                {
                    item.SubItems.Add("");
                }

                item.SubItems.Add(row["Phong"].ToString());
                item.SubItems.Add(row["CaSuDung"].ToString());

                string ttSuDung = "";
                if (row["TTSuDung"] != null && row["TTSuDung"] != DBNull.Value)
                {
                    bool ttSuDungValue = Convert.ToBoolean(row["TTSuDung"]);
                    ttSuDung = ttSuDungValue ? "Có sử dụng" : "Không sử dụng";
                }
                else
                {
                    ttSuDung = "";
                }

                item.SubItems.Add(ttSuDung);

                listViewDPList.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewDPList.Items.Clear();
        }

        private void listViewDPList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tblDatPhong.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewDPList.SelectedItems.Count > 0)
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
            if (listViewDPList.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }

            ListViewItem selectedItem = listViewDPList.SelectedItems[0];
            string maDP = selectedItem.SubItems[0].Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewDPList.SelectedItems[0];
            string maDP = selectedItem.SubItems[0].Text;

            if (!string.IsNullOrEmpty(maDP))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        DatPhongDAL.DeleteCTDatPhong(maDP);
                        DatPhongDAL.DeleteDatPhong(maDP);
                        Functions.HandleInfo("Xóa đặt phòng thành công");
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

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "Có sử dụng" || cboTimKiem.Text == "Không sử dụng")
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
