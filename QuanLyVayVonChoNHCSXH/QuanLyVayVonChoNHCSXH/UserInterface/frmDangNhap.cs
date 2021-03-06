using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.Controller;


namespace QuanLyVayVonChoNHCSXH.UserInterface
{
    public partial class frmDangNhap : Form
    {
        DangNhapController DNctrl = new DangNhapController();
        QuyenController Qctrl = new QuyenController();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Qctrl.HienThiCombobox(cmbMaQuyen);
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (DNctrl.TestDuLieu(Convert.ToString(txtUsername.Text), Convert.ToString(txtPassword.Text)))
                MessageBox.Show("Đăng nhập thành công!");
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
                txtUsername.Focus();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}