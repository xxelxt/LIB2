namespace LIB2.Forms
{
    partial class frmDatPhong
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
            this.listViewDP = new MaterialSkin.Controls.MaterialListView();
            this.txtMaBD = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblKhoa = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.lblLopNC = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTenBD = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSoTienPhat = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.cboViPham = new MaterialSkin.Controls.MaterialComboBox();
            this.chkViPham = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnThemVP = new MaterialSkin.Controls.MaterialButton();
            this.btnOpenList = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaBD = new MaterialSkin.Controls.MaterialButton();
            this.btnThemBD = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKiemTraPhong = new MaterialSkin.Controls.MaterialButton();
            this.rdoKhongSD = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoCoSD = new MaterialSkin.Controls.MaterialRadioButton();
            this.cboCaSuDung = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cboPhong = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaDP = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTGDat = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDP
            // 
            this.listViewDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewDP.AutoSizeTable = false;
            this.listViewDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewDP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDP.CheckBoxes = true;
            this.listViewDP.Depth = 0;
            this.listViewDP.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDP.FullRowSelect = true;
            this.listViewDP.HideSelection = false;
            this.listViewDP.Location = new System.Drawing.Point(27, 290);
            this.listViewDP.MinimumSize = new System.Drawing.Size(400, 150);
            this.listViewDP.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewDP.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewDP.Name = "listViewDP";
            this.listViewDP.OwnerDraw = true;
            this.listViewDP.Size = new System.Drawing.Size(571, 459);
            this.listViewDP.TabIndex = 187;
            this.listViewDP.UseCompatibleStateImageBehavior = false;
            this.listViewDP.View = System.Windows.Forms.View.Details;
            this.listViewDP.SelectedIndexChanged += new System.EventHandler(this.listViewDP_SelectedIndexChanged);
            // 
            // txtMaBD
            // 
            this.txtMaBD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaBD.AnimateReadOnly = true;
            this.txtMaBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaBD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaBD.Depth = 0;
            this.txtMaBD.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBD.HideSelection = true;
            this.txtMaBD.LeadingIcon = null;
            this.txtMaBD.Location = new System.Drawing.Point(133, 29);
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
            this.txtMaBD.Size = new System.Drawing.Size(236, 48);
            this.txtMaBD.TabIndex = 146;
            this.txtMaBD.TabStop = false;
            this.txtMaBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaBD.TrailingIcon = null;
            this.txtMaBD.UseSystemPasswordChar = false;
            this.txtMaBD.TextChanged += new System.EventHandler(this.txtMaBD_TextChanged);
            // 
            // lblKhoa
            // 
            this.lblKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Depth = 0;
            this.lblKhoa.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblKhoa.Location = new System.Drawing.Point(131, 179);
            this.lblKhoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(75, 19);
            this.lblKhoa.TabIndex = 159;
            this.lblKhoa.Text = "(textKhoa)";
            // 
            // materialLabel19
            // 
            this.materialLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.Location = new System.Drawing.Point(26, 179);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(38, 19);
            this.materialLabel19.TabIndex = 158;
            this.materialLabel19.Text = "Khoa";
            // 
            // lblLopNC
            // 
            this.lblLopNC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLopNC.AutoSize = true;
            this.lblLopNC.Depth = 0;
            this.lblLopNC.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLopNC.Location = new System.Drawing.Point(131, 135);
            this.lblLopNC.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLopNC.Name = "lblLopNC";
            this.lblLopNC.Size = new System.Drawing.Size(86, 19);
            this.lblLopNC.TabIndex = 157;
            this.lblLopNC.Text = "(textLopNC)";
            // 
            // materialLabel21
            // 
            this.materialLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.Location = new System.Drawing.Point(26, 135);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(95, 19);
            this.materialLabel21.TabIndex = 156;
            this.materialLabel21.Text = "Lớp niên chế:";
            // 
            // lblTenBD
            // 
            this.lblTenBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTenBD.AutoSize = true;
            this.lblTenBD.Depth = 0;
            this.lblTenBD.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTenBD.Location = new System.Drawing.Point(131, 93);
            this.lblTenBD.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTenBD.Name = "lblTenBD";
            this.lblTenBD.Size = new System.Drawing.Size(86, 19);
            this.lblTenBD.TabIndex = 149;
            this.lblTenBD.Text = "(textTenBD)";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(26, 93);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(94, 19);
            this.materialLabel7.TabIndex = 148;
            this.materialLabel7.Text = "Tên bạn đọc:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtSoTienPhat);
            this.groupBox4.Controls.Add(this.materialLabel25);
            this.groupBox4.Controls.Add(this.cboViPham);
            this.groupBox4.Controls.Add(this.chkViPham);
            this.groupBox4.Controls.Add(this.btnThemVP);
            this.groupBox4.Location = new System.Drawing.Point(610, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 225);
            this.groupBox4.TabIndex = 184;
            this.groupBox4.TabStop = false;
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
            this.txtSoTienPhat.Location = new System.Drawing.Point(128, 94);
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
            this.txtSoTienPhat.Size = new System.Drawing.Size(241, 48);
            this.txtSoTienPhat.TabIndex = 168;
            this.txtSoTienPhat.TabStop = false;
            this.txtSoTienPhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoTienPhat.TrailingIcon = null;
            this.txtSoTienPhat.UseSystemPasswordChar = false;
            // 
            // materialLabel25
            // 
            this.materialLabel25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.Location = new System.Drawing.Point(25, 106);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(90, 19);
            this.materialLabel25.TabIndex = 169;
            this.materialLabel25.Text = "Số tiền phạt:";
            // 
            // cboViPham
            // 
            this.cboViPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboViPham.AutoResize = false;
            this.cboViPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboViPham.Depth = 0;
            this.cboViPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboViPham.DropDownHeight = 174;
            this.cboViPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViPham.DropDownWidth = 121;
            this.cboViPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboViPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboViPham.FormattingEnabled = true;
            this.cboViPham.IntegralHeight = false;
            this.cboViPham.ItemHeight = 43;
            this.cboViPham.Location = new System.Drawing.Point(128, 28);
            this.cboViPham.MaxDropDownItems = 4;
            this.cboViPham.MouseState = MaterialSkin.MouseState.OUT;
            this.cboViPham.Name = "cboViPham";
            this.cboViPham.Size = new System.Drawing.Size(241, 49);
            this.cboViPham.StartIndex = 0;
            this.cboViPham.TabIndex = 166;
            this.cboViPham.SelectedIndexChanged += new System.EventHandler(this.cboViPham_SelectedIndexChanged);
            // 
            // chkViPham
            // 
            this.chkViPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkViPham.AutoSize = true;
            this.chkViPham.Depth = 0;
            this.chkViPham.Location = new System.Drawing.Point(17, 32);
            this.chkViPham.Margin = new System.Windows.Forms.Padding(0);
            this.chkViPham.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkViPham.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkViPham.Name = "chkViPham";
            this.chkViPham.ReadOnly = false;
            this.chkViPham.Ripple = true;
            this.chkViPham.Size = new System.Drawing.Size(98, 37);
            this.chkViPham.TabIndex = 167;
            this.chkViPham.Text = "Vi phạm:";
            this.chkViPham.UseVisualStyleBackColor = true;
            this.chkViPham.CheckedChanged += new System.EventHandler(this.chkViPham_CheckedChanged);
            // 
            // btnThemVP
            // 
            this.btnThemVP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemVP.AutoSize = false;
            this.btnThemVP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemVP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemVP.Depth = 0;
            this.btnThemVP.DrawShadows = false;
            this.btnThemVP.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVP.HighEmphasis = true;
            this.btnThemVP.Icon = null;
            this.btnThemVP.Location = new System.Drawing.Point(261, 168);
            this.btnThemVP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemVP.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnThemVP.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnThemVP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemVP.Name = "btnThemVP";
            this.btnThemVP.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemVP.Size = new System.Drawing.Size(108, 36);
            this.btnThemVP.TabIndex = 151;
            this.btnThemVP.Text = "Thêm vi phạm";
            this.btnThemVP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemVP.UseAccentColor = false;
            this.btnThemVP.UseVisualStyleBackColor = true;
            this.btnThemVP.Click += new System.EventHandler(this.btnThemVP_Click);
            // 
            // btnOpenList
            // 
            this.btnOpenList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenList.AutoSize = false;
            this.btnOpenList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenList.Depth = 0;
            this.btnOpenList.DrawShadows = false;
            this.btnOpenList.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenList.HighEmphasis = true;
            this.btnOpenList.Icon = null;
            this.btnOpenList.Location = new System.Drawing.Point(27, 775);
            this.btnOpenList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenList.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnOpenList.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnOpenList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenList.Name = "btnOpenList";
            this.btnOpenList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenList.Size = new System.Drawing.Size(104, 36);
            this.btnOpenList.TabIndex = 188;
            this.btnOpenList.Text = "Danh sách";
            this.btnOpenList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenList.UseAccentColor = false;
            this.btnOpenList.UseVisualStyleBackColor = true;
            this.btnOpenList.MouseCaptureChanged += new System.EventHandler(this.btnOpenList_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnXoaBD);
            this.groupBox3.Controls.Add(this.btnThemBD);
            this.groupBox3.Controls.Add(this.txtMaBD);
            this.groupBox3.Controls.Add(this.lblKhoa);
            this.groupBox3.Controls.Add(this.materialLabel19);
            this.groupBox3.Controls.Add(this.lblLopNC);
            this.groupBox3.Controls.Add(this.materialLabel21);
            this.groupBox3.Controls.Add(this.lblTenBD);
            this.groupBox3.Controls.Add(this.materialLabel7);
            this.groupBox3.Controls.Add(this.materialLabel8);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(610, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 293);
            this.groupBox3.TabIndex = 181;
            this.groupBox3.TabStop = false;
            // 
            // btnXoaBD
            // 
            this.btnXoaBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaBD.AutoSize = false;
            this.btnXoaBD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaBD.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaBD.Depth = 0;
            this.btnXoaBD.DrawShadows = false;
            this.btnXoaBD.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBD.HighEmphasis = true;
            this.btnXoaBD.Icon = null;
            this.btnXoaBD.Location = new System.Drawing.Point(241, 222);
            this.btnXoaBD.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaBD.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnXoaBD.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnXoaBD.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaBD.Name = "btnXoaBD";
            this.btnXoaBD.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaBD.Size = new System.Drawing.Size(128, 36);
            this.btnXoaBD.TabIndex = 171;
            this.btnXoaBD.Text = "Xoá bạn đọc";
            this.btnXoaBD.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoaBD.UseAccentColor = false;
            this.btnXoaBD.UseVisualStyleBackColor = true;
            this.btnXoaBD.Click += new System.EventHandler(this.btnXoaBD_Click);
            // 
            // btnThemBD
            // 
            this.btnThemBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemBD.AutoSize = false;
            this.btnThemBD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemBD.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemBD.Depth = 0;
            this.btnThemBD.DrawShadows = false;
            this.btnThemBD.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBD.HighEmphasis = true;
            this.btnThemBD.Icon = null;
            this.btnThemBD.Location = new System.Drawing.Point(95, 222);
            this.btnThemBD.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemBD.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnThemBD.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnThemBD.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemBD.Name = "btnThemBD";
            this.btnThemBD.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemBD.Size = new System.Drawing.Size(128, 36);
            this.btnThemBD.TabIndex = 170;
            this.btnThemBD.Text = "Thêm bạn đọc";
            this.btnThemBD.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemBD.UseAccentColor = false;
            this.btnThemBD.UseVisualStyleBackColor = true;
            this.btnThemBD.Click += new System.EventHandler(this.btnThemBD_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(26, 44);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(90, 19);
            this.materialLabel8.TabIndex = 139;
            this.materialLabel8.Text = "Mã bạn đọc:";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.AutoSize = false;
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.DrawShadows = false;
            this.btnHuy.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(518, 775);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnHuy.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(80, 36);
            this.btnHuy.TabIndex = 186;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = false;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.AutoSize = false;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.DrawShadows = false;
            this.btnLuu.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(428, 775);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnLuu.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(80, 36);
            this.btnLuu.TabIndex = 185;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.DrawShadows = false;
            this.btnThem.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = null;
            this.btnThem.Location = new System.Drawing.Point(336, 775);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnThem.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(80, 36);
            this.btnThem.TabIndex = 179;
            this.btnThem.Text = "Thêm";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKiemTraPhong);
            this.groupBox1.Controls.Add(this.rdoKhongSD);
            this.groupBox1.Controls.Add(this.rdoCoSD);
            this.groupBox1.Controls.Add(this.cboCaSuDung);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.cboPhong);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtMaDP);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.txtTGDat);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 249);
            this.groupBox1.TabIndex = 180;
            this.groupBox1.TabStop = false;
            // 
            // btnKiemTraPhong
            // 
            this.btnKiemTraPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKiemTraPhong.AutoSize = false;
            this.btnKiemTraPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKiemTraPhong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKiemTraPhong.Depth = 0;
            this.btnKiemTraPhong.DrawShadows = false;
            this.btnKiemTraPhong.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTraPhong.HighEmphasis = true;
            this.btnKiemTraPhong.Icon = null;
            this.btnKiemTraPhong.Location = new System.Drawing.Point(401, 188);
            this.btnKiemTraPhong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKiemTraPhong.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnKiemTraPhong.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnKiemTraPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKiemTraPhong.Name = "btnKiemTraPhong";
            this.btnKiemTraPhong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKiemTraPhong.Size = new System.Drawing.Size(147, 36);
            this.btnKiemTraPhong.TabIndex = 172;
            this.btnKiemTraPhong.Text = "Kiểm tra phòng";
            this.btnKiemTraPhong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKiemTraPhong.UseAccentColor = false;
            this.btnKiemTraPhong.UseVisualStyleBackColor = true;
            this.btnKiemTraPhong.Click += new System.EventHandler(this.btnKiemTraPhong_Click);
            // 
            // rdoKhongSD
            // 
            this.rdoKhongSD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoKhongSD.AutoSize = true;
            this.rdoKhongSD.Depth = 0;
            this.rdoKhongSD.Location = new System.Drawing.Point(405, 133);
            this.rdoKhongSD.Margin = new System.Windows.Forms.Padding(0);
            this.rdoKhongSD.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoKhongSD.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoKhongSD.Name = "rdoKhongSD";
            this.rdoKhongSD.Ripple = true;
            this.rdoKhongSD.Size = new System.Drawing.Size(143, 37);
            this.rdoKhongSD.TabIndex = 168;
            this.rdoKhongSD.TabStop = true;
            this.rdoKhongSD.Text = "Không sử dụng";
            this.rdoKhongSD.UseVisualStyleBackColor = true;
            // 
            // rdoCoSD
            // 
            this.rdoCoSD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoCoSD.AutoSize = true;
            this.rdoCoSD.Depth = 0;
            this.rdoCoSD.Location = new System.Drawing.Point(405, 96);
            this.rdoCoSD.Margin = new System.Windows.Forms.Padding(0);
            this.rdoCoSD.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoCoSD.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoCoSD.Name = "rdoCoSD";
            this.rdoCoSD.Ripple = true;
            this.rdoCoSD.Size = new System.Drawing.Size(116, 37);
            this.rdoCoSD.TabIndex = 167;
            this.rdoCoSD.TabStop = true;
            this.rdoCoSD.Text = "Có sử dụng";
            this.rdoCoSD.UseVisualStyleBackColor = true;
            // 
            // cboCaSuDung
            // 
            this.cboCaSuDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCaSuDung.AutoResize = false;
            this.cboCaSuDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCaSuDung.Depth = 0;
            this.cboCaSuDung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCaSuDung.DropDownHeight = 174;
            this.cboCaSuDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaSuDung.DropDownWidth = 121;
            this.cboCaSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCaSuDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCaSuDung.FormattingEnabled = true;
            this.cboCaSuDung.IntegralHeight = false;
            this.cboCaSuDung.ItemHeight = 43;
            this.cboCaSuDung.Location = new System.Drawing.Point(405, 29);
            this.cboCaSuDung.MaxDropDownItems = 4;
            this.cboCaSuDung.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCaSuDung.Name = "cboCaSuDung";
            this.cboCaSuDung.Size = new System.Drawing.Size(140, 49);
            this.cboCaSuDung.StartIndex = 0;
            this.cboCaSuDung.TabIndex = 173;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(321, 106);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(78, 19);
            this.materialLabel11.TabIndex = 166;
            this.materialLabel11.Text = "Trạng thái:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(313, 44);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(86, 19);
            this.materialLabel9.TabIndex = 172;
            this.materialLabel9.Text = "Ca sử dụng:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(76, 173);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(51, 19);
            this.materialLabel4.TabIndex = 171;
            this.materialLabel4.Text = "Phòng:";
            // 
            // cboPhong
            // 
            this.cboPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboPhong.AutoResize = false;
            this.cboPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboPhong.Depth = 0;
            this.cboPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPhong.DropDownHeight = 174;
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.DropDownWidth = 121;
            this.cboPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.IntegralHeight = false;
            this.cboPhong.ItemHeight = 43;
            this.cboPhong.Location = new System.Drawing.Point(134, 160);
            this.cboPhong.MaxDropDownItems = 4;
            this.cboPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(140, 49);
            this.cboPhong.StartIndex = 0;
            this.cboPhong.TabIndex = 170;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(22, 44);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 19);
            this.materialLabel1.TabIndex = 83;
            this.materialLabel1.Text = "Mã đặt phòng:";
            // 
            // txtMaDP
            // 
            this.txtMaDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaDP.AnimateReadOnly = true;
            this.txtMaDP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaDP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaDP.Depth = 0;
            this.txtMaDP.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDP.HideSelection = true;
            this.txtMaDP.LeadingIcon = null;
            this.txtMaDP.Location = new System.Drawing.Point(134, 29);
            this.txtMaDP.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaDP.MaxLength = 32767;
            this.txtMaDP.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaDP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaDP.Name = "txtMaDP";
            this.txtMaDP.PasswordChar = '\0';
            this.txtMaDP.PrefixSuffixText = null;
            this.txtMaDP.ReadOnly = false;
            this.txtMaDP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaDP.SelectedText = "";
            this.txtMaDP.SelectionLength = 0;
            this.txtMaDP.SelectionStart = 0;
            this.txtMaDP.ShortcutsEnabled = true;
            this.txtMaDP.Size = new System.Drawing.Size(140, 48);
            this.txtMaDP.TabIndex = 84;
            this.txtMaDP.TabStop = false;
            this.txtMaDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaDP.TrailingIcon = null;
            this.txtMaDP.UseSystemPasswordChar = false;
            this.txtMaDP.TextChanged += new System.EventHandler(this.txtMaDP_TextChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(27, 106);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(100, 19);
            this.materialLabel5.TabIndex = 97;
            this.materialLabel5.Text = "Thời gian đặt:";
            // 
            // txtTGDat
            // 
            this.txtTGDat.AllowPromptAsInput = true;
            this.txtTGDat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTGDat.AnimateReadOnly = false;
            this.txtTGDat.AsciiOnly = false;
            this.txtTGDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTGDat.BeepOnError = false;
            this.txtTGDat.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTGDat.Depth = 0;
            this.txtTGDat.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTGDat.HidePromptOnLeave = false;
            this.txtTGDat.HideSelection = true;
            this.txtTGDat.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtTGDat.LeadingIcon = null;
            this.txtTGDat.Location = new System.Drawing.Point(134, 93);
            this.txtTGDat.Mask = "00/00/0000";
            this.txtTGDat.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtTGDat.MaxLength = 32767;
            this.txtTGDat.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtTGDat.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTGDat.Name = "txtTGDat";
            this.txtTGDat.PasswordChar = '\0';
            this.txtTGDat.PrefixSuffixText = null;
            this.txtTGDat.PromptChar = '_';
            this.txtTGDat.ReadOnly = false;
            this.txtTGDat.RejectInputOnFirstFailure = false;
            this.txtTGDat.ResetOnPrompt = true;
            this.txtTGDat.ResetOnSpace = true;
            this.txtTGDat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTGDat.SelectedText = "";
            this.txtTGDat.SelectionLength = 0;
            this.txtTGDat.SelectionStart = 0;
            this.txtTGDat.ShortcutsEnabled = true;
            this.txtTGDat.Size = new System.Drawing.Size(140, 48);
            this.txtTGDat.SkipLiterals = true;
            this.txtTGDat.TabIndex = 100;
            this.txtTGDat.TabStop = false;
            this.txtTGDat.Text = "  /  /";
            this.txtTGDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTGDat.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTGDat.TrailingIcon = null;
            this.txtTGDat.UseSystemPasswordChar = false;
            this.txtTGDat.ValidatingType = null;
            // 
            // frmDatPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 850);
            this.Controls.Add(this.listViewDP);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnOpenList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmDatPhong";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 6, 6);
            this.Text = "frmDatPhong";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewDP;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaBD;
        private MaterialSkin.Controls.MaterialLabel lblKhoa;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel lblLopNC;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialLabel lblTenBD;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoTienPhat;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialComboBox cboViPham;
        private MaterialSkin.Controls.MaterialCheckbox chkViPham;
        private MaterialSkin.Controls.MaterialButton btnThemVP;
        private MaterialSkin.Controls.MaterialButton btnOpenList;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaDP;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtTGDat;
        private MaterialSkin.Controls.MaterialComboBox cboPhong;
        private MaterialSkin.Controls.MaterialButton btnXoaBD;
        private MaterialSkin.Controls.MaterialButton btnThemBD;
        private MaterialSkin.Controls.MaterialRadioButton rdoKhongSD;
        private MaterialSkin.Controls.MaterialRadioButton rdoCoSD;
        private MaterialSkin.Controls.MaterialComboBox cboCaSuDung;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnKiemTraPhong;
    }
}