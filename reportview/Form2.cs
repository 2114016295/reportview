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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public DataTable dt;         //创建一个datatable  
        public DataTable dt_xml;         //创建一个datatable  
        private void Form2_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt_xml = new DataTable();
            dt_xml.Columns.Add("BingLiZhenDuan", typeof(string));
            dt_xml.Columns.Add("JingXiaSuoJian", typeof(string));
            dt_xml.Columns.Add("RouYanSuoJian", typeof(string));
            dt_xml.Columns.Add("TeShuJianCha", typeof(string));
            //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));  //绑定数据源  
            //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt_xml));  //绑定数据源  
            //this.reportViewer1.RefreshReport();

            //dt = getdata.GetData("sss");
            //dataGridView1.DataSource = dt;
            //string sql2 = string.Format("select resultXML.value('(/root/data/BingLiZhenDuan)[1]','nvarchar(max)') as BingLiZhenDuan," +
            //                                     "resultXML.value('(/root/data/JingXiaSuoJian)[1]', 'nvarchar(max)') as JingXiaSuoJian," +
            //                                     "resultXML.value('(/root/data/RouYanSuoJian)[1]', 'nvarchar(max)') as RouYanSuoJian," +
            //                                     "resultXML.value('(/root/data/TeShuJianCha)[1]', 'nvarchar(max)') as TeShuJianChafrom from BL_Sampleinfo where pathologyNo='BL2201863' ");
            ////dt.Columns.Add("name", typeof(string));//定义类型
            ////dt.Columns.Add("age", typeof(string));
            ////dt.Columns.Add("name", typeof(string));//定义类型

            //dt_xml.Columns.Add("BingLiZhenDuan", typeof(string));
            //dt_xml.Columns.Add("JingXiaSuoJian", typeof(string));
            //dt_xml.Columns.Add("RouYanSuoJian", typeof(string));
            //dt_xml.Columns.Add("TeShuJianCha", typeof(string));
            //dt_xml=DBhelper.GetTable("A", sql2);
            ////dt.Rows.Add("小红", 5); //添加数据
            ////dt.Rows.Add("小花", 4);
            ////dt.Rows.Add("大董", 20);
            ////dt_xml.Rows.Add(dt_xml.Rows[0]["BingLiZhenDuan"].ToString(), dt_xml.Rows[0]["JingXiaSuoJian"].ToString(), dt_xml.Rows[0]["RouYanSuoJian"].ToString(), dt_xml.Rows[0]["TeShuJianCha"].ToString()); //添加数据

            ////this.reportViewer1.LocalReport.ReportPath = ".../.../Report1.rdlc";  //查找要绑定的报表  
            //dataGridView2.DataSource = dt_xml;
            //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));  //绑定数据源  
            //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt_xml));  //绑定数据源  
            //this.reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
           
            
            dt = getdata.GetData(textBox1.Text);
            dataGridView1.DataSource = dt;
            string sql2 = string.Format("select resultXML.value('(/root/data/BingLiZhenDuan)[1]','nvarchar(max)') as BingLiZhenDuan," +
                                                 "resultXML.value('(/root/data/JingXiaSuoJian)[1]', 'nvarchar(max)') as JingXiaSuoJian," +
                                                 "resultXML.value('(/root/data/RouYanSuoJian)[1]', 'nvarchar(max)') as RouYanSuoJian," +
                                                 "resultXML.value('(/root/data/TeShuJianCha)[1]', 'nvarchar(max)') as TeShuJianChafrom from BL_Sampleinfo where barcode='{0}' ",textBox1.Text);
            //dt.Columns.Add("name", typeof(string));//定义类型
            //dt.Columns.Add("age", typeof(string));
            //dt.Columns.Add("name", typeof(string));//定义类型

            
            dt_xml = DBhelper.GetTable("A", sql2);
            //dt.Rows.Add("小红", 5); //添加数据
            //dt.Rows.Add("小花", 4);
            //dt.Rows.Add("大董", 20);
            //dt_xml.Rows.Add(dt_xml.Rows[0]["BingLiZhenDuan"].ToString(), dt_xml.Rows[0]["JingXiaSuoJian"].ToString(), dt_xml.Rows[0]["RouYanSuoJian"].ToString(), dt_xml.Rows[0]["TeShuJianCha"].ToString()); //添加数据

            //this.reportViewer1.LocalReport.ReportPath = ".../.../Report1.rdlc";  //查找要绑定的报表  
            dataGridView2.DataSource = dt_xml;
 
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));  //绑定数据源  
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt_xml));  //绑定数据源  
            this.reportViewer1.RefreshReport();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //textBox2.Text = checkBox1.value;
        }
    }
}
