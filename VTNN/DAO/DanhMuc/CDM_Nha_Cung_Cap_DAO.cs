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
    public class CDM_Nha_Cung_Cap_DAO
    {
        private static CDM_Nha_Cung_Cap_DAO Instance { get; set; }
        public static CDM_Nha_Cung_Cap_DAO getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Nha_Cung_Cap_DAO();
            return Instance;
        }

        private void MapDM_Nha_Cung_Cap(DataRow p_row, CDM_Nha_Cung_Cap p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int64(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Ma_Nha_Cung_Cap"))
                p_objDes.Ma_Nha_Cung_Cap = CUtility.Convert_To_String(p_row["Ma_Nha_Cung_Cap"]);

            if (p_dt.Columns.Contains("Ten_Nha_Cung_Cap"))
                p_objDes.Ten_Nha_Cung_Cap = CUtility.Convert_To_String(p_row["Ten_Nha_Cung_Cap"]);

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

        public IList<CDM_Nha_Cung_Cap> List_DM_Nha_Cung_Cap()
        {
            IList<CDM_Nha_Cung_Cap> v_arrRes = new List<CDM_Nha_Cung_Cap>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strVTNN_Conn_String, v_dt, "sp_sel_List_DM_Nha_Cung_Cap");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_Nha_Cung_Cap v_objRes = new CDM_Nha_Cung_Cap();
                    MapDM_Nha_Cung_Cap(v_row, v_objRes);
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

        public CDM_Nha_Cung_Cap Get_DM_Nha_Cung_Cap_By_ID(Int64 p_iID)
        {
            CDM_Nha_Cung_Cap v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strVTNN_Conn_String, v_dt, "sp_sel_Get_DM_Nha_Cung_Cap_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CDM_Nha_Cung_Cap();
                    MapDM_Nha_Cung_Cap(v_dt.Rows[0], v_objRes);
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

        public int Insert_DM_Nha_Cung_Cap(CDM_Nha_Cung_Cap p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strVTNN_Conn_String, "sp_ins_DM_Nha_Cung_Cap",
                    p_objData.Ma_Nha_Cung_Cap, p_objData.Ten_Nha_Cung_Cap, p_objData.Dia_Chi, p_objData.Dien_Thoai, p_objData.Ma_So_Thue, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_DM_Nha_Cung_Cap(CDM_Nha_Cung_Cap p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strVTNN_Conn_String, "sp_upd_DM_Nha_Cung_Cap", p_objData.Auto_ID,
                    p_objData.Ma_Nha_Cung_Cap, p_objData.Ten_Nha_Cung_Cap, p_objData.Dia_Chi, p_objData.Dien_Thoai, p_objData.Ma_So_Thue, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_DM_Nha_Cung_Cap(Int64 p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strVTNN_Conn_String, "sp_del_DM_Nha_Cung_Cap", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
