using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace QuanLyVayVonChoNHCSXH.Setting
{
    public class DataService: DataTable
    {    
        public static String Servername;
        public static String Database;
        public static String User;
        public static String Pass;
        public static String Security;
        public static SqlConnection m_Connection;
        private SqlDataAdapter m_DataAdapter;
        private DataSet m_Dataset;
        private SqlCommand m_Command;
        public static String m_ConnectionString;

        public DataService()
        {        
            m_Connection = new SqlConnection(GetString());
            OpenConnection();
        }

        public SqlCommand Command
        {
            get { return m_Command; }
            set { m_Command = value; }
        }

        public void Load(SqlCommand command)
        {
            m_Command = command;
            try
            {
                this.Clear();
                m_Command.Connection = m_Connection;
                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;
                m_DataAdapter.Fill(this);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //MessageBox.Show("Không thể kết nối hệ thống CSDL,vui lòng Start SQL Server", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool OpenConnection()
        {
            try
            {
                if (m_Connection == null)
                    m_Connection = new SqlConnection(m_ConnectionString);

                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch (Exception e)
            {
                m_Connection.Close();
                return false;
            }

        }
        /// <summary>
        /// Closes the connection of this data service.
        /// </summary>
        public void CloseConnection()
        {
            m_Connection.Close();
        }

        /// <summary>
        /// Update DataTable
        /// </summary>
        /// <returns></returns>
        public int ExecuteNoneQuery()
        {
            int result = 0;
            SqlTransaction tr = null;
            // m_Dataset = new DataSet();
            try
            {
                tr = m_Connection.BeginTransaction();

                m_Command.Connection = m_Connection;
                m_Command.Transaction = tr;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                SqlCommandBuilder builder = new SqlCommandBuilder(m_DataAdapter);
                result = m_DataAdapter.Update(this);          
                tr.Commit();
            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();
            }
            return result;
        }
        
        /// <summary>
        /// Thuc thi mot command
        /// </summary>
        /// <param name="command">OleDb hay Store Procedure</param>
        /// <returns></returns>
        public int ExecuteNoneQuery(SqlCommand cmd)
        {
            int result = 0;
            SqlTransaction tr = null;
            try
            {
            tr = m_Connection.BeginTransaction();
            cmd.Connection = m_Connection;
            cmd.Transaction = tr;
            result = cmd.ExecuteNonQuery();
            this.AcceptChanges();
            tr.Commit();
            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();
                throw;
            }
            return result;
        }
        public object ExecuteScalar(SqlCommand cmd)
        {
            object result = null;
            SqlTransaction tr = null;

            try
            {
                tr = m_Connection.BeginTransaction();
                cmd.Connection = m_Connection;
                cmd.Transaction = tr;
                result = cmd.ExecuteScalar();
                this.AcceptChanges();
                tr.Commit();
                if (result == DBNull.Value)
                {
                    result = null;
                }
            }
            catch
            {
                if (tr != null) tr.Rollback();
                throw;
            }
            return result;
        }

        // Lay duong dan toi file ccsdl
        public static String GetString()
        {
            try
            {
                string path = Application.StartupPath;
                path = path.ToLower();
                path = path.Replace("bin\\debug", "Setting\\PathToDB.xml");
                //path = "PathToDB.xml";
                XmlDocument ThongTinSQL = Doc_XML(path);
                XmlElement Goc = ThongTinSQL.DocumentElement;
                Servername = Goc.SelectSingleNode("Servername").InnerText;
                Database = Goc.SelectSingleNode("Database").InnerText;
                User = Goc.SelectSingleNode("Username").InnerText;
                Pass = Goc.SelectSingleNode("Password").InnerText;
                Security = Goc.SelectSingleNode("IntegratedSecurity").InnerText;
            }
            catch
            {
                MessageBox.Show("Không tim thấy đường dẫn đến file định dạng");
            }
            //return m_ConnectionString = "Data Source=" + Servername + ";Initial Catalog=" + Database + ";Integrated Security=True;";
            return m_ConnectionString = "Data Source =" + Servername + "; User ID =" + User + "; Password =" + Pass + "; Initial Catalog =" + Database + "; Integrated Security=" + Security + ";";
        }

        public static XmlDocument Doc_XML(string tenfileXML)
        {
            XmlDocument kq = new XmlDocument();
            try
            {
                kq.Load(tenfileXML);
            }
            catch
            {
                MessageBox.Show("Không đọc được file cấu hình !");
            }
            return kq;
        }

        public String servername
        {
            get { return Servername; }
        }

        public String database
        {
            get { return Database; }
        }

        public String username
        {
            get { return User; }
        }

        public String password
        {
            get { return Pass; }
        }

        public String security
        {
            get { return Security; }
        }


    }
}
