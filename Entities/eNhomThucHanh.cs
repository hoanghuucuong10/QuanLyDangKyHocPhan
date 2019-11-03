using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNhomThucHanh
    {
        public string ID_NhomThucHanh { get; set; }
        public string ID_LopHocPhan { get; set; }
        public string ID_GiangVien { get; set; }
        public string TenNhom { get; set; }
        public Nullable<int> SoTiet { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }

        public  List<eDangKyHocPhan> DangKyHocPhans { get; set; }
        public  List<eLichHoc_NhomThucHanh> LichHoc_NhomThucHanh { get; set; }

        public  eGiangVien _GiangVien { get; set; }
        public  eLopHocPhan _LopHocPhan { get; set; }
        public  List<eSinhVien> _LstSinhVien { get; set; }



    }
}
