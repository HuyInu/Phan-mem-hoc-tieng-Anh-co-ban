using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án
{
    public partial class QLhoc : Form
    {
        public QLhoc()
        {
            InitializeComponent();
        }
        Database db;
        private void QLhoc_Load(object sender, EventArgs e)
        {
            db = new Database("QLAV");
            sumWeek.Text = "0";
            sumMonth.Text = "0";
            sumYear.Text = "0";
            lbday.Text = "0";

        }
        /*****ham tai su dung ********/
        public static int GetWeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        public static DateTime FirstDateOfWeek(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            if (firstWeek == 1)
            {
                weekNum -= 1;
            }
            var result = firstThursday.AddDays(weekNum * 7);

            return result.AddDays(-3);
        }

        /**********************************************************************************/
        private void date_ValueChanged(object sender, EventArgs e)
        {
            int weekyear = GetWeekOfYear(date.Value);
            week.Text = "Tuần " + weekyear;
            DateTime Monday= FirstDateOfWeek(date.Value.Year, weekyear);
            lbday.Text = Monday.Day + " -> "+ Monday.AddDays(6).ToString("dd/MM/yyyy"); 
            month.Text = "Tháng " + date.Value.Month;
            year.Text = "Năm " + date.Value.Year;

            DataTable dt1 = db.Execute("select a.MaNH,a.Name,isnull(a.SLW,0) as 'Tổng trong tuần',isnull(a.SLM,0) as 'Tổng trong tháng',isnull(c.TM,0) as 'Tổng tong năm' from (select aa.MaNH,aa.Name,aa.SL as 'SLW',bb.SL as 'SLM' from " +
                    "(select N.MaNH, N.Name, W.SL from NGUOIHOC N left join (select MaNH, SL from TKEWEEK where TUAN = '" + weekyear + "' and NAM = '" + date.Value.Year + "') W on N.MaNH = W.MaNH) aa " +
                    "left join(select MaNH, SL, THANG, NAM from TKEMONTH where THANG = '" + date.Value.Month + "' and NAM = '" + date.Value.Year + "') bb on aa.MaNH = bb.MaNH ) a " +
                    "left join(select M.MaNH, SUM(M.SL) as 'TM' from TKEMONTH M where NAM = '" + date.Value.Year + "' group by MaNH) c on c.MaNH = a.MaNH");
            dtg.DataSource = dt1;
            try
            {
                DataTable dt = db.Execute("select isnull(SUM(SL),0) as 'TW' from TKEWEEK where TUAN='" + weekyear + "' and NAM='" + date.Value.Year + "'");
                sumWeek.Text = dt.Rows[0][0].ToString();
            }
            catch { sumWeek.Text = "0"; }
            try
            {
                DataTable dt = db.Execute("select isnull(SUM(SL),0) as 'TM',THANG from TKEMONTH where THANG='" + date.Value.Month + "' and NAM='" + date.Value.Year + "' group by THANG");
                sumMonth.Text = dt.Rows[0][0].ToString();
            }
            catch { sumMonth.Text = "0"; }
            try
            {
                DataTable dt = db.Execute("select isnull(SUM(SL),0) as 'TY' from TKEMONTH where NAM='" + date.Value.Year + "'");
                sumYear.Text = dt.Rows[0][0].ToString();
            }
            catch { sumYear.Text = "0"; }
                
            GC.Collect();
        }

        private void pn1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void showReport(int choise,string id)
        {
            ReportFull rp = new ReportFull();
            rp.tuan = GetWeekOfYear(date.Value);
            rp.thang = date.Value.Month;
            rp.nam = date.Value.Year;
            rp.sta = FirstDateOfWeek(date.Value.Year, rp.tuan);
            rp.choise = choise;
            rp.maND = id; 
            rp.ShowDialog();
        }
        private void butreport_Click(object sender, EventArgs e)
        {
            showReport(0,null);

        }

        private void dtg_SelectionChanged(object sender, EventArgs e)
        {
            but1.Enabled = true;           
        }

        private void but1_Click(object sender, EventArgs e)
        {
            string listId=null;
            /*showReport(1,dtg.SelectedCells[0].Value.ToString());*/
            foreach (DataGridViewRow row in dtg.SelectedRows)
                listId += "c.MaNH='" + dtg.Rows[row.Index].Cells[0].Value.ToString() + "' or ";
            listId = listId.Substring(0,listId.Length-4);

            showReport(1, listId);
        }
    }
}
