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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void labdangky_MouseEnter(object sender, EventArgs e)
        {
            labdangky.ForeColor = System.Drawing.Color.FromArgb(0, 119, 171);
        }

        private void labdangky_MouseLeave(object sender, EventArgs e)
        {
            labdangky.ForeColor = System.Drawing.Color.FromArgb(7, 59, 122);
        }

        private void labmatkhau_MouseEnter(object sender, EventArgs e)
        {
            labmatkhau.ForeColor = System.Drawing.Color.FromArgb(0, 119, 171);
        }

        private void labmatkhau_MouseLeave(object sender, EventArgs e)
        {
            labmatkhau.ForeColor = System.Drawing.Color.FromArgb(7, 59, 122);
        }

        private void labdangky_Click(object sender, EventArgs e)
        {
            Dangky dk = new Dangky();
            dk.StartPosition = FormStartPosition.Manual;
            dk.Location = this.Location;
            dk.Left = 380;
            dk.Top = 100;
            dk.ShowDialog();
        }

        private void butdn_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.ShowDialog();
        }
    }
}
