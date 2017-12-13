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


namespace VTNN.GUI.NhapHang
{
    public partial class frmChungTuHangMuaTraLai : frmListTemplate
    {
        public frmChungTuHangMuaTraLai()
        {
            InitializeComponent();
        }

        private void frmChungTuBanHang_Load(object sender, EventArgs e)
        {

        }
        protected override void bar_btn_Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add();
        }
        private void Add()
        {
            using (frmChiTietHangMuaTraLai frm = new frmChiTietHangMuaTraLai())
            {
                frm.fStatus = Utility.FormStatus.Add;
                frm.ShowDialog();
            }

        }
    }
}