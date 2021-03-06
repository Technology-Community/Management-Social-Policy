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
    public partial class frmLoaiDoiTac : Form
    {
        LoaiDoiTacController LDTctrl = new LoaiDoiTacController();
        public frmLoaiDoiTac()
        {
            InitializeComponent();
        }

        private void frmLoaiDoiTac_Load(object sender, EventArgs e)
        {
            LDTctrl.HienThiDataGridView(dataGridViewLDT, bindingNavigatorLDT);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorLDT.BindingSource.AddNew();
            LDTctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Loai Doi Tac", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLDT.BindingSource.RemoveCurrent();
                LDTctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            LDTctrl.Save();
            LDTctrl.HienThiDataGridView(dataGridViewLDT, bindingNavigatorLDT);
            bindingNavigatorLDT.BindingSource.MoveLast();
        }

        private void ToolTimMaLoaiDoiTac_Click(object sender, EventArgs e)
        {
            ToolTimTenLoaiDoiTac.Checked = false;
            ToolTimMaLoaiDoiTac.Checked = true;
            if (Test())
                toolTimLoaiDoiTac.Text = "Mã Loại Đối Tác";
            bindingNavigatorLDT.Focus();
        }

        private void ToolTimTenLoaiDoiTac_Click(object sender, EventArgs e)
        {
            ToolTimTenLoaiDoiTac.Checked = true;
            ToolTimMaLoaiDoiTac.Checked = false;
            if (Test())
                toolTimLoaiDoiTac.Text = "Tên Loại Đối Tác";
            bindingNavigatorLDT.Focus();
        }

        private void toolTimLoaiDoiTac_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaLoaiDoiTac.Checked == true)
                    toolTimLoaiDoiTac.Text = "Mã Loại Đối Tác";
                else
                    toolTimLoaiDoiTac.Text = "Tên Loại Đối Tác";
            }
        }

        private void toolTimLoaiDoiTac_Enter(object sender, EventArgs e)
        {
            toolTimLoaiDoiTac.Text = "";
            toolTimLoaiDoiTac.ForeColor = Color.Black;
        }

        private void toolTimLoaiDoiTac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaLoaiDoiTac.Checked)
                    LDTctrl.TimMaLoaiDoiTac(toolTimLoaiDoiTac.Text);
                else
                    LDTctrl.TimTenLoaiDoiTac(toolTimLoaiDoiTac.Text);
            }
        }

      

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            LDTctrl.HienThiDataGridView(dataGridViewLDT, bindingNavigatorLDT);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Test()
        {
            String str = toolTimLoaiDoiTac.Text;
            if (str == "Mã loại đối tác" || str == "Tên loại đối tác")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaLoaiDoiTac.Checked)
                LDTctrl.TimMaLoaiDoiTac(toolTimLoaiDoiTac.Text);
            else
                LDTctrl.TimTenLoaiDoiTac(toolTimLoaiDoiTac.Text);
        }



    }
}