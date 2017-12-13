using BUS.DanhMuc;
using DAO;
using DAO.DanhMuc;
using DTO;
using DTO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DanhMuc
{
    public class CDM_Don_Vi_Tinh_BUS : IDanhMuc<CDM_Don_Vi_Tinh>
    {
        CDM_Don_Vi_Tinh_DAO _objDonViTinhDAO = CDM_Don_Vi_Tinh_DAO.getInstance();
        private static CDM_Don_Vi_Tinh_BUS Instance { get; set; }
        public static CDM_Don_Vi_Tinh_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Don_Vi_Tinh_BUS();
            return Instance;
        }
        public CDM_Don_Vi_Tinh Get_By_ID(Int64 p_iAutoID)
        {
            CDM_Don_Vi_Tinh v_objResult = _objDonViTinhDAO.Get_DM_Don_Vi_Tinh_By_ID(p_iAutoID);
            return v_objResult;
        }
        
        public IList<CDM_Don_Vi_Tinh> Get_List_All()
        {
            return _objDonViTinhDAO.List_DM_Don_Vi_Tinh();
        }
        public Int64 Insert(CDM_Don_Vi_Tinh p_objDonViTinh)
        {
            return _objDonViTinhDAO.Insert_DM_Don_Vi_Tinh(p_objDonViTinh);
        }
        public  void Updated(CDM_Don_Vi_Tinh p_objDonViTinh)
        {
            _objDonViTinhDAO.Update_DM_Don_Vi_Tinh(p_objDonViTinh);
        }
        public void Deleted(Int64 p_iAutoID, string p_strLast_Updated_By)
        {
            _objDonViTinhDAO.Delete_DM_Don_Vi_Tinh(p_iAutoID, p_strLast_Updated_By);
        }
    }
}
