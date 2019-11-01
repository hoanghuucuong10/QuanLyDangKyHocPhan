using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eLopNienChe
    {
        public string ID_LopNienChe { get; set; }
        public string TenLop { get; set; }
        public string ChuyenNganh { get; set; }
        public string KhoaHoc { get; set; }
        public string ID_GiangVien { get; set; }

        public eGiangVien GiangVien { get; set; }
        public List<eSinhVien> SinhViens { get; set; }
    }
}
