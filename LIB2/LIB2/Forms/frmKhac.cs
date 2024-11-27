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
    public partial class FrmKhac : MaterialForm
    {
        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance; 
        
        public FrmKhac()
        {
            InitializeComponent();
        }

        private frmPhongBan childFormPB;
        private frmChucVu childFormCV;

        private frmKhoa childFormKhoa;
        private frmViPham childFormVP;
        private frmTaiKhoan childFormTK;

        private void frmKhac_Load(object sender, EventArgs e)
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
            initFormPB();
            initFormCV();
            initFormKhoa();
            initFormVP();
            initFormTK();
        }

        private void initFormPB()
        {
            childFormPB = new frmPhongBan();
            initForm(childFormPB);
            tabPagePB.Controls.Add(childFormPB);
            childFormPB.Show();
        }

        private void initFormCV()
        {
            childFormCV = new frmChucVu();
            initForm(childFormCV);
            tabPageCV.Controls.Add(childFormCV);
            childFormCV.Show();
        }

        private void initFormKhoa()
        {
            childFormKhoa = new frmKhoa();
            initForm(childFormKhoa);
            tabPageKhoa.Controls.Add(childFormKhoa);
            childFormKhoa.Show();
        }

        private void initFormVP()
        {
            childFormVP = new frmViPham();
            initForm(childFormVP);
            tabPageVP.Controls.Add(childFormVP);
            childFormVP.Show();
        }

        private void initFormTK()
        {
            childFormTK = new frmTaiKhoan();
            initForm(childFormTK);
            tabPageTK.Controls.Add(childFormTK);
            childFormTK.Show();
        }
    }
}
