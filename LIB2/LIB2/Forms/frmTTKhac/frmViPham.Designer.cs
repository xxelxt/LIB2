﻿namespace LIB2.Forms
{
    partial class frmViPham
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
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.listViewVP = new MaterialSkin.Controls.MaterialListView();
            this.txtTenVP = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMaVP = new MaterialSkin.Controls.MaterialTextBox2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSoTienCoDinh = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSoPhanTram = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnTimKiem.Location = new System.Drawing.Point(904, 21);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 12, 4, 6);
            this.btnTimKiem.MaximumSize = new System.Drawing.Size(96, 40);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(0, 48);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.btnTimKiem.Size = new System.Drawing.Size(96, 48);
            this.btnTimKiem.TabIndex = 41;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnHuy.Location = new System.Drawing.Point(685, 756);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnHuy.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(80, 36);
            this.btnHuy.TabIndex = 39;
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
            this.btnLuu.Location = new System.Drawing.Point(577, 756);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnLuu.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(80, 36);
            this.btnLuu.TabIndex = 38;
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
            this.btnXoa.Location = new System.Drawing.Point(473, 756);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnXoa.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(80, 36);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(371, 756);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnSua.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(80, 36);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa";
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnThem.Location = new System.Drawing.Point(272, 756);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnThem.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(80, 36);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(21, 40);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Mã vi phạm:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(306, 40);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(93, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Tên vi phạm:";
            // 
            // listViewVP
            // 
            this.listViewVP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewVP.AutoSizeTable = false;
            this.listViewVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewVP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewVP.CheckBoxes = true;
            this.listViewVP.Depth = 0;
            this.listViewVP.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewVP.FullRowSelect = true;
            this.listViewVP.HideSelection = false;
            this.listViewVP.Location = new System.Drawing.Point(24, 275);
            this.listViewVP.MinimumSize = new System.Drawing.Size(820, 378);
            this.listViewVP.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewVP.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewVP.Name = "listViewVP";
            this.listViewVP.OwnerDraw = true;
            this.listViewVP.Size = new System.Drawing.Size(976, 456);
            this.listViewVP.TabIndex = 34;
            this.listViewVP.UseCompatibleStateImageBehavior = false;
            this.listViewVP.View = System.Windows.Forms.View.Details;
            this.listViewVP.SelectedIndexChanged += new System.EventHandler(this.listViewVP_SelectedIndexChanged);
            // 
            // txtTenVP
            // 
            this.txtTenVP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenVP.AnimateReadOnly = false;
            this.txtTenVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenVP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenVP.Depth = 0;
            this.txtTenVP.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVP.HideSelection = true;
            this.txtTenVP.LeadingIcon = null;
            this.txtTenVP.Location = new System.Drawing.Point(405, 26);
            this.txtTenVP.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtTenVP.MaxLength = 32767;
            this.txtTenVP.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtTenVP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenVP.Name = "txtTenVP";
            this.txtTenVP.PasswordChar = '\0';
            this.txtTenVP.PrefixSuffixText = null;
            this.txtTenVP.ReadOnly = false;
            this.txtTenVP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenVP.SelectedText = "";
            this.txtTenVP.SelectionLength = 0;
            this.txtTenVP.SelectionStart = 0;
            this.txtTenVP.ShortcutsEnabled = true;
            this.txtTenVP.Size = new System.Drawing.Size(543, 48);
            this.txtTenVP.TabIndex = 16;
            this.txtTenVP.TabStop = false;
            this.txtTenVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenVP.TrailingIcon = null;
            this.txtTenVP.UseSystemPasswordChar = false;
            // 
            // txtMaVP
            // 
            this.txtMaVP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaVP.AnimateReadOnly = true;
            this.txtMaVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaVP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaVP.Depth = 0;
            this.txtMaVP.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVP.HideSelection = true;
            this.txtMaVP.LeadingIcon = null;
            this.txtMaVP.Location = new System.Drawing.Point(116, 26);
            this.txtMaVP.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaVP.MaxLength = 32767;
            this.txtMaVP.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaVP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaVP.Name = "txtMaVP";
            this.txtMaVP.PasswordChar = '\0';
            this.txtMaVP.PrefixSuffixText = null;
            this.txtMaVP.ReadOnly = false;
            this.txtMaVP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaVP.SelectedText = "";
            this.txtMaVP.SelectionLength = 0;
            this.txtMaVP.SelectionStart = 0;
            this.txtMaVP.ShortcutsEnabled = true;
            this.txtMaVP.Size = new System.Drawing.Size(150, 48);
            this.txtMaVP.TabIndex = 14;
            this.txtMaVP.TabStop = false;
            this.txtMaVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaVP.TrailingIcon = null;
            this.txtMaVP.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSoTienCoDinh);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.txtSoPhanTram);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.txtTenVP);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtMaVP);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Location = new System.Drawing.Point(24, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 167);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
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
            this.txtTimKiem.Location = new System.Drawing.Point(24, 21);
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
            this.txtTimKiem.Size = new System.Drawing.Size(863, 48);
            this.txtTimKiem.TabIndex = 40;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TrailingIcon = null;
            this.txtTimKiem.UseSystemPasswordChar = false;
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // txtSoTienCoDinh
            // 
            this.txtSoTienCoDinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTienCoDinh.AnimateReadOnly = false;
            this.txtSoTienCoDinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoTienCoDinh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoTienCoDinh.Depth = 0;
            this.txtSoTienCoDinh.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienCoDinh.HideSelection = true;
            this.txtSoTienCoDinh.LeadingIcon = null;
            this.txtSoTienCoDinh.Location = new System.Drawing.Point(726, 96);
            this.txtSoTienCoDinh.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtSoTienCoDinh.MaxLength = 32767;
            this.txtSoTienCoDinh.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtSoTienCoDinh.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoTienCoDinh.Name = "txtSoTienCoDinh";
            this.txtSoTienCoDinh.PasswordChar = '\0';
            this.txtSoTienCoDinh.PrefixSuffixText = null;
            this.txtSoTienCoDinh.ReadOnly = false;
            this.txtSoTienCoDinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoTienCoDinh.SelectedText = "";
            this.txtSoTienCoDinh.SelectionLength = 0;
            this.txtSoTienCoDinh.SelectionStart = 0;
            this.txtSoTienCoDinh.ShortcutsEnabled = true;
            this.txtSoTienCoDinh.Size = new System.Drawing.Size(222, 48);
            this.txtSoTienCoDinh.TabIndex = 20;
            this.txtSoTienCoDinh.TabStop = false;
            this.txtSoTienCoDinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoTienCoDinh.TrailingIcon = null;
            this.txtSoTienCoDinh.UseSystemPasswordChar = false;
            this.txtSoTienCoDinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienCoDinh_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(22, 110);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(278, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Số phần trăm phạt (tính theo giá sách):";
            // 
            // txtSoPhanTram
            // 
            this.txtSoPhanTram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoPhanTram.AnimateReadOnly = true;
            this.txtSoPhanTram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoPhanTram.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoPhanTram.Depth = 0;
            this.txtSoPhanTram.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhanTram.HideSelection = true;
            this.txtSoPhanTram.LeadingIcon = null;
            this.txtSoPhanTram.Location = new System.Drawing.Point(306, 96);
            this.txtSoPhanTram.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtSoPhanTram.MaxLength = 32767;
            this.txtSoPhanTram.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtSoPhanTram.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoPhanTram.Name = "txtSoPhanTram";
            this.txtSoPhanTram.PasswordChar = '\0';
            this.txtSoPhanTram.PrefixSuffixText = null;
            this.txtSoPhanTram.ReadOnly = false;
            this.txtSoPhanTram.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoPhanTram.SelectedText = "";
            this.txtSoPhanTram.SelectionLength = 0;
            this.txtSoPhanTram.SelectionStart = 0;
            this.txtSoPhanTram.ShortcutsEnabled = true;
            this.txtSoPhanTram.Size = new System.Drawing.Size(222, 48);
            this.txtSoPhanTram.TabIndex = 18;
            this.txtSoPhanTram.TabStop = false;
            this.txtSoPhanTram.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoPhanTram.TrailingIcon = null;
            this.txtSoPhanTram.UseSystemPasswordChar = false;
            this.txtSoPhanTram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoPhanTram_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(573, 110);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(147, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Số tiền phạt cố định:";
            // 
            // frmViPham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.listViewVP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimKiem);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmViPham";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 6, 6);
            this.Text = "Vi phạm";
            this.Load += new System.EventHandler(this.frmViPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialListView listViewVP;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenVP;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaVP;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoTienCoDinh;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtSoPhanTram;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}