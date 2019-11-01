using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ePhongHoc
    {
        public string ID_PhongHoc { get; set; }
        public string TenPhongHoc { get; set; }
        public virtual List<eLichHoc> LichHocs { get; set; }
    }
}
