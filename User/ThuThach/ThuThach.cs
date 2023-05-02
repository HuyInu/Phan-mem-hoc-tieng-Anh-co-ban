using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech.Synthesis;
using System.IO;
using System.Threading;
using System.Globalization;

namespace Đồ_án
{
    public partial class ThuThach : Form
    {
        public static ThuThach nc;
        public Button but;
        public ThuThach()
        {
            InitializeComponent();
        }
        Database db;
        int wid, dem = 0;
        public int Dung = 0, Sai = 0;
        int combo=0,comboSai=0;
        int tiendoNoiTu = 0;
        int tiendoChonHinh = 0;
        int tiendoNghe = 0;
        int tiendo = 0;
        int loaiCH = 0;
        int noiTuCount,chonHinhCount,ngheCount;
        DataTable cauHoiNoiTu,cauHoiChonHinh,cauHoiNghe;
        Thread newThread;

        /*Bien chon hinh*/
        string luaChonHinh;

        /*---------------*/

        SpeechSynthesizer voice; 
        private void ThuThach_Load(object sender, EventArgs e)
        {
            db = new Database("QLAV");
            voice = new SpeechSynthesizer();
            cauHoiNoiTu = db.Execute("select top 5 MaNoiCau,TV,TA from NOICAU where MaBH='"+NGUOIHOC.idbaihoc+"' order by newid()");
            cauHoiChonHinh = db.Execute("select top 5 MaLoaiCH,MaLOAI,Hinh,DapAn from CauHoiChonHinh H where MaBH='" + NGUOIHOC.idbaihoc + "' order by newid()");
            cauHoiNghe = db.Execute("select top 5 TA from CauHoiNghe where MaBH='" + NGUOIHOC.idbaihoc + "' order by newid()");
            noiTuCount = cauHoiNoiTu.Rows.Count;
            chonHinhCount = cauHoiChonHinh.Rows.Count;
            ngheCount = cauHoiNghe.Rows.Count;

            voice.Volume = 100;
            voice.SelectVoiceByHints(VoiceGender.Female);

            loadBaiHoc(cauHoiNoiTu, cauHoiChonHinh,cauHoiNghe, tiendoNoiTu, tiendoChonHinh, noiTuCount, chonHinhCount,tiendoNghe,ngheCount);
            
            showTiendo();
        }
        /* Cau hoi noi cau */
        void createButton(int x, int y, string name, string ChuoiFirst)
        {
            CustomButton but = new CustomButton();
            but.BackColor = System.Drawing.Color.White;
            but.BackgroundColor = System.Drawing.Color.White;
            but.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            but.BorderRadius = 10;
            but.BorderSize = 3;
            but.FlatAppearance.BorderSize = 0;
            but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            but.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            but.ForeColor = System.Drawing.Color.Black;
            but.Size = new System.Drawing.Size(80, 40);
            but.AutoSize = true;
            but.TabIndex = 0;
            but.Location = new System.Drawing.Point(x, y);
            but.Name = name;
            but.Text = ChuoiFirst;
            but.TextColor = System.Drawing.Color.Black;
            but.UseVisualStyleBackColor = false;
            but.Click += new EventHandler(this.but_click);
            pnbut.Controls.Add(but);
            wid = but.Width;
        }
        void but_click(object sender, EventArgs e)
        {
            Button but = sender as Button;
            Button butTop = null;  
            string text = but.Text;
            if (loaiCH == 0 || loaiCH==2)
            {
                newThread = new Thread(() => loadVoice(text));
                newThread.Start();
            }
            for (int i = 0; i < dem; i++)
            {
                butTop = pnTop.Controls[i] as Button;
                if (butTop.Text == "")
                {
                    butTop.Visible = true;
                    butTop.Text = but.Text;

                    but.Text = "";
                    but.Enabled = false;
                    break;
                }
            }                   
        }
        void createButtonTop(int x, int y, int i)
        {
            CustomButton but = new CustomButton();
            but.AutoSize = true;
            but.BackColor = System.Drawing.Color.White;
            but.BackgroundColor = System.Drawing.Color.White;
            but.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            but.BorderRadius = 10;
            but.BorderSize = 3;
            but.FlatAppearance.BorderSize = 0;
            but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            but.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            but.ForeColor = System.Drawing.Color.Black;
            but.Name = "customButton1";
            but.Size = new System.Drawing.Size(80, 40);
            but.TabIndex = 0;
            but.Location = new System.Drawing.Point(x, y);
            but.Name = i.ToString();
            but.Text = "";
            but.TextColor = System.Drawing.Color.Black;
            but.UseVisualStyleBackColor = false;
            but.Visible = false;
            but.Click += new EventHandler(this.butTop_click);
            pnTop.Controls.Add(but);
            //wid = but.Width;
        }
        void butTop_click(object sender, EventArgs e)
        {
            Button butDown = null;
            Button butTop1 = null, butTop2 = null;
            Button but = sender as Button;
            butDown = pnbut.Controls[but.Text] as Button;
            if (butDown.Text != "")
            {
                int i = 1;
                bool check;
                do
                {
                    check = false;
                    butDown = pnbut.Controls[but.Text + i] as Button;
                    if (butDown.Text == "")
                    {
                        butDown.Text = but.Text;
                        butDown.Enabled = true;
                    }
                    else
                    {
                        check = true;
                        i++;
                    }
                }
                while (check);
            }
            else
            {
                butDown.Text = but.Text;
                butDown.Enabled = true;
            }

            but.Text = "";
            but.Width = 80;
            for (int i = int.Parse(but.Name); i < dem; i++)
            {
                butTop1 = pnTop.Controls[i] as Button;
                butTop1.Show();
                if (butTop1.Name == (dem-1).ToString())
                {
                    butTop1.Visible = false;
                    break;
                }
                else
                {
                    butTop2 = pnTop.Controls[i + 1] as Button;
                    if (butTop2.Text != "")
                    {
                        butTop1.Text = butTop2.Text;
                        butTop2.Text = "";
                        butTop2.Visible = false;
                    }
                    else
                    {
                        butTop1.Visible = false;
                        break;
                    }
                }
            }
        }
        int checkString(string[] ChuoiFnal, ArrayList ChuoiFirst)
        {           
            for(int i=0;i<ChuoiFnal.Length;i++)
                if(ChuoiFnal[i]!=ChuoiFirst[i].ToString())
                    return 0;
            return 1;
        }
        public void demChu(string chuoi)
        {
            for (int s = 0; s < chuoi.Length; s++)
            {
                if (chuoi[s] == ' ')
                    dem++;
            }
        }
        public void stringToArray(string chuoi,ArrayList ChuoiFirst)
        {
            string tam;
            int i = 0, j = 0;
            while (i != chuoi.Length)
            {
                if (i == (chuoi.Length - 1))
                {
                    tam = chuoi.Substring(j);
                    ChuoiFirst.Add(tam);
                }
                else if (chuoi[i] == ' ')
                {
                    tam = chuoi.Substring(j, i - j);
                    ChuoiFirst.Add(tam);
                    j = i + 1;
                }
                i++;
            }
        }
        public void createButtonTopDown(String[] ChuoiFinal,string[] ChuoiFinalCopy)
        {
            int x = 0;
            for (int k = 0; k < ChuoiFinal.Length; k++)
            {
                if (checkTrung(k, ChuoiFinal) > 0)
                {
                    createButton(x, 0, ChuoiFinal[k] + checkTrung(k, ChuoiFinal), ChuoiFinal[k]);
                    ChuoiFinalCopy[k] = ChuoiFinal[k] + checkTrung(k, ChuoiFinal);
                }
                else
                {
                    createButton(x, 0, ChuoiFinal[k], ChuoiFinal[k]);
                    ChuoiFinalCopy[k] = ChuoiFinal[k];
                }
                createButtonTop(x, 0, k);
                x += wid;
            }
        }      
        public void getXY(int y, int Right, int Left, int Dai, Button butDown, string[] ChuoiFinalCopy)
        {
            int x;

            x = (pnbut.Width - Dai) / 2;
            for (int i = Left; i <= Right - 1; i++)
            {
                butDown = pnbut.Controls[ChuoiFinalCopy[i]] as Button;
                butDown.Location = new System.Drawing.Point(x, y);
                x += butDown.Width;
            }
        }
        public void SapXepButDown(string[] ChuoiFinalCopy)
        {
            int Dai = 0, Left = 0, Right, y = 0;
            Button butDown = null;
            for (int i = 0; i < ChuoiFinalCopy.Length; i++)
            {
                butDown = pnbut.Controls[ChuoiFinalCopy[i]] as Button;
                Dai += butDown.Width;
                if (Dai > pnbut.Width)
                {
                    Right = i;
                    Dai -= butDown.Width;
                    getXY(y, Right, Left, Dai, butDown, ChuoiFinalCopy);
                    y += butDown.Height;
                    Left = Right;
                    Dai = butDown.Width;
                }
            }
            if (Dai < pnbut.Width)
            {
                Right = ChuoiFinalCopy.Length;
                getXY(y, Right, Left, Dai, butDown, ChuoiFinalCopy);
            }

        }
        public void lbAserCenter(Label a)
        {
            a.Left = (pnKhen.Width - a.Width) / 2;
        }
        void daoChuoi(ArrayList ChuoiFirst, string[] ChuoiFnal, Random ran)
        {
            int num;
            do
            {
                for (int h = 0; h < ChuoiFirst.Count; h++)
                {
                    bool check = false;
                    do
                    {
                        num = ran.Next(0, ChuoiFnal.Length);
                        if (ChuoiFnal[num] == null)
                        {
                            ChuoiFnal[num] = ChuoiFirst[h].ToString();
                            check = true;
                        }
                    }
                    while (check == false);
                }
            }
            while (checkString(ChuoiFnal, ChuoiFirst)==1);
        }
        int checkTrung(int k, string[] chuoi)
        {
            int demTrung = 0;
            for (int h = k + 1; h < chuoi.Length; h++)
            {
                if (chuoi[k] == chuoi[h])
                    demTrung++;
            }
            return demTrung;
        }
        string noiCau()
        {
            string cauDaGhep = null;
           
            Button butTop = null;
            for (int i = 0; i < dem; i++)
            {
                butTop = pnTop.Controls[i] as Button;
                if (butTop.Text != "")
                    cauDaGhep += butTop.Text + " ";
                else break;
            }
            if (cauDaGhep == null)
                return " ";
            return cauDaGhep.Substring(0, cauDaGhep.Length - 1);
        }
        string addPhanTuVaoChuoi(String baiLam)
        {
            DataTable AddChuoi;
            string sql=null;
            if (loaiCH == 0 ||loaiCH==2)
                sql = "select top 2 Angu from TUVUNG where MaBH=0001 order by NEWID()";
            if(loaiCH==3)
                sql = "select top 2 Vngu from TUVUNG where MaBH=0001 order by NEWID()";

            AddChuoi = db.Execute(sql);

            for (int i = 0; i < AddChuoi.Rows.Count; i++)
            {
                baiLam += " " + AddChuoi.Rows[i][0].ToString();
            }
            return baiLam;
        }
        private void speakerTA_Click(object sender, EventArgs e)
        {
            pnTop.Enabled = false;
            pnbut.Enabled = false;
            loadVoice(lbCauHoi.Text);
            pnTop.Enabled = true;
            pnbut.Enabled = true;
        }
        public void loadCauHoiNoiCau(string TA, string TV)
        {
            string cauhHoi, baiLam;
            if (loaiCH == 3)
            {
                cauhHoi = TA;
                baiLam = TV;
                speakerTA.Show();
                newThread = new Thread(() => loadVoice(cauhHoi));
                newThread.Start();
            }
            else
            {
                cauhHoi = TV;
                baiLam = TA;
            }

            lbCauHoi.Text = cauhHoi;
            pnTop.Controls.Clear();
            pnbut.Controls.Clear();
            
            Random ran = new Random();

            baiLam= addPhanTuVaoChuoi(baiLam);

            var ChuoiFirst = new ArrayList();

            stringToArray(baiLam, ChuoiFirst);

            dem = ChuoiFirst.Count;

            string[] ChuoiFinal = new string[dem];
            string[] ChuoiFinalCopy = new string[dem];
            

            daoChuoi(ChuoiFirst, ChuoiFinal, ran);

            createButtonTopDown(ChuoiFinal, ChuoiFinalCopy);

            SapXepButDown(ChuoiFinalCopy);

        }
        public bool KQnoituAndKQchonhinh(string bailam,string kq)
        {
            if (bailam == kq)
                return true;
            else return false;
        }
        /*--------------------------------------------------------------------------------------*/
        /* Cau hoi chon hinh */
        public Image convertbytetoimage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }
        private void pickA_Click(object sender, EventArgs e)
        {
            luaChonHinh = pickA.Text;
            buttonABCColor(255, 205, 5, 112, 179, 255, 112, 179, 255);
            newThread = new Thread(() => loadVoice(luaChonHinh));
            newThread.Start();

        }
        private void pinkB_Click(object sender, EventArgs e)
        {
            luaChonHinh = pickB.Text;
            buttonABCColor(112, 179, 255, 255, 205, 5, 112, 179, 255);
            newThread = new Thread(() => loadVoice(luaChonHinh));
            newThread.Start();
        }
        private void pickC_Click(object sender, EventArgs e)
        {
            luaChonHinh = pickC.Text;
            buttonABCColor(112, 179, 255, 112, 179, 255, 255, 205, 5);
            newThread = new Thread(() => loadVoice(luaChonHinh));
            newThread.Start();
        }
        public void buttonABCColor(int a1,int b1,int c1,int a2,int b2,int c2,int a3,int b3,int c3)
        {
            pickA.BorderColor = System.Drawing.Color.FromArgb(a1,b1,c1);
            pickB.BorderColor = System.Drawing.Color.FromArgb(a2,b2,c2);
            pickC.BorderColor = System.Drawing.Color.FromArgb(a3,b3,c3);
        }
        
        public void loadCauHoiChonHinh(object hinh,string A,string B,string C)
        {
            lbCauHoi.Text = "Đây là gì?";
            pic.Image= convertbytetoimage((byte[])hinh);
            String[] mangABC = { A, B, C };

            int number,n=mangABC.Length;
            Random ranABC = new Random();

            number = ranABC.Next(0, 3);
            pickA.Text = mangABC[number];
            xoaPtMang(mangABC, number,n);

            number = ranABC.Next(0, 2);
            pickB.Text = mangABC[number];
            xoaPtMang(mangABC, number,n);

            pickC.Text = mangABC[0];

        }
        /*--------------------------------------------------------------------------------------*/
        /* Cau hoi nghe */
        private void speaker_Click(object sender, EventArgs e)
        {
            pnTop.Enabled = false;
            pnbut.Enabled = false;
            loadVoice(cauHoiNghe.Rows[tiendoNghe][0].ToString());
            pnTop.Enabled = true;
            pnbut.Enabled = true;
        }
        public void loadCauHoiNghe(string chuoi)
        {
            speaker.Show();
            newThread = new Thread(() => loadVoice(chuoi));
            newThread.Start();
            lbCauHoi.Text = "Viết lại những gì đã nghe.";
            pnTop.Controls.Clear();
            pnbut.Controls.Clear();

            string baiLam = chuoi;
            dem = 0;
            Random ran = new Random();

            baiLam = addPhanTuVaoChuoi(baiLam);
            var ChuoiFirst = new ArrayList();

            stringToArray(baiLam, ChuoiFirst);

            dem = ChuoiFirst.Count;

            string[] ChuoiFinal = new string[dem];
            string[] ChuoiFinalCopy = new string[dem];


            daoChuoi(ChuoiFirst, ChuoiFinal, ran);

            createButtonTopDown(ChuoiFinal, ChuoiFinalCopy);

            SapXepButDown(ChuoiFinalCopy);
        }
        /*--------------------------------------------------------------------------------------*/
        public void xoaPtMang(string[] arr,int index,int n)
        {
            if (index != n-1)
            {
                for (int i = index; i < n; i++)
                {
                    arr[i] = arr[i +1];
                    n--;
                }
            }
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
            try
            {
                int week = GetWeekOfYear(DateTime.Now);
                int month = DateTime.Now.Month;
                int year = DateTime.Now.Year;
                if (db.kiemtra("select * from TKEMONTH where MaNH='" + NGUOIHOC.id + "' and THANG='" + month + "' and NAM='" + year + "'") == false)
                {
                    db.ExecuteNonQuery("insert into TKEMONTH values ('" + NGUOIHOC.id + "','" + 1 + "','" + month + "','" + year + "')");
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

            }
            catch { }
        }
        public void loadBaiHoc(DataTable cauhoinoitu,DataTable cauhoichonhinh,DataTable cauhoinghe,int tiendonoitu,int tiendochonhinh,int noiTuCount,int chonHinhCount,int tiendonghe,int ngheCount )
        {
            Random ran = new Random();
            loaiCH = ran.Next(0, 4);
            bool founded = true;
            do
            {
                if (loaiCH == 0 || loaiCH==3)
                {
                    if (tiendonoitu < noiTuCount)
                    {
                        NoiChu.Show();
                        ChonHinh.Hide();
                        loadCauHoiNoiCau(cauhoinoitu.Rows[tiendonoitu][2].ToString(), cauhoinoitu.Rows[tiendonoitu][1].ToString());
                        founded = false;
                    }
                    else
                    {
                        loaiCH = ran.Next(0, 3);
                        
                    }
                }
                if (loaiCH == 1)
                {
                    if (tiendochonhinh < chonHinhCount)
                    {
                        DataTable ABC = db.Execute("select top 2 a.Angu from (select Angu from TUVUNG where MaLOAI='" + cauhoichonhinh.Rows[tiendoChonHinh][1].ToString() + "' and MaBH='" + NGUOIHOC.idbaihoc + "' except select  Angu from TUVUNG where Angu='" + cauhoichonhinh.Rows[tiendoChonHinh][3].ToString() + "' and MaBH='0001' ) a order by newid() ");
                        NoiChu.Hide();
                        ChonHinh.Show();
                        loadCauHoiChonHinh(cauhoichonhinh.Rows[tiendochonhinh][2], cauhoichonhinh.Rows[tiendochonhinh][3].ToString(), ABC.Rows[0][0].ToString(),ABC.Rows[1][0].ToString());
                        founded = false;
                    }
                    else
                    {
                        loaiCH = ran.Next(0, 3);
                    }
                }
                if(loaiCH==2)
                {
                    if(tiendonghe<ngheCount)
                    {
                        NoiChu.Show();
                        ChonHinh.Hide();
                        loadCauHoiNghe(cauhoinghe.Rows[tiendonghe][0].ToString());
                        founded = false;                                            
                    }
                    else
                    {
                        loaiCH = ran.Next(0, 3);
                    }
                }
            } while (founded);

        }
        public void loadVoice(string text)
        {
            voice.Speak(text);
        }
        void Finish()
        {
            UpdateWeekMounthYear();
            MSHoanThanhBaiHoc MS = new MSHoanThanhBaiHoc();
            MS.Dung = Dung;
            MS.Sai = Sai;
            MS.StartPosition = FormStartPosition.CenterParent;
            MS.ShowDialog();
            this.Close();
        }
        void showTiendo()
        {
            lbTienDo.Text = (tiendo + 1) + "/" + (noiTuCount + chonHinhCount+ngheCount);
        }
        public void inKhenThuong()
        {
            lbAserCenter(lbKhen);
            pnKhen.Show();
            waitKhenThuong.Start();
        }
        public void NextOrFinish()
        {
            if (tiendo < (noiTuCount + chonHinhCount + ngheCount))
            {
                pnAser.Hide();
                buthoanthanh.Show();
                loadBaiHoc(cauHoiNoiTu, cauHoiChonHinh, cauHoiNghe, tiendoNoiTu, tiendoChonHinh, noiTuCount, chonHinhCount, tiendoNghe, ngheCount);
                showTiendo();
            }
            else
            {
                Finish();
            }
        }  
        public void KhenThuong()
        {
            NoiChu.Hide();
            ChonHinh.Hide();
            if (combo == 5 && tiendo < (noiTuCount + chonHinhCount + ngheCount))
            {
                lbKhen.Text = "Đúng liên tiếp 5 lần, hãy tiếp tục.";
                inKhenThuong();
            }
            if (combo == 10)
            {
                lbKhen.Text = "10 câu liên tiếp, bạn hảo English";
                inKhenThuong();
            }
            if(comboSai==5)
            {
                lbKhen.Text = "Bạn đang sai liên tục, hãy cố gắn lên.";
                inKhenThuong();
            }
            if (comboSai == 10)
            {
                lbKhen.Text = "Bạn không khỏe à, cố gắn tập trung.";
                inKhenThuong();
            }

        }    
        private void waitKhenThuong_Tick(object sender, EventArgs e)
        {
            waitKhenThuong.Stop();
            pnKhen.Hide();
            NextOrFinish();
        }
        public void TBaoDung()
        {
            combo++;
            comboSai = 0;
            Dung++;

            pnAser.BackColor = System.Drawing.Color.FromArgb(127, 255, 105);
            lbAser.ForeColor = System.Drawing.Color.FromArgb(33, 110, 19);

            pnAser.Show();
            lbDapAn.Hide();
            lbAser.Text = "Chính xác! (ノ^∇^)";

        }
        public void TBaoSai(string DapAn)
        {
            combo = 0;
            comboSai++;
            Sai++;

            lbDapAn.Text = DapAn;
            pnAser.BackColor = System.Drawing.Color.FromArgb(252, 188, 157);
            lbAser.ForeColor = System.Drawing.Color.FromArgb(128, 49, 11);
            lbDapAn.ForeColor = lbAser.ForeColor;

            pnAser.Show();
            lbDapAn.Show();

            lbAser.Text = "Không đúng rồi  (˘̩╭╮˘̩)";

        }
        private void buthoanthanh_Click(object sender, EventArgs e)
        {
            buthoanthanh.Hide();
            if(loaiCH==0)
            {
                if (KQnoituAndKQchonhinh(noiCau(), cauHoiNoiTu.Rows[tiendoNoiTu][2].ToString()))
                    TBaoDung();
                else
                    TBaoSai(cauHoiNoiTu.Rows[tiendoNoiTu][2].ToString());
                tiendoNoiTu++;
                
            }        
            if(loaiCH==1)
             {
                    if (KQnoituAndKQchonhinh(luaChonHinh, cauHoiChonHinh.Rows[tiendoChonHinh][3].ToString()))
                        TBaoDung();
                    else
                        TBaoSai(cauHoiChonHinh.Rows[tiendoChonHinh][3].ToString());
                    tiendoChonHinh++;
                    buttonABCColor(112, 179, 255, 112, 179, 255, 112, 179, 255);
               }
            if(loaiCH==2)
            {
                if(KQnoituAndKQchonhinh(noiCau(),cauHoiNghe.Rows[tiendoNghe][0].ToString()))
                    TBaoDung();
                else
                    TBaoSai(cauHoiNghe.Rows[tiendoNghe][0].ToString());
                tiendoNghe++;
                speaker.Hide();
            }
            if (loaiCH == 3)
            {
                if (KQnoituAndKQchonhinh(noiCau(), cauHoiNoiTu.Rows[tiendoNoiTu][1].ToString()))
                    TBaoDung();
                else
                    TBaoSai(cauHoiNoiTu.Rows[tiendoNoiTu][1].ToString());
                tiendoNoiTu++;
                speakerTA.Hide();

            }
            GC.Collect();        
        }
        private void butNext_Click(object sender, EventArgs e)
        {
            tiendo++;
            if ((combo == 5 || combo == 10 || comboSai == 5 || comboSai == 10) && tiendo < (noiTuCount + chonHinhCount + ngheCount))
                KhenThuong();
            else
            {
                NextOrFinish();
            }
        }
        private void choDoi_Tick(object sender, EventArgs e)
        {
            choDoi.Stop();                                    
        }
        private void buttrove_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Tiến độ của bạn sẽ bị mất, bạn có muốn trở về ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                GC.Collect();
                this.Close();
            }
        }
    }
}
