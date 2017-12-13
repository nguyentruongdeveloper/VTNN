using DAO;
using DAO.DanhMuc;
using DTO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace BUS.DanhMuc
{
    public class CDM_Hang_Hoa_BUS : IDanhMuc<CDM_Hang_Hoa>
    {
        CDM_Hang_Hoa_DAO _objHangHoaDAO = CDM_Hang_Hoa_DAO.getInstance();
        CDM_Don_Vi_Tinh_Chuyen_Doi_DAO _objDVTChuyenDoiDAO = CDM_Don_Vi_Tinh_Chuyen_Doi_DAO.getInstance();
        private static CDM_Hang_Hoa_BUS Instance { get; set; }
        public static CDM_Hang_Hoa_BUS getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Hang_Hoa_BUS();
            return Instance;
        }
        public CDM_Hang_Hoa Get_By_ID(long p_iAutoID)
        {
            CDM_Hang_Hoa v_objResult = _objHangHoaDAO.Get_DM_Hang_Hoa_By_ID(p_iAutoID);
            return v_objResult;
        }

        public IList<CDM_Hang_Hoa> Get_List_All()
        {
            return _objHangHoaDAO.List_DM_Hang_Hoa();
        }
        public bool FHH_0001_Insert(CDM_Hang_Hoa p_objHangHoa,List<CDM_Don_Vi_Tinh_Chuyen_Doi> p_arrDVTChuyenDoi)
        {
            bool v_blResul = true;
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;
            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.g_strVTNN_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();
                Int64 v_iHangHoaID= _objHangHoaDAO.FHH0001_Insert_DM_Hang_Hoa( v_conn, v_trans,p_objHangHoa);
                
                foreach (CDM_Don_Vi_Tinh_Chuyen_Doi v_obj in p_arrDVTChuyenDoi)
                {
                    v_obj.Hang_Hoa_ID = v_iHangHoaID;
                    _objDVTChuyenDoiDAO.FDVTCD_0001_Insert_DM_Don_Vi_Tinh_Chuyen_Doi(v_conn, v_trans, v_obj);
                }

                v_trans.Commit();
            }
            catch (Exception ex)
            {
                v_blResul = false;
                throw ex;
            }
            finally
            {
                v_trans.Dispose();
                if (v_conn != null)
                    v_conn.Close();
            }
            return v_blResul;
            //return _objHangHoaDAO.FHH0001_Insert_DM_Hang_Hoa(p_Cons, p_Trans, p_objHangHoa);
        }
        public Int64 Insert(CDM_Hang_Hoa p_objHangHoa)
        {
            return _objHangHoaDAO.Insert_DM_Hang_Hoa(p_objHangHoa);
        }
        public void Updated(CDM_Hang_Hoa p_objHangHoa)
        {
            _objHangHoaDAO.Update_DM_Hang_Hoa(p_objHangHoa);
        }
        public void FHH_0002_Updated(CDM_Hang_Hoa p_objHangHoa, List<CDM_Don_Vi_Tinh_Chuyen_Doi> p_arrDVTChuyenDoi)
        {
           
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;
            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.g_strVTNN_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();
                _objHangHoaDAO.FHH0002_Update_DM_Hang_Hoa(v_conn, v_trans, p_objHangHoa);

                foreach (CDM_Don_Vi_Tinh_Chuyen_Doi v_obj in p_arrDVTChuyenDoi)
                {
                    if (v_obj.Auto_ID <= 0)
                    {
                        v_obj.Hang_Hoa_ID = p_objHangHoa.Auto_ID;
                        _objDVTChuyenDoiDAO.FDVTCD_0001_Insert_DM_Don_Vi_Tinh_Chuyen_Doi(v_conn, v_trans, v_obj);
                    }
                    if (v_obj.Auto_ID > 0)
                    {
                        _objDVTChuyenDoiDAO.FDVTCD_0002_Update_DM_Don_Vi_Tinh_Chuyen_Doi(v_conn, v_trans, v_obj);

                    }
                }

                v_trans.Commit();
            }
            catch (Exception ex)
            {
               
                throw ex;
            }
            finally
            {
                v_trans.Dispose();
                if (v_conn != null)
                    v_conn.Close();
            }
          
        }
        public void Deleted(long p_iAutoID, string p_strLast_Updated_By)
        {
            _objHangHoaDAO.Delete_DM_Hang_Hoa(p_iAutoID, p_strLast_Updated_By);
        }
    }
}
