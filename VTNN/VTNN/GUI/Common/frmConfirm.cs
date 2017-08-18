﻿using System;
using System.Windows.Forms;

namespace VTNN.GUI.Common
{
    public partial class frmConfirm : DevExpress.XtraEditors.XtraForm
    {
       public bool isUserExit = false;
        public frmConfirm()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            isUserExit = true;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isUserExit = false;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isUserExit)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
           
        }
    }
}