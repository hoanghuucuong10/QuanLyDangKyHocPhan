using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNhanVienPDT
    {
        public string ID_NhanVienPDT { get; set; }
        public string HoVaTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Mail { get; set; }
        public string MatKhau { get; set; }
        public byte[] HinhAnh { get; set; }

        public virtual List<eLopHocPhan> LopHocPhans { get; set; }

    }
}
