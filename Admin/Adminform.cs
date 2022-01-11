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
        QLhoc qlh = new QLhoc();

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

            qlh.TopLevel = false;
            maincrn.Controls.Add(qlh);
            qlh.Dock = DockStyle.Fill;
            qlh.Show();
            qlh.Hide();

        }

        private void butnhapNH_Click_1(object sender, EventArgs e)
        {
            
            GC.Collect();
            bh.Hide();
            qlh.Hide();
            nd.Show();
        }

        private void butnhapBAIHOC_Click(object sender, EventArgs e)
        {

            GC.Collect();
            qlh.Hide();
            nd.Hide();
            bh.Show();
        }
        private void butTK_Click(object sender, EventArgs e)
        {
            GC.Collect();
            nd.Hide();
            bh.Hide();
            qlh.Show();
        }
        private void butdangxuat_Click(object sender, EventArgs e)
        {
            DialogResult i = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (i == DialogResult.Yes)
            {                
                Dangnhap.dn.Show();
                this.FormClosing -= Adminform_FormClosing;
                this.Close();
            }
        }

        private void Adminform_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void Adminform_FormClosing(object sender, FormClosingEventArgs e)
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
