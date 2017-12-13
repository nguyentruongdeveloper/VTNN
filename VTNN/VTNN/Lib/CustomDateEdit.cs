using DevExpress.Utils;
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
    public class CustomDateEdit : DateEdit
    {
        public bool IsReset { get; set; }
        static CustomDateEdit() { RepositoryItemCustomDateEdit.RegisterMyDateEdit(); }

        public CustomDateEdit() : base()
        {
            Format();
        }
        public virtual void Format()
        {

            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            Properties.Mask.EditMask = "99/99/0000";
            Properties.Mask.UseMaskAsDisplayFormat = true;
            Properties.AllowNullInput = DefaultBoolean.True;

            this.Size = new System.Drawing.Size(180, 0);
            this.EnterMoveNextControl = true;
            this.Validating -= CustomDateEdit_Validating;
            this.Validating += CustomDateEdit_Validating;
            this.InvalidValue -= CustomDateEdit_InvalidValue;
            this.InvalidValue += CustomDateEdit_InvalidValue;
        }

        private void CustomDateEdit_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        }

        private void CustomDateEdit_Validating(object sender, CancelEventArgs e)
        {
            DateEdit v_objDateEdit = (sender as DateEdit);
            v_objDateEdit.ErrorText = "";
            if (v_objDateEdit.DateTime == DateTime.MinValue && v_objDateEdit.Text != "__/__/____")
            {
                v_objDateEdit.ErrorText = "Vui lòng chọn lại ngày!";
                e.Cancel = true;
            }

        }

        public override string EditorTypeName { get { return RepositoryItemCustomDateEdit.CustomDateEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomDateEdit Properties
        {
            get
            {
                return (RepositoryItemCustomDateEdit)base.Properties;
            }
        }


    }
    [UserRepositoryItem("RegisterCustomDateEdit")]
    public class RepositoryItemCustomDateEdit : RepositoryItemDateEdit
    {
        static RepositoryItemCustomDateEdit() { RegisterMyDateEdit(); }

        public RepositoryItemCustomDateEdit() : base()
        {
            Format();
        }
        public void Format()
        {
            Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            Mask.EditMask = "99/99/0000";
            Mask.UseMaskAsDisplayFormat = true;
            AllowNullInput = DefaultBoolean.True;
            this.Validating -= RepositoryItemCustomDateEdit_Validating;
            this.Validating += RepositoryItemCustomDateEdit_Validating;
            this.InvalidValue -= RepositoryItemCustomDateEdit_InvalidValue;
            this.InvalidValue += RepositoryItemCustomDateEdit_InvalidValue;

        }

        private void RepositoryItemCustomDateEdit_Validating(object sender, CancelEventArgs e)
        {
            DateEdit v_objDateEdit = (sender as DateEdit);
            v_objDateEdit.ErrorText = "";
            if (v_objDateEdit.DateTime == DateTime.MinValue && v_objDateEdit.Text != "__/__/____")
            {
                v_objDateEdit.ErrorText = "Vui lòng chọn lại ngày!";
                e.Cancel = true;
            }
        }

        private void CustomDateEdit_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        }

        internal const string CustomDateEditName = "CustomDateEdit";

        public override string EditorTypeName { get { return CustomDateEditName; } }

        public int InvalidValue { get; private set; }

        public int RepositoryItemCustomDateEdit_InvalidValue { get; private set; }

        public static void RegisterMyDateEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomDateEditName, typeof(CustomDateEdit),
                typeof(RepositoryItemCustomDateEdit), typeof(DateEditViewInfo), new ButtonEditPainter(), true));
        }
        public override void CreateDefaultButton()
        {
            base.CreateDefaultButton();
            Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            Buttons[0].Image = VTNN.Properties.Resources.adateoccurring_16x16;



        }
    }
}
