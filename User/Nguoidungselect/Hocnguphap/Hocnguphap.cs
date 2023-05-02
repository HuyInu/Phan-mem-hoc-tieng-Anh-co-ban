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
    public partial class Hocnguphap : Form
    {
        public Hocnguphap()
        {
            InitializeComponent();
        }
        Database db;
        DataTable dt,dt1;
        int tiendo=0,dem,dembt;
        int dung=0, sai=0,phantram;

        private void Hocnguphap_Load(object sender, EventArgs e)
        {
            db = new Database("QLAV");
          

            lbtenNP.Text = "Ngữ pháp bài " + "'" + db.dem("select TenBH from BAIHOC where MaBH='" + NGUOIHOC.idbaihoc + "'") + "'";

            dt = db.Execute("select TenNP,Noidung,Chuthich,MaNP,MaBH from NGUPHAP where MaBH='"+NGUOIHOC.idbaihoc+"'");
            dem = dt.Rows.Count;
            taolabel();

            dt1 = db.Execute("select Cauhoi,A,B,C,Dapan from BAITAPNP where MaBH ='" + NGUOIHOC.idbaihoc + "'");
            dembt = dt1.Rows.Count;
            if (dembt == 0) butthuchanh.Hide();

            dt=db.Execute("select TiendoNP,DungNP,SaiNP,FNP from HOC where MaBH='"+NGUOIHOC.idbaihoc+"' and MaNH='"+NGUOIHOC.id+"'");
            tiendo = int.Parse(dt.Rows[0][0].ToString());
            dung= int.Parse(dt.Rows[0][1].ToString());
            sai = int.Parse(dt.Rows[0][2].ToString());
            
             if(tiendo!=0)
            {
                MessageBox.Show("Học tiếp.");
                hidepnbai();
                loadbaitap();
                pnQ.Show();
                showtextbox();

            }
            else if(int.Parse(dt.Rows[0][3].ToString()) == 100)
            {
                //lbtenNP.Text = "Ngữ pháp bài " + "'"+ db.dem("select TenBH from BAIHOC where MaBH='" + NGUOIHOC.idbaihoc + "'")+ "'";
                showpnbai();
            }
            //MessageBox.Show(dt.Rows[0][3].ToString());
        }
        /*Hàm tái sử dụng*/
        public void hidetexbox()
        {
            butnopbai.Hide();                       
        }
        public void FalseRadio()
        {
            raA.Checked = false;
            raB.Checked = false;
            raC.Checked = false;
        }
        public void showtextbox()
        {
            butnopbai.Visible=true;
            raA.Visible = true;
            raB.Visible=true;
            raC.Visible=true;
        }
        public void showpnbai()
        {
            pnF.Show();
            butthuchanh.Show();
        }
        public void hidepnbai()
        {
            pnF.Hide();
            butthuchanh.Hide();
        }
        public void centerlabel(Label lb, Panel pn)
        {
            lb.Left = (pn.Width - lb.Width) / 2;
        }
        public void loadbaitap()
        {
            lbTienDo.Show();
            showTiendo();
            txtCauHoi.Text = dt1.Rows[tiendo][0].ToString();
            raA.Text = dt1.Rows[tiendo][1].ToString();
            raB.Text = dt1.Rows[tiendo][2].ToString();
            raC.Text = dt1.Rows[tiendo][3].ToString();
        }    
        public void taolabel()
        {
            int top=25;
            for (int i = 0; i < dem; i++)
            {
                Label bl = new Label();
                bl.Font = new Font("000 Chinacat [TeddyBear]", 13);
                bl.Text = dt.Rows[i][0].ToString();
                bl.AutoSize = true;
                bl.MaximumSize = new Size(250, 0);
                bl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                bl.ForeColor = System.Drawing.Color.FromArgb(255, 123, 41);
                bl.Top = top;
                bl.Left = 230 ;
                pnF.Controls.Add(bl);
                top += bl.Height;
                //MessageBox.Show(bl.Width.ToString());

                Label blnd = new Label();
                blnd.Font = new Font("000 Chinacat [TeddyBear]", 13);
                blnd.Text = dt.Rows[i][1].ToString();
                blnd.AutoSize = true;
                blnd.MaximumSize = new Size(550, 0);
                blnd.ForeColor = System.Drawing.Color.FromArgb(199, 0, 126);
                blnd.Top = top;
                blnd.Left = 50;
                pnF.Controls.Add(blnd);
                top += blnd.Height;

                Label blct = new Label();
                blct.Font = new Font("000 Chinacat [TeddyBear]", 11);
                blct.Text = dt.Rows[i][2].ToString();
                blct.AutoSize = true;
                blct.ForeColor = System.Drawing.Color.FromArgb(25, 33, 89);
                blct.Top = top;
                blct.Left = 60;
                pnF.Controls.Add(blct);
                top += blct.Height;
            }
        }
        public void updatethongke()
        {
            db.ExecuteNonQuery("update THONGKE set Tongdung=Tongdung+" + dung + ",Tongsai=Tongsai+" + sai + ",Solanhoc=Solanhoc+1 where MaBH='"+NGUOIHOC.idbaihoc+"' and MaNH='"+NGUOIHOC.id+"'");
        }
        public void tinhphantram()
        {
            phantram = (dung * 100) / dembt;
        }
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
        public void UpdateWeekMounthYear()
        {
            //try
            //{
                int week = GetWeekOfYear(DateTime.Now);
                int month = DateTime.Now.Month;
                int year = DateTime.Now.Year;
                if (db.kiemtra("select * from TKEMONTH where MaNH='" + NGUOIHOC.id + "' and THANG='" + month + "' and NAM='" + year + "'") == false)
                {
                    db.ExecuteNonQuery("insert into TKEMONTH values ('" + NGUOIHOC.id + "','" + 1 + "','" + month + "','" + year + "')");
                    MessageBox.Show("1");
                }
                else
                {
                    db.ExecuteNonQuery("update TKEMONTH set SL=SL+1 where MaNH='" + NGUOIHOC.id + "' and THANG='" + month + "' and NAM='" + year + "'");
                }
                if (db.kiemtra("select * from TKEWEEK where MaNH='" + NGUOIHOC.id + "' and TUAN='" + week + "' and NAM='" + year + "'") == false)
                {
                    DateTime monday = FirstDateOfWeek(year, week);

                    db.ExecuteNonQuery("insert into TKEWEEK values ('" + NGUOIHOC.id + "','" + 1 + "','" + week + "','" + monday + "','" + monday.AddDays(6) + "','" + year + "')");
                }
                else
                {
                    db.ExecuteNonQuery("update TKEWEEK set SL=SL+1 where MaNH='" + NGUOIHOC.id + "' and TUAN='" + week + "' and NAM='" + year + "'");
                }

            //}
            //catch { MessageBox.Show("erro"); }
        }
        public void finish()
        {           
            tinhphantram();
            MessageBox.Show("Bạn đã học xong");
            butnopbai.Hide();
            pnA.Hide();
            if(int.Parse(db.dem("select FNP from HOC  where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='" + NGUOIHOC.id + "'")) !=100)
                db.ExecuteNonQuery("update HOC set TiendoNP='" + 0 + "',FNP='" + phantram + "',DungNP='" + 0 + "',SaiNP='" + 0 + "' where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='"+NGUOIHOC.id+"'");
            else
                db.ExecuteNonQuery("update HOC set TiendoNP='" + 0 + "',DungNP='" + 0 + "',SaiNP='" + 0 + "' where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='" + NGUOIHOC.id + "'");
            updatethongke();
            UpdateWeekMounthYear();
            loadKQ();
            pnKQ.Show();
            pnKQ.BringToFront();
            showpnbai();

            tiendo = 0;
            dung = 0;
            sai = 0;
            db.huyketnoi();
        }
        public void loadKQ()
        {
            //lbtenNP.Text = "Tổng kết ngữ pháp bài "+NGUOIHOC.tenbaihoc;
            lbphantram.Text = "Hoàn thành " + phantram + "%" + " bài học.";
            centerlabel(lbphantram, pnKQ);
            lbR.Text = "Đúng: " + dung+"/"+dembt + " câu.";
            centerlabel(lbR, pnKQ);
            lbF.Text = "Sai: " + sai+"/"+dembt + " câu.";
            centerlabel(lbF, pnKQ);
        }
        /***************************************************************************************************************/
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            /*pnQ.Show();                
            showtextbox();*/
            
            timer1.Stop();
        }
        private void butthuchanh_Click(object sender, EventArgs e)
        {
            buthoclai.Show();
            hidepnbai();
            loadbaitap();
            pnQ.Show();
            showtextbox();            
        }
        public void TBaoDung()
        {
            dung++;

            pnA.BackColor = System.Drawing.Color.FromArgb(127, 255, 105);
            lbAser.ForeColor = System.Drawing.Color.FromArgb(33, 110, 19);

            pnA.Show();
            lbDapAn.Hide();
            lbAser.Text = "Chính xác! (ノ^∇^)";

        }
        public void TBaoSai(string DapAn)
        {
            string NdDapAn = null ;
            if (DapAn == "A")
                NdDapAn = dt1.Rows[tiendo][1].ToString();
            if (DapAn == "B")
                NdDapAn = dt1.Rows[tiendo][2].ToString();
            if (DapAn == "C")
                NdDapAn = dt1.Rows[tiendo][3].ToString();
            sai++;

            lbDapAn.Text = NdDapAn;
            pnA.BackColor = System.Drawing.Color.FromArgb(252, 188, 157);
            lbAser.ForeColor = System.Drawing.Color.FromArgb(128, 49, 11);
            lbDapAn.ForeColor = lbAser.ForeColor;

            pnA.Show();
            lbDapAn.Show();

            lbAser.Text = "Không đúng rồi  (˘̩╭╮˘̩)";

        }
        public void showTiendo()
        {
            lbTienDo.Text = (tiendo + 1) + "/" + dembt;
        }
        private void buthoclai_Click_1(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Học lại từ đầu ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                tiendo = 0;
                db.ExecuteNonQuery("update HOC set TiendoNP='0',FNP='0',DungNP='0',SaiNP='0' where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='" + NGUOIHOC.id + "'");
                hidepnbai();
                loadbaitap();
                pnF.Show();
                butthuchanh.Show();
                butnopbai.Hide();
            }
        }

        private void butnopbai_Click(object sender, EventArgs e)
        {
            string DA="";

            hidetexbox();
            if (raA.Checked) DA = "A";
            if (raB.Checked) DA = "B";
            if (raC.Checked) DA = "C";
            if(DA== dt1.Rows[tiendo][4].ToString())
            {

                TBaoDung();                            
            }
            else
            {
                TBaoSai(dt1.Rows[tiendo][4].ToString());              
            }
        }
        private void butNext_Click(object sender, EventArgs e)
        {
            pnA.Hide();
            butnopbai.Show();
            if (tiendo == dembt - 1)
            {
                lbTienDo.Hide();       
                finish();
            }
            else
            {
                FalseRadio();
                tiendo++;
                tinhphantram();
                db.ExecuteNonQuery("update HOC set TiendoNP='" + tiendo + "',DungNP='" + dung + "',SaiNP='" + sai + "' where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='" + NGUOIHOC.id + "'");
                loadbaitap();
            }
        }
        private void butok_Click(object sender, EventArgs e)
        {
            pnKQ.Hide();
            buthoclai.Hide();
        }
        /***********hoc lai,tro ve**************/
        private void buthoclai_Click(object sender, EventArgs e)
        {
            showpnbai();
            pnF.Hide();
        }
        private void buttrove_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Tiến độ của bạn sẽ được lưu, bạn có muốn trở về ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                GC.Collect();
                this.Close();
            }
        }
    }
}
