using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
namespace BLL
{
    public class LichHocBLL
    {
        LichHocDAL lichHoc = new LichHocDAL();
        public List<eLichHoc_LopHocPhan> GetLichHoc_LopHocPhan(string id_LopHP)
        {
            return lichHoc.GetLichHoc_LopHocPhan(id_LopHP);
        }
        public List<eLichHoc_NhomThucHanh> GetLichHoc_NhomThucHanh(string id_NhomTH)
        {
            return lichHoc.GetLichHoc_NhomThucHanh(id_NhomTH);
        }
        public int AddLichLT(eLichHoc_LopHocPhan x)
        {
            return lichHoc.AddLichLT(x);
        }
        public int AddLichTH(eLichHoc_NhomThucHanh x)
        {
            return lichHoc.AddLichTH(x);
        }

        public bool CheckLichTrung(string idSV, string idLopHP, string idNhom, string hocKy, int id_NienKhoa)
        {
            return lichHoc.CheckLichTrung(idSV, idLopHP, idNhom,hocKy,id_NienKhoa);
        }
    }
}
