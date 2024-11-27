namespace LIB2.Forms
{
    partial class frmKhoaLuan
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
            this.txtNamHT = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTomTat = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cboMaNganh = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNguoiHD = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNguoiTH = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaTL = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cboMaKho = new MaterialSkin.Controls.MaterialComboBox();
            this.txtTenTL = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSoLuong = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cboTimKiem = new MaterialSkin.Controls.MaterialComboBox();
            this.listViewTL = new MaterialSkin.Controls.MaterialListView();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.cboMaLoai = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNamHT
            // 
            this.txtNamHT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNamHT.AnimateReadOnly = false;
            this.txtNamHT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNamHT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNamHT.Depth = 0;
            this.txtNamHT.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHT.HideSelection = true;
            this.txtNamHT.LeadingIcon = null;
            this.txtNamHT.Location = new System.Drawing.Point(126, 93);
            this.txtNamHT.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtNamHT.MaxLength = 32767;
            this.txtNamHT.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtNamHT.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNamHT.Name = "txtNamHT";
            this.txtNamHT.PasswordChar = '\0';
            this.txtNamHT.PrefixSuffixText = null;
            this.txtNamHT.ReadOnly = false;
            this.txtNamHT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNamHT.SelectedText = "";
            this.txtNamHT.SelectionLength = 0;
            this.txtNamHT.SelectionStart = 0;
            this.txtNamHT.ShortcutsEnabled = true;
            this.txtNamHT.Size = new System.Drawing.Size(150, 48);
            this.txtNamHT.TabIndex = 141;
            this.txtNamHT.TabStop = false;
            this.txtNamHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNamHT.TrailingIcon = null;
            this.txtNamHT.UseSystemPasswordChar = false;
            this.txtNamHT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamHT_KeyPress);
            // 
            // txtTomTat
            // 
            this.txtTomTat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTomTat.AnimateReadOnly = false;
            this.txtTomTat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTomTat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTomTat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTomTat.Depth = 0;
            this.txtTomTat.HideSelection = true;
            this.txtTomTat.Location = new System.Drawing.Point(424, 222);
            this.txtTomTat.MaxLength = 32767;
            this.txtTomTat.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTomTat.Name = "txtTomTat";
            this.txtTomTat.PasswordChar = '\0';
            this.txtTomTat.ReadOnly = false;
            this.txtTomTat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTomTat.SelectedText = "";
            this.txtTomTat.SelectionLength = 0;
            this.txtTomTat.SelectionStart = 0;
            this.txtTomTat.ShortcutsEnabled = true;
            this.txtTomTat.Size = new System.Drawing.Size(531, 178);
            this.txtTomTat.TabIndex = 140;
            this.txtTomTat.TabStop = false;
            this.txtTomTat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTomTat.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(357, 238);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(61, 19);
            this.materialLabel6.TabIndex = 139;
            this.materialLabel6.Text = "Tóm tắt:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(68, 238);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 19);
            this.materialLabel3.TabIndex = 138;
            this.materialLabel3.Text = "Ngành:";
            // 
            // cboMaNganh
            // 
            this.cboMaNganh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboMaNganh.AutoResize = false;
            this.cboMaNganh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaNganh.Depth = 0;
            this.cboMaNganh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboMaNganh.DropDownHeight = 174;
            this.cboMaNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNganh.DropDownWidth = 121;
            this.cboMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboMaNganh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboMaNganh.FormattingEnabled = true;
            this.cboMaNganh.IntegralHeight = false;
            this.cboMaNganh.ItemHeight = 43;
            this.cboMaNganh.Location = new System.Drawing.Point(126, 222);
            this.cboMaNganh.MaxDropDownItems = 4;
            this.cboMaNganh.MinimumSize = new System.Drawing.Size(150, 0);
            this.cboMaNganh.MouseState = MaterialSkin.MouseState.OUT;
            this.cboMaNganh.Name = "cboMaNganh";
            this.cboMaNganh.Size = new System.Drawing.Size(150, 49);
            this.cboMaNganh.StartIndex = 0;
            this.cboMaNganh.TabIndex = 137;
            // 
            // txtNguoiHD
            // 
            this.txtNguoiHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNguoiHD.AnimateReadOnly = false;
            this.txtNguoiHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNguoiHD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNguoiHD.Depth = 0;
            this.txtNguoiHD.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiHD.HideSelection = true;
            this.txtNguoiHD.LeadingIcon = null;
            this.txtNguoiHD.Location = new System.Drawing.Point(424, 158);
            this.txtNguoiHD.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtNguoiHD.MaxLength = 32767;
            this.txtNguoiHD.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtNguoiHD.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNguoiHD.Name = "txtNguoiHD";
            this.txtNguoiHD.PasswordChar = '\0';
            this.txtNguoiHD.PrefixSuffixText = null;
            this.txtNguoiHD.ReadOnly = false;
            this.txtNguoiHD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNguoiHD.SelectedText = "";
            this.txtNguoiHD.SelectionLength = 0;
            this.txtNguoiHD.SelectionStart = 0;
            this.txtNguoiHD.ShortcutsEnabled = true;
            this.txtNguoiHD.Size = new System.Drawing.Size(531, 48);
            this.txtNguoiHD.TabIndex = 135;
            this.txtNguoiHD.TabStop = false;
            this.txtNguoiHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNguoiHD.TrailingIcon = null;
            this.txtNguoiHD.UseSystemPasswordChar = false;
            // 
            // txtNguoiTH
            // 
            this.txtNguoiTH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNguoiTH.AnimateReadOnly = false;
            this.txtNguoiTH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNguoiTH.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNguoiTH.Depth = 0;
            this.txtNguoiTH.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiTH.HideSelection = true;
            this.txtNguoiTH.LeadingIcon = null;
            this.txtNguoiTH.Location = new System.Drawing.Point(424, 93);
            this.txtNguoiTH.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtNguoiTH.MaxLength = 32767;
            this.txtNguoiTH.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtNguoiTH.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNguoiTH.Name = "txtNguoiTH";
            this.txtNguoiTH.PasswordChar = '\0';
            this.txtNguoiTH.PrefixSuffixText = null;
            this.txtNguoiTH.ReadOnly = false;
            this.txtNguoiTH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNguoiTH.SelectedText = "";
            this.txtNguoiTH.SelectionLength = 0;
            this.txtNguoiTH.SelectionStart = 0;
            this.txtNguoiTH.ShortcutsEnabled = true;
            this.txtNguoiTH.Size = new System.Drawing.Size(531, 48);
            this.txtNguoiTH.TabIndex = 134;
            this.txtNguoiTH.TabStop = false;
            this.txtNguoiTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNguoiTH.TrailingIcon = null;
            this.txtNguoiTH.UseSystemPasswordChar = false;
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
            this.btnSua.TabIndex = 164;
            this.btnSua.Text = "Sửa";
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.cboMaLoai);
            this.groupBox1.Controls.Add(this.txtNamHT);
            this.groupBox1.Controls.Add(this.txtTomTat);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.cboMaNganh);
            this.groupBox1.Controls.Add(this.txtNguoiHD);
            this.groupBox1.Controls.Add(this.txtNguoiTH);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtMaTL);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.cboMaKho);
            this.groupBox1.Controls.Add(this.txtTenTL);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Location = new System.Drawing.Point(27, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 424);
            this.groupBox1.TabIndex = 171;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(23, 109);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(97, 19);
            this.materialLabel11.TabIndex = 130;
            this.materialLabel11.Text = "Năm h.thành:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(41, 43);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 83;
            this.materialLabel1.Text = "Mã tài liệu:";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaTL.AnimateReadOnly = true;
            this.txtMaTL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaTL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaTL.Depth = 0;
            this.txtMaTL.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTL.HideSelection = true;
            this.txtMaTL.LeadingIcon = null;
            this.txtMaTL.Location = new System.Drawing.Point(126, 29);
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
            this.txtMaTL.Size = new System.Drawing.Size(150, 48);
            this.txtMaTL.TabIndex = 84;
            this.txtMaTL.TabStop = false;
            this.txtMaTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaTL.TrailingIcon = null;
            this.txtMaTL.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(87, 304);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(33, 19);
            this.materialLabel8.TabIndex = 128;
            this.materialLabel8.Text = "Kho:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(342, 43);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 85;
            this.materialLabel2.Text = "Tên đề tài:";
            // 
            // cboMaKho
            // 
            this.cboMaKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboMaKho.AutoResize = false;
            this.cboMaKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaKho.Depth = 0;
            this.cboMaKho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboMaKho.DropDownHeight = 174;
            this.cboMaKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKho.DropDownWidth = 121;
            this.cboMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboMaKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboMaKho.FormattingEnabled = true;
            this.cboMaKho.IntegralHeight = false;
            this.cboMaKho.ItemHeight = 43;
            this.cboMaKho.Location = new System.Drawing.Point(126, 288);
            this.cboMaKho.MaxDropDownItems = 4;
            this.cboMaKho.MinimumSize = new System.Drawing.Size(150, 0);
            this.cboMaKho.MouseState = MaterialSkin.MouseState.OUT;
            this.cboMaKho.Name = "cboMaKho";
            this.cboMaKho.Size = new System.Drawing.Size(150, 49);
            this.cboMaKho.StartIndex = 0;
            this.cboMaKho.TabIndex = 127;
            // 
            // txtTenTL
            // 
            this.txtTenTL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTL.AnimateReadOnly = false;
            this.txtTenTL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenTL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenTL.Depth = 0;
            this.txtTenTL.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTL.HideSelection = true;
            this.txtTenTL.LeadingIcon = null;
            this.txtTenTL.Location = new System.Drawing.Point(424, 29);
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
            this.txtTenTL.Size = new System.Drawing.Size(531, 48);
            this.txtTenTL.TabIndex = 86;
            this.txtTenTL.TabStop = false;
            this.txtTenTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenTL.TrailingIcon = null;
            this.txtTenTL.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(51, 367);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(69, 19);
            this.materialLabel7.TabIndex = 101;
            this.materialLabel7.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoLuong.AnimateReadOnly = false;
            this.txtSoLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoLuong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoLuong.Depth = 0;
            this.txtSoLuong.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.HideSelection = true;
            this.txtSoLuong.LeadingIcon = null;
            this.txtSoLuong.Location = new System.Drawing.Point(126, 352);
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
            this.txtSoLuong.Size = new System.Drawing.Size(150, 48);
            this.txtSoLuong.TabIndex = 103;
            this.txtSoLuong.TabStop = false;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoLuong.TrailingIcon = null;
            this.txtSoLuong.UseSystemPasswordChar = false;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(289, 173);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(129, 19);
            this.materialLabel4.TabIndex = 111;
            this.materialLabel4.Text = "Người hướng dẫn:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(300, 109);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(118, 19);
            this.materialLabel5.TabIndex = 113;
            this.materialLabel5.Text = "Người thực hiện:";
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
            this.cboTimKiem.TabIndex = 170;
            // 
            // listViewTL
            // 
            this.listViewTL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTL.AutoSizeTable = false;
            this.listViewTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewTL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTL.CheckBoxes = true;
            this.listViewTL.Depth = 0;
            this.listViewTL.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTL.FullRowSelect = true;
            this.listViewTL.HideSelection = false;
            this.listViewTL.Location = new System.Drawing.Point(27, 532);
            this.listViewTL.MinimumSize = new System.Drawing.Size(820, 200);
            this.listViewTL.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewTL.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewTL.Name = "listViewTL";
            this.listViewTL.OwnerDraw = true;
            this.listViewTL.Size = new System.Drawing.Size(973, 200);
            this.listViewTL.TabIndex = 162;
            this.listViewTL.UseCompatibleStateImageBehavior = false;
            this.listViewTL.View = System.Windows.Forms.View.Details;
            this.listViewTL.SelectedIndexChanged += new System.EventHandler(this.listViewTL_SelectedIndexChanged);
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
            this.btnTimKiem.TabIndex = 169;
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
            this.txtTimKiem.Size = new System.Drawing.Size(688, 48);
            this.txtTimKiem.TabIndex = 168;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TrailingIcon = null;
            this.txtTimKiem.UseSystemPasswordChar = false;
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
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
            this.btnHuy.TabIndex = 167;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = false;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnThem.TabIndex = 163;
            this.btnThem.Text = "Thêm";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnLuu.TabIndex = 166;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnXoa.TabIndex = 165;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(17, 173);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(103, 19);
            this.materialLabel9.TabIndex = 143;
            this.materialLabel9.Text = "Loại ấn phẩm:";
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboMaLoai.AutoResize = false;
            this.cboMaLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaLoai.Depth = 0;
            this.cboMaLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboMaLoai.DropDownHeight = 174;
            this.cboMaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLoai.DropDownWidth = 121;
            this.cboMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboMaLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.IntegralHeight = false;
            this.cboMaLoai.ItemHeight = 43;
            this.cboMaLoai.Location = new System.Drawing.Point(126, 157);
            this.cboMaLoai.MaxDropDownItems = 4;
            this.cboMaLoai.MinimumSize = new System.Drawing.Size(150, 0);
            this.cboMaLoai.MouseState = MaterialSkin.MouseState.OUT;
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(150, 49);
            this.cboMaLoai.StartIndex = 0;
            this.cboMaLoai.TabIndex = 142;
            // 
            // frmKhoaLuan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.listViewTL);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmKhoaLuan";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 6, 6);
            this.Text = "frmKhoaLuan";
            this.Load += new System.EventHandler(this.frmKhoaLuan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtNamHT;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTomTat;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cboMaNganh;
        private MaterialSkin.Controls.MaterialTextBox2 txtNguoiHD;
        private MaterialSkin.Controls.MaterialTextBox2 txtNguoiTH;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaTL;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cboMaKho;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenTL;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoLuong;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cboTimKiem;
        private MaterialSkin.Controls.MaterialListView listViewTL;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialComboBox cboMaLoai;
    }
}