using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eLichHoc_NhomThucHanh
    {
        public int ID_LichHoc_NhomTH { get; set; }
        public string ID_NhomThucHanh { get; set; }
        public string NgayHoc { get; set; }
        public string TietHoc { get; set; }
        public string ID_PhongHoc { get; set; }

        public eNhomThucHanh NhomThucHanh { get; set; }
        public ePhongHoc PhongHoc { get; set; }
    }
}
