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
using VTNN.GUI.Common;
using DevExpress.XtraBars;
using VTNN.GUI.DanhMuc.Sub;
using BUS.DanhMuc;
using DTO.DanhMuc;
using VTNN.Extensions;

namespace VTNN.GUI.DanhMuc
{
    public partial class frmHangHoa : frmTemplateCategory, IDanhMuc
    {
        CDM_Hang_Hoa_BUS _objHangHoaBUS = CDM_Hang_Hoa_BUS.getInstance();
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            FormatControl();
            Load_Repository();
            Load_Data_Form();

        }
        public void FormatControl()
        {
            FormatControl(this);
            grvHangHoa.Format(false, true, true);


        }



        public void Load_Repository()
        {

        }

        public void Load_Data_Form()
        {


            grcHangHoa.DataSource = _objHangHoaBUS.Get_List_All();
            grvHangHoa.ExpandAllGroups();
         
            Show_Button_MenuContext();

        }

        private void Show_Button_MenuContext()
        {
            if (grvHangHoa.RowCount <= 0)
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
            using (frmChiTietHangHoa frm = new frmChiTietHangHoa())
            {
                frm.fStatus = Utility.FormStatus.Add;
                frm.ReLoadParent = this.Load_Data_Form;
                frm.ShowDialog();
            }

        }

        public void Updated()
        {
            if (grvHangHoa.RowCount > 0 && grvHangHoa.FocusedRowHandle >= 0)
            {


                using (frmChiTietHangHoa frm = new frmChiTietHangHoa())
                {
                    frm.fStatus = Utility.FormStatus.Edit;
                    CDM_Hang_Hoa v_objHangHoa = (CDM_Hang_Hoa)grvHangHoa.GetRow(grvHangHoa.FocusedRowHandle);
                    frm._objHangHoa = v_objHangHoa;
                    frm.ReLoadParent = this.Load_Data_Form;
                    frm.ShowDialog();
                }
            }

        }

        public void Deleted()
        {
            if (grvHangHoa.RowCount > 0 && grvHangHoa.FocusedRowHandle >= 0 && CExtensions.showConfirmMessage("Xác nhận xóa dữ liệu"))
            {

                CDM_Hang_Hoa v_objHangHoa = (CDM_Hang_Hoa)grvHangHoa.GetRow(grvHangHoa.FocusedRowHandle);
                if (v_objHangHoa != null)
                {
                    try
                    {
                        _objHangHoaBUS.Deleted(v_objHangHoa.Auto_ID, "Admin");
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