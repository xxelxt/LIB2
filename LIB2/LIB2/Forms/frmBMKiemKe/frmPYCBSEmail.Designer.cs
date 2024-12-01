namespace LIB2.Forms
{
    partial class frmPYCBSEmail
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
            this.txtMaPYCBS = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cboNCC = new MaterialSkin.Controls.MaterialComboBox();
            this.cboNXB = new MaterialSkin.Controls.MaterialComboBox();
            this.rdoNCC = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoNXB = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtNoiDung = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnGui = new MaterialSkin.Controls.MaterialButton();
            this.rdoKhac = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // txtMaPYCBS
            // 
            this.txtMaPYCBS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPYCBS.AnimateReadOnly = true;
            this.txtMaPYCBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaPYCBS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaPYCBS.Depth = 0;
            this.txtMaPYCBS.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPYCBS.HideSelection = true;
            this.txtMaPYCBS.LeadingIcon = null;
            this.txtMaPYCBS.Location = new System.Drawing.Point(270, 105);
            this.txtMaPYCBS.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaPYCBS.MaxLength = 32767;
            this.txtMaPYCBS.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaPYCBS.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaPYCBS.Name = "txtMaPYCBS";
            this.txtMaPYCBS.PasswordChar = '\0';
            this.txtMaPYCBS.PrefixSuffixText = null;
            this.txtMaPYCBS.ReadOnly = false;
            this.txtMaPYCBS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaPYCBS.SelectedText = "";
            this.txtMaPYCBS.SelectionLength = 0;
            this.txtMaPYCBS.SelectionStart = 0;
            this.txtMaPYCBS.ShortcutsEnabled = true;
            this.txtMaPYCBS.Size = new System.Drawing.Size(202, 48);
            this.txtMaPYCBS.TabIndex = 86;
            this.txtMaPYCBS.TabStop = false;
            this.txtMaPYCBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaPYCBS.TrailingIcon = null;
            this.txtMaPYCBS.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(149, 119);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(115, 19);
            this.materialLabel1.TabIndex = 85;
            this.materialLabel1.Text = "Mã phiếu YCBS:";
            // 
            // cboNCC
            // 
            this.cboNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNCC.AutoResize = false;
            this.cboNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboNCC.Depth = 0;
            this.cboNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboNCC.DropDownHeight = 174;
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.DropDownWidth = 121;
            this.cboNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.IntegralHeight = false;
            this.cboNCC.ItemHeight = 43;
            this.cboNCC.Location = new System.Drawing.Point(180, 179);
            this.cboNCC.MaxDropDownItems = 4;
            this.cboNCC.MouseState = MaterialSkin.MouseState.OUT;
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(437, 49);
            this.cboNCC.StartIndex = 0;
            this.cboNCC.TabIndex = 152;
            // 
            // cboNXB
            // 
            this.cboNXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNXB.AutoResize = false;
            this.cboNXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboNXB.Depth = 0;
            this.cboNXB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboNXB.DropDownHeight = 174;
            this.cboNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNXB.DropDownWidth = 121;
            this.cboNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboNXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboNXB.FormattingEnabled = true;
            this.cboNXB.IntegralHeight = false;
            this.cboNXB.ItemHeight = 43;
            this.cboNXB.Location = new System.Drawing.Point(180, 244);
            this.cboNXB.MaxDropDownItems = 4;
            this.cboNXB.MouseState = MaterialSkin.MouseState.OUT;
            this.cboNXB.Name = "cboNXB";
            this.cboNXB.Size = new System.Drawing.Size(437, 49);
            this.cboNXB.StartIndex = 0;
            this.cboNXB.TabIndex = 153;
            // 
            // rdoNCC
            // 
            this.rdoNCC.AutoSize = true;
            this.rdoNCC.Depth = 0;
            this.rdoNCC.Location = new System.Drawing.Point(26, 182);
            this.rdoNCC.Margin = new System.Windows.Forms.Padding(0);
            this.rdoNCC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoNCC.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoNCC.Name = "rdoNCC";
            this.rdoNCC.Ripple = true;
            this.rdoNCC.Size = new System.Drawing.Size(133, 37);
            this.rdoNCC.TabIndex = 154;
            this.rdoNCC.TabStop = true;
            this.rdoNCC.Text = "Nhà cung cấp";
            this.rdoNCC.UseVisualStyleBackColor = true;
            this.rdoNCC.CheckedChanged += new System.EventHandler(this.rdoNCC_CheckedChanged);
            // 
            // rdoNXB
            // 
            this.rdoNXB.AutoSize = true;
            this.rdoNXB.Depth = 0;
            this.rdoNXB.Location = new System.Drawing.Point(26, 247);
            this.rdoNXB.Margin = new System.Windows.Forms.Padding(0);
            this.rdoNXB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoNXB.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoNXB.Name = "rdoNXB";
            this.rdoNXB.Ripple = true;
            this.rdoNXB.Size = new System.Drawing.Size(130, 37);
            this.rdoNXB.TabIndex = 155;
            this.rdoNXB.TabStop = true;
            this.rdoNXB.Text = "Nhà xuất bản";
            this.rdoNXB.UseVisualStyleBackColor = true;
            this.rdoNXB.CheckedChanged += new System.EventHandler(this.rdoNXB_CheckedChanged);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDung.AnimateReadOnly = false;
            this.txtNoiDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNoiDung.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiDung.Depth = 0;
            this.txtNoiDung.HideSelection = true;
            this.txtNoiDung.Location = new System.Drawing.Point(26, 389);
            this.txtNoiDung.MaxLength = 32767;
            this.txtNoiDung.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PasswordChar = '\0';
            this.txtNoiDung.ReadOnly = false;
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoiDung.SelectedText = "";
            this.txtNoiDung.SelectionLength = 0;
            this.txtNoiDung.SelectionStart = 0;
            this.txtNoiDung.ShortcutsEnabled = true;
            this.txtNoiDung.Size = new System.Drawing.Size(591, 250);
            this.txtNoiDung.TabIndex = 158;
            this.txtNoiDung.TabStop = false;
            this.txtNoiDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNoiDung.UseSystemPasswordChar = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHuy.AutoSize = false;
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(334, 665);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnHuy.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(80, 36);
            this.btnHuy.TabIndex = 236;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = false;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnGui
            // 
            this.btnGui.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGui.AutoSize = false;
            this.btnGui.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGui.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGui.Depth = 0;
            this.btnGui.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.HighEmphasis = true;
            this.btnGui.Icon = null;
            this.btnGui.Location = new System.Drawing.Point(230, 665);
            this.btnGui.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGui.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnGui.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnGui.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGui.Name = "btnGui";
            this.btnGui.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGui.Size = new System.Drawing.Size(80, 36);
            this.btnGui.TabIndex = 235;
            this.btnGui.Text = "Gửi";
            this.btnGui.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGui.UseAccentColor = false;
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // rdoKhac
            // 
            this.rdoKhac.AutoSize = true;
            this.rdoKhac.Depth = 0;
            this.rdoKhac.Location = new System.Drawing.Point(26, 312);
            this.rdoKhac.Margin = new System.Windows.Forms.Padding(0);
            this.rdoKhac.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoKhac.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoKhac.Name = "rdoKhac";
            this.rdoKhac.Ripple = true;
            this.rdoKhac.Size = new System.Drawing.Size(71, 37);
            this.rdoKhac.TabIndex = 237;
            this.rdoKhac.TabStop = true;
            this.rdoKhac.Text = "Khác";
            this.rdoKhac.UseVisualStyleBackColor = true;
            this.rdoKhac.CheckedChanged += new System.EventHandler(this.rdoKhac_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.AnimateReadOnly = true;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HideSelection = true;
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(179, 309);
            this.txtEmail.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(438, 48);
            this.txtEmail.TabIndex = 238;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // frmPYCBSEmail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(645, 736);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.rdoKhac);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.rdoNXB);
            this.Controls.Add(this.rdoNCC);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.cboNXB);
            this.Controls.Add(this.txtMaPYCBS);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
            this.Name = "frmPYCBSEmail";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 6, 6);
            this.Text = "Gửi yêu cầu bổ sung qua Email";
            this.Load += new System.EventHandler(this.frmPYCBSEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtMaPYCBS;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cboNCC;
        private MaterialSkin.Controls.MaterialComboBox cboNXB;
        private MaterialSkin.Controls.MaterialRadioButton rdoNCC;
        private MaterialSkin.Controls.MaterialRadioButton rdoNXB;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtNoiDung;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnGui;
        private MaterialSkin.Controls.MaterialRadioButton rdoKhac;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
    }
}