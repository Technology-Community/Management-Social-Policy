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
    public partial class frmLoaiChungTu : Form
    {
        LoaiChungTuController LCTctrl = new LoaiChungTuController();
        public frmLoaiChungTu()
        {
            InitializeComponent();
        }

        private void frmDanToc_Load(object sender, EventArgs e)
        {
            LCTctrl.HienThiDataGridView(dataGridViewLCT, bindingNavigatorLCT);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorLCT.BindingSource.AddNew();
            LCTctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Loai Chung Tu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLCT.BindingSource.RemoveCurrent();
                LCTctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            LCTctrl.Save();
            LCTctrl.HienThiDataGridView(dataGridViewLCT, bindingNavigatorLCT);
            bindingNavigatorLCT.BindingSource.MoveLast();
        }

        private void ToolTimMaLoaiChungTu_Click(object sender, EventArgs e)
        {
            ToolTimMaLoaiChungTu.Checked = true;
            ToolTimTenLoaiChungTu.Checked = false;           
            if (Test())
                toolTimLoaiChungTu.Text = "Mã Loại Chứng Từ";
            bindingNavigatorLCT.Focus();
        }

        private void ToolTimTenLoaiChungTu_Click(object sender, EventArgs e)
        {

            ToolTimTenLoaiChungTu.Checked = true;
            ToolTimMaLoaiChungTu.Checked = false;
            if (Test())
                toolTimLoaiChungTu.Text = "Tên Loại Chứng Từ";
            bindingNavigatorLCT.Focus();
        }

        private void toolTimLoaiChungTu_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaLoaiChungTu.Checked == true)
                    toolTimLoaiChungTu.Text = "Mã Loại Chứng Từ";
                else
                    toolTimLoaiChungTu.Text = "Tên Loại Chứng Từ";
            }
        }

        private void toolTimLoaiChungTu_Enter(object sender, EventArgs e)
        {
            toolTimLoaiChungTu.Text = "";
            toolTimLoaiChungTu.ForeColor = Color.Black;
        }

        private void toolTimLoaiChungTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaLoaiChungTu.Checked)
                    LCTctrl.TimMaLoaiChungTu(toolTimLoaiChungTu.Text);
                else
                    LCTctrl.TimTenLoaiChungTu(toolTimLoaiChungTu.Text);
            }
        }

        //private void toolStripButton5_Click(object sender, EventArgs e)
        //{
        //    if (e.KeyChar == 13)
        //    {
        //        if (toolTimMaLoaiChungTu.Checked)
        //            LCTctrl.TimMaLoaiChungTu(toolTimLoaiChungTu.Text);
        //        else
        //            LCTctrl.TimTenLoaiChungTu(toolTimLoaiChungTu.Text);
        //    }
        //}

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            LCTctrl.HienThiDataGridView(dataGridViewLCT, bindingNavigatorLCT);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimLoaiChungTu.Text;
            if (str == "Mã loại chứng từ" || str == "Tên loại chứng từ")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaLoaiChungTu.Checked)
                LCTctrl.TimMaLoaiChungTu(toolTimLoaiChungTu.Text);
            else
                LCTctrl.TimTenLoaiChungTu(toolTimLoaiChungTu.Text);
        }





    }
}