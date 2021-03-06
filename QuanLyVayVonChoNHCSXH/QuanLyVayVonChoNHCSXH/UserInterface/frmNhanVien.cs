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
    public partial class frmNhanVien : Form
    {
        NhanVienController NVctrl = new NhanVienController();
        ChucVuController CVctrl = new ChucVuController();
        PhongBanController PBctrl = new PhongBanController();
        ThamSo.Controll status = ThamSo.Controll.Normal;
        public frmNhanVien()
        {
            InitializeComponent();
           // ThamSo.Controll status = ThamSo.Controll.Addnew;
        }

        public frmNhanVien(NhanVienController ctrlnv)
            : this()
        {
            this.NVctrl = ctrlnv;
            status = ThamSo.Controll.Normal;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            CVctrl.HienThiCombobox(cmbMaChucVu);
            PBctrl.HienThiCombobox(cmbMaPhong);
            NVctrl.HienThiDataGridView(dataGridViewNV, bindingNavigatorNV, txtMaNV, txtHoTenNV, dtpNgaySinh, txtDiaChi, cmbMaPhong, cmbMaChucVu, txtGhiChu);
            if (status == ThamSo.Controll.Addnew)
            {              
                Allow(true);
            }
            else
            {
                Allow(false);
            }
        }

        private void toolThem_Click(object sender, EventArgs e)
        {
            status = ThamSo.Controll.Addnew;            
            this.Allow(true);
            DataRow row = NVctrl.NewRow();
            row["MaNV"] = "";
            row["HoTenNV"] = "";
            row["NgaySinh"] = "01/01/1900";
            row["DiaChi"] = "";
            row["MaPhongBan"] = "";
            row["MaChucVu"] = "";
            row["GhiChu"] = "";
            NVctrl.Add(row);
            bindingNavigatorNV.BindingSource.MoveLast();
            txtMaNV.Focus();

        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Nhan Vien", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNV.BindingSource.RemoveCurrent();
                NVctrl.Save();
            }
        }

        private void toolLuu_Click(object sender, EventArgs e)
        {
            txtMaNV.Focus();
            bindingNavigatorNV.BindingSource.MoveNext();
            KiemTra();
           // KiemTraMa();
            if (status == ThamSo.Controll.noreally)
            {
                MessageBox.Show("Thông tin còn thiếu nên nhân viên không được lưu", "Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NVctrl.Save();
                Allow(false);
            }
            status = ThamSo.Controll.Save;


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
            NVctrl.Update();
        }

        void ThemMoi()
        {
            DataRow row = NVctrl.NewRow();
            row["MaNV"] = "";
            row["HoTenNV"] = "";
            row["NgaySinh"] = "01/01/1900";
            row["DiaChi"] = "";
            row["MaPhongBan"] = "";
            row["MaChucVu"] = "";
            row["GhiChu"] = "";

            NVctrl.Add(row);           
        }


        void KiemTra()
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên !", "Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtHoTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên nhân viên!", "Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã phòng !", "Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaChucVu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã chức vụ", "Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                     

            if (txtMaNV.Text == "" || txtHoTenNV.Text == "" || txtDiaChi.Text == "" || cmbMaPhong.SelectedValue == null || cmbMaChucVu == null)
            {
                status = ThamSo.Controll.noreally;

            }                       
        }



        //public void KiemTraMa()
        //{            
        //        foreach (DataGridViewRow view in dataGridViewNV.Rows)
        //        {

        //            if (txtMaNV.Text.Trim().Equals(view.Cells["MaNV"].Value))
        //            {
        //                status = ThamSo.Controll.like;
                        
        //            }
        //        }
            
        //    if (status == ThamSo.Controll.like)
        //    {
        //        MessageBox.Show("Mã nhân viên này đã tồn tại trong danh sách! Vui lòng bạn nhấn nút Sửa để đưa thông tin vào cho đúng !", "Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
            
        //}



        private void tooltimtheomanv_Click(object sender, EventArgs e)
        {
            ToolTimTenNhanVien.Checked = false;

            ToolTimMaChucVu.Checked = false;
            ToolTimMaPhongBan.Checked = false;
            ToolTimMaNhanVien.Checked = true;
            if (Test())
                toolTimNhanVien.Text = "Mã Nhân Viên";
            bindingNavigatorNV.Focus();
        }

        private void tooltimtheohotennv_Click(object sender, EventArgs e)
        {
            ToolTimTenNhanVien.Checked = true;
            ToolTimMaNhanVien.Checked = false;
            ToolTimMaChucVu.Checked = false;
            ToolTimMaPhongBan.Checked = false;
            if (Test())
                toolTimNhanVien.Text = "Tên Nhân Viên";
            bindingNavigatorNV.Focus();
        }

        private void tooltimtheomaphong_Click(object sender, EventArgs e)
        {
            ToolTimTenNhanVien.Checked = false;
            ToolTimMaNhanVien.Checked = false;
            ToolTimMaChucVu.Checked = false;
            ToolTimMaPhongBan.Checked = true;
            if (Test())
                toolTimNhanVien.Text = "Mã Phòng Ban";
            bindingNavigatorNV.Focus();
        }

        private void tooltimtheomachucvu_Click(object sender, EventArgs e)
        {
            ToolTimTenNhanVien.Checked = false;
            ToolTimMaNhanVien.Checked = false;
            ToolTimMaChucVu.Checked = true;
            ToolTimMaPhongBan.Checked = false;
            if (Test())
                toolTimNhanVien.Text = "Mã Chức Vụ";
            bindingNavigatorNV.Focus();
        }

        private void toolTimNhanVien_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaNhanVien.Checked == true)
                    toolTimNhanVien.Text = "Mã Nhân Viên";
                else
                    if (ToolTimTenNhanVien.Checked == true)
                        toolTimNhanVien.Text = "Tên Nhân Viên";
                    else
                        if (ToolTimMaPhongBan.Checked == true)
                            toolTimNhanVien.Text = "Mã Phòng Ban";
                        else
                            toolTimNhanVien.Text = "Mã Chức Vụ";
            }
        }

        private void toolTimNhanVien_Enter(object sender, EventArgs e)
        {
            toolTimNhanVien.Text = "";
            toolTimNhanVien.ForeColor = Color.Black;
        }

        private void toolTimNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaNhanVien.Checked)
                    NVctrl.TimMaNhanVien(dataGridViewNV, bindingNavigatorNV, txtMaNV, txtHoTenNV, dtpNgaySinh, txtDiaChi, cmbMaPhong, cmbMaChucVu, txtGhiChu, toolTimNhanVien.Text.Trim());
                else
                    if (ToolTimTenNhanVien.Checked)
                        NVctrl.TimTenNhanVien(dataGridViewNV, bindingNavigatorNV, txtMaNV, txtHoTenNV, dtpNgaySinh, txtDiaChi, cmbMaPhong, cmbMaChucVu, txtGhiChu, toolTimNhanVien.Text.Trim());
                    else
                        if (ToolTimMaPhongBan.Checked)
                            NVctrl.TimMaPhongBan(dataGridViewNV, bindingNavigatorNV, txtMaNV, txtHoTenNV, dtpNgaySinh, txtDiaChi, cmbMaPhong, cmbMaChucVu, txtGhiChu, toolTimNhanVien.Text.Trim());
                        else
                            NVctrl.TimMaChucVu(dataGridViewNV, bindingNavigatorNV, txtMaNV, txtHoTenNV, dtpNgaySinh, txtDiaChi, cmbMaPhong, cmbMaChucVu, txtGhiChu, toolTimNhanVien.Text.Trim());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ToolTimMaNhanVien.Checked)
                NVctrl.TimMaNhanVien(dataGridViewNV, bindingNavigatorNV, txtMaNV, txtHoTenNV, dtpNgaySinh, txtDiaChi, cmbMaPhong, cmbMaChucVu, txtGhiChu, toolTimNhanVien.Text.Trim());
            else
                if (ToolTimTenNhanVien.Checked)
                    NVctrl.TimTenNhanVien(dataGridViewNV, bindingNavigatorNV, txtMaNV, txtHoTenNV, dtpNgaySinh, txtDiaChi, cmbMaPhong, cmbMaChucVu, txtGhiChu, toolTimNhanVien.Text.Trim());
                else
                    if (ToolTimMaPhongBan.Checked)
                        NVctrl.TimMaPhongBan(dataGridViewNV, bindingNavigatorNV, txtMaNV, txtHoTenNV, dtpNgaySinh, txtDiaChi, cmbMaPhong, cmbMaChucVu, txtGhiChu, toolTimNhanVien.Text.Trim());
                    else
                        NVctrl.TimMaChucVu(dataGridViewNV, bindingNavigatorNV, txtMaNV, txtHoTenNV, dtpNgaySinh, txtDiaChi, cmbMaPhong, cmbMaChucVu, txtGhiChu, toolTimNhanVien.Text.Trim());
        }

        private void toolXemlai_Click(object sender, EventArgs e)
        {
            CVctrl.HienThiCombobox(cmbMaChucVu);
            PBctrl.HienThiCombobox(cmbMaPhong);
            NVctrl.HienThiDataGridView(dataGridViewNV, bindingNavigatorNV, txtMaNV, txtHoTenNV, dtpNgaySinh, txtDiaChi, cmbMaPhong, cmbMaChucVu, txtGhiChu);
        }

        private void toolThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn thoát không!", "Nhan Vien", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        public bool Test()
        {
            String str = toolTimNhanVien.Text;
            if (str == "Mã nhân viên" || str == "Tên nhân viên" || str == "Mã phòng ban" || str == "Mã chức vụ")
                return true;
            return false;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            frmPhongBan PB = new frmPhongBan();
            PB.ShowDialog();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu CV = new frmChucVu();
            CV.ShowDialog();
        }

        private void toolSua_Click(object sender, EventArgs e)
        {
            status = ThamSo.Controll.Edit;
            this.Allow(true);
        }


        void Allow(bool val)
        {

            txtMaNV.Enabled = val;
            txtHoTenNV.Enabled = val;
            dtpNgaySinh.Enabled = val;
            txtDiaChi.Enabled = val;
            cmbMaChucVu.Enabled = val;
            cmbMaPhong.Enabled = val;
            txtGhiChu.Enabled = val;

        }

        private void dataGridViewNV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridViewNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}