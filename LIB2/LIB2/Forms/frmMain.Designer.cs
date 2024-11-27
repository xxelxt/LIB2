namespace LIB2
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageTL = new System.Windows.Forms.TabPage();
            this.tabPageMT = new System.Windows.Forms.TabPage();
            this.tabPageDP = new System.Windows.Forms.TabPage();
            this.tabPagePhat = new System.Windows.Forms.TabPage();
            this.tabPageRaVao = new System.Windows.Forms.TabPage();
            this.tabPageBD = new System.Windows.Forms.TabPage();
            this.tabPageNV = new System.Windows.Forms.TabPage();
            this.tabPageKho = new System.Windows.Forms.TabPage();
            this.tabPageNCC = new System.Windows.Forms.TabPage();
            this.tabPageNXB = new System.Windows.Forms.TabPage();
            this.tabPageNhap = new System.Windows.Forms.TabPage();
            this.tabPageKiemKe = new System.Windows.Forms.TabPage();
            this.tabPageThanhLoc = new System.Windows.Forms.TabPage();
            this.tabPageBC = new System.Windows.Forms.TabPage();
            this.tabPageTTTaiLieuKhac = new System.Windows.Forms.TabPage();
            this.tabPageTTK = new System.Windows.Forms.TabPage();
            this.tabPageTT = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.tabPageHome);
            this.materialTabControl.Controls.Add(this.tabPageTL);
            this.materialTabControl.Controls.Add(this.tabPageMT);
            this.materialTabControl.Controls.Add(this.tabPageDP);
            this.materialTabControl.Controls.Add(this.tabPagePhat);
            this.materialTabControl.Controls.Add(this.tabPageRaVao);
            this.materialTabControl.Controls.Add(this.tabPageBD);
            this.materialTabControl.Controls.Add(this.tabPageNV);
            this.materialTabControl.Controls.Add(this.tabPageKho);
            this.materialTabControl.Controls.Add(this.tabPageNCC);
            this.materialTabControl.Controls.Add(this.tabPageNXB);
            this.materialTabControl.Controls.Add(this.tabPageNhap);
            this.materialTabControl.Controls.Add(this.tabPageKiemKe);
            this.materialTabControl.Controls.Add(this.tabPageThanhLoc);
            this.materialTabControl.Controls.Add(this.tabPageBC);
            this.materialTabControl.Controls.Add(this.tabPageTTTaiLieuKhac);
            this.materialTabControl.Controls.Add(this.tabPageTTK);
            this.materialTabControl.Controls.Add(this.tabPageTT);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl.ImageList = this.imageList1;
            this.materialTabControl.Location = new System.Drawing.Point(0, 80);
            this.materialTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(1228, 955);
            this.materialTabControl.TabIndex = 0;
            this.materialTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // tabPageHome
            // 
            this.tabPageHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageHome.ImageKey = "tabPageHomeIcon.png";
            this.tabPageHome.Location = new System.Drawing.Point(4, 58);
            this.tabPageHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Size = new System.Drawing.Size(1220, 893);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Trang chủ";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageTL
            // 
            this.tabPageTL.BackColor = System.Drawing.Color.Transparent;
            this.tabPageTL.ImageKey = "tabPageTLIcon.png";
            this.tabPageTL.Location = new System.Drawing.Point(4, 31);
            this.tabPageTL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageTL.Name = "tabPageTL";
            this.tabPageTL.Size = new System.Drawing.Size(1220, 920);
            this.tabPageTL.TabIndex = 1;
            this.tabPageTL.Text = "Tài liệu";
            // 
            // tabPageMT
            // 
            this.tabPageMT.ImageKey = "tabPageMTIcon.png";
            this.tabPageMT.Location = new System.Drawing.Point(4, 31);
            this.tabPageMT.Name = "tabPageMT";
            this.tabPageMT.Size = new System.Drawing.Size(1220, 920);
            this.tabPageMT.TabIndex = 4;
            this.tabPageMT.Text = "Mượn/trả";
            this.tabPageMT.UseVisualStyleBackColor = true;
            // 
            // tabPageDP
            // 
            this.tabPageDP.ImageKey = "tabPageDPIcon.png";
            this.tabPageDP.Location = new System.Drawing.Point(4, 31);
            this.tabPageDP.Name = "tabPageDP";
            this.tabPageDP.Size = new System.Drawing.Size(1220, 920);
            this.tabPageDP.TabIndex = 5;
            this.tabPageDP.Text = "Đặt phòng";
            this.tabPageDP.UseVisualStyleBackColor = true;
            // 
            // tabPagePhat
            // 
            this.tabPagePhat.ImageKey = "tabPagePhatIcon.png";
            this.tabPagePhat.Location = new System.Drawing.Point(4, 31);
            this.tabPagePhat.Name = "tabPagePhat";
            this.tabPagePhat.Size = new System.Drawing.Size(1220, 920);
            this.tabPagePhat.TabIndex = 6;
            this.tabPagePhat.Text = "Tra cứu phạt";
            this.tabPagePhat.UseVisualStyleBackColor = true;
            // 
            // tabPageRaVao
            // 
            this.tabPageRaVao.ImageKey = "tabPageRaVaoIcon.png";
            this.tabPageRaVao.Location = new System.Drawing.Point(4, 31);
            this.tabPageRaVao.Name = "tabPageRaVao";
            this.tabPageRaVao.Size = new System.Drawing.Size(1220, 920);
            this.tabPageRaVao.TabIndex = 21;
            this.tabPageRaVao.Text = "Ra vào thư viện";
            this.tabPageRaVao.UseVisualStyleBackColor = true;
            // 
            // tabPageBD
            // 
            this.tabPageBD.ImageKey = "tabPageBDIcon.png";
            this.tabPageBD.Location = new System.Drawing.Point(4, 31);
            this.tabPageBD.Name = "tabPageBD";
            this.tabPageBD.Size = new System.Drawing.Size(1220, 920);
            this.tabPageBD.TabIndex = 7;
            this.tabPageBD.Text = "Bạn đọc";
            this.tabPageBD.UseVisualStyleBackColor = true;
            // 
            // tabPageNV
            // 
            this.tabPageNV.ImageKey = "tabPageNVIcon.png";
            this.tabPageNV.Location = new System.Drawing.Point(4, 31);
            this.tabPageNV.Name = "tabPageNV";
            this.tabPageNV.Size = new System.Drawing.Size(1220, 920);
            this.tabPageNV.TabIndex = 8;
            this.tabPageNV.Text = "Nhân viên";
            this.tabPageNV.UseVisualStyleBackColor = true;
            // 
            // tabPageKho
            // 
            this.tabPageKho.ImageKey = "tabPageKhoIcon.png";
            this.tabPageKho.Location = new System.Drawing.Point(4, 31);
            this.tabPageKho.Name = "tabPageKho";
            this.tabPageKho.Size = new System.Drawing.Size(1220, 920);
            this.tabPageKho.TabIndex = 12;
            this.tabPageKho.Text = "Kho";
            this.tabPageKho.UseVisualStyleBackColor = true;
            // 
            // tabPageNCC
            // 
            this.tabPageNCC.ImageKey = "tabPageNCCIcon.png";
            this.tabPageNCC.Location = new System.Drawing.Point(4, 31);
            this.tabPageNCC.Name = "tabPageNCC";
            this.tabPageNCC.Size = new System.Drawing.Size(1220, 920);
            this.tabPageNCC.TabIndex = 13;
            this.tabPageNCC.Text = "Nhà cung cấp";
            this.tabPageNCC.UseVisualStyleBackColor = true;
            // 
            // tabPageNXB
            // 
            this.tabPageNXB.ImageKey = "tabPageNXBIcon.png";
            this.tabPageNXB.Location = new System.Drawing.Point(4, 31);
            this.tabPageNXB.Name = "tabPageNXB";
            this.tabPageNXB.Size = new System.Drawing.Size(1220, 920);
            this.tabPageNXB.TabIndex = 14;
            this.tabPageNXB.Text = "Nhà xuất bản";
            this.tabPageNXB.UseVisualStyleBackColor = true;
            // 
            // tabPageNhap
            // 
            this.tabPageNhap.ImageKey = "tabPageNhapIcon.png";
            this.tabPageNhap.Location = new System.Drawing.Point(4, 58);
            this.tabPageNhap.Name = "tabPageNhap";
            this.tabPageNhap.Size = new System.Drawing.Size(1220, 893);
            this.tabPageNhap.TabIndex = 16;
            this.tabPageNhap.Text = "Biểu mẫu nhập tài liệu";
            this.tabPageNhap.UseVisualStyleBackColor = true;
            // 
            // tabPageKiemKe
            // 
            this.tabPageKiemKe.ImageKey = "tabPageKiemKeIcon.png";
            this.tabPageKiemKe.Location = new System.Drawing.Point(4, 58);
            this.tabPageKiemKe.Name = "tabPageKiemKe";
            this.tabPageKiemKe.Size = new System.Drawing.Size(1220, 893);
            this.tabPageKiemKe.TabIndex = 17;
            this.tabPageKiemKe.Text = "Biểu mẫu kiểm kê tài liệu";
            this.tabPageKiemKe.UseVisualStyleBackColor = true;
            // 
            // tabPageThanhLoc
            // 
            this.tabPageThanhLoc.ImageKey = "tabPageThanhLocIcon.png";
            this.tabPageThanhLoc.Location = new System.Drawing.Point(4, 58);
            this.tabPageThanhLoc.Name = "tabPageThanhLoc";
            this.tabPageThanhLoc.Size = new System.Drawing.Size(1220, 893);
            this.tabPageThanhLoc.TabIndex = 18;
            this.tabPageThanhLoc.Text = "Biểu mẫu thanh lọc tài liệu";
            this.tabPageThanhLoc.UseVisualStyleBackColor = true;
            // 
            // tabPageBC
            // 
            this.tabPageBC.ImageKey = "tabPageBCIcon.png";
            this.tabPageBC.Location = new System.Drawing.Point(4, 58);
            this.tabPageBC.Name = "tabPageBC";
            this.tabPageBC.Size = new System.Drawing.Size(1220, 893);
            this.tabPageBC.TabIndex = 19;
            this.tabPageBC.Text = "Báo cáo";
            this.tabPageBC.UseVisualStyleBackColor = true;
            // 
            // tabPageTTTaiLieuKhac
            // 
            this.tabPageTTTaiLieuKhac.ImageKey = "tabPageTTTaiLieuKhacIcon.png";
            this.tabPageTTTaiLieuKhac.Location = new System.Drawing.Point(4, 58);
            this.tabPageTTTaiLieuKhac.Name = "tabPageTTTaiLieuKhac";
            this.tabPageTTTaiLieuKhac.Size = new System.Drawing.Size(1220, 893);
            this.tabPageTTTaiLieuKhac.TabIndex = 23;
            this.tabPageTTTaiLieuKhac.Text = "Các thông tin khác của tài liệu";
            this.tabPageTTTaiLieuKhac.UseVisualStyleBackColor = true;
            // 
            // tabPageTTK
            // 
            this.tabPageTTK.ImageKey = "tabPageTTKIcon.png";
            this.tabPageTTK.Location = new System.Drawing.Point(4, 58);
            this.tabPageTTK.Name = "tabPageTTK";
            this.tabPageTTK.Size = new System.Drawing.Size(1220, 893);
            this.tabPageTTK.TabIndex = 20;
            this.tabPageTTK.Text = "Khác";
            this.tabPageTTK.UseVisualStyleBackColor = true;
            // 
            // tabPageTT
            // 
            this.tabPageTT.ImageKey = "tabPageTTIcon.png";
            this.tabPageTT.Location = new System.Drawing.Point(4, 58);
            this.tabPageTT.Name = "tabPageTT";
            this.tabPageTT.Size = new System.Drawing.Size(1220, 893);
            this.tabPageTT.TabIndex = 22;
            this.tabPageTT.Text = "Thông tin";
            this.tabPageTT.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tabPageBCIcon.png");
            this.imageList1.Images.SetKeyName(1, "tabPageBDIcon.png");
            this.imageList1.Images.SetKeyName(2, "tabPageDPIcon.png");
            this.imageList1.Images.SetKeyName(3, "tabPageHomeIcon.png");
            this.imageList1.Images.SetKeyName(4, "tabPageKiemKeIcon.png");
            this.imageList1.Images.SetKeyName(5, "tabPageKhoIcon.png");
            this.imageList1.Images.SetKeyName(6, "tabPageMTIcon.png");
            this.imageList1.Images.SetKeyName(7, "tabPageNCCIcon.png");
            this.imageList1.Images.SetKeyName(8, "tabPageNVIcon.png");
            this.imageList1.Images.SetKeyName(9, "tabPageNXBIcon.png");
            this.imageList1.Images.SetKeyName(10, "tabPageNhapIcon.png");
            this.imageList1.Images.SetKeyName(11, "tabPagePhatIcon.png");
            this.imageList1.Images.SetKeyName(12, "tabPageTGIcon.png");
            this.imageList1.Images.SetKeyName(13, "tabPageTTIcon.png");
            this.imageList1.Images.SetKeyName(14, "tabPageTTKIcon.png");
            this.imageList1.Images.SetKeyName(15, "tabPageThanhLocIcon.png");
            this.imageList1.Images.SetKeyName(16, "tabPageRaVaoIcon.png");
            this.imageList1.Images.SetKeyName(17, "tabPageTTTaiLieuKhacIcon.png");
            this.imageList1.Images.SetKeyName(18, "tabPageTLIcon.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 1038);
            this.Controls.Add(this.materialTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl;
            this.DrawerWidth = 250;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1200, 960);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 4, 3);
            this.Text = "BAEK-PERCENT";
            this.Shown += new System.EventHandler(this.atEnd_frmMain_Shown);
            this.VisibleChanged += new System.EventHandler(this.frmMain_VisibleChanged);
            this.materialTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPageTL;
        private System.Windows.Forms.TabPage tabPageMT;
        private System.Windows.Forms.TabPage tabPageDP;
        private System.Windows.Forms.TabPage tabPagePhat;
        private System.Windows.Forms.TabPage tabPageBD;
        private System.Windows.Forms.TabPage tabPageNV;
        private System.Windows.Forms.TabPage tabPageKho;
        private System.Windows.Forms.TabPage tabPageNCC;
        private System.Windows.Forms.TabPage tabPageNXB;
        private System.Windows.Forms.TabPage tabPageNhap;
        private System.Windows.Forms.TabPage tabPageKiemKe;
        private System.Windows.Forms.TabPage tabPageThanhLoc;
        private System.Windows.Forms.TabPage tabPageBC;
        private System.Windows.Forms.TabPage tabPageTTK;
        private System.Windows.Forms.TabPage tabPageRaVao;
        private System.Windows.Forms.TabPage tabPageTT;
        private System.Windows.Forms.TabPage tabPageTTTaiLieuKhac;
    }
}

