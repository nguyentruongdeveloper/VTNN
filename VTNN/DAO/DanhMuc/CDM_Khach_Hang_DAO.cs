using DTO;
using DTO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DAO.DanhMuc
{
    public class CDM_Khach_Hang_DAO
    {
        private static CDM_Khach_Hang_DAO Instance { get; set; }
        public static CDM_Khach_Hang_DAO getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Khach_Hang_DAO();
            return Instance;
        }
        private void MapDM_Khach_Hang(DataRow p_row, CDM_Khach_Hang p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int64(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Ma_Khach_Hang"))
                p_objDes.Ma_Khach_Hang = CUtility.Convert_To_String(p_row["Ma_Khach_Hang"]);

            if (p_dt.Columns.Contains("Ten_Khach_Hang"))
                p_objDes.Ten_Khach_Hang = CUtility.Convert_To_String(p_row["Ten_Khach_Hang"]);

            if (p_dt.Columns.Contains("Dia_Chi"))
                p_objDes.Dia_Chi = CUtility.Convert_To_String(p_row["Dia_Chi"]);

            if (p_dt.Columns.Contains("Dien_Thoai"))
                p_objDes.Dien_Thoai = CUtility.Convert_To_String(p_row["Dien_Thoai"]);

            if (p_dt.Columns.Contains("Ma_So_Thue"))
                p_objDes.Ma_So_Thue = CUtility.Convert_To_String(p_row["Ma_So_Thue"]);

            if (p_dt.Columns.Contains("Created"))
                p_objDes.Created = CUtility.Convert_To_DateTime(p_row["Created"]);

            if (p_dt.Columns.Contains("Created_By"))
                p_objDes.Created_By = CUtility.Convert_To_String(p_row["Created_By"]);

            if (p_dt.Columns.Contains("Last_Updated"))
                p_objDes.Last_Updated = CUtility.Convert_To_DateTime(p_row["Last_Updated"]);

            if (p_dt.Columns.Contains("Last_Updated_By"))
                p_objDes.Last_Updated_By = CUtility.Convert_To_String(p_row["Last_Updated_By"]);

            if (p_dt.Columns.Contains("Deleted"))
                p_objDes.Deleted = CUtility.Convert_To_Bool(p_row["Deleted"]);
        }

        public IList<CDM_Khach_Hang> List_DM_Khach_Hang()
        {
            IList<CDM_Khach_Hang> v_arrRes = new List<CDM_Khach_Hang>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strVTNN_Conn_String, v_dt, "sp_sel_List_DM_Khach_Hang");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_Khach_Hang v_objRes = new CDM_Khach_Hang();
                    MapDM_Khach_Hang(v_row, v_objRes);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public CDM_Khach_Hang Get_DM_Khach_Hang_By_ID(Int64 p_iID)
        {
            CDM_Khach_Hang v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strVTNN_Conn_String, v_dt, "sp_sel_Get_DM_Khach_Hang_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CDM_Khach_Hang();
                    MapDM_Khach_Hang(v_dt.Rows[0], v_objRes);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_objRes;
        }

        public int Insert_DM_Khach_Hang(CDM_Khach_Hang p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strVTNN_Conn_String, "sp_ins_DM_Khach_Hang",
                    p_objData.Ma_Khach_Hang, p_objData.Ten_Khach_Hang, p_objData.Dia_Chi, p_objData.Dien_Thoai, p_objData.Ma_So_Thue, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_DM_Khach_Hang(CDM_Khach_Hang p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strVTNN_Conn_String, "sp_upd_DM_Khach_Hang", p_objData.Auto_ID,
                    p_objData.Ma_Khach_Hang, p_objData.Ten_Khach_Hang, p_objData.Dia_Chi, p_objData.Dien_Thoai, p_objData.Ma_So_Thue, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_DM_Khach_Hang(Int64 p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strVTNN_Conn_String, "sp_del_DM_Khach_Hang", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
