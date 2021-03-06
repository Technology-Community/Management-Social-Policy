using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using QuanLyVayVonChoNHCSXH.Controller;
using QuanLyVayVonChoNHCSXH.UserInterface;
using QuanLyVayVonChoNHCSXH.CrystalReport;


namespace QuanLyVayVonChoNHCSXH.UserInterface
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public String Quyen = null;
        public frmMain()
        {
            
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ribbonControl1.QatFrequentCommands.Add(btnDangNhap);
            ribbonControl1.QatFrequentCommands.Add(btnDangXuat);
            ribbonControl1.QatFrequentCommands.Add(btnThoat);

            // Load Quick Access Toolbar layout if one is saved from last session...
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
            if (key != null)
            {
                try
                {
                    string layout = key.GetValue("RibbonPadCSLayout", "").ToString();
                    if (layout != "" && layout != null)
                        ribbonControl1.QatLayout = layout;
                }
                finally
                {
                    key.Close();
                }
            }
            UpdateTitle();

            // Pulse the Application Button
            buttonFile.Pulse(11);
            Logon();
            GioiHanNguoiDung();

        }

        private void UpdateTitle()
        {
            string t = "";
            if (this.ActiveMdiChild != null)
            {
                // Note the usage of SysCaptionTextExtra for as the value of color attribute.
                // It specifies the system color that changes based on selected color table.
                t += "<font color=\"SysCaptionTextExtra\">" + this.ActiveMdiChild.Text + "</font> ";
            }
            t += "<b>PHẦN MỀM QUẢN LÝ VAY VỐN CHO NGÂN HÀNG CHÍNH SÁCH XÃ HỘI</b>";
            t += " <b><a name=\"tip\"><font color=\"SysCaptionTextExtra\"></font></a></b>";
            ribbonControl1.TitleText = t;
        }

        frmLogIn lgin = null;
        String user = null;
        String pass = null;
        DangNhapController DNctrl = new DangNhapController();
        public void Logon()
        {
            if (lgin == null || lgin.IsDisposed)
            {
                lgin = new frmLogIn();
            }
            while (lgin.ShowDialog() == DialogResult.OK)
            {
                
                user = Convert.ToString(lgin.txtUsername.Text.Trim());
                pass = Convert.ToString(lgin.txtPassword.Text.Trim());
                if (DNctrl.TestDuLieu(user, pass))
                {
                    lgin.txtUsername.Clear();
                    lgin.txtPassword.Clear();
                    break;
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại User và Password!");
                    //lgin.txtUsername.Clear();
                    //lgin.txtPassword.Clear();
                    lgin.txtUsername.Focus();
                }
            }
            GioiHanNguoiDung();
        }

        //frmQuyen Quyen = new frmQuyen();
        public void GioiHanNguoiDung()
        {
            if (user != null)
                Quyen = DNctrl.LayQuyenTruyCap(user);
            switch (Quyen)
            {
                case null:
                    {
                        ribDanhMuc.Enabled = false;
                        ribNhanVien.Enabled = false;
                        ribDoiTac.Enabled = false;
                        ribNghiepVu.Enabled = false;
                        ribThongKeBaoCao.Enabled = false;
                        ribQuanLy.Enabled = false;
                        rtiHeThong.Enabled = false;
                        rtiQuanLyThongTin.Enabled = false;
                        rtiNghiepVu.Enabled = false;
                        rtiThongKeBaoCao.Enabled = false;
                        expandablePanelHeThong.Enabled = false;
                        expandablePanelQuanLyDanhSachVayVon.Enabled = false;
                        expandablePanelNghiepVu.Enabled = false;
                        expandablePanelBaoCaoThongKe.Enabled = false;
                        
                        break;
                    }
                case "Admin":
                    {
                        ribDanhMuc.Enabled = true;
                        ribDoiTac.Enabled = true;
                        ribNghiepVu.Enabled = true;
                        ribNhanVien.Enabled = true;
                        ribQuanLy.Enabled = true;
                        ribThongKeBaoCao.Enabled = true;
                        rtiHeThong.Enabled = true;
                        rtiQuanLyThongTin.Enabled = true;
                        rtiNghiepVu.Enabled = true;
                        rtiThongKeBaoCao.Enabled = true;
                        expandablePanelHeThong.Enabled = true;
                        expandablePanelQuanLyDanhSachVayVon.Enabled = true;
                        expandablePanelNghiepVu.Enabled = true;
                        expandablePanelBaoCaoThongKe.Enabled = true;

                        break;
                    }
                case "User":
                    {
                        ribDanhMuc.Enabled = false;
                        ribNhanVien.Enabled = false;
                        rtiHeThong.Enabled = false;
                        ribDoiTac.Enabled = true;
                        ribNghiepVu.Enabled = true;
                        ribQuanLy.Enabled = true;
                        ribThongKeBaoCao.Enabled = true;
                        rtiQuanLyThongTin.Enabled = true;
                        rtiNghiepVu.Enabled = true;
                        rtiThongKeBaoCao.Enabled = true;
                        expandablePanelHeThong.Enabled = false;
                        expandablePanelQuanLyDanhSachVayVon.Enabled = true;
                        expandablePanelNghiepVu.Enabled = true;
                        expandablePanelBaoCaoThongKe.Enabled = true;

                        
                        break;
                    }
                default:
                    break;
            }

        }

        private void LaunchRibbonDialog(object sender, System.EventArgs e)
        {
            MessageBox.Show("Start <i>Ribbon Dialog</i> with more options here...", "Ribbon Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        frmDoiTac DoiTacfrm = null;
        private void btnDangKiKhachHang_Click(object sender, EventArgs e)
        {
            if (DoiTacfrm == null || DoiTacfrm.IsDisposed)
            {
                DoiTacfrm = new frmDoiTac();
                DoiTacfrm.MdiParent = this;
                DoiTacfrm.Show();
            }
            else
                DoiTacfrm.Activate();
        
        }

        frmLoaiHinh LoaiHinhfrm = null;
        private void btnLoaiHinh_Click(object sender, EventArgs e)
        {
            if (LoaiHinhfrm == null || LoaiHinhfrm.IsDisposed)
            {
                LoaiHinhfrm = new frmLoaiHinh();
                LoaiHinhfrm.MdiParent = this;
                LoaiHinhfrm.Show();
            }
            else
                LoaiHinhfrm.Activate();
        }

        frmDanToc DanTocfrm = null;
        private void btnDanToc_Click(object sender, EventArgs e)
        {
            if (DanTocfrm == null || DanTocfrm.IsDisposed)
            {
                DanTocfrm = new frmDanToc();
                DanTocfrm.MdiParent = this;
                DanTocfrm.Show();
            }
            else
                DanTocfrm.Activate();
        }

        frmTinh Tinhfrm = null;
        private void btnDanhSachTinh_Click(object sender, EventArgs e)
        {
            if (Tinhfrm == null || Tinhfrm.IsDisposed)
            {
                Tinhfrm = new frmTinh();
                Tinhfrm.MdiParent = this;
                Tinhfrm.Show();
            }
            else
                Tinhfrm.Activate();
        }

        frmHuyen Huyenfrm = null;
        private void btnDanhSachHuyen_Click(object sender, EventArgs e)
        {
            if (Huyenfrm == null || Huyenfrm.IsDisposed)
            {
                Huyenfrm = new frmHuyen();
                Huyenfrm.MdiParent = this;
                Huyenfrm.Show();
            }
            else
                Huyenfrm.Activate();
        }

        frmXa Xafrm = null;
        private void Xa_Click(object sender, EventArgs e)
        {
            if (Xafrm == null || Xafrm.IsDisposed)
            {
                Xafrm = new frmXa();
                Xafrm.MdiParent = this;
                Xafrm.Show();
            }
            else
                Xafrm.Activate();
        }

        frmNhanVien NhanVienfrm = null;
        private void NhânViên_Click(object sender, EventArgs e)
        {
            if (NhanVienfrm == null || NhanVienfrm.IsDisposed)
            {
                NhanVienfrm = new frmNhanVien();
                NhanVienfrm.MdiParent = this;
                NhanVienfrm.Show();
            }
            else
                NhanVienfrm.Activate();
        }

        frmPhongBan PhongBanfrm = null;
        private void PhongBan_Click(object sender, EventArgs e)
        {
            if (PhongBanfrm == null || PhongBanfrm.IsDisposed)
            {
                PhongBanfrm = new frmPhongBan();
                PhongBanfrm.MdiParent = this;
                PhongBanfrm.Show();
            }
            else
                PhongBanfrm.Activate();
        }
        frmChucVu ChucVufrm = null;
        private void ChucVu_Click(object sender, EventArgs e)
        {
            if (ChucVufrm == null || ChucVufrm.IsDisposed)
            {
                ChucVufrm = new frmChucVu();
                ChucVufrm.MdiParent = this;
                ChucVufrm.Show();
            }
            else
                ChucVufrm.Activate();
        }

        frmLoaiVay LoaiVayfrm = null;
        private void btnLoaiVay_Click(object sender, EventArgs e)
        {
            if (LoaiVayfrm == null || LoaiVayfrm.IsDisposed)
            {
                LoaiVayfrm = new frmLoaiVay();
                LoaiVayfrm.MdiParent = this;
                LoaiVayfrm.Show();
            }
            else
                LoaiVayfrm.Activate();
        }

        frmKieuTra KieuTrafrm = null;
        private void KieuTra_Click(object sender, EventArgs e)
        {
            if (KieuTrafrm == null || KieuTrafrm.IsDisposed)
            {
                KieuTrafrm = new frmKieuTra();
                KieuTrafrm.MdiParent = this;
                KieuTrafrm.Show();
            }
            else
                KieuTrafrm.Activate();
        }

        frmChuongTrinh ChuongTrinhfrm = null;
        private void ChuongTrinh_Click(object sender, EventArgs e)
        {
            if (ChuongTrinhfrm == null || ChuongTrinhfrm.IsDisposed)
            {
                ChuongTrinhfrm = new frmChuongTrinh();
                ChuongTrinhfrm.MdiParent = this;
                ChuongTrinhfrm.Show();
            }
            else
                ChuongTrinhfrm.Activate();
        }
        frmHinhThucVay HinhThucVayfrm = null;
        private void HinhThucVay_Click(object sender, EventArgs e)
        {
            if (HinhThucVayfrm == null || HinhThucVayfrm.IsDisposed)
            {
                HinhThucVayfrm = new frmHinhThucVay();
                HinhThucVayfrm.MdiParent = this;
                HinhThucVayfrm.Show();
            }
            else
                HinhThucVayfrm.Activate();
        }

        frmLaiSuat LaiSuatfrm = null;
        private void LaiSuat_Click(object sender, EventArgs e)
        {
            if (LaiSuatfrm == null || LaiSuatfrm.IsDisposed)
            {
                LaiSuatfrm = new frmLaiSuat();
                LaiSuatfrm.MdiParent = this;
                LaiSuatfrm.Show();
            }
            else
                LaiSuatfrm.Activate();
        }

        frmHTDamBao HTDamBaofrm = null;
        private void HinhThucDamBao_Click(object sender, EventArgs e)
        {
            if (HTDamBaofrm == null || HTDamBaofrm.IsDisposed)
            {
                HTDamBaofrm = new frmHTDamBao();
                HTDamBaofrm.MdiParent = this;
                HTDamBaofrm.Show();
            }
            else
                HTDamBaofrm.Activate();
        }

        frmMucDichVay MucDichVayfrm = null;
        private void MucDichVay_Click(object sender, EventArgs e)
        {
            if (MucDichVayfrm == null || MucDichVayfrm.IsDisposed)
            {
                MucDichVayfrm = new frmMucDichVay();
                MucDichVayfrm.MdiParent = this;
                MucDichVayfrm.Show();
            }
            else
                MucDichVayfrm.Activate();
        }


        frmTaiKhoan DangKiTaiKhoanfrm = null;
        private void DangKiTaiKhoan_Click(object sender, EventArgs e)
        {
            if (DangKiTaiKhoanfrm == null || DangKiTaiKhoanfrm.IsDisposed)
            {
                DangKiTaiKhoanfrm = new frmTaiKhoan();
                DangKiTaiKhoanfrm.MdiParent = this;
                DangKiTaiKhoanfrm.Show();
            }
            else
                DangKiTaiKhoanfrm.Activate();
        }


        frmHoSoKheUoc HoSoKheUocfrm = null;
        private void DangKiKheUoc_Click(object sender, EventArgs e)
        {
            if (HoSoKheUocfrm == null || HoSoKheUocfrm.IsDisposed)
            {
                HoSoKheUocfrm = new frmHoSoKheUoc();
                HoSoKheUocfrm.MdiParent = this;
                HoSoKheUocfrm.Show();
            }
            else
                HoSoKheUocfrm.Activate();
        }

        
        private void DangKiKhachHang_Click(object sender, EventArgs e)
        {
            if (DoiTacfrm == null || DoiTacfrm.IsDisposed)
            {
                DoiTacfrm = new frmDoiTac();
                DoiTacfrm.MdiParent = this;
                DoiTacfrm.Show();
            }
            else
                DoiTacfrm.Activate();
        }

        frmGiaiNgan GiaiNganfrm = null;
        private void GiaiNgan_Click(object sender, EventArgs e)
        {
            if (GiaiNganfrm == null || GiaiNganfrm.IsDisposed)
            {
                GiaiNganfrm = new frmGiaiNgan();
                GiaiNganfrm.MdiParent = this;
                GiaiNganfrm.Show();
            }
            else
                GiaiNganfrm.Activate();
        }


        frmThuVon ThuNofrm = null;
        private void ThuNoThuLai_Click(object sender, EventArgs e)
        {
            if (ThuNofrm == null || ThuNofrm.IsDisposed)
            {
                ThuNofrm = new frmThuVon();
                ThuNofrm.MdiParent = this;
                ThuNofrm.Show();
            }
            else
                ThuNofrm.Activate();
        }

        
        private void LoaiHinh_Click(object sender, EventArgs e)
        {
            if (LoaiHinhfrm == null || LoaiHinhfrm.IsDisposed)
            {
                LoaiHinhfrm = new frmLoaiHinh();
                LoaiHinhfrm.MdiParent = this;
                LoaiHinhfrm.Show();
            }
            else
                LoaiHinhfrm.Activate();
        }

        
        private void DanToc_Click(object sender, EventArgs e)
        {
            if (DanTocfrm == null || DanTocfrm.IsDisposed)
            {
                DanTocfrm = new frmDanToc();
                DanTocfrm.MdiParent = this;
                DanTocfrm.Show();
            }
            else
                DanTocfrm.Activate();
        }


       
        private void DanhSachTinh_Click(object sender, EventArgs e)
        {
            if (Tinhfrm == null || Tinhfrm.IsDisposed)
            {
                Tinhfrm = new frmTinh();
                Tinhfrm.MdiParent = this;
                Tinhfrm.Show();
            }
            else
                Tinhfrm.Activate();
        }


        
        private void DanhSachHuyen_Click(object sender, EventArgs e)
        {
            if (Huyenfrm == null || Huyenfrm.IsDisposed)
            {
                Huyenfrm = new frmHuyen();
                Huyenfrm.MdiParent = this;
                Huyenfrm.Show();
            }
            else
                Huyenfrm.Activate();
        }

       
        private void DanhSachXa_Click(object sender, EventArgs e)
        {
            if (Xafrm == null || Xafrm.IsDisposed)
            {
                Xafrm = new frmXa();
                Xafrm.MdiParent = this;
                Xafrm.Show();
            }
            else
                Xafrm.Activate();
        }

       
        private void NhanVien_Click(object sender, EventArgs e)
        {
            if (NhanVienfrm == null || NhanVienfrm.IsDisposed)
            {
                NhanVienfrm = new frmNhanVien();
                NhanVienfrm.MdiParent = this;
                NhanVienfrm.Show();
            }
            else
                NhanVienfrm.Activate();
        }

    
        private void PhòngBan_Click(object sender, EventArgs e)
        {
            if (PhongBanfrm == null || PhongBanfrm.IsDisposed)
            {
                PhongBanfrm = new frmPhongBan();
                PhongBanfrm.MdiParent = this;
                PhongBanfrm.Show();
            }
            else
                PhongBanfrm.Activate();
        }

      
        private void ChứcVụ_Click(object sender, EventArgs e)
        {
            if (ChucVufrm == null || ChucVufrm.IsDisposed)
            {
                ChucVufrm = new frmChucVu();
                ChucVufrm.MdiParent = this;
                ChucVufrm.Show();
            }
            else
                ChucVufrm.Activate();
        }

       
        private void LoaiVay_Click(object sender, EventArgs e)
        {
            if (LoaiVayfrm == null || LoaiVayfrm.IsDisposed)
            {
                LoaiVayfrm = new frmLoaiVay();
                LoaiVayfrm.MdiParent = this;
                LoaiVayfrm.Show();
            }
            else
                LoaiVayfrm.Activate();
        }
       
        private void KiêuTrả_Click(object sender, EventArgs e)
        {
            if (KieuTrafrm == null || KieuTrafrm.IsDisposed)
            {
                KieuTrafrm = new frmKieuTra();
                KieuTrafrm.MdiParent = this;
                KieuTrafrm.Show();
            }
            else
                KieuTrafrm.Activate();
        }

     
        private void ChuongTrinhChoVay_Click(object sender, EventArgs e)
        {
            if (ChuongTrinhfrm == null || ChuongTrinhfrm.IsDisposed)
            {
                ChuongTrinhfrm = new frmChuongTrinh();
                ChuongTrinhfrm.MdiParent = this;
                ChuongTrinhfrm.Show();
            }
            else
                ChuongTrinhfrm.Activate();
        }

       
        private void HinhThucChoVay_Click(object sender, EventArgs e)
        {
            if (HinhThucVayfrm == null || HinhThucVayfrm.IsDisposed)
            {
                HinhThucVayfrm = new frmHinhThucVay();
                HinhThucVayfrm.MdiParent = this;
                HinhThucVayfrm.Show();
            }
            else
                HinhThucVayfrm.Activate();
        }

        
        private void LaiSuất_Click(object sender, EventArgs e)
        {
            if (LaiSuatfrm == null || LaiSuatfrm.IsDisposed)
            {
                LaiSuatfrm = new frmLaiSuat();
                LaiSuatfrm.MdiParent = this;
                LaiSuatfrm.Show();
            }
            else
                LaiSuatfrm.Activate();
        }

       
        private void HìnhThứcĐảmBảo_Click(object sender, EventArgs e)
        {
            if (HTDamBaofrm == null || HTDamBaofrm.IsDisposed)
            {
                HTDamBaofrm = new frmHTDamBao();
                HTDamBaofrm.MdiParent = this;
                HTDamBaofrm.Show();
            }
            else
                HTDamBaofrm.Activate();
        }

        
        private void MụcĐíchVay_Click(object sender, EventArgs e)
        {
            if (MucDichVayfrm == null || MucDichVayfrm.IsDisposed)
            {
                MucDichVayfrm = new frmMucDichVay();
                MucDichVayfrm.MdiParent = this;
                MucDichVayfrm.Show();
            }
            else
                MucDichVayfrm.Activate();
        }

        
        private void ĐăngKíTàiKhoản_Click(object sender, EventArgs e)
        {
            if (DangKiTaiKhoanfrm == null || DangKiTaiKhoanfrm.IsDisposed)
            {
                DangKiTaiKhoanfrm = new frmTaiKhoan();
                DangKiTaiKhoanfrm.MdiParent = this;
                DangKiTaiKhoanfrm.Show();
            }
            else
                DangKiTaiKhoanfrm.Activate();
        }

      
        private void ĐăngKíKhếUơc_Click(object sender, EventArgs e)
        {
            if (HoSoKheUocfrm == null || HoSoKheUocfrm.IsDisposed)
            {
                HoSoKheUocfrm = new frmHoSoKheUoc();
                HoSoKheUocfrm.MdiParent = this;
                HoSoKheUocfrm.Show();
            }
            else
                HoSoKheUocfrm.Activate();
        }

        
        private void ĐăngKíKháchHàng_Click(object sender, EventArgs e)
        {
            if (DoiTacfrm == null || DoiTacfrm.IsDisposed)
            {
                DoiTacfrm = new frmDoiTac();
                DoiTacfrm.MdiParent = this;
                DoiTacfrm.Show();
            }
            else
                DoiTacfrm.Activate();
        }

    
        private void GiảiNgân_Click(object sender, EventArgs e)
        {
            if (GiaiNganfrm == null || GiaiNganfrm.IsDisposed)
            {
                GiaiNganfrm = new frmGiaiNgan();
                GiaiNganfrm.MdiParent = this;
                GiaiNganfrm.Show();
            }
            else
                GiaiNganfrm.Activate();
        }

      
        //private void ThuNợThuLãi_Click(object sender, EventArgs e)
        //{
        //    if (ThuNoThuLaifrm == null || ThuNoThuLaifrm.IsDisposed)
        //    {
        //        ThuNoThuLaifrm = new frmThuVon();
        //        ThuNoThuLaifrm.MdiParent = this;
        //        ThuNoThuLaifrm.Show();
        //    }
        //    else
        //        ThuNoThuLaifrm.Activate();
        //}

        private void DanhSachLoaiHinh_Click(object sender, EventArgs e)
        {
            if (LoaiHinhfrm == null || LoaiHinhfrm.IsDisposed)
            {
                LoaiHinhfrm = new frmLoaiHinh();
                LoaiHinhfrm.MdiParent = this;
                LoaiHinhfrm.Show();
            }
            else
                LoaiHinhfrm.Activate();
        }

        private void DanhSachDanToc_Click(object sender, EventArgs e)
        {
            if (DanTocfrm == null || DanTocfrm.IsDisposed)
            {
                DanTocfrm = new frmDanToc();
                DanTocfrm.MdiParent = this;
                DanTocfrm.Show();
            }
            else
                DanTocfrm.Activate();
        }

        private void Tinh_Click(object sender, EventArgs e)
        {
            if (Tinhfrm == null || Tinhfrm.IsDisposed)
            {
                Tinhfrm = new frmTinh();
                Tinhfrm.MdiParent = this;
                Tinhfrm.Show();
            }
            else
                Tinhfrm.Activate();
        }

        private void Huyen_Click(object sender, EventArgs e)
        {
            if (Huyenfrm == null || Huyenfrm.IsDisposed)
            {
                Huyenfrm = new frmHuyen();
                Huyenfrm.MdiParent = this;
                Huyenfrm.Show();
            }
            else
                Huyenfrm.Activate();
        }

        private void Xa_Click_1(object sender, EventArgs e)
        {
            if (Xafrm == null || Xafrm.IsDisposed)
            {
                Xafrm = new frmXa();
                Xafrm.MdiParent = this;
                Xafrm.Show();
            }
            else
                Xafrm.Activate();
        }

        private void DanhSachNhanVien_Click(object sender, EventArgs e)
        {
            if (NhanVienfrm == null || NhanVienfrm.IsDisposed)
            {
                NhanVienfrm = new frmNhanVien();
                NhanVienfrm.MdiParent = this;
                NhanVienfrm.Show();
            }
            else
                NhanVienfrm.Activate();
        }

        private void DanhSachPhongBan_Click(object sender, EventArgs e)
        {
            if (PhongBanfrm == null || PhongBanfrm.IsDisposed)
            {
                PhongBanfrm = new frmPhongBan();
                PhongBanfrm.MdiParent = this;
                PhongBanfrm.Show();
            }
            else
                PhongBanfrm.Activate();
        }

        private void DanhSachChucVu_Click(object sender, EventArgs e)
        {
            if (ChucVufrm == null || ChucVufrm.IsDisposed)
            {
                ChucVufrm = new frmChucVu();
                ChucVufrm.MdiParent = this;
                ChucVufrm.Show();
            }
            else
                ChucVufrm.Activate();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (NhanVienfrm == null || NhanVienfrm.IsDisposed)
            {
                NhanVienfrm = new frmNhanVien();
                NhanVienfrm.MdiParent = this;
                NhanVienfrm.Show();
            }
            else
                NhanVienfrm.Activate();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            if (PhongBanfrm == null || PhongBanfrm.IsDisposed)
            {
                PhongBanfrm = new frmPhongBan();
                PhongBanfrm.MdiParent = this;
                PhongBanfrm.Show();
            }
            else
                PhongBanfrm.Activate();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            if (ChucVufrm == null || ChucVufrm.IsDisposed)
            {
                ChucVufrm = new frmChucVu();
                ChucVufrm.MdiParent = this;
                ChucVufrm.Show();
            }
            else
                ChucVufrm.Activate();
        }

        private void LoaiHinh_Click_1(object sender, EventArgs e)
        {
            if (LoaiHinhfrm == null || LoaiHinhfrm.IsDisposed)
            {
                LoaiHinhfrm = new frmLoaiHinh();
                LoaiHinhfrm.MdiParent = this;
                LoaiHinhfrm.Show();
            }
            else
                LoaiHinhfrm.Activate();
        }

        private void DanToc_Click_1(object sender, EventArgs e)
        {
            if (DanTocfrm == null || DanTocfrm.IsDisposed)
            {
                DanTocfrm = new frmDanToc();
                DanTocfrm.MdiParent = this;
                DanTocfrm.Show();
            }
            else
                DanTocfrm.Activate();
        }

        private void DanhSachTinh_Click_1(object sender, EventArgs e)
        {
            if (Tinhfrm == null || Tinhfrm.IsDisposed)
            {
                Tinhfrm = new frmTinh();
                Tinhfrm.MdiParent = this;
                Tinhfrm.Show();
            }
            else
                Tinhfrm.Activate();
        }

        private void DanhSachHuyen_Click_1(object sender, EventArgs e)
        {
            if (Huyenfrm == null || Huyenfrm.IsDisposed)
            {
                Huyenfrm = new frmHuyen();
                Huyenfrm.MdiParent = this;
                Huyenfrm.Show();
            }
            else
                Huyenfrm.Activate();
        }

        private void DanhSachXa_Click_1(object sender, EventArgs e)
        {
            if (Xafrm == null || Xafrm.IsDisposed)
            {
                Xafrm = new frmXa();
                Xafrm.MdiParent = this;
                Xafrm.Show();
            }
            else
                Xafrm.Activate();
        }
        frmQuyen Quyenfrm = null;
        private void PhanQuyen_Click(object sender, EventArgs e)
        {
            if (Quyenfrm == null || Quyenfrm.IsDisposed)
            {
                Quyenfrm = new frmQuyen();
                Quyenfrm.MdiParent = this;
                Quyenfrm.Show();
            }
            else
                Quyenfrm.Activate();
        }

        private void buttonItem54_Click(object sender, EventArgs e)
        {
            if (Quyenfrm == null || Quyenfrm.IsDisposed)
            {
                Quyenfrm = new frmQuyen();
                Quyenfrm.MdiParent = this;
                Quyenfrm.Show();
            }
            else
                Quyenfrm.Activate();
        }

        frmDangKi DangKifrm = null;
        private void DangKiUser_Click(object sender, EventArgs e)
        {
            if (DangKifrm == null || DangKifrm.IsDisposed)
            {
                DangKifrm = new frmDangKi();
                DangKifrm.MdiParent = this;
                DangKifrm.Show();
            }
            else
                DangKifrm.Activate();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        public void DangNhap()
        {
            if (user == null)
            {
                Logon();
                //GioiHanNguoiDung();
            }
            else
                if (MessageBox.Show("Bạn có muốn đăng xuất không đê đăng nhập mới không?", "Quan Ly Nha Hang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Quyen = null;
                    user = null;
                    pass = null;
                    GioiHanNguoiDung();
                    Logon();
                    GioiHanNguoiDung();
                }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }

        public void DangXuat()
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất khỏi hệ thống không?", "Quan Ly Vay Von cho NHCSXH", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Quyen = null;
                user = null;
                pass = null;
                //lgin.txtUsername.Text = null;
                //lgin.txtPassword.Text = null;

                GioiHanNguoiDung();
            }
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            DangXuat();
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            DangXuat();
        }

        private void ebtnDangKiUser_Click(object sender, EventArgs e)
        {
            if (DangKifrm == null || DangKifrm.IsDisposed)
            {
                DangKifrm = new frmDangKi();
                DangKifrm.MdiParent = this;
                DangKifrm.Show();
            }
            else
                DangKifrm.Activate();
        }
        frmThuLai ThuLaifrm = null;
        private void ThuLai_Click(object sender, EventArgs e)
        {
            if (ThuLaifrm == null || ThuLaifrm.IsDisposed)
            {
                ThuLaifrm = new frmThuLai();
                ThuLaifrm.MdiParent = this;
                ThuLaifrm.Show();
            }
            else
                ThuLaifrm.Activate();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        frmDanhSachKhachHang DSKhachHangfrm = null;

        private void DanhSachKhachHang_Click(object sender, EventArgs e)
        {
            if (DSKhachHangfrm == null || DSKhachHangfrm.IsDisposed)
            {
                DSKhachHangfrm = new frmDanhSachKhachHang();
                DSKhachHangfrm.MdiParent = this;
                DSKhachHangfrm.Show();
            }
            else
                DSKhachHangfrm.Activate();
        }
        frmDSTaiKhoan DSTaiKhoanfrm = null;
        private void DanhSachTaiKhoan_Click(object sender, EventArgs e)
        {
            if (DSTaiKhoanfrm == null || DSTaiKhoanfrm.IsDisposed)
            {
                DSTaiKhoanfrm = new frmDSTaiKhoan();
                DSTaiKhoanfrm.MdiParent = this;
                DSTaiKhoanfrm.Show();
            }
            else
                DSTaiKhoanfrm.Activate();
        }
        frmDanhSachKheUoc DSKheUocfrm = null;
        private void DanhSachKheUoc_Click(object sender, EventArgs e)
        {
            if (DSKheUocfrm == null || DSKheUocfrm.IsDisposed)
            {
                DSKheUocfrm = new frmDanhSachKheUoc();
                DSKheUocfrm.MdiParent = this;
                DSKheUocfrm.Show();
            }
            else
                DSKheUocfrm.Activate();
        }

        private void tbnGiupDo_Click(object sender, EventArgs e)
        {
            GiupDo();
        }


        

        public void GiupDo()
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.TableOfContents);
        }



        frmChiTietThuLai CTThuLaiifrm = null;
        private void btnPhieuthu_Click(object sender, EventArgs e)
        {
            if (CTThuLaiifrm == null || CTThuLaiifrm.IsDisposed)
            {
                CTThuLaiifrm = new frmChiTietThuLai();
                CTThuLaiifrm.MdiParent = this;
                CTThuLaiifrm.Show();
            }
            else
                CTThuLaiifrm.Activate();
        }
        frmPhieuChi PCfrm = null;
        private void btnPhieuchi_Click(object sender, EventArgs e)
        {
            if (PCfrm == null || PCfrm.IsDisposed)
            {
                PCfrm  = new frmPhieuChi();
                PCfrm.MdiParent = this;
                PCfrm.Show();
            }
            else
                PCfrm.Activate();
        }

       
    }
}