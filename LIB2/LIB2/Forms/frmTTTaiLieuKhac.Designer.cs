namespace LIB2.Forms
{
    partial class frmTTTaiLieuKhac
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
            this.tabPageNganh = new System.Windows.Forms.TabPage();
            this.tabPageLV = new System.Windows.Forms.TabPage();
            this.tabPageNN = new System.Windows.Forms.TabPage();
            this.tabPageLAP = new System.Windows.Forms.TabPage();
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
            this.materialTabControl.Controls.Add(this.tabPageNganh);
            this.materialTabControl.Controls.Add(this.tabPageLV);
            this.materialTabControl.Controls.Add(this.tabPageNN);
            this.materialTabControl.Controls.Add(this.tabPageLAP);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(0, 48);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(1024, 771);
            this.materialTabControl.TabIndex = 28;
            // 
            // tabPageNganh
            // 
            this.tabPageNganh.Location = new System.Drawing.Point(4, 22);
            this.tabPageNganh.Name = "tabPageNganh";
            this.tabPageNganh.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNganh.Size = new System.Drawing.Size(1016, 745);
            this.tabPageNganh.TabIndex = 2;
            this.tabPageNganh.Text = "Ngành";
            this.tabPageNganh.UseVisualStyleBackColor = true;
            // 
            // tabPageLV
            // 
            this.tabPageLV.Location = new System.Drawing.Point(4, 22);
            this.tabPageLV.Name = "tabPageLV";
            this.tabPageLV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLV.Size = new System.Drawing.Size(1016, 745);
            this.tabPageLV.TabIndex = 3;
            this.tabPageLV.Text = "Lĩnh vực";
            this.tabPageLV.UseVisualStyleBackColor = true;
            // 
            // tabPageNN
            // 
            this.tabPageNN.Location = new System.Drawing.Point(4, 22);
            this.tabPageNN.Name = "tabPageNN";
            this.tabPageNN.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNN.Size = new System.Drawing.Size(1016, 745);
            this.tabPageNN.TabIndex = 4;
            this.tabPageNN.Text = "Ngôn ngữ";
            this.tabPageNN.UseVisualStyleBackColor = true;
            // 
            // tabPageLAP
            // 
            this.tabPageLAP.Location = new System.Drawing.Point(4, 22);
            this.tabPageLAP.Name = "tabPageLAP";
            this.tabPageLAP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLAP.Size = new System.Drawing.Size(1016, 745);
            this.tabPageLAP.TabIndex = 5;
            this.tabPageLAP.Text = "Loại ấn phẩm";
            this.tabPageLAP.UseVisualStyleBackColor = true;
            // 
            // frmTTTaiLieuKhac
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmTTTaiLieuKhac";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 6, 6);
            this.Text = "Các thông tin khác của tài liệu";
            this.Load += new System.EventHandler(this.frmTTTaiLieuKhac_Load);
            this.materialTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageNganh;
        private System.Windows.Forms.TabPage tabPageLV;
        private System.Windows.Forms.TabPage tabPageNN;
        private System.Windows.Forms.TabPage tabPageLAP;
    }
}