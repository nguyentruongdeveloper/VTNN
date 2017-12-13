using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNN.Lib
{
    [ToolboxItem(true)]
    public class CustomTextEdit : TextEdit
    {
        public bool IsRest { get; set; } = true;
        public CustomTextEdit() : base()
        {
            Format();
        }
        public virtual void Format()
        {
            this.EnterMoveNextControl = true;

        }
    }
}
