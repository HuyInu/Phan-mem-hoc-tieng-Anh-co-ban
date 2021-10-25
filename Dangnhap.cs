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
        public void MouseEnterlabel(Label a)
        {
            a.ForeColor = System.Drawing.Color.FromArgb(0, 119, 171);
        }
        public void MouseLeavelabel(Label a)
        {
            a.ForeColor = System.Drawing.Color.FromArgb(7, 59, 122);
        }
        private void labdangky_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterlabel(labdangky);
        }

        private void labdangky_MouseLeave(object sender, EventArgs e)
        {
            MouseLeavelabel(labdangky);
        }

        private void labmatkhau_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterlabel(labmatkhau);
        }

        private void labmatkhau_MouseLeave(object sender, EventArgs e)
        {
            MouseLeavelabel(labmatkhau);
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
