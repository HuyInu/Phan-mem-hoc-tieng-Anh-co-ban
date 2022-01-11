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
    public partial class Nguoidungselect : Form
    {
        public Nguoidungselect()
        {
            InitializeComponent();
        }
        Database db;
        bool pnTVNPop,pnhocop;
        private void Nguoidungselect_Load(object sender, EventArgs e)
        {
            pnhoc.Hide();
            pnTVNP.Hide();
            try
            {
                db = new Database("QLAV");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
        private void buthoc_Click(object sender, EventArgs e)
        {
            pnhocop = true;
            buttrove.Show();
            pnhoc.Visible = true;
            pnhoc.Controls.Clear();
            int dis = 0;
            DataTable dt = db.Execute("select MaBH, TenBH from BAIHOC");
            if (dt.Rows.Count == 0)
            {
                Label bl = new Label();
                bl.Font = new Font("000 Chinacat [TeddyBear]", 14);
                bl.Text="Hiện tại chưa có bài học mới. Bạn hãy kiên nhẫn.";
                bl.AutoSize = true;
                bl.ForeColor = System.Drawing.Color.FromArgb(0, 14, 171);
                bl.Top = (pnhoc.Height - bl.Height) / 2;
                bl.Left = 150;
                pnhoc.Controls.Add(bl);
            }
            else
            {
                for (int i = 0; i <dt.Rows.Count; i++)
                {
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Height = 150;
                    pic.Width = 120;
                    pic.Margin = new Padding(30, 0, 30, 0);
                    pic.Top = 50;
                    pic.Left = (30 + 30 + pic.Width) * dis;
                    pic.Load("picture/book.png");
                    pic.Name = dt.Rows[i][0].ToString();
                    pnhoc.Controls.Add(pic);
                    pic.Click += new EventHandler(this.pictureBox_click);

                    Label lb = new Label();
                    lb.Top = pic.Top + pic.Height + 10;
                    lb.Left = pic.Left + 20;
                    lb.Text = dt.Rows[i][1].ToString();
                    lb.Name = dt.Rows[i][0].ToString();
                    lb.AutoSize = true;
                    lb.Font = new Font("000 Chinacat [TeddyBear]", 14);
                    lb.ForeColor = System.Drawing.Color.FromArgb(0, 14, 171);
                    pnhoc.Controls.Add(lb);
                    dis++;
                }
            }
        }
        public void CheckLearn()
        {
            if (db.kiemtra("select * from HOC where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='" + NGUOIHOC.id + "'") == false)
            {
                db.ExecuteNonQuery("insert into HOC values('" + NGUOIHOC.idbaihoc + "','" + NGUOIHOC.id + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "')");
                db.ExecuteNonQuery("insert into Thongke values('" + NGUOIHOC.idbaihoc + "','" + NGUOIHOC.id + "',0,0,0)");
            }
            
        }
        public void ClearSearch()
        {
            pnSear.Hide();
            pnSear.Controls.Clear();
        }
        void pictureBox_click(object sender, EventArgs e)
        {
            pnTVNPop = true;
            PictureBox pic = sender as PictureBox;
            NGUOIHOC.idbaihoc = pic.Name;
            CheckLearn();
            pnTVNP.Show();
        }

        private  void ChonTV_Click(object sender, EventArgs e)
        {
            DataTable dt1 = db.Execute("select * from TUVUNG where MaBH='" + NGUOIHOC.idbaihoc + "'");
            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("Hiện không có gì để học.");
            }
            else
            {
                Hoctuvung htv = new Hoctuvung();
                htv.Show();
                htv.TopLevel = false;
                Nguoidungfrom.ndf.pn.Controls.Add(htv);
                htv.Dock = DockStyle.Fill;
                htv.BringToFront();
            }
        }

        private void ChonNP_Click(object sender, EventArgs e)
        {
            DataTable dt1 = db.Execute("select * from NGUPHAP where MaBH='" + NGUOIHOC.idbaihoc + "'");
            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("Hiện không có gì để học.");
            }
            else
            {
                Hocnguphap HNP = new Hocnguphap();
                HNP.Show();
                HNP.TopLevel = false;
                Nguoidungfrom.ndf.pn.Controls.Add(HNP);
                HNP.Dock = DockStyle.Fill;
                HNP.BringToFront();
            }
        }

       


        /***---Trở về---***/
        private void buttrove_Click(object sender, EventArgs e)
        {
            if (pnTVNPop)
            {
                pnTVNP.Hide();
                pnTVNPop = false;
            }
            else
            {
                if (pnhocop)
                {
                    pnhoc.Hide();
                    pnhocop = false;
                }
            }
            if (pnhocop == false)
                buttrove.Hide();
            else if(pnTVNPop == false && pnhocop==false)
                buttrove.Hide();
        }
        private void picSear_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                pnSear.Controls.Clear();
            else
            {
                pnSear.Show();
                pnSear.Controls.Clear();
                int top = 0;
                bool turn = true;
                DataTable dt1 = db.Execute("select Angu,Vngu,T.MaBH,B.TenBH from TUVUNG T,BAIHOC B where T.MaBH=B.MaBH and Angu like '%" + txttimkiem.Text + "%' or T.MaBH=B.MaBH and Vngu like '%" + txttimkiem.Text + "%'");
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    Panel pn = new Panel();
                    Label AN = new Label();
                    Label VN = new Label();
                    Label BH = new Label();
                    PictureBox gto = new PictureBox();
                    //pn.AutoSize = true;
                    pn.Width = 288;
                    pn.Height = 90;

                    AN.AutoSize = true;
                    AN.Text = dt1.Rows[i][0].ToString();
                    AN.Top = 10;
                    AN.Left = 10;
                    AN.Font = new Font("000 Chinacat [TeddyBear]", 12);
                    AN.ForeColor = System.Drawing.Color.FromArgb(0, 14, 171);

                    VN.AutoSize = true;
                    VN.Text = dt1.Rows[i][1].ToString();
                    VN.Top = AN.Height + 10;
                    VN.Left = 10;
                    VN.Font = new Font("000 Chinacat [TeddyBear]", 11);
                    VN.ForeColor = System.Drawing.Color.FromArgb(0, 14, 171);

                    BH.AutoSize = true;
                    BH.Text = "Bài: " + dt1.Rows[i][3].ToString();
                    BH.Top = AN.Height + VN.Height + 10;
                    BH.Left = 10;
                    BH.Font = new Font("000 Chinacat [TeddyBear]", 12);
                    BH.ForeColor = System.Drawing.Color.FromArgb(0, 14, 171);

                    gto.SizeMode = PictureBoxSizeMode.StretchImage;
                    gto.Load("picture/goto.png");
                    gto.Height = 30;
                    gto.Width = 30;
                    gto.Left = 200;
                    gto.Top = 20;
                    gto.Name = dt1.Rows[i][2].ToString();
                    gto.Click += new EventHandler(this.picgotoTV_click);

                    if (turn)
                    {
                        pn.BackColor = System.Drawing.Color.FromArgb(209, 234, 255);
                        turn = false;
                    }
                    else if (turn == false)
                    {
                        pn.BackColor = System.Drawing.Color.FromArgb(224, 241, 255);
                        turn = true;
                    }
                    pn.Controls.Add(AN);
                    pn.Controls.Add(VN);
                    pn.Controls.Add(BH);
                    pn.Controls.Add(gto);

                    pn.Top = top;
                    pnSear.Controls.Add(pn);
                    top += pn.Height;
                }
                dt1 = db.Execute("select P.TenNP,H.MaBH,H.TenBH from NGUPHAP P,BAIHOC H where P.MaBH=H.MaBH and TenNP like '%" + txttimkiem.Text + "%'");
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    Panel pn = new Panel();
                    Label Ten = new Label();
                    Label BH = new Label();
                    PictureBox gto = new PictureBox();
                    pn.Width = 288;
                    pn.Height = 90;

                    //Ten.Width = 10;
                    Ten.Text = dt1.Rows[i][0].ToString();
                    Ten.Top = 10;
                    Ten.Left = 10;
                    Ten.Font = new Font("000 Chinacat [TeddyBear]", 12);
                    Ten.ForeColor = System.Drawing.Color.FromArgb(0, 14, 171);
                    Ten.AutoEllipsis = true;

                    BH.AutoSize = true;
                    BH.Text = "Bài: " + dt1.Rows[i][2].ToString();
                    BH.Top = Ten.Height + 10;
                    BH.Left = 10;
                    BH.Font = new Font("000 Chinacat [TeddyBear]", 12);
                    BH.ForeColor = System.Drawing.Color.FromArgb(0, 14, 171);

                    gto.SizeMode = PictureBoxSizeMode.StretchImage;
                    gto.Load("picture/goto.png");
                    gto.Height = 30;
                    gto.Width = 30;
                    gto.Left = 200;
                    gto.Top = 20;
                    gto.Name = dt1.Rows[i][1].ToString();
                    gto.Click += new EventHandler(this.picgotoNP_click);

                    if (turn)
                    {
                        pn.BackColor = System.Drawing.Color.FromArgb(242, 219, 39);
                        turn = false;
                    }
                    else if (turn == false)
                    {
                        pn.BackColor = System.Drawing.Color.FromArgb(247, 232, 114);
                        turn = true;
                    }

                    pn.Controls.Add(Ten);
                    pn.Controls.Add(BH);
                    pn.Controls.Add(gto);

                    pn.Top = top;
                    pnSear.Controls.Add(pn);
                    top += pn.Height;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            ClearSearch();
        }

        void picgotoTV_click(object sender, EventArgs e)
        {
            PictureBox gto = sender as PictureBox;
            NGUOIHOC.idbaihoc = gto.Name;
            CheckLearn();

            Hoctuvung htv = new Hoctuvung();
            htv.Show();
            htv.TopLevel = false;
            Nguoidungfrom.ndf.pn.Controls.Add(htv);
            htv.Dock = DockStyle.Fill;
            htv.BringToFront();

            ClearSearch();
        }
        void picgotoNP_click(object sender, EventArgs e)
        {
            PictureBox gto = sender as PictureBox;
            NGUOIHOC.idbaihoc = gto.Name;
            CheckLearn();

            Hocnguphap hnp = new Hocnguphap();
            hnp.Show();
            hnp.TopLevel = false;
            Nguoidungfrom.ndf.pn.Controls.Add(hnp);
            hnp.Dock = DockStyle.Fill;
            hnp.BringToFront();

            ClearSearch();
        }
    }
}
