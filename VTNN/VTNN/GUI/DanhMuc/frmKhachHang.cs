﻿using System;
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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars;
using VTNN.GUI.DanhMuc.Sub;
using VTNN.Extensions;
using DTO.DanhMuc;
using VTNN.GUI.Common;

namespace VTNN.GUI.DanhMuc
{
    public partial class frmKhachHang : frmTemplateCategory, IDanhMuc
    {


        public frmKhachHang()
        {
            InitializeComponent();
        }
        CDM_Khach_Hang_BUS _objKhachHangBUS = CDM_Khach_Hang_BUS.getInstance();
        private void frmKhachHang_Load(object sender, EventArgs e)
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
            grcKhachHang.DataSource = _objKhachHangBUS.Get_List_All();
            Show_Button_MenuContext();
        }
        private void Show_Button_MenuContext()
        {
            if (grvKhachHang.RowCount <= 0)
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
            using (frmChiTietKhachHang frm = new frmChiTietKhachHang())
            {
                frm.fStatus = Utility.FormStatus.Add;
                frm.ReLoadParent = this.Load_Data_Form;
                frm.ShowDialog();

            }

        }
        public void Updated()
        {
            if (grvKhachHang.RowCount > 0 && grvKhachHang.FocusedRowHandle >= 0)
            {
                using (frmChiTietKhachHang frm = new frmChiTietKhachHang())
                {

                    frm.fStatus = Utility.FormStatus.Edit;
                    CDM_Khach_Hang v_objKhachHang = (CDM_Khach_Hang)grvKhachHang.GetRow(grvKhachHang.FocusedRowHandle);
                    frm._objKhachHang = v_objKhachHang;
                    frm.ReLoadParent = this.Load_Data_Form;
                    frm.ShowDialog();

                }
            }


        }
        public void Deleted()
        {
            if (grvKhachHang.RowCount > 0 && grvKhachHang.FocusedRowHandle >= 0 && CExtensions.showConfirmMessage("Xác nhận xóa dữ liệu"))
            {

                CDM_Khach_Hang v_objKhachHang = (CDM_Khach_Hang)grvKhachHang.GetRow(grvKhachHang.FocusedRowHandle);
                if (v_objKhachHang != null)
                {
                    try
                    {
                        _objKhachHangBUS.Deleted(v_objKhachHang.Auto_ID, "Admin");
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

        //private void FormatControl()
        //{

        //    FormatControl(this);
        //}
        //protected override void FormatControl(Control p_objControl)
        //{
        //    base.FormatControl(p_objControl);
        //}
        //protected override void loadDataForm(int p_iAuto_ID)
        //{
        //    _blistKhachHang = new BindingList<CDM_Khach_Hang>(_objKhachHangBUS.List_DM_Khach_Hang());
        //    grcKhachHang.DataSource = _blistKhachHang;
        //}

        private void CustomGridView1_EditFormShowing(object sender, DevExpress.XtraGrid.Views.Grid.EditFormShowingEventArgs e)
        {
            //    GridView view = (GridView)sender;
            //    if (view == null)
            //        return;
            //    if (view.IsNewItemRow(e.RowHandle))
            //    {
            //        CustomGridView1.OptionsEditForm.FormCaptionFormat = "Thêm mới khách hàng";
            //    }
            //    else
            //    {
            //        CustomGridView1.OptionsEditForm.FormCaptionFormat = "Sửa thông tin khách hàng";
            //    }
        }
        private void CustomGridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //GridView view = (GridView)sender;

            //if (view == null)
            //    return;
            //CDM_Khach_Hang v_objKhachHang = e.Row as CDM_Khach_Hang;
            //if (v_objKhachHang != null)
            //{
            //    if (view.IsNewItemRow(e.RowHandle))
            //    {
            //        _objKhachHangBUS.Insert_DM_Khach_Hang(v_objKhachHang);
            //    }
            //    else
            //    {
            //        _objKhachHangBUS.Update_DM_Khach_Hang(v_objKhachHang);
            //    }

            //}

        }

        private void CustomGridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

            //if ((e as EditFormValidateEditorEventArgs).Column == colMa_Khach_Hang)

            //{
            //    if (string.IsNullOrEmpty(e.Value.ToString()))
            //    {
            //        e.Valid = false;
            //        e.ErrorText = "Vui lòng nhập mã khách hàng";
            //    }
            //}

        }

        private void CustomGridView1_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
    }
}