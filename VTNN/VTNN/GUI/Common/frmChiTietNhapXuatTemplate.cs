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
using DevExpress.XtraGrid.Views.Base;
using Utility;

namespace VTNN.GUI.Common
{
    public partial class frmChiTietNhapXuatTemplate : frmTemplate
    {

        public frmChiTietNhapXuatTemplate()
        {
            InitializeComponent();
        }
        protected virtual void frmChiTietNhapXuatTemplate_Load(object sender, EventArgs e)
        {
            
        }
        protected virtual void Set_Thong_Tin_Hien_Thi(NhapXuat p_NhapXuat=NhapXuat.Default)
        {

            if (p_NhapXuat == NhapXuat.ChungTuBanHang || p_NhapXuat == NhapXuat.ChungTuHangBanTraLai ||
                p_NhapXuat == NhapXuat.ChungTuNhapHang || p_NhapXuat == NhapXuat.ChungTuHangMuaTraLai)
            {
                layout_Kho.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layout_DKTT.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layout_HTTT.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layout_CheckCK.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layout_CheckKhuyenMai.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layout_CheckVAT.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                colNgay_Het_Han.Visible = false;
                colNgay_San_Xuat.Visible = false;
                layoutControlGroup6.Expanded = true;
               
            }
            if (p_NhapXuat == NhapXuat.ChungTuNhapKho || p_NhapXuat == NhapXuat.ChungTuXuatKho)
            {
                layout_Kho.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layout_DKTT.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layout_HTTT.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layout_CheckCK.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layout_CheckKhuyenMai.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layout_CheckVAT.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                colKho.Visible = false;
                colNgay_San_Xuat.Visible = true;
                colNgay_San_Xuat.VisibleIndex = colThanh_Tien.VisibleIndex + 1;
                colNgay_Het_Han.Visible = true;
                colNgay_Het_Han.VisibleIndex = colNgay_San_Xuat.VisibleIndex + 1;
                layoutControlGroup6.Expanded = false;
            }
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
        protected virtual bool Preview()
        {
            bool v_blResult = true;
            return v_blResult;
        }
        protected virtual void ClosedForm()
        {

        }
        protected virtual void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btnSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btnSaveAndPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btnPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btnClosed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private int Count_Columns_Visible()
        {
            int v_iCount = 0;
            foreach (DevExpress.XtraGrid.Columns.GridColumn v_objCol in grvChiTiet.Columns)
            {
                if (v_objCol.Visible)
                {
                    v_iCount++;
                }
            }
            return v_iCount;
        }

        private void ckChiet_Khau_CheckedChanged(object sender, EventArgs e)
        {
            int v_iCount_Column_Visible = colThanh_Tien.VisibleIndex;

            if (layout_CK.IsEditorActive)
            {
                if (layout_CK.Checked)
                {


                    colPhan_Tram_CK.VisibleIndex = v_iCount_Column_Visible + 1;

                    colTien_CK.VisibleIndex = colPhan_Tram_CK.VisibleIndex + 1;
                    colPhan_Tram_CK.Visible = true;
                    colTien_CK.Visible = true;




                }
                else
                {
                    colPhan_Tram_CK.Visible = false;
                    colTien_CK.Visible = false;
                }
            }
        }

        private void ckVAT_CheckedChanged(object sender, EventArgs e)
        {

            if (ckVAT.IsEditorActive)
            {
                if (ckVAT.Checked)
                {

                    if (colPhan_Tram_CK.Visible)
                    {
                        int v_iIndex = colPhan_Tram_CK.VisibleIndex;
                        colPhan_Tram_VAT.VisibleIndex = v_iIndex + 1;
                        colTien_VAT.VisibleIndex = colPhan_Tram_VAT.VisibleIndex + 1;
                        colPhan_Tram_VAT.Visible = true;
                        colTien_VAT.Visible = true;
                    }
                    else
                    {
                        int v_iIndex = colThanh_Tien.VisibleIndex;
                        colPhan_Tram_VAT.VisibleIndex = v_iIndex + 1;
                        colTien_VAT.VisibleIndex = colPhan_Tram_VAT.VisibleIndex + 1;
                    }





                }
                else
                {
                    colTien_VAT.Visible = false;
                    colPhan_Tram_VAT.Visible = false;
                }
            }
        }

        private void ckKhuyen_Mai_CheckedChanged(object sender, EventArgs e)
        {
            int v_iCount_Column_Visible = Count_Columns_Visible();
            if (ckKhuyen_Mai.IsEditorActive)
            {
                if (ckKhuyen_Mai.Checked)
                {

                    colKhuyen_Main.VisibleIndex = colKho.VisibleIndex;
                    colKhuyen_Main.Visible = true;


                }
                else
                {
                    colKhuyen_Main.Visible = false;
                }
            }
        }
    }
}