namespace LIB2.Forms
{
    partial class frmPhat
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
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.txtThoiGian = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaPhat = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenBD = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTTDaTH = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.rdoTTChuaTH = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtViPham = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaBD = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSoTienPhat = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cboTimKiem = new MaterialSkin.Controls.MaterialComboBox();
            this.listViewPhat = new MaterialSkin.Controls.MaterialListView();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnHuy.Location = new System.Drawing.Point(580, 755);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnHuy.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(80, 36);
            this.btnHuy.TabIndex = 157;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = false;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.AllowPromptAsInput = true;
            this.txtThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtThoiGian.AnimateReadOnly = false;
            this.txtThoiGian.AsciiOnly = false;
            this.txtThoiGian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtThoiGian.BeepOnError = false;
            this.txtThoiGian.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtThoiGian.Depth = 0;
            this.txtThoiGian.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtThoiGian.HidePromptOnLeave = false;
            this.txtThoiGian.HideSelection = true;
            this.txtThoiGian.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtThoiGian.LeadingIcon = null;
            this.txtThoiGian.Location = new System.Drawing.Point(126, 93);
            this.txtThoiGian.Mask = "00/00/0000";
            this.txtThoiGian.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtThoiGian.MaxLength = 32767;
            this.txtThoiGian.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtThoiGian.MouseState = MaterialSkin.MouseState.OUT;
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.PasswordChar = '\0';
            this.txtThoiGian.PrefixSuffixText = null;
            this.txtThoiGian.PromptChar = '_';
            this.txtThoiGian.ReadOnly = false;
            this.txtThoiGian.RejectInputOnFirstFailure = false;
            this.txtThoiGian.ResetOnPrompt = true;
            this.txtThoiGian.ResetOnSpace = true;
            this.txtThoiGian.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtThoiGian.SelectedText = "";
            this.txtThoiGian.SelectionLength = 0;
            this.txtThoiGian.SelectionStart = 0;
            this.txtThoiGian.ShortcutsEnabled = true;
            this.txtThoiGian.Size = new System.Drawing.Size(150, 48);
            this.txtThoiGian.SkipLiterals = true;
            this.txtThoiGian.TabIndex = 131;
            this.txtThoiGian.TabStop = false;
            this.txtThoiGian.Text = "  /  /";
            this.txtThoiGian.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtThoiGian.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtThoiGian.TrailingIcon = null;
            this.txtThoiGian.UseSystemPasswordChar = false;
            this.txtThoiGian.ValidatingType = null;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(48, 108);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(72, 19);
            this.materialLabel11.TabIndex = 130;
            this.materialLabel11.Text = "Thời gian:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(56, 43);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 83;
            this.materialLabel1.Text = "Mã phạt:";
            // 
            // txtMaPhat
            // 
            this.txtMaPhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaPhat.AnimateReadOnly = true;
            this.txtMaPhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaPhat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaPhat.Depth = 0;
            this.txtMaPhat.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhat.HideSelection = true;
            this.txtMaPhat.LeadingIcon = null;
            this.txtMaPhat.Location = new System.Drawing.Point(126, 29);
            this.txtMaPhat.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaPhat.MaxLength = 32767;
            this.txtMaPhat.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaPhat.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaPhat.Name = "txtMaPhat";
            this.txtMaPhat.PasswordChar = '\0';
            this.txtMaPhat.PrefixSuffixText = null;
            this.txtMaPhat.ReadOnly = false;
            this.txtMaPhat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaPhat.SelectedText = "";
            this.txtMaPhat.SelectionLength = 0;
            this.txtMaPhat.SelectionStart = 0;
            this.txtMaPhat.ShortcutsEnabled = true;
            this.txtMaPhat.Size = new System.Drawing.Size(150, 48);
            this.txtMaPhat.TabIndex = 84;
            this.txtMaPhat.TabStop = false;
            this.txtMaPhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaPhat.TrailingIcon = null;
            this.txtMaPhat.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(588, 43);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 85;
            this.materialLabel2.Text = "Tên bạn đọc:";
            // 
            // txtTenBD
            // 
            this.txtTenBD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenBD.AnimateReadOnly = false;
            this.txtTenBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenBD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenBD.Depth = 0;
            this.txtTenBD.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBD.HideSelection = true;
            this.txtTenBD.LeadingIcon = null;
            this.txtTenBD.Location = new System.Drawing.Point(688, 29);
            this.txtTenBD.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtTenBD.MaxLength = 32767;
            this.txtTenBD.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtTenBD.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenBD.Name = "txtTenBD";
            this.txtTenBD.PasswordChar = '\0';
            this.txtTenBD.PrefixSuffixText = null;
            this.txtTenBD.ReadOnly = false;
            this.txtTenBD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenBD.SelectedText = "";
            this.txtTenBD.SelectionLength = 0;
            this.txtTenBD.SelectionStart = 0;
            this.txtTenBD.ShortcutsEnabled = true;
            this.txtTenBD.Size = new System.Drawing.Size(267, 48);
            this.txtTenBD.TabIndex = 86;
            this.txtTenBD.TabStop = false;
            this.txtTenBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenBD.TrailingIcon = null;
            this.txtTenBD.UseSystemPasswordChar = false;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.AutoSize = false;
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSua.Depth = 0;
            this.btnSua.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = null;
            this.btnSua.Location = new System.Drawing.Point(364, 755);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnSua.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(101, 36);
            this.btnSua.TabIndex = 154;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(30, 173);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(90, 19);
            this.materialLabel6.TabIndex = 102;
            this.materialLabel6.Text = "Số tiền phạt:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdoTTDaTH);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.rdoTTChuaTH);
            this.groupBox1.Controls.Add(this.txtViPham);
            this.groupBox1.Controls.Add(this.materialLabel12);
            this.groupBox1.Controls.Add(this.txtMaBD);
            this.groupBox1.Controls.Add(this.txtThoiGian);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtMaPhat);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtTenBD);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.txtSoTienPhat);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Location = new System.Drawing.Point(27, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 235);
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            // 
            // rdoTTDaTH
            // 
            this.rdoTTDaTH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoTTDaTH.AutoSize = true;
            this.rdoTTDaTH.Depth = 0;
            this.rdoTTDaTH.Location = new System.Drawing.Point(676, 163);
            this.rdoTTDaTH.Margin = new System.Windows.Forms.Padding(0);
            this.rdoTTDaTH.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoTTDaTH.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoTTDaTH.Name = "rdoTTDaTH";
            this.rdoTTDaTH.Ripple = true;
            this.rdoTTDaTH.Size = new System.Drawing.Size(125, 37);
            this.rdoTTDaTH.TabIndex = 169;
            this.rdoTTDaTH.TabStop = true;
            this.rdoTTDaTH.Text = "Đã thực hiện";
            this.rdoTTDaTH.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(588, 173);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(78, 19);
            this.materialLabel3.TabIndex = 138;
            this.materialLabel3.Text = "Trạng thái:";
            // 
            // rdoTTChuaTH
            // 
            this.rdoTTChuaTH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoTTChuaTH.AutoSize = true;
            this.rdoTTChuaTH.Depth = 0;
            this.rdoTTChuaTH.Location = new System.Drawing.Point(812, 163);
            this.rdoTTChuaTH.Margin = new System.Windows.Forms.Padding(0);
            this.rdoTTChuaTH.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoTTChuaTH.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoTTChuaTH.Name = "rdoTTChuaTH";
            this.rdoTTChuaTH.Ripple = true;
            this.rdoTTChuaTH.Size = new System.Drawing.Size(143, 37);
            this.rdoTTChuaTH.TabIndex = 168;
            this.rdoTTChuaTH.TabStop = true;
            this.rdoTTChuaTH.Text = "Chưa thực hiện";
            this.rdoTTChuaTH.UseVisualStyleBackColor = true;
            // 
            // txtViPham
            // 
            this.txtViPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtViPham.AnimateReadOnly = false;
            this.txtViPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtViPham.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtViPham.Depth = 0;
            this.txtViPham.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViPham.HideSelection = true;
            this.txtViPham.LeadingIcon = null;
            this.txtViPham.Location = new System.Drawing.Point(403, 93);
            this.txtViPham.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtViPham.MaxLength = 32767;
            this.txtViPham.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtViPham.MouseState = MaterialSkin.MouseState.OUT;
            this.txtViPham.Name = "txtViPham";
            this.txtViPham.PasswordChar = '\0';
            this.txtViPham.PrefixSuffixText = null;
            this.txtViPham.ReadOnly = false;
            this.txtViPham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtViPham.SelectedText = "";
            this.txtViPham.SelectionLength = 0;
            this.txtViPham.SelectionStart = 0;
            this.txtViPham.ShortcutsEnabled = true;
            this.txtViPham.Size = new System.Drawing.Size(552, 48);
            this.txtViPham.TabIndex = 136;
            this.txtViPham.TabStop = false;
            this.txtViPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtViPham.TrailingIcon = null;
            this.txtViPham.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(307, 43);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(90, 19);
            this.materialLabel12.TabIndex = 134;
            this.materialLabel12.Text = "Mã bạn đọc:";
            // 
            // txtMaBD
            // 
            this.txtMaBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaBD.AnimateReadOnly = true;
            this.txtMaBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaBD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaBD.Depth = 0;
            this.txtMaBD.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBD.HideSelection = true;
            this.txtMaBD.LeadingIcon = null;
            this.txtMaBD.Location = new System.Drawing.Point(403, 29);
            this.txtMaBD.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaBD.MaxLength = 32767;
            this.txtMaBD.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaBD.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaBD.Name = "txtMaBD";
            this.txtMaBD.PasswordChar = '\0';
            this.txtMaBD.PrefixSuffixText = null;
            this.txtMaBD.ReadOnly = false;
            this.txtMaBD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaBD.SelectedText = "";
            this.txtMaBD.SelectionLength = 0;
            this.txtMaBD.SelectionStart = 0;
            this.txtMaBD.ShortcutsEnabled = true;
            this.txtMaBD.Size = new System.Drawing.Size(166, 48);
            this.txtMaBD.TabIndex = 135;
            this.txtMaBD.TabStop = false;
            this.txtMaBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaBD.TrailingIcon = null;
            this.txtMaBD.UseSystemPasswordChar = false;
            // 
            // txtSoTienPhat
            // 
            this.txtSoTienPhat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTienPhat.AnimateReadOnly = false;
            this.txtSoTienPhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoTienPhat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoTienPhat.Depth = 0;
            this.txtSoTienPhat.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienPhat.HideSelection = true;
            this.txtSoTienPhat.LeadingIcon = null;
            this.txtSoTienPhat.Location = new System.Drawing.Point(126, 158);
            this.txtSoTienPhat.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtSoTienPhat.MaxLength = 32767;
            this.txtSoTienPhat.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtSoTienPhat.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoTienPhat.Name = "txtSoTienPhat";
            this.txtSoTienPhat.PasswordChar = '\0';
            this.txtSoTienPhat.PrefixSuffixText = null;
            this.txtSoTienPhat.ReadOnly = false;
            this.txtSoTienPhat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoTienPhat.SelectedText = "";
            this.txtSoTienPhat.SelectionLength = 0;
            this.txtSoTienPhat.SelectionStart = 0;
            this.txtSoTienPhat.ShortcutsEnabled = true;
            this.txtSoTienPhat.Size = new System.Drawing.Size(445, 48);
            this.txtSoTienPhat.TabIndex = 119;
            this.txtSoTienPhat.TabStop = false;
            this.txtSoTienPhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoTienPhat.TrailingIcon = null;
            this.txtSoTienPhat.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(333, 108);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(64, 19);
            this.materialLabel5.TabIndex = 113;
            this.materialLabel5.Text = "Vi phạm:";
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTimKiem.AutoResize = false;
            this.cboTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTimKiem.Depth = 0;
            this.cboTimKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTimKiem.DropDownHeight = 174;
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.DropDownWidth = 121;
            this.cboTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.IntegralHeight = false;
            this.cboTimKiem.ItemHeight = 43;
            this.cboTimKiem.Location = new System.Drawing.Point(728, 26);
            this.cboTimKiem.MaxDropDownItems = 4;
            this.cboTimKiem.MinimumSize = new System.Drawing.Size(150, 0);
            this.cboTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(158, 49);
            this.cboTimKiem.StartIndex = 0;
            this.cboTimKiem.TabIndex = 160;
            this.cboTimKiem.SelectedIndexChanged += new System.EventHandler(this.cboTimKiem_SelectedIndexChanged);
            // 
            // listViewPhat
            // 
            this.listViewPhat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPhat.AutoSizeTable = false;
            this.listViewPhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewPhat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPhat.CheckBoxes = true;
            this.listViewPhat.Depth = 0;
            this.listViewPhat.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPhat.FullRowSelect = true;
            this.listViewPhat.HideSelection = false;
            this.listViewPhat.Location = new System.Drawing.Point(27, 350);
            this.listViewPhat.MinimumSize = new System.Drawing.Size(820, 200);
            this.listViewPhat.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewPhat.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewPhat.Name = "listViewPhat";
            this.listViewPhat.OwnerDraw = true;
            this.listViewPhat.Size = new System.Drawing.Size(970, 382);
            this.listViewPhat.TabIndex = 152;
            this.listViewPhat.UseCompatibleStateImageBehavior = false;
            this.listViewPhat.View = System.Windows.Forms.View.Details;
            this.listViewPhat.SelectedIndexChanged += new System.EventHandler(this.listViewPhat_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.AutoSize = false;
            this.btnTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiem.Depth = 0;
            this.btnTimKiem.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.HighEmphasis = true;
            this.btnTimKiem.Icon = null;
            this.btnTimKiem.Location = new System.Drawing.Point(902, 27);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 12, 4, 6);
            this.btnTimKiem.MaximumSize = new System.Drawing.Size(96, 40);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(0, 48);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.btnTimKiem.Size = new System.Drawing.Size(96, 48);
            this.btnTimKiem.TabIndex = 159;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.AnimateReadOnly = false;
            this.txtTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTimKiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiem.Depth = 0;
            this.txtTimKiem.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.HideSelection = true;
            this.txtTimKiem.LeadingIcon = null;
            this.txtTimKiem.Location = new System.Drawing.Point(27, 27);
            this.txtTimKiem.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PrefixSuffixText = null;
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.ShortcutsEnabled = true;
            this.txtTimKiem.Size = new System.Drawing.Size(685, 48);
            this.txtTimKiem.TabIndex = 158;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TrailingIcon = null;
            this.txtTimKiem.UseSystemPasswordChar = false;
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.AutoSize = false;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(482, 755);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnXoa.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(80, 36);
            this.btnXoa.TabIndex = 168;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmPhat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.listViewPhat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmPhat";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 6, 6);
            this.Text = "frmPhat";
            this.Load += new System.EventHandler(this.frmPhat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtThoiGian;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaPhat;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenBD;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoTienPhat;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cboTimKiem;
        private MaterialSkin.Controls.MaterialListView listViewPhat;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialRadioButton rdoTTDaTH;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRadioButton rdoTTChuaTH;
        private MaterialSkin.Controls.MaterialTextBox2 txtViPham;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaBD;
        private MaterialSkin.Controls.MaterialButton btnXoa;
    }
}