using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNN.GUI.DanhMuc.Sub
{
    public interface ISubDanhMuc
    {

        
        void FormatControl();
        void InitForm();
        void Load_Data_Form();
        void Load_Repository();
        bool ValidateForm();
        bool SaveData();
        void Reset_Value_Control();
        void CloseForm();


    }
}
