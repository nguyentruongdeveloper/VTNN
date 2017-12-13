namespace VTNN.GUI.DanhMuc
{
    partial class frmNoiDungThuChi
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
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // customGridControl1
            // 
            this.customGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGridControl1.Location = new System.Drawing.Point(0, 0);
            this.customGridControl1.MainView = null;
            this.customGridControl1.Name = "customGridControl1";
            this.customGridControl1.Size = new System.Drawing.Size(1062, 682);
            this.customGridControl1.TabIndex = 0;
            // 
            // frmNoiDungThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 682);
            this.Controls.Add(this.customGridControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmNoiDungThuChi";
            this.Text = "Nội dung thu chi";
            this.Load += new System.EventHandler(this.frmNoiDungThuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Lib.CustomGridControl customGridControl1;
    }
}