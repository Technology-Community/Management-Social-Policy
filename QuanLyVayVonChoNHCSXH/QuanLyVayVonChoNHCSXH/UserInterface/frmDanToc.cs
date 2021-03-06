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
    public partial class frmDanToc : Form
    {
        DanTocController DTctrl = new DanTocController();
        public frmDanToc()
        {
            InitializeComponent();
        }

        private void frmDanToc_Load(object sender, EventArgs e)
        {
            DTctrl.HienThiDataGridView(dataGridViewDT, bindingNavigatorDT);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorDT.BindingSource.AddNew();
            DTctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Dan Toc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorDT.BindingSource.RemoveCurrent();
                DTctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            DTctrl.Save();
            DTctrl.HienThiDataGridView(dataGridViewDT, bindingNavigatorDT);
            bindingNavigatorDT.BindingSource.MoveLast();
        }

        private void ToolTimMaDanToc_Click(object sender, EventArgs e)
        {
            ToolTimTenDanToc.Checked = false;
            ToolTimMaDanToc.Checked = true;
            if (Test())
                toolTimDanToc.Text = "Mã Dân Tộc";
            bindingNavigatorDT.Focus();
        }

        private void ToolTimTenDanToc_Click(object sender, EventArgs e)
        {
            ToolTimTenDanToc.Checked = true;
            ToolTimMaDanToc.Checked = false;
            if (Test())
                toolTimDanToc.Text = "Tên Dân Tộc";
            bindingNavigatorDT.Focus();
        }

        private void toolTimDanToc_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaDanToc.Checked == true)
                    toolTimDanToc.Text = "Mã Dân Tộc";
                else
                    toolTimDanToc.Text = "Tên Dân Tộc";
            }
        }

        private void toolTimDanToc_Enter(object sender, EventArgs e)
        {
            toolTimDanToc.Text = "";
            toolTimDanToc.ForeColor = Color.Black;
        }

        private void toolTimDanToc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaDanToc.Checked)
                    DTctrl.TimMaDanToc(toolTimDanToc.Text);
                else
                    DTctrl.TimTenDanToc(toolTimDanToc.Text);
            }
        }

     
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DTctrl.HienThiDataGridView(dataGridViewDT, bindingNavigatorDT);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimDanToc.Text;
            if (str == "Mã dân tộc" || str == "Tên dân tộc")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaDanToc.Checked)
                DTctrl.TimMaDanToc(toolTimDanToc.Text);
            else
                DTctrl.TimTenDanToc(toolTimDanToc.Text);
        }

       
    }
}