using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Đồ_án
{
    class Database
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
    
        public Database(string tendata)
        {
           // string svname = Environment.MachineName;
            string con = @"Data Source=DESKTOP-KBSLCQ1\SQLEXPRESS;Initial Catalog=" + tendata + ";Integrated Security=True";
            cn = new SqlConnection(con);
        }
        public DataTable Execute(string sqlstr)
        {
            da = new SqlDataAdapter(sqlstr, cn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void ExecuteNonQuery(string ss)
        {
            SqlCommand sqlcm = new SqlCommand(ss, cn);
            cn.Open();
            sqlcm.ExecuteNonQuery();
            cn.Close();
        }
        public int dem(string ss)
        {
            int a;
            SqlCommand sqlcm = new SqlCommand(ss, cn);
            cn.Open();
            a=int.Parse(sqlcm.ExecuteScalar().ToString());
            cn.Close();
            return a;
        }
    }
}
