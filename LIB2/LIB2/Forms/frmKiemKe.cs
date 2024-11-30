using LIB2.Class;
using LIB2.Class.Types;
using LIB2.DAL;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class FrmKiemKe : MaterialForm
    {
        public UserRole currentRole; 
        public string Username { get; set; }
        
        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public FrmKiemKe()
        {
            InitializeComponent();
        }

        private frmKHKK childFormKHKK;
        private frmPKK childFormPKK;
        private frmDMSC childFormDMSC;
        private frmDMBT childFormDMBT;
        private frmBCKK childFormBCKK;

        private void FrmKiemKe_Load(object sender, EventArgs e)
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
            initFormKHKK();
            initFormPKK();
            initFormDMSC();
            initFormDMBT();
            initFormBCKK();
        }

        private void initFormKHKK()
        {
            childFormKHKK = new frmKHKK();
            initForm(childFormKHKK);
            tabPageKHKK.Controls.Add(childFormKHKK);
            childFormKHKK.Show();

            childFormKHKK.Username = this.Username;
            childFormKHKK.currentRole = this.currentRole;
            childFormKHKK.LoadData();
        }

        private void initFormPKK()
        {
            childFormPKK = new frmPKK();
            initForm(childFormPKK);
            tabPagePKK.Controls.Add(childFormPKK);
            childFormPKK.Show();

            childFormPKK.Username = this.Username;
            childFormPKK.LoadData();
        }

        private void initFormDMSC()
        {
            childFormDMSC = new frmDMSC();
            initForm(childFormDMSC);
            tabPageDMSC.Controls.Add(childFormDMSC);
            childFormDMSC.Show();

            childFormDMSC.Username = this.Username;
            childFormDMSC.LoadData();
        }

        private void initFormDMBT()
        {
            childFormDMBT = new frmDMBT();
            initForm(childFormDMBT);
            tabPageDMBT.Controls.Add(childFormDMBT);
            childFormDMBT.Show();

            childFormDMBT.Username = this.Username;
            childFormDMBT.LoadData();
        }

        private void initFormBCKK()
        {
            childFormBCKK = new frmBCKK();
            initForm(childFormBCKK);
            tabPageBCKK.Controls.Add(childFormBCKK);
            childFormBCKK.Show();

            childFormBCKK.Username = this.Username;
            childFormBCKK.currentRole = this.currentRole;
            childFormBCKK.LoadData();
        }
    }
}
