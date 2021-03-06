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
    public partial class frmKieuVayNguonVon : Form
    {
        KieuVayNguonVonController KVNVctrl = new KieuVayNguonVonController();
        public frmKieuVayNguonVon()
        {
            InitializeComponent();
        }

        private void frmKieuVayNguonVon_Load(object sender, EventArgs e)
        {
            KVNVctrl.HienThiDataGridView(dataGridViewKVNV, bindingNavigatorKVNV);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorKVNV.BindingSource.AddNew();
            KVNVctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Kieu Vay Nguon Von", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKVNV.BindingSource.RemoveCurrent();
                KVNVctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            KVNVctrl.Save();
            KVNVctrl.HienThiDataGridView(dataGridViewKVNV, bindingNavigatorKVNV);
            bindingNavigatorKVNV.BindingSource.MoveLast();
        }

        private void ToolTimMaKVNV_Click(object sender, EventArgs e)
        {

            ToolTimTenKVNV.Checked = false;
            ToolTimMaKVNV.Checked = true;
            if (Test())
                toolTimKVNV.Text = "Mã Kiểu Vay Nguồn Vốn";
            bindingNavigatorKVNV.Focus();
        }

        private void ToolTimTenKVNV_Click(object sender, EventArgs e)
        {
            ToolTimTenKVNV.Checked = true;
            ToolTimMaKVNV.Checked = false;
            if (Test())
                toolTimKVNV.Text = "Tên Kiểu Vay Nguồn Vốn";
            bindingNavigatorKVNV.Focus();
        }

        private void toolTimKVNV_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaKVNV.Checked == true)
                   toolTimKVNV.Text = "Mã Kiểu Vay Nguồn Vốn";
                else
                   toolTimKVNV.Text = "Tên Kiểu Vay Nguồn Vốn";
            }
        }

        private void toolTimKVNV_Enter(object sender, EventArgs e)
        {
            toolTimKVNV.Text = "";
            toolTimKVNV.ForeColor = Color.Black;
        }

        private void toolTimKVNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaKVNV.Checked)
                    KVNVctrl.TimMaKieuVayNguonVon(toolTimKVNV.Text);
                else
                    KVNVctrl.TimTenKieuVayNguonVon(toolTimKVNV.Text);
            }
        }

      
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            KVNVctrl.HienThiDataGridView(dataGridViewKVNV, bindingNavigatorKVNV);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimKVNV.Text;
            if (str == "Mã KVNV" || str == "Tên KVNV")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaKVNV.Checked)
                KVNVctrl.TimMaKieuVayNguonVon(toolTimKVNV.Text);
            else
                KVNVctrl.TimTenKieuVayNguonVon(toolTimKVNV.Text);
        }



    }
}