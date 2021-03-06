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
    public partial class frmHinhThucVay : Form
    {
        HinhThucVayController HTVctrl = new HinhThucVayController();
        public frmHinhThucVay()
        {
            InitializeComponent();
        }

        private void frmHinhThucVay_Load(object sender, EventArgs e)
        {
            HTVctrl.HienThiDataGridView(dataGridViewHTV, bindingNavigatorHTV);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorHTV.BindingSource.AddNew();
            HTVctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Hinh Thuc Vay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorHTV.BindingSource.RemoveCurrent();
                HTVctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            HTVctrl.Save();
            HTVctrl.HienThiDataGridView(dataGridViewHTV, bindingNavigatorHTV);
            bindingNavigatorHTV.BindingSource.MoveLast();
        }

        private void ToolTimMaHinhThucVay_Click(object sender, EventArgs e)
        {
            ToolTimTenHinhThucVay.Checked = false;
            ToolTimMaHinhThucVay.Checked = true;
            if (Test())
                toolTimHinhThucVay.Text = "Mã Hình Thức Vay";
            bindingNavigatorHTV.Focus();
        }

        private void ToolTimTenHinhThucVay_Click(object sender, EventArgs e)
        {
            ToolTimTenHinhThucVay.Checked = true;
            ToolTimMaHinhThucVay.Checked = false;
            if (Test())
                toolTimHinhThucVay.Text = "Tên Hình Thức Vay";
            bindingNavigatorHTV.Focus();
        }

        private void toolTimHinhThucVay_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaHinhThucVay.Checked == true)
                    toolTimHinhThucVay.Text = "Mã Hình Thức Vay";
                else
                    toolTimHinhThucVay.Text = "Tên Hình Thức Vay";
            }
        }

        private void toolTimHinhThucVay_Enter(object sender, EventArgs e)
        {
            toolTimHinhThucVay.Text = "";
            toolTimHinhThucVay.ForeColor = Color.Black;
        }

        private void toolTimHinhThucVay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaHinhThucVay.Checked)
                    HTVctrl.TimMaHinhThucVay(toolTimHinhThucVay.Text);
                else
                    HTVctrl.TimTenHinhThucVay(toolTimHinhThucVay.Text);
            }
        }

       

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            HTVctrl.HienThiDataGridView(dataGridViewHTV, bindingNavigatorHTV);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimHinhThucVay.Text;
            if (str == "Mã hình thức vay" || str == "Tên hình thức vay")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaHinhThucVay.Checked)
                HTVctrl.TimMaHinhThucVay(toolTimHinhThucVay.Text);
            else
                HTVctrl.TimTenHinhThucVay(toolTimHinhThucVay.Text);
        }





    }
}