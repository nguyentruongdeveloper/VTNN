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
using DevExpress.XtraBars;

namespace VTNN.GUI.BanHang
{
    public partial class frmChiTietBanHang : frmChiTietNhapXuatTemplate
    {
        public frmChiTietBanHang()
        {
            InitializeComponent();
        }

        private void frmChiTietBanHang_Load(object sender, EventArgs e)
        {

        }
        protected override void btn_MenuContext_Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.btn_MenuContext_Add_ItemClick(sender, e);
        }
    }
}