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
    public partial class Nguoihocinfo : Form
    {
        public Nguoihocinfo()
        {
            InitializeComponent();
        }
        Database db;
        private void Nguoihocinfo_Load(object sender, EventArgs e)
        {
            try
            {
                db = new Database("QLAV");
            }
            catch (Exception )
            {
                MessageBox.Show("Lỗi kết nối");
            }

            DataTable bt = db.Execute("select * from NGUOIHOC");
            dtdrigNH.DataSource = bt;

        }
    }
}
