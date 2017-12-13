using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNN.Lib
{
    [ToolboxItem(true)]
    public class CustomLookUpEdit : LookUpEdit
    {
        public bool IsRest { get; set; } = true;
        static CustomLookUpEdit() { RepositoryItemCustomLookUpEdit.RegisterLookUpEdit(); }

        public CustomLookUpEdit() : base()
        {

        }
        public virtual void Format()
        {
            this.Size = new System.Drawing.Size(180, 0);
            this.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Properties.NullText = "";
            this.EnterMoveNextControl = true;
            this.Properties.ShowHeader = false;
        }

        public virtual void SetDataSource(List<object> p_arrSource, string p_strValueMember, string p_strDisplayMember)
        {
            this.Properties.DataSource = p_arrSource;
            this.Properties.ValueMember = p_strValueMember;
            this.Properties.DisplayMember = p_strDisplayMember;
        }

        public override string EditorTypeName { get { return RepositoryItemCustomLookUpEdit.CustomLookUpEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomLookUpEdit Properties
        {
            get
            {
                return (RepositoryItemCustomLookUpEdit)base.Properties;
            }
        }


    }
    [UserRepositoryItem("RegisterCustomLookUpEdit")]
    public class RepositoryItemCustomLookUpEdit : RepositoryItemLookUpEdit
    {
        static RepositoryItemCustomLookUpEdit()
        {

            RegisterLookUpEdit();

        }

        public RepositoryItemCustomLookUpEdit() : base()
        {
            AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            NullText = "";
        }
        public void Format()
        {

        }

        internal const string CustomLookUpEditName = "customLookUpEdit";

        public override string EditorTypeName { get { return CustomLookUpEditName; } }

        public static void RegisterLookUpEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomLookUpEditName,
             typeof(CustomLookUpEdit), typeof(RepositoryItemCustomLookUpEdit),
             typeof(GridLookUpEditBaseViewInfo), new ButtonEditPainter(), true));
        }

    }
}
