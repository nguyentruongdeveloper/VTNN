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
    public partial class frmChiTietDonViTinh : frmTemplate, ISubDanhMuc
    {
        CDM_Don_Vi_Tinh_BUS _objDonViTinhBUS = CDM_Don_Vi_Tinh_BUS.getInstance();
        public CDM_Don_Vi_Tinh _objDonViTinh { get; set; }
        public delegate void LoadData();
        public LoadData ReLoadParent;


        public frmChiTietDonViTinh()
        {
            InitializeComponent();
        }

        private void frmChiTietDonViTinh_Load(object sender, EventArgs e)
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
        protected override void FormatControl(Control p_objControl)
        {
            base.FormatControl(p_objControl);
        }
        public void InitForm()
        {
            if (this.fStatus == Utility.FormStatus.Add)
            {
                this.Text = "Thêm mới đơn vị tính";
                _objDonViTinh = new CDM_Don_Vi_Tinh();
            }
            if (this.fStatus == Utility.FormStatus.Edit)
            {
                this.Text = "Sửa đơn vị tính";
            }
        }
        public void Load_Data_Form()
        {
            Get_Data_Entity();
        }
        private void Get_Data_Entity()
        {
            txt_MaDVT.DataBindings.Add(new Binding("Text", _objDonViTinh, "Ma_Don_Vi_Tinh", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_TenDVT.DataBindings.Add(new Binding("Text", _objDonViTinh, "Ten_Don_Vi_Tinh", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_GhiChu.DataBindings.Add(new Binding("Text", _objDonViTinh, "Ghi_Chu", false, DataSourceUpdateMode.OnPropertyChanged));
        }
        public void Load_Repository()
        {

        }
        public bool ValidateForm()
        {
            bool v_blResult = true;
            return v_blResult;

        }
        protected override void ResetControl(Control p_objControl)
        {
            base.ResetControl(p_objControl);
        }
        public bool SaveData()
        {
            bool v_blResult = true;
            if (this.fStatus == Utility.FormStatus.Add)
            {
                try
                {
                    _objDonViTinhBUS.Insert(_objDonViTinh);

                }
                catch (Exception ex)
                {
                    v_blResult = false;
                    CExtensions.showErrorException(ex, "Error!");

                }
            }
            if (this.fStatus == Utility.FormStatus.Edit)
            {
                try
                {

                    _objDonViTinhBUS.Updated(_objDonViTinh);

                }
                catch (Exception ex)
                {
                    v_blResult = false;
                    CExtensions.showErrorException(ex, "Error!");

                }
            }

            return v_blResult;

        }
        public void CloseForm()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            ReLoadParent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                ReLoadParent();
            }
            CloseForm();

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }


    }
}