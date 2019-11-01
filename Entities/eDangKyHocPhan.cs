using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eDangKyHocPhan
    {
        public string ID_SinhVien { get; set; }
        public string ID_LopHocPhan { get; set; }
        public string ID_NhomThucHanh { get; set; }

        public eLopHocPhan LopHocPhan { get; set; }
        public eNhomThucHanh NhomThucHanh { get; set; }
        public eSinhVien SinhVien { get; set; }
    }
}
