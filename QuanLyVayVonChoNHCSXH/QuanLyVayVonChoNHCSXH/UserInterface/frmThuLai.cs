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
    public partial class frmThuLai : Form
    {
        ThuLaiController TLctrl = new ThuLaiController();
        LoaiChungTuController LCTctrl = new LoaiChungTuController();
        TaiKhoanController TK1ctrl = new TaiKhoanController();
        TaiKhoanController TK2ctrl = new TaiKhoanController();
        HoSoKheUocController HSKUctrl = new HoSoKheUocController();
        ThamSo.Controll status = ThamSo.Controll.Normal;     
        public frmThuLai()

        {
            InitializeComponent();
            //BThamSo.Controll status = ThamSo.Controll.Addnew; 
        }

         public frmThuLai(ThuLaiController ctrltl)
            :this()
        {
            this.TLctrl= ctrltl;
            status= ThamSo.Controll.Normal;
        }

        private void frmThuNoThulai_Load(object sender, EventArgs e)
        {
            LCTctrl.HienThiCombobox(cmbMaLoaiChungTu);
            HSKUctrl.HienThiCombobox(cmbMaSoKU);
            TK1ctrl.HienThiCombobox(cmbTaiKhoanCo);
            TK2ctrl.HienThiCombobox(cmbTaiKhoanNo);
           
            TLctrl.HienThiDataGridView(dataGridViewTL,bindingNavigatorTL,txtSoButToan,dtpNgayTL,dtpNgayTinhLai,cmbMaSoKU,txtSoTienLaiTH,numSoTienGoc,txtSoTienLaiQH,cmbMaLoaiChungTu,cmbTaiKhoanNo,cmbTaiKhoanCo);
            
            if (status == ThamSo.Controll.Addnew)
            {
                txtSoButToan.Text = ThamSo.LayMaTL().ToString();
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
            //ThamSo.SoButToan = sobuttoan + 1;
            this.Allow(true);
            DataRow row = TLctrl.NewRow();
            row["SoButToan"] = sobuttoan;
            row["NgayTL"] = dtpNgayTL.Value.Date;
            row["NgayTinhLai"] = dtpNgayTinhLai.Value.Date;
            row["MaSoKU"] = "";
            row["SoTienLaiTH"] = 0;
            row["SoTienGoc"] = 0;
            row["SoTienLaiQH"] = 0;
            row["MaLoaiChungTu"] = "LCT02";
            row["TaiKhoanNo"] = "";
            row["TaiKhoanCo"] = "";
            
            
            TLctrl.Add(row);
            bindingNavigatorTL.BindingSource.MoveLast();
            txtSoButToan.Focus();
         
        }

        private void Xoá_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thu Lai", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTL.BindingSource.RemoveCurrent();
                TLctrl.Save();
            }
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            txtSoButToan.Focus();
            bindingNavigatorTL.BindingSource.MoveNext();
            KiemTra();
            if (status == ThamSo.Controll.noreally)
            {
                MessageBox.Show("Thông tin còn thiếu nên thu lãi không được lưu", "Thu Lai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TLctrl.Save();
                Allow(false);
                long sobuttoan = ThamSo.SoButToan;
                ThamSo.SoButToan = sobuttoan + 1;
            }
            status = ThamSo.Controll.Save;
            HSKUctrl.Save();

            HoSoKheUocController HSctrol = new HoSoKheUocController();
            foreach (DataGridViewRow view in dataGridViewTL.Rows)
            {
                HSctrol.CapNhatNgayTinhLai(Convert.ToString(view.Cells["MaSoKU"].Value), Convert.ToDateTime(view.Cells["NgayTL"].Value));

            }

        }

        void Allow(bool val)
        {
            txtSoButToan.Enabled = val;
            dtpNgayTL.Enabled = val;
            dtpNgayTinhLai.Enabled = val;
            cmbMaSoKU.Enabled = val;
            txtSoTienLaiTH.Enabled = val;
            numSoTienGoc.Enabled = val;
            txtSoTienLaiQH.Enabled = val;
            cmbMaLoaiChungTu.Enabled = val;
            cmbTaiKhoanNo.Enabled = val;
            cmbTaiKhoanCo.Enabled = val;
          
            
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
            TLctrl.Update();
        }

        void ThemMoi()
        {
            DataRow row = TLctrl.NewRow();
            row["MaTL"] = "";
            row["NgayTL"] = dtpNgayTL.Value.Date;
            row["NgayTinhLai"] = "01/01/1900";
            row["MaSoKU"] = "";
            row["SoTienLaiTH"] = 0;
            row["SoTienGoc"] = 0;
            row["SoTienLaiQH"] = 0;
            row["MaLoaiChungTu"] = "";
            row["TaiKhoanNo"] = cmbTaiKhoanNo.SelectedValue;
            row["TaiKhoanCo"] = cmbTaiKhoanNo.SelectedValue;
            

            TLctrl.Add(row);
            ThuLaiController ctrlThuLai= new ThuLaiController();
            if (ctrlThuLai.LayThuLai(txtSoButToan.Text) != null)
            {
                MessageBox.Show("Mã thu lãi này đã tồn tại !", "Thu Lai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ThamSo.LaSoNguyen(txtSoButToan.Text))
            {
                long so = Convert.ToInt64(txtSoButToan.Text);
                if (so >= ThamSo.LayMaTL())
                {
                    ThamSo.GanMaTNTL(so + 1);
                }
            }

        }

        void KiemTra()
        {
            if (txtSoButToan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã thu vốn !", "Thu Lai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            else if (cmbMaSoKU.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã số khế ước!", "Thu Lai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpNgayTinhLai.Value>=dtpNgayTL.Value)
            {
                MessageBox.Show("Ngày thu lãi phải sao ngày tính lãi!", "Thu Lai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSoTienLaiTH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền lãi trong hạn!", "Thu Lai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numSoTienGoc.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền gốc !", "Thu Lai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else if (cmbMaLoaiChungTu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại loại chứng từ!", "Thu Lai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTaiKhoanNo.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản nợ!", "Thu Lai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTaiKhoanCo.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản có!", "Thu Lai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSoButToan.Text == "" || cmbMaSoKU.SelectedValue == null || txtSoTienLaiTH.Text == "" || numSoTienGoc.Value == 0 || 
            cmbMaLoaiChungTu.SelectedValue == null || cmbTaiKhoanNo.SelectedValue == null || cmbTaiKhoanCo.SelectedValue == null )
            {
                status = ThamSo.Controll.noreally;

            }

        }


       

        private void ToolMaSoKU_Click(object sender, EventArgs e)
        {
            ToolTimMaTL.Checked = false;
            ToolTimMaSoKU.Checked = true;
            if (Test())
                toolTimThuLai.Text = "Mã Số Khế Ước";
            bindingNavigatorTL.Focus();
        }
                 

      
        private void Tìm_Click(object sender, EventArgs e)
        {
            if (ToolTimMaTL.Checked)
                TLctrl.TimMaThuLai(dataGridViewTL, bindingNavigatorTL, txtSoButToan, dtpNgayTL,dtpNgayTinhLai, cmbMaSoKU, txtSoTienLaiTH, numSoTienGoc, txtSoTienLaiQH, cmbMaLoaiChungTu, cmbTaiKhoanNo, cmbTaiKhoanCo, toolTimThuLai.Text.Trim());
            else
                TLctrl.TimMaSoKUThuLai(dataGridViewTL, bindingNavigatorTL, txtSoButToan, dtpNgayTL,dtpNgayTinhLai, cmbMaSoKU, txtSoTienLaiTH, numSoTienGoc, txtSoTienLaiQH, cmbMaLoaiChungTu, cmbTaiKhoanNo, cmbTaiKhoanCo, toolTimThuLai.Text.Trim());
        }

        private void XemLai_Click(object sender, EventArgs e)
        {
            LCTctrl.HienThiCombobox(cmbMaLoaiChungTu);
            HSKUctrl.HienThiCombobox(cmbMaSoKU);
            TK1ctrl.HienThiCombobox(cmbTaiKhoanCo);
            TK2ctrl.HienThiCombobox(cmbTaiKhoanNo);
            TLctrl.HienThiDataGridView(dataGridViewTL, bindingNavigatorTL, txtSoButToan, dtpNgayTL, dtpNgayTinhLai,cmbMaSoKU, txtSoTienLaiTH, numSoTienGoc, txtSoTienLaiQH, cmbMaLoaiChungTu, cmbTaiKhoanNo, cmbTaiKhoanCo);
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimThuLai.Text;
            if (str == "Mã thu lãi" || str == "Mã thu lãi")
                return true;
            return false;
        }

       
        private void dataGridViewTNTL_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void ToolTimMaTV_Click_1(object sender, EventArgs e)
        {
            ToolTimMaTL.Checked = true;
            ToolTimMaSoKU.Checked = false;
            if (Test())
                toolTimThuLai.Text = "Mã Thu Lãi";
            bindingNavigatorTL.Focus();
        }

       

      

       

        private void toolTimThuLai_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaTL.Checked == true)
                    toolTimThuLai.Text = "Mã Thu Vốn";
                else
                    toolTimThuLai.Text = "Mã Số Khế Ước";
            }
        }

        private void toolTimThuLai_Enter(object sender, EventArgs e)
        {
            toolTimThuLai.Text = "";
            toolTimThuLai.ForeColor = Color.Black;
        }

        private void toolTimThuLai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaTL.Checked)
                    TLctrl.TimMaThuLai(dataGridViewTL, bindingNavigatorTL, txtSoButToan, dtpNgayTL,dtpNgayTinhLai, cmbMaSoKU, txtSoTienLaiTH, numSoTienGoc, txtSoTienLaiQH, cmbMaLoaiChungTu, cmbTaiKhoanNo, cmbTaiKhoanCo, toolTimThuLai.Text.Trim());
                else
                    TLctrl.TimMaSoKUThuLai(dataGridViewTL, bindingNavigatorTL, txtSoButToan, dtpNgayTL,dtpNgayTinhLai ,cmbMaSoKU, txtSoTienLaiTH, numSoTienGoc, txtSoTienLaiQH, cmbMaLoaiChungTu, cmbTaiKhoanNo, cmbTaiKhoanCo, toolTimThuLai.Text.Trim());
            }
        }

        private void btnThemMaSoKU_Click(object sender, EventArgs e)
        {
            frmHoSoKheUoc hsku = new frmHoSoKheUoc();
            hsku.ShowDialog();
        }

        private void btnThemLoaiCT_Click(object sender, EventArgs e)
        {
            frmLoaiChungTu LCT = new frmLoaiChungTu();
            LCT.ShowDialog();
        }

        private void btnThemTKNo_Click(object sender, EventArgs e)
        {
            frmTaiKhoan TK = new frmTaiKhoan();
            TK.ShowDialog();
        }

        private void btnThemTKCo_Click(object sender, EventArgs e)
        {
            frmTaiKhoan TK1 = new frmTaiKhoan();
            TK1.ShowDialog();
        }

        private void cmbMaSoKU_SelectedValueChanged_1(object sender, EventArgs e)
        {
            String s_MaSoKU = Convert.ToString(cmbMaSoKU.SelectedValue).Trim();
            TK1ctrl.HienThiComboboxTheoMaKheuocTL(txtSoTienLaiQH, txtSoTienLaiTH,dtpNgayTinhLai, numSoTienGoc, cmbTaiKhoanNo, cmbTaiKhoanCo, s_MaSoKU);
            //TK1ctrl.HienThiComboboxTheoMaKheuoc(txtSoTienLaiTH, txtSoTienLaiQH, s_MaSoKU);
            //double tong = TLctrl.TinhLai(s_MaSoKU);
            //MessageBox.Show(Convert.ToString(tong));
            //ThuLaiController tl = new ThuLaiController();
            //double tinhlai = tl.TinhLai(s_MaSoKU);
            //txtSoTienLaiTH.Value = Convert.ToInt64(tinhlai);
        }

        private void toolSua_Click(object sender, EventArgs e)
        {
            status = ThamSo.Controll.Edit;
            this.Allow(true);
        }

     


        //private void numSoTienLai_ValueChanged(object sender, EventArgs e)
        //{
        //    numSoTienLai.Value = numSoTienGoc.Value - numSoTien.Value;
        //}

       
    }
}