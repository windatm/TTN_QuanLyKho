﻿using System;
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
    public partial class frmXuatHang : Form
    {
        public frmXuatHang()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string str = @"Data Source=HP-PC;Initial Catalog=Project_4;Integrated Security=True";
        public string constr = @"select * from tblHangHoa";

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dgv_Xuat, constr);
        }

        private void butXuat_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("XuatHang", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@MaHH", txtMaHH.Text.Trim());
            sqlcm.Parameters.AddWithValue("@TenHH", txtTenHH.Text.Trim());
            sqlcm.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text.Trim());
            sqlcm.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text.Trim());
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Xuất thành công");
                conn.KhoiTao(dgv_Xuat, @"select * from tblHangHoa");
                txtMaHH.Text = txtTenHH.Text = txtMaNCC.Text = txtSoLuong.Text = string.Empty;
            }
            else MessageBox.Show("Có lỗi, không còn hàng");
            conn.DongKetNoi();
        }

    }
}
