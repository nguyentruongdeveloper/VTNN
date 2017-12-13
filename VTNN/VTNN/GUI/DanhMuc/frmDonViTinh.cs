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
using BUS.DanhMuc;
using DevExpress.XtraBars;
using VTNN.GUI.DanhMuc.Sub;
using DTO.DanhMuc;
using VTNN.Extensions;
using VTNN.GUI.Common;

namespace VTNN.GUI.DanhMuc
{
    public partial class frmDonViTinh : frmTemplateCategory, IDanhMuc
    {
        CDM_Don_Vi_Tinh_BUS _objDonViTinhBUS = CDM_Don_Vi_Tinh_BUS.getInstance();
        List<CDM_Don_Vi_Tinh> _arr = new List<CDM_Don_Vi_Tinh>();
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
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
        private void Show_Button_MenuContext()
        {
            if (grvDVT.RowCount <= 0)
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

        public void Load_Data_Form()
        {

            
            grcDVT.DataSource = _objDonViTinhBUS.Get_List_All().ToList();
            Show_Button_MenuContext();
        }
        protected override void bar_btn_Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add();
        }
        protected override void bar_btn_Menu_Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add();
        }
        public void Add()
        {
            using (frmChiTietDonViTinh frm = new frmChiTietDonViTinh())
            {
                frm.fStatus = Utility.FormStatus.Add;
                frm.ReLoadParent = this.Load_Data_Form;
                frm.ShowDialog();
            }

        }
        protected override void bar_btn_Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Updated();
        }
        protected override void bar_btn_Menu_Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Updated();
        }
        public void Updated()
        {

            using (frmChiTietDonViTinh frm = new frmChiTietDonViTinh())
            {
                frm.fStatus = Utility.FormStatus.Edit;
                CDM_Don_Vi_Tinh v_objDVT = (CDM_Don_Vi_Tinh)grvDVT.GetRow(grvDVT.FocusedRowHandle);
                frm._objDonViTinh = v_objDVT;
                frm.ReLoadParent = this.Load_Data_Form;
                frm.ShowDialog();
            }

        }
        protected override void bar_btn_Deleted_ItemClick(object sender, ItemClickEventArgs e)
        {
            Deleted();
        }
        protected override void bar_btn_Menu_Deleted_ItemClick(object sender, ItemClickEventArgs e)
        {
            Deleted();
        }
        public void Deleted()
        {
            if (grvDVT.RowCount > 0 && grvDVT.FocusedRowHandle >= 0 && CExtensions.showConfirmMessage("Xác nhận xóa dữ liệu"))
            {

                CDM_Don_Vi_Tinh v_objDVT = (CDM_Don_Vi_Tinh)grvDVT.GetRow(grvDVT.FocusedRowHandle);
                if (v_objDVT != null)
                {
                    try
                    {
                        _objDonViTinhBUS.Deleted(v_objDVT.Auto_ID, "Admin");
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
        protected override void bar_btn_Refesh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Refesh();
        }
        protected override void bar_btn_Menu_Refesh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Refesh();
        }
        public void Refesh()
        {
            Load_Data_Form();
        }
        protected override void bar_btn_Closed_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseForm();
        }
        protected override void bar_btn_Menu_Closed_ItemClick(object sender, ItemClickEventArgs e)
        {

            CloseForm();

        }
        public void CloseForm()
        {
            this.Dispose();
        }
        protected override void bar_btn_Export_ItemClick(object sender, ItemClickEventArgs e)
        {
            Export();
        }
        public void Export()
        {

        }
    }
}