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
    public partial class MSHoanThanhBaiHoc : Form
    {
        public MSHoanThanhBaiHoc()
        {
            InitializeComponent();
        }
        Database db;
        public int Dung, Sai;

        private void MSHoanThanhBaiHoc_Load(object sender, EventArgs e)
        {
            lbR.Text = "Đúng: " + Dung.ToString() + " câu.";
            centerPanel(lbR, pnKQ);
            lbF.Text ="Sai: "+ Sai.ToString()+ " câu.";
            centerPanel(lbF, pnKQ);
            lbphantram.Text ="Hoàn thành:" + ((Dung * 100) / (Dung+Sai)).ToString() + " %";
            centerPanel(lbphantram, pnKQ);
        }

        private void pnKQ_Paint(object sender, PaintEventArgs e)
        {

        }
        public void centerPanel(Label lb,Panel pn)
        {
            lb.Left = (pn.Width - lb.Width) / 2;
        }
        private void butok_Click(object sender, EventArgs e)
        {
            ThuThach tt = new ThuThach();
            tt.Close();
            this.Close();
            GC.Collect();
        }
    }
}
