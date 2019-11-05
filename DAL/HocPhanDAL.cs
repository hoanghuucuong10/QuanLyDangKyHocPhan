using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class HocPhanDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();
    
        public List<eHocPhan> GetALLHocPhan()
        {
            List<eHocPhan> lst = db.HocPhans.Select(x => new eHocPhan
            {
                ID_HocPhan = x.ID_HocPhan,
                TenMonHoc = x.TenMonHoc,
                SoTC = x.SoTC.Value
            }).ToList();

            return lst;
        }
        public List<eHocPhan> SearchHocPhan(string id, string name)
        {
            List<eHocPhan> lst = db.HocPhans.Where(s=>s.ID_HocPhan.Contains(id)&&s.TenMonHoc.ToUpper().Contains(name)).Select(x => new eHocPhan
            {
                ID_HocPhan = x.ID_HocPhan,
                TenMonHoc = x.TenMonHoc,
                SoTC = x.SoTC.Value
            }).ToList();

            return lst;
        }
        public eHocPhan GetHocPhanByID(string id)
        {

            eHocPhan ehp = db.HocPhans.Where(y => y.ID_HocPhan == id).Select(t => new eHocPhan {
                ID_HocPhan = t.ID_HocPhan,
                TenMonHoc = t.TenMonHoc,
                SoTC=t.SoTC.Value
            }).FirstOrDefault();
            return ehp;
        }
        public eHocPhan AddNewHocPhan(eHocPhan hp)
        {
            try
            {
                HocPhan x = new HocPhan();
                x.ID_HocPhan = hp.ID_HocPhan;
                x.TenMonHoc = hp.TenMonHoc;
                x.SoTC = hp.SoTC;
                db.HocPhans.Add(x);
                db.SaveChanges();
                return hp;
            }
            catch
            {
                return null;
            } 
        }
        public eHocPhan EditHocPhan(string id, eHocPhan hp)
        {
            try
            {
                HocPhan x = db.HocPhans.Where(m=>m.ID_HocPhan==id).FirstOrDefault();
                if(x==null)
                {
                    return null;
                }
                else
                {
                    x.TenMonHoc = hp.TenMonHoc;
                    x.SoTC = hp.SoTC;
                    db.SaveChanges();

                    return hp;
                } 
            }
            catch
            {
                return null;
            }
        }
        public string CreateID()
        {
            string id = db.HocPhans.Max(x => x.ID_HocPhan);
            string numStr = id.Substring(2);
            int num = int.Parse(numStr)+1;

            numStr = num.ToString();
            while(numStr.Count()!=8)
            {
                numStr = "0" + numStr;
            }
            numStr = "hp" + numStr;
            return numStr;
        }
    }
}
