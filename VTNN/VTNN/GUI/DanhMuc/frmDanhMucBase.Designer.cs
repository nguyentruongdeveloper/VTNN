namespace VTNN.GUI.DanhMuc
{
    partial class frmDanhMucBase
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar_btn_ThemMoi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar_btn_Sua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar_btn_Xoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.bar_btn_NapLai = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar_btn_Xuat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar_btn_In = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.bar_btn_Dong = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bar_btn_ThemMoi,
            this.bar_btn_Sua,
            this.bar_btn_Xoa,
            this.bar_btn_NapLai,
            this.bar_btn_Xuat,
            this.bar_btn_In,
            this.bar_btn_Dong,
            this.barStaticItem1,
            this.barStaticItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_ThemMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_Sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_NapLai),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_Xuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_In),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_Dong)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar_btn_ThemMoi
            // 
            this.bar_btn_ThemMoi.Caption = "Thêm mới";
            this.bar_btn_ThemMoi.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bar_btn_ThemMoi.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.bar_btn_ThemMoi.Id = 0;
            this.bar_btn_ThemMoi.ImageOptions.Image = global::VTNN.Properties.Resources.additem_16x16;
            this.bar_btn_ThemMoi.ImageOptions.LargeImage = global::VTNN.Properties.Resources.additem_16x161;
            this.bar_btn_ThemMoi.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar_btn_ThemMoi.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_btn_ThemMoi.MinSize = new System.Drawing.Size(100, 40);
            this.bar_btn_ThemMoi.Name = "bar_btn_ThemMoi";
            this.bar_btn_ThemMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_ThemMoi_ItemClick);
            // 
            // bar_btn_Sua
            // 
            this.bar_btn_Sua.Caption = "Sửa";
            this.bar_btn_Sua.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bar_btn_Sua.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.bar_btn_Sua.Id = 1;
            this.bar_btn_Sua.ImageOptions.Image = global::VTNN.Properties.Resources.edit_16x16;
            this.bar_btn_Sua.ImageOptions.LargeImage = global::VTNN.Properties.Resources.edit_16x161;
            this.bar_btn_Sua.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar_btn_Sua.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_btn_Sua.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar_btn_Sua.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.bar_btn_Sua.MinSize = new System.Drawing.Size(80, 40);
            this.bar_btn_Sua.Name = "bar_btn_Sua";
            this.bar_btn_Sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_Sua_ItemClick);
            // 
            // bar_btn_Xoa
            // 
            this.bar_btn_Xoa.Caption = "Xóa";
            this.bar_btn_Xoa.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bar_btn_Xoa.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.bar_btn_Xoa.Id = 2;
            this.bar_btn_Xoa.ImageOptions.Image = global::VTNN.Properties.Resources.deletelist_16x16;
            this.bar_btn_Xoa.ImageOptions.LargeImage = global::VTNN.Properties.Resources.deletelist_16x161;
            this.bar_btn_Xoa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar_btn_Xoa.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_btn_Xoa.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar_btn_Xoa.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.bar_btn_Xoa.MinSize = new System.Drawing.Size(80, 40);
            this.bar_btn_Xoa.Name = "bar_btn_Xoa";
            this.bar_btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_Xoa_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "|";
            this.barStaticItem1.Id = 7;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bar_btn_NapLai
            // 
            this.bar_btn_NapLai.Caption = "Nạp lại";
            this.bar_btn_NapLai.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bar_btn_NapLai.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.bar_btn_NapLai.Id = 3;
            this.bar_btn_NapLai.ImageOptions.Image = global::VTNN.Properties.Resources.refresh_16x16;
            this.bar_btn_NapLai.ImageOptions.LargeImage = global::VTNN.Properties.Resources.refresh_16x161;
            this.bar_btn_NapLai.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar_btn_NapLai.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_btn_NapLai.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar_btn_NapLai.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.bar_btn_NapLai.MinSize = new System.Drawing.Size(100, 40);
            this.bar_btn_NapLai.Name = "bar_btn_NapLai";
            this.bar_btn_NapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_NapLai_ItemClick);
            // 
            // bar_btn_Xuat
            // 
            this.bar_btn_Xuat.Caption = "Xuất";
            this.bar_btn_Xuat.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bar_btn_Xuat.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.bar_btn_Xuat.Id = 4;
            this.bar_btn_Xuat.ImageOptions.Image = global::VTNN.Properties.Resources.exporttoxls_16x16;
            this.bar_btn_Xuat.ImageOptions.LargeImage = global::VTNN.Properties.Resources.exporttoxlsx_16x16;
            this.bar_btn_Xuat.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar_btn_Xuat.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_btn_Xuat.MinSize = new System.Drawing.Size(80, 40);
            this.bar_btn_Xuat.Name = "bar_btn_Xuat";
            this.bar_btn_Xuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_Xuat_ItemClick);
            // 
            // bar_btn_In
            // 
            this.bar_btn_In.Caption = "In";
            this.bar_btn_In.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bar_btn_In.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.bar_btn_In.Id = 5;
            this.bar_btn_In.ImageOptions.Image = global::VTNN.Properties.Resources.print_16x16;
            this.bar_btn_In.ImageOptions.LargeImage = global::VTNN.Properties.Resources.print_16x161;
            this.bar_btn_In.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar_btn_In.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_btn_In.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar_btn_In.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.bar_btn_In.MinSize = new System.Drawing.Size(80, 40);
            this.bar_btn_In.Name = "bar_btn_In";
            this.bar_btn_In.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_In_ItemClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "|";
            this.barStaticItem2.Id = 8;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bar_btn_Dong
            // 
            this.bar_btn_Dong.Caption = "Đóng";
            this.bar_btn_Dong.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bar_btn_Dong.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.bar_btn_Dong.Id = 6;
            this.bar_btn_Dong.ImageOptions.Image = global::VTNN.Properties.Resources.close_16x162;
            this.bar_btn_Dong.ImageOptions.LargeImage = global::VTNN.Properties.Resources.close_16x163;
            this.bar_btn_Dong.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar_btn_Dong.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_btn_Dong.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar_btn_Dong.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.bar_btn_Dong.MinSize = new System.Drawing.Size(80, 40);
            this.bar_btn_Dong.Name = "bar_btn_Dong";
            this.bar_btn_Dong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_Dong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1303, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 812);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1303, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 772);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1303, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 772);
            // 
            // frmDanhMucBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 837);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDanhMucBase";
            this.Load += new System.EventHandler(this.frmDanhMucBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem bar_btn_ThemMoi;
        private DevExpress.XtraBars.BarLargeButtonItem bar_btn_Sua;
        private DevExpress.XtraBars.BarLargeButtonItem bar_btn_Xoa;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarLargeButtonItem bar_btn_NapLai;
        private DevExpress.XtraBars.BarLargeButtonItem bar_btn_Xuat;
        private DevExpress.XtraBars.BarLargeButtonItem bar_btn_In;
        private DevExpress.XtraBars.BarLargeButtonItem bar_btn_Dong;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
    }
}