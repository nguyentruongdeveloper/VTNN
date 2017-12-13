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
using BUS.DanhMuc;

namespace VTNN.GUI.Common
{
    public partial class frmListTemplate : frmTemplate
    {
      
        //CDM_Ky_BUS _objKyBUS = CDM_Ky_BUS.getInstance();
        public frmListTemplate()
        {
            InitializeComponent();
        }

        private void frmListTemplate_Load(object sender, EventArgs e)
        {
            //Load_Repository();
        }
        public virtual void Load_Repository()
        {
            //Load_Repository_Ky();
        }

        private void Load_Repository_Ky()
        {
            //lok_Ky.SetDataSource(_objKyBUS.Get_List_All().ToList<object>(), "Auto_ID", "Ten_Ky");
            //lok_Ky.EditValue = 1;
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
        protected virtual void Print()
        {

        }
        protected virtual void ExportExcel()
        {

        }
        protected virtual void Closed()
        {

        }

        protected virtual void  bar_btn_Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add();
        }

        protected virtual void  bar_btn_Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Updated();
        }

        protected virtual void  bar_btn_Deleted_ItemClick(object sender, ItemClickEventArgs e)
        {
            Deleted();
        }

        protected virtual void  bar_btn_Print_ItemClick(object sender, ItemClickEventArgs e)
        {
            Print();
        }

        protected virtual void  bar_btn_Exprot_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExportExcel();
        }

        protected virtual void  bar_btn_Closed_ItemClick(object sender, ItemClickEventArgs e)
        {
            Closed();
        }

        protected virtual void bar_btn_Refesh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Refesh();
        }
    }
}