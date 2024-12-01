using LIB2.Class;
using LIB2.DAL;
using LIB2.Database;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using System.IO;

using MailKit.Net.Smtp;
using MimeKit;

namespace LIB2.Forms
{
    public partial class frmPYCBSEmail : MaterialForm
    {
        public string maPYCBS { get; set; }
        
        public frmPYCBSEmail()
        {
            InitializeComponent();

            string fillComboNXB = "SELECT * FROM NhaXuatBan";
            DatabaseLayer.FillCombo(fillComboNXB, cboNXB, "MaNXB", "TenNXB");
            cboNXB.SelectedItem = null;

            string fillComboNCC = "SELECT * FROM NhaCungCap";
            DatabaseLayer.FillCombo(fillComboNCC, cboNCC, "MaNCC", "TenNCC");
            cboNCC.SelectedItem = null;

            cboNXB.Enabled = false;
            cboNCC.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void frmPYCBSEmail_Load(object sender, EventArgs e)
        {
            txtMaPYCBS.Text = this.maPYCBS;
            txtMaPYCBS.Enabled = false;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return System.Text.RegularExpressions.Regex.IsMatch(email, emailRegex);
            }
            catch
            {
                return false;
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string email = "";

            // Xác định email dựa trên lựa chọn
            if (rdoNCC.Checked == true)
            {
                email = NhaCungCapDAL.GetEmailByMaNCC(cboNCC.SelectedValue.ToString());
            }
            else if (rdoNXB.Checked == true)
            {
                email = NhaXuatBanDAL.GetEmailByMaNXB(cboNXB.SelectedValue.ToString());
            }
            else
            {
                email = txtEmail.Text.Trim();
            }

            if (IsValidEmail(email))
            {
                try
                {
                    string maPYCBS = txtMaPYCBS.Text.Trim();
                    DataTable tblThongTinPYCBS = PYCBSDAL.GetThongTinPYCBS(maPYCBS);
                    DataTable tblThongTinCTPYCBS = PYCBSDAL.GetCTPYCBS(maPYCBS);

                    if (tblThongTinPYCBS.Rows.Count > 0)
                    {
                        // Xuất PDF
                        string dateTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                        string outputPath = @"E:\" + maPYCBS + "_" + dateTime + ".pdf";
                        ExportToPDF.exportPYCBS(tblThongTinPYCBS, tblThongTinCTPYCBS, outputPath, true);

                        string noiDung = txtNoiDung.Text.Trim();

                        // Gửi email với tệp đính kèm
                        SendEmailWithAttachment(email, "Phiếu yêu cầu bổ sung tài liệu", noiDung, outputPath);

                        // Thông báo
                        Functions.HandleInfo("Gửi email thành công!");
                    }
                    else
                    {
                        Functions.HandleInfo("Không tìm thấy phiếu nhập kho nào.");
                    }
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi: " + ex.Message);
                }
            }
            else
            {
                Functions.HandleError("Email không hợp lệ.");
            }
        }

        private void SendEmailWithAttachment(string toEmail, string subject, string body, string attachmentPath)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Thư viện HVNH", "thuvienhvnh.demo@gmail.com"));
            message.To.Add(new MailboxAddress("", toEmail));
            message.Subject = subject;

            var builder = new BodyBuilder { TextBody = body };

            // Đính kèm file
            if (!string.IsNullOrEmpty(attachmentPath) && File.Exists(attachmentPath))
            {
                builder.Attachments.Add(attachmentPath);
            }

            message.Body = builder.ToMessageBody();

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                client.Authenticate("thuvienhvnh.demo@gmail.com", "q1p0w2o9"); // Mật khẩu ứng dụng
                client.Send(message);
                client.Disconnect(true);
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = "";
            txtEmail.Text = "";

            rdoNCC.Checked = false;
            rdoNXB.Checked = false;
            rdoKhac.Checked = false;

            cboNXB.SelectedItem = null;
            cboNCC.SelectedItem = null;
        }

        private void rdoNCC_CheckedChanged(object sender, EventArgs e)
        {
            cboNCC.Enabled = true;
            cboNXB.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void rdoNXB_CheckedChanged(object sender, EventArgs e)
        {
            cboNCC.Enabled = false;
            cboNXB.Enabled = true;
            txtEmail.Enabled = false;
        }

        private void rdoKhac_CheckedChanged(object sender, EventArgs e)
        {
            cboNCC.Enabled = false;
            cboNXB.Enabled = false;
            txtEmail.Enabled = true;
        }
    }
}
