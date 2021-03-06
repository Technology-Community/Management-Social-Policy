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
    public partial class frmHTDamBao : Form
    {
        HTDamBaoController HTDBctrl = new HTDamBaoController();
        public frmHTDamBao()
        {
            InitializeComponent();
        }

       
        private void frmHTDamBao_Load(object sender, EventArgs e)
        {
            HTDBctrl.HienThiDataGridView(dataGridViewHTDB, bindingNavigatorHTDB);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorHTDB.BindingSource.AddNew();
            HTDBctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "HT Dam Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorHTDB.BindingSource.RemoveCurrent();
                HTDBctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            HTDBctrl.Save();
            HTDBctrl.HienThiDataGridView(dataGridViewHTDB, bindingNavigatorHTDB);
            bindingNavigatorHTDB.BindingSource.MoveLast();
        }

        private void ToolTimMaHTDamBao_Click(object sender, EventArgs e)
        {
            ToolTimTenHTDamBao.Checked = false;
            ToolTimMaHTDamBao.Checked = true;
            if (Test())
                toolTimHTDamBao.Text = "Mã HT Đảm Bảo";
            bindingNavigatorHTDB.Focus();
        }

        private void ToolTimTenHTDamBao_Click(object sender, EventArgs e)
        {
            ToolTimTenHTDamBao.Checked = true;
            ToolTimMaHTDamBao.Checked = false;
            if (Test())
                toolTimHTDamBao.Text = "Tên HT Đảm Bảo";
            bindingNavigatorHTDB.Focus();
        }

        private void toolTimHTDamBao_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaHTDamBao.Checked == true)
                    toolTimHTDamBao.Text = "Mã HT Đảm Bảo";
                else
                    toolTimHTDamBao.Text = "Tên HT Đảm Bảo";
            }
        }

        private void toolTimHTDamBao_Enter(object sender, EventArgs e)
        {
            toolTimHTDamBao.Text = "";
            toolTimHTDamBao.ForeColor = Color.Black;
        }

        private void toolTimHTDamBao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaHTDamBao.Checked)
                    HTDBctrl.TimMaHTDamBao(toolTimHTDamBao.Text);
                else
                    HTDBctrl.TimTenHTDamBao(toolTimHTDamBao.Text);
            }
        }

       
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            HTDBctrl.HienThiDataGridView(dataGridViewHTDB, bindingNavigatorHTDB);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimHTDamBao.Text;
            if (str == "Mã hình thức đảm bảo" || str == "Tên hình thức đảm bảo")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaHTDamBao.Checked)
                HTDBctrl.TimMaHTDamBao(toolTimHTDamBao.Text);
            else
                HTDBctrl.TimTenHTDamBao(toolTimHTDamBao.Text);
        }



    }
}