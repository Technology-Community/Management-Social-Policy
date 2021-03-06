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
    public partial class frmMucDichVay : Form
    {
        MucDichVayController MDVctrl = new MucDichVayController();
        public frmMucDichVay()
        {
            InitializeComponent();
        }

     
        private void frmMucDichVay_Load(object sender, EventArgs e)
        {
            MDVctrl.HienThiDataGridView(dataGridViewMDV, bindingNavigatorMDV);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorMDV.BindingSource.AddNew();
            MDVctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Muc Dich Vay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorMDV.BindingSource.RemoveCurrent();
                MDVctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            MDVctrl.Save();
            MDVctrl.HienThiDataGridView(dataGridViewMDV, bindingNavigatorMDV);
            bindingNavigatorMDV.BindingSource.MoveLast();
        }

        private void ToolTimMaMucDichVay_Click(object sender, EventArgs e)
        {
            ToolTimTenMucDichvay.Checked = false;
            ToolTimMaMucDichVay.Checked = true;
            if (Test())
                toolTimMucDichVay.Text = "Mã Mục Đích Vay";
            bindingNavigatorMDV.Focus();
        }

        private void ToolTimTenMucDichvay_Click(object sender, EventArgs e)
        {
            ToolTimTenMucDichvay.Checked = true;
            ToolTimMaMucDichVay.Checked = false;
            if (Test())
                toolTimMucDichVay.Text = "Tên Mục Đích Vay";
            bindingNavigatorMDV.Focus();
        }

        private void toolTimMucDichVay_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaMucDichVay.Checked == true)
                    toolTimMucDichVay.Text = "Mã Mục Đích Vay";
                else
                    toolTimMucDichVay.Text = "Tên Mục Đích Vay";
            }
        }

        private void toolTimMucDichVay_Enter(object sender, EventArgs e)
        {
            toolTimMucDichVay.Text = "";
            toolTimMucDichVay.ForeColor = Color.Black;
        }

        private void toolTimMucDichVay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaMucDichVay.Checked)
                    MDVctrl.TimMaMucDichVay(toolTimMucDichVay.Text);
                else
                    MDVctrl.TimTenMucDichVay(toolTimMucDichVay.Text);
            }
        }

     

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            MDVctrl.HienThiDataGridView(dataGridViewMDV, bindingNavigatorMDV);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Test()
        {
            String str = toolTimMucDichVay.Text;
            if (str == "Mã mục đích vay" || str == "Tên mục đích vay")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaMucDichVay.Checked)
                MDVctrl.TimMaMucDichVay(toolTimMucDichVay.Text);
            else
                MDVctrl.TimTenMucDichVay(toolTimMucDichVay.Text);
        }


    }
}