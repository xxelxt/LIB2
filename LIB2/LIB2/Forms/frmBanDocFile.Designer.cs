namespace LIB2.Forms
{
    partial class frmBanDocFile
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
            this.btnOpen = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.txtFilePath = new MaterialSkin.Controls.MaterialTextBox2();
            this.listViewBDFile = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = false;
            this.btnOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpen.Depth = 0;
            this.btnOpen.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.HighEmphasis = true;
            this.btnOpen.Icon = null;
            this.btnOpen.Location = new System.Drawing.Point(27, 101);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 12, 4, 6);
            this.btnOpen.MaximumSize = new System.Drawing.Size(150, 40);
            this.btnOpen.MinimumSize = new System.Drawing.Size(0, 48);
            this.btnOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpen.Padding = new System.Windows.Forms.Padding(3);
            this.btnOpen.Size = new System.Drawing.Size(118, 48);
            this.btnOpen.TabIndex = 152;
            this.btnOpen.Text = "Mở file";
            this.btnOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpen.UseAccentColor = false;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.AutoSize = false;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(916, 101);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 12, 4, 6);
            this.btnLuu.MaximumSize = new System.Drawing.Size(96, 40);
            this.btnLuu.MinimumSize = new System.Drawing.Size(0, 48);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Padding = new System.Windows.Forms.Padding(3);
            this.btnLuu.Size = new System.Drawing.Size(84, 48);
            this.btnLuu.TabIndex = 151;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.AnimateReadOnly = false;
            this.txtFilePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFilePath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFilePath.Depth = 0;
            this.txtFilePath.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.HideSelection = true;
            this.txtFilePath.LeadingIcon = null;
            this.txtFilePath.Location = new System.Drawing.Point(163, 101);
            this.txtFilePath.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtFilePath.MaxLength = 32767;
            this.txtFilePath.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtFilePath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.PrefixSuffixText = null;
            this.txtFilePath.ReadOnly = false;
            this.txtFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.SelectionLength = 0;
            this.txtFilePath.SelectionStart = 0;
            this.txtFilePath.ShortcutsEnabled = true;
            this.txtFilePath.Size = new System.Drawing.Size(735, 48);
            this.txtFilePath.TabIndex = 150;
            this.txtFilePath.TabStop = false;
            this.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilePath.TrailingIcon = null;
            this.txtFilePath.UseSystemPasswordChar = false;
            this.txtFilePath.Enter += new System.EventHandler(this.txtFilePath_Enter);
            // 
            // listViewBDFile
            // 
            this.listViewBDFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBDFile.AutoSizeTable = false;
            this.listViewBDFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewBDFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewBDFile.CheckBoxes = true;
            this.listViewBDFile.Depth = 0;
            this.listViewBDFile.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBDFile.FullRowSelect = true;
            this.listViewBDFile.HideSelection = false;
            this.listViewBDFile.Location = new System.Drawing.Point(27, 175);
            this.listViewBDFile.MinimumSize = new System.Drawing.Size(820, 300);
            this.listViewBDFile.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewBDFile.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewBDFile.Name = "listViewBDFile";
            this.listViewBDFile.OwnerDraw = true;
            this.listViewBDFile.Size = new System.Drawing.Size(973, 614);
            this.listViewBDFile.TabIndex = 153;
            this.listViewBDFile.UseCompatibleStateImageBehavior = false;
            this.listViewBDFile.View = System.Windows.Forms.View.Details;
            // 
            // frmBanDocFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.listViewBDFile);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtFilePath);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
            this.Name = "frmBanDocFile";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 6, 6);
            this.Text = "Nhập thông tin bạn đọc từ file";
            this.Load += new System.EventHandler(this.frmBanDocFile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnOpen;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialTextBox2 txtFilePath;
        private MaterialSkin.Controls.MaterialListView listViewBDFile;
    }
}