using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.Controller;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.UserInterface
{
    public partial class frmDSTaiKhoan : Form
    {
        public frmDSTaiKhoan()
        {
            InitializeComponent();
        }

        TaiKhoanController DSTKctrl = new TaiKhoanController();

        private void frmDSTaiKhoan_Load(object sender, EventArgs e)
        {
            DSTKctrl.HienThiDataGridViewDSTK(dataGridView, bindingNavigator);
        }


        private void toolThem_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigator.BindingSource.AddNew();
            DSTKctrl.Save();
        }

        private void toolLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            DSTKctrl.Save();
            DSTKctrl.HienThiDataGridViewDSTK(dataGridView, bindingNavigator);
            bindingNavigator.BindingSource.MoveLast();
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Danh sách tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator.BindingSource.RemoveCurrent();
                DSTKctrl.Save();
            }
        }

        private void tooltimtheomataikhoan_Click(object sender, EventArgs e)
        {
            tooltimtheotentaikhoan.Checked = false;
            tooltimtheomataikhoan.Checked = true;            
            if (Test())
                ToolTimDSTaiKhoan.Text = "Mã tài khoản";
            bindingNavigator.Focus();
        }

        private void tooltimtheotentaikhoan_Click(object sender, EventArgs e)
        {
            tooltimtheotentaikhoan.Checked = true;
            tooltimtheomataikhoan.Checked = false;
            if (Test())
                ToolTimDSTaiKhoan.Text = "Tên tài khoản";
            bindingNavigator.Focus();
        }

        private void toolthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = ToolTimDSTaiKhoan.Text;
            if (str == "Mã tài khoản" || str == "Tên tài khoản")
                return true;
            return false;
        }

        private void ToolTimDSTaiKhoan_Enter(object sender, EventArgs e)
        {
            ToolTimDSTaiKhoan.Text = "";
            ToolTimDSTaiKhoan.ForeColor = Color.Black;
        }

        private void ToolTimDSTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tooltimtheomataikhoan.Checked)
                    DSTKctrl.TimMaTaiKhoan(ToolTimDSTaiKhoan.Text);               
                else
                    DSTKctrl.TimTenTaiKhoan(ToolTimDSTaiKhoan.Text);
            }
        }

        private void ToolTimDSTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (tooltimtheomataikhoan.Checked == true)
                    ToolTimDSTaiKhoan.Text = "Mã tài khoản";                
                else
                    ToolTimDSTaiKhoan.Text = "Tên tài khoản";
            }
        }

        private void ToolTimDSTaiKhoan_Click(object sender, EventArgs e)
        {
            if (tooltimtheomataikhoan.Checked)
                DSTKctrl.TimMaTaiKhoan(ToolTimDSTaiKhoan.Text);            
            else
                DSTKctrl.TimTenTaiKhoan(ToolTimDSTaiKhoan.Text);
        }
            

    }
}