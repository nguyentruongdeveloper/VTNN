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
using DevExpress.XtraNavBar;
using static VTNN.Extensions.CExtensions;
using VTNN.Extensions;
using VTNN.GUI.Common;

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
                    foreach (NavBarItemLink item in group.ItemLinks)
                    {

                        item.Item.LinkClicked += itemClick_LinkClicked;
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
           
            frmTemplate frm = (frmTemplate)clsCallForm.CreateNewForm(e.Link.Item.Name);
            if(frm!=null)
            {
               if(frm.fType==Utility.FormType.Sub)
                {
                    frm.fStatus = Utility.FormStatus.Add;
                    frm.ShowDialog();
                }
                else
                {
                    CExtensions.CallWaitForm(this);
                    addDocument(clsCallForm.CreateNewForm(e.Link.Item.Name));
                    CExtensions.CloseWaitForm();
                }
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

        private void navBarControl_Main_Click(object sender, EventArgs e)
        {

        }
    }
}