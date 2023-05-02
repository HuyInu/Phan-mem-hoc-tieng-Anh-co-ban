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
        string MANH = "";
        private void Dangky_Load(object sender, EventArgs e)
        {
            
            try
            {
                db = new Database("QLAV");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            timer1.Start();        
            DataTable dt = db.Execute("select top 1 MaNH from NGUOIHOC order by MaNH desc");
            if(dt.Rows.Count==0)
            {
                MANH = "0001";
            }
            else
            {
                MANH = dt.Rows[0][0].ToString();               
                MANH = (int.Parse(MANH) + 1).ToString("0000");
            }

        }

        private void but_Click(object sender, EventArgs e)
        {
            /*if (txtmk.Texts != txtmk2.Texts)
            {
                labwan.Visible = true;
                labwan5.Visible = true;
            }
            else
            {
                labwan.Visible = false;
                labwan5.Visible = false;
            }*/
            if (txtname.Texts == "" || txttk.Texts == "" || txtmk.Texts == "" || txtmk2.Texts == "" || txtemail.Texts == ""|| txtmk.Texts != txtmk2.Texts)
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
            else if(txtname.Texts.Length>10|| txtname.Texts.Length<5)
                MessageBox.Show("Tên tối thiểu 5 ký tự, tối đa 10 ký tự");
            else if(txttk.Texts.Length>10 || txttk.Texts.Length<5)
                MessageBox.Show("Tài khoản tối thiểu 5 ký tự, tối đa 10 ký tự");
            else if(txtmk.Texts.Length>10|| txtmk.Texts.Length <5)
                MessageBox.Show("Mật khẩu tối thiểu 5 ký tự, tối đa 10 ký tự");
            else
            {
                if (db.kiemtra("select * from NGUOIHOC where TK='" + txttk.Texts + "'"))
                    MessageBox.Show("Tài khoản hoặc mật khẩu đã có người dùng.");
                else if(db.kiemtra("select * from NGUOIHOC where MK='" + txtmk.Texts + "'")||txttk.Texts=="admin"||txtmk.Texts=="admin")
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu đã có người dùng.");
                }
                else if (db.kiemtra("select Email from NGUOIHOC where Email='" + txtemail.Texts + "'"))
                {
                    MessageBox.Show("Email đã có người dùng.");
                }
                else  
                {
                    try
                    {
                        DataTable dt = db.Execute("select Anh from DEFAULTAVATAR");
                        string sql = "insert into NGUOIHOC values('" + MANH + "','" + txtname.Texts + "','" + txtemail.Texts + "','" + txttk.Texts + "','" + txtmk.Texts + "',(select Anh from DEFAULTAVATAR))";
                        db.ExecuteNonQuery(sql);
                        MessageBox.Show("Đăng ký thành công");
                        this.Close();
                        Dispose();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đăng ký thất bại!");
                    }               
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void Dangky_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void gradian1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
