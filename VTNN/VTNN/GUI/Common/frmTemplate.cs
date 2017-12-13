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
using VTNN.Extensions;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using Utility;

namespace VTNN.GUI.Common
{
    public partial class frmTemplate : DevExpress.XtraEditors.XtraForm
    {
        public FormType fType { get; set; } = FormType.List;
        public FormStatus fStatus { get; set; }
        public frmTemplate()
        {
            InitializeComponent();
        }

        protected virtual void frmTemplate_Load(object sender, EventArgs e)
        {
            Set_Default_Font();


        }

        protected virtual void Set_Default_Font()
        {
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new Font("Arial", 10);
        }
        protected virtual void FormatControl(Control p_objControl)
        {

            if (p_objControl.GetType().ToString() == "VTNN.Lib.CustomDateEdit")
            {
                DevExpress.XtraEditors.DateEdit v_objDateEdit = (DevExpress.XtraEditors.DateEdit)p_objControl;
                v_objDateEdit.Format_VS1();


            }

            if (p_objControl.GetType().ToString() == "VTNN.Lib.CustomSpinEdit")
            {
                DevExpress.XtraEditors.SpinEdit v_objSpinEdit = (DevExpress.XtraEditors.SpinEdit)p_objControl;
                v_objSpinEdit.Format(0, false, true, true);


            }
            if (p_objControl.GetType().ToString() == "VTNN.Lib.CustomLookUpEdit")
            {
                DevExpress.XtraEditors.LookUpEdit v_objLookupEdit = (DevExpress.XtraEditors.LookUpEdit)p_objControl;
                v_objLookupEdit.Format(false);
            }
            if (p_objControl.GetType().ToString() == "VTNN.Lib.CustomSearchLookUpEdit")
            {
                DevExpress.XtraEditors.SearchLookUpEdit v_objSearchLookUpEdit = (DevExpress.XtraEditors.SearchLookUpEdit)p_objControl;
                v_objSearchLookUpEdit.Format(true);
            }
            if (p_objControl.GetType().ToString() == "VTNN.Lib.CustomGridControl")
            {
                DevExpress.XtraGrid.GridControl v_objGridControl = (DevExpress.XtraGrid.GridControl)p_objControl;
                Format_Grid(v_objGridControl);
            }

            if (p_objControl.Controls != null)
            {
                foreach (Control v_objCon in p_objControl.Controls)
                    FormatControl(v_objCon);
            }
        }
        private void Format_Grid(GridControl p_objGridControl)
        {
            //Properties.Settings.Default.Reload();
            ////int ScaleSoLuong = Convert.ToInt32(Properties.Settings.Default.);
            ////int ScaleDonGia = Convert.ToInt32(Properties.Settings.Default.ScaleDonGia);
            ////int ScaleSoTien = Convert.ToInt32(Properties.Settings.Default.ScaleSoTien);
            ////string v_strFormat = Properties.Settings.Default.FormatSoTien;
            ////Format Gridivew
            DevExpress.XtraGrid.Views.Grid.GridView v_obGridView = (DevExpress.XtraGrid.Views.Grid.GridView)p_objGridControl.MainView;
            v_obGridView.Format(false, false, true);
            // Format colum
            foreach (DevExpress.XtraGrid.Columns.GridColumn v_objCol in ((ColumnView)p_objGridControl.Views[0]).Columns)
            {
                if (v_objCol.ColumnEdit != null /*&& v_objCol.Visible*/)
                {

                    if (v_objCol.ColumnEdit.GetType().Name == "RepositoryItemCustomGridLookUpEdit")
                    {
                        VTNN.Lib.RepositoryItemCustomGridLookUpEdit v_objResLookupEdit = (VTNN.Lib.RepositoryItemCustomGridLookUpEdit)v_objCol.ColumnEdit;
                        v_objResLookupEdit.Format();
                        v_objResLookupEdit.CreateDefaultButton(false, false);
                    }


                    if (v_objCol.ColumnEdit.GetType().Name == "RepositoryItemCustomSpinEdit")
                    {

                        VTNN.Lib.RepositoryItemCustomSpinEdit v_objResSpinEdit = (VTNN.Lib.RepositoryItemCustomSpinEdit)v_objCol.ColumnEdit;
                        v_objResSpinEdit.Format(0, false, true);

                    }

                    if (v_objCol.ColumnEdit.GetType().Name == " RepositoryItemCustomDateEdit")
                    {
                        VTNN.Lib.RepositoryItemCustomDateEdit v_objResDateEdit = (VTNN.Lib.RepositoryItemCustomDateEdit)v_objCol.ColumnEdit;
                        v_objResDateEdit.Format_VS1();
                    }
                }

                //Format summary item
                if (v_objCol.SummaryItem != null)
                {
                    //v_objCol.SummaryItem.DisplayFormat = v_strFormat;
                }
            }

        }
        protected virtual void ResetControl(Control p_objControl)
        {
            
            if (p_objControl.GetType().ToString() == "VTNN.Lib.CustomTextEdit")
            {
                VTNN.Lib.CustomTextEdit v_objTextEdit = (VTNN.Lib.CustomTextEdit)p_objControl;
                if (v_objTextEdit.IsRest)
                    v_objTextEdit.Text = "";



            }
           

            if (p_objControl.GetType().ToString() == "VTNN.Lib.CustomMemoEdit")
            {
                VTNN.Lib.CustomMemoEdit v_objMenoEdit = (VTNN.Lib.CustomMemoEdit)p_objControl;
                if (v_objMenoEdit.IsRest)
                    v_objMenoEdit.Text = "";



            }

            if (p_objControl.GetType().ToString() == "VTNN.Lib.CustomDateEdit")
            {
                VTNN.Lib.CustomDateEdit v_objDateEdit = (VTNN.Lib.CustomDateEdit)p_objControl;
                if (v_objDateEdit.IsReset)
                    v_objDateEdit.EditValue = "";



            }

            if (p_objControl.GetType().ToString() == "VTNN.Lib.CustomSpinEdit")
            {
                VTNN.Lib.CustomSpinEdit v_objSpinEdit = (VTNN.Lib.CustomSpinEdit)p_objControl;
                if (v_objSpinEdit.IsRest)
                    v_objSpinEdit.EditValue = 0;


            }
            if (p_objControl.GetType().ToString() == "VTNN.Lib.CustomLookUpEdit")
            {
                VTNN.Lib.CustomLookUpEdit v_objLookupEdit = (VTNN.Lib.CustomLookUpEdit)p_objControl;
                if (v_objLookupEdit.IsRest)
                    v_objLookupEdit.EditValue = 0;
            }
            if (p_objControl.GetType().ToString() == "VTNN.Lib.CustomSearchLookUpEdit")
            {
                VTNN.Lib.CustomSearchLookUpEdit v_objSearchLookUpEdit = (VTNN.Lib.CustomSearchLookUpEdit)p_objControl;
                if (v_objSearchLookUpEdit.IsRest)
                    v_objSearchLookUpEdit.EditValue = 0;
            }
            if (p_objControl.GetType().ToString() == "VTNN.Lib.CustomGridControl")
            {
                VTNN.Lib.CustomGridControl v_objGridControl = (VTNN.Lib.CustomGridControl)p_objControl;
                if (v_objGridControl.IsReset)
                    v_objGridControl.DataSource = null;

            }

            if (p_objControl.Controls != null)
            {
                foreach (Control v_objCon in p_objControl.Controls)
                    ResetControl(v_objCon);
            }
        }

       

        protected virtual void btn_MenuContext_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btn_MenuContext_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btn_MenuContext_Deleted_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btn_MenuContext_DeletedAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btn_MenuContext_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btn_MenuContext_Refesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void btn_MenuContext_Closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}