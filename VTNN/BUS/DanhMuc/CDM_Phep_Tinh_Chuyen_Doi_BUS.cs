using DAO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.DanhMuc;

namespace BUS.DanhMuc
{
    public class CDM_Phep_Tinh_Chuyen_Doi_BUS:IDanhMuc<CDM_Phep_Tinh_Chuyen_Doi>
    {
        CDM_Phep_Tinh_Chuyen_Doi_DAO _objPhepTinhChuyenDoiDAO = CDM_Phep_Tinh_Chuyen_Doi_DAO.getInstance();
        private static CDM_Phep_Tinh_Chuyen_Doi_BUS Instance { get; set; }
        public static CDM_Phep_Tinh_Chuyen_Doi_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Phep_Tinh_Chuyen_Doi_BUS();
            return Instance;
        }
        public CDM_Phep_Tinh_Chuyen_Doi Get_By_ID(long p_iAutoID)
        {
            CDM_Phep_Tinh_Chuyen_Doi v_objResult = _objPhepTinhChuyenDoiDAO.Get_DM_Phep_Tinh_Chuyen_Doi_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Phep_Tinh_Chuyen_Doi> Get_List_All()
        {
            return _objPhepTinhChuyenDoiDAO.List_DM_Phep_Tinh_Chuyen_Doi();
        }
        public Int64 Insert(CDM_Phep_Tinh_Chuyen_Doi p_objKho)
        {
            return _objPhepTinhChuyenDoiDAO.Insert_DM_Phep_Tinh_Chuyen_Doi(p_objKho);
        }
        public void Updated(CDM_Phep_Tinh_Chuyen_Doi p_objKho)
        {
            _objPhepTinhChuyenDoiDAO.Update_DM_Phep_Tinh_Chuyen_Doi(p_objKho);
        }
        public void Deleted(long p_iAutoID, string p_strLast_Updated_By)
        {
            _objPhepTinhChuyenDoiDAO.Delete_DM_Phep_Tinh_Chuyen_Doi(p_iAutoID, p_strLast_Updated_By);
        }
    }
}
