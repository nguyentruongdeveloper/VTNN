using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNN.Lib
{
    [ToolboxItem(true)]
    public class CustomMemoEdit : DevExpress.XtraEditors.MemoEdit
    {
        public bool IsRest { get; set; } = true;
        public CustomMemoEdit() : base()
        {
            Format();
        }
        public virtual void Format()
        {
            MinimumSize = new System.Drawing.Size(0, 80);
            this.Size = new System.Drawing.Size(0, 80);
            this.EnterMoveNextControl = true;

        }
    }
}
