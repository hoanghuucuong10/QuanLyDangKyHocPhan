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

        public int EditLichLT(eLichHoc_LopHocPhan x)
        {
            return lichHoc.EditLichLT(x);
        }
        public int EditLichTH(eLichHoc_NhomThucHanh x)
        {
            return lichHoc.EditLichTH(x);
        }

        public bool CheckLichTrung(string idSV, string idLopHP, string idNhom, string hocKy, int id_NienKhoa)
        {
            return lichHoc.CheckLichTrung(idSV, idLopHP, idNhom, hocKy, id_NienKhoa);
        }

        public int CreateIDThucHanh()
        {
            return lichHoc.CreateIDThucHanh();
        }
        public int CreateIDLyThuyet()
        {
            return lichHoc.CreateIDLyThuyet();
        }
        public List<eLichHoc_LopHocPhan> GetLichHocLyThuyet_GiangVien(string id_GV, int hocKy, int idNienKhoa)
        {

            return lichHoc.GetLichHocLyThuyet_GiangVien(id_GV, hocKy, idNienKhoa);
        }
        public List<eLichHoc_NhomThucHanh> GetLichHocThucHanh_GiangVien(string id_GV, int hocKy, int idNienKhoa)
        {

            return lichHoc.GetLichHocThucHanh_GiangVien(id_GV, hocKy, idNienKhoa);
        }

        public List<eLichHoc_LopHocPhan> GetLichHocLyThuyet_SinhVien(string id_SV, int hocKy, int idNienKhoa)
        {

            return lichHoc.GetLichHocLyThuyet_SinhVien(id_SV, hocKy, idNienKhoa);
        }
        public List<eLichHoc_NhomThucHanh> GetLichHocThucHanh_SinhVien(string id_SV, int hocKy, int idNienKhoa)
        {

            return lichHoc.GetLichHocThucHanh_SinhVien(id_SV, hocKy, idNienKhoa);
        }
    }
}
