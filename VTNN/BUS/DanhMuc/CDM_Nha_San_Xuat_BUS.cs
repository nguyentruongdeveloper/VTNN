using DAO.DanhMuc;
using DTO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DanhMuc
{
    public class CDM_Nha_San_Xuat_BUS:IDanhMuc<CDM_Nha_San_Xuat>
    {
        private static CDM_Nha_San_Xuat_BUS Instance { get; set; }
        public static CDM_Nha_San_Xuat_BUS getInstace()
        {
            if (Instance == null)
                Instance = new CDM_Nha_San_Xuat_BUS();
            return Instance;
        }
        CDM_Nha_San_Xuat_DAO _objNhaSanXuatDAO = CDM_Nha_San_Xuat_DAO.getInstance();
        public CDM_Nha_San_Xuat Get_By_ID(Int64 p_iAutoID)
        {
            CDM_Nha_San_Xuat v_objResult = _objNhaSanXuatDAO.Get_DM_Nha_San_Xuat_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Nha_San_Xuat> Get_List_All()
        {
            return _objNhaSanXuatDAO.List_DM_Nha_San_Xuat();
        }
        public Int64 Insert(CDM_Nha_San_Xuat p_objNhaSanXuat)
        {
            return _objNhaSanXuatDAO.Insert_DM_Nha_San_Xuat(p_objNhaSanXuat);
        }
        public void Updated(CDM_Nha_San_Xuat p_objNhaSanXuat)
        {
            _objNhaSanXuatDAO.Update_DM_Nha_San_Xuat(p_objNhaSanXuat);
        }
        public void Deleted(Int64 p_iAutoID, string p_strLast_Updated_By)
        {
            _objNhaSanXuatDAO.Delete_DM_Nha_San_Xuat(p_iAutoID, p_strLast_Updated_By);
        }

    }

}
