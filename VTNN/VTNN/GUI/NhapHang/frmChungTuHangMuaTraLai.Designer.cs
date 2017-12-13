namespace VTNN.GUI.NhapHang
{
    partial class frmChungTuHangMuaTraLai
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
            this.customGridControl1 = new VTNN.Lib.CustomGridControl();
            this.customGridView1 = new VTNN.Lib.CustomGridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lok_Ky.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lok_TrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDen_Ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDen_Ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.customGridControl1);
            this.layoutControl1.Location = new System.Drawing.Point(0, 40);
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(0, 240, 562, 500);
            this.layoutControl1.Size = new System.Drawing.Size(1183, 731);
            this.layoutControl1.Controls.SetChildIndex(this.simpleButton1, 0);
            this.layoutControl1.Controls.SetChildIndex(this.lok_Ky, 0);
            this.layoutControl1.Controls.SetChildIndex(this.dteTuNgay, 0);
            this.layoutControl1.Controls.SetChildIndex(this.dteDen_Ngay, 0);
            this.layoutControl1.Controls.SetChildIndex(this.lok_TrangThai, 0);
            this.layoutControl1.Controls.SetChildIndex(this.customGridControl1, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1183, 731);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Size = new System.Drawing.Size(44, 34);
            // 
            // lok_Ky
            // 
            // 
            // lok_TrangThai
            // 
            // 
            // dteDen_Ngay
            // 
            this.dteDen_Ngay.EditValue = null;
            this.dteDen_Ngay.Properties.Mask.EditMask = "99/99/0000";
            this.dteDen_Ngay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.dteDen_Ngay.Properties.Mask.UseMaskAsDisplayFormat = true;
            // 
            // dteTuNgay
            // 
            this.dteTuNgay.EditValue = null;
            this.dteTuNgay.Properties.Mask.EditMask = "99/99/0000";
            this.dteTuNgay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.dteTuNgay.Properties.Mask.UseMaskAsDisplayFormat = true;
            // 
            // customGridControl1
            // 
            this.customGridControl1.IsReset = true;
            this.customGridControl1.Location = new System.Drawing.Point(16, 50);
            this.customGridControl1.MainView = this.customGridView1;
            this.customGridControl1.Name = "customGridControl1";
            this.customGridControl1.Size = new System.Drawing.Size(1151, 651);
            this.customGridControl1.TabIndex = 13;
            this.customGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customGridView1});
            // 
            // customGridView1
            // 
            this.customGridView1.GridControl = this.customGridControl1;
            this.customGridView1.IndicatorWidth = 40;
            this.customGridView1.IsReset = true;
            this.customGridView1.Name = "customGridView1";
            this.customGridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.customGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.customGridView1.OptionsView.ShowAutoFilterRow = true;
            this.customGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.customGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1157, 657);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmChungTuHangMuaTraLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 805);
            this.Name = "frmChungTuHangMuaTraLai";
            this.Text = "Chứng từ bán hàng";
            this.Load += new System.EventHandler(this.frmChungTuBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lok_Ky.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lok_TrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDen_Ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDen_Ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.CustomGridControl customGridControl1;
        private Lib.CustomGridView customGridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}