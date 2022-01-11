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
    public partial class NhapBTNP : Form
    {
        public static NhapBTNP btnp;
        public ComboBox bx;
        public NhapBTNP()
        {
            InitializeComponent();
            btnp = this;
            bx = comBH;
        }
        Database db;
        private void NhapBTNP_Load(object sender, EventArgs e)
        {
            db = new Database("QLAV");

            DataTable dt = db.Execute("select MaBH,TenBH from BAIHOC");
            comBH.DataSource = dt;
            comBH.DisplayMember = "MaBH";
            comBH.ValueMember = "TenBH";

            lbtenBH.Text = "Tên bài học.";
        }
        private void comNP_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbtenBH.Text = comBH.SelectedValue.ToString();
            xuatdatag();
            cleartextbox();
        }

        /*-----------Hàm tái sử dụng-----------*/
        public void cleartextbox()
        {
            txtmaBT.Texts = "";
            txtnoidung.Text = "";
            txtA.Texts = "";
            txtB.Texts = "";
            txtC.Texts = "";
            A.Checked = false;
            B.Checked = false;
            C.Checked = false;
        }
        public string getma()
        {
            string mabt;
            DataTable dt = db.Execute("select top 1 MaBTNP from BAITAPNP order by MaBTNP desc");
            if (dt.Rows.Count == 0)
                return "00001";
            else
            {
                mabt = (int.Parse(dt.Rows[0][0].ToString()) + 1).ToString("00000");
                return mabt;
            }           
        }
        public void xuatdatag()
        {
            db.xuatdata("select MaBTNP as 'Mã câu hỏi', Cauhoi as 'Câu hỏi',A,B,C,Dapan as 'Dấp án' from BAITAPNP where MaBH='" + comBH.Text + "'", dtgCH);
        }
        public string DA()
        {
            if (A.Checked)
                return "A";
            if (B.Checked)
                return "B";
            if (C.Checked)
                return "C";
            return "D";
        }
        /*-----------Load du data len textbox-----------*/
        private void dtgCH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i = dtgCH.CurrentRow.Index;
                txtmaBT.Texts = dtgCH.Rows[i].Cells[0].Value.ToString();
                txtnoidung.Text = dtgCH.Rows[i].Cells[1].Value.ToString();
                txtA.Texts= dtgCH.Rows[i].Cells[2].Value.ToString();
                txtB.Texts = dtgCH.Rows[i].Cells[3].Value.ToString();
                txtC.Texts = dtgCH.Rows[i].Cells[4].Value.ToString();
                if (dtgCH.Rows[i].Cells[5].Value.ToString() == "A")
                    A.Checked = true;
                else if (dtgCH.Rows[i].Cells[5].Value.ToString() == "B")
                    B.Checked = true;
                else
                    C.Checked = true;              
            }
            catch { }
        }
        /*-----------Thêm sửa xóa-----------*/
        private void butthem_Click(object sender, EventArgs e)
        {
            try
            {
                string dapan = DA();
                if (txtnoidung.Text == "" || txtA.Texts == "" || txtB.Texts == "" || txtC.Texts == "" || dapan == "D")
                {
                    MessageBox.Show("Dữ liệu không được để trống. ");
                }
                else if (db.kiemtra("select MaBTNP as 'Mã câu hỏi', Cauhoi as 'Câu hỏi',A,B,C,Dapan as 'Dấp án' from BAITAPNP where MaBH='" + comBH.Text + "' and Cauhoi='" + txtnoidung.Text + "' and A='" + txtA.Texts + "' and B='" + txtB.Texts + "' and C='" + txtC.Texts + "' and Dapan='" + dapan + "'"))
                    MessageBox.Show("Dữ liệu đã có trong CSDL.");

                else
                {
                    db.ExecuteNonQuery("insert into BAITAPNP values('" + getma() + "','" + comBH.Text + "',N'" + txtnoidung.Text + "',N'" + txtA.Texts + "',N'" + txtB.Texts + "',N'" + txtC.Texts + "',N'" + dapan + "')");
                    xuatdatag();              
                    cleartextbox();
                }
            }
            catch { MessageBox.Show("Thêm thất bại.");
                db.huyketnoi();
            }

            try { db.ExecuteNonQuery("update HOC set FNP='" + 0 + "' where MaBH='" + comBH.Text + "'"); }
            catch { }

        }

        private void butcapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                string dapan = DA();
                if (txtnoidung.Text == "" || txtA.Texts == "" || txtB.Texts == "" || txtC.Texts == "" || dapan == "D")
                {
                    MessageBox.Show("Dữ liệu không được để trống. ");
                }
                else if (db.kiemtra("select MaBTNP as 'Mã câu hỏi', Cauhoi as 'Câu hỏi',A,B,C,Dapan as 'Dấp án' from BAITAPNP where MaBH='" + comBH.Text + "' and Cauhoi='" + txtnoidung.Text + "' and A='" + txtA.Texts + "' and B='" + txtB.Texts + "' and C='" + txtC.Texts + "' and Dapan='" + dapan + "'"))
                    MessageBox.Show("Dữ liệu đã có trong CSDL.");

                else
                {
                    db.ExecuteNonQuery("update BAITAPNP set Cauhoi='" + txtnoidung.Text + "',A='" + txtA.Texts + "',B='" + txtB.Texts + "',C='" + txtC.Texts + "',Dapan='" + dapan + "' where MaBTNP='" + txtmaBT.Texts + "'");
                    xuatdatag();
                    cleartextbox();
                }
            }
            catch { MessageBox.Show("Sửa thất bại.");
                db.huyketnoi();
            }
        }
        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dl == DialogResult.Yes)
            {
                try
                {
                    db.ExecuteNonQuery("delete from BAITAPNP where MaBTNP='" + txtmaBT.Texts + "'");
                    xuatdatag();                  
                    cleartextbox();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại.");
                    db.huyketnoi();
                }
            }
            try { db.ExecuteNonQuery("update HOC set DungNP=0,SaiNP=0,TiendoNP=0,FNP=0 where MaBH='" + comBH.Text + "'"); }
            catch { }
        }

        private void NhapBTNP_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }
    }
}
