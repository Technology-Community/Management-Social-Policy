using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class ThuLaiController
    {
        ThuLaiPlayer TLplayer = new ThuLaiPlayer();
        BindingSource bs = new BindingSource();
        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "SoButToan";
            cmb.ValueMember = "SoButToan";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "SoButToan";
            cmb.ValueMember = "SoButToan";
            cmb.DataPropertyName = "SoButToan";
            cmb.HeaderText = "ThuLai";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn, TextBox txtSoButToan, DateTimePicker dtpNgayTL,DateTimePicker dtpNgayTinhLai, ComboBox cmbMaSoKU, TextBox txtSoTienLaiTH, NumericUpDown numSoTienGoc, TextBox txtSoTienLaiQH, ComboBox cmbMaLoaiChungTu, ComboBox cmbTaiKhoanNo, ComboBox cmbTaiKhoanCo)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = TLplayer.DanhSachThuLai();
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtSoButToan.DataBindings.Clear();
            txtSoButToan.DataBindings.Add("Text", bs, "SoButToan");

            try
            {
                dtpNgayTL.DataBindings.Clear();
                dtpNgayTL.DataBindings.Add("Value", bs, "NgayTL");
            }
            catch { }

            try
            {
                dtpNgayTinhLai.DataBindings.Clear();
                dtpNgayTinhLai.DataBindings.Add("Value", bs, "NgayTinhLai");
            }
            catch { }


            cmbMaSoKU.DataBindings.Clear();
            cmbMaSoKU.DataBindings.Add("SelectedValue", bs, "MaSoKU");



            txtSoTienLaiTH.DataBindings.Clear();
            txtSoTienLaiTH.DataBindings.Add("Text", bs, "SoTienLaiTH");

            numSoTienGoc.DataBindings.Clear();
            numSoTienGoc.DataBindings.Add("Value", bs, "SoTienGoc");

            txtSoTienLaiQH.DataBindings.Clear();
            txtSoTienLaiQH.DataBindings.Add("Text", bs, "SoTienLaiQH");


            cmbMaLoaiChungTu.DataBindings.Clear();
            cmbMaLoaiChungTu.DataBindings.Add("SelectedValue", bs, "MaLoaiChungTu");

            cmbTaiKhoanNo.DataBindings.Clear();
            cmbTaiKhoanNo.DataBindings.Add("SelectedValue", bs, "TaiKhoanNo");

            cmbTaiKhoanCo.DataBindings.Clear();
            cmbTaiKhoanCo.DataBindings.Add("SelectedValue", bs, "TaiKhoanCo");





        }

        public ThuLai LayThuLai(String ma)
        {
            DataTable tbl = new DataTable();
            tbl = TLplayer.LayThuLai(ma);
            ThuLai TL = null;
            if (tbl.Rows.Count > 0)
            {
                TL = new ThuLai();
                TL.sobuttoan = Convert.ToString(tbl.Rows[0]["SoButToan"]);
                TL.ngaytl = Convert.ToDateTime(tbl.Rows[0]["NgayTL"]);
                TL.ngaytinhlai = Convert.ToDateTime(tbl.Rows[0]["NgayTinhLai"]);
                TL.masoku = Convert.ToString(tbl.Rows[0]["MaSoKU"]);
                TL.sotienlaith = Convert.ToDouble(tbl.Rows[0]["SoTienLaiTH"]);
                TL.sotiengoc = Convert.ToDouble(tbl.Rows[0]["SoTienGoc"]);
                TL.sotienlaiqh = Convert.ToDouble(tbl.Rows[0]["SoTienLaiQH"]);
                TL.maloaichungtu = Convert.ToString(tbl.Rows[0]["MaLoaiChungTu"]);
                TL.taikhoanno = Convert.ToString(tbl.Rows[0]["TaiKhoanNo"]);
                TL.taikhoanco = Convert.ToString(tbl.Rows[0]["TaiKhoanCo"]);

            }

            return TL;
        }

       public void TimMaThuLai(DataGridView dg, BindingNavigator bn, TextBox txtSoButToan, DateTimePicker dtpNgayTL, DateTimePicker dtpNgayTinhLai, ComboBox cmbMaSoKU, TextBox txtSoTienLaiTH, NumericUpDown numSoTienGoc, TextBox txtSoTienLaiQH, ComboBox cmbMaLoaiChungTu, ComboBox cmbTaiKhoanNo, ComboBox cmbTaiKhoanCo, String SoButToan)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = TLplayer.TimThuLaiTheoMa(SoButToan);
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtSoButToan.DataBindings.Clear();
            txtSoButToan.DataBindings.Add("Text", bs, "SoButToan");

            try
            {
                dtpNgayTL.DataBindings.Clear();
                dtpNgayTL.DataBindings.Add("Value", bs, "NgayTL");
            }
            catch { }

            try
            {
                dtpNgayTinhLai.DataBindings.Clear();
                dtpNgayTinhLai.DataBindings.Add("Value", bs, "NgayTinhLai");
            }
            catch { }

            cmbMaSoKU.DataBindings.Clear();
            cmbMaSoKU.DataBindings.Add("SelectedValue", bs, "MaSoKU");



            txtSoTienLaiTH.DataBindings.Clear();
            txtSoTienLaiTH.DataBindings.Add("Text", bs, "SoTienLaiTH");

            numSoTienGoc.DataBindings.Clear();
            numSoTienGoc.DataBindings.Add("Value", bs, "SoTienGoc");

            txtSoTienLaiQH.DataBindings.Clear();
            txtSoTienLaiQH.DataBindings.Add("Text", bs, "SoTienLaiQH");


            cmbMaLoaiChungTu.DataBindings.Clear();
            cmbMaLoaiChungTu.DataBindings.Add("SelectedValue", bs, "MaLoaiChungTu");

            cmbTaiKhoanNo.DataBindings.Clear();
            cmbTaiKhoanNo.DataBindings.Add("SelectedValue", bs, "TaiKhoanNo");

            cmbTaiKhoanCo.DataBindings.Clear();
            cmbTaiKhoanCo.DataBindings.Add("SelectedValue", bs, "TaiKhoanCo");


        }

       public void TimMaSoKUThuLai(DataGridView dg, BindingNavigator bn, TextBox txtSoButToan, DateTimePicker dtpNgayTL, DateTimePicker dtpNgayTinhLai, ComboBox cmbMaSoKU, TextBox txtSoTienLaiTH, NumericUpDown numSoTienGoc,TextBox txtSoTienLaiQH, ComboBox cmbMaLoaiChungTu, ComboBox cmbTaiKhoanNo, ComboBox cmbTaiKhoanCo, String masoku)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = TLplayer.TimThuLaiTheoMaSoKU(masoku);
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtSoButToan.DataBindings.Clear();
            txtSoButToan.DataBindings.Add("Text", bs, "SoButToan");

            try
            {
                dtpNgayTL.DataBindings.Clear();
                dtpNgayTL.DataBindings.Add("Value", bs, "NgayTL");
            }
            catch { }

            try
            {
                dtpNgayTinhLai.DataBindings.Clear();
                dtpNgayTinhLai.DataBindings.Add("Value", bs, "NgayTinhLai");
            }
            catch { }

            cmbMaSoKU.DataBindings.Clear();
            cmbMaSoKU.DataBindings.Add("SelectedValue", bs, "MaSoKU");



            txtSoTienLaiTH.DataBindings.Clear();
            txtSoTienLaiTH.DataBindings.Add("Text", bs, "SoTienLaiTH");

            numSoTienGoc.DataBindings.Clear();
            numSoTienGoc.DataBindings.Add("Value", bs, "SoTienGoc");

            txtSoTienLaiQH.DataBindings.Clear();
            txtSoTienLaiQH.DataBindings.Add("Text", bs, "SoTienLaiQH");


            cmbMaLoaiChungTu.DataBindings.Clear();
            cmbMaLoaiChungTu.DataBindings.Add("SelectedValue", bs, "MaLoaiChungTu");

            cmbTaiKhoanNo.DataBindings.Clear();
            cmbTaiKhoanNo.DataBindings.Add("SelectedValue", bs, "TaiKhoanNo");

            cmbTaiKhoanCo.DataBindings.Clear();
            cmbTaiKhoanCo.DataBindings.Add("SelectedValue", bs, "TaiKhoanCo");


        }


        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = TLplayer.DanhSachThuLai();
            cmb.DisplayMember = "SoButToan";
            cmb.ValueMember = "SoButToan";

        }

        public void Update()
        {

            bs.MoveNext();
            TLplayer.Save();
        }

        public DataRow NewRow()
        {
            return TLplayer.NewRow();
        }
        public void Add(DataRow row)
        {
            TLplayer.Add(row);
        }
        public bool Save()
        {
            return TLplayer.Save();
        }
        //Tinh ngay
        public int TinhNgayTH(String maku)
        {
            ThuLaiPlayer data = new ThuLaiPlayer();
            DataTable tbl = data.LayTinhLai(maku);
            //DataRow row = tbl.Rows[0];
            int SoNgay = 0;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {

                DateTime d1 = Convert.ToDateTime(tbl.Rows[i]["NgayTL"].ToString());
                DateTime d2 = Convert.ToDateTime(tbl.Rows[i]["NgayTinhLai"].ToString());
                DateTime d3 = Convert.ToDateTime(tbl.Rows[i]["NgayTra"].ToString());
                if (d1 <= d3)
                {
                    SoNgay = Convert.ToInt32(d1.ToOADate() - d2.ToOADate());
                }
                else
                    SoNgay = Convert.ToInt32(d3.ToOADate() - d2.ToOADate());

            }

            return SoNgay;


        }

        // tinh so ngay qua hạn

        public int TinhNgayQH(String maku)
        {
            ThuLaiPlayer data = new ThuLaiPlayer();
            DataTable tbl = data.LayTinhLai(maku);
            //DataRow row = tbl.Rows[0];
            int SoNgay = 0;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {

                DateTime d1 = Convert.ToDateTime(tbl.Rows[i]["NgayTL"].ToString());
                DateTime d2 = Convert.ToDateTime(tbl.Rows[i]["NgayTinhLai"].ToString());
                DateTime d3 = Convert.ToDateTime(tbl.Rows[i]["NgayTra"].ToString());
                if (d1 <= d3)
                {
                    SoNgay = 0;
                }
                else
                    SoNgay = Convert.ToInt32(d1.ToOADate() - d3.ToOADate());

            }

            return SoNgay;


        }
        //Tinh Lai trong han
        public double TinhLai(String maku)
        {
            double m_TinhLai = 0;
            double tinhngay = 0;
            DataTable dt = TLplayer.LayTinhLai(maku);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tinhngay = TinhNgayTH(maku);

                m_TinhLai = Convert.ToDouble(dt.Rows[i]["SoTienGoc"]) * Convert.ToDouble(dt.Rows[i]["LaiSuat"]) / 100 * Convert.ToDouble(tinhngay / 30);



            }

            return m_TinhLai;
        }

        //tinh lai qua hạn


        public double TinhLaiQH(String maku)
        {
            double m_TinhLai = 0;
            double tinhngay = 0;
            DataTable dt = TLplayer.LayTinhLai(maku);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tinhngay = TinhNgayQH(maku);
                m_TinhLai = Convert.ToDouble(dt.Rows[i]["SoTienGoc"]) * Convert.ToDouble(dt.Rows[i]["LSQuaHan"]) / 100 * Convert.ToDouble(tinhngay / 30);

            }

            return m_TinhLai;
        }




    }
}
