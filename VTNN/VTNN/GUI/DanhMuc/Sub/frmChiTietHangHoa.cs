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
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Drawing;
using System.Data.SqlClient;
using VTNN.Extensions;

namespace VTNN.GUI.DanhMuc.Sub
{
    public partial class frmChiTietHangHoa : frmTemplate, ISubDanhMuc
    {
        CDM_Hang_Hoa_BUS _objHangHoaBUS = CDM_Hang_Hoa_BUS.getInstance();
        public CDM_Hang_Hoa _objHangHoa { get; set; }
        public BindingList<CDM_Don_Vi_Tinh_Chuyen_Doi> _bdDVTChuyenDoi { get; set; }
        public delegate void LoadData();
        public LoadData ReLoadParent;

        public frmChiTietHangHoa()
        {
            InitializeComponent();
            this.fStatus = Utility.FormStatus.Add;
        }

        private void frmChiTietHangHoa_Load(object sender, EventArgs e)
        {
            FormatControl();
            Load_Repository();
            InitForm();
            Load_Data_Form();

        }

        public void FormatControl()
        {
            FormatControl(this);
            grvDVTChuyenDoi.Format(true, false, true);
            

        }

        public void InitForm()
        {
            if (this.fStatus == Utility.FormStatus.Add)
            {
                this.Text = "Thêm mới thông tin hàng hóa";
                _objHangHoa = new CDM_Hang_Hoa();
                _bdDVTChuyenDoi = new BindingList<CDM_Don_Vi_Tinh_Chuyen_Doi>();
                _bdDVTChuyenDoi.AllowNew = true;
                _bdDVTChuyenDoi.AllowEdit = true;
                _bdDVTChuyenDoi.AllowRemove = true;


            }
            if (this.fStatus == Utility.FormStatus.Edit)
            {
                this.Text = "Sửa thông tin hàng hóa";
            }
        }

        public void Load_Data_Form()
        {
            txt_MaHang.DataBindings.Add(new Binding("Text", _objHangHoa, "Ma_Hang_Hoa", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_TenHang.DataBindings.Add(new Binding("Text", _objHangHoa, "Ten_Hang_Hoa", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_NguonGoc.DataBindings.Add(new Binding("Text", _objHangHoa, "Nguon_Goc", false, DataSourceUpdateMode.OnPropertyChanged));
            txt_MoTa.DataBindings.Add(new Binding("Text", _objHangHoa, "Mo_Ta", false, DataSourceUpdateMode.OnPropertyChanged));
            glk_NhomHang.DataBindings.Add(new Binding("EditValue", _objHangHoa, "Nhom_Hang_Hoa_ID", false, DataSourceUpdateMode.OnPropertyChanged));
            glk_NhaSanXuat.DataBindings.Add(new Binding("EditValue", _objHangHoa, "Nha_San_Xuat_ID", false, DataSourceUpdateMode.OnPropertyChanged));
            glk_DonViTinh.DataBindings.Add(new Binding("EditValue", _objHangHoa, "Don_Vi_Tinh_ID", false, DataSourceUpdateMode.OnPropertyChanged));
            sp_GiaBanLe.DataBindings.Add(new Binding("EditValue", _objHangHoa, "Gia_Ban_Le", false, DataSourceUpdateMode.OnPropertyChanged));
            sp_GiaBanSi.DataBindings.Add(new Binding("EditValue", _objHangHoa, "Gia_Ban_Si", false, DataSourceUpdateMode.OnPropertyChanged));
            sp_GiaBanDacBiet.DataBindings.Add(new Binding("EditValue", _objHangHoa, "Gia_Ban_Dac_Biet", false, DataSourceUpdateMode.OnPropertyChanged));
            grcDVTChuyenDoi.DataSource = _bdDVTChuyenDoi;


        }

        public void Load_Repository()
        {
            Load_Repository_Nhom_Hang(0);
            Load_Repository_Don_Vi_Tinh(0);
            Load_Repository_Nha_San_Xuat(0);
            Load_Repository_Phep_Tinh_Chuyen_Doi(0);
        }

        private void Load_Repository_Phep_Tinh_Chuyen_Doi(int v)
        {
            CDM_Phep_Tinh_Chuyen_Doi_BUS v_objPhepTinhChuyenDoiBUS = CDM_Phep_Tinh_Chuyen_Doi_BUS.getInstance();
            res_glk_PhepTinh.SetDataSource(v_objPhepTinhChuyenDoiBUS.Get_List_All().ToList<object>(), "Ten_Chuyen_Doi", "Auto_ID");
        }

        private void Load_Repository_Nha_San_Xuat(Int64 Auto_ID)
        {
            CDM_Nha_San_Xuat_BUS v_objNSXBUS = CDM_Nha_San_Xuat_BUS.getInstace();
            glk_NhaSanXuat.SetDataSource(v_objNSXBUS.Get_List_All().ToList<object>(), "Ten_Nha_San_Xuat", "Auto_ID");

        }

        private void Load_Repository_Don_Vi_Tinh(Int64 Auto_ID)
        {
            CDM_Don_Vi_Tinh_BUS v_objDVTBUS = CDM_Don_Vi_Tinh_BUS.getInstance();
            glk_DonViTinh.SetDataSource(v_objDVTBUS.Get_List_All().ToList<object>(), "Ten_Don_Vi_Tinh", "Auto_ID");
            res_glk_DonViTinh.SetDataSource(v_objDVTBUS.Get_List_All().ToList<object>(), "Ten_Don_Vi_Tinh", "Auto_ID");
        }

        private void Load_Repository_Nhom_Hang(Int64 Auto_ID)
        {
            CDM_Nhom_Hang_Hoa_BUS v_objNhomHangBUS = CDM_Nhom_Hang_Hoa_BUS.getInstance();
            glk_NhomHang.SetDataSource(v_objNhomHangBUS.Get_List_All().ToList<object>(), "Ten_Nhom_Hang", "Auto_ID");


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
                if (fStatus == Utility.FormStatus.Add)
                {
                    _objHangHoaBUS.FHH_0001_Insert(_objHangHoa, _bdDVTChuyenDoi.ToList());
                }
                if (fStatus == Utility.FormStatus.Edit)
                {
                    _objHangHoaBUS.FHH_0002_Updated(_objHangHoa, _bdDVTChuyenDoi.ToList());

                }

            }
            catch (Exception ex)
            {
                v_blResult = false;
                CExtensions.showErrorException(ex, "Error!");

            }

            return v_blResult;
        }

  

        public void Reset_Value_Control()
        {
            ResetControl(this);
            fStatus = Utility.FormStatus.Add;
        }

        public void CloseForm()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            ReLoadParent();
        }

        private void customGridLookUpEdit1View_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {

        }

        private void customGridLookUpEdit1View_MouseDown(object sender, MouseEventArgs e)
        {
            //GridView view = sender as GridView;
            //GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            //if (hitInfo.HitTest == GridHitTest.Column)
            //{
            //    GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;
            //    GridColumnInfoArgs columnInfo = viewInfo.ColumnsInfo[hitInfo.Column] as GridColumnInfoArgs;
            //    DrawElementInfo imageInfo = columnInfo.InnerElements.Find(typeof(DevExpress.Utils.Drawing.GlyphElementInfoArgs));
            //    if (imageInfo != null && imageInfo.ElementInfo.Bounds.Contains(e.Location))
            //        MessageBox.Show("Image");
            //}
            //if (hitInfo.HitTest == GridHitTest.GroupPanelColumn)
            //{
            //    GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;
            //    GroupPanelRow row = viewInfo.GroupPanel.Rows.RowByPoint(e.Location);
            //    if (row != null)
            //    {
            //        GridColumnInfoArgs columnInfo = row.ColumnByPoint(e.Location);
            //        DrawElementInfo imageInfo = columnInfo.InnerElements.Find(typeof(DevExpress.Utils.Drawing.GlyphElementInfoArgs));
            //        if (imageInfo != null && imageInfo.ElementInfo.Bounds.Contains(e.Location))
            //            MessageBox.Show("Image");
            //    }
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(SaveData())
            {
                CloseForm();
                ReLoadParent();
            }
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