using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Registrator;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace VTNN.Lib
{
    public class CustomGridView : GridView
    {
        public bool IsReset { get; set; } = true;
        public CustomGridView() : base()
        {
            Format();
        }
        public void Format()
        {
            BeginInit();

            // CODE GIAO DIỆN CHO GRIDVIEW SAU
            // ...


            //formmat cell header
            foreach (DevExpress.XtraGrid.Columns.GridColumn v_objcol in this.Columns)
            {
                v_objcol.AppearanceHeader.Font = new Font("Arial", 12);
                v_objcol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }



            OptionsView.EnableAppearanceEvenRow = true;
            OptionsView.ShowGroupPanel = false;
            OptionsView.ShowAutoFilterRow = true;
            OptionsView.ShowGroupPanel = false;
            OptionsView.AllowHtmlDrawHeaders = true;
            IndicatorWidth = 40;
            // tạo thêm cột stt
            CustomDrawRowIndicator += new RowIndicatorCustomDrawEventHandler(CustomGridView_CustomDrawRowIndicator);
            //Tao edit form 

            EndInit();
        }
        public CustomGridView(GridControl grid)
          : base(grid)
        {
            Format();
        }

        void CustomGridView_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }


        protected internal virtual void SetGridControlAccessMetod(GridControl newControl)
        {
            SetGridControl(newControl);
        }

        protected override string OnCreateLookupDisplayFilter(string text, string displayMember)
        {
            List<CriteriaOperator> subStringOperators = new List<CriteriaOperator>();
            foreach (string sString in text.Split(' '))
            {
                string exp = LikeData.CreateContainsPattern(sString);
                List<CriteriaOperator> columnsOperators = new List<CriteriaOperator>();
                foreach (GridColumn col in Columns)
                {
                    if (col.Visible && col.ColumnType == typeof(string))
                        columnsOperators.Add(new BinaryOperator(col.FieldName, exp, BinaryOperatorType.Like));
                }
                subStringOperators.Add(new GroupOperator(GroupOperatorType.Or, columnsOperators));
            }
            return new GroupOperator(GroupOperatorType.And, subStringOperators).ToString();
        }

        protected override string ViewName { get { return "CustomGridView"; } }
        protected virtual internal string GetExtraFilterText { get { return ExtraFilterText; } }
    }
    [ToolboxItem(true)]
    public class CustomGridControl : GridControl
    {
        public bool IsReset { get; set; } = true;
        public CustomGridControl() : base()
        {
            Dock = DockStyle.Fill;
            Name = "grid_data";

        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new CustomGridInfoRegistrator());
        }

        protected override BaseView CreateDefaultView()
        {
            return CreateView("CustomGridView");
        }

    }

    public class CustomGridPainter : GridPainter
    {
        public CustomGridPainter(GridView view) : base(view) { }

        public virtual new CustomGridView View { get { return (CustomGridView)base.View; } }

        protected override void DrawRowCell(GridViewDrawArgs e, GridCellInfo cell)
        {
            cell.ViewInfo.MatchedStringUseContains = true;
            cell.ViewInfo.MatchedString = View.GetExtraFilterText;
            cell.State = GridRowCellState.Dirty;
            e.ViewInfo.UpdateCellAppearance(cell);
            base.DrawRowCell(e, cell);
        }
    }

    public class CustomGridInfoRegistrator : GridInfoRegistrator
    {
        public CustomGridInfoRegistrator() : base() { }
        public override BaseViewPainter CreatePainter(BaseView view) { return new CustomGridPainter(view as DevExpress.XtraGrid.Views.Grid.GridView); }
        public override string ViewName { get { return "CustomGridView"; } }
        public override BaseView CreateView(GridControl grid)
        {
            CustomGridView view = new CustomGridView();
            view.SetGridControlAccessMetod(grid);
            return view;
        }

    }
}
