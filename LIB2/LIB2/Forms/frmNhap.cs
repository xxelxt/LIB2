using LIB2.Class;
using LIB2.DAL;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmNhap : MaterialForm
    {
        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public frmNhap()
        {
            InitializeComponent();
        }

        private frmPYCBS childFormPYCBS;
        private frmPNK childFormPNK;
        private frmPL childFormPL;

        private void frmNhap_Load(object sender, EventArgs e)
        {
            initAllSubForm();
        }

        private void initForm(MaterialForm form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            materialSkinManager.AddFormToManage(form);
        }

        private void initAllSubForm()
        {
            initFormPYCBS();
            initFormPNK();
            initFormPL();
        }

        private void initFormPYCBS()
        {
            childFormPYCBS = new frmPYCBS();
            initForm(childFormPYCBS);
            tabPagePYCBS.Controls.Add(childFormPYCBS);
            childFormPYCBS.Show();
        }

        private void initFormPNK()
        {
            childFormPNK = new frmPNK();
            initForm(childFormPNK);
            tabPagePNK.Controls.Add(childFormPNK);
            childFormPNK.Show();
        }

        private void initFormPL()
        {
            childFormPL = new frmPL();
            initForm(childFormPL);
            tabPagePL.Controls.Add(childFormPL);
            childFormPL.Show();
        }
    }
}
