using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNN.GUI.DanhMuc
{
    public interface IDanhMuc
    {
        void FormatControl();
        void Load_Repository();
        void Load_Data_Form();
        void Add();
        void Updated();
        void Deleted();
        void Refesh();
        void CloseForm();
        void Export();

    }
}
