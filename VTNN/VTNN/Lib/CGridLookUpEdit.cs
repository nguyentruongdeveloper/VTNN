using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Registrator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;
using System.Drawing;

namespace VTNN.Lib
{
    [UserRepositoryItem("RegisterCustomGridLookUpEdit")]
    public class RepositoryItemCustomGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        public bool _ShowButtonAdd { get; set; } = true;
        public bool _ShowButtonRefesh { get; set; } = true;

        static RepositoryItemCustomGridLookUpEdit() { RegisterCustomGridLookUpEdit(); }

        public RepositoryItemCustomGridLookUpEdit()
        {

            Format();
        }
        public void Format()
        {
            TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            AutoComplete = false;
            NullText = "";
            AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            BestFitMode = BestFitMode.BestFitResizePopup;


        }
        public void CreateDefaultButton(bool p_blShowButtonAdd, bool p_blShowButtonRefesh)
        {
            _ShowButtonAdd = p_blShowButtonAdd;
            _ShowButtonRefesh = p_blShowButtonRefesh;
            CreateDefaultButton();
        }
        private void AddDefaultButton(EditorButton btn, System.Windows.Forms.Keys keys, Image p_Image)
        {
            btn.IsDefaultButton = true;
            btn.Shortcut = new DevExpress.Utils.KeyShortcut(keys);
            btn.IsDefaultButton = true;
            btn.Image = p_Image;
            Buttons.Add(btn);
        }
        private void AddDefaultButton(EditorButton btn, Image p_Image)
        {
            btn.IsDefaultButton = true;
            btn.IsDefaultButton = true;
            btn.Image = p_Image;
            Buttons.Add(btn);
        }
        public override void CreateDefaultButton()
        {
            if (Buttons.ToList().Count < 1)
                base.CreateDefaultButton();
            if (_ShowButtonAdd)
            {
                if (Buttons.ToList().Count < 2)
                {
                    AddDefaultButton(new EditorButton(ButtonPredefines.Glyph), VTNN.Properties.Resources.sync_reload_refresh_arrow_16x16);
                }
            }
            else
                Buttons[1].Visible = false;
            if (_ShowButtonRefesh)
            {
                if (Buttons.ToList().Count < 3)
                    AddDefaultButton(new EditorButton(ButtonPredefines.Glyph), VTNN.Properties.Resources.add_plus16x16);
            }
            else
            {
                Buttons[2].Visible = false;
            }

        }
        public void SetDataSource(List<object> p_arrData, string p_strDisplayMember, string p_strValueMember)
        {
            DataSource = p_arrData;
            DisplayMember = p_strDisplayMember;
            ValueMember = p_strValueMember;
        }
        public override void Assign(RepositoryItem item)
        {
            base.Assign(item);
        }
        [Browsable(false)]
        public override DevExpress.XtraEditors.Controls.TextEditStyles TextEditStyle { get { return base.TextEditStyle; } set { base.TextEditStyle = value; } }
        public const string CustomGridLookUpEditName = "CustomGridLookUpEdit";

        public override string EditorTypeName { get { return CustomGridLookUpEditName; } }




        public static void RegisterCustomGridLookUpEdit()
        {


            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomGridLookUpEditName,
              typeof(CustomGridLookUpEdit), typeof(RepositoryItemCustomGridLookUpEdit),
              typeof(GridLookUpEditBaseViewInfo), new ButtonEditPainter(), true));
        }

        protected override GridView CreateViewInstance()
        {

            return new CustomGridView();
        }





        protected override GridControl CreateGrid()
        {
            return new CustomGridControl();
        }
    }

    [ToolboxItem(true)]
    public class CustomGridLookUpEdit : GridLookUpEdit
    {

        public bool ShowButtonAdd { get; set; } = true;
        public bool ShowButtonRefesh { get; set; } = true;
        public bool IsRest { get; set; } = true;
        static CustomGridLookUpEdit() { RepositoryItemCustomGridLookUpEdit.RegisterCustomGridLookUpEdit(); }

        public CustomGridLookUpEdit() : base()
        {

            Format();
        }

        public void Format()
        {
            //Properties.PopupFormMinSize = new Size(600, 300);
            Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            Properties.PopupFilterMode = PopupFilterMode.Default;
            Properties.NullText = "";
            Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            EnterMoveNextControl = true;
        }
        public override string EditorTypeName { get { return RepositoryItemCustomGridLookUpEdit.CustomGridLookUpEditName; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomGridLookUpEdit Properties { get { return base.Properties as RepositoryItemCustomGridLookUpEdit; } }

        public void SetDataSource(List<object> p_arrData, string p_strDisplayMember, string p_strValueMember)
        {
            this.Properties.DataSource = p_arrData;
            this.Properties.DisplayMember = p_strDisplayMember;
            this.Properties.ValueMember = p_strValueMember;
        }
    }
}
