using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Đồ_án
{
    public partial class Dangky : Form
    {   
        
        public Dangky()
        {
            InitializeComponent();
        }
        Database db;
        int a;
        private void Dangky_Load(object sender, EventArgs e)
        {
            try
            {
                db = new Database("QLAV");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            timer1.Start();

            string demsql = "select count(MaNH) from NGUOIHOC";
            a = db.dem(demsql);
            //textBox1.Text = a.ToString();
            a = a + 1;

        }

        private void but_Click(object sender, EventArgs e)
        {
            if (txtmk.Texts != txtmk2.Texts)
            {
                labwan.Visible = true;
                labwan5.Visible = true;
            }
            else
            {
                labwan.Visible = false;
                labwan5.Visible = false;
            }
            if (txtname.Texts == "" || txttk.Texts == "" || txtmk.Texts == "" || txtmk2.Texts == "" || txtemail.Texts == "")
            {
                if (txtname.Texts == "")
                {
                    labwanten.Visible = true;
                    labwan3.Visible = true;
                }
                else
                {
                    labwanten.Visible = false;
                    labwan3.Visible = false;
                }

                if (txttk.Texts == "")
                {
                    labwantk.Visible = true;
                    labwan4.Visible = true;
                }
                else
                {
                    labwantk.Visible = false;
                    labwan4.Visible = false;
                }
                if (txtmk.Texts == "")
                {
                    labwanmk.Visible = true;
                    labwan2.Visible = true;
                }
                else
                {
                    labwanmk.Visible = false;
                    labwan2.Visible = false;
                }
                if (txtemail.Texts == "")
                {
                    labwanemail.Visible = true;
                    labwan6.Visible = true;
                }
                else
                {
                    labwanemail.Visible = false;
                    labwan6.Visible = false;
                }
           }
            else
            {
                try
                {
                    string sql = "insert into NGUOIHOC values('"+a+"','" + txtname.Texts + "','" + txttk.Texts + "','" + txtmk.Texts + "','" + txtemail.Texts + "',0,0)";
                    db.ExecuteNonQuery(sql);
                    MessageBox.Show("Dk thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đăng ký thất bại!");
                }
                
            }
            
        }

        private void Dangky_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
   
}
