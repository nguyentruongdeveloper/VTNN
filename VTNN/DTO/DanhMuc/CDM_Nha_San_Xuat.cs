using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DTO.DanhMuc
{
    public class CDM_Nha_San_Xuat
    {
        private long m_lngAuto_ID;
        private string m_strMa_Nha_San_Xuat;
        private string m_strTen_Nha_San_Xuat;
        private string m_strSo_Dien_Thoai;
        private string m_strDia_Chi;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private bool m_blnDeleted;
        private string m_strGhi_Chu;

        public CDM_Nha_San_Xuat()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_strMa_Nha_San_Xuat = CConst.STR_VALUE_NULL;
            m_strTen_Nha_San_Xuat = CConst.STR_VALUE_NULL;
            m_strSo_Dien_Thoai = CConst.STR_VALUE_NULL;
            m_strDia_Chi = CConst.STR_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_blnDeleted = CConst.BL_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
        }

        public long Auto_ID
        {
            get
            {
                return m_lngAuto_ID;
            }
            set
            {
                m_lngAuto_ID = value;
            }
        }

        public string Ma_Nha_San_Xuat
        {
            get
            {
                return m_strMa_Nha_San_Xuat;
            }
            set
            {
                m_strMa_Nha_San_Xuat = value.Trim();
            }
        }

        public string Ten_Nha_San_Xuat
        {
            get
            {
                return m_strTen_Nha_San_Xuat;
            }
            set
            {
                m_strTen_Nha_San_Xuat = value.Trim();
            }
        }

        public string So_Dien_Thoai
        {
            get
            {
                return m_strSo_Dien_Thoai;
            }
            set
            {
                m_strSo_Dien_Thoai = value.Trim();
            }
        }

        public string Dia_Chi
        {
            get
            {
                return m_strDia_Chi;
            }
            set
            {
                m_strDia_Chi = value.Trim();
            }
        }

        public DateTime Created
        {
            get
            {
                return m_dtmCreated;
            }
            set
            {
                m_dtmCreated = value;
            }
        }

        public string Created_By
        {
            get
            {
                return m_strCreated_By;
            }
            set
            {
                m_strCreated_By = value.Trim();
            }
        }

        public DateTime Last_Updated
        {
            get
            {
                return m_dtmLast_Updated;
            }
            set
            {
                m_dtmLast_Updated = value;
            }
        }

        public string Last_Updated_By
        {
            get
            {
                return m_strLast_Updated_By;
            }
            set
            {
                m_strLast_Updated_By = value.Trim();
            }
        }

        public bool Deleted
        {
            get
            {
                return m_blnDeleted;
            }
            set
            {
                m_blnDeleted = value;
            }
        }

        public string Ghi_Chu
        {
            get
            {
                return m_strGhi_Chu;
            }
            set
            {
                m_strGhi_Chu = value.Trim();
            }
        }
    }
}
