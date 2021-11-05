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
    public partial class Nhapnguoidung : Form
    {
        public Nhapnguoidung()
        {
            InitializeComponent();
        }
        Database db;
        Hieuung hu=new Hieuung();
        string MANH;
        private  void Nguoihocinfo_Load(object sender, EventArgs e)
        {
            doimaudisable();
            try
            {
                db = new Database("QLAV");
            }
            catch (Exception )
            {
                MessageBox.Show("Lỗi kết nối");
            }

            DataTable dt = db.Execute("select * from NGUOIHOC");
            dtdrigNH.DataSource = dt;
            lbsl.Text = "Hiện có: " + (dt.Rows.Count).ToString()+" người dùng.";

        }
        /*------------------------------------------------------------------------*/
        public void disablebutton()
        {
            doimaudisable();
            butcapnhat.Enabled = false;
            customButton1.Enabled = false;
            butxoa.Enabled = false;
        }
        
        public void enablebutton()
        {
            doimauenable();
            butcapnhat.Enabled = true;
            customButton1.Enabled = true;
            butxoa.Enabled = true;
        }
        public void doimaudisable()
        {
            hu.doimaubutton(194, 194, 194, butcapnhat);
            hu.doimaubutton(194, 194, 194, customButton1);
            hu.doimaubutton(194, 194, 194, butxoa);
        }
        public void doimauenable()
        {
            hu.doimaubutton(204, 228, 255, butcapnhat);
            hu.doimaubutton(204, 228, 255, customButton1);
            hu.doimaubutton(255, 166, 174, butxoa);
        }
        public void cleartextbox()
        {
            txtemail.Texts = "";
            txthoten.Texts = "";
            txtkn.Text = "";
            txtlv.Text = "";
            txtmanh.Texts = "";
            txtmk.Texts = "";
            txttk.Texts = "";
        }
        /*------------------------------------------------------------------------*/
        private void dtdrigNH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i = dtdrigNH.CurrentRow.Index;                
                txtmanh.Texts = dtdrigNH.Rows[i].Cells[0].Value.ToString();
                MANH= dtdrigNH.Rows[i].Cells[0].Value.ToString();
                txthoten.Texts = dtdrigNH.Rows[i].Cells[1].Value.ToString();
                txttk.Texts = dtdrigNH.Rows[i].Cells[2].Value.ToString();
                txtmk.Texts = dtdrigNH.Rows[i].Cells[3].Value.ToString();
                txtemail.Texts = dtdrigNH.Rows[i].Cells[4].Value.ToString();
                txtlv.Text = dtdrigNH.Rows[i].Cells[5].Value.ToString();
                txtkn.Text = dtdrigNH.Rows[i].Cells[6].Value.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi");
                db.huyketnoi();
            }
            
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            string LV="", KN="";
            DataTable dt = db.Execute("select top 1 MaNH from NGUOIHOC order by MaNH desc");
            if (dt.Rows.Count == 0)
            {
                MANH = "0001";
            }
            else
            {
                MANH = dt.Rows[0][0].ToString();                
                MANH = (int.Parse(MANH) + 1).ToString("0000");
            }
            if(txthoten.Texts==""|| txttk.Texts==""||txtmk.Texts=="")
            {
                MessageBox.Show("Thông tin không được bỏ trống!");
            }           
            else if (db.kiemtra("select * from NGUOIHOC where TK='" + txttk.Texts + "'"))
                MessageBox.Show("Tài khoản hoặc mật khẩu đã có người dùng.");
            else if (db.kiemtra("select * from NGUOIHOC where MK='" + txtmk.Texts + "'"))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu đã có người dùng.");
            }
            else
            {
                try
                {
                    if (txtlv.Text == "") LV = "0";
                    if (txtkn.Text == "") KN = "0";
                    string insert = "insert into NGUOIHOC values('" + MANH + "',N'" + txthoten.Texts + "','" + txtemail.Texts + "','" + txttk.Texts + "','" + txtmk.Texts + "','" + LV + "','" + KN + "')";
                    db.ExecuteNonQuery(insert);
                    DataTable bt = db.Execute("select * from NGUOIHOC");
                    dtdrigNH.DataSource = bt;
                    lbsl.Text = "Hiện có: " + (bt.Rows.Count).ToString();
                    cleartextbox();
                    disablebutton();
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                    db.huyketnoi();
                }
            }
        }

        private void butcapnhat_Click(object sender, EventArgs e)
        {
            string LV="", KN="";
            if (txthoten.Texts == "" || txttk.Texts == "" || txtmk.Texts == "")
            {
                MessageBox.Show("Thông tin không được bỏ trống!");
            }
            else if (db.kiemtra("select * from NGUOIHOC where TK='" + txttk.Texts + "'"))
                MessageBox.Show("Tài khoản hoặc mật khẩu đã có người dùng.");
            else if (db.kiemtra("select * from NGUOIHOC where MK='" + txtmk.Texts + "'"))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu đã có người dùng.");
            }
            else
            {
                try
                {
                    if (txtlv.Text == "") LV = "0";
                    if (txtkn.Text == "") KN = "0";
                    string update = "update NGUOIHOC set Name=N'" + txthoten.Texts + "',TK='" + txttk.Texts + "',MK='" + txtmk.Texts + "',email='" + txtemail.Texts + "',LV='" + LV + "',KN='" + KN + "' where MaNH='" + txtmanh.Texts + "'";
                    db.ExecuteNonQuery(update);
                    DataTable bt = db.Execute("select * from NGUOIHOC");
                    dtdrigNH.DataSource = bt;
                    disablebutton();
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                    db.huyketnoi();
                }
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string xoa = "delete from NGUOIHOC where MaNH='" + MANH + "'";
                db.ExecuteNonQuery(xoa);
                DataTable dt = db.Execute("select * from NGUOIHOC");
                dtdrigNH.DataSource = dt;
                lbsl.Text = "Hiện có: " + (dt.Rows.Count).ToString();
                cleartextbox();
                disablebutton();
            }
            catch
            {
                MessageBox.Show("Lỗi");
                db.huyketnoi();
            }
        }        
        private void butthaotac_Click(object sender, EventArgs e)
        {           
            enablebutton();
        }

        private void buthuy_Click(object sender, EventArgs e)
        {           
            disablebutton();
        }
        /* number only textboc*/
        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!char.IsNumber(e.KeyChar))&&(!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtkn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        //////////////////////////////
    }
}
