namespace VTNN.GUI.Common
{
    partial class frmTest
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.customDateEdit1 = new VTNN.Lib.CustomDateEdit();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSaveAndNew = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSaveAndPrint = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnClosed = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.docMain = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.customDateEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1026, 605, 562, 500);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1849, 671);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // customDateEdit1
            // 
            this.customDateEdit1.EditValue = null;
            this.customDateEdit1.EnterMoveNextControl = true;
            this.customDateEdit1.IsReset = false;
            this.customDateEdit1.Location = new System.Drawing.Point(155, 16);
            this.customDateEdit1.MenuManager = this.barManager;
            this.customDateEdit1.Name = "customDateEdit1";
            this.customDateEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.customDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("customDateEdit1.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.customDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customDateEdit1.Properties.Mask.EditMask = "99/99/0000";
            this.customDateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.customDateEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.customDateEdit1.Size = new System.Drawing.Size(1678, 26);
            this.customDateEdit1.StyleController = this.layoutControl1;
            this.customDateEdit1.TabIndex = 4;
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControl1);
            this.barManager.DockControls.Add(this.barDockControl2);
            this.barManager.DockControls.Add(this.barDockControl3);
            this.barManager.DockControls.Add(this.barDockControl4);
            this.barManager.DockManager = this.docMain;
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barLargeButtonItem1,
            this.btnSave,
            this.btnSaveAndNew,
            this.btnSaveAndPrint,
            this.btnClosed,
            this.barEditItem1});
            this.barManager.LargeImages = this.imageCollection1;
            this.barManager.MaxItemId = 6;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.barManager.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveAndNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveAndPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClosed)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Id = 0;
            this.barLargeButtonItem1.MinSize = new System.Drawing.Size(460, 50);
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnSave.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.btnSave.Id = 1;
            this.btnSave.ImageOptions.LargeImageIndex = 1;
            this.btnSave.MinSize = new System.Drawing.Size(150, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Caption = "Lưu && Thêm mới";
            this.btnSaveAndNew.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnSaveAndNew.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.btnSaveAndNew.Id = 2;
            this.btnSaveAndNew.ImageOptions.LargeImageIndex = 0;
            this.btnSaveAndNew.MinSize = new System.Drawing.Size(150, 0);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAndNew_ItemClick);
            // 
            // btnSaveAndPrint
            // 
            this.btnSaveAndPrint.Caption = "Lưu && In";
            this.btnSaveAndPrint.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnSaveAndPrint.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.btnSaveAndPrint.Id = 3;
            this.btnSaveAndPrint.ImageOptions.LargeImageIndex = 2;
            this.btnSaveAndPrint.MinSize = new System.Drawing.Size(150, 0);
            this.btnSaveAndPrint.Name = "btnSaveAndPrint";
            this.btnSaveAndPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAndPrint_ItemClick);
            // 
            // btnClosed
            // 
            this.btnClosed.Caption = "Đóng";
            this.btnClosed.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnClosed.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.btnClosed.Id = 4;
            this.btnClosed.ImageOptions.LargeImageIndex = 3;
            this.btnClosed.MinSize = new System.Drawing.Size(150, 0);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClosed_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager;
            this.barDockControl1.Size = new System.Drawing.Size(1849, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 671);
            this.barDockControl2.Manager = this.barManager;
            this.barDockControl2.Size = new System.Drawing.Size(1849, 57);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager;
            this.barDockControl3.Size = new System.Drawing.Size(0, 671);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1849, 0);
            this.barDockControl4.Manager = this.barManager;
            this.barDockControl4.Size = new System.Drawing.Size(0, 671);
            // 
            // docMain
            // 
            this.docMain.Form = this;
            this.docMain.MenuManager = this.barManager;
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
            // barEditItem1
            // 
            this.barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem1.Caption = "In có công nợ";
            this.barEditItem1.CaptionAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.barEditItem1.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.barEditItem1.Edit = this.repositoryItemCheckEdit1;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Size = new System.Drawing.Size(150, 0);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "page_save.png");
            this.imageCollection1.Images.SetKeyName(1, "Save_all_download.png");
            this.imageCollection1.Images.SetKeyName(2, "004855-printer-save.png");
            this.imageCollection1.Images.SetKeyName(3, "cancel-32.png");
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1849, 671);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 32);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(1823, 613);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.customDateEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1823, 32);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(135, 19);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 728);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmTest";
            this.Text = "frmChiTietNhapXuatTemplate";
            this.Load += new System.EventHandler(this.frmChiTietNhapXuatTemplate_Load);
            this.Controls.SetChildIndex(this.barDockControl1, 0);
            this.Controls.SetChildIndex(this.barDockControl2, 0);
            this.Controls.SetChildIndex(this.barDockControl4, 0);
            this.Controls.SetChildIndex(this.barDockControl3, 0);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.Docking.DockManager docMain;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        public DevExpress.XtraBars.BarLargeButtonItem btnSave;
        public DevExpress.XtraBars.BarLargeButtonItem btnSaveAndNew;
        public DevExpress.XtraBars.BarLargeButtonItem btnSaveAndPrint;
        public DevExpress.XtraBars.BarLargeButtonItem btnClosed;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        public DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Lib.CustomDateEdit customDateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}