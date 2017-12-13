using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Test
    {
        public string MaBP { get; set; }
        public string TenBP { get; set; }
        public string  TenNV { get; set; }
        public decimal  Luong { get; set; }
    }
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }

    }
    public class BoPhan
    {
        public string MaBP { get; set; }
        public string TenBP { get; set; }
        public List<NhanVien> nhanviens { get; set; } = new List<NhanVien>();
    }

}
