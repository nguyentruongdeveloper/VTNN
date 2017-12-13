using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public enum NhapXuat
    {
        Default = 0,
        ChungTuNhapHang = 1,
        ChungTuBanHang = 2,
        ChungTuNhapKho = 3,
        ChungTuXuatKho = 4,
        ChungTuHangBanTraLai = 5,
        ChungTuHangMuaTraLai = 6,
    }
    public enum FormType
    {
        Default = 0,
        List = 1,
        Sub = 2,


    }
    public enum FormStatus
    {
        Default = 0,
        Add = 1,
        Edit = 2,
        Deleted = 3,
    }
    public enum ReportType
    {
        Default = 0,
        Chung_Tu_Dich_Vu = 1,
        Bang_Ke_Chung_Tu_Dich_Vu = 2,
        Phieu_Thu = 3,
        Danh_Sach_Phieu_Thu = 4,
        Phieu_Chi = 5,
        Danh_Sach_Phieu_Chi = 6,
        Danh_Sach_Cong_No = 7,
        Doanh_Thu_Dich_Vu = 8,
        Doanh_Thu_Khach_Hang = 9,
        Doanh_Thu_Ngay = 10,
        Theo_Doi_Cong_No_Khach_Hang = 11,
        Tong_Hop_Cong_No_Khach_Hang = 12,
        Tong_Hop_Thu_Chi = 13,
    }

}
