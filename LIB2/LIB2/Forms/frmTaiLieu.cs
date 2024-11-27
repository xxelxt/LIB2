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
    public partial class frmTaiLieu : MaterialForm
    {
        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public frmTaiLieu()
        {
            InitializeComponent();
        }

        private frmSach childFormSach;
        private frmTapChi childFormTapChi;
        private frmKhoaLuan childFormKhoaLuan;
        private frmTacGia childFormTG;

        private void frmTaiLieu_Load(object sender, EventArgs e)
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
            initFormSach();
            initFormTapChi();
            initFormKhoaLuan();
            initFormTG();
        }

        private void initFormSach()
        {
            childFormSach = new frmSach();
            initForm(childFormSach);
            tabPageSach.Controls.Add(childFormSach);
            childFormSach.Show();
        }

        private void initFormTapChi()
        {
            childFormTapChi = new frmTapChi();
            initForm(childFormTapChi);
            tabPageTapChi.Controls.Add(childFormTapChi);
            childFormTapChi.Show();
        }

        private void initFormKhoaLuan()
        {
            childFormKhoaLuan = new frmKhoaLuan();
            initForm(childFormKhoaLuan);
            tabPageKhoaLuan.Controls.Add(childFormKhoaLuan);
            childFormKhoaLuan.Show();
        }

        private void initFormTG()
        {
            childFormTG = new frmTacGia();
            initForm(childFormTG);
            tabPageTG.Controls.Add(childFormTG);
            childFormTG.Show();
        }
    }
}
