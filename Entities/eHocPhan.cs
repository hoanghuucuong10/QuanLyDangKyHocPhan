using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eHocPhan
    {
        public string ID_HocPhan { get; set; }
        public string TenMonHoc { get; set; }
        public Nullable<int> SoTC { get; set; }
        public virtual List<eLopHocPhan> _LstLopHocPhans { get; set; }

    }
}
