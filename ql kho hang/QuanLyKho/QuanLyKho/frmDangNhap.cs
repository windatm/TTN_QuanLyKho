using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        ConnectData conn = new ConnectData();
        public string str = @"select * from tblUser";

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHuongDan frmhd = new frmHuongDan();
            frmhd.ShowDialog();
        }

        private void butfrmNhap_Click(object sender, EventArgs e)
        {
            frmNhapHang frmmt = new frmNhapHang();
            frmmt.ShowDialog();
        }

        private void butfrmXuat_Click(object sender, EventArgs e)
        {
            frmXuatHang frmdg = new frmXuatHang();
            frmdg.ShowDialog();
        }

        private void butfrmTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frms = new frmTimKiem();
            frms.ShowDialog();
        }

    }
}
