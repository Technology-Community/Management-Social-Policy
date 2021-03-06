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
    public partial class frmHoSoKheUoc : Form
    {
        DoiTacController doitacCtrl = new DoiTacController();
        DoiTacController doitacCtrlTT = new DoiTacController();
        DoiTacController doitacCtrlTK = new DoiTacController();
        LoaiVayController loaivayCtrl = new LoaiVayController();
        KieuVayNguonVonController KVNVCtrl = new KieuVayNguonVonController();
        KieuTraController KieuTraCtrl = new KieuTraController();
        ChuongTrinhController ChuongTrinhCtrl = new ChuongTrinhController();
        LaiSuatController LaiSuatCtrl = new LaiSuatController();
        TaiKhoanController TaiKhoanCtrl = new TaiKhoanController();
        TaiKhoanController TaiKhoanCtrlTL = new TaiKhoanController();
        TaiKhoanController TaiKhoanCtrlNoQH = new TaiKhoanController();
        TaiKhoanController TaiKhoanCtrlTLNoQH = new TaiKhoanController();
        MucDichVayController MucDichVayCtrl = new MucDichVayController();
        HTDamBaoController HTDamBaoCtrl = new HTDamBaoController();
        NhanVienController NhanVienCtrl = new NhanVienController();
        HinhThucVayController HinhThucVayCtrl = new HinhThucVayController();
        ThoiHanVayController ThoiHanVayCtrl = new ThoiHanVayController();
        DonViUyThacController DonViUTCtrl = new DonViUyThacController();
        VungController VungCtrl = new VungController();        
        HoSoKheUocController HoSoKheUocCtrl = new HoSoKheUocController();

        ThamSo.Controll status = ThamSo.Controll.Normal;     

        public frmHoSoKheUoc()
        {
            InitializeComponent();
        //    ThamSo.Controll status = ThamSo.Controll.Addnew;  
        }
         public frmHoSoKheUoc(HoSoKheUocController ctrlhsku )
            :this()
        {
            this.HoSoKheUocCtrl = ctrlhsku;
            status= ThamSo.Controll.Normal;
        }
            

        private void frmHoSoKheUoc_Load(object sender, EventArgs e)
        {
            doitacCtrl.HienThiCombobox(cmbMaDoiTac);
            loaivayCtrl.HienThiCombobox(cmbMaLoaiVay);
            KVNVCtrl.HienThiCombobox(cmbMaKVNV);
            KieuTraCtrl.HienThiCombobox(cmbMaKieuTra);
            ChuongTrinhCtrl.HienThiCombobox(cmbMaChuongTrinh);
            doitacCtrlTT.HienThiCombobox(cmbTenToTruong);
            LaiSuatCtrl.HienThiCombobox(cmbMaLaiSuat);
            TaiKhoanCtrl.HienThiCombobox(cmbMaTaiKhoan);
            TaiKhoanCtrlTL.HienThiCombobox(cmbThuLai);
            TaiKhoanCtrlNoQH.HienThiCombobox(cmbTKNoQuaHan);
            TaiKhoanCtrlTLNoQH.HienThiCombobox(cmbThuLaiQuaHan);
            MucDichVayCtrl.HienThiCombobox(cmbMDVay);
            HTDamBaoCtrl.HienThiCombobox(cmbMaHTDamBao);
            NhanVienCtrl.HienThiCombobox(cmbMaNV);
            HinhThucVayCtrl.HienThiCombobox(cmbMaHTVay);
            ThoiHanVayCtrl.HienThiCombobox(cmbMaThoiHanVay);
            DonViUTCtrl.HienThiCombobox(cmbMaDVUT);
            VungCtrl.HienThiCombobox(cmbMaVung);
            doitacCtrlTK.HienThiCombobox(cmbHotenThuaKe);
            HoSoKheUocCtrl.HienThiDataGridView(dataGridViewHSKU, bindingNavigator, txtMaSoKU, cmbMaDoiTac, cmbMaLoaiVay, cmbMaKVNV, cmbMaKieuTra, cmbMaChuongTrinh, cmbTenToTruong, numNhuCau
            , dtpNgayDuyet, numMucDuyet, dtpNgayVay, dtpNgayTra, cmbMaLaiSuat, cmbMaTaiKhoan, cmbThuLai, cmbTKNoQuaHan, cmbThuLaiQuaHan, cmbMDVay, cmbMaHTDamBao
            , cmbMaNV, cmbMaHTVay, cmbMaThoiHanVay, cmbMaDVUT, cmbMaVung, cmbHotenThuaKe, numTraNoGocDinhKy,numSoTienHienTai);
         
            if (status == ThamSo.Controll.Addnew)
            {
                txtMaSoKU.Text = ThamSo.LaySoKheUoc().ToString();
                Allow(true);
            }
            else
            {
                Allow(false);
            }
            
        }

        private void toolThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolThem_Click(object sender, EventArgs e)
        {
            status = ThamSo.Controll.Addnew;
            txtMaSoKU.Text = ThamSo.LaySoKheUoc().ToString();
            this.Allow(true);            
            DataRow row = HoSoKheUocCtrl.NewRow();
            txtMaSoKU.Text = null;
            row["MaSoKU"] = txtMaSoKU.Text;
            row["MaDoiTac"] = cmbMaDoiTac.SelectedValue;
            row["MaLoaiVay"] = cmbMaLoaiVay.SelectedValue;
            row["MaKVNV"] = cmbMaKVNV.SelectedValue;
            row["MaKieuTra"] = cmbMaKieuTra.SelectedValue;
            row["TenToTruong"] = cmbTenToTruong.SelectedValue;
            row["MaChuongTrinh"] = cmbMaChuongTrinh.SelectedValue;
            row["NhuCau"] = numNhuCau.Value;
            row["SoTienHienTai"] = numSoTienHienTai.Value;
            row["NgayDuyet"] = dtpNgayDuyet.Value.Date;
            row["MucDuyet"] = numMucDuyet.Value;
            row["NgayVay"] = dtpNgayVay.Value.Date;
            row["NgayTra"] = dtpNgayTra.Value.Date;
            
            
            row["MaLaiSuat"] = cmbMaLaiSuat.SelectedValue;
            row["TKChoVay"] = cmbMaTaiKhoan.SelectedValue;
            row["ThuLai"] = cmbThuLai.SelectedValue;
            row["TKNoQuaHan"] = cmbTKNoQuaHan.SelectedValue;
            row["ThuLaiQuaHan"] = cmbThuLaiQuaHan.SelectedValue;
            row["MaMucDichVay"] = cmbMDVay.SelectedValue;

            row["MaHTDamBao"] = cmbMaHTDamBao.SelectedValue;
            row["MaNV"] = cmbMaNV.SelectedValue;
            row["MaThoiHanVay"] = cmbMaThoiHanVay.SelectedValue;
            row["MaHTVay"] = cmbMaHTVay.SelectedValue;
            row["MaDonViUyThac"] = cmbMaDVUT.SelectedValue;
            row["MaVung"] = cmbMaVung.SelectedValue;
            row["TraNoGocDinhKy"] = numTraNoGocDinhKy.Value;

            HoSoKheUocCtrl.Add(row);
            bindingNavigator.BindingSource.MoveLast();
            txtMaSoKU.Focus();
            
         
        }

        private void ToolXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khế ước này không?", "Khế ước", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator.BindingSource.RemoveCurrent();
                HoSoKheUocCtrl.Save();

            }
           
        }

        private void ToolLuu_Click(object sender, EventArgs e)
        {
            txtMaSoKU.Focus();
            bindingNavigator.BindingSource.MoveNext();
            KiemTra();
            if (status == ThamSo.Controll.noreally)
            {
                MessageBox.Show("Thông tin còn thiếu nên khế ước không được lưu", "Doi Tac", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                HoSoKheUocCtrl.Save();
                Allow(false);
            }
            status = ThamSo.Controll.Save;

           
        }

        void Allow(bool val)
        {
            txtMaSoKU.Enabled = val;
            cmbMaDoiTac.Enabled = val;
            cmbMaLoaiVay.Enabled = val;
            cmbMaKVNV.Enabled = val;
            cmbMaKieuTra.Enabled = val;
            cmbMaChuongTrinh.Enabled = val;
            cmbTenToTruong.Enabled = val;
            numNhuCau.Enabled = val;
            numSoTienHienTai.Enabled = val;
            numMucDuyet.Enabled = val;
            dtpNgayVay.Enabled = val;
            dtpNgayDuyet.Enabled = val;
            dtpNgayTra.Enabled = val;
            cmbMaLaiSuat.Enabled = val;
            cmbMaTaiKhoan.Enabled = val;
            cmbThuLai.Enabled = val;
            cmbTKNoQuaHan.Enabled = val;
            cmbThuLaiQuaHan.Enabled = val;
            cmbMDVay.Enabled = val;
            cmbMaHTDamBao.Enabled = val;
            cmbMaNV.Enabled = val;
            cmbMaHTVay.Enabled = val;
            cmbMaThoiHanVay.Enabled = val;
            cmbMaDVUT.Enabled = val;
            cmbMaVung.Enabled = val;
            cmbHotenThuaKe.Enabled = val;
            numTraNoGocDinhKy.Enabled = val;

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
            HoSoKheUocCtrl.Update();
        }

        void ThemMoi()
        {
            DataRow row = HoSoKheUocCtrl.NewRow();
            row["MaSoKU"] = txtMaSoKU.Text;
            row["MaDoiTac"] = cmbMaDoiTac.SelectedValue;
            row["MaLoaiVay"] = cmbMaLoaiVay.SelectedValue;
            row["MaKVNV"] = cmbMaKVNV.SelectedValue;
            row["MaKieuTra"] = cmbMaKieuTra.SelectedValue;
            row["TenToTruong"] = cmbTenToTruong.SelectedValue;
            row["MaChuongTrinh"] = cmbMaChuongTrinh.SelectedValue;
            row["NhuCau"] = numNhuCau.Value;
            row["SoTienHienTai"] = numSoTienHienTai.Value;
            row["NgayDuyet"] = dtpNgayDuyet.Value.Date;
            row["MucDuyet"] = numMucDuyet.Value;
            row["NgayVay"] = dtpNgayVay.Value.Date;
            row["NgayTra"] = dtpNgayTra.Value.Date;


            row["MaLaiSuat"] = cmbMaLaiSuat.SelectedValue;
            row["TKChoVay"] = cmbMaTaiKhoan.SelectedValue;
            row["ThuLai"] = cmbThuLai.SelectedValue;
            row["TKNoQuaHan"] = cmbTKNoQuaHan.SelectedValue;
            row["ThuLaiQuaHan"] = cmbThuLaiQuaHan.SelectedValue;
            row["MaMucDichVay"] = cmbMDVay.SelectedValue;

            row["MaHTDamBao"] = cmbMaHTDamBao.SelectedValue;
            row["MaNV"] = cmbMaNV.SelectedValue;
            row["MaThoiHanVay"] = cmbMaThoiHanVay.SelectedValue;
            row["MaHTVay"] = cmbMaHTVay.SelectedValue;
            row["MaDonViUyThac"] = cmbMaDVUT.SelectedValue;
            row["MaVung"] = cmbMaVung.SelectedValue;
            row["TraNoGocDinhKy"] = numTraNoGocDinhKy.Value;

            HoSoKheUocCtrl.Add(row);
            HoSoKheUocController ctrlhosokheuoc = new HoSoKheUocController();
            if (ctrlhosokheuoc.LayHoSoKheUoc(txtMaSoKU.Text) != null)
            {
                MessageBox.Show("Số khế ước này đã tồn tại !", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ThamSo.LaSoNguyen(txtMaSoKU.Text))
            {
                long so = Convert.ToInt64(txtMaSoKU.Text);
                if (so >= ThamSo.LaySoKheUoc())
                {
                    ThamSo.GanSoKheUoc(so + 1);
                }
            }

        }

        void KiemTra()
        {
            if (txtMaSoKU.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số khế ước!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaDoiTac.SelectedValue==null)
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng vào !", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaLoaiVay.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại vay!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaKVNV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn kiểu vay nguồn vốn!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaKieuTra.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn kiểu trả !", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaChuongTrinh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn chương trình!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTenToTruong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tổ trưởng !", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numNhuCau.Value==0)
            {
                MessageBox.Show("Vui lòng chọn nhu cầu vào !", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numMucDuyet.Value== 0)
            {
                MessageBox.Show("Vui lòng nhập mức duyệt vào !", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (dtpNgayVay.Value <= dtpNgayDuyet.Value)
            {
                MessageBox.Show("Vui lòng nhập ngày duyệt phải sau ngày ngày vay !", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpNgayTra.Value <= dtpNgayDuyet.Value)
            {
                MessageBox.Show("Vui lòng nhập ngày trả phải sau ngày ngày duyệt !", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaLaiSuat.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lãi suất!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaTaiKhoan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbThuLai.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thu lãi!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTKNoQuaHan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản nợ quá hạn!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbThuLaiQuaHan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thu lãi quá hạn!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            else if (cmbMDVay.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mục đích vay !", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaHTDamBao.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hình thức đảm bảo!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaNV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên !", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaHTVay.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hình thức vay!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaThoiHanVay.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thời hạn vay !", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaDVUT.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đơn vị ủy thác!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaVung.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn vùng!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbHotenThuaKe.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tên thừa kế!", "Ho So Khe Uoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaSoKU.Text == "" || cmbMaDoiTac.SelectedValue == null || cmbMaLoaiVay.SelectedValue == null || cmbMaKVNV.SelectedValue == null || cmbMaKieuTra.SelectedValue == null ||
            cmbMaChuongTrinh.SelectedValue == null || cmbTenToTruong.SelectedValue == null || numNhuCau.Value == 0 || numSoTienHienTai.Value == 0 || numMucDuyet.Value == 0 || dtpNgayVay.Value <= dtpNgayDuyet.Value ||
            dtpNgayTra.Value <= dtpNgayDuyet.Value || cmbMaLaiSuat.SelectedValue == null || cmbMaTaiKhoan.SelectedValue == null || cmbThuLai.SelectedValue == null || cmbTKNoQuaHan.SelectedValue == null||
            cmbThuLaiQuaHan.SelectedValue == null || cmbMDVay.SelectedValue == null || cmbMaHTDamBao.SelectedValue == null || cmbMaNV.SelectedValue == null || cmbMaHTVay.SelectedValue == null||
            cmbMaThoiHanVay.SelectedValue == null || cmbMaDVUT.SelectedValue == null || cmbMaVung.SelectedValue == null || cmbHotenThuaKe.SelectedValue == null)
            {
                status = ThamSo.Controll.noreally;

            }
        }




        private void tooltimtheomaku_Click(object sender, EventArgs e)
        {
            tooltimtheomaku.Checked = true;
            tooltimtheomadoitac.Checked = false;         
            if (Test())
                toolTimHoSoKheUoc.Text = "Mã số khế ước";
            bindingNavigator.Focus();
        }

        

        private void toolXemLai_Click(object sender, EventArgs e)
        {
            HoSoKheUocCtrl.HienThiDataGridView(dataGridViewHSKU, bindingNavigator, txtMaSoKU, cmbMaDoiTac, cmbMaLoaiVay, cmbMaKVNV, cmbMaKieuTra, cmbMaChuongTrinh, cmbTenToTruong, numNhuCau
          , dtpNgayDuyet, numMucDuyet, dtpNgayVay, dtpNgayTra, cmbMaLaiSuat, cmbMaTaiKhoan, cmbThuLai, cmbTKNoQuaHan, cmbThuLaiQuaHan, cmbMDVay, cmbMaHTDamBao
          , cmbMaNV, cmbMaHTVay, cmbMaThoiHanVay, cmbMaDVUT, cmbMaVung, cmbHotenThuaKe, numTraNoGocDinhKy,numSoTienHienTai);
        }


        public bool Test()
        {
            String str = toolTimHoSoKheUoc.Text;
            if (str == "Mã số khế ước" || str == "Mã đối tác")
                return true;
            return false;
        }

        private void tooltimtheomadoitac_Click(object sender, EventArgs e)
        {
            tooltimtheomaku.Checked = false;
            tooltimtheomadoitac.Checked = true;
            if (Test())
                toolTimHoSoKheUoc.Text = "Mã đối tác";
            bindingNavigator.Focus();
        }

        private void toolTimHoSoKheUoc_Enter(object sender, EventArgs e)
        {
            toolTimHoSoKheUoc.Text = "";
            toolTimHoSoKheUoc.ForeColor = Color.Black;
        }

        private void toolTimHoSoKheUoc_Leave(object sender, EventArgs e)
        {

        }

        private void toolTimHoSoKheUoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tooltimtheomaku.Checked)
                    HoSoKheUocCtrl.TimHoSoKheUocTheoMaSoKU(dataGridViewHSKU, bindingNavigator, txtMaSoKU, cmbMaDoiTac, cmbMaLoaiVay, cmbMaKVNV, cmbMaKieuTra, cmbMaChuongTrinh, cmbTenToTruong, numNhuCau
                    , dtpNgayDuyet, numMucDuyet, dtpNgayVay, dtpNgayTra, cmbMaLaiSuat, cmbMaTaiKhoan, cmbThuLai, cmbTKNoQuaHan, cmbThuLaiQuaHan, cmbMDVay, cmbMaHTDamBao
                    , cmbMaNV, cmbMaHTVay, cmbMaThoiHanVay, cmbMaDVUT, cmbMaVung, cmbHotenThuaKe, numTraNoGocDinhKy,numSoTienHienTai,toolTimHoSoKheUoc.Text.Trim());
                   
                 else
                        HoSoKheUocCtrl.TimHSKUTheoMaDoiTac(dataGridViewHSKU, bindingNavigator, txtMaSoKU, cmbMaDoiTac, cmbMaLoaiVay, cmbMaKVNV, cmbMaKieuTra, cmbMaChuongTrinh, cmbTenToTruong, numNhuCau
                   , dtpNgayDuyet, numMucDuyet, dtpNgayVay, dtpNgayTra, cmbMaLaiSuat, cmbMaTaiKhoan, cmbThuLai, cmbTKNoQuaHan, cmbThuLaiQuaHan, cmbMDVay, cmbMaHTDamBao
                   , cmbMaNV, cmbMaHTVay, cmbMaThoiHanVay, cmbMaDVUT, cmbMaVung, cmbHotenThuaKe, numTraNoGocDinhKy,numSoTienHienTai, toolTimHoSoKheUoc.Text.Trim());
            }
        }

        private void btnThemdt_Click(object sender, EventArgs e)
        {
            frmDoiTac doitac = new frmDoiTac();
            doitac.ShowDialog();
            
        }

        private void btnThemloaivay_Click(object sender, EventArgs e)
        {
            frmLoaiVay LV = new frmLoaiVay();
            LV.ShowDialog();
        }

        private void btnThemkvnv_Click(object sender, EventArgs e)
        {
            frmKieuVayNguonVon KVNV = new frmKieuVayNguonVon();
            KVNV.ShowDialog();
        }

        private void btnThemkieutra_Click(object sender, EventArgs e)
        {
            frmKieuTra KT = new frmKieuTra();
            KT.ShowDialog();
        }

        private void btnThemchuongtrinh_Click(object sender, EventArgs e)
        {
            frmChuongTrinh CT = new frmChuongTrinh();
            CT.ShowDialog();
        }

        private void btnThemTentotruong_Click(object sender, EventArgs e)
        {
            frmDoiTac TTT = new frmDoiTac();
            TTT.ShowDialog();
        }

        private void btnThemLaiSuat_Click(object sender, EventArgs e)
        {
            frmLaiSuat LS = new frmLaiSuat();
            LS.ShowDialog();
        }

        private void btnthemtaikhoanvay_Click(object sender, EventArgs e)
        {
            frmTaiKhoan TKCV = new frmTaiKhoan();
            TKCV.ShowDialog();
        }

        private void btnThemthulai_Click(object sender, EventArgs e)
        {
            frmTaiKhoan TL = new frmTaiKhoan();
            TL.ShowDialog();
        }

        private void btnThemnoquahan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan TKNQH = new frmTaiKhoan();
            TKNQH.ShowDialog();

        }

        private void btnThemthulaiquahan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan TLQH = new frmTaiKhoan();
            TLQH.ShowDialog();
        }

        private void btnThemmucdichvay_Click(object sender, EventArgs e)
        {
            frmMucDichVay MD = new frmMucDichVay();
            MD.ShowDialog();
        }

        private void btnThemhtdambao_Click(object sender, EventArgs e)
        {
            frmHTDamBao HTDB = new frmHTDamBao();
            HTDB.ShowDialog();
        }

        private void btnThemnv_Click(object sender, EventArgs e)
        {
            frmNhanVien NV = new frmNhanVien();
            NV.ShowDialog();

        }

        private void btnthemhthucvay_Click(object sender, EventArgs e)
        {
            frmHinhThucVay HTV = new frmHinhThucVay();
            HTV.ShowDialog();
        }

        private void btnThemhinhthucvay_Click(object sender, EventArgs e)
        {
            frmThoiHanVay THV = new frmThoiHanVay();
            THV.ShowDialog();
        }

        private void btnThemdvut_Click(object sender, EventArgs e)
        {
            frmDonViUyThac DVUT = new frmDonViUyThac();
            DVUT.ShowDialog();
        }

        private void btnThemmavung_Click(object sender, EventArgs e)
        {
            frmVungChoVay VCV = new frmVungChoVay();
            VCV.ShowDialog();
        }

        private void btnthemthuake_Click(object sender, EventArgs e)
        {
            frmDoiTac HTTK = new frmDoiTac();
            HTTK.ShowDialog();
        }

        private void toolSua_Click(object sender, EventArgs e)
        {
            status = ThamSo.Controll.Edit;
            this.Allow(true);
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void numNhuCau_ValueChanged(object sender, EventArgs e)
        {
            numMucDuyet.Value = numNhuCau.Value;
            numSoTienHienTai.Value = numNhuCau.Value;
        }

        private void cmbThuLai_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbThuLaiQuaHan.Text = cmbThuLai.Text;
        }

        private void dtpNgayVay_ValueChanged(object sender, EventArgs e)
        {
           // dtpNgayTra.Value= Convert.ToInt16(dtpNgayVay.Value) + 90;
        }



        

        
    }
}