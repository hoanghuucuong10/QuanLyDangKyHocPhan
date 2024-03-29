﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class DiemBLL
    {
        DiemDAL diemDal = new DiemDAL();
        public List<eDiem> GetDiemSV(string idSV)
        {
            return diemDal.GetDiemSV(idSV);
        }
        public List<eDiem> GetDiemLopHocPhan(string id_LopHP)
        {
            return diemDal.GetDiemLopHocPhan(id_LopHP);
        }
        public bool AddDiem(string idSV, string idLopHP)
        {
            return diemDal.AddDiem(idSV, idLopHP);
        }
        public bool DelDiem(string idSV, string idLopHP)
        {
            return diemDal.DelDiem(idSV, idLopHP);
        }
        public bool EditDiemSV(eDiem d)
        {
            return diemDal.EditDiemSV(d);
        }
        public bool EditDiemLopHP(eDiem d)
        {
            return diemDal.EditDiemLopHP(d);
        }
    }
}
