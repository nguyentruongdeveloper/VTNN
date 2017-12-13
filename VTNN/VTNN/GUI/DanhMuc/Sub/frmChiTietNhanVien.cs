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
using BUS.DanhMuc;
using DTO.DanhMuc;
using VTNN.GUI.Common;
using VTNN.Extensions;

namespace VTNN.GUI.DanhMuc.Sub
{
    public partial class frmChiTietNhanVien : frmTemplate, ISubDanhMuc
    {
        CDM_Nhan_Vien_BUS _objNhanVienBUS = CDM_Nhan_Vien_BUS.getInstance();
        public CDM_Nhan_Vien _objNhanVien { get; set; }
        public delegate void LoadData();
        public LoadData ReLoadParent;
        public frmChiTietNhanVien()
        {
            InitializeComponent();
        }
        protected override void frmTemplate_Load(object sender, EventArgs e)
        {
            this.fType = Utility.FormType.Sub;
            base.frmTemplate_Load(sender, e);

        }
        private void frmChiTietNhanVien_Load(object sender, EventArgs e)
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
                this.Text = "Thêm mới thông tin nhân viên";
                _objNhanVien = new CDM_Nhan_Vien();
            }
            if (this.fStatus == Utility.FormStatus.Edit)
            {
                this.Text = "Sửa thông tin nhân viên";
            }
        }
        protected override void FormatControl(Control p_objControl)
        {
            base.FormatControl(p_objControl);
        }
        public void Load_Data_Form()
        {
            txt_MaNV.DataBindings.Add(new Binding("Text", _objNhanVien, "Ma_Nhan_Vien", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_TenNV.DataBindings.Add(new Binding("Text", _objNhanVien, "Ten_Nhan_Vien", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_DienThoai.DataBindings.Add(new Binding("Text", _objNhanVien, "Dien_Thoai", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_DiaChi.DataBindings.Add(new Binding("Text", _objNhanVien, "Ghi_Chu", false, DataSourceUpdateMode.OnPropertyChanged));

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
                    _objNhanVienBUS.Insert(_objNhanVien);
                }
                if (this.fStatus == Utility.FormStatus.Edit)
                {
                    _objNhanVienBUS.Updated(_objNhanVien);
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
            ReLoadParent();
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
            if (SaveData())
            {
                Reset_Value_Control();
            }
        }
    }
}