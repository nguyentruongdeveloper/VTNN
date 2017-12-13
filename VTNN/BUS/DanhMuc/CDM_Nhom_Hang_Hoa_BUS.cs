using DAO.DanhMuc;
using DTO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DanhMuc
{
    public class CDM_Nhom_Hang_Hoa_BUS:IDanhMuc<CDM_Nhom_Hang_Hoa>
    {
        CDM_Nhom_Hang_Hoa_DAO _objNhomHangHoaDAO = CDM_Nhom_Hang_Hoa_DAO.getInstance();
        private static CDM_Nhom_Hang_Hoa_BUS Instance { get; set; }
        public static CDM_Nhom_Hang_Hoa_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Nhom_Hang_Hoa_BUS();
            return Instance;
        }
        public CDM_Nhom_Hang_Hoa Get_By_ID(Int64 p_iAutoID)
        {
            CDM_Nhom_Hang_Hoa v_objResult = _objNhomHangHoaDAO.Get_DM_Nhom_Hang_Hoa_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Nhom_Hang_Hoa> Get_List_All()
        {
            return _objNhomHangHoaDAO.List_DM_Nhom_Hang_Hoa();
        }
        public Int64 Insert(CDM_Nhom_Hang_Hoa p_objNhomHangHoa)
        {
            return _objNhomHangHoaDAO.Insert_DM_Nhom_Hang_Hoa(p_objNhomHangHoa);
        }
        public void Updated(CDM_Nhom_Hang_Hoa p_objNhomHangHoa)
        {
            _objNhomHangHoaDAO.Update_DM_Nhom_Hang_Hoa(p_objNhomHangHoa);
        }
        public void Deleted(Int64 p_iAutoID, string p_strLast_Updated_By)
        {
            _objNhomHangHoaDAO.Delete_DM_Nhom_Hang_Hoa(p_iAutoID, p_strLast_Updated_By);
        }
    }
}
