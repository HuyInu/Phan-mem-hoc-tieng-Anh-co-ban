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
    public partial class formcanhan : Form
    {
        public formcanhan()
        {
            InitializeComponent();
        }
        Database db;
        bool clickstat=false;
        private void formcanhan_Load(object sender, EventArgs e)
        {
            db = new Database("QLAV");
            loadchartong();

            DataTable dt = db.Execute("select MaBH,TenBH from BAIHOC");
            combaihoc.DataSource = dt;
            combaihoc.DisplayMember = "TenBH";
            combaihoc.ValueMember = "MaBH";

            updateinfo();
            loadava();
        }
        /*****************Hàm tái sử dụng*******************/
        public void updateinfo()
        {
            DataTable dt = db.Execute("select Name,Email from NGUOIHOC where MaNH='" + NGUOIHOC.id + "'");
            lbname.Text = dt.Rows[0][0].ToString();
            lbemail.Text = dt.Rows[0][1].ToString();
        }
        public void loadchartong()
        {
            DataTable dt = db.Execute("select Sum(Tongdung) as 'SR',Sum(Tongsai) as 'SF',Sum(Solanhoc) as 'SL' from THONGKE where MaNH='" + NGUOIHOC.id + "'");
            if (dt.Rows[0][0]!=DBNull.Value)
            {
                chart1.Series["Salary"].Points.AddXY("Sai", dt.Rows[0]["SF"].ToString());
                chart1.Series["Salary"].Points.AddXY("Đúng", dt.Rows[0]["SR"].ToString());

                lbsumhoc.Text = "Bạn đã học " + dt.Rows[0]["SL"].ToString() + " lần.";
                lbdung.Text = "Bạn làm đúng " + dt.Rows[0]["SR"].ToString() + " lần.";
                lbsai.Text = "Bạn làm sai " + dt.Rows[0]["SF"].ToString() + " lần.";
            }
            else { }

        }
        public Image convertbytetoimage(byte[] data)
        {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
        }
        byte[] convertImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public void loadava()
        {
            try
            {
                DataTable dt = db.Execute("select Ava from NGUOIHOC where MaNH='" + NGUOIHOC.id + "'");
                avatar.Image = convertbytetoimage((byte[])dt.Rows[0][0]);
                Nguoidungfrom.ndf.pic.Image = avatar.Image;
                GC.Collect();
            }
            catch { }
        }
        /****************************************************/
        private void combaihoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GC.Collect();
                chart2.Series[0].Points.Clear();
                DataTable dt = db.Execute("select Tongdung,Tongsai,Solanhoc from THONGKE where MaNH='" + NGUOIHOC.id + "' and MaBH='" + combaihoc.SelectedValue.ToString() + "'");
                chart2.Series["Salary2"].Points.AddXY("Đúng", dt.Rows[0]["Tongdung"].ToString());
                chart2.Series["Salary2"].Points.AddXY("Sai", dt.Rows[0]["Tongsai"].ToString());

                lbsunhoc1.Text = "Bạn đã học " + dt.Rows[0]["Solanhoc"].ToString() + " lần.";
                lbdung1.Text = "Bạn làm đúng " + dt.Rows[0]["Tongdung"].ToString() + " lần.";
                lbsai1.Text = "Bạn làm sai " + dt.Rows[0]["Tongsai"].ToString() + " lần.";
            }
            catch
            {
                lbsunhoc1.Text = "Bạn đã học 0 lần.";
                lbdung1.Text = "Bạn làm đúng 0 lần.";
                lbsai1.Text = "Bạn làm sai 0 lần.";
            }
        }
        public void insertimage(string path)
        {
            db.ExecuteNonQuery(@"update NGUOIHOC set Ava= (SELECT BulkColumn FROM Openrowset( Bulk '"+path+"', Single_Blob) as img) where MaNH='" + NGUOIHOC.id + "'");
        }
        private void picava_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            opd.Multiselect = false;
            if(opd.ShowDialog()==DialogResult.OK)
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(opd.FileName);
                if (img.Width > 200 || img.Height > 200)
                {
                    MessageBox.Show("Kích thước ảnh quá lớn.");
                    GC.Collect();
                }
                else
                {
                    insertimage(Path.GetFullPath(opd.FileName));
                    loadava();
                    GC.Collect();
                }

            }
        }

        private void butdoiinfo_Click(object sender, EventArgs e)
        {
            if (clickstat == false)
            {
                txtname.Texts = lbname.Text;
                txtemail.Texts = lbemail.Text;
                txtname.Show();
                txtemail.Show();
                buthuy.Show();
                clickstat = true;
                butdoiinfo.Text = "Cập nhật.";
            }
            else
            {
                if (txtname.Texts == "" || txtemail.Texts == "")
                {
                    MessageBox.Show("Tên hoặc Email không được bỏ trống.");
                }
                else if (db.kiemtra("select Email from NGUOIHOC where Email='" + txtemail.Texts + "' except select Email from NGUOIHOC where MaNH='" + NGUOIHOC.id + "'"))
                {
                    MessageBox.Show("Email đã tồn tại.");
                }
                else
                {
                    db.ExecuteNonQuery("update NGUOIHOC set Name=N'" + txtname.Texts + "',Email='" + txtemail.Texts + "' where MaNH='" + NGUOIHOC.id + "'");
                    lbname.Text = txtname.Texts;
                    lbemail.Text = txtemail.Texts;
                    Nguoidungfrom.ndf.ten.Text = lbname.Text; //update name
                    MessageBox.Show("Cập nhật thành công.");
                    txtname.Hide();
                    txtemail.Hide();
                    clickstat = false;
                    butdoiinfo.Text = "Thay đổi thông tin";
                    buthuy.Hide();
                    GC.Collect();
                }
            }            
        }

        private void buthuy_Click(object sender, EventArgs e)
        {
            clickstat = false;
            txtname.Hide();
            txtemail.Hide();
            butdoiinfo.Text = "Thay đổi thông tin";
            buthuy.Hide();
        }

        private void buttrove_Click(object sender, EventArgs e)
        {
            Nguoidungfrom.ndf.picInfo.Enabled = true;
            GC.Collect();
            this.Close();
        }

        private void lbDoiMk_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();
        }
    }
}
