using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Đồ_án
{
    class Database
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
    
        public Database(string tendata)
        {
            string svname = Environment.MachineName;
            string con = @"Data Source=" + svname + ";Initial Catalog=" + tendata + ";Integrated Security=True";
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
        public bool kiemtra(string ss)
        {
            SqlCommand sqlcm = new SqlCommand(ss, cn);
            cn.Open();
            SqlDataReader dr = sqlcm.ExecuteReader();

            if (dr.Read()==true)
            {
                cn.Close();
                return true;
            }
            else
            {
                cn.Close();
                return false;
            }
        }
        public void huyketnoi()
        {
            cn.Close();
        }
        public string dem(string ss)
        {
            DataTable dt = Execute(ss);
            return dt.Rows[0][0].ToString();
        }
        public void xuatdata(string sql,DataGridView datag)
        {
            DataTable dt = Execute(sql);
            datag.DataSource = dt;
        }
        public void datatintocombox(ComboBox com,string sql,string disp,string value)
        {
            DataTable dt = Execute(sql);
            com.DataSource = dt;
            com.DisplayMember = disp;
            com.ValueMember = value;

        }
    }
}
