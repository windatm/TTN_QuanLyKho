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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        ConnectData conn = new ConnectData();
        public string constr = @"select * from tblHangHoa";

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }

        private void butTimMa_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("TimMaHH", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@MaHH", txtMaHH.Text);
            SqlDataAdapter da = new SqlDataAdapter(sqlcm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
            txtMaHH.Text = string.Empty;
            conn.DongKetNoi();
        }

    }
}
