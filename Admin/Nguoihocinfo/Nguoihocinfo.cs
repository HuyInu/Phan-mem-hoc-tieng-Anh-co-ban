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
        private  void Nguoihocinfo_Load(object sender, EventArgs e)
        {
            doimaubutton(194, 194, 194, 194, 194, 194);
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
        //***************************//
        public void disablebutton()
        {          
            butcapnhat.Enabled = false;
            customButton1.Enabled = false;
            butxoa.Enabled = false;
        }
        public void enablebutton()
        {
            butcapnhat.Enabled = true;
            customButton1.Enabled = true;
            butxoa.Enabled = true;
        }
        public void doimaubutton(int a, int b, int c, int d, int e, int f)
        {
            butcapnhat.BackColor = System.Drawing.Color.FromArgb(a, b, c);
            customButton1.BackColor = System.Drawing.Color.FromArgb(a, b, c);
            butxoa.BackColor = System.Drawing.Color.FromArgb(d, e, f);
        }
        public void cleartextbox()
        {
            txtemail.Texts = "";
            txthoten.Texts = "";
            txtkn.Texts = "";
            txtlv.Texts = "";
            txtmanh.Texts = "";
            txtmk.Texts = "";
            txttk.Texts = "";
        }
        //***************************//
        private void dtdrigNH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                    int i = dtdrigNH.CurrentRow.Index;                
                    txtmanh.Texts = dtdrigNH.Rows[i].Cells[0].Value.ToString();
                    txthoten.Texts = dtdrigNH.Rows[i].Cells[1].Value.ToString();
                    txttk.Texts = dtdrigNH.Rows[i].Cells[2].Value.ToString();
                    txtmk.Texts = dtdrigNH.Rows[i].Cells[3].Value.ToString();
                    txtemail.Texts = dtdrigNH.Rows[i].Cells[4].Value.ToString();
                    txtlv.Texts = dtdrigNH.Rows[i].Cells[5].Value.ToString();
                    txtkn.Texts = dtdrigNH.Rows[i].Cells[6].Value.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("??");
            }
            
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            string insert = "insert into NGUOIHOC values('"+txtmanh.Texts+"','" + txthoten.Texts + "','" + txttk.Texts + "','" + txtmanh.Texts + "','" + txtmanh.Texts + "','" + txtlv.Texts + "','" + txtkn.Texts + "')";
            db.ExecuteNonQuery(insert);
            DataTable bt = db.Execute("select * from NGUOIHOC");
            dtdrigNH.DataSource = bt;
            cleartextbox();
            disablebutton();
        }

        private void butcapnhat_Click(object sender, EventArgs e)
        {
            string update = "update NGUOIHOC set Name='" + txthoten.Texts + "',TK='" + txttk.Texts + "',MK='" + txtmk.Texts + "',email='" + txtemail.Texts + "',LV='" + txtlv.Texts + "',KN='" + txtkn.Texts + "' where MaNH='"+txtmanh.Texts+"'";
            db.ExecuteNonQuery(update);
            DataTable bt = db.Execute("select * from NGUOIHOC");
            dtdrigNH.DataSource = bt;
            disablebutton();
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            string xoa = "delete from NGUOIHOC where MaNH='" + txtmanh.Texts + "'";
            db.ExecuteNonQuery(xoa);
            DataTable bt = db.Execute("select * from NGUOIHOC");
            dtdrigNH.DataSource = bt;
            cleartextbox();
            disablebutton();

        }
        
        private void butthaotac_Click(object sender, EventArgs e)
        {
            doimaubutton(204, 228, 255,255, 166, 174);
            enablebutton();
        }
    }
}
