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


namespace VTNN.GUI.BanHang
{
    public partial class frmChungTuHangBanTraLai : frmListTemplate
    {
        public frmChungTuHangBanTraLai()
        {
            InitializeComponent();
        }

        private void frmChungTuBanHang_Load(object sender, EventArgs e)
        {

        }
        protected override void Add()
        {
            base.Add();
        }
        protected override void Updated()
        {
            base.Updated();
        }
        protected override void Deleted()
        {
            base.Deleted();
        }
        protected override void Refesh()
        {
            base.Refesh();
        }
        protected override void Print()

        {
            base.Print();
        }
        protected override void ExportExcel()
        {
            base.ExportExcel();
        }

        protected override void Closed()
        {
            base.Closed();
        }
        protected override void bar_btn_Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.bar_btn_Add_ItemClick(sender, e);
        }
        protected override void bar_btn_Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.bar_btn_Edit_ItemClick(sender, e);
        }
        protected override void bar_btn_Deleted_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.bar_btn_Deleted_ItemClick(sender, e);
        }
        protected override void bar_btn_Refesh_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.bar_btn_Refesh_ItemClick(sender, e);
        }
        protected override void bar_btn_Print_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.bar_btn_Print_ItemClick(sender, e);
        }
        protected override void bar_btn_Exprot_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.bar_btn_Exprot_ItemClick(sender, e);
        }
        protected override void bar_btn_Closed_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.bar_btn_Closed_ItemClick(sender, e);
        }
    }
}