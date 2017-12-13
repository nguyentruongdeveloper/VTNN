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
using VTNN.GUI.Common;
using DevExpress.XtraBars;

namespace VTNN.GUI.NhapHang
{
    public partial class frmChiTietHangMuaTraLai : frmChiTietNhapXuatTemplate
    {
        public frmChiTietHangMuaTraLai()
        {
            InitializeComponent();
        }

        private void frmChiTietHangMuaTraLai_Load(object sender, EventArgs e)
        {

        }
        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.btnSave_ItemClick(sender, e);
        }
        protected override void btnSaveAndNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.btnSaveAndNew_ItemClick(sender, e);
        }
        protected override void btnSaveAndPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.btnSaveAndPrint_ItemClick(sender, e);
        }
        protected override void btnPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.btnPreview_ItemClick(sender, e);
        }
        protected override void btnClosed_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.btnClosed_ItemClick(sender, e);
        }

        protected override void btn_MenuContext_DeletedAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.btn_MenuContext_DeletedAll_ItemClick(sender, e);
        }
        protected override void btn_MenuContext_Deleted_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.btn_MenuContext_Deleted_ItemClick(sender, e);
        }
        protected override void btn_MenuContext_Save_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.btn_MenuContext_Save_ItemClick(sender, e);
        }
        protected override void btn_MenuContext_Closed_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.btn_MenuContext_Closed_ItemClick(sender, e);
        }
    }
}