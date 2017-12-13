namespace VTNN.GUI.DanhMuc
{
    partial class frmDonViTinh
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
            this.cDMDonViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grcDVT = new VTNN.Lib.CustomGridControl();
            this.grvDVT = new VTNN.Lib.CustomGridView();
            this.cDMDonViTinhBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colAuto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Don_Vi_Tinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Don_Vi_Tinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cDMDonViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMDonViTinhBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cDMDonViTinhBindingSource
            // 
            this.cDMDonViTinhBindingSource.DataSource = typeof(DTO.DanhMuc.CDM_Don_Vi_Tinh);
            // 
            // grcDVT
            // 
            this.grcDVT.DataSource = this.cDMDonViTinhBindingSource1;
            this.grcDVT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDVT.Location = new System.Drawing.Point(0, 40);
            this.grcDVT.MainView = this.grvDVT;
            this.grcDVT.Name = "grcDVT";
            this.grcDVT.Size = new System.Drawing.Size(1697, 738);
            this.grcDVT.TabIndex = 8;
            this.grcDVT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDVT});
            // 
            // grvDVT
            // 
            this.grvDVT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuto_ID,
            this.colMa_Don_Vi_Tinh,
            this.colTen_Don_Vi_Tinh,
            this.colGhi_Chu});
            this.grvDVT.GridControl = this.grcDVT;
            this.grvDVT.IndicatorWidth = 40;
            this.grvDVT.Name = "grvDVT";
            this.grvDVT.OptionsView.AllowHtmlDrawHeaders = true;
            this.grvDVT.OptionsView.EnableAppearanceEvenRow = true;
            this.grvDVT.OptionsView.ShowAutoFilterRow = true;
            this.grvDVT.OptionsView.ShowGroupPanel = false;
            // 
            // cDMDonViTinhBindingSource1
            // 
            this.cDMDonViTinhBindingSource1.DataSource = typeof(DTO.DanhMuc.CDM_Don_Vi_Tinh);
            // 
            // colAuto_ID
            // 
            this.colAuto_ID.Caption = "Auto_ID";
            this.colAuto_ID.FieldName = "Auto_ID";
            this.colAuto_ID.Name = "colAuto_ID";
            // 
            // colMa_Don_Vi_Tinh
            // 
            this.colMa_Don_Vi_Tinh.Caption = "Mã đơn vị tính";
            this.colMa_Don_Vi_Tinh.FieldName = "Ma_Don_Vi_Tinh";
            this.colMa_Don_Vi_Tinh.Name = "colMa_Don_Vi_Tinh";
            this.colMa_Don_Vi_Tinh.Visible = true;
            this.colMa_Don_Vi_Tinh.VisibleIndex = 0;
            // 
            // colTen_Don_Vi_Tinh
            // 
            this.colTen_Don_Vi_Tinh.Caption = "Tên đơn vị tính";
            this.colTen_Don_Vi_Tinh.FieldName = "Ten_Don_Vi_Tinh";
            this.colTen_Don_Vi_Tinh.Name = "colTen_Don_Vi_Tinh";
            this.colTen_Don_Vi_Tinh.Visible = true;
            this.colTen_Don_Vi_Tinh.VisibleIndex = 1;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.Caption = "Ghi chú";
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 2;
            // 
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 812);
            this.Controls.Add(this.grcDVT);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDonViTinh";
            this.Text = "Đơn vị tính";
            this.Load += new System.EventHandler(this.frmDonViTinh_Load);
            this.Controls.SetChildIndex(this.grcDVT, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cDMDonViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMDonViTinhBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cDMDonViTinhBindingSource;
        private Lib.CustomGridControl grcDVT;
        private System.Windows.Forms.BindingSource cDMDonViTinhBindingSource1;
        private Lib.CustomGridView grvDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colAuto_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Don_Vi_Tinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Don_Vi_Tinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
    }
}