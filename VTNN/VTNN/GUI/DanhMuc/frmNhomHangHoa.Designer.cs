namespace VTNN.GUI.DanhMuc
{
    partial class frmNhomHangHoa
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
            this.grcNhomHangHoa = new VTNN.Lib.CustomGridControl();
            this.cDMNhomHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvNhomHangHoa = new VTNN.Lib.CustomGridView();
            this.colAuto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nhom_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nhom_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMNhomHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhomHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // grcNhomHangHoa
            // 
            this.grcNhomHangHoa.DataSource = this.cDMNhomHangHoaBindingSource;
            this.grcNhomHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNhomHangHoa.Location = new System.Drawing.Point(0, 40);
            this.grcNhomHangHoa.MainView = this.grvNhomHangHoa;
            this.grcNhomHangHoa.Name = "grcNhomHangHoa";
            this.grcNhomHangHoa.Size = new System.Drawing.Size(1394, 601);
            this.grcNhomHangHoa.TabIndex = 4;
            this.grcNhomHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNhomHangHoa});
            // 
            // cDMNhomHangHoaBindingSource
            // 
            this.cDMNhomHangHoaBindingSource.DataSource = typeof(DTO.DanhMuc.CDM_Nhom_Hang_Hoa);
            // 
            // grvNhomHangHoa
            // 
            this.grvNhomHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuto_ID,
            this.colMa_Nhom_Hang,
            this.colTen_Nhom_Hang,
            this.colGhi_Chu});
            this.grvNhomHangHoa.GridControl = this.grcNhomHangHoa;
            this.grvNhomHangHoa.IndicatorWidth = 40;
            this.grvNhomHangHoa.Name = "grvNhomHangHoa";
            this.grvNhomHangHoa.OptionsSelection.MultiSelect = true;
            this.grvNhomHangHoa.OptionsView.AllowHtmlDrawHeaders = true;
            this.grvNhomHangHoa.OptionsView.EnableAppearanceEvenRow = true;
            this.grvNhomHangHoa.OptionsView.ShowAutoFilterRow = true;
            this.grvNhomHangHoa.OptionsView.ShowGroupPanel = false;
            // 
            // colAuto_ID
            // 
            this.colAuto_ID.FieldName = "Auto_ID";
            this.colAuto_ID.Name = "colAuto_ID";
            // 
            // colMa_Nhom_Hang
            // 
            this.colMa_Nhom_Hang.Caption = "Mã nhóm hàng";
            this.colMa_Nhom_Hang.FieldName = "Ma_Nhom_Hang";
            this.colMa_Nhom_Hang.MaxWidth = 150;
            this.colMa_Nhom_Hang.Name = "colMa_Nhom_Hang";
            this.colMa_Nhom_Hang.Visible = true;
            this.colMa_Nhom_Hang.VisibleIndex = 0;
            this.colMa_Nhom_Hang.Width = 150;
            // 
            // colTen_Nhom_Hang
            // 
            this.colTen_Nhom_Hang.Caption = "Tên nhóm hàng";
            this.colTen_Nhom_Hang.FieldName = "Ten_Nhom_Hang";
            this.colTen_Nhom_Hang.Name = "colTen_Nhom_Hang";
            this.colTen_Nhom_Hang.Visible = true;
            this.colTen_Nhom_Hang.VisibleIndex = 1;
            this.colTen_Nhom_Hang.Width = 322;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.Caption = "Ghi chú";
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 2;
            this.colGhi_Chu.Width = 880;
            // 
            // frmNhomHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 675);
            this.Controls.Add(this.grcNhomHangHoa);
            this.Name = "frmNhomHangHoa";
            this.Text = "Nhóm hàng hóa";
            this.Load += new System.EventHandler(this.frmNhomHangHoa_Load);
            this.Controls.SetChildIndex(this.grcNhomHangHoa, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMNhomHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhomHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.CustomGridControl grcNhomHangHoa;
        private Lib.CustomGridView grvNhomHangHoa;
        private System.Windows.Forms.BindingSource cDMNhomHangHoaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAuto_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nhom_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nhom_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
    }
}