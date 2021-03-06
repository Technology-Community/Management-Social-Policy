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
    public partial class frmDonViUyThac : Form
    {
        DonViUyThacController DVUTctrl = new DonViUyThacController();
        public frmDonViUyThac()
        {
            InitializeComponent();
        }

        private void frmDonViUyThac_Load(object sender, EventArgs e)
        {
            DVUTctrl.HienThiDataGridView(dataGridViewDVUT, bindingNavigatorDVUT);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorDVUT.BindingSource.AddNew();
            DVUTctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Don Vi Uy Thac", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorDVUT.BindingSource.RemoveCurrent();
                DVUTctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            DVUTctrl.Save();
            DVUTctrl.HienThiDataGridView(dataGridViewDVUT, bindingNavigatorDVUT);
            bindingNavigatorDVUT.BindingSource.MoveLast();
        }

        private void ToolTimMaDonViUyThac_Click(object sender, EventArgs e)
        {
            ToolTimTenDonViUyThac.Checked = false;
            ToolTimMaDonViUyThac.Checked = true;
            if (Test())
                toolTimDonViUyThac.Text = "Mã Đơn Vị Uỷ Thác";
            bindingNavigatorDVUT.Focus();
        }

        private void ToolTimTenDonViUyThac_Click(object sender, EventArgs e)
        {
            ToolTimTenDonViUyThac.Checked = true;
            ToolTimMaDonViUyThac.Checked = false;
            if (Test())
                toolTimDonViUyThac.Text = "Tên Đơn Vị Uỷ Thác";
            bindingNavigatorDVUT.Focus();
        }

        private void toolTimDonViUyThac_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaDonViUyThac.Checked == true)
                    toolTimDonViUyThac.Text = "Mã Đơn Vị Uỷ Thác";
                else
                    toolTimDonViUyThac.Text = "Tên Đơn Vị Uỷ Thác";
            }
        }

        private void toolTimDonViUyThac_Enter(object sender, EventArgs e)
        {
            toolTimDonViUyThac.Text = "";
            toolTimDonViUyThac.ForeColor = Color.Black;
        }

        private void toolTimDonViUyThac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaDonViUyThac.Checked)
                    DVUTctrl.TimMaDonViUyThac(toolTimDonViUyThac.Text);
                else
                    DVUTctrl.TimTenDonViUyThac(toolTimDonViUyThac.Text);
            }
        }

       
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DVUTctrl.HienThiDataGridView(dataGridViewDVUT, bindingNavigatorDVUT);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public bool Test()
        {
            String str = toolTimDonViUyThac.Text;
            if (str == "Mã đơn vị ủy thác" || str == "Tên đơn vị ủy thác")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaDonViUyThac.Checked)
                DVUTctrl.TimMaDonViUyThac(toolTimDonViUyThac.Text);
            else
                DVUTctrl.TimTenDonViUyThac(toolTimDonViUyThac.Text);
        }

    }
}