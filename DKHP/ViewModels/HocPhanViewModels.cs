using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKHP.ViewModels
{
    public class HocPhanViewModels
    {
        public string ID_HocPhan { get; set; }
        public string TenMonHoc { get; set; }
        public int SoTC { get; set; }

        public HocPhanViewModels(eHocPhan x)
        {
            this.ID_HocPhan = x.ID_HocPhan;
            this.SoTC = x.SoTC.Value;
            this.TenMonHoc = x.TenMonHoc;
        }
    }
}
