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
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using static VTNN.Utility.CExtensions;
using VTNN.Utility;
using DevExpress.XtraNavBar;

namespace VTNN.Common
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

     

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsCallForm.InitFormCollection();
            loadDataForm();
        }
        private void loadDataForm()
        {
            CExtensions.CallWaitForm(this);
            try
            {
                foreach (NavBarGroup group in navBarControl_Main.Groups)
                {
                    //AddFeature(group.Name, navBarControl_Main.Name, group.Caption);
                    //AddFeatureGridControl(group.Name, navBarControl_Main.Name, group.Caption);
                    foreach (NavBarControl nbc in group.ControlContainer.Controls.OfType<NavBarControl>())
                    {
                        foreach (NavBarGroup group2 in nbc.Groups)
                        {
                            //AddFeature(group2.Name, group.Name, group2.Caption);
                            // AddFeatureGridControl(group2.Name, group.Name, group2.Caption);
                            foreach (NavBarItemLink item in group2.ItemLinks)
                            {
                                // AddFeature(item.Item.Name, group2.Name, item.Item.Caption);
                                //AddGridControl(group2.Name, item.Item.Name);
                                item.Item.LinkClicked += itemClick_LinkClicked;
                            }
                        }
                    }
                }
                CExtensions.CloseWaitForm();
            }
            catch (Exception ex)
            {
                System.IO.File.Delete(Application.StartupPath + @"//db.sdf");
               
                CExtensions.CloseWaitForm();
                //Application.Restart();
            }
        }

        private void itemClick_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (e.Link.Item.Name == "navBarItem_HeThong_DuLieuKeToan" || e.Link.Item.Name == "navBarItem_HeThong_PPPhanBoChiPhiMuaHang" || e.Link.Item.Name == "navBarItem_HeThong_PPTinhGiaXuatKho"
              || e.Link.Item.Name == "navBarItem_HeThong_ThongTinDonVi")
            {
                DevExpress.XtraEditors.XtraForm frm = clsCallForm.CreateNewForm(e.Link.Item.Name);
                if (frm != null)
                    frm.ShowDialog();
            }
            else
            {
                CExtensions.CallWaitForm(this);
                addDocument(clsCallForm.CreateNewForm(e.Link.Item.Name));
                CExtensions.CloseWaitForm();

            }

        }

        private void addDocument(DevExpress.XtraEditors.XtraForm _xtrForm)
        {
            if (_xtrForm == null) return; 
            BaseDocument document = docMain.GetDocument(_xtrForm);
            if (document != null)
                tvMain.Controller.Activate(document);
            else
            {
            
                _xtrForm.MdiParent = this;
                _xtrForm.Show();
            }
        }
     
      

    }
}