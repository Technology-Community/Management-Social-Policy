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
    public partial class frmXa : Form
    {
        XaController Xctrl = new XaController();
        public frmXa()
        {
            InitializeComponent();
        }

        private void frmXa_Load(object sender, EventArgs e)
        {
            Xctrl.HienThiDataGridView(dataGridViewX, bindingNavigatorX);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorX.BindingSource.AddNew();
            Xctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Xa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorX.BindingSource.RemoveCurrent();
                Xctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            Xctrl.Save();
            Xctrl.HienThiDataGridView(dataGridViewX, bindingNavigatorX);
            bindingNavigatorX.BindingSource.MoveLast();
        }

        private void ToolTimMaXa_Click(object sender, EventArgs e)
        {
            ToolTimTenXa.Checked = false;
            ToolTimMaXa.Checked = true;
            if (Test())
                toolTimXa.Text = "Mã Xã";
            bindingNavigatorX.Focus();
        }

        private void ToolTimTenXa_Click(object sender, EventArgs e)
        {
            ToolTimTenXa.Checked = true;
            ToolTimMaXa.Checked = false;
            if (Test())
                toolTimXa.Text = "Tên Xã";
            bindingNavigatorX.Focus();
        }

        private void toolTimXa_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaXa.Checked == true)
                    toolTimXa.Text = "Mã Xã";
                else
                    toolTimXa.Text = "Tên Xã";
            }
        }

        private void toolTimXa_Enter(object sender, EventArgs e)
        {
            toolTimXa.Text = "";
            toolTimXa.ForeColor = Color.Black;
        }

        private void toolTimXa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaXa.Checked)
                    Xctrl.TimMaXa(toolTimXa.Text);
                else
                    Xctrl.TimTenXa(toolTimXa.Text);
            }
        }

        

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Xctrl.HienThiDataGridView(dataGridViewX, bindingNavigatorX);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimXa.Text;
            if (str == "Mã xã" || str == "Tên xã")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaXa.Checked)
                Xctrl.TimMaXa(toolTimXa.Text);
            else
                Xctrl.TimTenXa(toolTimXa.Text);
        }

    }
}