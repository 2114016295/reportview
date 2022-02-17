using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reportview
{
    class getdata
    {
        
        public static DataTable GetData(string barcode)
        {
            //string sql = string.Format("select brxm,brxb,brnl,jymd from lis_ybxx where ybid='{0}'", barcode);
            //string sql = string.Format("select brxm,brxb,brnl,jymd from lis_ybxx where ybid='76001657945P'");
            string sql = string.Format("select *from BL_Sampleinfo where barcode='{0}'",barcode);
            var dt=DBhelper.GetTable("lis_ybxx", sql);
            
            

            //dt.Rows.Add(new string[] { dt.Rows[0]["brxm"].ToString(), dt.Rows[0]["brnl"].ToString(), dt.Rows[0]["brxb"].ToString(), dt.Rows[0]["jymd"].ToString() });
            //dt.Rows.Add(new string[] { "侯康杰","22","男", "体检" });
            //dt.Rows.Add("侯康杰", "22", "男", "体检");
            return dt;
        }
    }
}
