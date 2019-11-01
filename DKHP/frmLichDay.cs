using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
using System.Globalization;

namespace DKHP
{
    public partial class frmLichDay : Form
    {
        public eGiangVien eGV = new eGiangVien();
        public frmLichDay(eGiangVien gV)
        {
            InitializeComponent();
            this.eGV = gV;
            int a = DateTime.Now.Year;
            int n = 0;
            List<string> lstItem = new List<string>();
            foreach (eLopHocPhan x in new LopHocPhanBLL().GetAllLopHocPhan())
            {
                n = 0;
                foreach (string t in lstItem)
                {
                   // if (x._NienKhoa.NienKhoa1.Trim() == t.Trim())
                    //{
                   ////     n = 1;
                   // }
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
        public void ClearPN()
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Controls.Clear();
            panel5.Controls.Clear();
            panel6.Controls.Clear();
            panel7.Controls.Clear();
            panel8.Controls.Clear();
            panel9.Controls.Clear();
            panel10.Controls.Clear();
            panel11.Controls.Clear();
            panel12.Controls.Clear();
            panel13.Controls.Clear();
            panel14.Controls.Clear();
            panel15.Controls.Clear();
            panel16.Controls.Clear();
            panel17.Controls.Clear();
            panel18.Controls.Clear();
            panel19.Controls.Clear();
            panel20.Controls.Clear();
            panel21.Controls.Clear();
            panel22.Controls.Clear();
            panel23.Controls.Clear();
            panel24.Controls.Clear();
            panel25.Controls.Clear();
            panel26.Controls.Clear();
            panel27.Controls.Clear();
            panel28.Controls.Clear();
            panel29.Controls.Clear();
            panel30.Controls.Clear();
            panel31.Controls.Clear();
            panel32.Controls.Clear();
            panel33.Controls.Clear();
            panel34.Controls.Clear();
            panel35.Controls.Clear();
        }
        public void AddPanelTH(eNhomThucHanh a)
        {
         
      
        }
        public void AddPanelLT(eLopHocPhan a)
        {
        }

        public void LoadLichDay(int hocKy,string namHoc)
        {
            ClearPN();
            List<eLopHocPhan> lstLHP = (new LopHocPhanBLL()).GetAllLopHocPhanGiangVien(eGV.ID_GiangVien,hocKy,namHoc);
            foreach (eLopHocPhan e in lstLHP)
            {
                AddPanelLT(e);
            }

            List<eNhomThucHanh> lstTH = (new NhomThucHanhBLL()).GetNhomByIDGiangVien(eGV.ID_GiangVien, hocKy, namHoc);
            foreach (eNhomThucHanh e in lstTH)
            {
                AddPanelTH(e);
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            int hocKy = int.Parse(cbHocKiSearch.SelectedItem.ToString().Trim());
            string namHoc = cbNamHocSearch.Text.Trim();
            LoadLichDay(hocKy, namHoc);
        }

    
    }
}
