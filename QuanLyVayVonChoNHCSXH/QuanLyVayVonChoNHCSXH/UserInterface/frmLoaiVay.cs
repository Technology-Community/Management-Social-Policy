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
    public partial class frmLoaiVay : Form
    {
        LoaiVayController LVctrl = new LoaiVayController();
        public frmLoaiVay()
        {
            InitializeComponent();
        }

        private void frmLoaiVay_Load(object sender, EventArgs e)
        {
            LVctrl.HienThiDataGridView(dataGridViewLV, bindingNavigatorLV);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorLV.BindingSource.AddNew();
            LVctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Loai Vay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLV.BindingSource.RemoveCurrent();
                LVctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            LVctrl.Save();
            LVctrl.HienThiDataGridView(dataGridViewLV, bindingNavigatorLV);
            bindingNavigatorLV.BindingSource.MoveLast();
        }

        private void ToolTimMaLoaiVay_Click(object sender, EventArgs e)
        {
            ToolTimTenLoaiVay.Checked = false;
            ToolTimMaLoaiVay.Checked = true;
            if (Test())
                toolTimLoaiVay.Text = "Mã Loại Vay";
            bindingNavigatorLV.Focus();
        }

        private void ToolTimTenLoaiVay_Click(object sender, EventArgs e)
        {
            ToolTimTenLoaiVay.Checked = true;
            ToolTimMaLoaiVay.Checked = false;
            if (Test())
                toolTimLoaiVay.Text = "Tên Loại Vay";
            bindingNavigatorLV.Focus();
        }

        private void toolTimLoaiVay_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaLoaiVay.Checked == true)
                    toolTimLoaiVay.Text = "Mã Loại Vay";
                else
                    toolTimLoaiVay.Text = "Tên Loại Vay";
            }
        }

        private void toolTimLoaiVay_Enter(object sender, EventArgs e)
        {
            toolTimLoaiVay.Text = "";
            toolTimLoaiVay.ForeColor = Color.Black;
        }

        private void toolTimLoaiVay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaLoaiVay.Checked)
                    LVctrl.TimMaLoaiVay(toolTimLoaiVay.Text);
                else
                    LVctrl.TimTenLoaiVay(toolTimLoaiVay.Text);
            }
        }

       
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            LVctrl.HienThiDataGridView(dataGridViewLV, bindingNavigatorLV);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimLoaiVay.Text;
            if (str == "Mã loại vay" || str == "Tên loại vay")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaLoaiVay.Checked)
                LVctrl.TimMaLoaiVay(toolTimLoaiVay.Text);
            else
                LVctrl.TimTenLoaiVay(toolTimLoaiVay.Text);
        }



    }
}