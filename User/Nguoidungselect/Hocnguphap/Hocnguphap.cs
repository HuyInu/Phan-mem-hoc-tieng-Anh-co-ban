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
    public partial class Hocnguphap : Form
    {
        public Hocnguphap()
        {
            InitializeComponent();
        }
        Database db;
        DataTable dt,dt1;
        int tiendo=0,tiendobt=0,dem,dembt,dis=0;
        int dung=0, sai=0,phantram,tongbt;

        private void Hocnguphap_Load(object sender, EventArgs e)
        {
            db = new Database("QLAV");
            
            dt = db.Execute("select TenNP,Noidung,Chuthich,MaNP,MaBH from NGUPHAP where MaBH='"+NGUOIHOC.idbaihoc+"'");
            dem = dt.Rows.Count;
            loaddatacauhoi();

            DataTable dt2 = db.Execute("select * from BAITAPNP where MaNP like '" + int.Parse(dt.Rows[0][4].ToString()) + "%'");
            tongbt = dt2.Rows.Count;

            dt2=db.Execute("select TiendoNP,DungNP,SaiNP,TiendoBTNP,FNP from HOC where MaBH='"+NGUOIHOC.idbaihoc+"' and MaNH='"+NGUOIHOC.id+"'");
            tiendo = int.Parse(dt2.Rows[0][0].ToString());
            dung= int.Parse(dt2.Rows[0][1].ToString());
            sai= int.Parse(dt2.Rows[0][2].ToString());
            tiendobt= int.Parse(dt2.Rows[0][3].ToString());
            
            if(tiendobt!=0)
            {
                MessageBox.Show("Học tiếp.");
                loaddatacauhoi();
                loadbaitap();
                hidepnbai();
                pnQ.Show();
                showtextbox();
            }
            else if(tiendo!=0)
            {
                loadbaihoc();
                showpnbai();
            }
            else if(tiendo==0 && int.Parse(dt2.Rows[0][4].ToString())!=100)
            {
                loadbaihoc();
                showpnbai();
            }
            else if(int.Parse(dt2.Rows[0][4].ToString()) == 100)
            {
                buthoclai.Show();
                lbtenNP.Text = "Tổng kết ngữ pháp bài " + "'"+NGUOIHOC.tenbaihoc+ "'";
                hidepnbai();
                taolabel();
                pnF.Show();
                butnext.Hide();
            }
        }
        /*Hàm tái sử dụng*/
        public void loaddatacauhoi()
        {
            dt1 = db.Execute("select Cauhoi,A,B,C,Dapan from BAITAPNP where MaNP='" + dt.Rows[tiendo]["MaNP"].ToString() + "'");
            dembt = dt1.Rows.Count;
            if (dembt == 0)
                butnext.Show();
            else butnext.Hide();
        }
        public void hidetexbox()
        {
            butnopbai.Hide();
            raA.Hide();
            raB.Hide();
            raC.Hide();
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
            pnbai.Visible = true;
            butthuchanh.Visible = true;
        }
        public void hidepnbai()
        {
            pnbai.Hide();
            butthuchanh.Hide();
        }
        public void centerlabel(Label lb, Panel pn)
        {
            lb.Left = (pn.Width - lb.Width) / 2;
        }
        public void loadbaihoc()
        {
            lbtenNP.Text = dt.Rows[tiendo][0].ToString();
            txtnoidung.Text = dt.Rows[tiendo][1].ToString();
            txtchuthich.Text = dt.Rows[tiendo][2].ToString();
        }
        public void loadbaitap()
        {
            txtQ.Text = dt1.Rows[tiendobt][0].ToString();
            raA.Text = dt1.Rows[tiendobt][1].ToString();
            raB.Text = dt1.Rows[tiendobt][2].ToString();
            raC.Text = dt1.Rows[tiendobt][3].ToString();
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
                bl.ForeColor = System.Drawing.Color.FromArgb(255, 123, 41);
                bl.Top = top;
                bl.Left = (pnF.Width-bl.Width)/ 2 ;
                pnF.Controls.Add(bl);
                top += bl.Height;

                Label blnd = new Label();
                blnd.Font = new Font("000 Chinacat [TeddyBear]", 13);
                blnd.Text = dt.Rows[i][1].ToString();
                blnd.AutoSize = true;
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
        public void tinhphantram()
        {
            phantram = ((dung+tiendo+1) * 100) / (tongbt+dem);
        }
        public void finish()
        {
            tinhphantram();
            pnA.Hide();           
            db.ExecuteNonQuery("update HOC set TiendoNP='" + 0 + "',FNP='" + phantram + "',DungNP='" + 0 + "',SaiNP='" + 0 + "',TiendoBTNP='" + 0 + "' where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='"+NGUOIHOC.id+"'");

            MessageBox.Show("Ban da hoc xong");
            loadKQ();
            pnKQ.Show();
            pnKQ.BringToFront();
            taolabel();
            pnF.Show();
        }
        public void loadKQ()
        {
            lbtenNP.Text = "Tổng kết ngữ pháp bài "+NGUOIHOC.tenbaihoc;
            lbphantram.Text = "Hoàn thành " + phantram + "%" + " bài học.";
            centerlabel(lbphantram, pnKQ);
            lbR.Text = "Đúng: " + dung + " câu.";
            centerlabel(lbR, pnKQ);
            lbF.Text = "Sai: " + sai + " câu.";
            centerlabel(lbF, pnKQ);
        }
        /***************************************************************************************************************/
        private void timer1_Tick(object sender, EventArgs e)
        {
            tinhphantram();
            pnA.Hide();
            if(tiendobt==dembt-1)
            {               
                tiendobt = 0;
                tiendo++;
                db.ExecuteNonQuery("update HOC set TiendoNP='"+tiendo+"',FNP='"+phantram+"',DungNP='" + dung + "',SaiNP='" + sai + "',TiendoBTNP='" + 0 + "' where MaBH='"+NGUOIHOC.idbaihoc+"' and MaNH='"+NGUOIHOC.id+"'");
                loaddatacauhoi(); //load du lieu cau hoi cho  NP ke tiep
                loadbaihoc();
                showpnbai();
            }
            else
            {
                db.ExecuteNonQuery("update HOC set FNP='" + phantram + "',DungNP='" + dung + "',SaiNP='" + sai + "',TiendoBTNP='" + (tiendobt + 1) + "' where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='" + NGUOIHOC.id + "'");
                tiendobt++;
                loadbaitap();
                pnQ.Show();                
                showtextbox();
            }
            timer1.Stop();
        }
        private void butthuchanh_Click(object sender, EventArgs e)
        {   

            pnbai.Hide();
            pnQ.Visible = true;
            butthuchanh.Hide();
            showtextbox();

            loadbaitap();
        }
        private void butnopbai_Click(object sender, EventArgs e)
        {
            string DA="";

            

            pnQ.Hide();
            hidetexbox();
            if (raA.Checked) DA = "A";
            if (raB.Checked) DA = "B";
            if (raC.Checked) DA = "C";
            if(DA== dt1.Rows[tiendobt][4].ToString())
            {
                dung++;
                lbAser.Text = "Chính xác! (ノ^∇^)";
                centerlabel(lbAser, pnA);
                pnA.Visible = true;
                hidetexbox();
                if(tiendo==dem-1 && tiendobt==dembt-1)
                {
                    finish();
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
                pnA.Visible = true;
                hidetexbox();
                if(tiendo==dem-1 && tiendobt == dembt - 1)
                {
                    finish();
                }
                else
                {
                    timer1.Start();
                }
            }
        }
        private void butok_Click(object sender, EventArgs e)
        {
            buthoclai.Show();
            pnKQ.Hide();
        }
        /***********hoc lai,tro ve**************/
        private void buthoclai_Click(object sender, EventArgs e)
        {
            buthoclai.Hide();
            loadbaihoc();
            showpnbai();
            pnF.Hide();
            loaddatacauhoi();
        }
        private void buttrove_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Tiến độ của bạn sẽ được lưu, bạn có muốn trở về ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void butnext_Click(object sender, EventArgs e)
        {
            if (tiendo != dem-1)
            {
                tinhphantram();
                tiendo++;
                loaddatacauhoi();
                loadbaihoc();
                db.ExecuteNonQuery("update HOC set TiendoNP='" + tiendo + "',FNP='" + phantram + "' where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='" + NGUOIHOC.id + "'");
            }
            else finish();
            
        }
    }
}
