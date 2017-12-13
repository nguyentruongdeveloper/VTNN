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
using DevExpress.XtraBars;
using BUS.DanhMuc;
using VTNN.Extensions;
using VTNN.GUI.DanhMuc.Sub;
using DTO.DanhMuc;
using VTNN.GUI.Common;

namespace VTNN.GUI.DanhMuc
{
    public partial class frmNhaSanXuat : frmTemplateCategory, IDanhMuc
    {
        CDM_Nha_San_Xuat_BUS _objNhaSanXuatBUS = CDM_Nha_San_Xuat_BUS.getInstace();
        public frmNhaSanXuat()
        {
            InitializeComponent();
        }

        private void frmNhaSanXuat_Load(object sender, EventArgs e)
        {
            FormatControl();
            Load_Repository();
            Load_Data_Form();
        }

        public void FormatControl()
        {
            FormatControl(this);
        }

        protected override void FormatControl(Control p_objControl)
        {
            base.FormatControl(p_objControl);
          

        }

        public void Load_Repository()
        {

        }

        public void Load_Data_Form()
        {
            grcNSX.DataSource = _objNhaSanXuatBUS.Get_List_All();
            Show_Button_MenuContext();

        }

        private void Show_Button_MenuContext()
        {
            if (grvNSX.RowCount <= 0)
            {
                bar_btn_MenuContext_Updated.Enabled = false;
                bar_btn_Menu_Context_Deleted.Enabled = false;
            }
            else
            {
                bar_btn_MenuContext_Updated.Enabled = true;
                bar_btn_Menu_Context_Deleted.Enabled = true;
            }
        }

        public void Add()
        {
            using (frmChiTietNhaSanXuat frm = new frmChiTietNhaSanXuat())
            {
                frm.fStatus = Utility.FormStatus.Add;
                frm.ReLoadParent = this.Load_Data_Form;
                frm.ShowDialog();
            }

        }

        public void Updated()
        {
            if (grvNSX.RowCount > 0 && grvNSX.FocusedRowHandle >= 0)
            {
                using (frmChiTietNhaSanXuat frm = new frmChiTietNhaSanXuat())
                {
                    frm.fStatus = Utility.FormStatus.Edit;
                    CDM_Nha_San_Xuat v_objNSX = (CDM_Nha_San_Xuat)grvNSX.GetRow(grvNSX.FocusedRowHandle);
                    frm._objNhaSanXuat = v_objNSX;
                    frm.ReLoadParent = this.Load_Data_Form;
                    frm.ShowDialog();
                }
            }
        }

        public void Deleted()
        {
            if (grvNSX.RowCount > 0 && grvNSX.FocusedRowHandle >= 0 && CExtensions.showConfirmMessage("Xác nhận xóa dữ liệu"))
            {

                CDM_Don_Vi_Tinh v_objDVT = (CDM_Don_Vi_Tinh)grvNSX.GetRow(grvNSX.FocusedRowHandle);
                if (v_objDVT != null)
                {
                    try
                    {
                        _objNhaSanXuatBUS.Deleted(v_objDVT.Auto_ID, "Admin");
                        CExtensions.showMessage("Xóa dữ liệu thành công!");
                        Load_Data_Form();
                    }
                    catch (Exception ex)
                    {
                        CExtensions.showErrorException(ex, "Error!");
                    }

                }

            }
        }

        public void Refesh()
        {
            Load_Data_Form();
        }

        public void CloseForm()
        {
            this.Dispose();
        }

        public void Export()
        {
        }

        protected override void bar_btn_Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add();
        }

        protected override void bar_btn_Menu_Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add();
        }

        protected override void bar_btn_Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Updated();
        }

        protected override void bar_btn_Menu_Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Updated();
        }

        protected override void bar_btn_Deleted_ItemClick(object sender, ItemClickEventArgs e)
        {
            Deleted();
        }

        protected override void bar_btn_Menu_Deleted_ItemClick(object sender, ItemClickEventArgs e)
        {
            Deleted();
        }

        protected override void bar_btn_Refesh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Refesh();
        }

        protected override void bar_btn_Menu_Refesh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Refesh();
        }

        protected override void bar_btn_Print_ItemClick(object sender, ItemClickEventArgs e)
        {
            Export();
        }

        protected override void bar_btn_Closed_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseForm();
        }

        protected override void bar_btn_Menu_Closed_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseForm();
        }
    }
}