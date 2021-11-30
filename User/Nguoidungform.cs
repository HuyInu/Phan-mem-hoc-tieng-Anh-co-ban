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

    public partial class Nguoidungfrom : Form
    {
        public static Nguoidungfrom ndf;
        public Panel pn;
        public Nguoidungfrom()
        {
            InitializeComponent();
            ndf = this;
            pn = maincrn;
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
            DataTable dt = db.Execute("select Name from NGUOIHOC where MaNH='" + NGUOIHOC.id + "'");
            labhoten.Text = dt.Rows[0][0].ToString();

            Nguoidungselect nd = new Nguoidungselect();
            nd.Show();
            nd.TopLevel = false;
            maincrn.Controls.Add(nd);
            nd.Dock = DockStyle.Fill;
        }     

        private void picedit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formcanhan fcn = new formcanhan();
            fcn.StartPosition = FormStartPosition.Manual;
            fcn.Location = this.Location;
            fcn.ShowDialog();
            this.Close();
            GC.Collect();
        }
        private void picedit_MouseEnter(object sender, EventArgs e)
        {

            picedit.Load("picture/edithover.png");
            GC.Collect();
        }

        private void picedit_MouseLeave(object sender, EventArgs e)
        {
            picedit.Load("picture/edit.png");
            GC.Collect();
        }
    }

}
