using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DTO.DanhMuc
{
    public class CDM_Hang_Hoa
    {
        private long m_lngAuto_ID;
        private string m_strMa_Hang_Hoa;
        private string m_strTen_Hang_Hoa;
        private long m_lngDon_Vi_Tinh_ID;
        private long m_lngNhom_Hang_Hoa_ID;
        private double m_dblGia_Nhap;
        private double m_dblGia_Ban_Si;
        private double m_dblGia_Ban_Le;
        private double m_dblGia_Ban_Tien_Mat;
        private double m_dblGia_Ban_No;
        private double m_dblGia_Ban_Dac_Biet;
        private long m_lngNha_San_Xuat_ID;
        private string m_strNguon_Goc;
        private string m_strMo_Ta;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private bool m_blnDeleted;
        private string m_strTen_Don_Vi_Tinh;
        private string m_strTen_Nhom_Hang;
        private string m_strTen_Nha_San_Xuat;

        public string Ten_Nha_San_Xuat
        {
            get { return m_strTen_Nha_San_Xuat; }
            set { m_strTen_Nha_San_Xuat = value; }
        }


        public string Ten_Nhom_Hang
        {
            get { return m_strTen_Nhom_Hang; }
            set { m_strTen_Nhom_Hang = value; }
        }


        public string Ten_Don_Vi_Tinh
        {
            get { return m_strTen_Don_Vi_Tinh; }
            set { m_strTen_Don_Vi_Tinh = value; }
        }


        public CDM_Hang_Hoa()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_strMa_Hang_Hoa = CConst.STR_VALUE_NULL;
            m_strTen_Hang_Hoa = CConst.STR_VALUE_NULL;
            m_lngDon_Vi_Tinh_ID = CConst.INT_VALUE_NULL;
            m_lngNhom_Hang_Hoa_ID = CConst.INT_VALUE_NULL;
            m_dblGia_Nhap = CConst.FLT_VALUE_NULL;
            m_dblGia_Ban_Si = CConst.FLT_VALUE_NULL;
            m_dblGia_Ban_Le = CConst.FLT_VALUE_NULL;
            m_dblGia_Ban_Tien_Mat = CConst.FLT_VALUE_NULL;
            m_dblGia_Ban_No = CConst.FLT_VALUE_NULL;
            m_dblGia_Ban_Dac_Biet = CConst.FLT_VALUE_NULL;
            m_lngNha_San_Xuat_ID = CConst.INT_VALUE_NULL;
            m_strNguon_Goc = CConst.STR_VALUE_NULL;
            m_strMo_Ta = CConst.STR_VALUE_NULL;
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

        public string Ma_Hang_Hoa
        {
            get
            {
                return m_strMa_Hang_Hoa;
            }
            set
            {
                m_strMa_Hang_Hoa = value.Trim();
            }
        }

        public string Ten_Hang_Hoa
        {
            get
            {
                return m_strTen_Hang_Hoa;
            }
            set
            {
                m_strTen_Hang_Hoa = value.Trim();
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

        public long Nhom_Hang_Hoa_ID
        {
            get
            {
                return m_lngNhom_Hang_Hoa_ID;
            }
            set
            {
                m_lngNhom_Hang_Hoa_ID = value;
            }
        }

        public double Gia_Nhap
        {
            get
            {
                return m_dblGia_Nhap;
            }
            set
            {
                m_dblGia_Nhap = value;
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

        public double Gia_Ban_Tien_Mat
        {
            get
            {
                return m_dblGia_Ban_Tien_Mat;
            }
            set
            {
                m_dblGia_Ban_Tien_Mat = value;
            }
        }

        public double Gia_Ban_No
        {
            get
            {
                return m_dblGia_Ban_No;
            }
            set
            {
                m_dblGia_Ban_No = value;
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

        public long Nha_San_Xuat_ID
        {
            get
            {
                return m_lngNha_San_Xuat_ID;
            }
            set
            {
                m_lngNha_San_Xuat_ID = value;
            }
        }

        public string Nguon_Goc
        {
            get
            {
                return m_strNguon_Goc;
            }
            set
            {
                m_strNguon_Goc = value.Trim();
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


