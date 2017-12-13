using DAO.DanhMuc;
using DTO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DanhMuc
{
    public class CDM_Ky_BUS : IDanhMuc<CDM_Ky>
    {
        CDM_Ky_DAO _objKyDAO = CDM_Ky_DAO.getInstance();
        private static CDM_Ky_BUS Instance { get; set; }
        public static CDM_Ky_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Ky_BUS();
            return Instance;
        }
        public CDM_Ky Get_By_ID(Int64 p_iAutoID)
        {
            CDM_Ky v_objResult = _objKyDAO.Get_DM_Ky_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Ky> Get_List_All()
        {
            return _objKyDAO.List_DM_Ky();
        }
        public Int64 Insert(CDM_Ky p_objKho)
        {
            return _objKyDAO.Insert_DM_Ky(p_objKho);
        }
        public void Updated(CDM_Ky p_objKho)
        {
            _objKyDAO.Update_DM_Ky(p_objKho);
        }
        public void Deleted(Int64 p_iAutoID, string p_strLast_Updated_By)
        {
            _objKyDAO.Delete_DM_Ky(p_iAutoID, p_strLast_Updated_By);
        }
    }
}
