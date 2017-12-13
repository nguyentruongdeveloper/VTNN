using BUS.DanhMuc;
using DAO.DanhMuc;
using DTO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DanhMuc
{
    public class CDM_Nha_Cung_Cap_BUS:IDanhMuc<CDM_Nha_Cung_Cap>
    {
        private static CDM_Nha_Cung_Cap_BUS Instance { get; set; }
        public static CDM_Nha_Cung_Cap_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Nha_Cung_Cap_BUS();
            return Instance;
        }
        CDM_Nha_Cung_Cap_DAO _objNhaCungCapDAO = CDM_Nha_Cung_Cap_DAO.getInstance();
        public CDM_Nha_Cung_Cap Get_By_ID(Int64 p_iAutoID)
        {
            CDM_Nha_Cung_Cap v_objResult = _objNhaCungCapDAO.Get_DM_Nha_Cung_Cap_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Nha_Cung_Cap> Get_List_All()
        {
            return _objNhaCungCapDAO.List_DM_Nha_Cung_Cap();
        }
        public Int64 Insert(CDM_Nha_Cung_Cap p_objNhaCungCap)
        {
            return _objNhaCungCapDAO.Insert_DM_Nha_Cung_Cap(p_objNhaCungCap);
        }
        public void Updated(CDM_Nha_Cung_Cap p_objNhaCungCap)
        {
            _objNhaCungCapDAO.Update_DM_Nha_Cung_Cap(p_objNhaCungCap);
        }
        public void Deleted(Int64 p_iAutoID, string p_strLast_Updated_By)
        {
            _objNhaCungCapDAO.Delete_DM_Nha_Cung_Cap(p_iAutoID, p_strLast_Updated_By);
        }

    }
}
