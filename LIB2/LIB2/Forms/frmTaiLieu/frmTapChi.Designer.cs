namespace LIB2.Forms
{
    partial class frmTapChi
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cboSoLuong = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSoTrang = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNgayXB = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaTL = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cboMaLoai = new MaterialSkin.Controls.MaterialComboBox();
            this.txtTenTL = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSoLuong = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboMaNN = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cboMaNXB = new MaterialSkin.Controls.MaterialComboBox();
            this.txtGia = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSoRa = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboMaKho = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.cboTimKiem = new MaterialSkin.Controls.MaterialComboBox();
            this.chkSoLuong = new MaterialSkin.Controls.MaterialCheckbox();
            this.listViewTL = new MaterialSkin.Controls.MaterialListView();
            this.cboNgayXB = new MaterialSkin.Controls.MaterialComboBox();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.chkNgayXB = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // cboSoLuong
            // 
            this.cboSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSoLuong.AutoResize = false;
            this.cboSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSoLuong.Depth = 0;
            this.cboSoLuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboSoLuong.DropDownHeight = 174;
            this.cboSoLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSoLuong.DropDownWidth = 121;
            this.cboSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboSoLuong.FormattingEnabled = true;
            this.cboSoLuong.IntegralHeight = false;
            this.cboSoLuong.ItemHeight = 43;
            this.cboSoLuong.Location = new System.Drawing.Point(519, 403);
            this.cboSoLuong.MaxDropDownItems = 4;
            this.cboSoLuong.MouseState = MaterialSkin.MouseState.OUT;
            this.cboSoLuong.Name = "cboSoLuong";
            this.cboSoLuong.Size = new System.Drawing.Size(155, 49);
            this.cboSoLuong.StartIndex = 0;
            this.cboSoLuong.TabIndex = 148;
            this.cboSoLuong.SelectedIndexChanged += new System.EventHandler(this.cboSoLuong_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.txtSoTrang);
            this.groupBox1.Controls.Add(this.txtNgayXB);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtMaTL);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.cboMaLoai);
            this.groupBox1.Controls.Add(this.txtTenTL);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.cboMaNN);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.cboMaNXB);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.txtSoRa);
            this.groupBox1.Controls.Add(this.cboMaKho);
            this.groupBox1.Controls.Add(this.materialLabel10);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Location = new System.Drawing.Point(27, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 297);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(553, 236);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(65, 19);
            this.materialLabel3.TabIndex = 132;
            this.materialLabel3.Text = "Số trang:";
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoTrang.AnimateReadOnly = false;
            this.txtSoTrang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoTrang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoTrang.Depth = 0;
            this.txtSoTrang.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTrang.HideSelection = true;
            this.txtSoTrang.LeadingIcon = null;
            this.txtSoTrang.Location = new System.Drawing.Point(624, 222);
            this.txtSoTrang.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtSoTrang.MaxLength = 32767;
            this.txtSoTrang.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtSoTrang.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.PasswordChar = '\0';
            this.txtSoTrang.PrefixSuffixText = null;
            this.txtSoTrang.ReadOnly = false;
            this.txtSoTrang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoTrang.SelectedText = "";
            this.txtSoTrang.SelectionLength = 0;
            this.txtSoTrang.SelectionStart = 0;
            this.txtSoTrang.ShortcutsEnabled = true;
            this.txtSoTrang.Size = new System.Drawing.Size(116, 48);
            this.txtSoTrang.TabIndex = 133;
            this.txtSoTrang.TabStop = false;
            this.txtSoTrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoTrang.TrailingIcon = null;
            this.txtSoTrang.UseSystemPasswordChar = false;
            this.txtSoTrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTrang_KeyPress);
            // 
            // txtNgayXB
            // 
            this.txtNgayXB.AllowPromptAsInput = true;
            this.txtNgayXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNgayXB.AnimateReadOnly = false;
            this.txtNgayXB.AsciiOnly = false;
            this.txtNgayXB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNgayXB.BeepOnError = false;
            this.txtNgayXB.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNgayXB.Depth = 0;
            this.txtNgayXB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNgayXB.HidePromptOnLeave = false;
            this.txtNgayXB.HideSelection = true;
            this.txtNgayXB.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtNgayXB.LeadingIcon = null;
            this.txtNgayXB.Location = new System.Drawing.Point(126, 93);
            this.txtNgayXB.Mask = "00/00/0000";
            this.txtNgayXB.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtNgayXB.MaxLength = 32767;
            this.txtNgayXB.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtNgayXB.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNgayXB.Name = "txtNgayXB";
            this.txtNgayXB.PasswordChar = '\0';
            this.txtNgayXB.PrefixSuffixText = null;
            this.txtNgayXB.PromptChar = '_';
            this.txtNgayXB.ReadOnly = false;
            this.txtNgayXB.RejectInputOnFirstFailure = false;
            this.txtNgayXB.ResetOnPrompt = true;
            this.txtNgayXB.ResetOnSpace = true;
            this.txtNgayXB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNgayXB.SelectedText = "";
            this.txtNgayXB.SelectionLength = 0;
            this.txtNgayXB.SelectionStart = 0;
            this.txtNgayXB.ShortcutsEnabled = true;
            this.txtNgayXB.Size = new System.Drawing.Size(150, 48);
            this.txtNgayXB.SkipLiterals = true;
            this.txtNgayXB.TabIndex = 131;
            this.txtNgayXB.TabStop = false;
            this.txtNgayXB.Text = "  /  /";
            this.txtNgayXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNgayXB.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNgayXB.TrailingIcon = null;
            this.txtNgayXB.UseSystemPasswordChar = false;
            this.txtNgayXB.ValidatingType = null;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(12, 109);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(108, 19);
            this.materialLabel11.TabIndex = 130;
            this.materialLabel11.Text = "Ngày xuất bản:";
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
            this.materialLabel8.Location = new System.Drawing.Point(17, 173);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(103, 19);
            this.materialLabel8.TabIndex = 128;
            this.materialLabel8.Text = "Loại ấn phẩm:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(341, 43);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 85;
            this.materialLabel2.Text = "Tiêu đề:";
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
            this.cboMaLoai.TabIndex = 127;
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
            this.txtTenTL.Location = new System.Drawing.Point(403, 29);
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
            this.txtTenTL.Size = new System.Drawing.Size(552, 48);
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
            this.materialLabel7.Location = new System.Drawing.Point(764, 236);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(69, 19);
            this.materialLabel7.TabIndex = 101;
            this.materialLabel7.Text = "Số lượng:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(91, 236);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(29, 19);
            this.materialLabel6.TabIndex = 102;
            this.materialLabel6.Text = "Giá:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.AnimateReadOnly = false;
            this.txtSoLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoLuong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoLuong.Depth = 0;
            this.txtSoLuong.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.HideSelection = true;
            this.txtSoLuong.LeadingIcon = null;
            this.txtSoLuong.Location = new System.Drawing.Point(839, 222);
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
            this.txtSoLuong.Size = new System.Drawing.Size(116, 48);
            this.txtSoLuong.TabIndex = 103;
            this.txtSoLuong.TabStop = false;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoLuong.TrailingIcon = null;
            this.txtSoLuong.UseSystemPasswordChar = false;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // cboMaNN
            // 
            this.cboMaNN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboMaNN.AutoResize = false;
            this.cboMaNN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaNN.Depth = 0;
            this.cboMaNN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboMaNN.DropDownHeight = 174;
            this.cboMaNN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNN.DropDownWidth = 121;
            this.cboMaNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboMaNN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboMaNN.FormattingEnabled = true;
            this.cboMaNN.IntegralHeight = false;
            this.cboMaNN.ItemHeight = 43;
            this.cboMaNN.Location = new System.Drawing.Point(403, 157);
            this.cboMaNN.MaxDropDownItems = 4;
            this.cboMaNN.MinimumSize = new System.Drawing.Size(150, 0);
            this.cboMaNN.MouseState = MaterialSkin.MouseState.OUT;
            this.cboMaNN.Name = "cboMaNN";
            this.cboMaNN.Size = new System.Drawing.Size(158, 49);
            this.cboMaNN.StartIndex = 0;
            this.cboMaNN.TabIndex = 110;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(324, 173);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 19);
            this.materialLabel4.TabIndex = 111;
            this.materialLabel4.Text = "Ngôn ngữ:";
            // 
            // cboMaNXB
            // 
            this.cboMaNXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMaNXB.AutoResize = false;
            this.cboMaNXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMaNXB.Depth = 0;
            this.cboMaNXB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboMaNXB.DropDownHeight = 174;
            this.cboMaNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNXB.DropDownWidth = 121;
            this.cboMaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboMaNXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboMaNXB.FormattingEnabled = true;
            this.cboMaNXB.IntegralHeight = false;
            this.cboMaNXB.ItemHeight = 43;
            this.cboMaNXB.Location = new System.Drawing.Point(403, 92);
            this.cboMaNXB.MaxDropDownItems = 4;
            this.cboMaNXB.MinimumSize = new System.Drawing.Size(150, 0);
            this.cboMaNXB.MouseState = MaterialSkin.MouseState.OUT;
            this.cboMaNXB.Name = "cboMaNXB";
            this.cboMaNXB.Size = new System.Drawing.Size(552, 49);
            this.cboMaNXB.StartIndex = 0;
            this.cboMaNXB.TabIndex = 112;
            // 
            // txtGia
            // 
            this.txtGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGia.AnimateReadOnly = false;
            this.txtGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtGia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGia.Depth = 0;
            this.txtGia.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.HideSelection = true;
            this.txtGia.LeadingIcon = null;
            this.txtGia.Location = new System.Drawing.Point(126, 222);
            this.txtGia.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtGia.MaxLength = 32767;
            this.txtGia.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtGia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.PrefixSuffixText = null;
            this.txtGia.ReadOnly = false;
            this.txtGia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGia.SelectedText = "";
            this.txtGia.SelectionLength = 0;
            this.txtGia.SelectionStart = 0;
            this.txtGia.ShortcutsEnabled = true;
            this.txtGia.Size = new System.Drawing.Size(150, 48);
            this.txtGia.TabIndex = 119;
            this.txtGia.TabStop = false;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGia.TrailingIcon = null;
            this.txtGia.UseSystemPasswordChar = false;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(297, 108);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(100, 19);
            this.materialLabel5.TabIndex = 113;
            this.materialLabel5.Text = "Nhà xuất bản:";
            // 
            // txtSoRa
            // 
            this.txtSoRa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoRa.AnimateReadOnly = false;
            this.txtSoRa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoRa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoRa.Depth = 0;
            this.txtSoRa.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoRa.HideSelection = true;
            this.txtSoRa.LeadingIcon = null;
            this.txtSoRa.Location = new System.Drawing.Point(403, 222);
            this.txtSoRa.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtSoRa.MaxLength = 32767;
            this.txtSoRa.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtSoRa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoRa.Name = "txtSoRa";
            this.txtSoRa.PasswordChar = '\0';
            this.txtSoRa.PrefixSuffixText = null;
            this.txtSoRa.ReadOnly = false;
            this.txtSoRa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoRa.SelectedText = "";
            this.txtSoRa.SelectionLength = 0;
            this.txtSoRa.SelectionStart = 0;
            this.txtSoRa.ShortcutsEnabled = true;
            this.txtSoRa.Size = new System.Drawing.Size(116, 48);
            this.txtSoRa.TabIndex = 118;
            this.txtSoRa.TabStop = false;
            this.txtSoRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoRa.TrailingIcon = null;
            this.txtSoRa.UseSystemPasswordChar = false;
            this.txtSoRa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoRa_KeyPress);
            // 
            // cboMaKho
            // 
            this.cboMaKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cboMaKho.Location = new System.Drawing.Point(624, 157);
            this.cboMaKho.MaxDropDownItems = 4;
            this.cboMaKho.MinimumSize = new System.Drawing.Size(110, 0);
            this.cboMaKho.MouseState = MaterialSkin.MouseState.OUT;
            this.cboMaKho.Name = "cboMaKho";
            this.cboMaKho.Size = new System.Drawing.Size(331, 49);
            this.cboMaKho.StartIndex = 0;
            this.cboMaKho.TabIndex = 115;
            // 
            // materialLabel10
            // 
            this.materialLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(355, 236);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(42, 19);
            this.materialLabel10.TabIndex = 117;
            this.materialLabel10.Text = "Số ra:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(585, 173);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(33, 19);
            this.materialLabel9.TabIndex = 116;
            this.materialLabel9.Text = "Kho:";
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
            this.cboTimKiem.TabIndex = 146;
            // 
            // chkSoLuong
            // 
            this.chkSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSoLuong.AutoSize = true;
            this.chkSoLuong.Depth = 0;
            this.chkSoLuong.Location = new System.Drawing.Point(406, 409);
            this.chkSoLuong.Margin = new System.Windows.Forms.Padding(0);
            this.chkSoLuong.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSoLuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSoLuong.Name = "chkSoLuong";
            this.chkSoLuong.ReadOnly = false;
            this.chkSoLuong.Ripple = true;
            this.chkSoLuong.Size = new System.Drawing.Size(99, 37);
            this.chkSoLuong.TabIndex = 150;
            this.chkSoLuong.Text = "Số lượng";
            this.chkSoLuong.UseVisualStyleBackColor = true;
            this.chkSoLuong.CheckedChanged += new System.EventHandler(this.chkSoLuong_CheckedChanged);
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
            this.listViewTL.Location = new System.Drawing.Point(27, 469);
            this.listViewTL.MinimumSize = new System.Drawing.Size(820, 200);
            this.listViewTL.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewTL.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewTL.Name = "listViewTL";
            this.listViewTL.OwnerDraw = true;
            this.listViewTL.Size = new System.Drawing.Size(973, 263);
            this.listViewTL.TabIndex = 138;
            this.listViewTL.UseCompatibleStateImageBehavior = false;
            this.listViewTL.View = System.Windows.Forms.View.Details;
            this.listViewTL.SelectedIndexChanged += new System.EventHandler(this.listViewTL_SelectedIndexChanged);
            // 
            // cboNgayXB
            // 
            this.cboNgayXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNgayXB.AutoResize = false;
            this.cboNgayXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboNgayXB.Depth = 0;
            this.cboNgayXB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboNgayXB.DropDownHeight = 174;
            this.cboNgayXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgayXB.DropDownWidth = 121;
            this.cboNgayXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboNgayXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboNgayXB.FormattingEnabled = true;
            this.cboNgayXB.IntegralHeight = false;
            this.cboNgayXB.ItemHeight = 43;
            this.cboNgayXB.Location = new System.Drawing.Point(845, 403);
            this.cboNgayXB.MaxDropDownItems = 4;
            this.cboNgayXB.MouseState = MaterialSkin.MouseState.OUT;
            this.cboNgayXB.Name = "cboNgayXB";
            this.cboNgayXB.Size = new System.Drawing.Size(155, 49);
            this.cboNgayXB.StartIndex = 0;
            this.cboNgayXB.TabIndex = 149;
            this.cboNgayXB.SelectedIndexChanged += new System.EventHandler(this.cboNgayXB_SelectedIndexChanged);
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
            this.btnTimKiem.TabIndex = 145;
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
            this.txtTimKiem.TabIndex = 144;
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
            this.btnHuy.TabIndex = 143;
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
            this.btnLuu.TabIndex = 142;
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
            this.btnXoa.TabIndex = 141;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // chkNgayXB
            // 
            this.chkNgayXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNgayXB.AutoSize = true;
            this.chkNgayXB.Depth = 0;
            this.chkNgayXB.Location = new System.Drawing.Point(694, 409);
            this.chkNgayXB.Margin = new System.Windows.Forms.Padding(0);
            this.chkNgayXB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkNgayXB.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkNgayXB.Name = "chkNgayXB";
            this.chkNgayXB.ReadOnly = false;
            this.chkNgayXB.Ripple = true;
            this.chkNgayXB.Size = new System.Drawing.Size(138, 37);
            this.chkNgayXB.TabIndex = 151;
            this.chkNgayXB.Text = "Ngày xuất bản";
            this.chkNgayXB.UseVisualStyleBackColor = true;
            this.chkNgayXB.CheckedChanged += new System.EventHandler(this.chkNgayXB_CheckedChanged);
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
            this.btnThem.TabIndex = 139;
            this.btnThem.Text = "Thêm";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnSua.TabIndex = 140;
            this.btnSua.Text = "Sửa";
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmTapChi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.cboSoLuong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.chkSoLuong);
            this.Controls.Add(this.listViewTL);
            this.Controls.Add(this.cboNgayXB);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.chkNgayXB);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmTapChi";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 6, 6);
            this.Text = "frmTapChi";
            this.Load += new System.EventHandler(this.frmTapChi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cboSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaTL;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cboMaLoai;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenTL;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoLuong;
        private MaterialSkin.Controls.MaterialComboBox cboMaNN;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cboMaNXB;
        private MaterialSkin.Controls.MaterialTextBox2 txtGia;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoRa;
        private MaterialSkin.Controls.MaterialComboBox cboMaKho;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialComboBox cboTimKiem;
        private MaterialSkin.Controls.MaterialCheckbox chkSoLuong;
        private MaterialSkin.Controls.MaterialListView listViewTL;
        private MaterialSkin.Controls.MaterialComboBox cboNgayXB;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialCheckbox chkNgayXB;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNgayXB;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoTrang;
    }
}