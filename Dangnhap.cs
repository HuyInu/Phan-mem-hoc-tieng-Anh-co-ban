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
        public Dangnhap()
        {
            InitializeComponent();
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
            if(txttk.Texts == "")
            {
                labwantk.Visible = true;
                labwan1.Visible = true;
            }
            else
            {
                labwantk.Visible = false;
                labwan1.Visible = false;
            }
            if(txtmk.Texts == "")
            {
                labwanmk.Visible=true;
                labwan2.Visible = true;
            }
            else
            {
                labwanmk.Visible = false;
                labwan2.Visible = false;
            }
            if (db.kiemtra("select * from NGUOIHOC where TK='" + txttk.Texts + "' and MK='" + txtmk.Texts + "'"))
            {
                DataTable dt = db.Execute("select MaNH from NGUOIHOC where TK='" + txttk.Texts + "' and MK='" + txtmk.Texts + "'");
                NGUOIHOC.id= dt.Rows[0][0].ToString();
                this.Hide();
                Nguoidungfrom ngd = new Nguoidungfrom();
                ngd.StartPosition = FormStartPosition.CenterScreen;
                ngd.ShowDialog();
                this.Close();
            }else        
            if(txttk.Texts=="admin"&& txtmk.Texts=="admin")
            {
                this.Hide();
                Adminform ad = new Adminform();
                ad.StartPosition = FormStartPosition.CenterScreen;      
                ad.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không tồn tài.");
            }
        }
    }
}
