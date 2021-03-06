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
    public partial class frmQuyen : Form
    {
        QuyenController Qctrl = new QuyenController();
        public frmQuyen()
        {
            InitializeComponent();
        }

        private void frmQuyen_Load(object sender, EventArgs e)
        {
            Qctrl.HienThiDataGridView(dataGridViewQ, bindingNavigatorQ);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorQ.BindingSource.AddNew();
            Qctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Quyen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorQ.BindingSource.RemoveCurrent();
                Qctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            Qctrl.Save();
            Qctrl.HienThiDataGridView(dataGridViewQ, bindingNavigatorQ);
            bindingNavigatorQ.BindingSource.MoveLast();
        }

        private void ToolTimMaQuyen_Click(object sender, EventArgs e)
        {
            ToolTimTenQuyen.Checked = false;
            ToolTimMaQuyen.Checked = true;
            if (Test())
                toolTimQuyen.Text = "Mã Quyền";
            bindingNavigatorQ.Focus();
        }

        private void ToolTimTenQuyen_Click(object sender, EventArgs e)
        {
            ToolTimTenQuyen.Checked = true;
            ToolTimMaQuyen.Checked = false;
            if (Test())
                toolTimQuyen.Text = "Tên Quyền";
            bindingNavigatorQ.Focus();
        }

        private void toolTimQuyen_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaQuyen.Checked == true)
                    toolTimQuyen.Text = "Mã Quyền";
                else
                    toolTimQuyen.Text = "Tên Quyền";
            }
        }

        private void toolTimQuyen_Enter(object sender, EventArgs e)
        {
            toolTimQuyen.Text = "";
            toolTimQuyen.ForeColor = Color.Black;
        }

        private void toolTimQuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaQuyen.Checked)
                    Qctrl.TimMaQuyen(toolTimQuyen.Text);
                else
                    Qctrl.TimTenQuyen(toolTimQuyen.Text);
            }
        }

       

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Qctrl.HienThiDataGridView(dataGridViewQ, bindingNavigatorQ);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimQuyen.Text;
            if (str == "Mã quyền" || str == "Tên quyền")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaQuyen.Checked)
                Qctrl.TimMaQuyen(toolTimQuyen.Text);
            else
                Qctrl.TimTenQuyen(toolTimQuyen.Text);
        }



    }
}