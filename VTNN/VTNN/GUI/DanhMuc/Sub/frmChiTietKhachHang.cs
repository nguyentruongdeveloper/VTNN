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
using DTO;
using BUS.DanhMuc;
using DTO.DanhMuc;
using VTNN.Extensions;

namespace VTNN.GUI.DanhMuc.Sub
{
    public partial class frmChiTietKhachHang : frmTemplate, ISubDanhMuc
    {
        CDM_Khach_Hang_BUS _objKhachHangBUS = CDM_Khach_Hang_BUS.getInstance();
        public CDM_Khach_Hang _objKhachHang { get; set; }
        public delegate void LoadData();
        public LoadData ReLoadParent;
        public frmChiTietKhachHang()
        {
            InitializeComponent();
        }
        protected override void frmTemplate_Load(object sender, EventArgs e)
        {
            this.fType = Utility.FormType.Sub;
            base.frmTemplate_Load(sender, e);

        }
        private void frmChiTietKhachHang_Load(object sender, EventArgs e)
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
                this.Text = "Thêm mới khách hàng";
                _objKhachHang = new CDM_Khach_Hang();
            }
            if (this.fStatus == Utility.FormStatus.Edit)
            {
                this.Text = "Sửa khách hàng";
            }
        }
        protected override void FormatControl(Control p_objControl)
        {
            base.FormatControl(p_objControl);
        }
        public void Load_Data_Form()
        {
            txt_MaKhachHang.DataBindings.Add(new Binding("Text", _objKhachHang, "Ma_Khach_Hang", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_TenKhachHang.DataBindings.Add(new Binding("Text", _objKhachHang, "Ten_Khach_Hang", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_DienThoai.DataBindings.Add(new Binding("Text", _objKhachHang, "Dien_Thoai", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_MaSoThue.DataBindings.Add(new Binding("Text", _objKhachHang, "Ma_So_Thue", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_DiaChi.DataBindings.Add(new Binding("Text", _objKhachHang, "Dia_Chi", false, DataSourceUpdateMode.OnPropertyChanged));
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
                    _objKhachHangBUS.Insert(_objKhachHang);
                }
                if (this.fStatus == Utility.FormStatus.Edit)
                {
                    _objKhachHangBUS.Updated(_objKhachHang);
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
            if (SaveData())
            {
                Reset_Value_Control();
            }
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