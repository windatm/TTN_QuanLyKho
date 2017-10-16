﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class frmHuongDan : Form
    {

        public frmHuongDan()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Name == "rGioiThieu")
            {
                txtHD.Text = @"Đây là phần mềm hỗ trợ cho việc quản lý kho, bao gồm các công việc nhập hành, xuất hàng, tìm kiếm và thống kê hàng hóa ở trong kho. Phần mềm sẽ giúp cho công việc quản lí kho của chúng ta đạt hiệu quả cao hơn.";
            }
            else if (treeView1.SelectedNode.Name == "rLienHe")
            {
                txtHD.Text = "Mọi thông tin hay thắc mắc về phần mềm liên hệ \r\nSĐT: 0987890957 \r\nEmail: dao1812@gmail.com";
            }
            else if (treeView1.SelectedNode.Name == "nTimKiem")
            {
                txtHD.Text = @"Để tìm kiếm nội dung nào đó, bạn nhập thông tin vào ô trống trong phần tìm kiếm sau đó click vào nội dung mình cần tìm kiếm";
            }
            else if (treeView1.SelectedNode.Name == "nThongKe")
            {
                txtHD.Text = @"Để thống kê , bạn nhập click vào ô ' Thống kê nhập' hoặc 'Thống kê xuất";
            }
        }


    }
}
