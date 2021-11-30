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
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }

        Nhapbaihoc bh = new Nhapbaihoc();
        Nhapnguoidung nd = new Nhapnguoidung();

        private void Adminform_Load(object sender, EventArgs e)
        {
            nd.TopLevel = false;
            maincrn.Controls.Add(nd);
            nd.Dock = DockStyle.Fill;           
            nd.Show();
            nd.Hide();

            bh.TopLevel = false;
            maincrn.Controls.Add(bh);
            bh.Dock = DockStyle.Fill;
            bh.Show();
            bh.Hide();

        }

        private void butnhapNH_Click_1(object sender, EventArgs e)
        {
            
            GC.Collect();
            bh.Hide();
            nd.Show();
        }

        private void butnhapBAIHOC_Click(object sender, EventArgs e)
        {

            GC.Collect();
            nd.Hide();
            bh.Show();
        }
        private void butdangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangnhap dnh = new Dangnhap();
            dnh.StartPosition = FormStartPosition.Manual;
            dnh.Location = this.Location;
            dnh.ShowDialog();
            GC.Collect();
            this.Close();
            
        }
    }
}
