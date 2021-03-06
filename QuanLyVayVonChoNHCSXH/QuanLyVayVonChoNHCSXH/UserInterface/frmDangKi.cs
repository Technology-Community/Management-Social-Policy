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
    public partial class frmDangKi : Form
    {
        DangKyController DKctrl = new DangKyController();
        NhanVienController NVctrl = new NhanVienController();
        QuyenController Qctrl = new QuyenController();
        public frmDangKi()
        {
            InitializeComponent();
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {
            NVctrl.HienThiCombobox(cmbMaNhanVien);
            Qctrl.HienThiCombobox(cmbMaQuyen);
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            if (IsTrue())
                if (DKctrl.Save(Convert.ToString(txtUsername.Text), Convert.ToString(txtPassword.Text), Convert.ToString(cmbMaQuyen.SelectedValue), Convert.ToString(cmbMaNhanVien.SelectedValue)))
                {
                    MessageBox.Show("Đăng ký thành công.", "Dang ky", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Đăng ký không thành công.", "Dang ky", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool IsTrue()
        {
            if (Convert.ToString(txtUsername.Text) == "")
            {
                MessageBox.Show("Chưa nhập username !", "Dang ky", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            else
                if (Convert.ToString(txtPassword.Text) == "")
                {
                    MessageBox.Show("Chưa nhập password !", "Dang ky", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return false;
                }
            return true;
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}