namespace reportview
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new reportview.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.XT_UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MKPathologyDB_testDataSet = new reportview.MKPathologyDB_testDataSet();
            this.XT_UserTableAdapter = new reportview.MKPathologyDB_testDataSetTableAdapters.XT_UserTableAdapter();
            this.mkliscenterDataSet = new reportview.mkliscenterDataSet();
            this.lis_ybxxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lis_ybxxTableAdapter = new reportview.mkliscenterDataSetTableAdapters.lis_ybxxTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XT_UserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MKPathologyDB_testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkliscenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lis_ybxxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "reportview.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(30, 68);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(577, 347);
            this.reportViewer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 25);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // XT_UserBindingSource
            // 
            this.XT_UserBindingSource.DataMember = "XT_User";
            this.XT_UserBindingSource.DataSource = this.MKPathologyDB_testDataSet;
            // 
            // MKPathologyDB_testDataSet
            // 
            this.MKPathologyDB_testDataSet.DataSetName = "MKPathologyDB_testDataSet";
            this.MKPathologyDB_testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // XT_UserTableAdapter
            // 
            this.XT_UserTableAdapter.ClearBeforeFill = true;
            // 
            // mkliscenterDataSet
            // 
            this.mkliscenterDataSet.DataSetName = "mkliscenterDataSet";
            this.mkliscenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lis_ybxxBindingSource
            // 
            this.lis_ybxxBindingSource.DataMember = "lis_ybxx";
            this.lis_ybxxBindingSource.DataSource = this.mkliscenterDataSet;
            // 
            // lis_ybxxTableAdapter
            // 
            this.lis_ybxxTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(696, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(464, 268);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XT_UserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MKPathologyDB_testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkliscenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lis_ybxxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource XT_UserBindingSource;
        private MKPathologyDB_testDataSet MKPathologyDB_testDataSet;
        private MKPathologyDB_testDataSetTableAdapters.XT_UserTableAdapter XT_UserTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource lis_ybxxBindingSource;
        private mkliscenterDataSet mkliscenterDataSet;
        private mkliscenterDataSetTableAdapters.lis_ybxxTableAdapter lis_ybxxTableAdapter;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

