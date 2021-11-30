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
        void pictureBox_click(object sender, EventArgs e)
        {
            pnTVNPop = true;
            PictureBox pic = sender as PictureBox;
            NGUOIHOC.idbaihoc = pic.Name;
            NGUOIHOC.tenbaihoc = db.dem("select TenBH from BAIHOC where MaBH='" + pic.Name + "'");
            if (db.kiemtra("select * from HOC where MaBH='" + NGUOIHOC.idbaihoc + "' and MaNH='" + NGUOIHOC.id + "'") == false)
            {
                db.ExecuteNonQuery("insert into HOC values('" + NGUOIHOC.idbaihoc + "','" + NGUOIHOC.id + "','" + "0" + "','"+"0"+"','"+"0"+"','"+"0"+"','"+0+"','"+0+"','"+0+"','"+0+"','"+0+"')");
            }
            //pnhoc.Hide();
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
    }
}
