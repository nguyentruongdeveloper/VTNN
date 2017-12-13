namespace VTNN.GUI.Common
{
    partial class frmTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemplate));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.MenuContext = new DevExpress.XtraBars.PopupMenu(this.components);
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.btn_MenuContext_Add = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btn_MenuContext_Edit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btn_MenuContext_Deleted = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btn_MenuContext_DeletedAll = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btn_MenuContext_Save = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btn_MenuContext_Refesh = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.btn_MenuContext_Closed = new DevExpress.XtraBars.BarLargeButtonItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.barToolbarsListItem1,
            this.btn_MenuContext_Add,
            this.btn_MenuContext_Edit,
            this.btn_MenuContext_Deleted,
            this.btn_MenuContext_DeletedAll,
            this.barStaticItem1,
            this.btn_MenuContext_Save,
            this.btn_MenuContext_Refesh,
            this.barStaticItem2,
            this.btn_MenuContext_Closed});
            this.barManager1.LargeImages = this.imageCollection1;
            this.barManager1.MaxItemId = 22;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1754, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1012);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1754, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1012);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1754, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1012);
            // 
            // MenuContext
            // 
            this.MenuContext.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_MenuContext_Add),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_MenuContext_Edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_MenuContext_Deleted),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_MenuContext_DeletedAll),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_MenuContext_Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_MenuContext_Refesh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_MenuContext_Closed)});
            this.MenuContext.Manager = this.barManager1;
            this.MenuContext.Name = "MenuContext";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 11;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 12;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // btn_MenuContext_Add
            // 
            this.btn_MenuContext_Add.Caption = "Thêm mới";
            this.btn_MenuContext_Add.Id = 13;
            this.btn_MenuContext_Add.ImageOptions.ImageIndex = 1;
            this.btn_MenuContext_Add.ImageOptions.LargeImageIndex = 1;
            this.btn_MenuContext_Add.Name = "btn_MenuContext_Add";
            this.btn_MenuContext_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MenuContext_Add_ItemClick);
            // 
            // btn_MenuContext_Edit
            // 
            this.btn_MenuContext_Edit.Caption = "Sửa";
            this.btn_MenuContext_Edit.Id = 14;
            this.btn_MenuContext_Edit.ImageOptions.ImageIndex = 3;
            this.btn_MenuContext_Edit.ImageOptions.LargeImageIndex = 3;
            this.btn_MenuContext_Edit.Name = "btn_MenuContext_Edit";
            this.btn_MenuContext_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MenuContext_Edit_ItemClick);
            // 
            // btn_MenuContext_Deleted
            // 
            this.btn_MenuContext_Deleted.Caption = "Xóa";
            this.btn_MenuContext_Deleted.Id = 15;
            this.btn_MenuContext_Deleted.ImageOptions.ImageIndex = 2;
            this.btn_MenuContext_Deleted.Name = "btn_MenuContext_Deleted";
            this.btn_MenuContext_Deleted.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MenuContext_Deleted_ItemClick);
            // 
            // btn_MenuContext_DeletedAll
            // 
            this.btn_MenuContext_DeletedAll.Caption = "Xóa tất cả";
            this.btn_MenuContext_DeletedAll.Id = 16;
            this.btn_MenuContext_DeletedAll.ImageOptions.ImageIndex = 2;
            this.btn_MenuContext_DeletedAll.Name = "btn_MenuContext_DeletedAll";
            this.btn_MenuContext_DeletedAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MenuContext_DeletedAll_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "_____________________";
            this.barStaticItem1.Id = 17;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btn_MenuContext_Save
            // 
            this.btn_MenuContext_Save.Caption = "Lưu";
            this.btn_MenuContext_Save.Id = 18;
            this.btn_MenuContext_Save.ImageOptions.ImageIndex = 6;
            this.btn_MenuContext_Save.Name = "btn_MenuContext_Save";
            this.btn_MenuContext_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MenuContext_Save_ItemClick);
            // 
            // btn_MenuContext_Refesh
            // 
            this.btn_MenuContext_Refesh.Caption = "Nạp lại";
            this.btn_MenuContext_Refesh.Id = 19;
            this.btn_MenuContext_Refesh.ImageOptions.ImageIndex = 7;
            this.btn_MenuContext_Refesh.Name = "btn_MenuContext_Refesh";
            this.btn_MenuContext_Refesh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MenuContext_Refesh_ItemClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "_____________________";
            this.barStaticItem2.Id = 20;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btn_MenuContext_Closed
            // 
            this.btn_MenuContext_Closed.Caption = "Đóng";
            this.btn_MenuContext_Closed.Id = 21;
            this.btn_MenuContext_Closed.ImageOptions.ImageIndex = 0;
            this.btn_MenuContext_Closed.Name = "btn_MenuContext_Closed";
            this.btn_MenuContext_Closed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MenuContext_Closed_ItemClick);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "cancel16x16.png");
            this.imageCollection1.Images.SetKeyName(1, "page_add16x16.png");
            this.imageCollection1.Images.SetKeyName(2, "page_delete16x16.png");
            this.imageCollection1.Images.SetKeyName(3, "page_edit16x16.png");
            this.imageCollection1.Images.SetKeyName(4, "page_excel16x16.png");
            this.imageCollection1.Images.SetKeyName(5, "print_16x16.png");
            this.imageCollection1.Images.SetKeyName(6, "save1_16x16.png");
            this.imageCollection1.Images.SetKeyName(7, "sync_reload_refresh_arrow-16x16.png");
            // 
            // frmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 1012);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTemplate";
            this.barManager1.SetPopupContextMenu(this, this.MenuContext);
            this.Text = "frmTemplate";
            this.Load += new System.EventHandler(this.frmTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu MenuContext;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        public DevExpress.XtraBars.BarLargeButtonItem btn_MenuContext_Add;
        public DevExpress.XtraBars.BarLargeButtonItem btn_MenuContext_Edit;
        public DevExpress.XtraBars.BarLargeButtonItem btn_MenuContext_Deleted;
        public DevExpress.XtraBars.BarLargeButtonItem btn_MenuContext_DeletedAll;
        public DevExpress.XtraBars.BarLargeButtonItem btn_MenuContext_Save;
        public DevExpress.XtraBars.BarLargeButtonItem btn_MenuContext_Refesh;
        public DevExpress.XtraBars.BarLargeButtonItem btn_MenuContext_Closed;
    }
}