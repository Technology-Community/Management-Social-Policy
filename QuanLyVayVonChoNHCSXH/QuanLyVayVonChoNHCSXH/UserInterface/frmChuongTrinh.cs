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
    public partial class frmChuongTrinh : Form
    {
        ChuongTrinhController CTctrl = new ChuongTrinhController();
        public frmChuongTrinh()
        {
            InitializeComponent();
        }

        private void frmChuongTrinh_Load(object sender, EventArgs e)
        {
            CTctrl.HienThiDataGridView(dataGridViewCT, bindingNavigatorCT);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorCT.BindingSource.AddNew();
            CTctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Choung Trinh", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorCT.BindingSource.RemoveCurrent();
                CTctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            CTctrl.Save();
            CTctrl.HienThiDataGridView(dataGridViewCT, bindingNavigatorCT);
            bindingNavigatorCT.BindingSource.MoveLast();
        }

        private void ToolTimMaChuongTrinh_Click(object sender, EventArgs e)
        {
            ToolTimTenChuongTrinh.Checked = false;
            ToolTimMaChuongTrinh.Checked = true;
            if (Test())
                toolTimChuongTrinh.Text = "Mã Chương Trình";
            bindingNavigatorCT.Focus();
        }

        private void ToolTimTenChuongTrinh_Click(object sender, EventArgs e)
        {
            ToolTimTenChuongTrinh.Checked = true;
            ToolTimMaChuongTrinh.Checked = false;
            if (Test())
                toolTimChuongTrinh.Text = "Tên Chương Trình";
            bindingNavigatorCT.Focus();
        }

        private void toolTimChuongTrinh_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaChuongTrinh.Checked == true)
                    toolTimChuongTrinh.Text = "Mã Chương Trình";
                else
                    toolTimChuongTrinh.Text = "Tên Chương Trình";
            }
        }

        private void toolTimChuongTrinh_Enter(object sender, EventArgs e)
        {
            toolTimChuongTrinh.Text = "";
            toolTimChuongTrinh.ForeColor = Color.Black;
        }

        private void toolTimChuongTrinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaChuongTrinh.Checked)
                    CTctrl.TimMaChuongTrinh(toolTimChuongTrinh.Text);
                else
                    CTctrl.TimTenChuongTrinh(toolTimChuongTrinh.Text);
            }
        }

        

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Test()
        {
            String str = toolTimChuongTrinh.Text;
            if (str == "Mã chương trình" || str == "Tên chương trình")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaChuongTrinh.Checked)
                CTctrl.TimMaChuongTrinh(toolTimChuongTrinh.Text);
            else
                CTctrl.TimTenChuongTrinh(toolTimChuongTrinh.Text);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            CTctrl.HienThiDataGridView(dataGridViewCT, bindingNavigatorCT);
        }

       




    }
}