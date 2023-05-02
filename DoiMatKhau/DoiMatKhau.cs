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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        Database db;
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            db = new Database("QLAV");


        }

        private void butDoiMk_Click(object sender, EventArgs e)
        {
            if (txttk.Texts == "" || txtmk.Texts == "" || txtmk2.Texts == "" )
            {
                if (txttk.Texts == "")
                {
                    labwantk.Show();
                    wan1.Show();
                }
                else
                {
                    labwantk.Hide();
                    wan1.Hide();
                }

                if (txtmk.Texts == "")
                {
                    labwanmk.Show();
                    wan2.Show();
                }
                else
                {
                    labwanmk.Hide();
                    wan2.Hide();
                }

                if (txtmk2.Texts == "")
                {
                    lbwanmk2.Show();
                    wan3.Show();
                }
                else
                {
                    lbwanmk2.Hide();
                    wan3.Hide();
                }
            }
            
            else if (db.kiemtra("select * from NGUOIHOC where TK='" + txttk.Texts + "' and MK='" + txtmk.Texts + "'") == false)
                MessageBox.Show("Tài khoản hoặc mật khẩu không tồn tại.");
            else if(db.kiemtra("select * from NGUOIHOC where MK='"+txtmk2.Texts+"'"))
                MessageBox.Show("Mật khẩu đã tồn tại.");
            else if (txtmk2.Texts.Length > 10 || txtmk2.Texts.Length < 5)
                MessageBox.Show("Mật khẩu tối thiểu 5 ký tự và tối đa 10 ký tự");
            else if(txtmk2.Texts!=txtmk3.Texts)
                MessageBox.Show("Mật khẩu không trùng nhau.");
            else
            {
                db.ExecuteNonQuery("update NGUOIHOC set MK='" + txtmk3.Texts + "' where TK='" + txttk.Texts + "'");
                MessageBox.Show("Đổi mật khẩu thành công.");
                this.Close();
            }
        }
    }
}
