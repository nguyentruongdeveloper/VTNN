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
    public partial class frmChitietKho : frmTemplate, ISubDanhMuc
    {
        CDM_Kho_BUS _objKhoBUS = CDM_Kho_BUS.getInstance();
        public CDM_Kho _objKho { get; set; }
        public delegate void LoadData();
        public LoadData ReLoadParent;
        public frmChitietKho()
        {
            InitializeComponent();
        }
      
        private void frmChitietKho_Load(object sender, EventArgs e)
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
                this.Text = "Thêm mới thông tin kho";
                _objKho = new CDM_Kho();
            }
            if (this.fStatus == Utility.FormStatus.Edit)
            {
                this.Text = "Sửa thông tin kho";
            }
        }
        public void Load_Data_Form()
        {
            txt_MaKho.DataBindings.Add(new Binding("Text", _objKho, "Ma_Kho", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_TenKho.DataBindings.Add(new Binding("Text", _objKho, "Ten_Kho", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_DienThoai.DataBindings.Add(new Binding("Text", _objKho, "Dien_Thoai", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_NguoiLienHe.DataBindings.Add(new Binding("Text", _objKho, "Nguoi_Lien_He", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_DiaChi.DataBindings.Add(new Binding("Text", _objKho, "Dia_Chi", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_GhiChu.DataBindings.Add(new Binding("Text", _objKho, "Ghi_Chu", false, DataSourceUpdateMode.OnPropertyChanged));
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
                    _objKhoBUS.Insert(_objKho);
                }
                if (this.fStatus == Utility.FormStatus.Edit)
                {
                    _objKhoBUS.Updated(_objKho);
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