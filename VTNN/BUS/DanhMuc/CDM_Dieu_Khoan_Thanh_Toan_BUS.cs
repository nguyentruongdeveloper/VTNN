using DAO.DanhMuc;
using DTO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DanhMuc
{
    class CDM_Dieu_Khoan_Thanh_Toan_BUS : IDanhMuc<CDM_Dieu_Khoan_Thanh_Toan>
    {
        CDM_Dieu_Khoan_Thanh_Toan_DAO _objDieuKhoanTTDAO = CDM_Dieu_Khoan_Thanh_Toan_DAO.getInstance();
        private static CDM_Dieu_Khoan_Thanh_Toan_BUS Instance { get; set; }
        public static CDM_Dieu_Khoan_Thanh_Toan_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Dieu_Khoan_Thanh_Toan_BUS();
            return Instance;
        }
        public CDM_Dieu_Khoan_Thanh_Toan Get_By_ID(long p_iAutoID)
        {
            CDM_Dieu_Khoan_Thanh_Toan v_objResult = _objDieuKhoanTTDAO.Get_DM_Dieu_Khoan_Thanh_Toan_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Dieu_Khoan_Thanh_Toan> Get_List_All()
        {
            return _objDieuKhoanTTDAO.List_DM_Dieu_Khoan_Thanh_Toan();
        }
        public Int64 Insert(CDM_Dieu_Khoan_Thanh_Toan p_objKho)
        {
            return _objDieuKhoanTTDAO.Insert_DM_Dieu_Khoan_Thanh_Toan(p_objKho);
        }
        public void Updated(CDM_Dieu_Khoan_Thanh_Toan p_objKho)
        {
            _objDieuKhoanTTDAO.Update_DM_Dieu_Khoan_Thanh_Toan(p_objKho);
        }
        public void Deleted(long p_iAutoID, string p_strLast_Updated_By)
        {
            _objDieuKhoanTTDAO.Delete_DM_Dieu_Khoan_Thanh_Toan(p_iAutoID, p_strLast_Updated_By);
        }
    }
}
