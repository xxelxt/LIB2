using LIB2.Class;
using LIB2.Class.Types;
using LIB2.DAL;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class FrmThanhLoc : MaterialForm
    {
        public UserRole currentRole; 
        public string Username { get; set; }
        
        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public FrmThanhLoc()
        {
            InitializeComponent();
        }

        private frmDMTL childFormDMTL;
        private frmBCTL childFormBCTL;

        private void FrmThanhLoc_Load(object sender, EventArgs e)
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
            initFormDMTL();
            initFormBCTL();
        }

        private void initFormDMTL()
        {
            childFormDMTL = new frmDMTL();
            initForm(childFormDMTL);
            tabPageDMTL.Controls.Add(childFormDMTL);
            childFormDMTL.Show();

            childFormDMTL.Username = this.Username;
            childFormDMTL.currentRole = this.currentRole;
            childFormDMTL.LoadData();
        }

        private void initFormBCTL()
        {
            childFormBCTL = new frmBCTL();
            initForm(childFormBCTL);
            tabPageBCTL.Controls.Add(childFormBCTL);
            childFormBCTL.Show();

            childFormBCTL.Username = this.Username;
            childFormBCTL.currentRole = this.currentRole;
            childFormBCTL.LoadData();
        }
    }
}
