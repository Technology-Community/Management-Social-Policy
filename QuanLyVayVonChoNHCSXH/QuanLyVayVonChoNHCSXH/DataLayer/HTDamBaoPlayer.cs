using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class HTDamBaoPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachHTDamBao()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HTDamBao");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayHTDamBao(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HTDamBao WHERE MaHTDamBao = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimHTDamBaoTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM HTDamBao WHERE TenHTDamBao LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimHTDamBaoTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM HTDamBao WHERE MaHTDamBao LIKE '%' + @ma +'%' ");
            cmd.Parameters.Add("ma", SqlDbType.NVarChar, 50).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataRow NewRow()
        {
            return m_Ds.NewRow();
        }

        public void Add(DataRow row)
        {
            m_Ds.Rows.Add(row);
        }

        public bool Save()
        {
            return (m_Ds.ExecuteNoneQuery() > 0);
        }
    }
}
