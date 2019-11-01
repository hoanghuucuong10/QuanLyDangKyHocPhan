using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eSinhVien
    {
        public string ID_SinhVien { get; set; }
        public string MatKhau { get; set; }
        public string HoVaTen { get; set; }
        public string ID_LopNienChe { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Mail { get; set; }
        public byte[] HinhAnh { get; set; }

        public virtual List<eDiem> _LstDiems { get; set; }
        public virtual eLopNienChe _LopNienChe { get; set; }


        public virtual List<eDangKyHocPhan> DangKyHocPhans { get; set; }


    }
}
