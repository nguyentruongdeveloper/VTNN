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
    public class CDM_Ky_DAO
    {
        private static CDM_Ky_DAO Instance { get; set; }
        public static CDM_Ky_DAO getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Ky_DAO();
            return Instance;
        }
        private void MapDM_Ky(DataRow p_row, CDM_Ky p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Ten_Ky"))
                p_objDes.Ten_Ky = CUtility.Convert_To_String(p_row["Ten_Ky"]);

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

        public IList<CDM_Ky> List_DM_Ky()
        {
            IList<CDM_Ky> v_arrRes = new List<CDM_Ky>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strVTNN_Conn_String, v_dt, "sp_sel_List_DM_Ky");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_Ky v_objRes = new CDM_Ky();
                    MapDM_Ky(v_row, v_objRes);
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

        public CDM_Ky Get_DM_Ky_By_ID(Int64 p_iID)
        {
            CDM_Ky v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strVTNN_Conn_String, v_dt, "sp_sel_Get_DM_Ky_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CDM_Ky();
                    MapDM_Ky(v_dt.Rows[0], v_objRes);
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

        public int Insert_DM_Ky(CDM_Ky p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strVTNN_Conn_String, "sp_ins_DM_Ky",
                    p_objData.Ten_Ky, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_DM_Ky(CDM_Ky p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strVTNN_Conn_String, "sp_upd_DM_Ky", p_objData.Auto_ID,
                    p_objData.Ten_Ky, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_DM_Ky(Int64 p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strVTNN_Conn_String, "sp_del_DM_Ky", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
