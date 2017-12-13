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
    public class CDM_Nhom_Hang_Hoa_DAO
    {
        private static CDM_Nhom_Hang_Hoa_DAO Instance { get; set; }
        public static CDM_Nhom_Hang_Hoa_DAO getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Nhom_Hang_Hoa_DAO();
            return Instance;
        }
        private void MapDM_Nhom_Hang_Hoa(DataRow p_row, CDM_Nhom_Hang_Hoa p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int64(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Ma_Nhom_Hang"))
                p_objDes.Ma_Nhom_Hang = CUtility.Convert_To_String(p_row["Ma_Nhom_Hang"]);

            if (p_dt.Columns.Contains("Ten_Nhom_Hang"))
                p_objDes.Ten_Nhom_Hang = CUtility.Convert_To_String(p_row["Ten_Nhom_Hang"]);

            if (p_dt.Columns.Contains("Ghi_Chu"))
                p_objDes.Ghi_Chu = CUtility.Convert_To_String(p_row["Ghi_Chu"]);

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

        public IList<CDM_Nhom_Hang_Hoa> List_DM_Nhom_Hang_Hoa()
        {
            IList<CDM_Nhom_Hang_Hoa> v_arrRes = new List<CDM_Nhom_Hang_Hoa>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strVTNN_Conn_String, v_dt, "sp_sel_List_DM_Nhom_Hang_Hoa");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_Nhom_Hang_Hoa v_objRes = new CDM_Nhom_Hang_Hoa();
                    MapDM_Nhom_Hang_Hoa(v_row, v_objRes);
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

        public CDM_Nhom_Hang_Hoa Get_DM_Nhom_Hang_Hoa_By_ID(Int64 p_iID)
        {
            CDM_Nhom_Hang_Hoa v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strVTNN_Conn_String, v_dt, "sp_sel_Get_DM_Nhom_Hang_Hoa_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CDM_Nhom_Hang_Hoa();
                    MapDM_Nhom_Hang_Hoa(v_dt.Rows[0], v_objRes);
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

        public int Insert_DM_Nhom_Hang_Hoa(CDM_Nhom_Hang_Hoa p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strVTNN_Conn_String, "sp_ins_DM_Nhom_Hang_Hoa",
                    p_objData.Ma_Nhom_Hang, p_objData.Ten_Nhom_Hang, p_objData.Ghi_Chu, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_DM_Nhom_Hang_Hoa(CDM_Nhom_Hang_Hoa p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strVTNN_Conn_String, "sp_upd_DM_Nhom_Hang_Hoa", p_objData.Auto_ID,
                    p_objData.Ma_Nhom_Hang, p_objData.Ten_Nhom_Hang, p_objData.Ghi_Chu, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_DM_Nhom_Hang_Hoa(Int64 p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strVTNN_Conn_String, "sp_del_DM_Nhom_Hang_Hoa", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
