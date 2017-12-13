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
using DTO.DanhMuc;
using BUS.DanhMuc;
using VTNN.Extensions;

namespace VTNN.GUI.DanhMuc.Sub
{
    public partial class frmChiTietNhomHangHoa : frmTemplate, ISubDanhMuc
    {


        CDM_Nhom_Hang_Hoa_BUS _objNhomHangHoaBUS = CDM_Nhom_Hang_Hoa_BUS.getInstance();
        public CDM_Nhom_Hang_Hoa _objNhomHangHoa { get; set; }
        public delegate void LoadData();
        public LoadData ReLoadParent;
        public frmChiTietNhomHangHoa()
        {
            InitializeComponent();
        }
        protected override void frmTemplate_Load(object sender, EventArgs e)
        {
            this.fType = Utility.FormType.Sub;
            base.frmTemplate_Load(sender, e);

        }
        private void frmChiTietNhomHangHoa_Load(object sender, EventArgs e)
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
                this.Text = "Thêm mới thông tin nhóm hàng hóa";
                _objNhomHangHoa = new CDM_Nhom_Hang_Hoa();
            }
            if (this.fStatus == Utility.FormStatus.Edit)
            {
                this.Text = "Sửa thông tin nhóm hàng hóa";
            }
        }
        protected override void FormatControl(Control p_objControl)
        {
            base.FormatControl(p_objControl);
        }
        public void Load_Data_Form()
        {
            txt_MaNhomHang.DataBindings.Add(new Binding("Text", _objNhomHangHoa, "Ma_Nhom_Hang", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_TenNhomHang.DataBindings.Add(new Binding("Text", _objNhomHangHoa, "Ten_Nhom_Hang", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_GhiChu.DataBindings.Add(new Binding("Text", _objNhomHangHoa, "Ghi_Chu", false, DataSourceUpdateMode.OnPropertyChanged));
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
                    _objNhomHangHoaBUS.Insert(_objNhomHangHoa);
                }
                if (this.fStatus == Utility.FormStatus.Edit)
                {
                    _objNhomHangHoaBUS.Updated(_objNhomHangHoa);
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
                CloseForm();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
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

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if(SaveData())
            {
                Reset_Value_Control();
            }
        }
    }
}