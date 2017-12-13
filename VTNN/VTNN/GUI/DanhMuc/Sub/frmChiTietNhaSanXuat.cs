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
using BUS.DanhMuc;
using DTO.DanhMuc;
using VTNN.Extensions;

namespace VTNN.GUI.DanhMuc.Sub
{
    public partial class frmChiTietNhaSanXuat : frmTemplate, ISubDanhMuc
    {
        CDM_Nha_San_Xuat_BUS _objNhaSanXuatBUS = CDM_Nha_San_Xuat_BUS.getInstace();
        public CDM_Nha_San_Xuat _objNhaSanXuat { get; set; }
        public delegate void LoadData();
        public LoadData ReLoadParent;
        public frmChiTietNhaSanXuat()
        {
            InitializeComponent();
        }
        protected override void frmTemplate_Load(object sender, EventArgs e)
        {
            this.fType = Utility.FormType.Sub;
            base.frmTemplate_Load(sender, e);

        }
        private void frmChiTietNhaSanXuat_Load(object sender, EventArgs e)
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
                this.Text = "Thêm mới thông tin nhà sản xuất";
                _objNhaSanXuat = new CDM_Nha_San_Xuat();
            }
            if (this.fStatus == Utility.FormStatus.Edit)
            {
                this.Text = "Sửa thông tin nhà sản xuất";
            }
        }
        protected override void FormatControl(Control p_objControl)
        {
            base.FormatControl(p_objControl);
        }
        public void Load_Data_Form()
        {
            txt_MaNSX.DataBindings.Add(new Binding("Text", _objNhaSanXuat, "Ma_Nha_San_Xuat", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_TenNSX.DataBindings.Add(new Binding("Text", _objNhaSanXuat, "Ten_Nha_San_Xuat", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_DienThoai.DataBindings.Add(new Binding("Text", _objNhaSanXuat, "So_Dien_Thoai", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_DiaChi.DataBindings.Add(new Binding("Text", _objNhaSanXuat, "Dia_Chi", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_GhiChu.DataBindings.Add(new Binding("Text", _objNhaSanXuat, "Ghi_Chu", false, DataSourceUpdateMode.OnPropertyChanged));

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
                    _objNhaSanXuatBUS.Insert(_objNhaSanXuat);

                }
                if (this.fStatus == Utility.FormStatus.Edit)
                {
                    _objNhaSanXuatBUS.Updated(_objNhaSanXuat);
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
    }
}