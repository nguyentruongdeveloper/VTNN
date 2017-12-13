using DAO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.DanhMuc;

namespace BUS.DanhMuc
{
    public class CDM_Quy_BUS: IDanhMuc<CDM_Quy>
    {
        CDM_Quy_DAO _objQuyDAO = CDM_Quy_DAO.getInstance();
        private static CDM_Quy_BUS Instance { get; set; }
        public static CDM_Quy_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Quy_BUS();
            return Instance;
        }
        public CDM_Quy Get_By_ID(Int64 p_iAutoID)
        {
            CDM_Quy v_objResult = _objQuyDAO.Get_DM_Quy_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Quy> Get_List_All()
        {
            return _objQuyDAO.List_DM_Quy();
        }
        public Int64 Insert(CDM_Quy p_objQuy)
        {
            return _objQuyDAO.Insert_DM_Quy(p_objQuy);
        }
        public void Updated(CDM_Quy p_objQuy)
        {
            _objQuyDAO.Update_DM_Quy(p_objQuy);

        }
        public void Deleted(Int64 p_iAutoID, string p_strLast_Updated_By)
        {
           _objQuyDAO.Delete_DM_Quy(p_iAutoID, p_strLast_Updated_By);
        }
    }
}
