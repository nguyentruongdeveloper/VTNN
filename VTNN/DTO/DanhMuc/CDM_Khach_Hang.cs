﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DTO.DanhMuc
{
    public class CDM_Khach_Hang
    {
        private long m_lngAuto_ID;
        private string m_strMa_Khach_Hang;
        private string m_strTen_Khach_Hang;
        private string m_strDia_Chi;
        private string m_strDien_Thoai;
        private string m_strMa_So_Thue;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private bool m_blnDeleted;

        public CDM_Khach_Hang()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_strMa_Khach_Hang = CConst.STR_VALUE_NULL;
            m_strTen_Khach_Hang = CConst.STR_VALUE_NULL;
            m_strDia_Chi = CConst.STR_VALUE_NULL;
            m_strDien_Thoai = CConst.STR_VALUE_NULL;
            m_strMa_So_Thue = CConst.STR_VALUE_NULL;
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

        public string Ma_Khach_Hang
        {
            get
            {
                return m_strMa_Khach_Hang;
            }
            set
            {
                m_strMa_Khach_Hang = value.Trim();
            }
        }

        public string Ten_Khach_Hang
        {
            get
            {
                return m_strTen_Khach_Hang;
            }
            set
            {
                m_strTen_Khach_Hang = value.Trim();
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

        public string Dien_Thoai
        {
            get
            {
                return m_strDien_Thoai;
            }
            set
            {
                m_strDien_Thoai = value.Trim();
            }
        }

        public string Ma_So_Thue
        {
            get
            {
                return m_strMa_So_Thue;
            }
            set
            {
                m_strMa_So_Thue = value.Trim();
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
