using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTNN.Lib
{
    [UserRepositoryItem("RegisterCustomSpinEdit")]
    public class RepositoryItemCustomSpinEdit : RepositoryItemSpinEdit
    {
        static RepositoryItemCustomSpinEdit()
        {
            RegisterCustomSpinEdit();
        }


        public const string CustomEditName = "CustomSpinEdit";

        public RepositoryItemCustomSpinEdit()
        {
            this.Buttons.Clear();
        }
        decimal _myMaxValue;
        private decimal _scale = 1.5m;
        public decimal MyMaxValue
        {
            get { return _myMaxValue; }
            set
            {
                _myMaxValue = value;

                if (OwnerEdit != null)
                {
                    //OwnerEdit.MaximumSize = new Size((int)(Math.Abs(MyMaxValue) * _scale), OwnerEdit.MaximumSize.Height);
                    //OwnerEdit.MinimumSize = OwnerEdit.MaximumSize;
                }
                OnPropertiesChanged();
            }
        }

        public override string EditorTypeName => CustomEditName;

        public static void RegisterCustomSpinEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(CustomSpinEdit), typeof(RepositoryItemCustomSpinEdit), typeof(CustomSpinEditViewInfo), new CustomSpinEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemCustomSpinEdit source = item as RepositoryItemCustomSpinEdit;
                if (source == null) return;
                //
            }
            finally
            {
                EndUpdate();
            }
        }

        public override void CreateDefaultButton()
        {
            base.CreateDefaultButton();
            Buttons.Clear();
        }
    }

    [ToolboxItem(true)]
    public class CustomSpinEdit : SpinEdit

    {
        public bool IsRest { get; set; } = true;
        public string DisplayFormat { get; set; }
        static CustomSpinEdit()
        {
            RepositoryItemCustomSpinEdit.RegisterCustomSpinEdit();

        }

        public CustomSpinEdit()
        {
            Format(0, false, true);
        }
        public void Format(int DecimalScale = 0, bool LeftAlight = true, bool NotNegative = true)
        {
            Properties.Buttons.Clear();
            EnterMoveNextControl = true;
            Properties.Mask.UseMaskAsDisplayFormat = true;
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            Properties.AppearanceReadOnly.TextOptions.HAlignment = Properties.AppearanceFocused.TextOptions.HAlignment = Properties.Appearance.TextOptions.HAlignment = LeftAlight ? HorzAlignment.Near : HorzAlignment.Far;
            Properties.Mask.EditMask = Properties.DisplayFormat.FormatString = Properties.EditFormat.FormatString = "N" + DecimalScale.ToString();
            if (NotNegative)
            {
                this.KeyPress -= NotNegative_KeyPress;
                this.KeyPress += NotNegative_KeyPress;
                if (Properties.MinValue == Properties.MaxValue)
                {
                    Properties.MaxValue = decimal.MaxValue;
                }
                if (Properties.MinValue < 0)
                    Properties.MinValue = 0;

            }

        }

        public static void NotNegative_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomSpinEdit Properties => base.Properties as RepositoryItemCustomSpinEdit;

        public override string EditorTypeName => RepositoryItemCustomSpinEdit.CustomEditName;


    }

    public class CustomSpinEditViewInfo : BaseSpinEditViewInfo
    {
        public CustomSpinEditViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class CustomSpinEditPainter : ButtonEditPainter
    {
        public CustomSpinEditPainter()
        {
        }
    }

    public class CustomSpinEditPopupForm : PopupBaseForm
    {
        public CustomSpinEditPopupForm(CustomSpinEdit ownerEdit) : base(ownerEdit)
        {
        }

        protected override Size CalcFormSizeCore()
        {
            throw new NotImplementedException();
        }

        public override object ResultValue => throw new NotImplementedException();
    }
}
