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
    public partial class frmThuVon : Form
    {
        ThuVonController TVctrl = new ThuVonController();
        LoaiChungTuController LCTctrl = new LoaiChungTuController();
        TaiKhoanController TK1ctrl = new TaiKhoanController();
        TaiKhoanController TK2ctrl = new TaiKhoanController();
        HoSoKheUocController HSKUctrl = new HoSoKheUocController();
        ThamSo.Controll status = ThamSo.Controll.Normal;     
        public frmThuVon()

        {
            InitializeComponent();
            //ThamSo.Controll status = ThamSo.Controll.Addnew; 
        }

         public frmThuVon(ThuVonController ctrltv)
            :this()
        {
            this.TVctrl= ctrltv;
            status= ThamSo.Controll.Normal;
        }

        private void frmThuNoThulai_Load(object sender, EventArgs e)
        {
            LCTctrl.HienThiCombobox(cmbMaLoaiChungTu);
            HSKUctrl.HienThiCombobox(cmbMaSoKU);
            TK1ctrl.HienThiCombobox(cmbTaiKhoanCo);
            TK2ctrl.HienThiCombobox(cmbTaiKhoanNo);
            TVctrl.HienThiDataGridView(dataGridViewTV,bindingNavigatorTV,txtSoButToan,dtpNgayTV,cmbMaSoKU,numSoTienThu,numSoTienGoc,numSoTienConLai,cmbMaLoaiChungTu,cmbTaiKhoanNo,cmbTaiKhoanCo);
            if (status == ThamSo.Controll.Addnew)
            {
                txtSoButToan.Text = ThamSo.LayMaTV().ToString();
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
            DataRow row = TVctrl.NewRow();
            row["SoButToan"] = sobuttoan;
            row["NgayTV"] = dtpNgayTV.Value.Date;
            row["MaSoKU"] = "";
            row["SoTienThu"] = 0;
            row["SoTienGoc"] = 0;
            row["SoTienConLai"] = 0;
            row["MaLoaiChungTu"] = "LCT02";
            row["TaiKhoanNo"] = null;
            row["TaiKhoanCo"] = null;
            
            
            TVctrl.Add(row);
            bindingNavigatorTV.BindingSource.MoveLast();
            txtSoButToan.Focus();
         
        }

        private void Xoá_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thu No Thu Lai", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTV.BindingSource.RemoveCurrent();
                TVctrl.Save();
            }
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            txtSoButToan.Focus();
            bindingNavigatorTV.BindingSource.MoveNext();
            KiemTra();
            if (status == ThamSo.Controll.noreally)
            {
                MessageBox.Show("Thông tin còn thiếu nên thu nợ thu lãi không được lưu", "Thu No Thu Lai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TVctrl.Save();
                Allow(false);
                long sobuttoan = ThamSo.SoButToan;
                ThamSo.SoButToan = sobuttoan + 1;
            }
            status = ThamSo.Controll.Save;
            

        }

        void Allow(bool val)
        {
            txtSoButToan.Enabled = val;
            dtpNgayTV.Enabled = val;
            cmbMaSoKU.Enabled = val;
            numSoTienThu.Enabled = val;
            numSoTienGoc.Enabled = val;
            numSoTienConLai.Enabled = val;
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
            TVctrl.Update();
        }

        void ThemMoi()
        {
            DataRow row = TVctrl.NewRow();
            row["MaTV"] = "";
            row["NgayTV"] = dtpNgayTV.Value.Date;
            row["MaSoKU"] = "";
            row["SoTienThu"] = 0;
            row["SoTienGoc"] = 0;
            row["SoTienConLai"] = 0;
            row["MaLoaiChungTu"] = "LCT02";
            row["TaiKhoanNo"] = null;
            row["TaiKhoanCo"] = null;
            

            TVctrl.Add(row);
            ThuVonController ctrlthuvon= new ThuVonController();
            if (ctrlthuvon.LayThuVon(txtSoButToan.Text) != null)
            {
                MessageBox.Show("Mã thu vốn này đã tồn tại !", "Thu Von", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ThamSo.LaSoNguyen(txtSoButToan.Text))
            {
                long so = Convert.ToInt64(txtSoButToan.Text);
                if (so >= ThamSo.LayMaTV())
                {
                    ThamSo.GanMaTNTL(so + 1);
                }
            }

        }

        void KiemTra()
        {
            if (txtSoButToan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã thu vốn !", "Thu Von", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            else if (cmbMaSoKU.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã số khế ước!", "Thu Von", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numSoTienThu.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền thu!", "Thu Von", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numSoTienGoc.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền gốc !", "Thu Von", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numSoTienConLai.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền còn lại!", "Thu Von", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaLoaiChungTu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại loại chứng từ!", "Thu Von", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTaiKhoanNo.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản nợ!", "Thu Von", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTaiKhoanCo.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản có!", "Thu Von", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSoButToan.Text == "" || cmbMaSoKU.SelectedValue == null || numSoTienThu.Value == 0 || numSoTienGoc.Value == 0 || numSoTienConLai.Value == 0 ||
            cmbMaLoaiChungTu.SelectedValue == null || cmbTaiKhoanNo.SelectedValue == null || cmbTaiKhoanCo.SelectedValue == null )
            {
                status = ThamSo.Controll.noreally;

            }

        }


       

        private void ToolMaSoKU_Click(object sender, EventArgs e)
        {
            ToolTimMaTV.Checked = false;
            ToolTimMaSoKU.Checked = true;
            if (Test())
                toolTimThuVon.Text = "Mã Số Khế Ước";
            bindingNavigatorTV.Focus();
        }

       

       

      

        private void Tìm_Click(object sender, EventArgs e)
        {
            if (ToolTimMaTV.Checked)
                TVctrl.TimMaThuVon(dataGridViewTV, bindingNavigatorTV, txtSoButToan, dtpNgayTV, cmbMaSoKU, numSoTienThu, numSoTienGoc, numSoTienConLai, cmbMaLoaiChungTu, cmbTaiKhoanNo, cmbTaiKhoanCo,  toolTimThuVon.Text.Trim());
            else
                TVctrl.TimMaSoKUThuVon(dataGridViewTV, bindingNavigatorTV, txtSoButToan, dtpNgayTV, cmbMaSoKU, numSoTienThu, numSoTienGoc, numSoTienConLai, cmbMaLoaiChungTu, cmbTaiKhoanNo, cmbTaiKhoanCo,  toolTimThuVon.Text.Trim());
        }

        private void XemLai_Click(object sender, EventArgs e)
        {
            LCTctrl.HienThiCombobox(cmbMaLoaiChungTu);
            HSKUctrl.HienThiCombobox(cmbMaSoKU);
            TK1ctrl.HienThiCombobox(cmbTaiKhoanCo);
            TK2ctrl.HienThiCombobox(cmbTaiKhoanNo);
            TVctrl.HienThiDataGridView(dataGridViewTV,bindingNavigatorTV,txtSoButToan,dtpNgayTV,cmbMaSoKU,numSoTienThu,numSoTienGoc,numSoTienConLai,cmbMaLoaiChungTu,cmbTaiKhoanNo,cmbTaiKhoanCo);
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimThuVon.Text;
            if (str == "Mã thu vốn" || str == "Mã thu vốn")
                return true;
            return false;
        }

       
        private void dataGridViewTNTL_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void ToolTimMaTV_Click_1(object sender, EventArgs e)
        {
            ToolTimMaTV.Checked = true;
            ToolTimMaSoKU.Checked = false;
            if (Test())
                toolTimThuVon.Text = "Mã Thu Vốn";
            bindingNavigatorTV.Focus();
        }

        private void toolTimThuVon_Leave_1(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaTV.Checked == true)
                    toolTimThuVon.Text = "Mã Thu Vốn";
                else
                    toolTimThuVon.Text = "Mã Số Khế Ước";
            }
        }

        private void toolTimThuVon_Enter_1(object sender, EventArgs e)
        {
            toolTimThuVon.Text = "";
            toolTimThuVon.ForeColor = Color.Black;
        }

        private void toolTimThuVon_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaTV.Checked)
                    TVctrl.TimMaThuVon(dataGridViewTV, bindingNavigatorTV, txtSoButToan, dtpNgayTV, cmbMaSoKU, numSoTienThu, numSoTienGoc, numSoTienConLai, cmbMaLoaiChungTu, cmbTaiKhoanNo, cmbTaiKhoanCo, toolTimThuVon.Text.Trim());
                else
                    TVctrl.TimMaSoKUThuVon(dataGridViewTV, bindingNavigatorTV, txtSoButToan, dtpNgayTV, cmbMaSoKU, numSoTienThu, numSoTienGoc, numSoTienConLai, cmbMaLoaiChungTu, cmbTaiKhoanNo, cmbTaiKhoanCo, toolTimThuVon.Text.Trim());
            }
        }

        private void numSoTienThu_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                numSoTienConLai.Value = numSoTienGoc.Value - numSoTienThu.Value;
            }
            catch { };
        }

        private void cmbMaSoKU_SelectedValueChanged(object sender, EventArgs e)
        {
            String s_MaSoKU = Convert.ToString(cmbMaSoKU.SelectedValue).Trim();
            TK1ctrl.HienThiComboboxTheoMaKheuocTV(numSoTienGoc, cmbTaiKhoanNo, cmbTaiKhoanCo, s_MaSoKU);
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