namespace VTNN.GUI.DanhMuc
{
    partial class frmNhaSanXuat
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
            this.grcNSX = new VTNN.Lib.CustomGridControl();
            this.cDMNhaSanXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvNSX = new VTNN.Lib.CustomGridView();
            this.colAuto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nha_San_Xuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nha_San_Xuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_Dien_Thoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcNSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMNhaSanXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNSX)).BeginInit();
            this.SuspendLayout();
            // 
            // grcNSX
            // 
            this.grcNSX.DataSource = this.cDMNhaSanXuatBindingSource;
            this.grcNSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNSX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grcNSX.Location = new System.Drawing.Point(0, 40);
            this.grcNSX.MainView = this.grvNSX;
            this.grcNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grcNSX.Name = "grcNSX";
            this.grcNSX.Size = new System.Drawing.Size(1353, 741);
            this.grcNSX.TabIndex = 4;
            this.grcNSX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNSX});
            // 
            // cDMNhaSanXuatBindingSource
            // 
            this.cDMNhaSanXuatBindingSource.DataSource = typeof(DTO.DanhMuc.CDM_Nha_San_Xuat);
            // 
            // grvNSX
            // 
            this.grvNSX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuto_ID,
            this.colMa_Nha_San_Xuat,
            this.colTen_Nha_San_Xuat,
            this.colSo_Dien_Thoai,
            this.colDia_Chi});
            this.grvNSX.GridControl = this.grcNSX;
            this.grvNSX.IndicatorWidth = 40;
            this.grvNSX.Name = "grvNSX";
            this.grvNSX.OptionsSelection.MultiSelect = true;
            this.grvNSX.OptionsView.AllowHtmlDrawHeaders = true;
            this.grvNSX.OptionsView.EnableAppearanceEvenRow = true;
            this.grvNSX.OptionsView.ShowAutoFilterRow = true;
            this.grvNSX.OptionsView.ShowGroupPanel = false;
            // 
            // colAuto_ID
            // 
            this.colAuto_ID.FieldName = "Auto_ID";
            this.colAuto_ID.Name = "colAuto_ID";
            // 
            // colMa_Nha_San_Xuat
            // 
            this.colMa_Nha_San_Xuat.Caption = "Mã nhà sản xuất";
            this.colMa_Nha_San_Xuat.FieldName = "Ma_Nha_San_Xuat";
            this.colMa_Nha_San_Xuat.MaxWidth = 150;
            this.colMa_Nha_San_Xuat.Name = "colMa_Nha_San_Xuat";
            this.colMa_Nha_San_Xuat.Visible = true;
            this.colMa_Nha_San_Xuat.VisibleIndex = 0;
            this.colMa_Nha_San_Xuat.Width = 150;
            // 
            // colTen_Nha_San_Xuat
            // 
            this.colTen_Nha_San_Xuat.Caption = "Tên nhà sản xuất";
            this.colTen_Nha_San_Xuat.FieldName = "Ten_Nha_San_Xuat";
            this.colTen_Nha_San_Xuat.Name = "colTen_Nha_San_Xuat";
            this.colTen_Nha_San_Xuat.Visible = true;
            this.colTen_Nha_San_Xuat.VisibleIndex = 1;
            this.colTen_Nha_San_Xuat.Width = 291;
            // 
            // colSo_Dien_Thoai
            // 
            this.colSo_Dien_Thoai.Caption = "Điện thoại";
            this.colSo_Dien_Thoai.FieldName = "So_Dien_Thoai";
            this.colSo_Dien_Thoai.MaxWidth = 150;
            this.colSo_Dien_Thoai.Name = "colSo_Dien_Thoai";
            this.colSo_Dien_Thoai.Visible = true;
            this.colSo_Dien_Thoai.VisibleIndex = 2;
            this.colSo_Dien_Thoai.Width = 150;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.Caption = "Địa chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 3;
            this.colDia_Chi.Width = 419;
            // 
            // frmNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 815);
            this.Controls.Add(this.grcNSX);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmNhaSanXuat";
            this.Text = "Nhà sản xuất";
            this.Load += new System.EventHandler(this.frmNhaSanXuat_Load);
            this.Controls.SetChildIndex(this.grcNSX, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grcNSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMNhaSanXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNSX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.CustomGridControl grcNSX;
        private Lib.CustomGridView grvNSX;
        private System.Windows.Forms.BindingSource cDMNhaSanXuatBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAuto_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nha_San_Xuat;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nha_San_Xuat;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Dien_Thoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
    }
}