using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKHP.ViewModels
{
    public class NhomThucHanhViewModels
    {
        public string ID_NhomThucHanh { get; set; }
        public string ID_LopHocPhan { get; set; }
        public string ID_GiangVien { get; set; }
        public string TenGiangVien { get; set; }
        public string TenNhom { get; set; }
        public Nullable<int> SoTiet { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }

    }
}
