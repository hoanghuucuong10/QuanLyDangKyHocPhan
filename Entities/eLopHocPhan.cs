using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eLopHocPhan
    {
        public string ID_LopHocPhan { get; set; }
        public string ID_HocPhan { get; set; }
        public string ID_NhanVienPDT { get; set; }
        public string ID_GiangVien { get; set; }
        public Nullable<int> ID_NienKhoa { get; set; }
        public Nullable<int> HocKy { get; set; }
        public string TrangThai { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> SoTiet { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }

        public virtual List<eDangKyHocPhan> DangKyHocPhans { get; set; }
        public virtual List<eDiem> Diems { get; set; }
        public virtual eGiangVien GiangVien { get; set; }
        public virtual eHocPhan HocPhan { get; set; }
        public virtual List<eLichHoc_LopHocPhan> LichHoc_LopHocPhan { get; set; }
        public virtual eNhanVienPDT NhanVienPDT { get; set; }
        public virtual eNienKhoa NienKhoa { get; set; }
        public virtual List<eNhomThucHanh> NhomThucHanhs { get; set; }


    }
}
