using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eLichHoc_LopHocPhan
    {
        public int ID_LichHoc_LopHP { get; set; }
        public string ID_LopHocPhan { get; set; }
        public string NgayHoc { get; set; }
        public string TietHoc { get; set; }
        public string ID_PhongHoc { get; set; }

        public eLopHocPhan LopHocPhan { get; set; }
        public ePhongHoc PhongHoc { get; set; }
    }
}
