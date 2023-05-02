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
        public static Dangnhap dn;
        public Dangnhap()
        {
            InitializeComponent();
            dn = this;
        }
        Database db;
        private void Dangnhap_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                db = new Database("QLAV");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
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
            if (txttk.Texts == "" || txtmk.Texts == "")
            {
                if (txttk.Texts == "")
                {
                    labwantk.Visible = true;
                    labwan1.Visible = true;
                }
                else
                {
                    labwantk.Visible = false;
                    labwan1.Visible = false;
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
            }
            else if (db.kiemtra("select * from NGUOIHOC where TK='" + txttk.Texts + "' and MK='" + txtmk.Texts + "'"))
            {
                DataTable dt = db.Execute("select MaNH from NGUOIHOC where TK='" + txttk.Texts + "' and MK='" + txtmk.Texts + "'");
                NGUOIHOC.id= dt.Rows[0][0].ToString();
                this.Hide();
                txttk.Texts = "";
                txtmk.Texts = "";
                Nguoidungfrom ngd = new Nguoidungfrom();
                ngd.StartPosition = FormStartPosition.CenterScreen;
                ngd.ShowDialog();
            }else        
            if(txttk.Texts=="admin"&& txtmk.Texts=="admin")
            {
                this.Hide();
                txttk.Texts = "";
                txtmk.Texts = "";
                Adminform ad = new Adminform();
                ad.StartPosition = FormStartPosition.CenterScreen;      
                ad.ShowDialog();
            }
            else
            {
                labwantk.Visible = false;
                labwan1.Visible = false;
                labwanmk.Visible = false;
                labwan2.Visible = false;
                MessageBox.Show("Tài khoản hoặc mật khẩu không tồn tại.");
            }
        }

        private void labmatkhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau mk = new DoiMatKhau();
            mk.StartPosition = FormStartPosition.Manual;
            mk.Location = this.Location;
            mk.Left = 380;
            mk.Top = 100;
            mk.ShowDialog();
        }
    }
}
