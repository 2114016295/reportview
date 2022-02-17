using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportview
{
    class DBhelper
    {
        public static SqlConnectionStringBuilder SqlConnectionBulider { get; set; }
        public static SqlConnection GetLisDB() //获得Sqlconnection连接
        {
            if (SqlConnectionBulider == null)
            {
                
                SqlConnectionBulider = new SqlConnectionStringBuilder();
                SqlConnectionBulider.DataSource ="10.36.100.221";       //服务器名称
                SqlConnectionBulider.UserID = "lisuser";
                try
                {
                    SqlConnectionBulider.Password = "lisuser";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                //SqlConnectionBulider.InitialCatalog = "mkliscenter";
                SqlConnectionBulider.InitialCatalog = "MKPathologyDB";
                SqlConnectionBulider.PersistSecurityInfo = true;
                SqlConnectionBulider.ConnectTimeout = 30;
            }

            return new SqlConnection(SqlConnectionBulider.ToString());
        }
        public static DataTable GetTable(string table_Name, string sql)  //查询语句 ，返回table
        {
            using (var db = GetLisDB())
            {
                //try
                //{
                //    SqlConnection conn = (SqlConnection)db;
                //    conn.Open();
                //    SqlCommand cmd = new SqlCommand(sql, conn);
                //    SqlDataAdapter sdAdapter = new SqlDataAdapter(cmd);
                //    DataSet ds = new DataSet();
                //    DataTable table = new DataTable(table_Name);
                //    sdAdapter.Fill(ds, table_Name);
                //    table = ds.Tables[table_Name];
                //    return table;
                //    conn.Close();
                //}
                //catch (Exception ex)
                //{
                //    DataTable table = new DataTable();
                //    return table;
                //}
                SqlConnection conn = (SqlConnection)db;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter sdAdapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    DataTable table = new DataTable(table_Name);
                    sdAdapter.Fill(ds, table_Name);
                    table = ds.Tables[table_Name];
                    return table;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    //UIMessageBox.ShowError("数据库连接错误!!");
                    DataTable table = new DataTable();
                    return table;
                    System.Environment.Exit(0);  //结束所有进程
                }

            }
        }
    }
}
