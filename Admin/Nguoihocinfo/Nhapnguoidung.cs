using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        bool clickstat=false;
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
           
            xuatdl();
            demsl();
            

        }
        /*------------------------------------------------------------------------*/
        public void disablebutton()
        {
            doimaudisable();
            butcapnhat.Enabled = false;
            customButton1.Enabled = false;
            butxoa.Enabled = false;
            buthuy.Enabled = false;
        }
        
        public void enablebutton()
        {
            doimauenable();
            butcapnhat.Enabled = true;
            customButton1.Enabled = true;
            butxoa.Enabled = true;
            buthuy.Enabled = true;
        }
        public void doimaudisable()
        {
            hu.doimaubutton(194, 194, 194, butcapnhat);
            hu.doimaubutton(194, 194, 194, customButton1);
            hu.doimaubutton(194, 194, 194, butxoa);
            hu.doimaubutton(194, 194, 194, buthuy);
        }
        public void doimauenable()
        {
            hu.doimaubutton(204, 228, 255, butcapnhat);
            hu.doimaubutton(204, 228, 255, customButton1);
            hu.doimaubutton(255, 166, 174, butxoa);
            hu.doimaubutton(204, 228, 255, buthuy);
        }
        public void cleartextbox()
        {
            txtemail.Texts = "";
            txthoten.Texts = "";
            txtmanh.Texts = "";
            txtmk.Texts = "";
            txttk.Texts = "";
        }
        public string getma()
        {
            string MANH;
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
            return MANH;
        }
        public void xuatdl()
        {
            DataTable dt = db.Execute("select MaNH as 'Mã NH',Name as Tên,Email,TK as 'Tài khoản',MK as 'Mật khẩu',Ava from NGUOIHOC");
            dtdrigNH.DataSource = dt;
        }
        public void demsl()
        {
            lbsl.Text = "Hiện có: " + (dtdrigNH.Rows.Count -1).ToString() + " người dùng.";
        }
        public Image convertbytetoimage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        /*------------------------------------------------------------------------*/
        private void dtdrigNH_SelectionChanged(object sender, EventArgs e)
        {
           try
           {
                int i = dtdrigNH.CurrentRow.Index;                
                txtmanh.Texts = dtdrigNH.Rows[i].Cells[0].Value.ToString();
                txthoten.Texts = dtdrigNH.Rows[i].Cells[1].Value.ToString();
                txttk.Texts = dtdrigNH.Rows[i].Cells[3].Value.ToString();
                txtmk.Texts = dtdrigNH.Rows[i].Cells[4].Value.ToString();
                txtemail.Texts = dtdrigNH.Rows[i].Cells[2].Value.ToString();
                avatar.Image = null;
                avatar.Image = convertbytetoimage((byte[])dtdrigNH.Rows[i].Cells[5].Value);               
                GC.Collect();
           }
           catch(Exception)
           {
           }           
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            if (txthoten.Texts == "" || txttk.Texts == "" || txtmk.Texts == "")
            {
                MessageBox.Show("Thông tin không được bỏ trống!");
                disablebutton();
            }
            else if (txthoten.Texts.Length > 10 || txthoten.Texts.Length < 5)
            {
                MessageBox.Show("Tên tối thiểu 5 ký tự, tối đa 10 ký tự");
                disablebutton();
            }
            else if (txttk.Texts.Length > 10 || txttk.Texts.Length < 5)
            {
                MessageBox.Show("Tài khoản tối thiểu 5 ký tự, tối đa 10 ký tự");
                disablebutton();
            }
            else if (txtmk.Texts.Length > 10 || txtmk.Texts.Length < 5)
            {
                MessageBox.Show("Mật khẩu tối thiểu 5 ký tự, tối đa 10 ký tự");
                disablebutton();
            }
            else if (db.kiemtra("select TK from NGUOIHOC where TK='" + txttk.Texts + "'"))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu đã có người dùng.");
                disablebutton();
            }
            else if (db.kiemtra("select MK from NGUOIHOC where MK='" + txtmk.Texts + "'"))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu đã có người dùng.");
                disablebutton();
            }
            else if (db.kiemtra("select Email from NGUOIHOC where Email='" + txtemail.Texts + "'"))
            {
                MessageBox.Show("Email đã có người dùng.");
                disablebutton();
            }
            else
            {
                try
                {
                    string insert = "insert into NGUOIHOC values('" + getma() + "',N'" + txthoten.Texts + "','" + txtemail.Texts + "','" + txttk.Texts + "','" + txtmk.Texts + "',(select Anh from DEFAULTAVATAR))";
                    db.ExecuteNonQuery(insert);
                    xuatdl();
                    demsl();
                    cleartextbox();
                    disablebutton();
                    MessageBox.Show("Thêm thành công.");
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại!.");
                    db.huyketnoi();
                    disablebutton();
                }
            }
        }

        private void butcapnhat_Click(object sender, EventArgs e)
        {
            if (txthoten.Texts == "" || txttk.Texts == "" || txtmk.Texts == "")
            {
                MessageBox.Show("Thông tin không được bỏ trống!");
                disablebutton();
            }
            else if (txthoten.Texts.Length > 10)
            {
                MessageBox.Show("Tên tối đa 10 ký tự");
                disablebutton();
            }
            else if (txttk.Texts.Length > 10)
            {
                MessageBox.Show("Tài khoản tối đa 10 ký tự");
                disablebutton();
            }
            else if (txtmk.Texts.Length > 10)
            {
                MessageBox.Show("Mật khẩu tối đa 10 ký tự");
                disablebutton();
            }
            else if (db.kiemtra("select TK from NGUOIHOC where TK='" + txttk.Texts + "' Except select TK from NGUOIHOC where MaNH='" + txtmanh.Texts + "'"))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu đã có người dùng.");
                disablebutton();
            }
            else if (db.kiemtra("select MK from NGUOIHOC where MK='" + txtmk.Texts + "'Except select MK from NGUOIHOC where MaNH='" + txtmanh.Texts + "'"))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu đã có người dùng.");
                disablebutton();
            }
            else if (db.kiemtra("select Email from NGUOIHOC where Email='" + txtemail.Texts + "'Except select Email from NGUOIHOC where MaNH='" + txtmanh.Texts + "'"))
            {
                MessageBox.Show("Email đã có người dùng.");
                disablebutton();
            }
            else
            {
                try
                {
                    string update = "update NGUOIHOC set Name=N'" + txthoten.Texts + "',TK='" + txttk.Texts + "',MK='" + txtmk.Texts + "',email='" + txtemail.Texts + "' where MaNH='" + txtmanh.Texts + "'";
                    db.ExecuteNonQuery(update);
                    xuatdl();
                    disablebutton();
                    MessageBox.Show("Sửa thành công.");
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại!");
                    db.huyketnoi();
                    disablebutton();
                }
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
                DialogResult dl = MessageBox.Show("Thông tin người dùng sẽ mất. Bạn có chắc xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                try
                {
                    string xoa = "delete from NGUOIHOC where MaNH='" + txtmanh.Texts + "'";
                    db.ExecuteNonQuery(xoa);
                    xuatdl();
                    demsl();
                    cleartextbox();
                    disablebutton();
                    MessageBox.Show("Xóa thành công.");
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!.");
                    db.huyketnoi();
                    disablebutton();
                }  
            }
            else disablebutton();

        }        
        private void butthaotac_Click(object sender, EventArgs e)
        {           
            enablebutton();
        }

        private void buthuy_Click(object sender, EventArgs e)
        {           
            disablebutton();
        }

        private void butava_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Avatar của người dùng sẽ thay dổi. Bạn có chắc chắn?", "Thông báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dl==DialogResult.Yes)
            {
                db.ExecuteNonQuery("update NGUOIHOC set Ava=(select Anh from DEFAULTAVATAR) where MaNH='"+txtmanh.Texts+"'");
                xuatdl();
           }
        }

        private void txtnoidung_TextChanged(object sender, EventArgs e)
        {
            if (raten.Checked == true)
            {
                DataTable dt = db.Execute("select MaNH as 'Mã NH',Name as Tên,Email,TK as 'Tài khoản',MK as 'Mật khẩu',Ava from NGUOIHOC where Name like '%" + txttimkiem.Text + "%'");
                dtdrigNH.DataSource = dt;
            }
            else if(raemail.Checked==true)
            {
                DataTable dt = db.Execute("select MaNH as 'Mã NH',Name as Tên,Email,TK as 'Tài khoản',MK as 'Mật khẩu',Ava from NGUOIHOC where Email like '%" + txttimkiem.Text + "%'");
                dtdrigNH.DataSource = dt;
            }
            else if(ratk.Checked==true)
            {
                DataTable dt = db.Execute("select MaNH as 'Mã NH',Name as Tên,Email,TK as 'Tài khoản',MK as 'Mật khẩu',Ava from NGUOIHOC where TK like '%" + txttimkiem.Text + "%'");
                dtdrigNH.DataSource = dt;
            }
            else if(ramk.Checked==true)
            {
                DataTable dt = db.Execute("select MaNH as 'Mã NH',Name as Tên,Email,TK as 'Tài khoản',MK as 'Mật khẩu',Ava from NGUOIHOC where MK like '%" + txttimkiem.Text + "%'");
                dtdrigNH.DataSource = dt;
            }
            else
            {
                DataTable dt = db.Execute("select MaNH as 'Mã NH',Name as Tên,Email,TK as 'Tài khoản',MK as 'Mật khẩu',Ava from NGUOIHOC where Name like '%" + txttimkiem.Text + "%'");
                dtdrigNH.DataSource = dt;
            }
        }

        private void picloc_Click(object sender, EventArgs e)
        {
            if (clickstat == false)
            {
                pnloc.Show();
                clickstat = true;
            }
            else
            {
                pnloc.Hide();
                clickstat = false;
                raten.Checked = false;
                raemail.Checked = false;
                ratk.Checked = false;
                ramk.Checked = false;
            }

        }

        private void butaddnew_Click(object sender, EventArgs e)
        {
            txtmanh.Texts = getma();
            txtemail.Texts = "";
            txthoten.Texts = "";
            txtmk.Texts = "";
            txttk.Texts = "";
        }
        //////////////////////////////
    }
}
