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
    public partial class frmTTTaiLieuKhac : MaterialForm
    {
        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public frmTTTaiLieuKhac()
        {
            InitializeComponent();
        }

        private frmNganh childFormNganh;
        private frmLinhVuc childFormLV;
        private frmNgonNgu childFormNN;
        private frmLoaiAnPham childFormLAP;

        private void frmTTTaiLieuKhac_Load(object sender, EventArgs e)
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
            initFormNganh();
            initFormLV();
            initFormNN();
            initFormLAP();
        }

        private void initFormNganh()
        {
            childFormNganh = new frmNganh();
            initForm(childFormNganh);
            tabPageNganh.Controls.Add(childFormNganh);
            childFormNganh.Show();
        }

        private void initFormLV()
        {
            childFormLV = new frmLinhVuc();
            initForm(childFormLV);
            tabPageLV.Controls.Add(childFormLV);
            childFormLV.Show();
        }

        private void initFormNN()
        {
            childFormNN = new frmNgonNgu();
            initForm(childFormNN);
            tabPageNN.Controls.Add(childFormNN);
            childFormNN.Show();
        }

        private void initFormLAP()
        {
            childFormLAP = new frmLoaiAnPham();
            initForm(childFormLAP);
            tabPageLAP.Controls.Add(childFormLAP);
            childFormLAP.Show();
        }
    }
}
