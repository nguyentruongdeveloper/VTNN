namespace VTNN.GUI.DanhMuc
{
    partial class frmNhanVien
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
            this.grcNhanVien = new VTNN.Lib.CustomGridControl();
            this.cDMNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvNhanVien = new VTNN.Lib.CustomGridView();
            this.colAuto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nhan_Vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nhan_Vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDien_Thoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grcNhanVien
            // 
            this.grcNhanVien.DataSource = this.cDMNhanVienBindingSource;
            this.grcNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNhanVien.Location = new System.Drawing.Point(0, 40);
            this.grcNhanVien.MainView = this.grvNhanVien;
            this.grcNhanVien.Name = "grcNhanVien";
            this.grcNhanVien.Size = new System.Drawing.Size(1376, 691);
            this.grcNhanVien.TabIndex = 5;
            this.grcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNhanVien});
            // 
            // cDMNhanVienBindingSource
            // 
            this.cDMNhanVienBindingSource.DataSource = typeof(DTO.DanhMuc.CDM_Nhan_Vien);
            // 
            // grvNhanVien
            // 
            this.grvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuto_ID,
            this.colMa_Nhan_Vien,
            this.colTen_Nhan_Vien,
            this.colDien_Thoai,
            this.colDia_Chi});
            this.grvNhanVien.GridControl = this.grcNhanVien;
            this.grvNhanVien.IndicatorWidth = 40;
            this.grvNhanVien.Name = "grvNhanVien";
            this.grvNhanVien.OptionsSelection.MultiSelect = true;
            this.grvNhanVien.OptionsView.AllowHtmlDrawHeaders = true;
            this.grvNhanVien.OptionsView.EnableAppearanceEvenRow = true;
            this.grvNhanVien.OptionsView.ShowAutoFilterRow = true;
            this.grvNhanVien.OptionsView.ShowGroupPanel = false;
            // 
            // colAuto_ID
            // 
            this.colAuto_ID.FieldName = "Auto_ID";
            this.colAuto_ID.Name = "colAuto_ID";
            // 
            // colMa_Nhan_Vien
            // 
            this.colMa_Nhan_Vien.Caption = "Mã nhân viên";
            this.colMa_Nhan_Vien.FieldName = "Ma_Nhan_Vien";
            this.colMa_Nhan_Vien.MaxWidth = 150;
            this.colMa_Nhan_Vien.Name = "colMa_Nhan_Vien";
            this.colMa_Nhan_Vien.Visible = true;
            this.colMa_Nhan_Vien.VisibleIndex = 0;
            this.colMa_Nhan_Vien.Width = 150;
            // 
            // colTen_Nhan_Vien
            // 
            this.colTen_Nhan_Vien.Caption = "Tên nhân viên";
            this.colTen_Nhan_Vien.FieldName = "Ten_Nhan_Vien";
            this.colTen_Nhan_Vien.Name = "colTen_Nhan_Vien";
            this.colTen_Nhan_Vien.Visible = true;
            this.colTen_Nhan_Vien.VisibleIndex = 1;
            this.colTen_Nhan_Vien.Width = 292;
            // 
            // colDien_Thoai
            // 
            this.colDien_Thoai.Caption = "Điện thoại";
            this.colDien_Thoai.FieldName = "Dien_Thoai";
            this.colDien_Thoai.MaxWidth = 150;
            this.colDien_Thoai.Name = "colDien_Thoai";
            this.colDien_Thoai.Visible = true;
            this.colDien_Thoai.VisibleIndex = 2;
            this.colDien_Thoai.Width = 150;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.Caption = "Địa chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 3;
            this.colDia_Chi.Width = 742;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 765);
            this.Controls.Add(this.grcNhanVien);
            this.Name = "frmNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.Controls.SetChildIndex(this.grcNhanVien, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.CustomGridControl grcNhanVien;
        private Lib.CustomGridView grvNhanVien;
        private System.Windows.Forms.BindingSource cDMNhanVienBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAuto_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nhan_Vien;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nhan_Vien;
        private DevExpress.XtraGrid.Columns.GridColumn colDien_Thoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
    }
}