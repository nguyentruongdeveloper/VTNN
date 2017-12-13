using DAO.DanhMuc;
using DTO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DanhMuc
{
    public class CDM_Don_Vi_Tinh_Chuyen_Doi_BUS : IDanhMuc<CDM_Don_Vi_Tinh_Chuyen_Doi>
    {
        CDM_Don_Vi_Tinh_Chuyen_Doi_DAO _objDonViTinhChuyenDoiDAO = CDM_Don_Vi_Tinh_Chuyen_Doi_DAO.getInstance();
        private static CDM_Don_Vi_Tinh_Chuyen_Doi_BUS Instance { get; set; }
        public static CDM_Don_Vi_Tinh_Chuyen_Doi_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Don_Vi_Tinh_Chuyen_Doi_BUS();
            return Instance;
        }
        public CDM_Don_Vi_Tinh_Chuyen_Doi Get_By_ID(long p_iAutoID)
        {
            CDM_Don_Vi_Tinh_Chuyen_Doi v_objResult = _objDonViTinhChuyenDoiDAO.Get_DM_Don_Vi_Tinh_Chuyen_Doi_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Don_Vi_Tinh_Chuyen_Doi> Get_List_All()
        {
            return _objDonViTinhChuyenDoiDAO.List_DM_Don_Vi_Tinh_Chuyen_Doi();
        }
        public Int64 FDVTCD_0001_Insert(CDM_Don_Vi_Tinh_Chuyen_Doi p_objDVTChuyenDoi, SqlConnection p_Cons, SqlTransaction p_Trans)
        {
            return _objDonViTinhChuyenDoiDAO.FDVTCD_0001_Insert_DM_Don_Vi_Tinh_Chuyen_Doi(p_Cons, p_Trans, p_objDVTChuyenDoi);
        }
        public Int64 Insert(CDM_Don_Vi_Tinh_Chuyen_Doi p_objDVTChuyenDoi)
        {
            return _objDonViTinhChuyenDoiDAO.Insert_DM_Don_Vi_Tinh_Chuyen_Doi(p_objDVTChuyenDoi);
        }
        public void Updated(CDM_Don_Vi_Tinh_Chuyen_Doi p_objDVTChuyenDoi)
        {
            _objDonViTinhChuyenDoiDAO.Update_DM_Don_Vi_Tinh_Chuyen_Doi(p_objDVTChuyenDoi);
        }
        public void Deleted(long p_iAutoID, string p_strLast_Updated_By)
        {
            _objDonViTinhChuyenDoiDAO.Delete_DM_Don_Vi_Tinh_Chuyen_Doi(p_iAutoID, p_strLast_Updated_By);
        }
    }
}
