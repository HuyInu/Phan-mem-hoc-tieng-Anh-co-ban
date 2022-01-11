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
    public partial class Exit : Form
    {
        public static Exit ex;
        public bool Thoat;
        public Exit()
        {
            InitializeComponent();
        }

        private void butdangxuat_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Thoat = true;
            this.Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            /*GC.Collect();
            this.Close();*/
            Thoat = false;
            this.Close();
        }

        private void Exit_Load(object sender, EventArgs e)
        {

        }
    }
}
