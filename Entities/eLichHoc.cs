using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eLichHoc
    {
        public int ID_LichHoc { get; set; }
        public string NgayHoc { get; set; }
        public string TietHoc { get; set; }
        public string ID_PhongHoc { get; set; }

        public virtual List<eLichHoc_LopHocPhan> LichHoc_LopHocPhan { get; set; }
        public virtual List<eLichHoc_NhomThucHanh> LichHoc_NhomThucHanh { get; set; }

        public virtual ePhongHoc _PhongHoc { get; set; }


    }
}
