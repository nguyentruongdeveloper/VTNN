using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VTNN.GUI.Common
{
    public partial class frmTest : frmTemplate
    {
        public frmTest()
        {
            InitializeComponent();
        }

        protected virtual void frmChiTietNhapXuatTemplate_Load(object sender, EventArgs e)
        {

        }
        protected virtual bool Save()
        {
            bool v_blResult = true;
            return v_blResult;

        }
        protected virtual bool SaveAndNew()
        {
            bool v_blResult = true;
            return v_blResult;

        }
        protected virtual bool SaveAndPrint()
        {
            bool v_blResult = true;
            return v_blResult;

        }

        protected virtual void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btnSaveAndPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btnClosed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btnSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dockPanelMain_Click(object sender, EventArgs e)
        {

        }
    }
}