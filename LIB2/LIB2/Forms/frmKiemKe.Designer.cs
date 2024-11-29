namespace LIB2.Forms
{
    partial class FrmKiemKe
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
            this.tabPageKHKK = new System.Windows.Forms.TabPage();
            this.tabPagePKK = new System.Windows.Forms.TabPage();
            this.tabPageDMSC = new System.Windows.Forms.TabPage();
            this.tabPageDMBT = new System.Windows.Forms.TabPage();
            this.tabPageBCKK = new System.Windows.Forms.TabPage();
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
            this.materialTabSelector1.TabIndex = 29;
            this.materialTabSelector1.TabIndicatorHeight = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl
            // 
            this.materialTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl.Controls.Add(this.tabPageKHKK);
            this.materialTabControl.Controls.Add(this.tabPagePKK);
            this.materialTabControl.Controls.Add(this.tabPageDMSC);
            this.materialTabControl.Controls.Add(this.tabPageDMBT);
            this.materialTabControl.Controls.Add(this.tabPageBCKK);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(0, 48);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(1024, 771);
            this.materialTabControl.TabIndex = 30;
            // 
            // tabPageKHKK
            // 
            this.tabPageKHKK.AutoScroll = true;
            this.tabPageKHKK.Location = new System.Drawing.Point(4, 22);
            this.tabPageKHKK.Name = "tabPageKHKK";
            this.tabPageKHKK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKHKK.Size = new System.Drawing.Size(1016, 745);
            this.tabPageKHKK.TabIndex = 0;
            this.tabPageKHKK.Text = "Kế hoạch kiểm kê";
            this.tabPageKHKK.UseVisualStyleBackColor = true;
            // 
            // tabPagePKK
            // 
            this.tabPagePKK.Location = new System.Drawing.Point(4, 22);
            this.tabPagePKK.Name = "tabPagePKK";
            this.tabPagePKK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePKK.Size = new System.Drawing.Size(1016, 745);
            this.tabPagePKK.TabIndex = 1;
            this.tabPagePKK.Text = "Phiếu kiểm kê";
            this.tabPagePKK.UseVisualStyleBackColor = true;
            // 
            // tabPageDMSC
            // 
            this.tabPageDMSC.Location = new System.Drawing.Point(4, 22);
            this.tabPageDMSC.Name = "tabPageDMSC";
            this.tabPageDMSC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDMSC.Size = new System.Drawing.Size(1016, 745);
            this.tabPageDMSC.TabIndex = 6;
            this.tabPageDMSC.Text = "Danh mục sửa chữa";
            this.tabPageDMSC.UseVisualStyleBackColor = true;
            // 
            // tabPageDMBT
            // 
            this.tabPageDMBT.Location = new System.Drawing.Point(4, 22);
            this.tabPageDMBT.Name = "tabPageDMBT";
            this.tabPageDMBT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDMBT.Size = new System.Drawing.Size(1016, 745);
            this.tabPageDMBT.TabIndex = 7;
            this.tabPageDMBT.Text = "Danh mục bồi thường";
            this.tabPageDMBT.UseVisualStyleBackColor = true;
            // 
            // tabPageBCKK
            // 
            this.tabPageBCKK.Location = new System.Drawing.Point(4, 22);
            this.tabPageBCKK.Name = "tabPageBCKK";
            this.tabPageBCKK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBCKK.Size = new System.Drawing.Size(1016, 745);
            this.tabPageBCKK.TabIndex = 8;
            this.tabPageBCKK.Text = "Báo cáo kiểm kê";
            this.tabPageBCKK.UseVisualStyleBackColor = true;
            // 
            // FrmKiemKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "FrmKiemKe";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 6, 6);
            this.Text = "frmKiemKe";
            this.Load += new System.EventHandler(this.FrmKiemKe_Load);
            this.materialTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageKHKK;
        private System.Windows.Forms.TabPage tabPagePKK;
        private System.Windows.Forms.TabPage tabPageDMSC;
        private System.Windows.Forms.TabPage tabPageDMBT;
        private System.Windows.Forms.TabPage tabPageBCKK;
    }
}