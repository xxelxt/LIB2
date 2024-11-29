using LIB2.DAL;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace LIB2.Forms
{
    public partial class frmHome : MaterialForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void swtDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (swtDarkMode.Checked)
            {
                EnableDarkMode();
            }
            else
            {
                EnableLightMode();
            }
        }

        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        private void EnableDarkMode()
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            var darkestColorScheme = new ColorScheme(
                Color.FromArgb(12, 12, 12),        // Darkest Gray
                Color.FromArgb(8, 8, 8),           // Darkest Black
                Color.FromArgb(18, 18, 18),        // Very Dark Gray
                Color.FromArgb(255, 150, 79),      // Orange
                TextShade.WHITE
            );
            materialSkinManager.ColorScheme = darkestColorScheme;

        }

        private void EnableLightMode()
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            var lightColorScheme = new ColorScheme(
                Color.FromArgb(255, 255, 255),     // White
                Color.FromArgb(240, 240, 240),     // Light Gray
                Color.FromArgb(255, 255, 255),     // White
                Color.FromArgb(255, 150, 79),      // Orange
                TextShade.BLACK
            );
            materialSkinManager.ColorScheme = lightColorScheme;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
        }

        public event EventHandler DirectToMTClicked;
        public event EventHandler DirectToDPClicked;
        public event EventHandler DirectToPhatClicked;

        public event EventHandler DirectToNhapClicked;
        public event EventHandler DirectToKiemKeClicked;
        public event EventHandler DirectToThanhLocClicked;

        private void btnDirectToMT_Click(object sender, EventArgs e)
        {
            DirectToMTClicked?.Invoke(sender, e);
        }

        private void btnDirectToDP_Click(object sender, EventArgs e)
        {
            DirectToDPClicked?.Invoke(sender, e);
        }

        private void btnDirectToPhat_Click(object sender, EventArgs e)
        {
            DirectToPhatClicked?.Invoke(sender, e);
        }

        private void btnDirectToNhap_Click(object sender, EventArgs e)
        {
            DirectToNhapClicked?.Invoke(sender, e);
        }

        private void btnDirectToKiemKe_Click(object sender, EventArgs e)
        {
            DirectToKiemKeClicked?.Invoke(sender, e);
        }

        private void btnDirectToTL_Click(object sender, EventArgs e)
        {
            DirectToThanhLocClicked?.Invoke(sender, e);
        }
    }
}