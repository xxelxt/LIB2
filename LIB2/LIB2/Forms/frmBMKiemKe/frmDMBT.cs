﻿using LIB2.Class;
using LIB2.DAL;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIB2.Forms
{
    public partial class frmDMBT : MaterialForm
    {
        private DataTable tblBanDoc;

        private bool isSearching = false;
        private string currentSearchKeyword = "";

        public frmDMBT()
        {
            InitializeComponent();
            InitializeListView();
            // LoadData();
        }

        private void InitializeListView()
        {

        }

        private void frmDMBT_Load(object sender, EventArgs e)
        {

        }

        private void AdjustColumnWidth()
        {

        }
    }
}