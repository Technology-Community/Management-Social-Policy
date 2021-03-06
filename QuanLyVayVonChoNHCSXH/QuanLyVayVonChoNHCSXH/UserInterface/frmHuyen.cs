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
    public partial class frmHuyen : Form
    {
        HuyenController Hctrl = new HuyenController();
        public frmHuyen()
        {
            InitializeComponent();
        }

        private void frmHuyen_Load(object sender, EventArgs e)
        {
            Hctrl.HienThiDataGridView(dataGridViewH, bindingNavigatorH);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorH.BindingSource.AddNew();
            Hctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Huyen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorH.BindingSource.RemoveCurrent();
                Hctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            Hctrl.Save();
            Hctrl.HienThiDataGridView(dataGridViewH, bindingNavigatorH);
            bindingNavigatorH.BindingSource.MoveLast();
        }

        private void ToolTimMaHuyen_Click(object sender, EventArgs e)
        {

            ToolTimTenHuyen.Checked = false;
            ToolTimMaHuyen.Checked = true;
            if (Test())
                toolTimHuyen.Text = "Mã Huyện";
            bindingNavigatorH.Focus();
        }

        private void ToolTimTenHuyen_Click(object sender, EventArgs e)
        {
            ToolTimTenHuyen.Checked = true;
            ToolTimMaHuyen.Checked = false;
            if (Test())
                toolTimHuyen.Text = "Tên Huyện";
            bindingNavigatorH.Focus();
        }

        private void toolTimHuyen_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaHuyen.Checked == true)
                    toolTimHuyen.Text = "Mã Huyện";
                else
                    toolTimHuyen.Text = "Tên Huyện";
            }
        }

        private void toolTimHuyen_Enter(object sender, EventArgs e)
        {
            toolTimHuyen.Text = "";
            toolTimHuyen.ForeColor = Color.Black;
        }

        private void toolTimHuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaHuyen.Checked)
                    Hctrl.TimMaHuyen(toolTimHuyen.Text);
                else
                    Hctrl.TimTenHuyen(toolTimHuyen.Text);
            }
        }

        

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Hctrl.HienThiDataGridView(dataGridViewH, bindingNavigatorH);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimHuyen.Text;
            if (str == "Mã Huyện" || str == "Tên Huyện")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaHuyen.Checked)
                Hctrl.TimMaHuyen(toolTimHuyen.Text);
            else
                Hctrl.TimTenHuyen(toolTimHuyen.Text);
        }



    }
}