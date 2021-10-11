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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }    



        private void Form1_Load(object sender, EventArgs e)
        {
            pnelhoc.Hide();
            GC.Collect();
        }

        private void picedit_MouseHover(object sender, EventArgs e)
        {
           picedit.Load("picture/edithover.png");
            GC.Collect();
           
        }

        private void picedit_MouseLeave(object sender, EventArgs e)
        {
            picedit.Load("picture/edit.png");
            GC.Collect();
        }

        private void picedit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formcanhan fcn = new formcanhan();
            fcn.StartPosition = FormStartPosition.Manual;
            fcn.Location = this.Location;
            fcn.ShowDialog();
            this.Close();
            GC.Collect();


        }

        private void buthoc_Click(object sender, EventArgs e)
        {
            maincrn.Hide();
            pnelhoc.Show();
            GC.Collect();

        }
    }
}
