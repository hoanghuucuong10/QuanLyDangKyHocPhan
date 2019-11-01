using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eDiem
    {
        public string ID_SinhVien { get; set; }
        public string ID_LopHocPhan { get; set; }
        public Nullable<double> TK1 { get; set; }
        public Nullable<double> TK2 { get; set; }
        public Nullable<double> TK3 { get; set; }
        public Nullable<double> GK { get; set; }
        public Nullable<double> CK { get; set; }

        public virtual eLopHocPhan _LopHocPhan { get; set; }
        public virtual eSinhVien _SinhVien { get; set; }



    }
}
