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
    public partial class frmThoiHanVay : Form
    {
        ThoiHanVayController THVctrl = new ThoiHanVayController();
        public frmThoiHanVay()
        {
            InitializeComponent();
        }

        private void frmThoiHanVay_Load(object sender, EventArgs e)
        {
            THVctrl.HienThiDataGridView(dataGridViewTHV, bindingNavigatorTHV);
        }

        private void ToolTimMaThoiHanVay_Click(object sender, EventArgs e)
        {
            ToolTimTenThoiHanVay.Checked = false;
            ToolTimMaThoiHanVay.Checked = true;
            if (Test())
                toolTimThoiHanVay.Text = "Mã Thời Hạn Vay"; 
            bindingNavigatorTHV.Focus();
        }

        private void ToolTimTenThoiHanVay_Click(object sender, EventArgs e)
        {
            ToolTimTenThoiHanVay.Checked = true;
            ToolTimMaThoiHanVay.Checked = false;
            if (Test())
                toolTimThoiHanVay.Text = "Tên Thời Hạn Vay";
            bindingNavigatorTHV.Focus();
        }

        private void toolTimThoiHanVay_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaThoiHanVay.Checked == true)
                    toolTimThoiHanVay.Text = "Mã Thời Hạn Vay";
                else
                    toolTimThoiHanVay.Text = "Tên Thời Hạn Vay";
            }
        }

        private void toolTimThoiHanVay_Enter(object sender, EventArgs e)
        {
            toolTimThoiHanVay.Text = "";
            toolTimThoiHanVay.ForeColor = Color.Black;
        }

        private void toolTimThoiHanVay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaThoiHanVay.Checked)
                    THVctrl.TimMaThoiHanVay(toolTimThoiHanVay.Text);
                else
                    THVctrl.TimTenThoiHanVay(toolTimThoiHanVay.Text);
            }
        }

        

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            THVctrl.HienThiDataGridView(dataGridViewTHV, bindingNavigatorTHV);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorTHV.BindingSource.AddNew();
            THVctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thoi Han Vay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTHV.BindingSource.RemoveCurrent();
                THVctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            THVctrl.Save();
            THVctrl.HienThiDataGridView(dataGridViewTHV, bindingNavigatorTHV);
            bindingNavigatorTHV.BindingSource.MoveLast();
        }

        public bool Test()
        {
            String str = toolTimThoiHanVay.Text;
            if (str == "Mã thời hạn vay" || str == "Tên thời hạn vay")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaThoiHanVay.Checked)
                THVctrl.TimMaThoiHanVay(toolTimThoiHanVay.Text);
            else
                THVctrl.TimTenThoiHanVay(toolTimThoiHanVay.Text);
        }


    }
}