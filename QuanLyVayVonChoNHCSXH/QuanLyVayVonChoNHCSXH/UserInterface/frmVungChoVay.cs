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
    public partial class frmVungChoVay : Form
    {
        VungController Vungctrl = new VungController();       
        public frmVungChoVay()
        {
            InitializeComponent();
        }

        private void frmVungChoVay_Load(object sender, EventArgs e)
        {
            Vungctrl.HienThiDataGridView(dataGridView, bindingNavigator);           
        }

        private void toolThem_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigator.BindingSource.AddNew();
            Vungctrl.Save();
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "VungChoVay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator.BindingSource.RemoveCurrent();
                Vungctrl.Save();
            }
        }

        private void toolLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            Vungctrl.Save();
            Vungctrl.HienThiDataGridView(dataGridView, bindingNavigator);
            bindingNavigator.BindingSource.MoveLast();
        }

        private void ToolTimVungChoVay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tooltimtheoma.Checked)
                    Vungctrl.TimMaVung(ToolTimVungChoVay.Text);
                else
                    Vungctrl.TimTenVung(ToolTimVungChoVay.Text);
            }
        }

        private void ToolTimVungChoVay_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (tooltimtheoma.Checked == true)
                    ToolTimVungChoVay.Text = "Mã vùng cho vay";
                else
                    ToolTimVungChoVay.Text = "Tên vùng cho vay";
            }
        }

        private void ToolTimVungChoVay_Enter(object sender, EventArgs e)
        {
            ToolTimVungChoVay.Text = "";
            ToolTimVungChoVay.ForeColor = Color.Black;
        }

        private void tooltimtheoma_Click(object sender, EventArgs e)
        {
            tooltimtheoten.Checked = false;
            tooltimtheoma.Checked = true;
            if (Test())
                ToolTimVungChoVay.Text = "Mã vùng cho vay";
            bindingNavigator.Focus();
        }

        private void tooltimtheoten_Click(object sender, EventArgs e)
        {
            tooltimtheoten.Checked = true;
            tooltimtheoma.Checked = false;
            if (Test())
                ToolTimVungChoVay.Text = "Tên vùng cho vay";
            bindingNavigator.Focus();
        }

        public bool Test()
        {
            String str = ToolTimVungChoVay.Text;
            if (str == "Mã vùng cho vay" || str == "Tên vùng cho vay")
                return true;
            return false;
        }

        private void toolThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolXemlai_Click(object sender, EventArgs e)
        {
            Vungctrl.HienThiDataGridView(dataGridView, bindingNavigator);           
        }





    }
}