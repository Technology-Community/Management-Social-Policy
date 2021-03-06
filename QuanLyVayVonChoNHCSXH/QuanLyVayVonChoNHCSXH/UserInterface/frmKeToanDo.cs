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
    public partial class frmKeToanDo : Form
    {
        KeToanDoController KTDctrl = new KeToanDoController();
        public frmKeToanDo()
        {
            InitializeComponent();
        }

        private void frmKeToanDo_Load_1(object sender, EventArgs e)
        {
            KTDctrl.HienThiDataGridView(dataGridViewKTD, bindingNavigatorKTD);
        }


        //private void frmKeToanDo_Load(object sender, EventArgs e)
        //{
        //    KTDctrl.HienThiDataGridView(dataGridViewKTD, bindingNavigatorKTD);
        //}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorKTD.BindingSource.AddNew();
            KTDctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Ke Toan Do", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKTD.BindingSource.RemoveCurrent();
                KTDctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            KTDctrl.Save();
            KTDctrl.HienThiDataGridView(dataGridViewKTD, bindingNavigatorKTD);
            bindingNavigatorKTD.BindingSource.MoveLast();
        }

        private void ToolTimMaKeToanDo_Click(object sender, EventArgs e)
        {
            ToolTimTenKeToanDo.Checked = false;
            ToolTimMaKeToanDo.Checked = true;
            if (Test())
                toolTimKeToanDo.Text = "Mã cấp";
            bindingNavigatorKTD.Focus();
        }

        private void ToolTimTenKeToanDo_Click(object sender, EventArgs e)
        {
            ToolTimTenKeToanDo.Checked = true;
            ToolTimMaKeToanDo.Checked = false;
            if (Test())
                toolTimKeToanDo.Text = "Tên cấp";
            bindingNavigatorKTD.Focus();
        }

        private void toolTimKeToanDo_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaKeToanDo.Checked == true)
                    toolTimKeToanDo.Text = "Mã cấp";
                else
                    toolTimKeToanDo.Text = "Tên cấp";
            }
        }

        private void toolTimKeToanDo_Enter(object sender, EventArgs e)
        {
            toolTimKeToanDo.Text = "";
            toolTimKeToanDo.ForeColor = Color.Black;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            KTDctrl.HienThiDataGridView(dataGridViewKTD, bindingNavigatorKTD);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimKeToanDo.Text;
            if (str == "Mã cấp" || str == "Tên cấp")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaKeToanDo.Checked)
                KTDctrl.TimMaKeToanDo(toolTimKeToanDo.Text);
            else
                KTDctrl.TimTenKeToanDo(toolTimKeToanDo.Text);
        }

        private void toolTimKeToanDo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaKeToanDo.Checked)
                    KTDctrl.TimMaKeToanDo(toolTimKeToanDo.Text);
                else
                    KTDctrl.TimTenKeToanDo(toolTimKeToanDo.Text);
            }
        }

        

    }
}