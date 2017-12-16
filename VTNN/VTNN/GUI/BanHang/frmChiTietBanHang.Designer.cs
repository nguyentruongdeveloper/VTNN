namespace VTNN.GUI.BanHang
{
    partial class frmChiTietBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietBanHang));
            this.docMain = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.docTimKiem = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.grMain = new DevExpress.XtraEditors.GroupControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.barMain = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarLargeButtonItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnSaveAndNew = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSaveAndPrint = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnXem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnClosed = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.docMain)).BeginInit();
            this.docTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grMain)).BeginInit();
            this.grMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // docMain
            // 
            this.docMain.Form = this;
            this.docMain.MenuManager = this.barMain;
            this.docMain.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.docTimKiem});
            this.docMain.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // docTimKiem
            // 
            this.docTimKiem.Controls.Add(this.dockPanel1_Container);
            this.docTimKiem.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.docTimKiem.ID = new System.Guid("2c780d86-15ff-4334-a5c7-d0a89091c104");
            this.docTimKiem.Location = new System.Drawing.Point(0, 0);
            this.docTimKiem.Name = "docTimKiem";
            this.docTimKiem.OriginalSize = new System.Drawing.Size(344, 200);
            this.docTimKiem.Size = new System.Drawing.Size(344, 837);
            this.docTimKiem.Text = "Tìm kiếm";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(5, 29);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(332, 803);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grMain);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(344, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(780, 361, 562, 500);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1140, 837);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(13, 13, 0, 13);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1140, 837);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // grMain
            // 
            this.grMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.grMain.Controls.Add(this.barDockControl3);
            this.grMain.Controls.Add(this.barDockControl4);
            this.grMain.Controls.Add(this.barDockControl2);
            this.grMain.Controls.Add(this.barDockControl1);
            this.grMain.Location = new System.Drawing.Point(16, 3);
            this.grMain.Name = "grMain";
            this.grMain.ShowCaption = false;
            this.grMain.Size = new System.Drawing.Size(1108, 49);
            this.grMain.TabIndex = 4;
            this.grMain.Text = "groupControl1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grMain;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1114, 55);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 55);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1114, 769);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // barMain
            // 
            this.barMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barMain.DockControls.Add(this.barDockControl1);
            this.barMain.DockControls.Add(this.barDockControl2);
            this.barMain.DockControls.Add(this.barDockControl3);
            this.barMain.DockControls.Add(this.barDockControl4);
            this.barMain.DockManager = this.docMain;
            this.barMain.Form = this.grMain;
            this.barMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSave,
            this.btnSaveAndNew,
            this.btnSaveAndPrint,
            this.btnXem,
            this.btnClosed});
            this.barMain.LargeImages = this.imageCollection1;
            this.barMain.MainMenu = this.bar2;
            this.barMain.MaxItemId = 5;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barMain;
            this.barDockControl1.Size = new System.Drawing.Size(1108, 50);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 49);
            this.barDockControl2.Manager = this.barMain;
            this.barDockControl2.Size = new System.Drawing.Size(1108, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 50);
            this.barDockControl3.Manager = this.barMain;
            this.barDockControl3.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1108, 50);
            this.barDockControl4.Manager = this.barMain;
            this.barDockControl4.Size = new System.Drawing.Size(0, 0);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveAndNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveAndPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClosed)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnSave.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.btnSave.Id = 0;
            this.btnSave.ImageOptions.LargeImageIndex = 4;
            this.btnSave.MinSize = new System.Drawing.Size(150, 50);
            this.btnSave.Name = "btnSave";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "004855-printer-save.png");
            this.imageCollection1.Images.SetKeyName(1, "cancel-32.png");
            this.imageCollection1.Images.SetKeyName(2, "page_save.png");
            this.imageCollection1.Images.SetKeyName(3, "print_preview-32.png");
            this.imageCollection1.Images.SetKeyName(4, "Save_all_download.png");
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Caption = "Lưu && Thêm mới";
            this.btnSaveAndNew.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnSaveAndNew.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.btnSaveAndNew.Id = 1;
            this.btnSaveAndNew.ImageOptions.LargeImageIndex = 2;
            this.btnSaveAndNew.MinSize = new System.Drawing.Size(150, 0);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            // 
            // btnSaveAndPrint
            // 
            this.btnSaveAndPrint.Caption = "Lưu && In";
            this.btnSaveAndPrint.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnSaveAndPrint.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.btnSaveAndPrint.Id = 2;
            this.btnSaveAndPrint.ImageOptions.LargeImageIndex = 0;
            this.btnSaveAndPrint.MinSize = new System.Drawing.Size(150, 0);
            this.btnSaveAndPrint.Name = "btnSaveAndPrint";
            // 
            // btnXem
            // 
            this.btnXem.Caption = "Xem";
            this.btnXem.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnXem.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.btnXem.Id = 3;
            this.btnXem.ImageOptions.LargeImageIndex = 3;
            this.btnXem.MinSize = new System.Drawing.Size(150, 0);
            this.btnXem.Name = "btnXem";
            // 
            // btnClosed
            // 
            this.btnClosed.Caption = "Đóng";
            this.btnClosed.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnClosed.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.btnClosed.Id = 4;
            this.btnClosed.ImageOptions.LargeImageIndex = 1;
            this.btnClosed.MinSize = new System.Drawing.Size(150, 0);
            this.btnClosed.Name = "btnClosed";
            // 
            // frmChiTietBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.ClientSize = new System.Drawing.Size(1484, 837);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.docTimKiem);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChiTietBanHang";
            this.Text = "Chi tiết bán hàng";
            this.Controls.SetChildIndex(this.docTimKiem, 0);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.docMain)).EndInit();
            this.docTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grMain)).EndInit();
            this.grMain.ResumeLayout(false);
            this.grMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private DevExpress.XtraBars.Docking.DockManager docMain;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl grMain;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barMain;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnSave;
        private DevExpress.XtraBars.BarLargeButtonItem btnSaveAndNew;
        private DevExpress.XtraBars.BarLargeButtonItem btnSaveAndPrint;
        private DevExpress.XtraBars.BarLargeButtonItem btnXem;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.Docking.DockPanel docTimKiem;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarLargeButtonItem btnClosed;
    }
}