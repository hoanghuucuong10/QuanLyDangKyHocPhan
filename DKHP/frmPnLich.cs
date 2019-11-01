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
    public partial class frmPnLich : Form
    {
        public frmPnLich(string id, string tenMH, string tenGV, string tiet, string phong, string NgayBD,string NgayKT)
        {
            InitializeComponent();
            lbGV.Text = "GV: "+tenGV;
            lbID.Text = "Mã Lớp HP: " + id;
            lbTenMH.Text = "Môn: "+tenMH +" (LT)";
            lbTiet.Text = "Tiết: "+ tiet+" Phòng: "+phong;
            lbBD.Text = "Ngày Bắt Đầu: " + NgayBD;
            lbKT.Text = "Ngày Kết Thúc: " + NgayKT;
        }

        public frmPnLich(string id, string tenMH, string tenGV, string tiet, string phong, string tenNhom,string NgayBD, string NgayKT)
        {
            InitializeComponent();
            lbGV.Text = "GV: " + tenGV;
            lbID.Text = "Mã Lớp HP: "+id;
            lbTenMH.Text = "Môn: " + tenMH + " (TH Nhóm: "+tenNhom+")";
            lbTiet.Text = "Tiết: " + tiet + " Phòng: " + phong;
            lbBD.Text = "Ngày Bắt Đầu: " + NgayBD;
            lbKT.Text = "Ngày Kết Thúc: " + NgayKT;
        }

        private void frmPnLich_Load(object sender, EventArgs e)
        {

        }
    }
}
