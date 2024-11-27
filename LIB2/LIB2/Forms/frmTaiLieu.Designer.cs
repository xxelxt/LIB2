namespace LIB2.Forms
{
    partial class frmTaiLieu
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
            this.tabPageSach = new System.Windows.Forms.TabPage();
            this.tabPageTapChi = new System.Windows.Forms.TabPage();
            this.tabPageKhoaLuan = new System.Windows.Forms.TabPage();
            this.tabPageTG = new System.Windows.Forms.TabPage();
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
            this.materialTabSelector1.TabIndex = 27;
            this.materialTabSelector1.TabIndicatorHeight = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl
            // 
            this.materialTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl.Controls.Add(this.tabPageSach);
            this.materialTabControl.Controls.Add(this.tabPageTapChi);
            this.materialTabControl.Controls.Add(this.tabPageKhoaLuan);
            this.materialTabControl.Controls.Add(this.tabPageTG);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(0, 48);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(1010, 733);
            this.materialTabControl.TabIndex = 28;
            // 
            // tabPageSach
            // 
            this.tabPageSach.Location = new System.Drawing.Point(4, 22);
            this.tabPageSach.Name = "tabPageSach";
            this.tabPageSach.Size = new System.Drawing.Size(1002, 707);
            this.tabPageSach.TabIndex = 0;
            this.tabPageSach.Text = "Sách";
            this.tabPageSach.UseVisualStyleBackColor = true;
            // 
            // tabPageTapChi
            // 
            this.tabPageTapChi.Location = new System.Drawing.Point(4, 22);
            this.tabPageTapChi.Name = "tabPageTapChi";
            this.tabPageTapChi.Size = new System.Drawing.Size(1016, 745);
            this.tabPageTapChi.TabIndex = 1;
            this.tabPageTapChi.Text = "Tạp chí/báo";
            this.tabPageTapChi.UseVisualStyleBackColor = true;
            // 
            // tabPageKhoaLuan
            // 
            this.tabPageKhoaLuan.Location = new System.Drawing.Point(4, 22);
            this.tabPageKhoaLuan.Name = "tabPageKhoaLuan";
            this.tabPageKhoaLuan.Size = new System.Drawing.Size(1016, 745);
            this.tabPageKhoaLuan.TabIndex = 2;
            this.tabPageKhoaLuan.Text = "Khoá luận";
            this.tabPageKhoaLuan.UseVisualStyleBackColor = true;
            // 
            // tabPageTG
            // 
            this.tabPageTG.Location = new System.Drawing.Point(4, 22);
            this.tabPageTG.Name = "tabPageTG";
            this.tabPageTG.Size = new System.Drawing.Size(1016, 745);
            this.tabPageTG.TabIndex = 3;
            this.tabPageTG.Text = "Tác giả";
            this.tabPageTG.UseVisualStyleBackColor = true;
            // 
            // frmTaiLieu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 780);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmTaiLieu";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 6, 6);
            this.Text = "frmTaiLieu";
            this.Load += new System.EventHandler(this.frmTaiLieu_Load);
            this.materialTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageSach;
        private System.Windows.Forms.TabPage tabPageTapChi;
        private System.Windows.Forms.TabPage tabPageKhoaLuan;
        private System.Windows.Forms.TabPage tabPageTG;
    }
}