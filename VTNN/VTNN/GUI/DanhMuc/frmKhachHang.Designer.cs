namespace VTNN.GUI.DanhMuc
{
    partial class frmKhachHang
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
            this.grcKhachHang = new VTNN.Lib.CustomGridControl();
            this.cDMKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvKhachHang = new VTNN.Lib.CustomGridView();
            this.colAuto_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Khach_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Khach_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDien_Thoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_So_Thue = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // grcKhachHang
            // 
            this.grcKhachHang.DataSource = this.cDMKhachHangBindingSource;
            this.grcKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcKhachHang.Location = new System.Drawing.Point(0, 40);
            this.grcKhachHang.MainView = this.grvKhachHang;
            this.grcKhachHang.Name = "grcKhachHang";
            this.grcKhachHang.Size = new System.Drawing.Size(1329, 754);
            this.grcKhachHang.TabIndex = 4;
            this.grcKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKhachHang});
            // 
            // cDMKhachHangBindingSource
            // 
            this.cDMKhachHangBindingSource.DataSource = typeof(DTO.DanhMuc.CDM_Khach_Hang);
            // 
            // grvKhachHang
            // 
            this.grvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuto_ID,
            this.colMa_Khach_Hang,
            this.colTen_Khach_Hang,
            this.colDia_Chi,
            this.colDien_Thoai,
            this.colMa_So_Thue});
            this.grvKhachHang.GridControl = this.grcKhachHang;
            this.grvKhachHang.IndicatorWidth = 40;
            this.grvKhachHang.Name = "grvKhachHang";
            this.grvKhachHang.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.grvKhachHang.OptionsEditForm.EditFormColumnCount = 2;
            this.grvKhachHang.OptionsEditForm.PopupEditFormWidth = 600;
            this.grvKhachHang.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.grvKhachHang.OptionsNavigation.AutoFocusNewRow = true;
            this.grvKhachHang.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvKhachHang.OptionsSelection.MultiSelect = true;
            this.grvKhachHang.OptionsView.AllowHtmlDrawHeaders = true;
            this.grvKhachHang.OptionsView.EnableAppearanceEvenRow = true;
            this.grvKhachHang.OptionsView.ShowAutoFilterRow = true;
            this.grvKhachHang.OptionsView.ShowGroupPanel = false;
            this.grvKhachHang.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.CustomGridView1_EditFormShowing);
            this.grvKhachHang.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.CustomGridView1_RowUpdated);
            this.grvKhachHang.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.CustomGridView1_ValidatingEditor);
            this.grvKhachHang.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.CustomGridView1_InvalidValueException);
            // 
            // colAuto_ID
            // 
            this.colAuto_ID.FieldName = "Auto_ID";
            this.colAuto_ID.Name = "colAuto_ID";
            // 
            // colMa_Khach_Hang
            // 
            this.colMa_Khach_Hang.Caption = "Mã khách hàng";
            this.colMa_Khach_Hang.FieldName = "Ma_Khach_Hang";
            this.colMa_Khach_Hang.MaxWidth = 150;
            this.colMa_Khach_Hang.Name = "colMa_Khach_Hang";
            this.colMa_Khach_Hang.Visible = true;
            this.colMa_Khach_Hang.VisibleIndex = 0;
            // 
            // colTen_Khach_Hang
            // 
            this.colTen_Khach_Hang.Caption = "Tên khách hàng";
            this.colTen_Khach_Hang.FieldName = "Ten_Khach_Hang";
            this.colTen_Khach_Hang.Name = "colTen_Khach_Hang";
            this.colTen_Khach_Hang.OptionsEditForm.VisibleIndex = 1;
            this.colTen_Khach_Hang.Visible = true;
            this.colTen_Khach_Hang.VisibleIndex = 1;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.Caption = "Địa chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.OptionsEditForm.ColumnSpan = 2;
            this.colDia_Chi.OptionsEditForm.StartNewRow = true;
            this.colDia_Chi.OptionsEditForm.UseEditorColRowSpan = false;
            this.colDia_Chi.OptionsEditForm.VisibleIndex = 4;
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 4;
            // 
            // colDien_Thoai
            // 
            this.colDien_Thoai.Caption = "Điện thoại";
            this.colDien_Thoai.FieldName = "Dien_Thoai";
            this.colDien_Thoai.MaxWidth = 150;
            this.colDien_Thoai.Name = "colDien_Thoai";
            this.colDien_Thoai.OptionsEditForm.VisibleIndex = 3;
            this.colDien_Thoai.Visible = true;
            this.colDien_Thoai.VisibleIndex = 2;
            // 
            // colMa_So_Thue
            // 
            this.colMa_So_Thue.Caption = "Mã số thuế";
            this.colMa_So_Thue.FieldName = "Ma_So_Thue";
            this.colMa_So_Thue.MaxWidth = 150;
            this.colMa_So_Thue.Name = "colMa_So_Thue";
            this.colMa_So_Thue.OptionsEditForm.ColumnSpan = 2;
            this.colMa_So_Thue.OptionsEditForm.VisibleIndex = 2;
            this.colMa_So_Thue.Visible = true;
            this.colMa_So_Thue.VisibleIndex = 3;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 828);
            this.Controls.Add(this.grcKhachHang);
            this.Name = "frmKhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.Controls.SetChildIndex(this.grcKhachHang, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.CustomGridControl grcKhachHang;
        private Lib.CustomGridView grvKhachHang;
        private System.Windows.Forms.BindingSource cDMKhachHangBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAuto_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Khach_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Khach_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
        private DevExpress.XtraGrid.Columns.GridColumn colDien_Thoai;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_So_Thue;
    }
}