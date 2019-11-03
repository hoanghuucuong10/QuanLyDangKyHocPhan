using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKHP.ViewModels
{
    public class LopHocPhanViewModels
    {
        public string ID_LopHocPhan { get; set; }
        public string ID_HocPhan { get; set; }
        public string TenMonHoc { get; set; }
        public string ID_NhanVienPDT { get; set; }
        public string ID_GiangVien { get; set; }
        public string TenGiangVien { get; set; }
        public Nullable<int> ID_NienKhoa { get; set; }
        public string NienKhoa { get; set; }
        public Nullable<int> HocKy { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string TrangThai { get; set; }
        public Nullable<int> SoTiet { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }

    }
}
