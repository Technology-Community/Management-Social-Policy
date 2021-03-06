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
    public partial class frmChucVu : Form
    {
        ChucVuController CVctrl = new ChucVuController();
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            CVctrl.HienThiDataGridView(dataGridViewCV, bindingNavigatorCV);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //if (CVctrl.LayChucVu(dataGridViewCV) != null)
            //{
            //    MessageBox.Show("Mã Phiếu bán này đã tồn tại !", "Phieu Nhap", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            DataRowView row = (DataRowView)bindingNavigatorCV.BindingSource.AddNew();
            CVctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Chuc Vu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorCV.BindingSource.RemoveCurrent();
                CVctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            CVctrl.Save();
            CVctrl.HienThiDataGridView(dataGridViewCV, bindingNavigatorCV);
            bindingNavigatorCV.BindingSource.MoveLast();
        }

        private void ToolTimMaChucVu_Click(object sender, EventArgs e)
        {
            ToolTimTenChucVu.Checked = false;
            ToolTimMaChucVu.Checked = true;
            if (Test())
                toolTimChucVu.Text = "Mã Chức Vụ";
            bindingNavigatorCV.Focus();
        }

        private void ToolTimTenChucVu_Click(object sender, EventArgs e)
        {
            ToolTimTenChucVu.Checked = true;
            ToolTimMaChucVu.Checked = false;
            if (Test())
                toolTimChucVu.Text = "Tên Chức Vụ";
            bindingNavigatorCV.Focus();

        }

        private void toolTimChucVu_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaChucVu.Checked == true)
                    toolTimChucVu.Text = "Mã Chức Vụ";
                else
                    toolTimChucVu.Text = "Tên Chức Vụ";
            }
        }

        private void toolTimChucVu_Enter(object sender, EventArgs e)
        {
            toolTimChucVu.Text = "";
            toolTimChucVu.ForeColor = Color.Black;
        }

        private void toolTimChucVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaChucVu.Checked)
                    CVctrl.TimMaChucVu(toolTimChucVu.Text);
                else
                    CVctrl.TimTenChucVu(toolTimChucVu.Text);
            }
        }

    

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            CVctrl.HienThiDataGridView(dataGridViewCV, bindingNavigatorCV);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimChucVu.Text;
            if (str == "Mã chức vụ" || str == "Tên chức vụ")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaChucVu.Checked)
                CVctrl.TimMaChucVu(toolTimChucVu.Text);
            else
                CVctrl.TimTenChucVu(toolTimChucVu.Text);
        }

       


       

       
        
    }
}