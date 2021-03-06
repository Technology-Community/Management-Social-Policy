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
    public partial class frmDanhSachKhachHang : Form
    {
        DoiTacController DTctrl = new DoiTacController();
        public frmDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void frmDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            DTctrl.HienThiDataGridViewDSKH(dataGridViewDSKH,bindingNavigatorDSKH);
        }

        private void Thêm_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigatorDSKH.BindingSource.AddNew();
            DTctrl.Save();
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Danh sach khach hang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorDSKH.BindingSource.RemoveCurrent();
                DTctrl.Save();
            }
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            DTctrl.Save();
            DTctrl.HienThiDataGridViewDSKH(dataGridViewDSKH, bindingNavigatorDSKH);
            bindingNavigatorDSKH.BindingSource.MoveLast();
        }

        private void ToolTimMaDoiTac_Click(object sender, EventArgs e)
        {
            ToolTimTenDoiTac.Checked = false;
            ToolTimMaLoaiDoiTac.Checked = false;
            ToolTimMaDoiTac.Checked = true;
            if (Test())
                toolTimDanhSachKhachHang.Text = "Mã Khách Hàng";
            bindingNavigatorDSKH.Focus();
        }

        private void ToolStripTimTenDoiTac_Click(object sender, EventArgs e)
        {
            ToolTimTenDoiTac.Checked = true;
            ToolTimMaLoaiDoiTac.Checked = false;
            ToolTimMaDoiTac.Checked = false;
            if (Test())
                toolTimDanhSachKhachHang.Text = "Tên Khách Hàng";
            bindingNavigatorDSKH.Focus();
        }

        private void ToolTimMaLoaiDoiTac_Click(object sender, EventArgs e)
        {
            ToolTimTenDoiTac.Checked = false;
            ToolTimMaLoaiDoiTac.Checked = true;
            ToolTimMaDoiTac.Checked = false;
            if (Test())
                toolTimDanhSachKhachHang.Text = "Tên Khách Hàng";
            bindingNavigatorDSKH.Focus();
        }

        public bool Test()
        {
            String str = toolTimDanhSachKhachHang.Text;
            if (str == "Mã đối tác" || str == "Tên đối tác")
                return true;
            return false;
        }

        private void toolTimDanhSachKhachHang_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaDoiTac.Checked == true)
                    toolTimDanhSachKhachHang.Text = "Mã Đối Tác";
                else
                    if (ToolTimMaLoaiDoiTac.Checked == true)
                        toolTimDanhSachKhachHang.Text = "Mã Loại Đối Tác";
                    else
                        toolTimDanhSachKhachHang.Text = "Tên Đối Tác";
            }
        }

        private void toolTimDanhSachKhachHang_Enter(object sender, EventArgs e)
        {
            toolTimDanhSachKhachHang.Text = "";
            toolTimDanhSachKhachHang.ForeColor = Color.Black;
        }

        private void toolTimDanhSachKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaDoiTac.Checked)
                    DTctrl.TimMaDoiTacDSKH(toolTimDanhSachKhachHang.Text);
                else
                    if (ToolTimMaLoaiDoiTac.Checked)
                        DTctrl.TimMaLoaiDoiTacDSKH(toolTimDanhSachKhachHang.Text);
                    else
                        DTctrl.TimTenDoiTacDSKH(toolTimDanhSachKhachHang.Text);
            }
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            if (ToolTimMaDoiTac.Checked)
                DTctrl.TimMaDoiTacDSKH(toolTimDanhSachKhachHang.Text);
            else
                if (ToolTimMaLoaiDoiTac.Checked)
                    DTctrl.TimMaLoaiDoiTacDSKH(toolTimDanhSachKhachHang.Text);
                else
                    DTctrl.TimTenDoiTacDSKH(toolTimDanhSachKhachHang.Text);
        }

        private void XemLai_Click(object sender, EventArgs e)
        {
            DTctrl.HienThiDataGridViewDSKH(dataGridViewDSKH, bindingNavigatorDSKH);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}