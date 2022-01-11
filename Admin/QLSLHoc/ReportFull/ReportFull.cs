using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án
{
    public partial class ReportFull : Form
    {
        public ReportFull()
        {
            InitializeComponent();
        }
        Database db;
        public int tuan, thang, nam;
        public DateTime sta,end;

        private void ReportFull_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void ReportFull_Load(object sender, EventArgs e)
        {
            db = new Database("QLAV");
            DataSet ds = new DataSet();
            DataTable dt = db.Execute("select a.MaNH,a.Name,isnull(a.SLW,0) as 'SW',isnull(a.SLM,0) as 'SM',isnull(c.TM,0) as 'SY' from (select aa.MaNH,aa.Name,aa.SL as 'SLW',bb.SL as 'SLM' from " +
                "(select N.MaNH, N.Name, W.SL from NGUOIHOC N left join (select MaNH, SL from TKEWEEK where TUAN = '"+tuan+"' and NAM = '"+nam+"') W on N.MaNH = W.MaNH) aa " +
                "left join(select MaNH, SL, THANG, NAM from TKEMONTH where THANG = '" + thang + "' and NAM = '" + nam + "' ) bb on aa.MaNH = bb.MaNH) a " +
                "left join(select M.MaNH, SUM(M.SL) as 'TM' from TKEMONTH M where NAM = '" + nam + "' group by MaNH) c on c.MaNH = a.MaNH");
            //DataTable dt1 = db.Execute("select distinct TUAN,NAM,DAY(StartW) as 'StartW',convert(varchar,EndW,3) as 'EndW' from TKEWEEK where TUAN='" + tuan + "' and NAM='" + nam + "'");
            DataTable dt2 = db.Execute("select distinct THANG from TKEMONTH where THANG='" + thang + "'");

            DataTable dtcopy = dt.Copy();
            dtcopy.TableName = "ChiTiet";
            ds.Tables.Add(dtcopy);

            /*dtcopy = dt1.Copy();
            dtcopy.TableName = "TongW";
            ds.Tables.Add(dtcopy);*/

            dtcopy = dt2.Copy();
            dtcopy.TableName = "TongM";
            ds.Tables.Add(dtcopy);
            
            CRP cry = new CRP();
            cry.SetDataSource(ds);
            cry.SetParameterValue("TUAN", tuan);
            cry.SetParameterValue("THANG", thang);
            cry.SetParameterValue("NAM", nam);
            cry.SetParameterValue("sta", sta.Day);
            cry.SetParameterValue("end", sta.AddDays(6).ToString("dd/MM/yyyy"));

            crystal.ReportSource = cry;


        }
    }
}
