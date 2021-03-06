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
    public partial class frmLoaiHinh : Form
    {
        LoaiHinhController LHctrl = new LoaiHinhController();
        public frmLoaiHinh()
        {
            InitializeComponent();
        }

        private void frmLoaiHinh_Load(object sender, EventArgs e)
        {
            LHctrl.HienThiDataGridView(dataGridViewLH, bindingNavigatorLH);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorLH.BindingSource.AddNew();
            LHctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Loai Hinh", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLH.BindingSource.RemoveCurrent();
                LHctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            LHctrl.Save();
            LHctrl.HienThiDataGridView(dataGridViewLH, bindingNavigatorLH);
            bindingNavigatorLH.BindingSource.MoveLast();
        }

        private void ToolTimMaLoaiHinh_Click(object sender, EventArgs e)
        {
            ToolTimTenLoaiHinh.Checked = false;
            ToolTimMaLoaiHinh.Checked = true;
            if (Test())
                toolTimLoaiHinh.Text = "Mã Loại Hình";
            bindingNavigatorLH.Focus();
        }

        private void ToolTimTenLoaiHinh_Click(object sender, EventArgs e)
        {
            ToolTimTenLoaiHinh.Checked = true;
            ToolTimMaLoaiHinh.Checked = false;
            if (Test())
                toolTimLoaiHinh.Text = "Tên Loại Hình";
            bindingNavigatorLH.Focus();
        }

        private void toolTimLoaiHinh_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaLoaiHinh.Checked == true)
                    toolTimLoaiHinh.Text = "Mã loại hình";
                else
                    toolTimLoaiHinh.Text = "Tên loại hình";
            }
        }

        private void toolTimLoaiHinh_Enter(object sender, EventArgs e)
        {
            toolTimLoaiHinh.Text = "";
            toolTimLoaiHinh.ForeColor = Color.Black;
        }

        private void toolTimLoaiHinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaLoaiHinh.Checked)
                    LHctrl.TimMaLoaiHinh(toolTimLoaiHinh.Text);
                else
                    LHctrl.TimTenLoaiHinh(toolTimLoaiHinh.Text);
            }
        }

      

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            LHctrl.HienThiDataGridView(dataGridViewLH, bindingNavigatorLH);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str =toolTimLoaiHinh.Text;
            if (str == "Mã loại hình" || str == "Tên loại hình")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaLoaiHinh.Checked)
                LHctrl.TimMaLoaiHinh(toolTimLoaiHinh.Text);
            else
                LHctrl.TimTenLoaiHinh(toolTimLoaiHinh.Text);
        }

        

        
    }
}