using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.Controller;
using QuanLyVayVonChoNHCSXH.BusinessObject;
using QuanLyVayVonChoNHCSXH.Setting;


namespace QuanLyVayVonChoNHCSXH.UserInterface
{
    public partial class frmDoiTac : Form
    {
        DoiTacController DTctrl = new DoiTacController();
        TinhController Tctrl = new TinhController();
        HuyenController Hctrl = new HuyenController();
        XaController Xctrl = new XaController();
        LoaiHinhController LHctrl = new LoaiHinhController();
        LoaiDoiTacController LDTctrl = new LoaiDoiTacController();
        DanTocController DanTocctrl = new DanTocController();
        ThamSo.Controll status = ThamSo.Controll.Normal;     
        public frmDoiTac()
        {
            InitializeComponent();
          //  ThamSo.Controll status = ThamSo.Controll.Addnew;  
        }

        public frmDoiTac(DoiTacController ctrldt)
            :this()
        {
            this.DTctrl = ctrldt;
            status= ThamSo.Controll.Normal;
        }
            
        private void frmDoiTac_Load(object sender, EventArgs e)
        {
            Tctrl.HienThiCombobox(cmbMaTinh);
            Hctrl.HienThiCombobox(cmbMaHuyen);
            Xctrl.HienThiCombobox(cmbMaXa);
            LHctrl.HienThiCombobox(cmbMaLoaiHinh);
            LDTctrl.HienThiCombobox(cmbMaLoaiDoiTac);
            DanTocctrl.HienThiCombobox(cmbMaDanToc);
            DTctrl.HienThiDataGridView(dataGridViewDT, bindingNavigatorDT, txtMaDoiTac, txtTenDoiTac, cbGioiTinh, txtDiaChi, dtpNgaySinh, txtCMND,dtpNgayCap,txtNoiCap,cmbMaTinh,cmbMaHuyen,cmbMaXa, cmbMaLoaiHinh,cmbMaLoaiDoiTac,cmbMaDanToc);

            if (status ==ThamSo.Controll.Addnew)
            {
                txtMaDoiTac.Text = ThamSo.LayMaDoiTac().ToString();
                Allow(true);
            }
            else
            {
                Allow(false);
            }
        }
        
        private void Thêm_Click(object sender, EventArgs e)
        {
           
            status =ThamSo.Controll.Addnew;
            txtMaDoiTac.Text = ThamSo.LayMaDoiTac().ToString();
            this.Allow(true);
            DataRow row = DTctrl.NewRow();
            row["MaDoiTac"] = "";
            row["HoTenDT"] = "";
            row["GioiTinh"] = 0;
            row["DiaChi"] = "";
            row["NgaySinh"] = "01/01/1900";
            row["CMND"] = "";
            row["NgayCap"] = "01/01/1918";
            row["NoiCap"] = "";
            row["MaTinh"] = "";
            row["MaHuyen"] = "";
            row["MaXa"] = "";
            row["MaLoaiHinh"] = "";
            row["MaLoaiDoiTac"] = "";
            row["MaDanToc"] = "";

            DTctrl.Add(row);
            bindingNavigatorDT.BindingSource.MoveLast();
            txtMaDoiTac.Focus();            
        }

        private void Xoá_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Doi Tac", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorDT.BindingSource.RemoveCurrent();
                DTctrl.Save();
               
            }
        }

        void Allow(bool val)
        {
            txtMaDoiTac.Enabled = val;
            txtTenDoiTac.Enabled = val;
            dtpNgaySinh.Enabled = val;
            cbGioiTinh.Enabled = val;
            txtCMND.Enabled = val;
            dtpNgayCap.Enabled = val;
            txtNoiCap.Enabled = val;
            txtDiaChi.Enabled = val;
            cmbMaTinh.Enabled = val;
            cmbMaHuyen.Enabled = val;
            cmbMaXa.Enabled = val;
            cmbMaLoaiHinh.Enabled = val;
            cmbMaLoaiDoiTac.Enabled = val;
            cmbMaDanToc.Enabled = val;
        }

        void Luu()
        {
            if (status ==ThamSo.Controll.Addnew)
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
            DTctrl.Update();            
        }

        void ThemMoi()
        {
            DataRow row = DTctrl.NewRow();
            row["MaDoiTac"] = "";
            row["HoTenDT"] = "";
            row["GioiTinh"] = 0;
            row["DiaChi"] = "";
            row["NgaySinh"] = "01/01/1900";
            row["CMND"] = "";
            row["NgayCap"] = "01/01/1918";
            row["NoiCap"] = "";
            row["MaTinh"] = "";
            row["MaHuyen"] = "";
            row["MaXa"] = "";
            row["MaLoaiHinh"] = "";
            row["MaLoaiDoiTac"] = "";
            row["MaDanToc"] = "";

            DTctrl.Add(row);
            DoiTacController ctrldoitac = new DoiTacController();
            if (ctrldoitac.LayDoiTac(txtMaDoiTac.Text) != null)
            {
                MessageBox.Show("Mã đối tác này đã tồn tại !", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ThamSo.LaSoNguyen(txtMaDoiTac.Text))
            {
                long so = Convert.ToInt64(txtMaDoiTac.Text);
                if (so >= ThamSo.LayMaDoiTac())
                {
                    ThamSo.GanMaDoiTac(so + 1);
                }
            }
           
        }

        void KiemTra()
        {            
            if (txtMaDoiTac.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã đối tác !", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
            else if (txtTenDoiTac.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đối tác !", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //else if (txtCMND.Text.Length > 9)
            //{
            //    MessageBox.Show("Vui lòng nhập CMND !", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else if (dtpNgayCap.Value <= dtpNgaySinh.Value)
            {
                MessageBox.Show("Vui lòng nhập ngày cấp phải sau ngày sinh !", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtNoiCap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nơi cấp CMND vào !", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ !", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaTinh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tỉnh !", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaHuyen.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn huyện !", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if (cmbMaXa.SelectedValue == null)
            //{
            //    MessageBox.Show("Vui lòng chọn xã !", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else if (cmbMaLoaiHinh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại hình !", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaLoaiDoiTac.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại đối tác !", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaDanToc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn dân tộc!", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaDoiTac.Text == "" || txtTenDoiTac.Text == "" || dtpNgayCap.Value <= dtpNgaySinh.Value||
            txtNoiCap.Text == "" || txtDiaChi.Text == "" || cmbMaTinh.SelectedValue == null || cmbMaHuyen.SelectedValue == null||
            cmbMaXa.SelectedValue == null || cmbMaLoaiHinh.SelectedValue == null || cmbMaLoaiDoiTac.SelectedValue == null || cmbMaDanToc.SelectedValue == null)
            {
                status = ThamSo.Controll.noreally;
 
            }
           
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            txtMaDoiTac.Focus();
            bindingNavigatorDT.BindingSource.MoveNext();
            KiemTra();         
            if (status == ThamSo.Controll.noreally)
            {
                MessageBox.Show("Thông tin còn thiếu nên đối tác không được lưu", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTctrl.Save();
                Allow(false);
            }
            status = ThamSo.Controll.Save;
            
        }

        private void ToolTimMaDoiTac_Click(object sender, EventArgs e)
        {
            ToolTimTenDoiTac.Checked = false;
            ToolTimMaLoaiDoiTac.Checked = false;
            ToolTimMaDoiTac.Checked = true;
            if (Test())
                toolTimDoiTac.Text = "Mã Đối Tác";
            bindingNavigatorDT.Focus();
        }

        private void ToolTimTenDoiTac_Click(object sender, EventArgs e)
        {
            ToolTimTenDoiTac.Checked = true;
            ToolTimMaDoiTac.Checked = false;
            ToolTimMaLoaiDoiTac.Checked = false;
            if (Test())
                toolTimDoiTac.Text = "Tên Đối Tác";
            bindingNavigatorDT.Focus();
        }

        private void ToolTimMaLoaiDoiTac_Click(object sender, EventArgs e)
        {
            ToolTimMaLoaiDoiTac.Checked = true;
            ToolTimTenDoiTac.Checked = false;
            ToolTimMaDoiTac.Checked = false;
            if (Test())
                toolTimDoiTac.Text = "Mã Loại Đối Tác";
            bindingNavigatorDT.Focus();
        }

        private void toolTimDoitac_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaDoiTac.Checked == true)
                    toolTimDoiTac.Text = "Mã Đối Tác";
                else
                    toolTimDoiTac.Text = "Tên Đối Tác";
            }
        }

        private void toolTimDoitac_Enter(object sender, EventArgs e)
        {
            toolTimDoiTac.Text = "";
            toolTimDoiTac.ForeColor = Color.Black;
        }

        private void toolTimDoitac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaDoiTac.Checked)
                    DTctrl.TimMaDoiTac(dataGridViewDT, bindingNavigatorDT, txtMaDoiTac, txtTenDoiTac, cbGioiTinh, txtDiaChi, dtpNgaySinh, txtCMND, dtpNgayCap, txtNoiCap, cmbMaTinh, cmbMaHuyen, cmbMaXa, cmbMaLoaiHinh, cmbMaLoaiDoiTac, cmbMaDanToc,toolTimDoiTac.Text.Trim());
                else
                    if (ToolTimMaLoaiDoiTac.Checked)
                            DTctrl.TimMaLoaiDoiTac(dataGridViewDT, bindingNavigatorDT, txtMaDoiTac, txtTenDoiTac, cbGioiTinh, txtDiaChi, dtpNgaySinh, txtCMND, dtpNgayCap, txtNoiCap, cmbMaTinh, cmbMaHuyen, cmbMaXa, cmbMaLoaiHinh, cmbMaLoaiDoiTac, cmbMaDanToc, toolTimDoiTac.Text.Trim());
                        else
                            DTctrl.TimTenDoiTac(dataGridViewDT, bindingNavigatorDT, txtMaDoiTac, txtTenDoiTac, cbGioiTinh, txtDiaChi, dtpNgaySinh, txtCMND, dtpNgayCap, txtNoiCap, cmbMaTinh, cmbMaHuyen, cmbMaXa, cmbMaLoaiHinh, cmbMaLoaiDoiTac, cmbMaDanToc,toolTimDoiTac.Text.Trim());
            }
        }

        private void Tìm_Click(object sender, EventArgs e)
        {
          
                if (ToolTimMaDoiTac.Checked)
                    DTctrl.TimMaDoiTac(dataGridViewDT, bindingNavigatorDT, txtMaDoiTac, txtTenDoiTac, cbGioiTinh, txtDiaChi, dtpNgaySinh, txtCMND, dtpNgayCap, txtNoiCap, cmbMaTinh, cmbMaHuyen, cmbMaXa, cmbMaLoaiHinh, cmbMaLoaiDoiTac, cmbMaDanToc, toolTimDoiTac.Text.Trim());
                    else
                    if (ToolTimMaLoaiDoiTac.Checked)
                        DTctrl.TimMaLoaiDoiTac(dataGridViewDT, bindingNavigatorDT, txtMaDoiTac, txtTenDoiTac, cbGioiTinh, txtDiaChi, dtpNgaySinh, txtCMND, dtpNgayCap, txtNoiCap, cmbMaTinh, cmbMaHuyen, cmbMaXa, cmbMaLoaiHinh, cmbMaLoaiDoiTac, cmbMaDanToc, toolTimDoiTac.Text.Trim());
                        else
                            DTctrl.TimTenDoiTac(dataGridViewDT, bindingNavigatorDT, txtMaDoiTac, txtTenDoiTac, cbGioiTinh, txtDiaChi, dtpNgaySinh, txtCMND, dtpNgayCap, txtNoiCap, cmbMaTinh, cmbMaHuyen, cmbMaXa, cmbMaLoaiHinh, cmbMaLoaiDoiTac, cmbMaDanToc, toolTimDoiTac.Text.Trim());
            
        }

        private void Xem_Click(object sender, EventArgs e)
        {
            Tctrl.HienThiCombobox(cmbMaTinh);
            Hctrl.HienThiCombobox(cmbMaHuyen);
            Xctrl.HienThiCombobox(cmbMaXa);
            LHctrl.HienThiCombobox(cmbMaLoaiHinh);
            LDTctrl.HienThiCombobox(cmbMaLoaiDoiTac);
            DanTocctrl.HienThiCombobox(cmbMaDanToc);
            DTctrl.HienThiDataGridView(dataGridViewDT, bindingNavigatorDT, txtMaDoiTac, txtTenDoiTac, cbGioiTinh, txtDiaChi, dtpNgaySinh, txtCMND, dtpNgayCap, txtNoiCap, cmbMaTinh, cmbMaHuyen, cmbMaXa, cmbMaLoaiHinh, cmbMaLoaiDoiTac, cmbMaDanToc);
        }
              
        private void Thoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn thoát không!", "DoiTac", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
               
                this.Close();
            }
            
        
         }

        public bool Test()
        {
            String str = toolTimDoiTac.Text;
            if (str == "Mã đối tác" || str == "Tên đối tác")
                return true;
            return false;
        }

        private void ThemTinh_Click(object sender, EventArgs e)
        {
            frmTinh T = new frmTinh();
            T.ShowDialog();
        }

        private void ThemHuyen_Click(object sender, EventArgs e)
        {
            frmHuyen H = new frmHuyen();
            H.ShowDialog();
        }

        private void ThemXa_Click(object sender, EventArgs e)
        {
            frmXa X = new frmXa();
            X.ShowDialog();
        }

        private void ThemLoaiHinh_Click(object sender, EventArgs e)
        {
            frmLoaiHinh LH = new frmLoaiHinh();
            LH.ShowDialog();
        }

        private void ThemLoaiDoiTac_Click(object sender, EventArgs e)
        {
            frmLoaiDoiTac LDT = new frmLoaiDoiTac();
            LDT.ShowDialog();
        }

        private void ThemDanToc_Click(object sender, EventArgs e)
        {
            frmDanToc DT = new frmDanToc();
            DT.ShowDialog();
        }

        private void dataGridViewDT_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void toolchihsua_Click(object sender, EventArgs e)
        {
            status = ThamSo.Controll.Edit;
            this.Allow(true);
        }

        private void cmbMaTinh_SelectedValueChanged(object sender, EventArgs e)
        {
            String s_MaTinh = Convert.ToString(cmbMaTinh.SelectedValue);
            Hctrl.HienThiComboboxTheoTinh(cmbMaHuyen, s_MaTinh);
        }

        private void cmbMaHuyen_SelectedValueChanged(object sender, EventArgs e)
        {
            String s_MaHuyen = Convert.ToString(cmbMaHuyen.SelectedValue);
           //ComboBox s_MaHuyen = Convert.ToSingle(cmbMaHuyen.SelectedValue);
            Xctrl.HienThiComboboxTheoHuyen(cmbMaXa, s_MaHuyen);
        }

        
        

        
    }
}