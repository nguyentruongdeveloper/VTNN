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
using DTO.DanhMuc;
using VTNN.Extensions;
using DevExpress.XtraBars;
using VTNN.GUI.DanhMuc.Sub;
using VTNN.GUI.Common;

namespace VTNN.GUI.DanhMuc
{
    public partial class frmQuy : frmTemplateCategory, IDanhMuc
    {
        CDM_Quy_BUS _objQuyBUS = CDM_Quy_BUS.getInstance();

        public frmQuy()
        {
            InitializeComponent();
        }

        private void frmQuy_Load(object sender, EventArgs e)
        {
            FormatControl();
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

            grcQuy.DataSource = _objQuyBUS.Get_List_All();
            Show_Button_MenuContext();

        }

        private void Show_Button_MenuContext()
        {
            if (grvQuy.RowCount <= 0)
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
            using (frmChiTietQuy frm = new frmChiTietQuy())
            {
                frm.fStatus = Utility.FormStatus.Add;
                frm.ReLoadParent = this.Load_Data_Form;
                frm.ShowDialog();
            }

        }

        public void Updated()
        {
            if (grvQuy.RowCount > 0 && grvQuy.FocusedRowHandle >= 0)
            {


                using (frmChiTietQuy frm = new frmChiTietQuy())
                {
                    frm.fStatus = Utility.FormStatus.Edit;
                    CDM_Quy v_objQuy = (CDM_Quy)grvQuy.GetRow(grvQuy.FocusedRowHandle);
                    frm._objQuy = v_objQuy;
                    frm.ReLoadParent = this.Load_Data_Form;
                    frm.ShowDialog();
                }
            }

        }

        public void Deleted()
        {
            if (grvQuy.RowCount > 0 && grvQuy.FocusedRowHandle >= 0 && CExtensions.showConfirmMessage("Xác nhận xóa dữ liệu"))
            {

                CDM_Quy v_objQuy = (CDM_Quy)grvQuy.GetRow(grvQuy.FocusedRowHandle);
                if (v_objQuy != null)
                {
                    try
                    {
                        _objQuyBUS.Deleted(v_objQuy.Auto_ID, "Admin");
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