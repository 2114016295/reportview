using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportview
{
    public partial class 数据窗口增删改查 : Form
    {
        public 数据窗口增删改查()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter adapter;
        private void 数据窗口增删改查_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=.;database=MKPathologyDB_test;uid=sa;pwd=123456");
            SqlDataAdapter sda = new SqlDataAdapter("Select *from XT_User", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }
        private DataTable dbconn(string strSql)
        {
            conn.Open();
            this.adapter = new SqlDataAdapter(strSql, conn);
            DataTable dtselect = new DataTable();
            int rnt = this.adapter.Fill(dtselect);
            conn.Close();
            return dtselect;
        }
        private Boolean dbupdate()
        {
            string strSql = "select *from XT_User";
            DataTable dtUpdate = new DataTable();
            dtUpdate = this.dbconn(strSql);
            dtUpdate.Rows.Clear();
            DataTable dtshow = new DataTable();
            dtshow = (DataTable)this.gridControl1.DataSource;
            for (int i = 0; i < dtshow.Rows.Count; i++)
            {
                dtUpdate.ImportRow(dtshow.Rows[i]);
            }
            try
            {
                this.conn.Open();
                SqlCommandBuilder commandBuilder;
                commandBuilder = new SqlCommandBuilder(this.adapter);
                int j = this.adapter.Update(dtUpdate);
                button1.Text = j.ToString();
                this.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            dtUpdate.AcceptChanges();
            return true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dbupdate())
            {
                MessageBox.Show("数据修改成功");
            }
        }
    }
}
