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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        ConnectData conn = new ConnectData();
        public string constr = @"select * from tblHangHoa";
        public string consql = @"Data Source=UBUNTU;Initial Catalog=Project_4;Integrated Security=True";

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dgv_Hanghoa, constr);
        }

        private void butIns_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("NhapMoi", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@MaHH", txtMaHH.Text.Trim());
            sqlcm.Parameters.AddWithValue("@TenHH", txtTenHH.Text.Trim());
            sqlcm.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text.Trim());
            sqlcm.Parameters.AddWithValue("@Soluong", txtSoLuong.Text.Trim());
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Nhập thành công");
                conn.KhoiTao(dgv_Hanghoa, @"select * from tblHangHoa");
                txtMaHH.Text = txtTenHH.Text = txtMaNCC.Text = txtSoLuong.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.DongKetNoi();
        }

     
    }
}
