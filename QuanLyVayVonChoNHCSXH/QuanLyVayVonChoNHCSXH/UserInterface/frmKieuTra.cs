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
    public partial class frmKieuTra : Form
    {
        KieuTraController KTctrl = new KieuTraController();
        public frmKieuTra()
        {
            InitializeComponent();
        }

        private void frmKieuTra_Load(object sender, EventArgs e)
        {
            KTctrl.HienThiDataGridView(dataGridViewKT, bindingNavigatorKT);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorKT.BindingSource.AddNew();
            KTctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Kieu Tra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKT.BindingSource.RemoveCurrent();
                KTctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            KTctrl.Save();
            KTctrl.HienThiDataGridView(dataGridViewKT, bindingNavigatorKT);
            bindingNavigatorKT.BindingSource.MoveLast();
        }

        private void ToolTimMaKieuTra_Click(object sender, EventArgs e)
        {
            ToolTimTenKieuTra.Checked = false;
            ToolTimMaKieuTra.Checked = true;
            if (Test())
                toolTimKieuTra.Text = "Mã Kiểu Trả";
            bindingNavigatorKT.Focus();
        }

        private void ToolTimTenKieuTra_Click(object sender, EventArgs e)
        {
            ToolTimTenKieuTra.Checked = true;
            ToolTimMaKieuTra.Checked = false;
            if (Test())
                toolTimKieuTra.Text = "Tên Kiểu Trả";
            bindingNavigatorKT.Focus();
        }

        private void toolTimKieuTra_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaKieuTra.Checked == true)
                    toolTimKieuTra.Text = "Mã Kiểu Trả";
                else
                    toolTimKieuTra.Text = "Tên Kiểu Trả";
            }
        }

        private void toolTimKieuTra_Enter(object sender, EventArgs e)
        {
            toolTimKieuTra.Text = "";
            toolTimKieuTra.ForeColor = Color.Black;
        }

        private void toolTimKieuTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaKieuTra.Checked)
                    KTctrl.TimMaKieuTra(toolTimKieuTra.Text);
                else
                    KTctrl.TimTenKieuTra(toolTimKieuTra.Text);
            }
        }

        

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            KTctrl.HienThiDataGridView(dataGridViewKT, bindingNavigatorKT);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimKieuTra.Text;
            if (str == "Mã kiểu trả" || str == "Tên kiểu trả")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaKieuTra.Checked)
                KTctrl.TimMaKieuTra(toolTimKieuTra.Text);
            else
                KTctrl.TimTenKieuTra(toolTimKieuTra.Text);
        }


    }
}