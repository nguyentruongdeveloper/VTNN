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
    public class CDM_Nhan_Vien_BUS
    {
        CDM_Nhan_Vien_DAO _objNhanVienDAO = CDM_Nhan_Vien_DAO.getInstance();
        private static CDM_Nhan_Vien_BUS Instance { get; set; }
        public static CDM_Nhan_Vien_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Nhan_Vien_BUS();
            return Instance;
        }
        public CDM_Nhan_Vien Get_By_ID(Int64 p_iAutoID)
        {
            CDM_Nhan_Vien v_objResult = _objNhanVienDAO.Get_DM_Nhan_Vien_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Nhan_Vien> Get_List_All()
        {
            return _objNhanVienDAO.List_DM_Nhan_Vien();
        }
        public Int64 Insert(CDM_Nhan_Vien p_objNhanVien)
        {
            return _objNhanVienDAO.Insert_DM_Nhan_Vien(p_objNhanVien);
        }
        public void Updated(CDM_Nhan_Vien p_objNhanVien)
        {
            _objNhanVienDAO.Update_DM_Nhan_Vien(p_objNhanVien);
        }
        public void Deleted(Int64 p_iAutoID, string p_strLast_Updated_By)
        {
            _objNhanVienDAO.Delete_DM_Nhan_Vien(p_iAutoID, p_strLast_Updated_By);
        }
    }
}
