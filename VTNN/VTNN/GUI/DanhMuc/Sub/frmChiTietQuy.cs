using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VTNN.GUI.Common;
using VTNN.Extensions;
using BUS.DanhMuc;
using DTO.DanhMuc;

namespace VTNN.GUI.DanhMuc.Sub
{
    public partial class frmChiTietQuy : frmTemplate, ISubDanhMuc
    {
        public frmChiTietQuy()
        {
            InitializeComponent();
        }
        CDM_Quy_BUS _objQuyBUS = CDM_Quy_BUS.getInstance();
        public CDM_Quy _objQuy { get; set; }
        public delegate void LoadData();
        public LoadData ReLoadParent;
        protected override void frmTemplate_Load(object sender, EventArgs e)
        {
            this.fType = Utility.FormType.Sub;
            base.frmTemplate_Load(sender, e);

        }
        private void frmChiTietQuy_Load(object sender, EventArgs e)
        {
            FormatControl();
            Load_Repository();
            InitForm();
            Load_Data_Form();

        }
        public void FormatControl()
        {
            FormatControl(this);
        }
        public void InitForm()
        {
            if (this.fStatus == Utility.FormStatus.Add)
            {
                this.Text = "Thêm mới thông tin quỹ";
                _objQuy = new CDM_Quy();
            }
            if (this.fStatus == Utility.FormStatus.Edit)
            {
                this.Text = "Sửa thông tin quỹ";
            }
        }
        protected override void FormatControl(Control p_objControl)
        {
            base.FormatControl(p_objControl);
        }
        public void Load_Data_Form()
        {
            txt_MaQuy.DataBindings.Add(new Binding("Text", _objQuy, "Ma_Quy", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_TenQuy.DataBindings.Add(new Binding("Text", _objQuy, "Ten_Quy", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_SoTaiKhoan.DataBindings.Add(new Binding("Text", _objQuy, "So_Tai_Khoan", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_GhiChu.DataBindings.Add(new Binding("Text", _objQuy, "Ghi_Chu", false, DataSourceUpdateMode.OnPropertyChanged));
        }
        public void Load_Repository()
        {

        }
        public bool ValidateForm()
        {
            bool v_blResult = true;

            return v_blResult;

        }
        public bool SaveData()
        {
            bool v_blResult = true;
            try
            {
                if (this.fStatus == Utility.FormStatus.Add)
                {
                    _objQuyBUS.Insert(_objQuy);
                }
                if (this.fStatus == Utility.FormStatus.Edit)
                {
                    _objQuyBUS.Updated(_objQuy);
                }
            }
            catch (Exception ex)
            {
                v_blResult = false;
                CExtensions.showErrorException(ex, "Error!");
            }

            return v_blResult;

        }
        public void CloseForm()
        {
            this.DialogResult = DialogResult.OK;
            ReLoadParent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                ReLoadParent();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Reset_Value_Control();
            }
        }

        protected override void ResetControl(Control p_objControl)
        {
            base.ResetControl(p_objControl);
        }

        public void Reset_Value_Control()
        {
            ResetControl(this);
            this.fStatus = Utility.FormStatus.Add;
        }

        private void btnSaveAndNew_Click_1(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Reset_Value_Control();
            }
        }
    }
}