using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class SinhVienDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();
        //Kiem tra dang nhap tai khoan sinh vien
        public eSinhVien CheckLogInSinhVien(string userName, string passWord)
        {

            SinhVien sv = db.SinhViens.Where(x => x.ID_SinhVien == userName).FirstOrDefault();
            //sai MSSV
            if (sv == null)
                return null;
            else
            {
                // sai MK
                if (sv.MatKhau.Trim() != passWord)
                    return null;
                else
                {
                    eSinhVien esv = new eSinhVien();
                    esv.ID_SinhVien = sv.ID_SinhVien;
                    esv.MatKhau = sv.MatKhau;
                    esv.HoVaTen = sv.HoVaTen;
                    esv.ID_LopNienChe = sv.ID_LopNienChe;
                    esv.SDT = sv.SDT;
                    esv.DiaChi = sv.DiaChi;
                    esv.Mail = sv.Mail;
                    esv.HinhAnh = sv.HinhAnh;

                    return esv;
                }
            }
        }
        public List<eSinhVien> GetAllSinhVien()
        {
            List<eSinhVien> lst = db.SinhViens.Select(x => new eSinhVien
            {
                HinhAnh = x.HinhAnh,
                ID_SinhVien = x.ID_SinhVien,
                HoVaTen = x.HoVaTen,
                SDT = x.SDT,
                MatKhau = x.MatKhau,
                ID_LopNienChe = x.ID_LopNienChe,
                DiaChi = x.DiaChi,
                Mail = x.Mail
            }).ToList();

            return lst;
        }
        public List<eSinhVien> SearchAllSinhVien(string id, string name)
        {
            List<eSinhVien> lst = db.SinhViens.Where(t=>t.ID_SinhVien.Contains(id)&& t.HoVaTen.Contains(name)).Select(x => new eSinhVien
            {
                HinhAnh = x.HinhAnh,
                ID_SinhVien = x.ID_SinhVien,
                HoVaTen = x.HoVaTen,
                SDT = x.SDT,
                MatKhau = x.MatKhau,
                ID_LopNienChe = x.ID_LopNienChe,
                DiaChi = x.DiaChi,
                Mail = x.Mail
            }).ToList();

            return lst;
        }

        public eSinhVien GetSinhVienByID(string id)
        {
            eSinhVien eSV = db.SinhViens.Where(t => t.ID_SinhVien == id).Select(x => new eSinhVien
            {
                HinhAnh = x.HinhAnh,
                ID_SinhVien = x.ID_SinhVien,
                HoVaTen = x.HoVaTen,
                SDT = x.SDT,
                MatKhau = x.MatKhau,
                ID_LopNienChe = x.ID_LopNienChe,
                DiaChi = x.DiaChi,
                Mail = x.Mail
            }).FirstOrDefault();

            return eSV;
        }

        public bool AddNewSinhVien(eSinhVien eSV)
        {
            try
            {
                SinhVien x = new SinhVien();
                x.HinhAnh=eSV.HinhAnh;
                x.ID_SinhVien = eSV.ID_SinhVien;
                x.HoVaTen = eSV.HoVaTen;
                x.SDT = eSV.SDT;
                x.MatKhau = eSV.MatKhau;
                x.ID_LopNienChe = eSV.ID_LopNienChe;
                x.DiaChi = eSV.DiaChi;
                x.Mail = eSV.Mail;
                db.SinhViens.Add(x);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditSinhVien(string id, eSinhVien eSV)
        {
            try
            {
                SinhVien x = db.SinhViens.Where(m => m.ID_SinhVien == id).FirstOrDefault();
                if (x == null)
                {
                    return false;
                }
                else
                {
                    x.HinhAnh = eSV.HinhAnh;
                    x.HinhAnh = eSV.HinhAnh;
                    x.ID_SinhVien = eSV.ID_SinhVien;
                    x.HoVaTen = eSV.HoVaTen;
                    x.SDT = eSV.SDT;
                    x.MatKhau = eSV.MatKhau;
                    x.ID_LopNienChe = eSV.ID_LopNienChe;
                    x.DiaChi = eSV.DiaChi;
                    x.Mail = eSV.Mail;
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
            string id = db.SinhViens.Max(x => x.ID_SinhVien);
            string numStr = id.Substring(2);
            int num = int.Parse(numStr) + 1;

            numStr = num.ToString();
            while (numStr.Count() != 8)
            {
                numStr = "0" + numStr;
            }
            numStr = "sv" + numStr;
            return numStr;
        }
    }
}

