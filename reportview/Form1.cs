using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“MKPathologyDB_testDataSet.XT_User”中。您可以根据需要移动或删除它。
            //this.XT_UserTableAdapter.Fill(this.MKPathologyDB_testDataSet.XT_User);
            // TODO: 这行代码将数据加载到表“MKPathologyDB_testDataSet.XT_User”中。您可以根据需要移动或删除它。
            //this.XT_UserTableAdapter.Fill(this.MKPathologyDB_testDataSet.XT_User);
            // TODO: 这行代码将数据加载到表“MKPathologyDB_testDataSet.XT_User”中。您可以根据需要移动或删除它。
            //this.XT_UserTableAdapter.Fill(this.MKPathologyDB_testDataSet.XT_User);

            //this.reportViewer1.RefreshReport();
            //getdata get = new getdata();
            //ReportDataSource rds = new ReportDataSource
            //{
            //    Name = "dataSet1",  //你的数据集名称
            //    Value = getdata.GetData(textBox1.Text)

            // };
            //reportViewer1.LocalReport.DataSources.Add(rds);


            //reportViewer1.RefreshReport();
            //reportViewer1.LocalReport.ReportPath = ".../.../Report2.rdlc";
            //var dt = new DataTable();
            //dt.Columns.Add("brxm", typeof(string));
            //dt.Columns.Add("brnl", typeof(string));
            //dt.Columns.Add("brxb", typeof(string));
            //dt.Columns.Add("jymd", typeof(string));
            ////dt.Rows.Add(new string[] { dt.Rows[0]["brxm"].ToString(), dt.Rows[0]["brnl"].ToString(), dt.Rows[0]["brxb"].ToString(), dt.Rows[0]["jymd"].ToString() });
            ////dt.Rows.Add(new string[] { "侯康杰","22","男", "体检" });
            //dt.Rows.Add("侯康杰", "22", "男", "体检");
            //reportViewer1.LocalReport.ReportPath = ".../.../Report3.rdlc";
            //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DateSet1",dt));
            //reportViewer1.RefreshReport();
            DataTable dt = new DataTable();         //创建一个datatable  

            dt.Columns.Add("name", typeof(string));//定义类型
            dt.Columns.Add("age", typeof(string));

            dt.Rows.Add("小红", "5"); //添加数据
            dt.Rows.Add("小花", "4");
            dt.Rows.Add("大董", "20");
            dataGridView1.DataSource = dt;

            this.reportViewer1.LocalReport.ReportPath = ".../.../Report3.rdlc";  //查找要绑定的报表  
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;

            this.reportViewer1.LocalReport.DataSources.Add(rds);  //绑定数据源  

            this.reportViewer1.RefreshReport();
        }
    }
}
