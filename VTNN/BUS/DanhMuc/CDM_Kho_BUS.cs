using DAO.DanhMuc;
using DTO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DanhMuc
{
    public class CDM_Kho_BUS:IDanhMuc<CDM_Kho>
    {
        CDM_Kho_DAO _objKhoDAO = CDM_Kho_DAO.getInstance();
        private static CDM_Kho_BUS Instance { get; set; }
        public static CDM_Kho_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Kho_BUS();
            return Instance;
        }
        public CDM_Kho Get_By_ID(Int64 p_iAutoID)
        {
            CDM_Kho v_objResult = _objKhoDAO.Get_DM_Kho_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Kho> Get_List_All()
        {
            return _objKhoDAO.List_DM_Kho();
        }
        public Int64 Insert(CDM_Kho p_objKho)
        {
            return _objKhoDAO.Insert_DM_Kho(p_objKho);
        }
        public void Updated(CDM_Kho p_objKho)
        {
            _objKhoDAO.Update_DM_Kho(p_objKho);
        }
        public void Deleted(Int64 p_iAutoID, string p_strLast_Updated_By)
        {
            _objKhoDAO.Delete_DM_Kho(p_iAutoID, p_strLast_Updated_By);
        }
    }
}
