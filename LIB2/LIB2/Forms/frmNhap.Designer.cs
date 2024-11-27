namespace LIB2.Forms
{
    partial class frmNhap
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
            this.tabPagePYCBS = new System.Windows.Forms.TabPage();
            this.tabPagePNK = new System.Windows.Forms.TabPage();
            this.tabPagePL = new System.Windows.Forms.TabPage();
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
            this.materialTabControl.Controls.Add(this.tabPagePYCBS);
            this.materialTabControl.Controls.Add(this.tabPagePNK);
            this.materialTabControl.Controls.Add(this.tabPagePL);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(0, 48);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(1024, 771);
            this.materialTabControl.TabIndex = 28;
            // 
            // tabPagePYCBS
            // 
            this.tabPagePYCBS.AutoScroll = true;
            this.tabPagePYCBS.Location = new System.Drawing.Point(4, 22);
            this.tabPagePYCBS.Name = "tabPagePYCBS";
            this.tabPagePYCBS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePYCBS.Size = new System.Drawing.Size(1016, 745);
            this.tabPagePYCBS.TabIndex = 0;
            this.tabPagePYCBS.Text = "Phiếu yêu cầu bổ sung";
            this.tabPagePYCBS.UseVisualStyleBackColor = true;
            // 
            // tabPagePNK
            // 
            this.tabPagePNK.Location = new System.Drawing.Point(4, 22);
            this.tabPagePNK.Name = "tabPagePNK";
            this.tabPagePNK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePNK.Size = new System.Drawing.Size(1016, 745);
            this.tabPagePNK.TabIndex = 1;
            this.tabPagePNK.Text = "Phiếu nhập kho";
            this.tabPagePNK.UseVisualStyleBackColor = true;
            // 
            // tabPagePL
            // 
            this.tabPagePL.Location = new System.Drawing.Point(4, 22);
            this.tabPagePL.Name = "tabPagePL";
            this.tabPagePL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePL.Size = new System.Drawing.Size(1016, 745);
            this.tabPagePL.TabIndex = 6;
            this.tabPagePL.Text = "Phiếu xử lý tài liệu lỗi";
            this.tabPagePL.UseVisualStyleBackColor = true;
            // 
            // frmNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmNhap";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 6, 6);
            this.Text = "frmNhap";
            this.Load += new System.EventHandler(this.frmNhap_Load);
            this.materialTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPagePYCBS;
        private System.Windows.Forms.TabPage tabPagePNK;
        private System.Windows.Forms.TabPage tabPagePL;
    }
}