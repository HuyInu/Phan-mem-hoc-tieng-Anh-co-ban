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
    public partial class Nhapbaihoc : Form
    {
        public Nhapbaihoc()
        {
            InitializeComponent();
        }
        bool clickTV, clickNP;
        //int demTV,demNP;
        Database db;
        Hieuung hu = new Hieuung();
        string MaBH;
        string MaLOAI;
        
        private void Nhapbaihoc_Load(object sender, EventArgs e)
        {
            db = new Database("QLAV");

            db.datatintocombox(commaBH, "select MaBH,TenBH from BAIHOC", "MaBH", "TenBH");
            db.datatintocombox(comloaiTV, "select MaLOAI,Tenloai from LOAITV", "Tenloai", "MaLOAI");

            MaLOAI = comloaiTV.SelectedValue.ToString();
            

            //txttenBH.Texts = commaBH.SelectedValue.ToString();

            disablebutton(butcapnhat, butthem, butxoa);

            /* add bai hoc */
            pneladdBH.Visible = false;
            db.xuatdata("select * from BAIHOC", dtaddBH);
            disablebutton(butaddsua, butaddthem, butaddxoa);
            labaddBH.Text = "Sl bài học: " + (dtaddBH.Rows.Count - 1).ToString();
        }
        /* Hàm tái sử dụng */
        public void cleartexboxTV()
        {
            txtmaTV.Texts = "";
            commaBH.Text = "";
            txtAN.Texts= "";
            txtV.Texts = "";
            txtpam.Texts = "";
        }
        public void cleartextboxNP()
        {
            txtmaNP.Texts = "";
            txtnoidung.Texts = "";
            txtchuthich.Texts = "";
        }
        public void doimaudisable(Button capnhat, Button them, Button xoa)
        {
            hu.doimaubutton(194, 194, 194, capnhat);
            hu.doimaubutton(194, 194, 194, them);
            hu.doimaubutton(194, 194, 194, xoa);
        }
        public void doimauenable(Button capnhat, Button them, Button xoa)
        {
            hu.doimaubutton(204, 228, 255, capnhat);
            hu.doimaubutton(204, 228, 255, them);
            hu.doimaubutton(255, 166, 174, xoa);
        }
        public void disablebutton(Button capnhat, Button them, Button xoa)
        {
            doimaudisable(capnhat, them, xoa);
            capnhat.Enabled = false;
            them.Enabled = false;
            xoa.Enabled = false;
        }

        public void enablebutton(Button capnhat, Button them, Button xoa)
        {
            doimauenable(capnhat, them, xoa);
            capnhat.Enabled = true;
            them.Enabled = true;
            xoa.Enabled = true;
        }
        /*------------------------------------------------------------------------*/
        private void butthemTV_Click(object sender, EventArgs e)
        {
            clickTV = true;
            clickNP = false;
            pnelTV.Enabled = true;
            pnelNP.Enabled = false;
        }
        private void butthemNP_Click_1(object sender, EventArgs e)
        {
            clickTV = false;
            clickNP = true;
            pnelNP.Enabled = true;
            pnelTV.Enabled = false;
        }
        /*load dl len textbox*/
        private void dtTV_SelectionChanged(object sender, EventArgs e)
        {
            try { 
            string maloai;
            int i= dtTV.CurrentRow.Index;

                txtmaTV.Texts = dtTV.Rows[i].Cells[0].Value.ToString();
                maloai = dtTV.Rows[i].Cells[2].Value.ToString();
                comloaiTV.Text = db.dem("select Tenloai from LOAITV where MaLOAI='" + maloai + "'");
                txtAN.Texts = dtTV.Rows[i].Cells[3].Value.ToString();
                txtV.Texts = dtTV.Rows[i].Cells[4].Value.ToString();
                txtpam.Texts= dtTV.Rows[i].Cells[5].Value.ToString();
            }
            catch { db.huyketnoi(); }
            
        }
        private void dtNP_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i = dtNP.CurrentRow.Index;
                txtmaNP.Texts = dtNP.Rows[i].Cells[0].Value.ToString();
                txtnoidung.Texts = dtNP.Rows[i].Cells[2].Value.ToString();
                txtchuthich.Texts = dtNP.Rows[i].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        /*------------------------------------------------------------------------*/
        /* Even combobox */
        private void commaBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenbh = commaBH.SelectedValue.ToString();
            txttenBH.Texts = tenbh;
            MaBH = commaBH.Text;

            DataTable dt = db.Execute("select * from TUVUNG where MaBH='" + MaBH + "'");
            dtTV.DataSource = dt;
            db.xuatdata("select * from TUVUNG where MaBH='" + MaBH + "'", dtTV);
            labslTV.Text = "SL: " + (dtTV.Rows.Count - 1).ToString();
            cleartexboxTV();
            db.xuatdata("select * from NGUPHAP where MaBH='" + MaBH + "'", dtNP);
            labslNP.Text = "SL: " + (dtNP.Rows.Count - 1).ToString();
            cleartextboxNP();
        }
        private void comloaiTV_SelectedIndexChanged(object sender, EventArgs e)
        {

            MaLOAI = comloaiTV.SelectedValue.ToString();
        }
        /*------------------------------------------------------------------------*/
        /* thêm sửa xóa */
        public string getma()
        {
            string ma = "";
            string rong = "0";
            string rong1 = " ";
            string mabh = MaBH;
            for (int i = 0; i < mabh.Length; i++)
            {
                if (mabh[i] != rong[0])
                {
                    mabh = mabh.Substring(i);
                    break;
                }
            }
            for (int j = 0; j < mabh.Length; j++)
            {
                if (mabh[j] == rong1[0])
                {
                    mabh = mabh.Substring(0, j);
                    break;
                }
            }
            int dem;
            string B = "B";
            string tam = "";
            string last = "";
            DataTable dt;
            if (clickTV)
            {
                dt = db.Execute("select top 1 MaTV from TUVUNG where MaBH='" + MaBH + "' order by MaTV desc ");
                if (dt.Rows.Count == 0)
                {
                    dem = 0;
                }
                else
                {
                    last = dt.Rows[0][0].ToString();
                    for (int i = last.Length - 1; i >= 0; i--)
                    {
                        if (last[i] == B[0])
                        {
                            tam = last.Substring(i + 2);
                        }
                    }
                    dem = int.Parse(tam);
                }             
               ma = mabh + "BV" + (dem + 1).ToString("0000");                    
            }
                if (clickNP)
                {
                
                    dt = db.Execute("select top 1 MaNP from NGUPHAP where MaBH='" + MaBH + "' order by MaNP desc ");
                    if (dt.Rows.Count == 0)
                    {
                        dem = 0;
                    }
                    else
                    {
                        last = dt.Rows[0][0].ToString();

                        for (int i = last.Length - 1; i >= 0; i--)
                        {
                            if (last[i] == B[0])
                            {
                                tam = last.Substring(i + 2);
                            }
                        }
                        dem = int.Parse(tam);
                    }
                    ma = mabh + "BP" + (dem + 1).ToString("0000");                   
                }
            return ma;
        }
        private void butthem_Click(object sender, EventArgs e)
        {
            
            if (clickTV)
            {
                string matv = getma();
                
                if (txtAN.Texts == "" || txtV.Texts == ""||txtpam.Texts=="")
                {
                    MessageBox.Show("Dữ liệu không được bỏ trống.");
                }
                else if (db.kiemtra("select * from TUVUNG where Angu='" + txtAN.Texts + "'"))
                {
                    MessageBox.Show("Từ này đã có trong bài học khác.");
                }
                else
                {
                        string insert = "insert into TUVUNG values('" + matv + "','" + MaBH + "','"+MaLOAI+"','" + txtAN.Texts + "',N'" + txtV.Texts + "',N'"+txtpam.Texts+"')";
                        db.ExecuteNonQuery(insert);
                        db.xuatdata("select * from TUVUNG where MaBH='" + MaBH + "'", dtTV);
                        labslTV.Text = "SL: " + (dtTV.Rows.Count - 1).ToString();
                        cleartexboxTV();
                        disablebutton(butcapnhat, butthem, butxoa);
                   
                }
            }
            if (clickNP)
            {
                string manp = getma();
                if (txtnoidung.Texts == "" || txtchuthich.Texts == "")
                {
                    MessageBox.Show("Dữ liệu không được bỏ trống.");
                }
                else
                {
                    try
                    {
                        string insert = "insert into NGUPHAP values ('" + manp + "','" + MaBH + "',N'" + txtnoidung.Texts + "',N'" + txtchuthich.Texts + "')";
                        db.ExecuteNonQuery(insert);
                        db.xuatdata("select * from NGUPHAP where MaBH='" + MaBH + "'", dtNP);
                        labslNP.Text = "SL: " + (dtNP.Rows.Count - 1).ToString();
                        cleartextboxNP();
                        disablebutton(butcapnhat, butthem, butxoa);
                    }
                    catch
                    {
                        db.huyketnoi();
                    }
                }
            }
        }

        private void butcapnhat_Click(object sender, EventArgs e)
        {
            if (clickTV)
            {
                try
                {
                    if (txtAN.Texts == "" || txtV.Texts == "")
                    {
                        MessageBox.Show("Dữ liệu không được bỏ trống.");
                    }
                    else
                        if (db.kiemtra("select * from TUVUNG where Angu='"+txtAN.Texts+"' Except select * from TUVUNG where MaTV='"+txtmaTV.Texts+"'"))
                    {
                        MessageBox.Show("Từ này đã có trong bài học khác.");
                    }
                    else
                    {
                        string sua = "update TUVUNG set MaLOAI='" + MaLOAI + "',Angu='" + txtAN.Texts + "',Vngu=N'" + txtV.Texts + "',Phienam=N'"+txtpam.Texts+"' where MaTV='" + txtmaTV.Texts + "'";
                        db.ExecuteNonQuery(sua);
                        db.xuatdata("select * from TUVUNG where MaBH='" + MaBH + "'", dtTV);
                        cleartexboxTV();
                        disablebutton(butcapnhat, butthem, butxoa);
                    }
                }
                catch
                {
                    db.huyketnoi();
                }
            }
            if (clickNP)
            {
                try
                {
                    string sua = "update NGUPHAP set Noidung=N'" + txtnoidung.Texts + "',Chuthich=N'" + txtchuthich.Texts + "' where MaNP='" + txtmaNP.Texts + "'";
                    db.ExecuteNonQuery(sua);
                    db.xuatdata("select * from NGUPHAP where MaBH='" + MaBH + "'", dtNP);
                    cleartextboxNP();
                    disablebutton(butcapnhat, butthem, butxoa);
                }
                catch
                {
                    db.huyketnoi();
                }
            }
        }
        private void butxoa_Click(object sender, EventArgs e)
        {
            if (clickTV)
            {
                try
                {
                    string xoa = "delete from TUVUNG where MaTV='" + txtmaTV.Texts + "'";
                    db.ExecuteNonQuery(xoa);
                    db.xuatdata("select * from TUVUNG where MaBH='" + MaBH + "'", dtTV);
                    labslTV.Text = "SL: " + (dtTV.Rows.Count - 1).ToString();
                    cleartextboxNP();
                    disablebutton(butcapnhat, butthem, butxoa);
                }
                catch
                {
                    db.huyketnoi();
                }
            }
            if (clickNP)
            {
                try
                {
                    string xoa = "delete from NGUPHAP where MaNP='" + txtmaNP.Texts + "'";
                    db.ExecuteNonQuery(xoa);
                    db.xuatdata("select * from NGUPHAP where MaBH='" + MaBH + "'", dtNP);
                    labslNP.Text = "SL: " + (dtNP.Rows.Count - 1).ToString();
                    cleartextboxNP();
                    disablebutton(butcapnhat, butthem, butxoa);
                }
                catch
                {
                    db.huyketnoi();
                }
            }
        }
        /*------------------------------------------------------------------------*/
        /* Thao tac - Huy */
        private void butthaotac_Click(object sender, EventArgs e)
        {
            enablebutton(butcapnhat, butthem, butxoa);
        }
        private void buthuy_Click(object sender, EventArgs e)
        {
            disablebutton(butcapnhat, butthem, butxoa);
        }



        /*------------------------------------------------------------------------*/
        /*                  Add bài học             */
        private void butthemBH_Click_1(object sender, EventArgs e)
        {
            pneladdBH.Visible = true;
        }
        private void butaddclose_Click(object sender, EventArgs e)
        {
            pneladdBH.Visible = false;
            GC.Collect();
        }
        private void butaddthaotac_Click(object sender, EventArgs e)
        {
            enablebutton(butaddsua, butaddthem, butaddxoa);
        }
        private void butaddhuy_Click(object sender, EventArgs e)
        {
            disablebutton(butaddsua, butaddthem, butaddxoa);
        }

        private void dtaddBH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i = dtaddBH.CurrentRow.Index;
                txtaddmaBH.Text= dtaddBH.Rows[i].Cells[0].Value.ToString();
                txtaddtenBH.Text = dtaddBH.Rows[i].Cells[1].Value.ToString();
                
            }
            catch
            {

            }
        }
        private void butaddthem_Click(object sender, EventArgs e)
        {
            int dem;
            DataTable dt = db.Execute("select top 1 MaBH from BAIHOC order by MaBH desc");
            if(dt.Rows.Count==0)
            {
                dem = 0;
            }
            else
                dem = int.Parse(dt.Rows[0][0].ToString());
            if (txtaddtenBH.Text == "")
            {
                MessageBox.Show("Thông tin không được bỏ trống.");
            }
            else
            {
                if (db.kiemtra("select TenBH from BAIHOC where TenBH='" + txtaddtenBH.Text + "'"))
                {
                    MessageBox.Show("Bài học này đã có");
                }
                else
                {
                    
                        string sql = "insert into BAIHOC values('" + (dem + 1).ToString("0000") + "',N'" + txtaddtenBH.Text + "')";
                        db.ExecuteNonQuery(sql);
                        db.xuatdata("select * from BAIHOC", dtaddBH);
                        labaddBH.Text = "Sl bài học: " + (dtaddBH.Rows.Count - 1).ToString();
                        txtaddtenBH.Text = "";
                        txtaddmaBH.Text = "";
                        disablebutton(butaddsua, butaddthem, butaddxoa);
                        db.datatintocombox(commaBH, "select MaBH,TenBH from BAIHOC", "MaBH", "TenBH");
                        GC.Collect();
                    
                }
            }
        }
        private void butaddsua_Click(object sender, EventArgs e)
        {
            string sql = "update BAIHOC set TenBH=N'" + txtaddtenBH.Text + "' where MaBH='"+txtaddmaBH.Text+"'";
            if (txtaddtenBH.Text == "")
            {
                MessageBox.Show("Thông tin không được bỏ trống.");
            }
            else
            {
                if (db.kiemtra("select TenBH from BAIHOC where TenBH='" +txtaddtenBH.Text + "'"))
                {
                    MessageBox.Show("Bài học này đã có");
                }
                else
                {
                    try
                    {
                        db.ExecuteNonQuery(sql);
                        db.xuatdata("select * from BAIHOC ", dtaddBH);
                        txtaddtenBH.Text = "";
                        txtaddmaBH.Text = "";
                        disablebutton(butaddsua, butaddthem, butaddxoa);
                        db.datatintocombox(commaBH, "select MaBH,TenBH from BAIHOC", "MaBH", "TenBH");
                        GC.Collect();
                    }
                    catch
                    {
                        db.huyketnoi();
                    }
                }
            }
        }


        private void butaddxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string xoa = "delete from BAIHOC where MaBH='" + txtaddmaBH.Text + "'";
                db.ExecuteNonQuery(xoa);
                db.xuatdata("select * from BAIHOC ", dtaddBH);
                labaddBH.Text = "Sl bài học: " + (dtaddBH.Rows.Count - 1).ToString();
                txtaddtenBH.Text = "";
                txtaddmaBH.Text = "";
                disablebutton(butaddsua, butaddthem, butaddxoa);
                db.datatintocombox(commaBH, "select MaBH,TenBH from BAIHOC", "MaBH", "TenBH");
                GC.Collect();
            }
            catch { }
        }
    }
}
