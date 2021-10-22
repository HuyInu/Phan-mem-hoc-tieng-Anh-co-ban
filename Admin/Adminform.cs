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


        private void Adminform_Load(object sender, EventArgs e)
        {
            
        }

        private void butnhapNH_Click_1(object sender, EventArgs e)
        {
            Nguoihocinfo nh = new Nguoihocinfo();
            nh.TopLevel = false;
            maincrn.Controls.Add(nh);
            nh.Dock = DockStyle.Fill;
            nh.Show();
        }
    }
}
