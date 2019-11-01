using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNienKhoa
    {
        public int ID_NienKhoa { get; set; }
        public string NienKhoa1 { get; set; }

        public virtual List<eLopHocPhan> _LopHocPhans { get; set; }
    }
}
