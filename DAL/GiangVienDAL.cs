using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class GiangVienDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();



        //Kiem tra dang nhap tai khoan sinh vien
        public eGiangVien CheckLogInGiangVien(string userName, string passWord)
        {

            GiangVien gv = db.GiangViens.Where(x => x.ID_GiangVien == userName).FirstOrDefault();
            //sai MSSV
            if (gv == null)
                return null;
            else
            {
                // sai MK
                if (gv.MatKhau.Trim() != passWord)
                    return null;
                else
                {
                    eGiangVien egv = new eGiangVien();
                    egv.ID_GiangVien = gv.ID_GiangVien;
                    egv.HoVaTen = gv.HoVaTen;
                    egv.HinhAnh = gv.HinhAnh;
                    egv.MatKhau = gv.MatKhau;
                    egv.DiaChi = gv.DiaChi;
                    egv.Mail = gv.Mail;
                    egv.SDT = gv.SDT;
                    egv.TrinhDo = gv.TrinhDo;
                    return egv;
                }
            }
        }

        public List<eGiangVien> GetAllGiangVien()
        {
            List<eGiangVien> lst = db.GiangViens.Select(x => new eGiangVien
            {
                ID_GiangVien = x.ID_GiangVien,
                HoVaTen = x.HoVaTen,
                SDT = x.SDT,
                MatKhau = x.MatKhau,
                TrinhDo = x.TrinhDo,
                DiaChi = x.DiaChi,
                Mail = x.Mail,
                HinhAnh = x.HinhAnh
            }).ToList();

            return lst;
        }
        public List<eGiangVien> SearchAllGiangVien(string id, string name)
        {
            List<eGiangVien> lst = db.GiangViens.Where(t => t.ID_GiangVien.Contains(id) && t.HoVaTen.Contains(name)).Select(x => new eGiangVien
            {
                ID_GiangVien = x.ID_GiangVien,
                HoVaTen = x.HoVaTen,
                SDT = x.SDT,
                MatKhau = x.MatKhau,
                TrinhDo = x.TrinhDo,
                DiaChi = x.DiaChi,
                Mail = x.Mail,
                HinhAnh = x.HinhAnh
            }).ToList();

            return lst;
        }
        public eGiangVien GetGiangVienByID(string id)
        {
            eGiangVien eGV = db.GiangViens.Where(t => t.ID_GiangVien == id).Select(x => new eGiangVien
            {
                ID_GiangVien = x.ID_GiangVien,
                HoVaTen = x.HoVaTen,
                SDT = x.SDT,
                MatKhau = x.MatKhau,
                TrinhDo = x.TrinhDo,
                DiaChi = x.DiaChi,
                Mail = x.Mail,
                HinhAnh = x.HinhAnh
            }).FirstOrDefault();

            return eGV;
        }

        public bool AddNewGiangVien(eGiangVien eGV)
        {
            try
            {
                GiangVien x = new GiangVien();
                x.ID_GiangVien = eGV.ID_GiangVien;
                x.HoVaTen = eGV.HoVaTen;
                x.SDT = eGV.SDT;
                x.TrinhDo = eGV.TrinhDo;
                x.MatKhau = eGV.MatKhau;
                x.DiaChi = eGV.DiaChi;
                x.Mail = eGV.Mail;
                x.HinhAnh = eGV.HinhAnh;
                db.GiangViens.Add(x);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditGiangVien(string id, eGiangVien eGV)
        {
            try
            {
                GiangVien x = db.GiangViens.Where(m => m.ID_GiangVien == id).FirstOrDefault();
                if (x == null)
                {
                    return false;
                }
                else
                {
                    x.HoVaTen = eGV.HoVaTen;
                    x.SDT = eGV.SDT;
                    x.TrinhDo = eGV.TrinhDo;
                    x.MatKhau = eGV.MatKhau;
                    x.DiaChi = eGV.DiaChi;
                    x.Mail = eGV.Mail;
                    x.HinhAnh = eGV.HinhAnh;
                    db.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public string CreateID()
        {
            string id = db.GiangViens.Max(x => x.ID_GiangVien);
            string numStr = id.Substring(2);
            int num = int.Parse(numStr) + 1;

            numStr = num.ToString();
            while (numStr.Count() != 8)
            {
                numStr = "0" + numStr;
            }
            numStr = "gv" + numStr;
            return numStr;
        }

        public int CheckLichDay(GiangVien gv, int hocKy, string namHoc, string ngayHoc, string tietHoc)
        {
            //if (db.LopHocPhans.Where(x => x.ID_GiangVien == gv.ID_GiangVien && x.HocKy == hocKy && x.NamHoc == namHoc && x.NgayHoc == ngayHoc && x.TietHoc == tietHoc).FirstOrDefault() != null || db.NhomThucHanhs.Where(x => x.ID_GiangVien == gv.ID_GiangVien && x.LopHocPhan.HocKy == hocKy && x.LopHocPhan.NamHoc == namHoc && x.NgayHoc == ngayHoc && x.TietHoc == tietHoc).FirstOrDefault() != null)
            //{
            //    //Trùng lịch
            //    return 1;
            //}
            //else
                //ko trùng lịch
                return 0;
        }
    }
}
