namespace LIB2.Forms
{
    partial class frmNhaXuatBan
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
            this.txtTenNXB = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFax = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSDT = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaNXB = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDiaChi = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.listViewNXB = new MaterialSkin.Controls.MaterialListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNXB.AnimateReadOnly = false;
            this.txtTenNXB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenNXB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenNXB.Depth = 0;
            this.txtTenNXB.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNXB.HideSelection = true;
            this.txtTenNXB.LeadingIcon = null;
            this.txtTenNXB.Location = new System.Drawing.Point(442, 27);
            this.txtTenNXB.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtTenNXB.MaxLength = 32767;
            this.txtTenNXB.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtTenNXB.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.PasswordChar = '\0';
            this.txtTenNXB.PrefixSuffixText = null;
            this.txtTenNXB.ReadOnly = false;
            this.txtTenNXB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenNXB.SelectedText = "";
            this.txtTenNXB.SelectionLength = 0;
            this.txtTenNXB.SelectionStart = 0;
            this.txtTenNXB.ShortcutsEnabled = true;
            this.txtTenNXB.Size = new System.Drawing.Size(508, 48);
            this.txtTenNXB.TabIndex = 40;
            this.txtTenNXB.TabStop = false;
            this.txtTenNXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenNXB.TrailingIcon = null;
            this.txtTenNXB.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(91, 104);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(54, 19);
            this.materialLabel5.TabIndex = 51;
            this.materialLabel5.Text = "Địa chỉ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtMaNXB);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenNXB);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Location = new System.Drawing.Point(27, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 227);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            // 
            // txtFax
            // 
            this.txtFax.AllowPromptAsInput = true;
            this.txtFax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFax.AnimateReadOnly = false;
            this.txtFax.AsciiOnly = false;
            this.txtFax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFax.BeepOnError = false;
            this.txtFax.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFax.Depth = 0;
            this.txtFax.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFax.HidePromptOnLeave = false;
            this.txtFax.HideSelection = true;
            this.txtFax.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtFax.LeadingIcon = null;
            this.txtFax.Location = new System.Drawing.Point(810, 154);
            this.txtFax.Mask = "000 000 0000";
            this.txtFax.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtFax.MaxLength = 32767;
            this.txtFax.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtFax.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFax.Name = "txtFax";
            this.txtFax.PasswordChar = '\0';
            this.txtFax.PrefixSuffixText = null;
            this.txtFax.PromptChar = '_';
            this.txtFax.ReadOnly = false;
            this.txtFax.RejectInputOnFirstFailure = false;
            this.txtFax.ResetOnPrompt = true;
            this.txtFax.ResetOnSpace = true;
            this.txtFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFax.SelectedText = "";
            this.txtFax.SelectionLength = 0;
            this.txtFax.SelectionStart = 0;
            this.txtFax.ShortcutsEnabled = true;
            this.txtFax.Size = new System.Drawing.Size(140, 48);
            this.txtFax.SkipLiterals = true;
            this.txtFax.TabIndex = 102;
            this.txtFax.TabStop = false;
            this.txtFax.Text = "        ";
            this.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFax.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFax.TrailingIcon = null;
            this.txtFax.UseSystemPasswordChar = false;
            this.txtFax.ValidatingType = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(773, 168);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(31, 19);
            this.materialLabel4.TabIndex = 101;
            this.materialLabel4.Text = "Fax:";
            // 
            // txtSDT
            // 
            this.txtSDT.AllowPromptAsInput = true;
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.AnimateReadOnly = false;
            this.txtSDT.AsciiOnly = false;
            this.txtSDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSDT.BeepOnError = false;
            this.txtSDT.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSDT.Depth = 0;
            this.txtSDT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSDT.HidePromptOnLeave = false;
            this.txtSDT.HideSelection = true;
            this.txtSDT.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtSDT.LeadingIcon = null;
            this.txtSDT.Location = new System.Drawing.Point(810, 90);
            this.txtSDT.Mask = "000 000 0000";
            this.txtSDT.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtSDT.MaxLength = 32767;
            this.txtSDT.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtSDT.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PrefixSuffixText = null;
            this.txtSDT.PromptChar = '_';
            this.txtSDT.ReadOnly = false;
            this.txtSDT.RejectInputOnFirstFailure = false;
            this.txtSDT.ResetOnPrompt = true;
            this.txtSDT.ResetOnSpace = true;
            this.txtSDT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSDT.SelectedText = "";
            this.txtSDT.SelectionLength = 0;
            this.txtSDT.SelectionStart = 0;
            this.txtSDT.ShortcutsEnabled = true;
            this.txtSDT.Size = new System.Drawing.Size(140, 48);
            this.txtSDT.SkipLiterals = true;
            this.txtSDT.TabIndex = 100;
            this.txtSDT.TabStop = false;
            this.txtSDT.Text = "        ";
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSDT.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSDT.TrailingIcon = null;
            this.txtSDT.UseSystemPasswordChar = false;
            this.txtSDT.ValidatingType = null;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(705, 104);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(99, 19);
            this.materialLabel7.TabIndex = 99;
            this.materialLabel7.Text = "Số điện thoại:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HideSelection = true;
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(151, 154);
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
            this.txtEmail.Size = new System.Drawing.Size(536, 48);
            this.txtEmail.TabIndex = 56;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(99, 168);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(45, 19);
            this.materialLabel3.TabIndex = 55;
            this.materialLabel3.Text = "Email:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(19, 41);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(125, 19);
            this.materialLabel1.TabIndex = 37;
            this.materialLabel1.Text = "Mã nhà xuất bản:";
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaNXB.AnimateReadOnly = true;
            this.txtMaNXB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaNXB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaNXB.Depth = 0;
            this.txtMaNXB.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNXB.HideSelection = true;
            this.txtMaNXB.LeadingIcon = null;
            this.txtMaNXB.Location = new System.Drawing.Point(151, 27);
            this.txtMaNXB.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaNXB.MaxLength = 32767;
            this.txtMaNXB.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaNXB.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.PasswordChar = '\0';
            this.txtMaNXB.PrefixSuffixText = null;
            this.txtMaNXB.ReadOnly = false;
            this.txtMaNXB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaNXB.SelectedText = "";
            this.txtMaNXB.SelectionLength = 0;
            this.txtMaNXB.SelectionStart = 0;
            this.txtMaNXB.ShortcutsEnabled = true;
            this.txtMaNXB.Size = new System.Drawing.Size(140, 48);
            this.txtMaNXB.TabIndex = 38;
            this.txtMaNXB.TabStop = false;
            this.txtMaNXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaNXB.TrailingIcon = null;
            this.txtMaNXB.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(308, 41);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(129, 19);
            this.materialLabel2.TabIndex = 39;
            this.materialLabel2.Text = "Tên nhà xuất bản:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.AnimateReadOnly = false;
            this.txtDiaChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDiaChi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiaChi.Depth = 0;
            this.txtDiaChi.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.HideSelection = true;
            this.txtDiaChi.LeadingIcon = null;
            this.txtDiaChi.Location = new System.Drawing.Point(151, 90);
            this.txtDiaChi.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtDiaChi.MaxLength = 32767;
            this.txtDiaChi.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtDiaChi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PrefixSuffixText = null;
            this.txtDiaChi.ReadOnly = false;
            this.txtDiaChi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.SelectionLength = 0;
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.ShortcutsEnabled = true;
            this.txtDiaChi.Size = new System.Drawing.Size(536, 48);
            this.txtDiaChi.TabIndex = 54;
            this.txtDiaChi.TabStop = false;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiaChi.TrailingIcon = null;
            this.txtDiaChi.UseSystemPasswordChar = false;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = null;
            this.btnThem.Location = new System.Drawing.Point(274, 756);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnThem.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(80, 36);
            this.btnThem.TabIndex = 91;
            this.btnThem.Text = "Thêm";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(475, 756);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnXoa.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(80, 36);
            this.btnXoa.TabIndex = 93;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnHuy.Location = new System.Drawing.Point(687, 756);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnHuy.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(80, 36);
            this.btnHuy.TabIndex = 95;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = false;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.AutoSize = false;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(579, 756);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnLuu.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(80, 36);
            this.btnLuu.TabIndex = 94;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.txtTimKiem.Size = new System.Drawing.Size(860, 48);
            this.txtTimKiem.TabIndex = 96;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TrailingIcon = null;
            this.txtTimKiem.UseSystemPasswordChar = false;
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
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
            this.btnTimKiem.Location = new System.Drawing.Point(904, 27);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 12, 4, 6);
            this.btnTimKiem.MaximumSize = new System.Drawing.Size(96, 40);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(0, 48);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.btnTimKiem.Size = new System.Drawing.Size(96, 48);
            this.btnTimKiem.TabIndex = 97;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnSua.Location = new System.Drawing.Point(373, 756);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnSua.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(80, 36);
            this.btnSua.TabIndex = 92;
            this.btnSua.Text = "Sửa";
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // listViewNXB
            // 
            this.listViewNXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewNXB.AutoSizeTable = false;
            this.listViewNXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewNXB.CheckBoxes = true;
            this.listViewNXB.Depth = 0;
            this.listViewNXB.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewNXB.FullRowSelect = true;
            this.listViewNXB.HideSelection = false;
            this.listViewNXB.Location = new System.Drawing.Point(27, 342);
            this.listViewNXB.MinimumSize = new System.Drawing.Size(820, 378);
            this.listViewNXB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewNXB.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewNXB.Name = "listViewNXB";
            this.listViewNXB.OwnerDraw = true;
            this.listViewNXB.Size = new System.Drawing.Size(973, 389);
            this.listViewNXB.TabIndex = 90;
            this.listViewNXB.UseCompatibleStateImageBehavior = false;
            this.listViewNXB.View = System.Windows.Forms.View.Details;
            this.listViewNXB.SelectedIndexChanged += new System.EventHandler(this.listViewNXB_SelectedIndexChanged);
            // 
            // frmNhaXuatBan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.listViewNXB);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmNhaXuatBan";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 6, 6);
            this.Text = "frmNhaXuatBan";
            this.Load += new System.EventHandler(this.frmNhaXuatBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txtTenNXB;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaNXB;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private MaterialSkin.Controls.MaterialListView listViewNXB;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtDiaChi;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSDT;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtFax;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}