using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eGiangVien
    {

        public string ID_GiangVien { get; set; }
        public string HoVaTen { get; set; }
        public string MatKhau { get; set; }
        public string TrinhDo { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Mail { get; set; }
        public byte[] HinhAnh { get; set; }

        public virtual List<eLopHocPhan> _LstLopHocPhans { get; set; }
        public virtual List<eLopNienChe> _LstLopNienChes { get; set; }
        public virtual List<eNhomThucHanh> _LstNhomThucHanhs { get; set; }
    }
}
