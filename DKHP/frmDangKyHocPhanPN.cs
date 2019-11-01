using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKHP
{
    public partial class frmDangKyHocPhanPN : Form
    {
        public eSinhVien eSV = new eSinhVien();
        LopHocPhanBLL LHP = new LopHocPhanBLL();

        public frmDangKyHocPhanPN(eSinhVien eSV)
        {
            InitializeComponent();
            LoadcbNamSearch();
            this.eSV = eSV;
        }
        public void LoadcbNamSearch()
        {
            int a = DateTime.Now.Year;
            int n = 0;
            List<string> lstItem = new List<string>();
            foreach (eLopHocPhan x in LHP.GetAllLopHocPhan())
            {
                n = 0;
                foreach (string t in lstItem)
                {
                    //if (x.ID_NienKhoa.NienKhoa1.Trim() == t.Trim())
                    //{
                    //    n = 1;
                    //}
                }
                if (n == 0)
                {
                    //lstItem.Add(x._NienKhoa.NienKhoa1.Trim());
                }
            }
            n = 0;
            foreach (string t in lstItem)
            {
                if ((a + "-" + (a + 1)) == t.Trim())
                {
                    n = 1;
                }
            }
            if (n == 0)
            {
                lstItem.Add(a + "-" + (a + 1));
            }
            n = 0;
            foreach (string t in lstItem)
            {
                if (((a + 1) + "-" + (a + 2)) == t.Trim())
                {
                    n = 1;
                }
            }
            if (n == 0)
            {
                lstItem.Add((a + 1) + "-" + (a + 2));
            }
            n = 0;
            foreach (string t in lstItem)
            {
                if (((a + 2) + "-" + (a + 3)) == t.Trim())
                {
                    n = 1;
                }
            }
            if (n == 0)
            {
                lstItem.Add((a + 2) + "-" + (a + 3));
            }

            cbNamHocSearch.DataSource = lstItem;
        }
  
    }
}
