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
    public partial class frmGiaiNgan : Form
    {
        GiaiNganController GNctrl=new GiaiNganController();
        HoSoKheUocController HSKUctrl=new HoSoKheUocController();
        TaiKhoanController TKctrl=new TaiKhoanController();
        TaiKhoanController TKctrlNo = new TaiKhoanController();
        TaiKhoanController TKctrlCo = new TaiKhoanController();
        LoaiChungTuController LCTctrl = new LoaiChungTuController();

        ThamSo.Controll status = ThamSo.Controll.Normal;     

        public frmGiaiNgan()
        {
            InitializeComponent();
            //ThamSo.Controll status = ThamSo.Controll.Addnew;  
        }

        public frmGiaiNgan(GiaiNganController ctrlgn)
            :this()
        {
            this.GNctrl = ctrlgn;
            status= ThamSo.Controll.Normal;
        }                  

        private void frmGiaiNgan_Load(object sender, EventArgs e)
        {
            HSKUctrl.HienThiCombobox(cmbMaSoKU);
            TKctrl.HienThiCombobox(cmbSoTaiKhoan);
            LCTctrl.HienThiCombobox(cmbLoaiCT);
            TKctrlNo.HienThiCombobox(cmbTKNo);
            TKctrlCo.HienThiCombobox(cmbTKCo);
            GNctrl.HienThiDataGridView(dataGridViewGN, bindingNavigatorGN,txtSbt,dtpNgayGiaiNgan,cmbMaSoKU, cmbSoTaiKhoan, numSoTienGN, numConLai,
                numDuocPhep, cmbLoaiCT, cmbTKNo, cmbTKCo);
          
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
            long sobuttoan = ThamSo.SoButToan;   
            this.Allow(true);
            DataRow row = GNctrl.NewRow();
            row["SoButToan"] =sobuttoan;            
            row["NgayGiaiNgan"] = dtpNgayGiaiNgan.Value.Date;                        
            row["MaSoKU"] = cmbMaSoKU.SelectedValue;
            row["SoTaiKhoan"] = cmbSoTaiKhoan.SelectedValue;            
            row["SoTienGiaiNgan"] = 0;           
            row["DuocPhep"] = 0;             
            row["ConLai"] =0; 
            row["MaLoaiChungTu"] = "LCT01";
            row["TaiKhoanNo"] = cmbTKNo.SelectedValue;
            row["TaiKhoanCo"] = "101101.0001";
             
            GNctrl.Add(row);
            bindingNavigatorGN.BindingSource.MoveLast();
            txtSbt.Focus();          
        }

        private void Xoá_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Giai Ngan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorGN.BindingSource.RemoveCurrent();
                GNctrl.Save();
            }
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            txtSbt.Focus();
             bindingNavigatorGN.BindingSource.MoveNext();
            KiemTra();
            
            if (status == ThamSo.Controll.noreally)
            {
                MessageBox.Show("Thông tin còn thiếu nên giải ngân không được lưu", "Giai Ngan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GNctrl.Save();
                Allow(false);
                long sobuttoan = ThamSo.SoButToan;
                ThamSo.SoButToan = sobuttoan + 1;
            }

            status = ThamSo.Controll.Save;
            HSKUctrl.Save();

            HoSoKheUocController HSctrol= new HoSoKheUocController();
            foreach (DataGridViewRow view in dataGridViewGN.Rows)
            {
                HSctrol.CapNhatSoTienHienTai( Convert.ToString(view.Cells["MaSoKU"].Value),Convert.ToInt64(view.Cells["ConLai"].Value));

            }
            
        }

        void Allow(bool val)
        {
            txtSbt.Enabled = val;
            dtpNgayGiaiNgan.Enabled = val;
            cmbMaSoKU.Enabled = val;
            cmbSoTaiKhoan.Enabled = val;
            numSoTienGN.Enabled = val;
            numDuocPhep.Enabled = val;
            numConLai.Enabled = val;
           // cmbLoaiCT.Enabled = val;
            cmbTKNo.Enabled = val;
            cmbTKCo.Enabled = val;
            
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
            GNctrl.Update();
        }

        void ThemMoi()
        {
            DataRow row = GNctrl.NewRow();
            row["SoButToan"] = txtSbt.Text;
            row["NgayGiaiNgan"] = dtpNgayGiaiNgan.Value.Date;
            row["MaSoKU"] = cmbMaSoKU.SelectedValue;
            row["SoTaiKhoan"] = cmbSoTaiKhoan.SelectedValue;
            row["SoTienGiaiNgan"] = 0;
            row["DuocPhep"] = 0;
            row["ConLai"] = 0;
            row["MaLoaiChungTu"] = cmbLoaiCT.SelectedValue;
            row["TaiKhoanNo"] = cmbTKNo.SelectedValue;
            row["TaiKhoanCo"] = "101101.0001";

            GNctrl.Add(row);

        }

        void KiemTra()
        {
            if (txtSbt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số bút toán !", "Giai Ngan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                       
            else if (cmbMaSoKU.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã số khế ước !", "Giai Ngan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbSoTaiKhoan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn số tài khoản !", "Giai Ngan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numSoTienGN.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền giải ngân !", "Giai Ngan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numDuocPhep.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền được phép!", "Giai Ngan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numConLai.Value == 0)
            {
                MessageBox.Show("Đã giải ngân hết !", "Giai Ngan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbLoaiCT.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại chứng từ!", "Giai Ngan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTKNo.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản nợ !", "Giai Ngan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTKCo.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản có!", "Giai Ngan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

            if (txtSbt.Text == "" || cmbMaSoKU.SelectedValue == null || cmbSoTaiKhoan.SelectedValue == null || numSoTienGN.Value == 0 ||
            numDuocPhep.Value == 0 || numConLai.Value == 0 || cmbLoaiCT.SelectedValue == null || cmbTKNo.SelectedValue == null || cmbTKCo.SelectedValue == null)
            {
                status = ThamSo.Controll.noreally;

            }
        }

        private void tooltimtheomasoku_Click(object sender, EventArgs e)
        {
            tooltimtheomasoku.Checked = true;
            tooltimtheosobuttoan.Checked = false;

            if (Test())
                ToolTimGiaiNgan.Text = "Mã số khế ước";
            bindingNavigatorGN.Focus();
        }

        private void tooltimtheosobuttoan_Click(object sender, EventArgs e)
        {
            tooltimtheomasoku.Checked = false;
            tooltimtheosobuttoan.Checked = true;

            if (Test())
                ToolTimGiaiNgan.Text = "Số bút toán";
            bindingNavigatorGN.Focus();
        }

        private void ToolTimGiaiNgan_Enter(object sender, EventArgs e)
        {
            ToolTimGiaiNgan.Text = "";
            ToolTimGiaiNgan.ForeColor = Color.Black;
        }

        private void ToolTimGiaiNgan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tooltimtheomasoku.Checked)
                    GNctrl.TimMaKheUoc(dataGridViewGN, bindingNavigatorGN, txtSbt, dtpNgayGiaiNgan, cmbMaSoKU, cmbSoTaiKhoan, numSoTienGN, numConLai,
                numDuocPhep, cmbLoaiCT, cmbTKNo, cmbTKCo,ToolTimGiaiNgan.Text.Trim());              
                else
                    GNctrl.TimSoButToan(dataGridViewGN, bindingNavigatorGN, txtSbt, dtpNgayGiaiNgan, cmbMaSoKU, cmbSoTaiKhoan, numSoTienGN, numConLai,
                numDuocPhep, cmbLoaiCT, cmbTKNo, cmbTKCo,ToolTimGiaiNgan.Text.Trim());
            }
        }

        private void ToolTimGiaiNgan_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (tooltimtheomasoku.Checked == true)
                    ToolTimGiaiNgan.Text = "Mã số khế ước";
                else
                    ToolTimGiaiNgan.Text = "Số bút toán";
            }
        }

        public bool Test()
        {
            String str = ToolTimGiaiNgan.Text;
            if (str == "Mã khế ước" || str == "Số bút toán")
                return true;
            return false;
        }

        private void btnThemKU_Click(object sender, EventArgs e)
        {
            frmHoSoKheUoc HSKU = new frmHoSoKheUoc();
            HSKU.ShowDialog();
        }

        private void btnThemLoaiChungTu_Click(object sender, EventArgs e)
        {
            frmLoaiChungTu LCT = new frmLoaiChungTu();
            LCT.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (tooltimtheomasoku.Checked)
                GNctrl.TimMaKheUoc(dataGridViewGN, bindingNavigatorGN, txtSbt, dtpNgayGiaiNgan, cmbMaSoKU, cmbSoTaiKhoan, numSoTienGN, numConLai,
            numDuocPhep, cmbLoaiCT, cmbTKNo, cmbTKCo, ToolTimGiaiNgan.Text.Trim());
            else
                GNctrl.TimSoButToan(dataGridViewGN, bindingNavigatorGN, txtSbt, dtpNgayGiaiNgan, cmbMaSoKU, cmbSoTaiKhoan, numSoTienGN, numConLai,
            numDuocPhep, cmbLoaiCT, cmbTKNo, cmbTKCo, ToolTimGiaiNgan.Text.Trim());
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn thoát không!", "Giai Ngan", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTaiKhoan tk = new frmTaiKhoan();
            tk.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTaiKhoan tk = new frmTaiKhoan();
            tk.ShowDialog();
        }

        private void toolSua_Click(object sender, EventArgs e)
        {
            status = ThamSo.Controll.Edit;
            this.Allow(true);
        }

        private void XemLai_Click(object sender, EventArgs e)
        {
            HSKUctrl.HienThiCombobox(cmbMaSoKU);
            TKctrl.HienThiCombobox(cmbSoTaiKhoan);
            LCTctrl.HienThiCombobox(cmbLoaiCT);
            TKctrlNo.HienThiCombobox(cmbTKNo);
            TKctrlCo.HienThiCombobox(cmbTKCo);
            GNctrl.HienThiDataGridView(dataGridViewGN, bindingNavigatorGN, txtSbt, dtpNgayGiaiNgan, cmbMaSoKU, cmbSoTaiKhoan, numSoTienGN, numConLai,
                numDuocPhep, cmbLoaiCT, cmbTKNo, cmbTKCo);
        }

        private void btnThemSoTK_Click(object sender, EventArgs e)
        {
            frmTaiKhoan tk = new frmTaiKhoan();
            tk.ShowDialog();
        }

        private void dataGridViewGN_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void cmbMaSoKU_SelectedValueChanged(object sender, EventArgs e)
        {
            String s_MaSoKU = Convert.ToString(cmbMaSoKU.SelectedValue).Trim();
            TKctrl.HienThiComboboxTheoMaKheuoc(numConLai, numDuocPhep,cmbSoTaiKhoan,cmbTKNo, s_MaSoKU);
        }

        private void numSoTienGN_ValueChanged(object sender, EventArgs e)
        {
            numConLai.Value = numDuocPhep.Value - numSoTienGN.Value;
        }

       


        
    }
}