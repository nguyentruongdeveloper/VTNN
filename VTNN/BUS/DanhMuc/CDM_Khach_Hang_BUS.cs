using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Utility;
using DAO.DanhMuc;
using DTO.DanhMuc;

namespace BUS.DanhMuc
{
    public class CDM_Khach_Hang_BUS:IDanhMuc<CDM_Khach_Hang>
    {
        CDM_Khach_Hang_DAO _objKhachHangDAO = CDM_Khach_Hang_DAO.getInstance();
        private static CDM_Khach_Hang_BUS Instance { get; set; }
        public static CDM_Khach_Hang_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Khach_Hang_BUS();
            return Instance;
        }
        public CDM_Khach_Hang Get_By_ID(Int64 p_iAutoID)
        {
            CDM_Khach_Hang v_objResult = _objKhachHangDAO.Get_DM_Khach_Hang_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Khach_Hang> Get_List_All()
        {
            return _objKhachHangDAO.List_DM_Khach_Hang();
        }
        public Int64 Insert(CDM_Khach_Hang p_objKhachHang)
        {
            return _objKhachHangDAO.Insert_DM_Khach_Hang(p_objKhachHang);
        }
        public void Updated(CDM_Khach_Hang p_objKhachHang)
        {
            _objKhachHangDAO.Update_DM_Khach_Hang(p_objKhachHang);
        }
        public void Deleted(Int64 p_iAutoID, string p_strLast_Updated_By)
        {
            _objKhachHangDAO.Delete_DM_Khach_Hang(p_iAutoID, p_strLast_Updated_By);
        }

    }
}
