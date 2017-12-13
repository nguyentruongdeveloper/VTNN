using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.EditForm.Helpers.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTNN.Extensions
{
    public static class CFormatControl
    {
        #region DateEdit
        public static void Format_VS1(this DateEdit dteMain)
        {
            dteMain.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            dteMain.Properties.Mask.EditMask = "99/99/0000";
            dteMain.Properties.Mask.UseMaskAsDisplayFormat = true;
            dteMain.Properties.AllowNullInput = DefaultBoolean.True;
            dteMain.Validating += DateEdit_Validating;
            dteMain.InvalidValue += Date_InvalidValue;

        }
        public static void Format_VS1(this RepositoryItemDateEdit dteMain)
        {

            dteMain.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            dteMain.Mask.EditMask = "99/99/0000";
            dteMain.Mask.UseMaskAsDisplayFormat = true;
            dteMain.AllowNullInput = DefaultBoolean.True;
            dteMain.Validating += DateEdit_Validating;



        }
        private static void Date_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        }

        private static void DateEdit_Validating(object sender, CancelEventArgs e)
        {


            DateEdit v_objDateEdit = (sender as DateEdit);
            v_objDateEdit.ErrorText = "";
            if (v_objDateEdit.DateTime == DateTime.MinValue && v_objDateEdit.Text != "__/__/____")
            {
                v_objDateEdit.ErrorText = "Vui lòng chọn lại ngày!";
                e.Cancel = true;
            }


        }
        #endregion
        #region Format SpinEdit
        public static void Format(this SpinEdit spnMain, int DecimalScale = 0, bool LeftAlight = true, bool NotNegative = true, bool FormatNumber = true)
        {
            spnMain.Properties.Buttons.Clear();
            spnMain.Properties.Mask.UseMaskAsDisplayFormat = true;
            spnMain.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            spnMain.Properties.AppearanceReadOnly.TextOptions.HAlignment = spnMain.Properties.AppearanceFocused.TextOptions.HAlignment = spnMain.Properties.Appearance.TextOptions.HAlignment = LeftAlight ? HorzAlignment.Near : HorzAlignment.Far;
            spnMain.Properties.Mask.EditMask = spnMain.Properties.DisplayFormat.FormatString = spnMain.Properties.EditFormat.FormatString = "N" + DecimalScale.ToString();
            if (NotNegative)
            {
                spnMain.KeyPress += NotNegative_KeyPress;
                if (spnMain.Properties.MinValue == spnMain.Properties.MaxValue)
                {
                    spnMain.Properties.MaxValue = decimal.MaxValue;
                }
                if (spnMain.Properties.MinValue < 0)
                    spnMain.Properties.MinValue = 0;

            }
            if (FormatNumber)
            {

                spnMain.Properties.DisplayFormat.FormatType = FormatType.Custom;
                spnMain.Properties.DisplayFormat.FormatString = "{0:###,###,###.####}";
            }
        }
        public static void NotNegative_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
        public static void Format(this RepositoryItemSpinEdit rspnMain, int DecimalScale = 0, bool LeftAlight = true, bool NotNegative = true)
        {
            rspnMain.Buttons.Clear();
            rspnMain.Mask.UseMaskAsDisplayFormat = true;
            rspnMain.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            rspnMain.AppearanceReadOnly.TextOptions.HAlignment = rspnMain.AppearanceFocused.TextOptions.HAlignment = rspnMain.Appearance.TextOptions.HAlignment = LeftAlight ? HorzAlignment.Near : HorzAlignment.Far;
            rspnMain.Mask.EditMask = rspnMain.DisplayFormat.FormatString = rspnMain.EditFormat.FormatString = "N" + DecimalScale.ToString();
            if (NotNegative)
            {
                rspnMain.KeyPress += NotNegative_KeyPress;
                if (rspnMain.MinValue == rspnMain.MaxValue)
                {
                    rspnMain.MaxValue = decimal.MaxValue;
                }
                if (rspnMain.MinValue < 0)
                    rspnMain.MinValue = 0;
            }
        }
        #endregion

        #region SearchLookupEdit

        public static void Format(this SearchLookUpEdit slokMain, bool showHeader = true)
        {
            slokMain.Properties.ShowAddNewButton = false;
            slokMain.Properties.ShowClearButton = false;
            slokMain.Properties.ShowFooter = false;
            slokMain.Properties.NullValuePrompt = slokMain.Properties.NullText = "";
        }
        public static void formatSearchLookupEdit(this SearchLookUpEdit slokMain, bool showHeader = true, int Width = 0, int Height = 0)
        {
            slokMain.Properties.ShowAddNewButton = false;
            slokMain.Properties.ShowClearButton = false;
            slokMain.Properties.ShowFooter = false;
            slokMain.Properties.NullValuePrompt = slokMain.Properties.NullText = "";
            slokMain.Properties.PopupFormSize = new Size(Width, Height);
        }
        #endregion

        #region Format LookUpEdit
        public static void Format(this LookUpEdit lokMain, bool showHeader = true)
        {
            lokMain.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            lokMain.Properties.ShowFooter = false;
            lokMain.Properties.NullText = String.Empty;
            lokMain.Properties.ShowHeader = showHeader;
            lokMain.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;

            lokMain.Properties.SearchMode = SearchMode.AutoFilter;
            lokMain.Properties.AllowNullInput = DefaultBoolean.True;
            lokMain.Properties.AutoSearchColumnIndex = 1;
            lokMain.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = HorzAlignment.Center;
            lokMain.Properties.HighlightedItemStyle = HighlightStyle.Standard;

            lokMain.Translation();
            lokMain.FormatColumnLookUpEdit();
        }

        public static void Translation(this LookUpEdit lokMain)
        {
            string fName = "";
            try { fName = lokMain.FindForm().Name; }
            catch { }
            if (!string.IsNullOrEmpty(fName) && lokMain != null && lokMain.Properties.Columns.Count > 0)
            {
                //db = new aModel();
                //List<xMsgDictionary> lstAdd = new List<xMsgDictionary>();
                //foreach (LookUpColumnInfo col in lokMain.Properties.Columns)
                //{
                //    string mName = string.Format("{0}_{1}", lokMain.Name, col.FieldName);
                //    var myTrans = db.xMsgDictionaries.FirstOrDefault<xMsgDictionary>(n => n.FormName.Equals(fName) && n.MsgName.Equals(mName));
                //    if (myTrans == null)
                //    {
                //        lstAdd.Add(myTrans = new xMsgDictionary()
                //        {
                //            FormName = fName,
                //            MsgName = mName,
                //            VN = col.Caption,
                //            EN = col.FieldName.AutoSpace()
                //        });

                //    }
                //    col.Caption = myTrans.GetStringByName(curCulture);
                //}
                //if (lstAdd != null && lstAdd.Count() > 0)
                //{
                //    try
                //    {
                //        db.xMsgDictionaries.AddRange(lstAdd);
                //        db.SaveChanges();
                //    }
                //    catch { }
                //}
            }
        }

        public static void FormatColumnLookUpEdit(this LookUpEdit lokMain, string fName = "")
        {
            if (string.IsNullOrEmpty(fName))
            {
                try { fName = lokMain.FindForm().Name; }
                catch { }
            }
            if (string.IsNullOrEmpty(fName) || lokMain.Properties.Columns.Count == 0 || !lokMain.Properties.ShowHeader) return;

            //db = new aModel();
            //List<xDisplay> lstAdd = new List<xDisplay>();

            //bool addCol = false;
            //foreach (LookUpColumnInfo col in lokMain.Properties.Columns)
            //{
            //    addCol = false;
            //    xDisplay myDisplay = null;
            //    try
            //    {
            //        myDisplay = db.xDisplays.FirstOrDefault<xDisplay>(n => n.ParentName.Equals(fName) && n.Group.Equals(lokMain.Name) && n.ColumnName.Equals(col.FieldName));

            //        addCol = (myDisplay == null);
            //    }
            //    catch { addCol = true; }
            //    finally
            //    {
            //        if (addCol && lokMain.Properties.DataSource != null)
            //        {
            //            myDisplay = new xDisplay();
            //            myDisplay.ParentName = fName;
            //            myDisplay.Group = lokMain.Name;
            //            myDisplay.ColumnName = col.FieldName;
            //            myDisplay.FieldName = col.FieldName;
            //            myDisplay.Showing = col.Visible;

            //            string cType = "None";
            //            string cAlign = "Default";
            //            if (col.FormatType == FormatType.DateTime)
            //            {
            //                cType = "DateTime"; cAlign = "Center";
            //            }
            //            else if (col.FormatType == FormatType.Numeric)
            //            {
            //                cType = "Numeric"; cAlign = "Far";
            //            }
            //            else
            //            {
            //                cType = "Custom"; cAlign = "Near";
            //            }

            //            myDisplay.Type = cType;
            //            myDisplay.TextAlign = cAlign;
            //            myDisplay.EnableEdit = false;
            //            lstAdd.Add(myDisplay);
            //        }
            //        else if (myDisplay == null)
            //            myDisplay = db.xDisplays.FirstOrDefault<xDisplay>(hts => hts.ParentName.Equals(fName) && hts.Group.Equals(lokMain.Name) && hts.ColumnName.Equals(col.FieldName));

            //        if (myDisplay != null)
            //        {
            //            col.Visible = myDisplay.Showing;
            //            col.FieldName = myDisplay.FieldName;
            //            if (myDisplay.Type != null)
            //            {
            //                if (lokMain.Properties.DataSource != null)
            //                    lokMain.Properties.AppearanceDropDownHeader.ForeColor = MyColor.GridForeHeader;

            //                col.FormatType = (FormatType)Enum.Parse(typeof(FormatType), myDisplay.Type);
            //                col.Alignment = (HorzAlignment)Enum.Parse(typeof(HorzAlignment), myDisplay.TextAlign);

            //                if (myDisplay.Type.Equals("Numeric") && curDecimalFormat != null && string.IsNullOrEmpty(col.FormatString))
            //                    col.FormatString = curDecimalFormat;
            //                else if (myDisplay.Type.Equals("DateTime") && curDateFormat != null && string.IsNullOrEmpty(col.FormatString))
            //                    col.FormatString = curDateFormat;
            //            }
            //        }
            //    }
            //}

            //if (lstAdd != null && lstAdd.Count > 0)
            //{
            //    try
            //    {
            //        db = new aModel();
            //        db.xDisplays.AddRange(lstAdd);
            //        db.SaveChanges();
            //    }
            //    catch { }
            //}
        }

        public static int ToInt(this LookUpEdit lokMain)
        {
            try
            {
                if (lokMain.ItemIndex < 0)
                    return 0;
                else
                    return Convert.ToInt32(lokMain.EditValue);
            }
            catch { return 0; }
        }

        public static int ToInt16(this LookUpEdit lokMain)
        {
            try
            {
                if (lokMain.ItemIndex < 0)
                    return 0;
                else
                    return Convert.ToInt16(lokMain.EditValue);
            }
            catch { return 0; }
        }

        public static decimal ToDecimal(this LookUpEdit lokMain)
        {
            try
            {
                if (lokMain.ItemIndex < 0)
                    return 0;
                else
                    return Convert.ToDecimal(lokMain.EditValue);
            }
            catch { return 0; }
        }
        #endregion

        #region Format RepositoryLookUpEdit
        public static void Format(this RepositoryItemLookUpEdit rlokMain, string fName = "", bool showHeader = false)
        {
            rlokMain.NullText = "";
            rlokMain.ShowFooter = false;
            rlokMain.AllowFocused = false;
            rlokMain.ShowHeader = showHeader;
            rlokMain.AppearanceDropDownHeader.TextOptions.HAlignment = HorzAlignment.Center;
            rlokMain.AppearanceDropDownHeader.Options.UseFont = false;
            rlokMain.TextEditStyle = TextEditStyles.DisableTextEditor;
            rlokMain.BestFitMode = BestFitMode.BestFitResizePopup;

        }

        public static void Translation(this RepositoryItemLookUpEdit rlokMain, string fName)
        {
            if (!string.IsNullOrEmpty(fName) && rlokMain != null && rlokMain.Columns.Count > 0)
            {
                //db = new aModel();
                //List<xMsgDictionary> lstAdd = new List<xMsgDictionary>();
                //foreach (LookUpColumnInfo col in rlokMain.Columns)
                //{
                //    string mName = string.Format("{0}_{1}", rlokMain.Name, col.FieldName);
                //    var myTrans = db.xMsgDictionaries.FirstOrDefault<xMsgDictionary>(n => n.FormName.Equals(fName) && n.MsgName.Equals(mName));
                //    if (myTrans == null)
                //    {
                //        lstAdd.Add(myTrans = new xMsgDictionary()
                //        {
                //            FormName = fName,
                //            MsgName = mName,
                //            VN = col.Caption,
                //            EN = col.FieldName.AutoSpace()
                //        });

                //    }
                //    col.Caption = myTrans.GetStringByName(curCulture);
                //}
                //if (lstAdd != null && lstAdd.Count() > 0)
                //{
                //    try
                //    {
                //        db.xMsgDictionaries.AddRange(lstAdd);
                //        db.SaveChanges();
                //    }
                //    catch { }
                //}
            }
        }

        public static void FormatColumnRepositoryLookUpEdit(this RepositoryItemLookUpEdit rlokMain, string fName)
        {
            //db = new aModel();
            //List<xDisplay> lstAdd = new List<xDisplay>();

            //bool addCol = false;
            //foreach (LookUpColumnInfo col in rlokMain.Columns)
            //{
            //    addCol = false;
            //    xDisplay myDisplay = null;
            //    try
            //    {
            //        myDisplay = db.xDisplays.FirstOrDefault<xDisplay>(hts => hts.ParentName.Equals(fName) && hts.Group.Equals(rlokMain.Name) && hts.ColumnName.Equals(col.FieldName));

            //        if (myDisplay == null)
            //            addCol = true;
            //    }
            //    catch { addCol = true; }
            //    finally
            //    {
            //        if (addCol && rlokMain.DataSource != null)
            //        {
            //            myDisplay = new xDisplay();
            //            myDisplay.ParentName = fName;
            //            myDisplay.Group = rlokMain.Name;
            //            myDisplay.ColumnName = col.FieldName;
            //            myDisplay.FieldName = col.FieldName;
            //            myDisplay.Showing = col.Visible;

            //            string cType = "None";
            //            string cAlign = "Default";
            //            if (col.FormatType == FormatType.DateTime)
            //            {
            //                cType = "DateTime"; cAlign = "Center";
            //            }
            //            else if (col.FormatType == FormatType.Numeric)
            //            {
            //                cType = "Numeric"; cAlign = "Far";
            //            }
            //            else
            //            {
            //                cType = "Custom"; cAlign = "Near";
            //            }

            //            myDisplay.Type = cType;
            //            myDisplay.TextAlign = cAlign;
            //            myDisplay.EnableEdit = false;
            //            lstAdd.Add(myDisplay);
            //        }
            //        else if (myDisplay == null)
            //            myDisplay = db.xDisplays.FirstOrDefault<xDisplay>(hts => hts.ParentName.Equals(fName) && hts.Group.Equals(rlokMain.Name) && hts.ColumnName.Equals(col.FieldName));


            //        if (myDisplay != null)
            //        {
            //            col.Visible = myDisplay.Showing;
            //            col.FieldName = myDisplay.FieldName;
            //            if (myDisplay.Type != null)
            //            {
            //                if (rlokMain.DataSource != null)
            //                    rlokMain.AppearanceDropDownHeader.ForeColor = MyColor.GridForeHeader;

            //                col.FormatType = (FormatType)Enum.Parse(typeof(FormatType), myDisplay.Type);
            //                col.Alignment = (HorzAlignment)Enum.Parse(typeof(HorzAlignment), myDisplay.TextAlign);

            //                if (myDisplay.Type.Equals("Numeric") && curDecimalFormat != null && string.IsNullOrEmpty(col.FormatString))
            //                    col.FormatString = curDecimalFormat;
            //                else if (myDisplay.Type.Equals("DateTime") && curDateFormat != null && string.IsNullOrEmpty(col.FormatString))
            //                    col.FormatString = curDateFormat;
            //            }
            //        }
            //    }
            //}

            //if (lstAdd != null && lstAdd.Count() > 0)
            //{
            //    try
            //    {
            //        db = new aModel();
            //        db.xDisplays.AddRange(lstAdd);
            //        db.SaveChanges();
            //    }
            //    catch { }
            //}
        }
        #endregion

        #region GridControl
        public static void Format(this GridView grvMain, bool p_blShowNewRow, bool p_blShowGroupPanel=false, bool ColumnAuto=true)
        {
            grvMain.OptionsSelection.EnableAppearanceFocusedCell = false;
            grvMain.OptionsView.RowAutoHeight = true;
            grvMain.OptionsView.ColumnAutoWidth = ColumnAuto;
         
            if (p_blShowNewRow)
            {

                grvMain.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }
            if(p_blShowGroupPanel)
            {
                grvMain.OptionsView.ShowGroupPanel = true;
               
               

                
            }
            //grvMain.Translation();
            //grvMain.FormatColmnsGridView();
            grvMain.BestFitColumns();
        }
        private static void OnEditFormShowing(object sender, EditFormShowingEventArgs e)
        {


        }
        private static void grvMain_ShowingPopupEditForm(object sender, ShowingPopupEditFormEventArgs e)
        {
            foreach (Control control in e.EditForm.Controls)
            {
                if (!(control is EditFormContainer))
                {
                    continue;
                }
                foreach (Control nestedControl in control.Controls)
                {
                    if (!(nestedControl is PanelControl))
                    {
                        continue;
                    }
                    foreach (Control button in nestedControl.Controls)
                    {
                        if (button is SimpleButton)
                        {
                            var simpleButton = button as SimpleButton;
                            ChangeButtonCaption(simpleButton);
                            ChangeButtonSize(simpleButton);
                        }
                    }
                }
            }
        }
        private static void ChangeButtonCaption(SimpleButton btn)
        {
            var newUpdateBtnText = "Lưu";
            var newCancelBtnText = "Hủy";
            var btnText = btn.Text;
            switch (btnText)
            {
                case "Update":
                    btn.Text = newUpdateBtnText;
                    //btn.Image = Properties.Resources.;

                    break;
                case "Cancel":
                    btn.Text = newCancelBtnText;
                    //btn.Image = Properties.Resources.cancel_16x16;
                    break;
            }
        }
        private static void ChangeButtonSize(SimpleButton btn)
        {
            btn.CalcBestSize();
        }
        private static void grvMain_EditFormPrepared(object sender, EditFormPreparedEventArgs e)
        {
            (e.Panel.Parent as Form).StartPosition = FormStartPosition.CenterScreen;
        }



        private static void grvMain_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView grvMain = (GridView)sender;
            grvMain.OptionsSelection.EnableAppearanceFocusedCell = true;
            grvMain.OptionsSelection.EnableAppearanceFocusedRow = true;
            grvMain.OptionsSelection.EnableAppearanceHideSelection = true;

        }

        public static void FormatColmnsGridView(this GridView grvMain)
        {
            //Format Colum Text
            foreach (GridColumn v_objCol in grvMain.Columns)
            {
                if (v_objCol.ColumnEdit != null)
                {
                    //Format colum spin edit
                    if (v_objCol.ColumnEdit.GetType().Name == "RepositoryItemSpinEdit")
                    {
                        v_objCol.DisplayFormat.FormatType = FormatType.Custom;
                        v_objCol.DisplayFormat.FormatString = "{0:###,###,###.####}";

                    }
                    //Format colum date edit
                    if (v_objCol.ColumnEdit.GetType().Name == "RepositoryItemDateEdit")
                    {
                        v_objCol.DisplayFormat.FormatType = FormatType.Custom;
                        v_objCol.DisplayFormat.FormatString = "{0:dd-MM-yyyy}";
                        v_objCol.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;

                    }

                }

            }

            //if (grvMain == null || grvMain.Columns.Count == 0 || grvMain.Columns[0].AppearanceHeader.ForeColor == MyColor.GridForeHeader) return;
            //if (string.IsNullOrEmpty(fName))
            //{
            //    try
            //    {
            //        fName = grvMain.GridControl.FindForm().Name;
            //        if (string.IsNullOrEmpty(fName)) return;
            //    }
            //    catch { return; }
            //}
            //List<xDisplay> lstAdd = new List<xDisplay>();
            //grvMain.BeginInit();
            //foreach (GridColumn col in grvMain.Columns)
            //{
            //    bool addCol = !db.xDisplays.Any(hts => hts.ParentName.Equals(fName) && hts.Group.Equals(grvMain.Name) && hts.ColumnName.Equals(col.Name));
            //    xDisplay myDisplay = null;

            //    if (addCol && grvMain.DataSource != null && grvMain.RowCount > 0)
            //    {
            //        myDisplay = new xDisplay();
            //        myDisplay.ParentName = fName;
            //        myDisplay.Group = grvMain.Name;
            //        myDisplay.ColumnName = col.Name;
            //        myDisplay.FieldName = col.FieldName;
            //        myDisplay.Showing = col.Visible;

            //        string cType = "None";
            //        string cAlign = "Default";
            //        if (col.ColumnType == typeof(Nullable<DateTime>) || col.ColumnType == typeof(DateTime) || col.UnboundType == DevExpress.Data.UnboundColumnType.DateTime)
            //        {
            //            cType = "DateTime"; cAlign = "Center";
            //        }
            //        else if (col.ColumnType == typeof(Nullable<Decimal>) || col.ColumnType == typeof(Decimal) || col.ColumnType == typeof(Nullable<int>) || col.ColumnType == typeof(int) || col.ColumnType == typeof(Nullable<Double>) || col.ColumnType == typeof(Double) || col.ColumnType == typeof(Nullable<long>) || col.ColumnType == typeof(long) || col.ColumnType == typeof(Nullable<float>) || col.ColumnType == typeof(float) || col.UnboundType == DevExpress.Data.UnboundColumnType.Decimal || col.UnboundType == DevExpress.Data.UnboundColumnType.Integer)
            //        {
            //            cType = "Numeric"; cAlign = "Far";
            //            if (col.ColumnEdit != null)
            //                cAlign = "Near";
            //        }
            //        else if (col.DisplayFormat.FormatType == FormatType.Custom)
            //        {
            //            cType = "Custom"; cAlign = "Near";
            //        }

            //        myDisplay.Type = cType;
            //        myDisplay.TextAlign = cAlign;
            //        myDisplay.EnableEdit = col.OptionsColumn.AllowEdit;
            //        lstAdd.Add(myDisplay);
            //    }
            //    else if (myDisplay == null)
            //        myDisplay = db.xDisplays.FirstOrDefault<xDisplay>(hts => hts.ParentName.Equals(fName) && hts.Group.Equals(grvMain.Name) && hts.ColumnName.Equals(col.Name));

            //    if (myDisplay != null)
            //    {
            //        col.Visible = myDisplay.Showing;
            //        col.FieldName = myDisplay.FieldName;
            //        if (myDisplay.Type != null)
            //        {
            //            if (col.ColumnEdit == null)
            //                col.AppearanceCell.TextOptions.HAlignment = (HorzAlignment)Enum.Parse(typeof(HorzAlignment), myDisplay.TextAlign);

            //            if (myDisplay.Type.Equals("Numeric") && curDecimalFormat != null && string.IsNullOrEmpty(col.DisplayFormat.FormatString))
            //            {
            //                col.DisplayFormat.FormatType = FormatType.Numeric;
            //                col.DisplayFormat.FormatString = curDecimalFormat;
            //                if (col.ColumnEdit != null)
            //                {
            //                    col.ColumnEdit.EditFormat.FormatType = FormatType.Numeric;
            //                    col.ColumnEdit.EditFormat.FormatString = curDecimalFormat;
            //                }
            //            }
            //            else if (myDisplay.Type.Equals("DateTime") && curDateFormat != null && string.IsNullOrEmpty(col.DisplayFormat.FormatString))
            //            {
            //                col.DisplayFormat.FormatType = FormatType.DateTime;
            //                col.DisplayFormat.FormatString = curDateFormat;
            //                if (col.ColumnEdit != null)
            //                {
            //                    col.ColumnEdit.EditFormat.FormatType = FormatType.DateTime;
            //                    col.ColumnEdit.EditFormat.FormatString = curDateFormat;
            //                }
            //            }
            //        }
            //        grvMain.OptionsNavigation.EnterMoveNextColumn = col.OptionsColumn.AllowFocus = col.OptionsColumn.AllowEdit = myDisplay.EnableEdit;
            //    }
            //}
            //grvMain.EndInit();
            //if (lstAdd != null && lstAdd.Count() > 0)
            //{
            //    try
            //    {
            //        db.xDisplays.AddRange(lstAdd);
            //        db.SaveChanges();
            //    }
            //    catch { }
            //}
        }

        public static void Translation(this GridView grvMain)
        {
            string fName = "";
            try
            {
                fName = grvMain.GridControl.FindForm().Name;
            }
            catch { }
            if (!string.IsNullOrEmpty(fName) && grvMain != null && grvMain.Columns.Count > 0)
            {
                //db = new aModel();
                //List<xMsgDictionary> lstAdd = new List<xMsgDictionary>();
                //foreach (GridColumn col in grvMain.Columns)
                //{
                //    string mName = string.Format("{0}_{1}", grvMain.Name, col.Name);
                //    var myTrans = db.xMsgDictionaries.FirstOrDefault<xMsgDictionary>(n => n.FormName.Equals(fName) && n.MsgName.Equals(mName));
                //    if (myTrans == null)
                //    {
                //        lstAdd.Add(myTrans = new xMsgDictionary()
                //        {
                //            FormName = fName,
                //            MsgName = mName,
                //            VN = col.GetCaption(),
                //            EN = col.Name.AutoSpace()
                //        });

                //    }
                //    col.Caption = myTrans.GetStringByName(curCulture);
                //    col.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                //}
                //if (lstAdd != null && lstAdd.Count() > 0)
                //{
                //    try
                //    {
                //        db.xMsgDictionaries.AddRange(lstAdd);
                //        db.SaveChanges();
                //    }
                //    catch { }
                //}
            }
        }

        private static void CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Info.DisplayText)) return;
            bool indicatorIcon = false;
            DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;

            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
                e.Appearance.TextOptions.VAlignment = VertAlignment.Center;
                e.Appearance.DrawString(e.Cache, e.RowHandle.ToString(), e.Bounds);
                //e.Info.DisplayText = Convert.ToString(int.Parse(e.RowHandle.ToString()) + 1);
                e.Info.DisplayText = (Convert.ToInt16(e.RowHandle + 1)).ToString();
                //e.Appearance.Font = new Font("Arial", 9.75F);
                if (!indicatorIcon)
                    e.Info.ImageIndex = -1;
            }
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
                e.Appearance.TextOptions.VAlignment = VertAlignment.Center;

                e.Appearance.DrawString(e.Cache, e.RowHandle.ToString(), e.Bounds);
                e.Info.DisplayText = "";
            }
            //e.Appearance.ForeColor = MyColor.GridForeHeader;
            e.Painter.DrawObject(e.Info);
            e.Handled = true;
        }

        private static void grvMain_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.Ignore;
        }

        #endregion


    }
}
