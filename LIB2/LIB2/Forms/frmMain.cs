﻿using LIB2.Class.Types;
using LIB2.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2
{
    public partial class frmMain : MaterialForm
    {
        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public UserRole currentRole { get; set; }
        public string Username { get; set; }
        
        private frmHome childFormHome;

        private frmTaiLieu childFormTaiLieu;
        private frmMuonTra childFormMT;
        private frmDatPhong childFormDP;
        private frmPhat childFormPhat;
        private frmBanDoc childFormBD;

        private frmNhanVien childFormNV;

        private frmKho childFormKho;
        private frmNhaXuatBan childFormNXB;
        private frmNhaCungCap childFormNCC;

        private frmNhap childFormNhap;
        private FrmKiemKe childFormKiemKe;
        private FrmThanhLoc childFormThanhLoc;

        private frmBaoCao childFormBC;

        private frmTTTaiLieuKhac childFormTTTLK;
        private FrmKhac childFormTTK;
        private frmRaVao childFormRaVao;
        private frmThongTin childFormTT;

        public frmMain()
        {
            InitializeComponent();
            ConfigureMaterialSkin();
            UpdateFormTitle(materialTabControl.SelectedTab);
        }

        public void ConfigureMaterialSkin()
        {
            Color primaryColor = Color.FromArgb(255, 255, 255);       // White
            Color darkPrimaryColor = Color.FromArgb(240, 240, 240);   // Light Gray
            Color lightPrimaryColor = Color.FromArgb(255, 255, 255);  // White
            Color accentColor = Color.FromArgb(255, 150, 79);         // Orange

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            var colorScheme = new ColorScheme(
                primaryColor,
                darkPrimaryColor,
                lightPrimaryColor,
                accentColor,
                TextShade.BLACK
            );

            materialSkinManager.ColorScheme = colorScheme;
            materialSkinManager.AddFormToManage(this);
        }

        private void initForm(MaterialForm form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            materialSkinManager.AddFormToManage(form);
        }

        private void initAllForm()
        {
            initFormHome();

            initFormTaiLieu();
            initFormMT();
            initFormDP();
            initFormPhat();
            initFormBD();

            initFormNV();

            initFormKho();
            initFormNXB();
            initFormNCC();

            initFormNhap();
            initFormKiemKe();
            initFormThanhLoc();

            initFormTTKTL();
            initFormTTK();
            initFormRaVao();
            initFormThongTin();
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFormTitle(materialTabControl.SelectedTab);
        }

        private void UpdateFormTitle(TabPage selectedTab)
        {
            if (selectedTab != null)
            {
                this.Text = $"{selectedTab.Text}";
            }
        }

        private void initFormHome()
        {
            childFormHome = new frmHome();
            initForm(childFormHome);
            tabPageHome.Controls.Add(childFormHome);
            childFormHome.Show();

            //childFormHome.DirectToThueClicked += FrmHome_DirectToThueClicked;
            //childFormHome.DirectToTraClicked += FrmHome_DirectToTraClicked;
            //childFormHome.DirectToBaoCaoClicked += FrmHome_DirectToBaoCaoClicked;
        }

        private void initFormTaiLieu()
        {
            childFormTaiLieu = new frmTaiLieu();
            initForm(childFormTaiLieu);
            tabPageTL.Controls.Add(childFormTaiLieu);
            childFormTaiLieu.Show();
        }

        private void initFormMT()
        {
            childFormMT = new frmMuonTra();
            initForm(childFormMT);
            tabPageMT.Controls.Add(childFormMT);
            childFormMT.Show();
        }

        private void initFormDP()
        {
            childFormDP = new frmDatPhong();
            initForm(childFormDP);
            tabPageDP.Controls.Add(childFormDP);
            childFormDP.Show();
        }

        private void initFormPhat()
        {
            childFormPhat = new frmPhat();
            initForm(childFormPhat);
            tabPagePhat.Controls.Add(childFormPhat);
            childFormPhat.Show();
        }

        private void initFormBD()
        {
            childFormBD = new frmBanDoc();
            initForm(childFormBD);
            tabPageBD.Controls.Add(childFormBD);
            childFormBD.Show();
        }

        private void initFormNV()
        {
            childFormNV = new frmNhanVien();
            initForm(childFormNV);
            tabPageNV.Controls.Add(childFormNV);
            childFormNV.Show();
        }

        private void initFormKho()
        {
            childFormKho = new frmKho();
            initForm(childFormKho);
            tabPageKho.Controls.Add(childFormKho);
            childFormKho.Show();
        }

        private void initFormNXB()
        {
            childFormNXB = new frmNhaXuatBan();
            initForm(childFormNXB);
            tabPageNXB.Controls.Add(childFormNXB);
            childFormNXB.Show();
        }

        private void initFormNCC()
        {
            childFormNCC = new frmNhaCungCap();
            initForm(childFormNCC);
            tabPageNCC.Controls.Add(childFormNCC);
            childFormNCC.Show();
        }

        private void initFormNhap()
        {
            childFormNhap = new frmNhap();
            initForm(childFormNhap);
            tabPageNhap.Controls.Add(childFormNhap);
            childFormNhap.Show();
        }

        private void initFormKiemKe()
        {
            childFormKiemKe = new FrmKiemKe();
            initForm(childFormKiemKe);
            tabPageKiemKe.Controls.Add(childFormKiemKe);
            childFormKiemKe.Show();
        }

        private void initFormThanhLoc()
        {
            childFormThanhLoc = new FrmThanhLoc();
            initForm(childFormThanhLoc);
            tabPageThanhLoc.Controls.Add(childFormThanhLoc);
            childFormThanhLoc.Show();
        }

        private void initFormBC()
        {
            childFormBC = new frmBaoCao();
            initForm(childFormBC);
            tabPageBC.Controls.Add(childFormBC);
            childFormBC.Show();
        }

        private void initFormTTKTL()
        {
            childFormTTTLK = new frmTTTaiLieuKhac();
            initForm(childFormTTTLK);
            tabPageTTTaiLieuKhac.Controls.Add(childFormTTTLK);
            childFormTTTLK.Show();
        }

        private void initFormTTK()
        {
            childFormTTK = new FrmKhac();
            initForm(childFormTTK);
            tabPageTTK.Controls.Add(childFormTTK);
            childFormTTK.Show();
        }

        private void initFormRaVao()
        {
            childFormRaVao = new frmRaVao();
            initForm(childFormRaVao);
            tabPageRaVao.Controls.Add(childFormRaVao);
            childFormRaVao.Show();
        }

        private void initFormThongTin()
        {
            childFormTT = new frmThongTin();
            childFormTT.Username = this.Username;
            childFormTT.currentRole = this.currentRole;
            initForm(childFormTT);
            tabPageTT.Controls.Add(childFormTT);
            childFormTT.Show();
        }

        private void atEnd_frmMain_Shown(object sender, EventArgs e)
        {
            initAllForm();
            UpdateChildForms();
            UpdateTabVisibility(); // Update tab visibility when the form is shown
        }

        private void UpdateChildForms()
        {
            childFormTT.Username = this.Username;
            childFormTT.currentRole = this.currentRole;

            // Reload data for child forms that depend on Username
            childFormTT.LoadData();
        }

        private void frmMain_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                initAllForm();
                UpdateChildForms();
                UpdateTabVisibility();
            }
        }

        private void UpdateTabVisibility()
        {
            childFormHome.SetDoanhThuCardVisible(this.currentRole == UserRole.Admin);

            if (this.currentRole == UserRole.User)
            {
                HideUserTabs();
            }
            else if (this.currentRole == UserRole.Admin)
            {
                ShowAllTabs();
            }
        }

        private void HideUserTabs()
        {
            if (Drawer != null && Drawer.BaseTabControl != null)
            {
                // Danh sách tab sẽ ẩn với vai trò nhân viên
            }
        }

        private void ShowAllTabs()
        {
            if (Drawer != null && Drawer.BaseTabControl != null)
            {
                // Ngược với danh sách trên
            }
        }

        private void FrmHome_DirectToThueClicked(object sender, EventArgs e)
        {
             // materialTabControl.SelectedTab = tabPageThue;
        }

        private void FrmHome_DirectToTraClicked(object sender, EventArgs e)
        {
            // materialTabControl.SelectedTab = tabPageTra;
        }

        private void FrmHome_DirectToBaoCaoClicked(object sender, EventArgs e)
        {
            // materialTabControl.SelectedTab = tabPageBC;
        }
    }
};