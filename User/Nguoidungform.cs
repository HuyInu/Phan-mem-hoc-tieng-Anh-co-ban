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
using System.Globalization;
using System.IO;

namespace Đồ_án
{

    public partial class Nguoidungfrom : Form
    {
        public static Nguoidungfrom ndf;
        public Panel pn;
        public PictureBox pic;
        public PictureBox picInfo;
        public Label ten;
        public Nguoidungfrom()
        {
            InitializeComponent();
            ndf = this;
            pn = maincrn;
            pic = picava;
            ten = labhoten;
            picInfo = pictureBox1;
        }
        Database db;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                db = new Database("QLAV");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            DataTable dt = db.Execute("select Name,Ava from NGUOIHOC where MaNH='" + NGUOIHOC.id + "'");
            labhoten.Text = dt.Rows[0][0].ToString();
            labhoten.Left = (pnelava.Width - labhoten.Width) / 2;
            picava.Image = convertbytetoimage((byte[])dt.Rows[0][1]);

            Nguoidungselect nd = new Nguoidungselect();
            nd.Show();
            nd.TopLevel = false;
            maincrn.Controls.Add(nd);
            nd.Dock = DockStyle.Fill;

            GC.Collect();
        }
        public Image convertbytetoimage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            formcanhan fcn = new formcanhan();
            fcn.Show();
            fcn.TopLevel = false;
            maincrn.Controls.Add(fcn);
            fcn.Dock = DockStyle.Fill;
            fcn.BringToFront();
        }

        private void butdangxuat_Click(object sender, EventArgs e)
        {
            DialogResult i = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(i==DialogResult.Yes)
            {
                Dangnhap.dn.Show();
                this.FormClosing -= Nguoidungfrom_FormClosing;
                this.Close();
            }
        }

        private void Nguoidungfrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit ex = new Exit();
            ex.StartPosition = FormStartPosition.CenterParent;
            ex.Location = this.Location;
            ex.ShowDialog();
            if (ex.Thoat) Environment.Exit(0);
            else e.Cancel = true;
        }
    }
}
