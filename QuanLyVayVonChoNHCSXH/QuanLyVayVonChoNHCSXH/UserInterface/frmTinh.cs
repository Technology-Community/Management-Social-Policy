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
    public partial class frmTinh : Form
    {
        TinhController Tctrl = new TinhController();
        public frmTinh()
        {
            InitializeComponent();
        }

        private void frmTinh_Load(object sender, EventArgs e)
        {
            Tctrl.HienThiDataGridView(dataGridViewT, bindingNavigatorT);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorT.BindingSource.AddNew();
            Tctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Tinh", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorT.BindingSource.RemoveCurrent();
                Tctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            Tctrl.Save();
            Tctrl.HienThiDataGridView(dataGridViewT, bindingNavigatorT);
            bindingNavigatorT.BindingSource.MoveLast();
        }

        private void ToolTimMaTinh_Click(object sender, EventArgs e)
        {
            ToolTimTenTinh.Checked = false;
            ToolTimMaTinh.Checked = true;
            if (Test())
                toolTimTinh.Text = "Mã Tỉnh";
            bindingNavigatorT.Focus();
        }

        private void ToolTimTenTinh_Click(object sender, EventArgs e)
        {
            ToolTimTenTinh.Checked = true;
            ToolTimMaTinh.Checked = false;
            if (Test())
                toolTimTinh.Text = "Tên Tỉnh";
            bindingNavigatorT.Focus();
        }

        private void toolTimTinh_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaTinh.Checked == true)
                    toolTimTinh.Text = "Mã Tỉnh";
                else
                    toolTimTinh.Text = "Tên Tỉnh";
            }
        }

        private void toolTimTinh_Enter(object sender, EventArgs e)
        {
            toolTimTinh.Text = "";
            toolTimTinh.ForeColor = Color.Black;
        }

        private void toolTimTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaTinh.Checked)
                    Tctrl.TimMaTinh(toolTimTinh.Text);
                else
                    Tctrl.TimTenTinh(toolTimTinh.Text);
            }
        }

       
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Tctrl.HienThiDataGridView(dataGridViewT, bindingNavigatorT);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public bool Test()
        {
            String str = toolTimTinh.Text;
            if (str == "Mã tỉnh" || str == "Tên tỉnh")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaTinh.Checked)
                Tctrl.TimMaTinh(toolTimTinh.Text);
            else
                Tctrl.TimTenTinh(toolTimTinh.Text);
        }

        
    }
}