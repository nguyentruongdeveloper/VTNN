namespace VTNN.GUI.DanhMuc
{
    partial class frmKho
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
            this.grcKho = new VTNN.Lib.CustomGridControl();
            this.grvKho = new VTNN.Lib.CustomGridView();
            this.cDMKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colAuto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDien_Thoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoi_Lien_He = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMKhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grcKho
            // 
            this.grcKho.DataSource = this.cDMKhoBindingSource;
            this.grcKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcKho.Location = new System.Drawing.Point(0, 40);
            this.grcKho.MainView = this.grvKho;
            this.grcKho.Name = "grcKho";
            this.grcKho.Size = new System.Drawing.Size(1558, 786);
            this.grcKho.TabIndex = 8;
            this.grcKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKho});
            // 
            // grvKho
            // 
            this.grvKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuto_ID,
            this.colMa_Kho,
            this.colTen_Kho,
            this.colDien_Thoai,
            this.colDia_Chi,
            this.colNguoi_Lien_He,
            this.colGhi_Chu});
            this.grvKho.GridControl = this.grcKho;
            this.grvKho.IndicatorWidth = 40;
            this.grvKho.Name = "grvKho";
            this.grvKho.OptionsView.AllowHtmlDrawHeaders = true;
            this.grvKho.OptionsView.EnableAppearanceEvenRow = true;
            this.grvKho.OptionsView.ShowAutoFilterRow = true;
            this.grvKho.OptionsView.ShowGroupPanel = false;
            // 
            // cDMKhoBindingSource
            // 
            this.cDMKhoBindingSource.DataSource = typeof(DTO.DanhMuc.CDM_Kho);
            // 
            // colAuto_ID
            // 
            this.colAuto_ID.Caption = "Auto_ID";
            this.colAuto_ID.FieldName = "Auto_ID";
            this.colAuto_ID.Name = "colAuto_ID";
            // 
            // colMa_Kho
            // 
            this.colMa_Kho.Caption = "Mã kho";
            this.colMa_Kho.FieldName = "Ma_Kho";
            this.colMa_Kho.Name = "colMa_Kho";
            this.colMa_Kho.Visible = true;
            this.colMa_Kho.VisibleIndex = 0;
            // 
            // colTen_Kho
            // 
            this.colTen_Kho.Caption = "Tên kho";
            this.colTen_Kho.FieldName = "Ten_Kho";
            this.colTen_Kho.Name = "colTen_Kho";
            this.colTen_Kho.Visible = true;
            this.colTen_Kho.VisibleIndex = 1;
            // 
            // colDien_Thoai
            // 
            this.colDien_Thoai.Caption = "Điện thoại";
            this.colDien_Thoai.FieldName = "Dien_Thoai";
            this.colDien_Thoai.Name = "colDien_Thoai";
            this.colDien_Thoai.Visible = true;
            this.colDien_Thoai.VisibleIndex = 2;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.Caption = "Địa chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 3;
            // 
            // colNguoi_Lien_He
            // 
            this.colNguoi_Lien_He.Caption = "Người liên hệ";
            this.colNguoi_Lien_He.FieldName = "Nguoi_Lien_He";
            this.colNguoi_Lien_He.Name = "colNguoi_Lien_He";
            this.colNguoi_Lien_He.Visible = true;
            this.colNguoi_Lien_He.VisibleIndex = 4;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.Caption = "Ghi chú";
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 5;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.ClientSize = new System.Drawing.Size(1558, 860);
            this.Controls.Add(this.grcKho);
            this.Name = "frmKho";
            this.Controls.SetChildIndex(this.grcKho, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grcKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMKhoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Lib.CustomGridControl grcKho;
        private System.Windows.Forms.BindingSource cDMKhoBindingSource;
        private Lib.CustomGridView grvKho;
        private DevExpress.XtraGrid.Columns.GridColumn colAuto_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colDien_Thoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoi_Lien_He;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
    }
}