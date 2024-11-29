namespace LIB2.Forms
{
    partial class frmKHKK
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
            this.txtNgayLap = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.cboTimKiem = new MaterialSkin.Controls.MaterialComboBox();
            this.listViewKHKK = new MaterialSkin.Controls.MaterialListView();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKHKK = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFile = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaNVLap = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMaNVDuyet = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNgayDuyet = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnFile = new MaterialSkin.Controls.MaterialButton();
            this.btnDuyet = new MaterialSkin.Controls.MaterialButton();
            this.btnIn = new MaterialSkin.Controls.MaterialButton();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.txtNgayLap.Location = new System.Drawing.Point(448, 92);
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
            this.txtNgayLap.Size = new System.Drawing.Size(126, 48);
            this.txtNgayLap.SkipLiterals = true;
            this.txtNgayLap.TabIndex = 131;
            this.txtNgayLap.TabStop = false;
            this.txtNgayLap.Text = "  /  /";
            this.txtNgayLap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNgayLap.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNgayLap.TrailingIcon = null;
            this.txtNgayLap.UseSystemPasswordChar = false;
            this.txtNgayLap.ValidatingType = null;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(69, 108);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(102, 19);
            this.materialLabel11.TabIndex = 130;
            this.materialLabel11.Text = "Nhân viên lập:";
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
            this.cboTimKiem.Location = new System.Drawing.Point(729, 26);
            this.cboTimKiem.MaxDropDownItems = 4;
            this.cboTimKiem.MinimumSize = new System.Drawing.Size(150, 0);
            this.cboTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(158, 49);
            this.cboTimKiem.StartIndex = 0;
            this.cboTimKiem.TabIndex = 160;
            // 
            // listViewKHKK
            // 
            this.listViewKHKK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewKHKK.AutoSizeTable = false;
            this.listViewKHKK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewKHKK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewKHKK.CheckBoxes = true;
            this.listViewKHKK.Depth = 0;
            this.listViewKHKK.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewKHKK.FullRowSelect = true;
            this.listViewKHKK.HideSelection = false;
            this.listViewKHKK.Location = new System.Drawing.Point(25, 347);
            this.listViewKHKK.MinimumSize = new System.Drawing.Size(820, 200);
            this.listViewKHKK.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewKHKK.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewKHKK.Name = "listViewKHKK";
            this.listViewKHKK.OwnerDraw = true;
            this.listViewKHKK.Size = new System.Drawing.Size(973, 385);
            this.listViewKHKK.TabIndex = 152;
            this.listViewKHKK.UseCompatibleStateImageBehavior = false;
            this.listViewKHKK.View = System.Windows.Forms.View.Details;
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
            this.btnTimKiem.Location = new System.Drawing.Point(903, 27);
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
            this.txtTimKiem.Location = new System.Drawing.Point(25, 27);
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
            this.txtTimKiem.TabIndex = 158;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TrailingIcon = null;
            this.txtTimKiem.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 43);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(154, 19);
            this.materialLabel1.TabIndex = 83;
            this.materialLabel1.Text = "Mã kế hoạch kiểm kê:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnFile);
            this.groupBox1.Controls.Add(this.txtNgayDuyet);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.txtMaNVDuyet);
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtMaKHKK);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtFile);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.txtMaNVLap);
            this.groupBox1.Location = new System.Drawing.Point(25, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 234);
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            // 
            // txtMaKHKK
            // 
            this.txtMaKHKK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaKHKK.AnimateReadOnly = true;
            this.txtMaKHKK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaKHKK.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaKHKK.Depth = 0;
            this.txtMaKHKK.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKHKK.HideSelection = true;
            this.txtMaKHKK.LeadingIcon = null;
            this.txtMaKHKK.Location = new System.Drawing.Point(177, 29);
            this.txtMaKHKK.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaKHKK.MaxLength = 32767;
            this.txtMaKHKK.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaKHKK.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaKHKK.Name = "txtMaKHKK";
            this.txtMaKHKK.PasswordChar = '\0';
            this.txtMaKHKK.PrefixSuffixText = null;
            this.txtMaKHKK.ReadOnly = false;
            this.txtMaKHKK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaKHKK.SelectedText = "";
            this.txtMaKHKK.SelectionLength = 0;
            this.txtMaKHKK.SelectionStart = 0;
            this.txtMaKHKK.ShortcutsEnabled = true;
            this.txtMaKHKK.Size = new System.Drawing.Size(150, 48);
            this.txtMaKHKK.TabIndex = 84;
            this.txtMaKHKK.TabStop = false;
            this.txtMaKHKK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaKHKK.TrailingIcon = null;
            this.txtMaKHKK.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(52, 173);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(119, 19);
            this.materialLabel8.TabIndex = 128;
            this.materialLabel8.Text = "Nhân viên duyệt:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(353, 43);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(84, 19);
            this.materialLabel2.TabIndex = 85;
            this.materialLabel2.Text = "Đường dẫn:";
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.AnimateReadOnly = false;
            this.txtFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFile.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFile.Depth = 0;
            this.txtFile.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.HideSelection = true;
            this.txtFile.LeadingIcon = null;
            this.txtFile.Location = new System.Drawing.Point(592, 28);
            this.txtFile.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtFile.MaxLength = 32767;
            this.txtFile.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtFile.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFile.Name = "txtFile";
            this.txtFile.PasswordChar = '\0';
            this.txtFile.PrefixSuffixText = null;
            this.txtFile.ReadOnly = false;
            this.txtFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFile.SelectedText = "";
            this.txtFile.SelectionLength = 0;
            this.txtFile.SelectionStart = 0;
            this.txtFile.ShortcutsEnabled = true;
            this.txtFile.Size = new System.Drawing.Size(357, 48);
            this.txtFile.TabIndex = 86;
            this.txtFile.TabStop = false;
            this.txtFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFile.TrailingIcon = null;
            this.txtFile.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(369, 108);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(68, 19);
            this.materialLabel6.TabIndex = 102;
            this.materialLabel6.Text = "Ngày lập:";
            // 
            // txtMaNVLap
            // 
            this.txtMaNVLap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaNVLap.AnimateReadOnly = false;
            this.txtMaNVLap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaNVLap.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaNVLap.Depth = 0;
            this.txtMaNVLap.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNVLap.HideSelection = true;
            this.txtMaNVLap.LeadingIcon = null;
            this.txtMaNVLap.Location = new System.Drawing.Point(177, 92);
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
            this.txtMaNVLap.Size = new System.Drawing.Size(150, 48);
            this.txtMaNVLap.TabIndex = 119;
            this.txtMaNVLap.TabStop = false;
            this.txtMaNVLap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaNVLap.TrailingIcon = null;
            this.txtMaNVLap.UseSystemPasswordChar = false;
            // 
            // txtMaNVDuyet
            // 
            this.txtMaNVDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaNVDuyet.AnimateReadOnly = false;
            this.txtMaNVDuyet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaNVDuyet.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaNVDuyet.Depth = 0;
            this.txtMaNVDuyet.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNVDuyet.HideSelection = true;
            this.txtMaNVDuyet.LeadingIcon = null;
            this.txtMaNVDuyet.Location = new System.Drawing.Point(177, 158);
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
            this.txtMaNVDuyet.Size = new System.Drawing.Size(150, 48);
            this.txtMaNVDuyet.TabIndex = 134;
            this.txtMaNVDuyet.TabStop = false;
            this.txtMaNVDuyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaNVDuyet.TrailingIcon = null;
            this.txtMaNVDuyet.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(352, 173);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 19);
            this.materialLabel3.TabIndex = 135;
            this.materialLabel3.Text = "Ngày duyệt:";
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
            this.txtNgayDuyet.Location = new System.Drawing.Point(448, 158);
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
            this.txtNgayDuyet.Size = new System.Drawing.Size(126, 48);
            this.txtNgayDuyet.SkipLiterals = true;
            this.txtNgayDuyet.TabIndex = 136;
            this.txtNgayDuyet.TabStop = false;
            this.txtNgayDuyet.Text = "  /  /";
            this.txtNgayDuyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNgayDuyet.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNgayDuyet.TrailingIcon = null;
            this.txtNgayDuyet.UseSystemPasswordChar = false;
            this.txtNgayDuyet.ValidatingType = null;
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFile.AutoSize = false;
            this.btnFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFile.Depth = 0;
            this.btnFile.DrawShadows = false;
            this.btnFile.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.HighEmphasis = true;
            this.btnFile.Icon = null;
            this.btnFile.Location = new System.Drawing.Point(448, 28);
            this.btnFile.Margin = new System.Windows.Forms.Padding(4, 12, 4, 6);
            this.btnFile.MaximumSize = new System.Drawing.Size(0, 48);
            this.btnFile.MinimumSize = new System.Drawing.Size(0, 48);
            this.btnFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFile.Name = "btnFile";
            this.btnFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFile.Padding = new System.Windows.Forms.Padding(3);
            this.btnFile.Size = new System.Drawing.Size(126, 48);
            this.btnFile.TabIndex = 162;
            this.btnFile.Text = "Mở file";
            this.btnFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFile.UseAccentColor = false;
            this.btnFile.UseVisualStyleBackColor = true;
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
            this.btnDuyet.Location = new System.Drawing.Point(734, 755);
            this.btnDuyet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDuyet.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnDuyet.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnDuyet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDuyet.Size = new System.Drawing.Size(80, 36);
            this.btnDuyet.TabIndex = 223;
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
            this.btnIn.Location = new System.Drawing.Point(627, 755);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIn.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnIn.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIn.Name = "btnIn";
            this.btnIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIn.Size = new System.Drawing.Size(80, 36);
            this.btnIn.TabIndex = 222;
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
            this.btnHuy.Location = new System.Drawing.Point(519, 755);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnHuy.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(80, 36);
            this.btnHuy.TabIndex = 221;
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
            this.btnLuu.Location = new System.Drawing.Point(415, 755);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnLuu.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(80, 36);
            this.btnLuu.TabIndex = 220;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // materialButton4
            // 
            this.materialButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(214, 755);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MaximumSize = new System.Drawing.Size(0, 36);
            this.materialButton4.MinimumSize = new System.Drawing.Size(80, 36);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(80, 36);
            this.materialButton4.TabIndex = 218;
            this.materialButton4.Text = "Thêm";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
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
            this.btnXoa.Location = new System.Drawing.Point(313, 755);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnXoa.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(80, 36);
            this.btnXoa.TabIndex = 219;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // frmKHKK
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.listViewKHKK);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmKHKK";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 6, 6);
            this.Text = "frmKHKK";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNgayLap;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialComboBox cboTimKiem;
        private MaterialSkin.Controls.MaterialListView listViewKHKK;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaKHKK;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtFile;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaNVLap;
        private MaterialSkin.Controls.MaterialButton btnFile;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNgayDuyet;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaNVDuyet;
        private MaterialSkin.Controls.MaterialButton btnDuyet;
        private MaterialSkin.Controls.MaterialButton btnIn;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton btnXoa;
    }
}