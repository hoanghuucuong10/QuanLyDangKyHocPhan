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
        public Nullable<int> ID_LichHoc { get; set; }

        public eLichHoc LichHoc { get; set; }
        public eLopHocPhan LopHocPhan { get; set; }
    }
}
