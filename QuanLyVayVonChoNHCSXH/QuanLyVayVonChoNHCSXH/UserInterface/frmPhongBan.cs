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
    public partial class frmPhongBan : Form
    {
        PhongBanController PBctrl = new PhongBanController();
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            PBctrl.HienThiDataGridView(dataGridViewPB, bindingNavigatorPB);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorPB.BindingSource.AddNew();
            PBctrl.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Phong Ban", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorPB.BindingSource.RemoveCurrent();
                PBctrl.Save();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            PBctrl.Save();
            PBctrl.HienThiDataGridView(dataGridViewPB, bindingNavigatorPB);
            bindingNavigatorPB.BindingSource.MoveLast();
        }

        private void ToolTimMaPhongBan_Click(object sender, EventArgs e)
        {
            ToolTimTenPhongBan.Checked = false;
            ToolTimMaPhongBan.Checked = true;
            if (Test())
                toolTimPhongBan.Text = "Mã Phòng Ban";
            bindingNavigatorPB.Focus();
        }

        private void ToolTimTenPhongBan_Click(object sender, EventArgs e)
        {
            ToolTimTenPhongBan.Checked = true;
            ToolTimMaPhongBan.Checked = false;
            if (Test())
                toolTimPhongBan.Text = "Tên Phòng Ban";
            bindingNavigatorPB.Focus();
        }

        private void toolTimPhongBan_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaPhongBan.Checked == true)
                    toolTimPhongBan.Text = "Mã Phòng Ban";
                else
                    toolTimPhongBan.Text = "Tên Phòng Ban";
            }
        }

        private void toolTimPhongBan_Enter(object sender, EventArgs e)
        {
            toolTimPhongBan.Text = "";
            toolTimPhongBan.ForeColor = Color.Black;
        }

        private void toolTimPhongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaPhongBan.Checked)
                    PBctrl.TimMaPhongBan(toolTimPhongBan.Text);
                else
                    PBctrl.TimTenPhongBan(toolTimPhongBan.Text);
            }
        }

       

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            PBctrl.HienThiDataGridView(dataGridViewPB, bindingNavigatorPB);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimPhongBan.Text;
            if (str == "Mã phòng ban" || str == "Tên phòng ban")
                return true;
            return false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (ToolTimMaPhongBan.Checked)
                PBctrl.TimMaPhongBan(toolTimPhongBan.Text);
            else
                PBctrl.TimTenPhongBan(toolTimPhongBan.Text);
        }



    }
}