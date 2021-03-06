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
    public partial class frmDanhSachKheUoc : Form
    {
        HoSoKheUocController HSKUctrl = new HoSoKheUocController();
        public frmDanhSachKheUoc()
        {
            InitializeComponent();
        }

        private void frmDanhSachKheUoc_Load(object sender, EventArgs e)
        {
            HSKUctrl.HienThiDataGridViewDSKU(dataGridViewDSKU,bindingNavigatorDSKU);
        }

        private void Thêm_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorDSKU.BindingSource.AddNew();
            HSKUctrl.Save();
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Danh sach khe uoc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorDSKU.BindingSource.RemoveCurrent();
                HSKUctrl.Save();
            }
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            HSKUctrl.Save();
            HSKUctrl.HienThiDataGridViewDSKU(dataGridViewDSKU, bindingNavigatorDSKU);
            bindingNavigatorDSKU.BindingSource.MoveLast();
        }


        public bool Test()
        {
            String str = toolTimKheUoc.Text;
            if (str == "Mã số khế ước" || str == "Mã đối tác")
                return true;
            return false;
        }
        private void ToolTimMaKheUoc_Click(object sender, EventArgs e)
        {
            ToolTimMaKheUoc.Checked = true;
            ToolTimMaDoiTac.Checked = false;
            if (Test())
                toolTimKheUoc.Text = "Mã số khế ước";
            bindingNavigatorDSKU.Focus();
        }

        private void ToolTimMaDoiTac_Click(object sender, EventArgs e)
        {
            ToolTimMaKheUoc.Checked = false;
            ToolTimMaDoiTac.Checked = true;
            if (Test())
                toolTimKheUoc.Text = "Mã đối tác";
            bindingNavigatorDSKU.Focus();
        }

        private void toolTimKheUoc_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaKheUoc.Checked == true)
                    toolTimKheUoc.Text = "Mã Số Khế Ước";
                else
                    toolTimKheUoc.Text = "Mã Đối Tác";
            }
        }

        private void toolTimKheUoc_Enter(object sender, EventArgs e)
        {
            toolTimKheUoc.Text = "";
            toolTimKheUoc.ForeColor = Color.Black;
        }

        private void toolTimKheUoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaKheUoc.Checked)
                    HSKUctrl.TimHoSoKheUocTheoMaSoKUDS(toolTimKheUoc.Text);

                else
                    HSKUctrl.TimHSKUTheoMaDoiTacDS(toolTimKheUoc.Text);
            }
        }

        private void tim_Click(object sender, EventArgs e)
        {
            if (ToolTimMaKheUoc.Checked)
                HSKUctrl.TimHoSoKheUocTheoMaSoKUDS(toolTimKheUoc.Text);

            else
                HSKUctrl.TimHSKUTheoMaDoiTacDS(toolTimKheUoc.Text);
        }

        private void XemLai_Click(object sender, EventArgs e)
        {
            HSKUctrl.HienThiDataGridViewDSKU(dataGridViewDSKU, bindingNavigatorDSKU);
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}