namespace VTNN.GUI.DanhMuc
{
    partial class frmQuy
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
            this.grcQuy = new VTNN.Lib.CustomGridControl();
            this.grvQuy = new VTNN.Lib.CustomGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grcQuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuy)).BeginInit();
            this.SuspendLayout();
            // 
            // grcQuy
            // 
            this.grcQuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcQuy.Location = new System.Drawing.Point(0, 40);
            this.grcQuy.MainView = this.grvQuy;
            this.grcQuy.Name = "grcQuy";
            this.grcQuy.Size = new System.Drawing.Size(1128, 515);
            this.grcQuy.TabIndex = 4;
            this.grcQuy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvQuy});
            // 
            // grvQuy
            // 
            this.grvQuy.GridControl = this.grcQuy;
            this.grvQuy.IndicatorWidth = 40;
            this.grvQuy.Name = "grvQuy";
            this.grvQuy.OptionsSelection.MultiSelect = true;
            this.grvQuy.OptionsView.AllowHtmlDrawHeaders = true;
            this.grvQuy.OptionsView.EnableAppearanceEvenRow = true;
            this.grvQuy.OptionsView.ShowAutoFilterRow = true;
            this.grvQuy.OptionsView.ShowGroupPanel = false;
            // 
            // frmQuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 589);
            this.Controls.Add(this.grcQuy);
            this.Name = "frmQuy";
            this.Text = "Quỹ";
            this.Load += new System.EventHandler(this.frmQuy_Load);
            this.Controls.SetChildIndex(this.grcQuy, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grcQuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.CustomGridControl grcQuy;
        private Lib.CustomGridView grvQuy;
    }
}