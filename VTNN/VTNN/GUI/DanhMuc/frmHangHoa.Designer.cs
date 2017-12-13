namespace VTNN.GUI.DanhMuc
{
    partial class frmHangHoa
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
            this.cDMHangHoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grcHangHoa = new VTNN.Lib.CustomGridControl();
            this.cDMHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvHangHoa = new VTNN.Lib.CustomGridView();
            this.colAuto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Hang_Hoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Hang_Hoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nha_San_Xuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Don_Vi_Tinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nhom_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia_Ban_Si = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia_Ban_Le = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia_Ban_Dac_Biet = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cDMHangHoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // cDMHangHoaBindingSource1
            // 
            this.cDMHangHoaBindingSource1.DataSource = typeof(DTO.DanhMuc.CDM_Hang_Hoa);
            // 
            // grcHangHoa
            // 
            this.grcHangHoa.DataSource = this.cDMHangHoaBindingSource;
            this.grcHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcHangHoa.Location = new System.Drawing.Point(0, 40);
            this.grcHangHoa.MainView = this.grvHangHoa;
            this.grcHangHoa.Name = "grcHangHoa";
            this.grcHangHoa.Size = new System.Drawing.Size(1803, 744);
            this.grcHangHoa.TabIndex = 8;
            this.grcHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHangHoa});
            // 
            // cDMHangHoaBindingSource
            // 
            this.cDMHangHoaBindingSource.DataSource = typeof(DTO.DanhMuc.CDM_Hang_Hoa);
            // 
            // grvHangHoa
            // 
            this.grvHangHoa.Appearance.GroupPanel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.grvHangHoa.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Red;
            this.grvHangHoa.Appearance.GroupPanel.Options.UseFont = true;
            this.grvHangHoa.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grvHangHoa.Appearance.GroupRow.BackColor = System.Drawing.Color.White;
            this.grvHangHoa.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuto_ID,
            this.colMa_Hang_Hoa,
            this.colTen_Hang_Hoa,
            this.colTen_Nha_San_Xuat,
            this.colTen_Don_Vi_Tinh,
            this.colTen_Nhom_Hang,
            this.colGia_Ban_Si,
            this.colGia_Ban_Le,
            this.colGia_Ban_Dac_Biet});
            this.grvHangHoa.GridControl = this.grcHangHoa;
            this.grvHangHoa.GroupCount = 1;
            this.grvHangHoa.IndicatorWidth = 40;
            this.grvHangHoa.Name = "grvHangHoa";
            this.grvHangHoa.OptionsView.AllowHtmlDrawHeaders = true;
            this.grvHangHoa.OptionsView.EnableAppearanceEvenRow = true;
            this.grvHangHoa.OptionsView.ShowAutoFilterRow = true;
            this.grvHangHoa.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTen_Nhom_Hang, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colAuto_ID
            // 
            this.colAuto_ID.Caption = "Auto_ID";
            this.colAuto_ID.FieldName = "Auto_ID";
            this.colAuto_ID.Name = "colAuto_ID";
            // 
            // colMa_Hang_Hoa
            // 
            this.colMa_Hang_Hoa.Caption = "Mã hàng hóa";
            this.colMa_Hang_Hoa.FieldName = "Ma_Hang_Hoa";
            this.colMa_Hang_Hoa.Name = "colMa_Hang_Hoa";
            this.colMa_Hang_Hoa.Visible = true;
            this.colMa_Hang_Hoa.VisibleIndex = 0;
            // 
            // colTen_Hang_Hoa
            // 
            this.colTen_Hang_Hoa.Caption = "Tên hàng hóa";
            this.colTen_Hang_Hoa.FieldName = "Ten_Hang_Hoa";
            this.colTen_Hang_Hoa.Name = "colTen_Hang_Hoa";
            this.colTen_Hang_Hoa.Visible = true;
            this.colTen_Hang_Hoa.VisibleIndex = 1;
            // 
            // colTen_Nha_San_Xuat
            // 
            this.colTen_Nha_San_Xuat.Caption = "Nhà sản xuất";
            this.colTen_Nha_San_Xuat.FieldName = "Ten_Nha_San_Xuat";
            this.colTen_Nha_San_Xuat.Name = "colTen_Nha_San_Xuat";
            this.colTen_Nha_San_Xuat.Visible = true;
            this.colTen_Nha_San_Xuat.VisibleIndex = 2;
            // 
            // colTen_Don_Vi_Tinh
            // 
            this.colTen_Don_Vi_Tinh.Caption = "Đơn vị tính";
            this.colTen_Don_Vi_Tinh.FieldName = "Ten_Don_Vi_Tinh";
            this.colTen_Don_Vi_Tinh.Name = "colTen_Don_Vi_Tinh";
            this.colTen_Don_Vi_Tinh.Visible = true;
            this.colTen_Don_Vi_Tinh.VisibleIndex = 3;
            // 
            // colTen_Nhom_Hang
            // 
            this.colTen_Nhom_Hang.Caption = "Nhóm hàng";
            this.colTen_Nhom_Hang.FieldName = "Ten_Nhom_Hang";
            this.colTen_Nhom_Hang.Name = "colTen_Nhom_Hang";
            this.colTen_Nhom_Hang.Visible = true;
            this.colTen_Nhom_Hang.VisibleIndex = 4;
            // 
            // colGia_Ban_Si
            // 
            this.colGia_Ban_Si.Caption = "Giá bán sỉ";
            this.colGia_Ban_Si.FieldName = "Gia_Ban_Si";
            this.colGia_Ban_Si.Name = "colGia_Ban_Si";
            this.colGia_Ban_Si.Visible = true;
            this.colGia_Ban_Si.VisibleIndex = 4;
            // 
            // colGia_Ban_Le
            // 
            this.colGia_Ban_Le.Caption = "Giá bán lẻ";
            this.colGia_Ban_Le.FieldName = "Gia_Ban_Le";
            this.colGia_Ban_Le.Name = "colGia_Ban_Le";
            this.colGia_Ban_Le.Visible = true;
            this.colGia_Ban_Le.VisibleIndex = 5;
            // 
            // colGia_Ban_Dac_Biet
            // 
            this.colGia_Ban_Dac_Biet.Caption = "Giá bán đặc biệt";
            this.colGia_Ban_Dac_Biet.FieldName = "Gia_Ban_Dac_Biet";
            this.colGia_Ban_Dac_Biet.Name = "colGia_Ban_Dac_Biet";
            this.colGia_Ban_Dac_Biet.Visible = true;
            this.colGia_Ban_Dac_Biet.VisibleIndex = 6;
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 818);
            this.Controls.Add(this.grcHangHoa);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHangHoa";
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.Controls.SetChildIndex(this.grcHangHoa, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cDMHangHoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cDMHangHoaBindingSource1;
        private Lib.CustomGridControl grcHangHoa;
        private Lib.CustomGridView grvHangHoa;
        private System.Windows.Forms.BindingSource cDMHangHoaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAuto_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Hang_Hoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Hang_Hoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nha_San_Xuat;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Don_Vi_Tinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nhom_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colGia_Ban_Si;
        private DevExpress.XtraGrid.Columns.GridColumn colGia_Ban_Le;
        private DevExpress.XtraGrid.Columns.GridColumn colGia_Ban_Dac_Biet;
    }
}