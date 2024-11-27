namespace LIB2.Forms
{
    partial class FrmKhac
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPagePB = new System.Windows.Forms.TabPage();
            this.tabPageCV = new System.Windows.Forms.TabPage();
            this.tabPageKhoa = new System.Windows.Forms.TabPage();
            this.tabPageVP = new System.Windows.Forms.TabPage();
            this.tabPageTK = new System.Windows.Forms.TabPage();
            this.materialTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1024, 48);
            this.materialTabSelector1.TabIndex = 25;
            this.materialTabSelector1.TabIndicatorHeight = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl
            // 
            this.materialTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl.Controls.Add(this.tabPagePB);
            this.materialTabControl.Controls.Add(this.tabPageCV);
            this.materialTabControl.Controls.Add(this.tabPageKhoa);
            this.materialTabControl.Controls.Add(this.tabPageVP);
            this.materialTabControl.Controls.Add(this.tabPageTK);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(0, 48);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(1024, 771);
            this.materialTabControl.TabIndex = 26;
            // 
            // tabPagePB
            // 
            this.tabPagePB.AutoScroll = true;
            this.tabPagePB.Location = new System.Drawing.Point(4, 22);
            this.tabPagePB.Name = "tabPagePB";
            this.tabPagePB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePB.Size = new System.Drawing.Size(1016, 745);
            this.tabPagePB.TabIndex = 0;
            this.tabPagePB.Text = "Phòng ban";
            this.tabPagePB.UseVisualStyleBackColor = true;
            // 
            // tabPageCV
            // 
            this.tabPageCV.Location = new System.Drawing.Point(4, 22);
            this.tabPageCV.Name = "tabPageCV";
            this.tabPageCV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCV.Size = new System.Drawing.Size(1016, 745);
            this.tabPageCV.TabIndex = 1;
            this.tabPageCV.Text = "Chức vụ";
            this.tabPageCV.UseVisualStyleBackColor = true;
            // 
            // tabPageKhoa
            // 
            this.tabPageKhoa.Location = new System.Drawing.Point(4, 22);
            this.tabPageKhoa.Name = "tabPageKhoa";
            this.tabPageKhoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKhoa.Size = new System.Drawing.Size(1016, 745);
            this.tabPageKhoa.TabIndex = 6;
            this.tabPageKhoa.Text = "Khoa";
            this.tabPageKhoa.UseVisualStyleBackColor = true;
            // 
            // tabPageVP
            // 
            this.tabPageVP.Location = new System.Drawing.Point(4, 22);
            this.tabPageVP.Name = "tabPageVP";
            this.tabPageVP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVP.Size = new System.Drawing.Size(1016, 745);
            this.tabPageVP.TabIndex = 7;
            this.tabPageVP.Text = "Vi phạm";
            this.tabPageVP.UseVisualStyleBackColor = true;
            // 
            // tabPageTK
            // 
            this.tabPageTK.Location = new System.Drawing.Point(4, 22);
            this.tabPageTK.Name = "tabPageTK";
            this.tabPageTK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTK.Size = new System.Drawing.Size(1016, 745);
            this.tabPageTK.TabIndex = 8;
            this.tabPageTK.Text = "Tài khoản";
            this.tabPageTK.UseVisualStyleBackColor = true;
            // 
            // FrmKhac
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.materialTabControl);
            this.Controls.Add(this.materialTabSelector1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "FrmKhac";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 6, 6);
            this.Text = "frmKhac";
            this.Load += new System.EventHandler(this.frmKhac_Load);
            this.materialTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPagePB;
        private System.Windows.Forms.TabPage tabPageCV;
        private System.Windows.Forms.TabPage tabPageKhoa;
        private System.Windows.Forms.TabPage tabPageVP;
        private System.Windows.Forms.TabPage tabPageTK;
    }
}