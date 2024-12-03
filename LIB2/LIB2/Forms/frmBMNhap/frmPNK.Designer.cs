namespace LIB2.Forms
{
    partial class frmPNK
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
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNgayLap = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaPNK = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaNVLap = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboTimKiem = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDonGia = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNguon = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNgayDuyet = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtMaNVDuyet = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSoLuong = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenTL = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.listViewPNK = new MaterialSkin.Controls.MaterialListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaTL = new MaterialSkin.Controls.MaterialButton();
            this.btnThemTL = new MaterialSkin.Controls.MaterialButton();
            this.txtMaTL = new MaterialSkin.Controls.MaterialTextBox2();
            this.listViewCTPNK = new MaterialSkin.Controls.MaterialListView();
            this.btnKhongDuyet = new MaterialSkin.Controls.MaterialButton();
            this.btnDuyet = new MaterialSkin.Controls.MaterialButton();
            this.btnIn = new MaterialSkin.Controls.MaterialButton();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(312, 108);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(68, 19);
            this.materialLabel11.TabIndex = 144;
            this.materialLabel11.Text = "Ngày lập:";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.AllowPromptAsInput = true;
            this.txtNgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNgayLap.AnimateReadOnly = false;
            this.txtNgayLap.AsciiOnly = false;
            this.txtNgayLap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNgayLap.BeepOnError = false;
            this.txtNgayLap.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNgayLap.Depth = 0;
            this.txtNgayLap.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNgayLap.HidePromptOnLeave = false;
            this.txtNgayLap.HideSelection = true;
            this.txtNgayLap.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtNgayLap.LeadingIcon = null;
            this.txtNgayLap.Location = new System.Drawing.Point(385, 92);
            this.txtNgayLap.Mask = "00/00/0000";
            this.txtNgayLap.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtNgayLap.MaxLength = 32767;
            this.txtNgayLap.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtNgayLap.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.PasswordChar = '\0';
            this.txtNgayLap.PrefixSuffixText = null;
            this.txtNgayLap.PromptChar = '_';
            this.txtNgayLap.ReadOnly = false;
            this.txtNgayLap.RejectInputOnFirstFailure = false;
            this.txtNgayLap.ResetOnPrompt = true;
            this.txtNgayLap.ResetOnSpace = true;
            this.txtNgayLap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNgayLap.SelectedText = "";
            this.txtNgayLap.SelectionLength = 0;
            this.txtNgayLap.SelectionStart = 0;
            this.txtNgayLap.ShortcutsEnabled = true;
            this.txtNgayLap.Size = new System.Drawing.Size(146, 48);
            this.txtNgayLap.SkipLiterals = true;
            this.txtNgayLap.TabIndex = 145;
            this.txtNgayLap.TabStop = false;
            this.txtNgayLap.Text = "  /  /";
            this.txtNgayLap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNgayLap.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNgayLap.TrailingIcon = null;
            this.txtNgayLap.UseSystemPasswordChar = false;
            this.txtNgayLap.ValidatingType = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(24, 44);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 19);
            this.materialLabel1.TabIndex = 83;
            this.materialLabel1.Text = "Mã phiếu nhập:";
            // 
            // txtMaPNK
            // 
            this.txtMaPNK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaPNK.AnimateReadOnly = true;
            this.txtMaPNK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaPNK.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaPNK.Depth = 0;
            this.txtMaPNK.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPNK.HideSelection = true;
            this.txtMaPNK.LeadingIcon = null;
            this.txtMaPNK.Location = new System.Drawing.Point(140, 29);
            this.txtMaPNK.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaPNK.MaxLength = 32767;
            this.txtMaPNK.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaPNK.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaPNK.Name = "txtMaPNK";
            this.txtMaPNK.PasswordChar = '\0';
            this.txtMaPNK.PrefixSuffixText = null;
            this.txtMaPNK.ReadOnly = false;
            this.txtMaPNK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaPNK.SelectedText = "";
            this.txtMaPNK.SelectionLength = 0;
            this.txtMaPNK.SelectionStart = 0;
            this.txtMaPNK.ShortcutsEnabled = true;
            this.txtMaPNK.Size = new System.Drawing.Size(141, 48);
            this.txtMaPNK.TabIndex = 84;
            this.txtMaPNK.TabStop = false;
            this.txtMaPNK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaPNK.TrailingIcon = null;
            this.txtMaPNK.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(33, 108);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(102, 19);
            this.materialLabel5.TabIndex = 97;
            this.materialLabel5.Text = "Nhân viên lập:";
            // 
            // txtMaNVLap
            // 
            this.txtMaNVLap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaNVLap.AnimateReadOnly = true;
            this.txtMaNVLap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaNVLap.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaNVLap.Depth = 0;
            this.txtMaNVLap.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNVLap.HideSelection = true;
            this.txtMaNVLap.LeadingIcon = null;
            this.txtMaNVLap.Location = new System.Drawing.Point(140, 92);
            this.txtMaNVLap.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaNVLap.MaxLength = 32767;
            this.txtMaNVLap.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaNVLap.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaNVLap.Name = "txtMaNVLap";
            this.txtMaNVLap.PasswordChar = '\0';
            this.txtMaNVLap.PrefixSuffixText = null;
            this.txtMaNVLap.ReadOnly = false;
            this.txtMaNVLap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaNVLap.SelectedText = "";
            this.txtMaNVLap.SelectionLength = 0;
            this.txtMaNVLap.SelectionStart = 0;
            this.txtMaNVLap.ShortcutsEnabled = true;
            this.txtMaNVLap.Size = new System.Drawing.Size(141, 48);
            this.txtMaNVLap.TabIndex = 146;
            this.txtMaNVLap.TabStop = false;
            this.txtMaNVLap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaNVLap.TrailingIcon = null;
            this.txtMaNVLap.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(31, 44);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(79, 19);
            this.materialLabel8.TabIndex = 139;
            this.materialLabel8.Text = "Mã tài liệu:";
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
            this.txtTimKiem.Size = new System.Drawing.Size(688, 48);
            this.txtTimKiem.TabIndex = 206;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TrailingIcon = null;
            this.txtTimKiem.UseSystemPasswordChar = false;
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
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
            this.cboTimKiem.Location = new System.Drawing.Point(731, 26);
            this.cboTimKiem.MaxDropDownItems = 4;
            this.cboTimKiem.MinimumSize = new System.Drawing.Size(150, 0);
            this.cboTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(158, 49);
            this.cboTimKiem.StartIndex = 0;
            this.cboTimKiem.TabIndex = 208;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.AnimateReadOnly = true;
            this.txtDonGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDonGia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDonGia.Depth = 0;
            this.txtDonGia.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.HideSelection = true;
            this.txtDonGia.LeadingIcon = null;
            this.txtDonGia.Location = new System.Drawing.Point(266, 158);
            this.txtDonGia.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtDonGia.MaxLength = 32767;
            this.txtDonGia.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtDonGia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.PrefixSuffixText = null;
            this.txtDonGia.ReadOnly = false;
            this.txtDonGia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.SelectionLength = 0;
            this.txtDonGia.SelectionStart = 0;
            this.txtDonGia.ShortcutsEnabled = true;
            this.txtDonGia.Size = new System.Drawing.Size(108, 48);
            this.txtDonGia.TabIndex = 152;
            this.txtDonGia.TabStop = false;
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDonGia.TrailingIcon = null;
            this.txtDonGia.UseSystemPasswordChar = false;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(200, 174);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(60, 19);
            this.materialLabel4.TabIndex = 151;
            this.materialLabel4.Text = "Đơn giá:";
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
            this.btnTimKiem.Location = new System.Drawing.Point(905, 27);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 12, 4, 6);
            this.btnTimKiem.MaximumSize = new System.Drawing.Size(96, 40);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(0, 48);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.btnTimKiem.Size = new System.Drawing.Size(96, 48);
            this.btnTimKiem.TabIndex = 207;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNguon);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.txtNgayDuyet);
            this.groupBox1.Controls.Add(this.txtMaNVDuyet);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.txtMaNVLap);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtMaPNK);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(27, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 288);
            this.groupBox1.TabIndex = 204;
            this.groupBox1.TabStop = false;
            // 
            // cboNguon
            // 
            this.cboNguon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboNguon.AutoResize = false;
            this.cboNguon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboNguon.Depth = 0;
            this.cboNguon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboNguon.DropDownHeight = 174;
            this.cboNguon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguon.DropDownWidth = 121;
            this.cboNguon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboNguon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboNguon.FormattingEnabled = true;
            this.cboNguon.IntegralHeight = false;
            this.cboNguon.ItemHeight = 43;
            this.cboNguon.Location = new System.Drawing.Point(385, 29);
            this.cboNguon.MaxDropDownItems = 4;
            this.cboNguon.MinimumSize = new System.Drawing.Size(145, 0);
            this.cboNguon.MouseState = MaterialSkin.MouseState.OUT;
            this.cboNguon.Name = "cboNguon";
            this.cboNguon.Size = new System.Drawing.Size(146, 49);
            this.cboNguon.StartIndex = 0;
            this.cboNguon.TabIndex = 158;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(328, 44);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(52, 19);
            this.materialLabel9.TabIndex = 151;
            this.materialLabel9.Text = "Nguồn:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(295, 173);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(85, 19);
            this.materialLabel7.TabIndex = 149;
            this.materialLabel7.Text = "Ngày duyệt:";
            // 
            // txtNgayDuyet
            // 
            this.txtNgayDuyet.AllowPromptAsInput = true;
            this.txtNgayDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNgayDuyet.AnimateReadOnly = false;
            this.txtNgayDuyet.AsciiOnly = false;
            this.txtNgayDuyet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNgayDuyet.BeepOnError = false;
            this.txtNgayDuyet.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNgayDuyet.Depth = 0;
            this.txtNgayDuyet.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNgayDuyet.HidePromptOnLeave = false;
            this.txtNgayDuyet.HideSelection = true;
            this.txtNgayDuyet.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtNgayDuyet.LeadingIcon = null;
            this.txtNgayDuyet.Location = new System.Drawing.Point(385, 158);
            this.txtNgayDuyet.Mask = "00/00/0000";
            this.txtNgayDuyet.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtNgayDuyet.MaxLength = 32767;
            this.txtNgayDuyet.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtNgayDuyet.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNgayDuyet.Name = "txtNgayDuyet";
            this.txtNgayDuyet.PasswordChar = '\0';
            this.txtNgayDuyet.PrefixSuffixText = null;
            this.txtNgayDuyet.PromptChar = '_';
            this.txtNgayDuyet.ReadOnly = false;
            this.txtNgayDuyet.RejectInputOnFirstFailure = false;
            this.txtNgayDuyet.ResetOnPrompt = true;
            this.txtNgayDuyet.ResetOnSpace = true;
            this.txtNgayDuyet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNgayDuyet.SelectedText = "";
            this.txtNgayDuyet.SelectionLength = 0;
            this.txtNgayDuyet.SelectionStart = 0;
            this.txtNgayDuyet.ShortcutsEnabled = true;
            this.txtNgayDuyet.Size = new System.Drawing.Size(146, 48);
            this.txtNgayDuyet.SkipLiterals = true;
            this.txtNgayDuyet.TabIndex = 150;
            this.txtNgayDuyet.TabStop = false;
            this.txtNgayDuyet.Text = "  /  /";
            this.txtNgayDuyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNgayDuyet.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNgayDuyet.TrailingIcon = null;
            this.txtNgayDuyet.UseSystemPasswordChar = false;
            this.txtNgayDuyet.ValidatingType = null;
            // 
            // txtMaNVDuyet
            // 
            this.txtMaNVDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaNVDuyet.AnimateReadOnly = true;
            this.txtMaNVDuyet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaNVDuyet.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaNVDuyet.Depth = 0;
            this.txtMaNVDuyet.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNVDuyet.HideSelection = true;
            this.txtMaNVDuyet.LeadingIcon = null;
            this.txtMaNVDuyet.Location = new System.Drawing.Point(140, 158);
            this.txtMaNVDuyet.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaNVDuyet.MaxLength = 32767;
            this.txtMaNVDuyet.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaNVDuyet.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaNVDuyet.Name = "txtMaNVDuyet";
            this.txtMaNVDuyet.PasswordChar = '\0';
            this.txtMaNVDuyet.PrefixSuffixText = null;
            this.txtMaNVDuyet.ReadOnly = false;
            this.txtMaNVDuyet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaNVDuyet.SelectedText = "";
            this.txtMaNVDuyet.SelectionLength = 0;
            this.txtMaNVDuyet.SelectionStart = 0;
            this.txtMaNVDuyet.ShortcutsEnabled = true;
            this.txtMaNVDuyet.Size = new System.Drawing.Size(141, 48);
            this.txtMaNVDuyet.TabIndex = 148;
            this.txtMaNVDuyet.TabStop = false;
            this.txtMaNVDuyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaNVDuyet.TrailingIcon = null;
            this.txtMaNVDuyet.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(16, 173);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(119, 19);
            this.materialLabel6.TabIndex = 147;
            this.materialLabel6.Text = "Nhân viên duyệt:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoLuong.AnimateReadOnly = true;
            this.txtSoLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoLuong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoLuong.Depth = 0;
            this.txtSoLuong.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.HideSelection = true;
            this.txtSoLuong.LeadingIcon = null;
            this.txtSoLuong.Location = new System.Drawing.Point(116, 158);
            this.txtSoLuong.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtSoLuong.MaxLength = 32767;
            this.txtSoLuong.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtSoLuong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.PrefixSuffixText = null;
            this.txtSoLuong.ReadOnly = false;
            this.txtSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.SelectionLength = 0;
            this.txtSoLuong.SelectionStart = 0;
            this.txtSoLuong.ShortcutsEnabled = true;
            this.txtSoLuong.Size = new System.Drawing.Size(69, 48);
            this.txtSoLuong.TabIndex = 150;
            this.txtSoLuong.TabStop = false;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoLuong.TrailingIcon = null;
            this.txtSoLuong.UseSystemPasswordChar = false;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(41, 173);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 19);
            this.materialLabel3.TabIndex = 149;
            this.materialLabel3.Text = "Số lượng:";
            // 
            // txtTenTL
            // 
            this.txtTenTL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTL.AnimateReadOnly = true;
            this.txtTenTL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenTL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenTL.Depth = 0;
            this.txtTenTL.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTL.HideSelection = true;
            this.txtTenTL.LeadingIcon = null;
            this.txtTenTL.Location = new System.Drawing.Point(116, 92);
            this.txtTenTL.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtTenTL.MaxLength = 32767;
            this.txtTenTL.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtTenTL.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.PasswordChar = '\0';
            this.txtTenTL.PrefixSuffixText = null;
            this.txtTenTL.ReadOnly = false;
            this.txtTenTL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenTL.SelectedText = "";
            this.txtTenTL.SelectionLength = 0;
            this.txtTenTL.SelectionStart = 0;
            this.txtTenTL.ShortcutsEnabled = true;
            this.txtTenTL.Size = new System.Drawing.Size(258, 48);
            this.txtTenTL.TabIndex = 148;
            this.txtTenTL.TabStop = false;
            this.txtTenTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenTL.TrailingIcon = null;
            this.txtTenTL.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(27, 108);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 147;
            this.materialLabel2.Text = "Tên tài liệu:";
            // 
            // listViewPNK
            // 
            this.listViewPNK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewPNK.AutoSizeTable = false;
            this.listViewPNK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewPNK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPNK.CheckBoxes = true;
            this.listViewPNK.Depth = 0;
            this.listViewPNK.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPNK.FullRowSelect = true;
            this.listViewPNK.HideSelection = false;
            this.listViewPNK.Location = new System.Drawing.Point(27, 400);
            this.listViewPNK.MinimumSize = new System.Drawing.Size(300, 200);
            this.listViewPNK.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewPNK.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewPNK.Name = "listViewPNK";
            this.listViewPNK.OwnerDraw = true;
            this.listViewPNK.Size = new System.Drawing.Size(475, 332);
            this.listViewPNK.TabIndex = 214;
            this.listViewPNK.UseCompatibleStateImageBehavior = false;
            this.listViewPNK.View = System.Windows.Forms.View.Details;
            this.listViewPNK.SelectedIndexChanged += new System.EventHandler(this.listViewPNK_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnXoaTL);
            this.groupBox3.Controls.Add(this.btnThemTL);
            this.groupBox3.Controls.Add(this.txtDonGia);
            this.groupBox3.Controls.Add(this.materialLabel4);
            this.groupBox3.Controls.Add(this.txtSoLuong);
            this.groupBox3.Controls.Add(this.materialLabel3);
            this.groupBox3.Controls.Add(this.txtTenTL);
            this.groupBox3.Controls.Add(this.materialLabel2);
            this.groupBox3.Controls.Add(this.txtMaTL);
            this.groupBox3.Controls.Add(this.materialLabel8);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(601, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 288);
            this.groupBox3.TabIndex = 205;
            this.groupBox3.TabStop = false;
            // 
            // btnXoaTL
            // 
            this.btnXoaTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaTL.AutoSize = false;
            this.btnXoaTL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaTL.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaTL.Depth = 0;
            this.btnXoaTL.DrawShadows = false;
            this.btnXoaTL.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTL.HighEmphasis = true;
            this.btnXoaTL.Icon = null;
            this.btnXoaTL.Location = new System.Drawing.Point(266, 229);
            this.btnXoaTL.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaTL.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnXoaTL.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnXoaTL.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaTL.Name = "btnXoaTL";
            this.btnXoaTL.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaTL.Size = new System.Drawing.Size(108, 36);
            this.btnXoaTL.TabIndex = 168;
            this.btnXoaTL.Text = "Xoá tài liệu";
            this.btnXoaTL.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoaTL.UseAccentColor = false;
            this.btnXoaTL.UseVisualStyleBackColor = true;
            this.btnXoaTL.Click += new System.EventHandler(this.btnXoaTL_Click);
            // 
            // btnThemTL
            // 
            this.btnThemTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemTL.AutoSize = false;
            this.btnThemTL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemTL.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemTL.Depth = 0;
            this.btnThemTL.DrawShadows = false;
            this.btnThemTL.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTL.HighEmphasis = true;
            this.btnThemTL.Icon = null;
            this.btnThemTL.Location = new System.Drawing.Point(142, 229);
            this.btnThemTL.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemTL.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnThemTL.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnThemTL.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemTL.Name = "btnThemTL";
            this.btnThemTL.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemTL.Size = new System.Drawing.Size(116, 36);
            this.btnThemTL.TabIndex = 167;
            this.btnThemTL.Text = "Thêm tài liệu";
            this.btnThemTL.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemTL.UseAccentColor = false;
            this.btnThemTL.UseVisualStyleBackColor = true;
            this.btnThemTL.Click += new System.EventHandler(this.btnThemTL_Click);
            // 
            // txtMaTL
            // 
            this.txtMaTL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaTL.AnimateReadOnly = true;
            this.txtMaTL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaTL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaTL.Depth = 0;
            this.txtMaTL.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTL.HideSelection = true;
            this.txtMaTL.LeadingIcon = null;
            this.txtMaTL.Location = new System.Drawing.Point(116, 29);
            this.txtMaTL.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaTL.MaxLength = 32767;
            this.txtMaTL.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaTL.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.PasswordChar = '\0';
            this.txtMaTL.PrefixSuffixText = null;
            this.txtMaTL.ReadOnly = false;
            this.txtMaTL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaTL.SelectedText = "";
            this.txtMaTL.SelectionLength = 0;
            this.txtMaTL.SelectionStart = 0;
            this.txtMaTL.ShortcutsEnabled = true;
            this.txtMaTL.Size = new System.Drawing.Size(258, 48);
            this.txtMaTL.TabIndex = 146;
            this.txtMaTL.TabStop = false;
            this.txtMaTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaTL.TrailingIcon = null;
            this.txtMaTL.UseSystemPasswordChar = false;
            this.txtMaTL.TextChanged += new System.EventHandler(this.txtMaTL_TextChanged);
            // 
            // listViewCTPNK
            // 
            this.listViewCTPNK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCTPNK.AutoSizeTable = false;
            this.listViewCTPNK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewCTPNK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCTPNK.CheckBoxes = true;
            this.listViewCTPNK.Depth = 0;
            this.listViewCTPNK.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCTPNK.FullRowSelect = true;
            this.listViewCTPNK.HideSelection = false;
            this.listViewCTPNK.Location = new System.Drawing.Point(519, 400);
            this.listViewCTPNK.MinimumSize = new System.Drawing.Size(300, 200);
            this.listViewCTPNK.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewCTPNK.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewCTPNK.Name = "listViewCTPNK";
            this.listViewCTPNK.OwnerDraw = true;
            this.listViewCTPNK.Size = new System.Drawing.Size(482, 332);
            this.listViewCTPNK.TabIndex = 215;
            this.listViewCTPNK.UseCompatibleStateImageBehavior = false;
            this.listViewCTPNK.View = System.Windows.Forms.View.Details;
            this.listViewCTPNK.SelectedIndexChanged += new System.EventHandler(this.listViewCTPNK_SelectedIndexChanged);
            // 
            // btnKhongDuyet
            // 
            this.btnKhongDuyet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKhongDuyet.AutoSize = false;
            this.btnKhongDuyet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKhongDuyet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKhongDuyet.Depth = 0;
            this.btnKhongDuyet.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongDuyet.HighEmphasis = true;
            this.btnKhongDuyet.Icon = null;
            this.btnKhongDuyet.Location = new System.Drawing.Point(765, 755);
            this.btnKhongDuyet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKhongDuyet.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnKhongDuyet.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnKhongDuyet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKhongDuyet.Name = "btnKhongDuyet";
            this.btnKhongDuyet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKhongDuyet.Size = new System.Drawing.Size(132, 36);
            this.btnKhongDuyet.TabIndex = 237;
            this.btnKhongDuyet.Text = "Không duyệt";
            this.btnKhongDuyet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKhongDuyet.UseAccentColor = false;
            this.btnKhongDuyet.UseVisualStyleBackColor = true;
            this.btnKhongDuyet.Click += new System.EventHandler(this.btnKhongDuyet_Click);
            // 
            // btnDuyet
            // 
            this.btnDuyet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDuyet.AutoSize = false;
            this.btnDuyet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDuyet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDuyet.Depth = 0;
            this.btnDuyet.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.HighEmphasis = true;
            this.btnDuyet.Icon = null;
            this.btnDuyet.Location = new System.Drawing.Point(657, 755);
            this.btnDuyet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDuyet.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnDuyet.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnDuyet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDuyet.Size = new System.Drawing.Size(80, 36);
            this.btnDuyet.TabIndex = 236;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDuyet.UseAccentColor = false;
            this.btnDuyet.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIn.AutoSize = false;
            this.btnIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIn.Depth = 0;
            this.btnIn.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.HighEmphasis = true;
            this.btnIn.Icon = null;
            this.btnIn.Location = new System.Drawing.Point(550, 755);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIn.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnIn.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIn.Name = "btnIn";
            this.btnIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIn.Size = new System.Drawing.Size(80, 36);
            this.btnIn.TabIndex = 235;
            this.btnIn.Text = "In";
            this.btnIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIn.UseAccentColor = false;
            this.btnIn.UseVisualStyleBackColor = true;
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
            this.btnHuy.Location = new System.Drawing.Point(442, 755);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnHuy.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(80, 36);
            this.btnHuy.TabIndex = 234;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = false;
            this.btnHuy.UseVisualStyleBackColor = true;
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
            this.btnLuu.Location = new System.Drawing.Point(338, 755);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnLuu.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(80, 36);
            this.btnLuu.TabIndex = 233;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
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
            this.btnThem.Location = new System.Drawing.Point(137, 755);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnThem.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(80, 36);
            this.btnThem.TabIndex = 231;
            this.btnThem.Text = "Thêm";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
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
            this.btnXoa.Location = new System.Drawing.Point(236, 755);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnXoa.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(80, 36);
            this.btnXoa.TabIndex = 232;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // frmPNK
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.btnKhongDuyet);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewPNK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listViewCTPNK);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmPNK";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 6, 6);
            this.Text = "frmPNK";
            this.Load += new System.EventHandler(this.frmPNK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNgayLap;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaPNK;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaNVLap;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialComboBox cboTimKiem;
        private MaterialSkin.Controls.MaterialTextBox2 txtDonGia;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoLuong;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenTL;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialListView listViewPNK;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaTL;
        private MaterialSkin.Controls.MaterialListView listViewCTPNK;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNgayDuyet;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaNVDuyet;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox cboNguon;
        private MaterialSkin.Controls.MaterialButton btnXoaTL;
        private MaterialSkin.Controls.MaterialButton btnThemTL;
        private MaterialSkin.Controls.MaterialButton btnKhongDuyet;
        private MaterialSkin.Controls.MaterialButton btnDuyet;
        private MaterialSkin.Controls.MaterialButton btnIn;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnXoa;
    }
}