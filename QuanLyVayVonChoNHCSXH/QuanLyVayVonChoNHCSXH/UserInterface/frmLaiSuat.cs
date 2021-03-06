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
    public partial class frmLaiSuat : Form
    {
        LaiSuatController LSctrl = new LaiSuatController();
        ThamSo.Controll status = ThamSo.Controll.Normal;  
        public frmLaiSuat()
        {
            InitializeComponent();
          //  ThamSo.Controll status = ThamSo.Controll.Addnew;  
        }

         public frmLaiSuat(LaiSuatController ctrlls)
            : this()
        {
            this.LSctrl = ctrlls;
            status = ThamSo.Controll.Normal;
        }


        private void frmLaiSuat_Load(object sender, EventArgs e)
        {
            LSctrl.HienThiDataGridView(dataGridViewLS, bindingNavigatorLS,txtMaLaiSuat,txtLaiSuat,txtLSQuaHan,txtLSTren,txtTenLoaiLS);
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
            DataRow row = LSctrl.NewRow();
            row["MaLaiSuat"] = "";
            row["LaiSuat"] = 0;
            row["LSQuaHan"] = 0;
            row["LSTren"] = "";          
            row["TenLoaiLS"] = "";            
            LSctrl.Add(row);
            bindingNavigatorLS.BindingSource.MoveLast();
            txtMaLaiSuat.Focus();
                       
        }

        private void Xoá_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Lai Suat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLS.BindingSource.RemoveCurrent();
                LSctrl.Save();
            }
        }

        private void Lưu_Click(object sender, EventArgs e)
        {          
            txtMaLaiSuat.Focus();
            bindingNavigatorLS.BindingSource.MoveNext();
            KiemTra();
            if (status == ThamSo.Controll.noreally)
            {
                MessageBox.Show("Thông tin còn thiếu nên lãi suất không được lưu", "Lai Suat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LSctrl.Save();
                Allow(false);
            }
            status = ThamSo.Controll.Save;
            
        }

        void Allow(bool val)
        {
            txtMaLaiSuat.Enabled = val;
            txtLaiSuat.Enabled = val;
            txtLSTren.Enabled = val;
            txtLSQuaHan.Enabled = val; 
            txtTenLoaiLS.Enabled = val;                     
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
           LSctrl.Update();
        }

        void ThemMoi()
        {
            DataRow row = LSctrl.NewRow();
            row["MaLaiSuat"] = "";
            row["LaiSuat"] = "";
            row["LSTren"] = "";
            row["LSQuaHan"] = "";
            row["TenLoaiLS"] = "";
            LSctrl.Add(row);            
        }

        void KiemTra()
        {
            if (txtMaLaiSuat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã lãi suất !", "Lai Suat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLaiSuat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lãi suất !", "Lai Suat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            else if (txtLSQuaHan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lãi suất quá hạn", "Lai Suat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenLoaiLS.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại lãi suất!", "Lai Suat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaLaiSuat.Text == "" || txtLaiSuat.Text == "" || txtLSQuaHan.Text == "" || txtTenLoaiLS.Text == "")
            {
                status = ThamSo.Controll.noreally;
            }

        }




        private void ToolTimMaLaiSuat_Click(object sender, EventArgs e)
        {
            ToolTimTenLaiSuat.Checked = false;
            ToolTimMaLaiSuat.Checked = true;
            if (Test())
                toolTimLaiSuat.Text = "Mã Lãi Suất";
            bindingNavigatorLS.Focus();
        }

        private void ToolTimTenLaiSuat_Click(object sender, EventArgs e)
        {
            ToolTimTenLaiSuat.Checked = true;
            ToolTimMaLaiSuat.Checked = false;
            if (Test())
                toolTimLaiSuat.Text = "Lãi Suất";
            bindingNavigatorLS.Focus();
        }

        private void toolTimLaiSuat_Leave(object sender, EventArgs e)
        {
            if (Test())
            {
                if (ToolTimMaLaiSuat.Checked == true)
                    toolTimLaiSuat.Text = "Mã Lãi Suất";
                else
                    toolTimLaiSuat.Text = "Lãi Suất";
            }
        }

        private void toolTimLaiSuat_Enter(object sender, EventArgs e)
        {
            toolTimLaiSuat.Text = "";
            toolTimLaiSuat.ForeColor = Color.Black;
        }

        private void toolTimLaiSuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ToolTimMaLaiSuat.Checked)
                    LSctrl.TimMaLaiSuat(toolTimLaiSuat.Text);
                else
                    LSctrl.TimTenLaiSuat(toolTimLaiSuat.Text);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
                if (ToolTimMaLaiSuat.Checked)
                    LSctrl.TimMaLaiSuat(toolTimLaiSuat.Text);
                else
                    LSctrl.TimTenLaiSuat(toolTimLaiSuat.Text);
            
        }

        private void XemLai_Click(object sender, EventArgs e)
        {
            LSctrl.HienThiDataGridView(dataGridViewLS, bindingNavigatorLS, txtMaLaiSuat, txtLaiSuat, txtLSQuaHan, txtLSTren, txtTenLoaiLS);
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Test()
        {
            String str = toolTimLaiSuat.Text;
            if (str == "Mã lãi suất" || str == "Tên lãi suất")
                return true;
            return false;
        }

        private void dataGridViewLS_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void toolSua_Click(object sender, EventArgs e)
        {
            status = ThamSo.Controll.Edit;
            this.Allow(true);
        }
    }
}