using System;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using QuanLyVayVonChoNHCSXH.DataPlyer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
    public class DangKyController
    {
        DangKyPlayer DKplayer = new DangKyPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            cmb.DataSource = DKplayer.DanhSachUsername();
            cmb.DisplayMember = "Username";
            cmb.ValueMember = "Username";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = DKplayer.DanhSachUsername();
            cmb.DisplayMember = "Username";
            cmb.ValueMember = "Username";
            cmb.DataPropertyName = "Username";
            cmb.HeaderText = "Username";

            //return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DKplayer.DanhSachUsername();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public Username LayUser(String user)
        {
            DataTable tbl = DKplayer.LayUsername(user);
            Username User = null;

            if (tbl.Rows.Count > 0)
                User = new Username(Convert.ToString(tbl.Rows[0]["Username"]), Convert.ToString(tbl.Rows[0]["Password"]), Convert.ToString(tbl.Rows[0]["Quyen"]));

            return User;
        }
        //public bool Save()
        //{
        //    return DKplayer.Save();
        //}

        public bool Save(String user, String pass, String quyen, String nv)
        {
            String strPass = null;

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);
            bs = md5.ComputeHash(bs);
            foreach (byte b in bs)
            {
                strPass += (b.ToString("x2").ToLower());
            }

            return DKplayer.Save(user, strPass, quyen, nv);
        }
    }
}
