namespace VTNN.GUI.DanhMuc
{
    partial class frmNhaCungCap
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
            this.grcNhaCungCap = new VTNN.Lib.CustomGridControl();
            this.cDMNhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvNhaCungCap = new VTNN.Lib.CustomGridView();
            this.colAuto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nha_Cung_Cao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nha_Cung_Cap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDien_Thoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDMNhaCungCapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMNhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMNhaCungCapBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grcNhaCungCap
            // 
            this.grcNhaCungCap.DataSource = this.cDMNhaCungCapBindingSource1;
            this.grcNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNhaCungCap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grcNhaCungCap.Location = new System.Drawing.Point(0, 40);
            this.grcNhaCungCap.MainView = this.grvNhaCungCap;
            this.grcNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grcNhaCungCap.Name = "grcNhaCungCap";
            this.grcNhaCungCap.Size = new System.Drawing.Size(1553, 725);
            this.grcNhaCungCap.TabIndex = 4;
            this.grcNhaCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNhaCungCap});
            // 
            // cDMNhaCungCapBindingSource
            // 
            this.cDMNhaCungCapBindingSource.DataSource = typeof(DTO.DanhMuc.CDM_Nha_Cung_Cap);
            // 
            // grvNhaCungCap
            // 
            this.grvNhaCungCap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuto_ID,
            this.colMa_Nha_Cung_Cao,
            this.colTen_Nha_Cung_Cap,
            this.colDia_Chi,
            this.colDien_Thoai,
            this.colMST});
            this.grvNhaCungCap.GridControl = this.grcNhaCungCap;
            this.grvNhaCungCap.IndicatorWidth = 40;
            this.grvNhaCungCap.Name = "grvNhaCungCap";
            this.grvNhaCungCap.OptionsSelection.MultiSelect = true;
            this.grvNhaCungCap.OptionsView.AllowHtmlDrawHeaders = true;
            this.grvNhaCungCap.OptionsView.EnableAppearanceEvenRow = true;
            this.grvNhaCungCap.OptionsView.ShowAutoFilterRow = true;
            this.grvNhaCungCap.OptionsView.ShowGroupPanel = false;
            // 
            // colAuto_ID
            // 
            this.colAuto_ID.FieldName = "Auto_ID";
            this.colAuto_ID.Name = "colAuto_ID";
            // 
            // colMa_Nha_Cung_Cao
            // 
            this.colMa_Nha_Cung_Cao.Caption = "Mã NCC";
            this.colMa_Nha_Cung_Cao.FieldName = "Ma_Nha_Cung_Cap";
            this.colMa_Nha_Cung_Cao.MaxWidth = 150;
            this.colMa_Nha_Cung_Cao.Name = "colMa_Nha_Cung_Cao";
            this.colMa_Nha_Cung_Cao.Visible = true;
            this.colMa_Nha_Cung_Cao.VisibleIndex = 0;
            // 
            // colTen_Nha_Cung_Cap
            // 
            this.colTen_Nha_Cung_Cap.Caption = "Tên NCC";
            this.colTen_Nha_Cung_Cap.FieldName = "Ten_Nha_Cung_Cap";
            this.colTen_Nha_Cung_Cap.Name = "colTen_Nha_Cung_Cap";
            this.colTen_Nha_Cung_Cap.Visible = true;
            this.colTen_Nha_Cung_Cap.VisibleIndex = 1;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.Caption = "Địa chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 4;
            // 
            // colDien_Thoai
            // 
            this.colDien_Thoai.Caption = "Điện thoại";
            this.colDien_Thoai.FieldName = "Dien_Thoai";
            this.colDien_Thoai.MaxWidth = 150;
            this.colDien_Thoai.Name = "colDien_Thoai";
            this.colDien_Thoai.Visible = true;
            this.colDien_Thoai.VisibleIndex = 2;
            // 
            // colMST
            // 
            this.colMST.Caption = "Mã số thuế";
            this.colMST.FieldName = "Ma_So_Thue";
            this.colMST.MaxWidth = 150;
            this.colMST.Name = "colMST";
            this.colMST.Visible = true;
            this.colMST.VisibleIndex = 3;
            // 
            // cDMNhaCungCapBindingSource1
            // 
            this.cDMNhaCungCapBindingSource1.DataSource = typeof(DTO.DanhMuc.CDM_Nha_Cung_Cap);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 799);
            this.Controls.Add(this.grcNhaCungCap);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhaCungCap";
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            this.Controls.SetChildIndex(this.grcNhaCungCap, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMNhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMNhaCungCapBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.CustomGridControl grcNhaCungCap;
        private Lib.CustomGridView grvNhaCungCap;
        private System.Windows.Forms.BindingSource cDMNhaCungCapBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAuto_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nha_Cung_Cao;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nha_Cung_Cap;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
        private DevExpress.XtraGrid.Columns.GridColumn colDien_Thoai;
        private DevExpress.XtraGrid.Columns.GridColumn colMST;
        private System.Windows.Forms.BindingSource cDMNhaCungCapBindingSource1;
    }
}