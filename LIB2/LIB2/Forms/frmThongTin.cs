﻿using LIB2.Class;
using LIB2.Class.Types;
using LIB2.DAL;
using LIB2.Database;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmThongTin : MaterialForm
    {
        public UserRole currentRole;
        public string Username { get; set; }

        private DataTable tblInfo;

        public frmThongTin()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(Username))
            {
                LoadData();
            }

            cboPriv.Items.Add("Quản lý");
            cboPriv.Items.Add("Nhân viên");
        }

        public void LoadData()
        {
            try
            {
                tblInfo = NhanVienDAL.GetInfoNhanVienByUsername(Username);

                LoadInfo();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadInfo()
        {
            DataRow row = tblInfo.Rows[0];

            txtMaNV.Text = row["MaNV"].ToString();
            txtTenNV.Text = row["TenNV"].ToString();

            txtTenDangNhap.Text = row["TenDangNhap"].ToString();
            txtMatKhau.Text = row["MatKhau"].ToString();

            string quyenValue = row["Quyen"].ToString();

            if (quyenValue == "1")
            {
                cboPriv.SelectedItem = "Quản lý";
            }
            else if (quyenValue == "0")
            {
                cboPriv.SelectedItem = "Nhân viên";
            }

            string ngaySinhStr = row["NgaySinh"].ToString();
            DateTime ngaySinh;
            if (DateTime.TryParse(ngaySinhStr, out ngaySinh))
            {
                txtNgaySinh.Text = ngaySinh.ToString("dd/MM/yyyy");
            }
            else
            {
                txtNgaySinh.Text = "";
            }

            bool gioiTinh = (bool)row["GioiTinh"];
            if (gioiTinh)
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
            }

            txtEmail.Text = row["Email"].ToString();
            txtSDT.Text = row["SDT"].ToString();
            cboChucVu.Text = row["TenCV"].ToString();
            cboPhongBan.Text = row["TenPB"].ToString();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            swtEdit.Checked = false;

            string fillComboSqlCV = "SELECT * FROM ChucVu;";
            DatabaseLayer.FillCombo(fillComboSqlCV, cboChucVu, "MaCV", "TenCV");

            string fillComboSqlPB = "SELECT * FROM PhongBan;";
            DatabaseLayer.FillCombo(fillComboSqlPB, cboPhongBan, "MaPB", "TenPB");

            cboChucVu.SelectedItem = null;
            cboPhongBan.SelectedItem = null;

            DisableAllFields();
        }

        private void DisableAllFields()
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;

            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            cboPriv.Enabled = false;

            txtNgaySinh.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;

            txtEmail.Enabled = false;
            txtSDT.Enabled = false;

            cboChucVu.Enabled = false;
            cboPhongBan.Enabled = false;

            btnLuu.Enabled = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect forms to close in a separate list
                List<MaterialForm> formsToClose = new List<MaterialForm>();
                foreach (MaterialForm form in Application.OpenForms)
                {
                    if (form != this) // Exclude the current form for now
                    {
                        formsToClose.Add(form);
                    }
                }

                // Close all collected forms
                foreach (MaterialForm form in formsToClose)
                {
                    form.Close();
                }

                // Now close the main form
                this.Close();

                // Restart the application
                Application.Restart();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi khi đăng xuất: " + ex.Message);
            }
        }

        private void swtEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (swtEdit.Checked)
            {
                txtMatKhau.Enabled = true;
                txtEmail.Enabled = true;
                txtSDT.Enabled = true;

                btnLuu.Enabled = true;

                if (currentRole == UserRole.Admin)
                {
                    txtTenNV.Enabled = true;
                    cboPriv.Enabled = true;

                    txtNgaySinh.Enabled = true;
                    rdoNam.Enabled = true;
                    rdoNu.Enabled = true;

                    cboChucVu.Enabled = true;
                    cboPhongBan.Enabled = true;
                }
            }
            else
            {
                DisableAllFields();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                Functions.HandleWarning("Bạn phải nhập email");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                Functions.HandleWarning("Bạn phải nhập số điện thoại");
                txtSDT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mật khẩu");
                txtMatKhau.Focus();
                return false;
            }

            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string maNV = txtMaNV.Text.Trim();
                string tenNV = txtTenNV.Text.Trim();

                string tenDangNhap = txtTenDangNhap.Text.Trim();
                string matKhau = Functions.ComputeSha256Hash(txtMatKhau.Text.Trim());

                string privStr = cboPriv.SelectedItem.ToString();

                int priv = -1;

                if (privStr == "Quản lý")
                {
                    priv = 1;
                }
                else if (privStr == "Nhân viên")
                {
                    priv = 0;
                }

                DateTime ngaySinh;
                if (!DateTime.TryParse(txtNgaySinh.Text, out ngaySinh))
                {
                    Functions.HandleWarning("Ngày sinh không hợp lệ");
                    txtNgaySinh.Focus();
                    return;
                }

                bool gioiTinh = rdoNam.Checked;

                string email = txtEmail.Text.Trim();
                string SDT = txtSDT.Text.Trim().Replace(" ", "");

                string maCV = cboChucVu.SelectedValue.ToString();
                string maPB = cboPhongBan.SelectedValue.ToString();

                try
                {
                    NhanVienDAL.UpdateNhanVien(maNV, tenNV, ngaySinh, gioiTinh, email, SDT, maCV, maPB);
                    TaiKhoanDAL.UpdateTaiKhoan(tenDangNhap, matKhau, priv, maNV);
                    Functions.HandleInfo("Sửa thông tin thành công");
                    LoadData();

                    swtEdit.Checked = false;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi sửa thông tin: " + ex.Message);
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
