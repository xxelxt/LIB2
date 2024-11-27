using LIB2.Class;
using LIB2.DAL;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmRaVao : MaterialForm
    {
        public frmRaVao()
        {
            InitializeComponent();
        }

        private void frmRaVao_Load(object sender, EventArgs e)
        {
            lblThongBao.ForeColor = Color.Green;
            ResetThongTinBanDoc();

            getSoBanDocTrongTV();
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void getSoBanDocTrongTV()
        {
            lblTrongTV.Text = BanDocDAL.GetSoBanDocTrongTV().ToString();
        }

        private void btnVaoTV_Click(object sender, EventArgs e)
        {
            string maBD = txtMaBD.Text.Trim();

            try
            {
                BanDocDAL.CheckInOutBanDoc(maBD, true);
                lblThongBao.Text = "Bạn đọc vào thư viện thành công";

                getSoBanDocTrongTV();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi cho bạn đọc vào thư viện: " + ex.Message);
            }
        }

        private void btnRaTV_Click(object sender, EventArgs e)
        {
            string maBD = txtMaBD.Text.Trim();

            try
            {
                BanDocDAL.CheckInOutBanDoc(maBD, false);
                lblThongBao.Text = "Bạn đọc ra thư viện thành công";

                getSoBanDocTrongTV();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi cho bạn đọc ra khỏi thư viện: " + ex.Message);
            }
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

                        bool ttRaVao = Convert.ToBoolean(dt.Rows[0]["TTRaVao"]);
                        if (ttRaVao)
                        {
                            lblTrangThai.Text = "Đang ở trong thư viện";
                            btnRaTV.Enabled = true;
                            btnVaoTV.Enabled = false;
                        }
                        else
                        {
                            lblTrangThai.Text = "Không ở trong thư viện";
                            btnRaTV.Enabled = false;
                            btnVaoTV.Enabled = true;
                        }
                    }
                    else
                    {
                        ResetThongTinBanDoc();
                        btnRaTV.Enabled = false;
                        btnVaoTV.Enabled = false;
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
                btnRaTV.Enabled = false;
                btnVaoTV.Enabled = false;
            }
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
            lblTrangThai.Text = "";
            lblThongBao.Text = "";
        }
    }
}
