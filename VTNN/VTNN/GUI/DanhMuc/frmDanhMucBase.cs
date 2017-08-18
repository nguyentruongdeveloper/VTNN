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

namespace VTNN.GUI.DanhMuc
{
    public partial class frmDanhMucBase : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhMucBase()
        {
            InitializeComponent();
        }

       

        private void frmDanhMucBase_Load(object sender, EventArgs e)
        {

        }
        protected virtual void loadDataForm(int p_iAuto_ID)
        {

        }
        protected virtual void Add()
        {

        }
        protected virtual void Updated()
        {

        }
        protected virtual void Deleted()
        {

        }
        protected virtual void Refesh()
        {

        }
        protected virtual void Export()
        {

        }
        protected virtual void CloseForm()
        {

        }
        private void bar_btn_ThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bar_btn_Sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bar_btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bar_btn_NapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bar_btn_Xuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bar_btn_In_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bar_btn_Dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}