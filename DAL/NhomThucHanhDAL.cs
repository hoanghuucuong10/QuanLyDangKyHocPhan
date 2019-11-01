﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class NhomThucHanhDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();

        public List<eNhomThucHanh> GetNhomByIDLopHocPhan(string id)
        {
            List<eNhomThucHanh> lst = db.NhomThucHanhs.Where(x => x.ID_LopHocPhan == id).Select(m => new eNhomThucHanh
            {
                //id_LopThucHanh = m.ID_NhomThucHanh,
                //id_LopHocPhan = m.ID_LopHocPhan,
                //tenMonHoc = m.LopHocPhan.HocPhan.TenMonHoc,
                //tenNhom = m.TenNhom.Value,
                //id_GiangVien = m.ID_GiangVien,
                //id_PhongHoc = m.ID_PhongHoc,
                //tenPhong = m.PhongHoc.TenPhongHoc,
                //tenGiangVien = m.GiangVien.HoVaTen,
                //tietHoc = m.TietHoc,
                //ngayHoc = m.NgayHoc,
                //NgayBD=m.NgayBatDau,
                //NgayKT=m.NgayKetThuc,
                //soLuong = db.DangKyHocPhans.Where(x => x.ID_NhomThucHanh == m.ID_NhomThucHanh).Count()
            }).ToList();
            return lst;
        }
        public List<eNhomThucHanh> GetNhomByIDGiangVien(string id, int hocKy, string namHoc)
        {
            List<eNhomThucHanh> lst = db.NhomThucHanhs.Where(x => x.ID_GiangVien == id && x.LopHocPhan.HocKy == hocKy && x.LopHocPhan.NienKhoa.NienKhoa1 == namHoc).Select(m => new eNhomThucHanh
            {
                //id_LopThucHanh = m.ID_NhomThucHanh,
                //id_LopHocPhan = m.ID_LopHocPhan,
                //tenMonHoc = m.LopHocPhan.HocPhan.TenMonHoc,
                //tenNhom = m.TenNhom.Value,
                //id_GiangVien = m.ID_GiangVien,
                //id_PhongHoc = m.ID_PhongHoc,
                //tenPhong = m.PhongHoc.TenPhongHoc,
                //tenGiangVien = m.GiangVien.HoVaTen,
                //tietHoc = m.TietHoc,
                //ngayHoc = m.NgayHoc,
                //NgayBD = m.NgayBatDau,
                //NgayKT = m.NgayKetThuc,
                //soLuong = db.DangKyHocPhans.Where(x => x.ID_NhomThucHanh == m.ID_NhomThucHanh).Count()
            }).ToList();
            return lst;
        }
        public eNhomThucHanh GetNhomByID(string id)
        {
            eNhomThucHanh lst = db.NhomThucHanhs.Where(x => x.ID_NhomThucHanh == id).Select(m => new eNhomThucHanh
            {
                //id_LopThucHanh = m.ID_NhomThucHanh,
                //id_LopHocPhan = m.ID_LopHocPhan,
                //tenMonHoc = m.LopHocPhan.HocPhan.TenMonHoc,
                //tenNhom = m.TenNhom.Value,
                //id_GiangVien = m.ID_GiangVien,
                //id_PhongHoc = m.ID_PhongHoc,
                //tenPhong = m.PhongHoc.TenPhongHoc,
                //tenGiangVien = m.GiangVien.HoVaTen,
                //tietHoc = m.TietHoc,
                //ngayHoc = m.NgayHoc,
                //NgayBD=m.NgayBatDau,
                //NgayKT=m.NgayKetThuc,
                //soLuong = db.DangKyHocPhans.Where(x => x.ID_NhomThucHanh == m.ID_NhomThucHanh).Count()
            }).FirstOrDefault();
            return lst;
        }
        public int EditNhomThucHanh(eNhomThucHanh a)
        {
            NhomThucHanh n = db.NhomThucHanhs.Where(t => t.ID_NhomThucHanh == a.ID_NhomThucHanh).FirstOrDefault();
            if (n != null)
            {
                n.ID_NhomThucHanh = a.ID_NhomThucHanh;
                n.ID_LopHocPhan = a.ID_LopHocPhan;
                n.ID_GiangVien = a.ID_GiangVien;
                n.TenNhom = a.TenNhom;
                //n.LichHoc_NhomThucHanh.l = a.ngayHoc;
                n.SoTiet = a.SoTiet;
                n.NgayBatDau = a.NgayBatDau;
                n.NgayKetThuc = a.NgayKetThuc;

                db.NhomThucHanhs.Add(n);
            }
            else
                return 0;

            db.SaveChanges();
            return 1;
        }
        public int AddNewNhomThucHanh(eNhomThucHanh a)
        {
            try
            {
                NhomThucHanh n = new NhomThucHanh();
                n.ID_NhomThucHanh = a.ID_NhomThucHanh;
                n.ID_LopHocPhan = a.ID_LopHocPhan;
                n.ID_GiangVien = a.ID_GiangVien;
             
                n.TenNhom = a.TenNhom;
                //n.LichHoc_NhomThucHanh.l = a.ngayHoc;
                n.SoTiet = a.SoTiet;
                n.NgayBatDau = a.NgayBatDau;
                n.NgayKetThuc = a.NgayKetThuc;

                db.NhomThucHanhs.Add(n);
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int DelNhomTH(string id)
        {
            try
            {
                db.NhomThucHanhs.Remove(db.NhomThucHanhs.Where(x => x.ID_NhomThucHanh == id).FirstOrDefault());
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public string CreateID()
        {
            string id = db.NhomThucHanhs.Max(x => x.ID_NhomThucHanh);
            string numStr = id.Substring(2);
            int num = int.Parse(numStr) + 1;

            numStr = num.ToString();
            while (numStr.Count() != 8)
            {
                numStr = "0" + numStr;
            }
            numStr = "th" + numStr;
            return numStr;
        }
    }
}