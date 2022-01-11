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
    public partial class TimkiemBH_Admin : Form
    {
        public TimkiemBH_Admin()
        {
            InitializeComponent();
        }
        Database db;
        private void TimkiemBH_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                db = new Database("QLAV");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
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
                    gto.Click += new EventHandler(this.picgoto_click);

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
                    gto.Click += new EventHandler(this.picgoto_click);

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

                    GC.Collect();
                }
            }
        }
        void picgoto_click(object sender, EventArgs e)
        {
            PictureBox gto = sender as PictureBox;
            Nhapbaihoc.nph.combh.Text = gto.Name;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            pnSear.Controls.Clear();
            GC.Collect();
        }
    }
}
