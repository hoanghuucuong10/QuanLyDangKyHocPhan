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
        public Nullable<int> ID_LichHoc { get; set; }

        public eLichHoc LichHoc { get; set; }
        public eNhomThucHanh NhomThucHanh { get; set; }
    }
}
