using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VTNN.GUI.Common;
using Utility;

namespace VTNN.GUI.Kho.XuatKho
{
    public partial class frmChiTietXuatKho : frmChiTietNhapXuatTemplate
    {
        public frmChiTietXuatKho()
        {
            InitializeComponent();
            Set_Thong_Tin_Hien_Thi(NhapXuat.ChungTuNhapKho);
        }

        private void frmChiTietNhapKho_Load(object sender, EventArgs e)
        {
          
           
        }
     
        protected override void Set_Thong_Tin_Hien_Thi(NhapXuat p_NhapXuat)
        {
            base.Set_Thong_Tin_Hien_Thi(NhapXuat.ChungTuNhapKho);
        }
        
    }
}