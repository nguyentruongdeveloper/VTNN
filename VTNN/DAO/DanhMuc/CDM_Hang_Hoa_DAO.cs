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
    public class CDM_Hang_Hoa_DAO
    {
        private static CDM_Hang_Hoa_DAO Instance { get; set; }
        public static CDM_Hang_Hoa_DAO getInstance()
        {
            if (Instance == null)
                Instance = new CDM_Hang_Hoa_DAO();
            return Instance;
        }
        private void MapDM_Hang_Hoa(DataRow p_row, CDM_Hang_Hoa p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int64(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Ma_Hang_Hoa"))
                p_objDes.Ma_Hang_Hoa = CUtility.Convert_To_String(p_row["Ma_Hang_Hoa"]);

            if (p_dt.Columns.Contains("Ten_Hang_Hoa"))
                p_objDes.Ten_Hang_Hoa = CUtility.Convert_To_String(p_row["Ten_Hang_Hoa"]);

            if (p_dt.Columns.Contains("Don_Vi_Tinh_ID"))
                p_objDes.Don_Vi_Tinh_ID = CUtility.Convert_To_Int64(p_row["Don_Vi_Tinh_ID"]);

            if (p_dt.Columns.Contains("Ten_Don_Vi_Tinh"))
                p_objDes.Ten_Don_Vi_Tinh = CUtility.Convert_To_String(p_row["Ten_Don_Vi_Tinh"]);

            if (p_dt.Columns.Contains("Nhom_Hang_Hoa_ID"))
                p_objDes.Nhom_Hang_Hoa_ID = CUtility.Convert_To_Int64(p_row["Nhom_Hang_Hoa_ID"]);

            if (p_dt.Columns.Contains("Ten_Nhom_Hang"))
                p_objDes.Ten_Nhom_Hang = CUtility.Convert_To_String(p_row["Ten_Nhom_Hang"]);

            if (p_dt.Columns.Contains("Gia_Nhap"))
                p_objDes.Gia_Nhap = CUtility.Convert_To_Double(p_row["Gia_Nhap"]);

            if (p_dt.Columns.Contains("Gia_Ban_Si"))
                p_objDes.Gia_Ban_Si = CUtility.Convert_To_Double(p_row["Gia_Ban_Si"]);

            if (p_dt.Columns.Contains("Gia_Ban_Le"))
                p_objDes.Gia_Ban_Le = CUtility.Convert_To_Double(p_row["Gia_Ban_Le"]);

            if (p_dt.Columns.Contains("Gia_Ban_Dac_Biet"))
                p_objDes.Gia_Ban_Dac_Biet = CUtility.Convert_To_Double(p_row["Gia_Ban_Dac_Biet"]);

            if (p_dt.Columns.Contains("Gia_Ban_Tien_Mat"))
				p_objDes.Gia_Ban_Tien_Mat = CUtility.Convert_To_Double(p_row["Gia_Ban_Tien_Mat"]);

			if (p_dt.Columns.Contains("Gia_Ban_No"))
				p_objDes.Gia_Ban_No = CUtility.Convert_To_Double(p_row["Gia_Ban_No"]);


            if (p_dt.Columns.Contains("Nha_San_Xuat_ID"))
                p_objDes.Nha_San_Xuat_ID = CUtility.Convert_To_Int64(p_row["Nha_San_Xuat_ID"]);

            if (p_dt.Columns.Contains("Ten_Nha_San_Xuat"))
                p_objDes.Ten_Nha_San_Xuat = CUtility.Convert_To_String(p_row["Ten_Nha_San_Xuat"]);

            if (p_dt.Columns.Contains("Nguon_Goc"))
                p_objDes.Nguon_Goc = CUtility.Convert_To_String(p_row["Nguon_Goc"]);

            if (p_dt.Columns.Contains("Mo_Ta"))
                p_objDes.Mo_Ta = CUtility.Convert_To_String(p_row["Mo_Ta"]);

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

        public IList<CDM_Hang_Hoa> List_DM_Hang_Hoa()
        {
            IList<CDM_Hang_Hoa> v_arrRes = new List<CDM_Hang_Hoa>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strVTNN_Conn_String, v_dt, "sp_sel_List_DM_Hang_Hoa");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_Hang_Hoa v_objRes = new CDM_Hang_Hoa();
                    MapDM_Hang_Hoa(v_row, v_objRes);
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

        public CDM_Hang_Hoa Get_DM_Hang_Hoa_By_ID(long p_iID)
        {
            CDM_Hang_Hoa v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strVTNN_Conn_String, v_dt, "sp_sel_Get_DM_Hang_Hoa_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CDM_Hang_Hoa();
                    MapDM_Hang_Hoa(v_dt.Rows[0], v_objRes);
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

        public Int64 Insert_DM_Hang_Hoa(CDM_Hang_Hoa p_objData)
        {
            Int64 v_iRes = CConst.INT64_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.g_strVTNN_Conn_String, "sp_ins_DM_Hang_Hoa",
                    p_objData.Ma_Hang_Hoa, p_objData.Ten_Hang_Hoa, p_objData.Don_Vi_Tinh_ID, p_objData.Nhom_Hang_Hoa_ID, p_objData.Gia_Nhap, p_objData.Gia_Ban_Si, p_objData.Gia_Ban_Le, p_objData.Gia_Ban_Dac_Biet, p_objData.Nha_San_Xuat_ID, p_objData.Nguon_Goc, p_objData.Mo_Ta, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public Int64 FHH0001_Insert_DM_Hang_Hoa(SqlConnection p_Cons, SqlTransaction p_Trans, CDM_Hang_Hoa p_objData)
        {
            Int64 v_iRes = CConst.INT64_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_Cons, p_Trans, CConfig.g_strVTNN_Conn_String, "sp_ins_DM_Hang_Hoa",
                    p_objData.Ma_Hang_Hoa, p_objData.Ten_Hang_Hoa, p_objData.Don_Vi_Tinh_ID, p_objData.Nhom_Hang_Hoa_ID, p_objData.Gia_Nhap, p_objData.Gia_Ban_Si, p_objData.Gia_Ban_Le, p_objData.Gia_Ban_Tien_Mat, p_objData.Gia_Ban_No, p_objData.Gia_Ban_Dac_Biet, p_objData.Nha_San_Xuat_ID, p_objData.Nguon_Goc, p_objData.Mo_Ta, p_objData.Last_Updated_By));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return v_iRes;
        }

        public void Update_DM_Hang_Hoa(CDM_Hang_Hoa p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strVTNN_Conn_String, "sp_ins_DM_Hang_Hoa",
                    p_objData.Ma_Hang_Hoa, p_objData.Ten_Hang_Hoa, p_objData.Don_Vi_Tinh_ID, p_objData.Nhom_Hang_Hoa_ID, p_objData.Gia_Nhap, p_objData.Gia_Ban_Si, p_objData.Gia_Ban_Le, p_objData.Gia_Ban_Tien_Mat, p_objData.Gia_Ban_No, p_objData.Gia_Ban_Dac_Biet, p_objData.Nha_San_Xuat_ID, p_objData.Nguon_Goc, p_objData.Mo_Ta, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FHH0002_Update_DM_Hang_Hoa(SqlConnection p_Cons, SqlTransaction p_Trans, CDM_Hang_Hoa p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_Cons,p_Trans, CConfig.g_strVTNN_Conn_String, "sp_upd_DM_Hang_Hoa", p_objData.Auto_ID,
                    p_objData.Ma_Hang_Hoa, p_objData.Ten_Hang_Hoa, p_objData.Don_Vi_Tinh_ID, p_objData.Nhom_Hang_Hoa_ID, p_objData.Gia_Nhap, p_objData.Gia_Ban_Si, p_objData.Gia_Ban_Le, p_objData.Gia_Ban_Tien_Mat, p_objData.Gia_Ban_No, p_objData.Gia_Ban_Dac_Biet, p_objData.Nha_San_Xuat_ID, p_objData.Nguon_Goc, p_objData.Mo_Ta, p_objData.Last_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete_DM_Hang_Hoa(long p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strVTNN_Conn_String, "sp_del_DM_Hang_Hoa", p_iAuto_ID, p_strLast_Updated_By);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
