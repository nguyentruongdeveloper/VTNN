using DTO.DanhMuc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DAO.DanhMuc
{
    public class CDM_Don_Vi_Tinh_Chuyen_Doi_DAO
    {
        private static CDM_Don_Vi_Tinh_Chuyen_Doi_DAO Instance { get; set; }
        public static CDM_Don_Vi_Tinh_Chuyen_Doi_DAO getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Don_Vi_Tinh_Chuyen_Doi_DAO();
            return Instance;
        }
        private void MapDM_Don_Vi_Tinh_Chuyen_Doi(DataRow p_row, CDM_Don_Vi_Tinh_Chuyen_Doi p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int64(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Don_Vi_Tinh_ID"))
                p_objDes.Don_Vi_Tinh_ID = CUtility.Convert_To_Int64(p_row["Don_Vi_Tinh_ID"]);

            if (p_dt.Columns.Contains("Hang_Hoa_ID"))
                p_objDes.Hang_Hoa_ID = CUtility.Convert_To_Int64(p_row["Hang_Hoa_ID"]);

            if (p_dt.Columns.Contains("Ty_Le_Chuyen_Doi"))
                p_objDes.Ty_Le_Chuyen_Doi = CUtility.Convert_To_Int32(p_row["Ty_Le_Chuyen_Doi"]);

            if (p_dt.Columns.Contains("Phep_Tinh_Chuyen_ID"))
                p_objDes.Phep_Tinh_Chuyen_ID = CUtility.Convert_To_Int64(p_row["Phep_Tinh_Chuyen_ID"]);

            if (p_dt.Columns.Contains("Mo_Ta"))
                p_objDes.Mo_Ta = CUtility.Convert_To_String(p_row["Mo_Ta"]);

            if (p_dt.Columns.Contains("Gia_Ban_Si"))
                p_objDes.Gia_Ban_Si = CUtility.Convert_To_Double(p_row["Gia_Ban_Si"]);

            if (p_dt.Columns.Contains("Gia_Ban_Le"))
                p_objDes.Gia_Ban_Le = CUtility.Convert_To_Double(p_row["Gia_Ban_Le"]);

            if (p_dt.Columns.Contains("Gia_Ban_Dac_Biet"))
                p_objDes.Gia_Ban_Dac_Biet = CUtility.Convert_To_Double(p_row["Gia_Ban_Dac_Biet"]);

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

        public IList<CDM_Don_Vi_Tinh_Chuyen_Doi> List_DM_Don_Vi_Tinh_Chuyen_Doi()
        {
            IList<CDM_Don_Vi_Tinh_Chuyen_Doi> v_arrRes = new List<CDM_Don_Vi_Tinh_Chuyen_Doi>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strVTNN_Conn_String, v_dt, "sp_sel_List_DM_Don_Vi_Tinh_Chuyen_Doi");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_Don_Vi_Tinh_Chuyen_Doi v_objRes = new CDM_Don_Vi_Tinh_Chuyen_Doi();
                    MapDM_Don_Vi_Tinh_Chuyen_Doi(v_row, v_objRes);
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

        public CDM_Don_Vi_Tinh_Chuyen_Doi Get_DM_Don_Vi_Tinh_Chuyen_Doi_By_ID(long p_iID)
        {
            CDM_Don_Vi_Tinh_Chuyen_Doi v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strVTNN_Conn_String, v_dt, "sp_sel_Get_DM_Don_Vi_Tinh_Chuyen_Doi_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CDM_Don_Vi_Tinh_Chuyen_Doi();
                    MapDM_Don_Vi_Tinh_Chuyen_Doi(v_dt.Rows[0], v_objRes);
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

        public Int64 Insert_DM_Don_Vi_Tinh_Chuyen_Doi(CDM_Don_Vi_Tinh_Chuyen_Doi p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strVTNN_Conn_String, "sp_ins_DM_Don_Vi_Tinh_Chuyen_Doi",
                    p_objData.Don_Vi_Tinh_ID, p_objData.Hang_Hoa_ID, p_objData.Ty_Le_Chuyen_Doi, p_objData.Phep_Tinh_Chuyen_ID, p_objData.Mo_Ta, p_objData.Gia_Ban_Si, p_objData.Gia_Ban_Le, p_objData.Gia_Ban_Dac_Biet, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public Int64 FDVTCD_0001_Insert_DM_Don_Vi_Tinh_Chuyen_Doi(SqlConnection p_Cons, SqlTransaction p_Trans, CDM_Don_Vi_Tinh_Chuyen_Doi p_objData)
        {
            Int64 v_iRes = CConst.INT64_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_Cons, p_Trans, CConfig.g_strVTNN_Conn_String, "sp_ins_DM_Don_Vi_Tinh_Chuyen_Doi",
                    p_objData.Don_Vi_Tinh_ID, p_objData.Hang_Hoa_ID, p_objData.Ty_Le_Chuyen_Doi, p_objData.Phep_Tinh_Chuyen_ID, p_objData.Mo_Ta, p_objData.Gia_Ban_Si, p_objData.Gia_Ban_Le, p_objData.Gia_Ban_Dac_Biet, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_DM_Don_Vi_Tinh_Chuyen_Doi(CDM_Don_Vi_Tinh_Chuyen_Doi p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strVTNN_Conn_String, "sp_upd_DM_Don_Vi_Tinh_Chuyen_Doi", p_objData.Auto_ID,
                    p_objData.Don_Vi_Tinh_ID, p_objData.Hang_Hoa_ID, p_objData.Ty_Le_Chuyen_Doi, p_objData.Phep_Tinh_Chuyen_ID, p_objData.Mo_Ta, p_objData.Gia_Ban_Si, p_objData.Gia_Ban_Le, p_objData.Gia_Ban_Dac_Biet, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FDVTCD_0002_Update_DM_Don_Vi_Tinh_Chuyen_Doi(SqlConnection p_Cons, SqlTransaction p_Trans, CDM_Don_Vi_Tinh_Chuyen_Doi p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_Cons, p_Trans, CConfig.g_strVTNN_Conn_String, "sp_upd_DM_Don_Vi_Tinh_Chuyen_Doi", p_objData.Auto_ID,
                    p_objData.Don_Vi_Tinh_ID, p_objData.Hang_Hoa_ID, p_objData.Ty_Le_Chuyen_Doi, p_objData.Phep_Tinh_Chuyen_ID, p_objData.Mo_Ta, p_objData.Gia_Ban_Si, p_objData.Gia_Ban_Le, p_objData.Gia_Ban_Dac_Biet, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_DM_Don_Vi_Tinh_Chuyen_Doi(long p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strVTNN_Conn_String, "sp_del_DM_Don_Vi_Tinh_Chuyen_Doi", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
