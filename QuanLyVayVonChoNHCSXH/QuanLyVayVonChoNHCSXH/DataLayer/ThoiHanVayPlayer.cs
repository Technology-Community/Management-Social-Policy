using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class ThoiHanVayPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachThoiHanVay()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThoiHanVay");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayThoiHanVay(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThoiHanVay WHERE MaThoiHanVay = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimThoiHanVayTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM ThoiHanVay WHERE TenThoiHanVay LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimThoiHanVayTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM ThoiHanVay WHERE MaThoiHanVay LIKE '%' + @ma +'%' ");
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
