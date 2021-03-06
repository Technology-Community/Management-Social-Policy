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
    public partial class frmTaiKhoan : Form
    {
        TaiKhoanController TKctrl = new TaiKhoanController();
        NhanVienController NVctrol = new NhanVienController();
        KeToanDoController KTDctrl = new KeToanDoController();
        ThamSo.Controll status = ThamSo.Controll.Normal;  

        public frmTaiKhoan()
        {
            InitializeComponent();
         //   ThamSo.Controll status = ThamSo.Controll.Addnew;
        }

         public frmTaiKhoan(TaiKhoanController ctrltk)
            :this()
        {
            this.TKctrl = ctrltk;
            status= ThamSo.Controll.Normal;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            NVctrol.HienThiCombobox(cmbMaNV);
            KTDctrl.HienThiCombobox(cmbMaCap);
            TKctrl.HienThiDataGridView(dataGridViewTK, bindingNavigatorTK, txtMaTaiKhoan, txtTenTaiKhoan, cmbMaNV,cmbMaCap);
            if (status == ThamSo.Controll.Addnew)
            {                
                Allow(true);
            }
            else
            {
                Allow(false);
            }
        }

        private void Thêm_Click(object sender, EventArgs e)
        {           
            status = ThamSo.Controll.Addnew;          
            this.Allow(true);
            DataRow row = TKctrl.NewRow();
            row["MaTaiKhoan"] = "";
            row["TenTaiKhoan"] = "";
            row["MaNV"] ="";
            row["MaCap"] = "";

            TKctrl.Add(row);
            bindingNavigatorTK.BindingSource.MoveLast();
            txtMaTaiKhoan.Focus();            

        }

        private void Xoá_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Tai Khoan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTK.BindingSource.RemoveCurrent();
                TKctrl.Save();
            }
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            txtMaTaiKhoan.Focus();
            bindingNavigatorTK.BindingSource.MoveNext();            
            KiemTra();
            if (status == ThamSo.Controll.noreally)
            {
                MessageBox.Show("Thông tin còn thiếu nên tài khoản không được lưu", "Tai Khoan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TKctrl.Save();
                Allow(false);
            }
            status = ThamSo.Controll.Save;

        }

        void Allow(bool val)
        {
            txtMaTaiKhoan.Enabled = val;
            txtTenTaiKhoan.Enabled = val;          
            cmbMaNV.Enabled = val;
            cmbMaCap.Enabled = val;
        }

        void Luu()
        {
            if (status == ThamSo.Controll.Addnew)
            {
                ThemMoi();
            }
            else
            {
                CapNhat();
            }
        }

        void CapNhat()
        {
            TKctrl.Update();
        }

        void ThemMoi()
        {
            DataRow row = TKctrl.NewRow();
            row["MaTaiKhoan"] = "";
            row["TenTaiKhoan"] = "";
            row["MaNV"] = "";
            row["MaCap"] = "";

            TKctrl.Add(row);
            TaiKhoanController ctrltk= new TaiKhoanController();
            if (ctrltk.LayTaiKhoan(txtMaTaiKhoan.Text) != null)
            {
                MessageBox.Show("Mã tài khoản này đã tồn tại !", "Tai Khoan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        void KiemTra()
        {
            if (txtMaTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản !", "Tai Khoan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản !", "Tai Khoan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaNV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại đối tác !", "Tai Khoan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã cấp!", "Tai Khoan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaTaiKhoan.Text == "" || txtTenTaiKhoan.Text == "" || cmbMaNV.SelectedValue == null || cmbMaCap.SelectedValue == null)
            {
                status = ThamSo.Controll.noreally;

            }

        }


        private void ToolTimMaTaiKhoan_Click(object sender, EventArgs e)
        {
            ToolTimTenTaiKhoan.Checked = false;
            ToolTimMaTaiKhoan.Checked = true;
            if (Test())
                toolTimTaiKhoan.Text = "Mã Tài Khoản";
            bindingNavigatorTK.Focus();
        }

        private void ToolTimTenTaiKhoan_Click(object sender, EventArgs e)
        {
            ToolTimTenTaiKhoan.Checked = true;
            ToolTimMaTaiKhoan.Checked = false;
            if (Test())
                toolTimTaiKhoan.Text = "Tên Tài Khoản";
            bindingNavigatorTK.Focus();
        }

        private void toolTimTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaTaiKhoan.Checked == true)
                    toolTimTaiKhoan.Text = "Mã Tài Khoản";

                toolTimTaiKhoan.Text = "Tên Tài Khoản";
            }
        }

        private void toolTimTaiKhoan_Enter(object sender, EventArgs e)
        {
            toolTimTaiKhoan.Text = "";
            toolTimTaiKhoan.ForeColor = Color.Black;
        }

        private void toolTimTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaTaiKhoan.Checked)
                    TKctrl.TimMaTaiKhoan(toolTimTaiKhoan.Text);
                else
                    TKctrl.TimTenTaiKhoan(toolTimTaiKhoan.Text);
            }
        }

        private void tooTKtripTimKiem_Click(object sender, EventArgs e)
        {
            if (ToolTimMaTaiKhoan.Checked)
                TKctrl.TimMaTaiKhoan(toolTimTaiKhoan.Text);
            else
                TKctrl.TimTenTaiKhoan(toolTimTaiKhoan.Text);
        }

        private void tooTKtripButton6_Click(object sender, EventArgs e)
        {
            TKctrl.HienThiCombobox(cmbMaNV);
            TKctrl.HienThiDataGridView(dataGridViewTK, bindingNavigatorTK, txtMaTaiKhoan, txtTenTaiKhoan, cmbMaNV,cmbMaCap);
        }

        private void tooTKtripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimTaiKhoan.Text;
            if (str == "Mã lãi suất" || str == "Tên lãi suất")
                return true;
            return false;
        }

        private void toolStripTimKiem_Click(object sender, EventArgs e)
        {
            if (ToolTimMaTaiKhoan.Checked)
                TKctrl.TimMaTaiKhoan(toolTimTaiKhoan.Text);
            else
                TKctrl.TimTenTaiKhoan(toolTimTaiKhoan.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMaCap_Click(object sender, EventArgs e)
        {
            frmKeToanDo ktd = new frmKeToanDo();
            ktd.ShowDialog();

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            NVctrol.HienThiCombobox(cmbMaNV);
            KTDctrl.HienThiCombobox(cmbMaCap);
            TKctrl.HienThiDataGridView(dataGridViewTK, bindingNavigatorTK, txtMaTaiKhoan, txtTenTaiKhoan, cmbMaNV, cmbMaCap);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolSua_Click(object sender, EventArgs e)
        {
            status = ThamSo.Controll.Edit;
            this.Allow(true);
        }
    }
}