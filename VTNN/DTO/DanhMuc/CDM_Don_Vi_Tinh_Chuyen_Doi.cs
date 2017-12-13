using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DTO.DanhMuc
{
    public class CDM_Don_Vi_Tinh_Chuyen_Doi
    {
        private long m_lngAuto_ID;
        private long m_lngDon_Vi_Tinh_ID;
        private long m_lngHang_Hoa_ID;
        private double m_dblTy_Le_Chuyen_Doi;
        private long m_lngPhep_Tinh_Chuyen_ID;
        private string m_strMo_Ta;
        private double m_dblGia_Ban_Si;
        private double m_dblGia_Ban_Le;
        private double m_dblGia_Ban_Dac_Biet;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private bool m_blnDeleted;

        public CDM_Don_Vi_Tinh_Chuyen_Doi()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_lngDon_Vi_Tinh_ID = CConst.INT_VALUE_NULL;
            m_lngHang_Hoa_ID = CConst.INT_VALUE_NULL;
            m_dblTy_Le_Chuyen_Doi = CConst.DB_VALUE_NULL;
            m_lngPhep_Tinh_Chuyen_ID = CConst.INT_VALUE_NULL;
            m_strMo_Ta = CConst.STR_VALUE_NULL;
            m_dblGia_Ban_Si = CConst.FLT_VALUE_NULL;
            m_dblGia_Ban_Le = CConst.FLT_VALUE_NULL;
            m_dblGia_Ban_Dac_Biet = CConst.FLT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_blnDeleted = CConst.BL_VALUE_NULL;
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

        public long Don_Vi_Tinh_ID
        {
            get
            {
                return m_lngDon_Vi_Tinh_ID;
            }
            set
            {
                m_lngDon_Vi_Tinh_ID = value;
            }
        }

        public long Hang_Hoa_ID
        {
            get
            {
                return m_lngHang_Hoa_ID;
            }
            set
            {
                m_lngHang_Hoa_ID = value;
            }
        }

        public double Ty_Le_Chuyen_Doi
        {
            get
            {
                return m_dblTy_Le_Chuyen_Doi;
            }
            set
            {
                m_dblTy_Le_Chuyen_Doi = value;
            }
        }

        public long Phep_Tinh_Chuyen_ID
        {
            get
            {
                return m_lngPhep_Tinh_Chuyen_ID;
            }
            set
            {
                m_lngPhep_Tinh_Chuyen_ID = value;
            }
        }

        public string Mo_Ta
        {
            get
            {
                return m_strMo_Ta;
            }
            set
            {
                m_strMo_Ta = value.Trim();
            }
        }

        public double Gia_Ban_Si
        {
            get
            {
                return m_dblGia_Ban_Si;
            }
            set
            {
                m_dblGia_Ban_Si = value;
            }
        }

        public double Gia_Ban_Le
        {
            get
            {
                return m_dblGia_Ban_Le;
            }
            set
            {
                m_dblGia_Ban_Le = value;
            }
        }

        public double Gia_Ban_Dac_Biet
        {
            get
            {
                return m_dblGia_Ban_Dac_Biet;
            }
            set
            {
                m_dblGia_Ban_Dac_Biet = value;
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
    }
}
