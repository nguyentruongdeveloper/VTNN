﻿using DAO.DanhMuc;
using DTO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DanhMuc
{
    public class CDM_Hinh_Thuc_Thanh_Toan_BUS : IDanhMuc<CDM_Hinh_Thuc_Thanh_Toan>
    {
        CDM_Hinh_Thuc_Thanh_Toan_DAO _objHinhThucTTDAO = CDM_Hinh_Thuc_Thanh_Toan_DAO.getInstance();
        private static CDM_Hinh_Thuc_Thanh_Toan_BUS Instance { get; set; }
        public static CDM_Hinh_Thuc_Thanh_Toan_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Hinh_Thuc_Thanh_Toan_BUS();
            return Instance;
        }
        public CDM_Hinh_Thuc_Thanh_Toan Get_By_ID(long p_iAutoID)
        {
            CDM_Hinh_Thuc_Thanh_Toan v_objResult = _objHinhThucTTDAO.Get_DM_Hinh_Thuc_Thanh_Toan_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Hinh_Thuc_Thanh_Toan> Get_List_All()
        {
            return _objHinhThucTTDAO.List_DM_Hinh_Thuc_Thanh_Toan();
        }
        public Int64 Insert(CDM_Hinh_Thuc_Thanh_Toan p_objKho)
        {
            return _objHinhThucTTDAO.Insert_DM_Hinh_Thuc_Thanh_Toan(p_objKho);
        }
        public void Updated(CDM_Hinh_Thuc_Thanh_Toan p_objKho)
        {
            _objHinhThucTTDAO.Update_DM_Hinh_Thuc_Thanh_Toan(p_objKho);
        }
        public void Deleted(long p_iAutoID, string p_strLast_Updated_By)
        {
            _objHinhThucTTDAO.Delete_DM_Hinh_Thuc_Thanh_Toan(p_iAutoID, p_strLast_Updated_By);
        }
    }
}
