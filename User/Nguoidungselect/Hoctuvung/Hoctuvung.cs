using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Đồ_án
{
    public partial class Hoctuvung : Form
    {
        public Hoctuvung()
        {
            InitializeComponent();
        }
        Database db;
        DataTable dt,dt1;
        System.Media.SoundPlayer play = new System.Media.SoundPlayer();
        int tiendo=0,dem;
        int dung=0, sai=0;
        string DA;
        int dis = 1;
        int phantram;
        private void Hoctuvung_Load(object sender, EventArgs e)
        {
            db = new Database("QLAV");

            dt = db.Execute("select Angu,Phienam,MaLOAI,Vngu from TUVUNG where MaBH='"+NGUOIHOC.idbaihoc+"'");
            dem = dt.Rows.Count;
            
            dt1 = db.Execute("select TiendoTV,FTV,DungTV,SaiTV from HOC where MaBH='"+NGUOIHOC.idbaihoc+"' and MaNH='"+NGUOIHOC.id+"'");
            tiendo = int.Parse(dt1.Rows[0][0].ToString());
            dung= int.Parse(dt1.Rows[0][2].ToString());
            sai= int.Parse(dt1.Rows[0][3].ToString());

            lbtenbh1.Text = NGUOIHOC.tenbaihoc;

            if(tiendo == 0 && int.Parse(dt1.Rows[0][1].ToString())!=100)
            {
                loadTV();
                loadsound();
            }
            else if (tiendo > 0 && tiendo < dem)
            {
                loadTV();
                MessageBox.Show("Hoc tiep");
                loadsound();
            }
            else if(int.Parse(dt1.Rows[0][1].ToString())==100)
            {
                loadTVvaoList();

                pnbai.Hide();
                pnQ.Hide();
                pnA.Hide();

                hidetexbox();
                butthuchanh.Hide();

                pnfinish.Show();

                pnKQ.Hide();

                lbtenbh.Left = lbhead.Left + lbhead.Width;
                lbtenbh.Text =NGUOIHOC.tenbaihoc;
                lbtenbh1.Hide();
                baihoc.Hide();
            }
        }
        /* hàm tái sử dụng */
        public void centerlabel(Label lb,Panel pn)
        {
            lb.Left = (pn.Width - lb.Width) / 2;
        }
        public void loadTV()
        {           
            av.Text = dt.Rows[tiendo][0].ToString();
            DA = dt.Rows[tiendo][0].ToString();
            loai.Text = dt.Rows[tiendo][2].ToString();
            phienam.Text = dt.Rows[tiendo][1].ToString();
            TV.Text = dt.Rows[tiendo][3].ToString();
        }
        public void hidetexbox()
        {
            butnopbai.Hide();
            txttrabai.Hide();
        }
        public void showbaihoc()
        {
            pnA.Hide();
            pnbai.Visible = true;
            butthuchanh.Visible = true;
        }
        public void loadTVvaoList()
        {
            lstTV.Items.Clear();
            for (int i = 0; i <= dem - 1; i++)
            {
                lstTV.Items.Add(dt.Rows[i][0].ToString());
                lstTV.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lstTV.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lstTV.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
            }
        }
        public void finishlearn()
        {
            phantram = (dung * 100) / dem;
            MessageBox.Show("Bạn đã hoàn thành bài học");
            lbtenbh1.Hide();
            baihoc.Hide();
            if (int.Parse(dt1.Rows[0][1].ToString()) != 100)
                db.ExecuteNonQuery("update HOC set FTV='" + phantram + "' where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='" + NGUOIHOC.id + "'");
            db.ExecuteNonQuery("update HOC set FTV='" + phantram + "',TiendoTV='" + 0 + "',DungTV='"+0+"',SaiTV='"+0+"' where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='" + NGUOIHOC.id + "'");
            pnfinish.Visible = true;
            pnA.Hide();
            loadTVvaoList();
            
            lbphantram.Text = "Hoàn thành "+phantram + "%"+" bài học.";
            centerlabel(lbphantram, pnKQ);
            lbR.Text = "Đúng: " + dung + " từ.";
            centerlabel(lbR, pnKQ);
            lbF.Text = "Sai: " + sai + " từ.";
            centerlabel(lbF, pnKQ);
            pnKQ.Show();
            pnKQ.BringToFront();
        }
        public void loadsound()
        {
            try
            {
                play.SoundLocation = "audio/" + NGUOIHOC.idbaihoc + "/" + av.Text + ".wav";
                play.Play();
            }
            catch { }
        }
        /*******************************************************************************/
        private void speaker_Click(object sender, EventArgs e)
        {
            loadsound();
        }
        private void speaker2_Click(object sender, EventArgs e)
        {
            loadsound();
        }
        private void buttrove_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Tiến độ của bạn sẽ được lưu, bạn có muốn trở về ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kq==DialogResult.Yes)
            {
                this.Close();                              
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tiendo++;
            phantram = (dung * 100) / dem;
            db.ExecuteNonQuery("update HOC set TiendoTV='" + tiendo + "',DungTV='" + dung + "',SaiTV='" + sai + "',FTV='" + phantram + "' where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='" + NGUOIHOC.id + "'");
            loadTV();
            showbaihoc();
            loadsound();
            timer1.Stop();
        }

        private void butthuchanh_Click(object sender, EventArgs e)
        {        
            pnbai.Hide();
            txttrabai.Visible = true;
            TV1.Text = dt.Rows[tiendo][3].ToString();
            lbla.Left = TV1.Left + TV1.Width;
            speaker2.Left = lbla.Left + lbla.Width;

            pnQ.Show();
            butnopbai.Show();
            loadsound();
            txttrabai.Focus();
        }
        private void butnopbai_Click(object sender, EventArgs e)
        {           
            pnQ.Hide();
            pnA.Visible = true;
            butthuchanh.Hide();
            if (txttrabai.Texts == dt.Rows[tiendo][0].ToString())
            {
                dung++;
                
                lbAser.Text = "Chính xác! (ノ^∇^)";
                centerlabel(lbAser, pnA);              
                hidetexbox();

                txttrabai.Texts = "";
                dis++;
                if(tiendo == dem-1)
                {
                    finishlearn();
                }
                else
                {
                    timer1.Start();                   
                }
            }
            else
            {                
                sai++;               
                lbAser.Text = "Không đúng rồi  (˘̩╭╮˘̩)";
                centerlabel(lbAser, pnA);
                hidetexbox();

                dis++;
                txttrabai.Texts = "";
                if (tiendo == dem - 1)
                {
                    finishlearn();
                }
                else
                {
                    timer1.Start();
                }               
            }
        }
        private void buthoclai_Click(object sender, EventArgs e)
        {
            tiendo = 0;
            pnfinish.Hide();
            loadTV();
            lbtenbh1.Show();
            baihoc.Show();
            showbaihoc();
            loadsound();

        }
        private void butok_Click(object sender, EventArgs e)
        {
            pnKQ.Hide();           
        }
    }
}
