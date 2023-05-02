namespace Đồ_án
{
    partial class ThuThach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuThach));
            this.pnTop = new System.Windows.Forms.FlowLayoutPanel();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.pnKhen = new System.Windows.Forms.Panel();
            this.lbKhen = new System.Windows.Forms.Label();
            this.pnbut = new System.Windows.Forms.Panel();
            this.choDoi = new System.Windows.Forms.Timer(this.components);
            this.EpnA = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.EpnTop = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.waitKhenThuong = new System.Windows.Forms.Timer(this.components);
            this.NoiChu = new System.Windows.Forms.Panel();
            this.ChonHinh = new System.Windows.Forms.Panel();
            this.pickC = new Đồ_án.CustomButton();
            this.pic = new System.Windows.Forms.PictureBox();
            this.pickB = new Đồ_án.CustomButton();
            this.pickA = new Đồ_án.CustomButton();
            this.lbTienDo = new System.Windows.Forms.Label();
            this.speaker = new System.Windows.Forms.PictureBox();
            this.speakerTA = new System.Windows.Forms.PictureBox();
            this.pnAser = new System.Windows.Forms.Panel();
            this.butNext = new Đồ_án.CustomButton();
            this.lbDapAn = new System.Windows.Forms.Label();
            this.lbAser = new System.Windows.Forms.Label();
            this.buthoanthanh = new Đồ_án.CustomButton();
            this.buttrove = new Đồ_án.CustomButton();
            this.pnKhen.SuspendLayout();
            this.NoiChu.SuspendLayout();
            this.ChonHinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakerTA)).BeginInit();
            this.pnAser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.White;
            this.pnTop.Location = new System.Drawing.Point(98, 35);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(455, 116);
            this.pnTop.TabIndex = 4;
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbCauHoi.Location = new System.Drawing.Point(184, 70);
            this.lbCauHoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(74, 26);
            this.lbCauHoi.TabIndex = 83;
            this.lbCauHoi.Text = "Cau hoi";
            // 
            // pnKhen
            // 
            this.pnKhen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.pnKhen.Controls.Add(this.lbKhen);
            this.pnKhen.Location = new System.Drawing.Point(60, 112);
            this.pnKhen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnKhen.Name = "pnKhen";
            this.pnKhen.Size = new System.Drawing.Size(628, 176);
            this.pnKhen.TabIndex = 84;
            this.pnKhen.Visible = false;
            // 
            // lbKhen
            // 
            this.lbKhen.AutoSize = true;
            this.lbKhen.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbKhen.Location = new System.Drawing.Point(265, 74);
            this.lbKhen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKhen.Name = "lbKhen";
            this.lbKhen.Size = new System.Drawing.Size(98, 26);
            this.lbKhen.TabIndex = 74;
            this.lbKhen.Text = "Chính xác!";
            // 
            // pnbut
            // 
            this.pnbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnbut.Location = new System.Drawing.Point(28, 169);
            this.pnbut.Name = "pnbut";
            this.pnbut.Size = new System.Drawing.Size(606, 109);
            this.pnbut.TabIndex = 85;
            // 
            // choDoi
            // 
            this.choDoi.Interval = 700;
            this.choDoi.Tick += new System.EventHandler(this.choDoi_Tick);
            // 
            // EpnA
            // 
            this.EpnA.BorderRadius = 25;
            this.EpnA.TargetControl = this.pnKhen;
            // 
            // EpnTop
            // 
            this.EpnTop.BorderRadius = 25;
            this.EpnTop.TargetControl = this.pnTop;
            // 
            // waitKhenThuong
            // 
            this.waitKhenThuong.Interval = 2000;
            this.waitKhenThuong.Tick += new System.EventHandler(this.waitKhenThuong_Tick);
            // 
            // NoiChu
            // 
            this.NoiChu.Controls.Add(this.pnTop);
            this.NoiChu.Controls.Add(this.pnbut);
            this.NoiChu.Location = new System.Drawing.Point(40, 121);
            this.NoiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoiChu.Name = "NoiChu";
            this.NoiChu.Size = new System.Drawing.Size(671, 291);
            this.NoiChu.TabIndex = 87;
            // 
            // ChonHinh
            // 
            this.ChonHinh.Controls.Add(this.pickC);
            this.ChonHinh.Controls.Add(this.pic);
            this.ChonHinh.Controls.Add(this.pickB);
            this.ChonHinh.Controls.Add(this.pickA);
            this.ChonHinh.Location = new System.Drawing.Point(109, 110);
            this.ChonHinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChonHinh.Name = "ChonHinh";
            this.ChonHinh.Size = new System.Drawing.Size(542, 261);
            this.ChonHinh.TabIndex = 88;
            // 
            // pickC
            // 
            this.pickC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickC.AutoSize = true;
            this.pickC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.pickC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.pickC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pickC.BorderRadius = 0;
            this.pickC.BorderSize = 3;
            this.pickC.FlatAppearance.BorderSize = 0;
            this.pickC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pickC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.pickC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickC.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pickC.Location = new System.Drawing.Point(270, 153);
            this.pickC.Name = "pickC";
            this.pickC.Size = new System.Drawing.Size(204, 37);
            this.pickC.TabIndex = 89;
            this.pickC.Text = "Chọn";
            this.pickC.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pickC.UseVisualStyleBackColor = false;
            this.pickC.Click += new System.EventHandler(this.pickC_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(58, 10);
            this.pic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(146, 180);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // pickB
            // 
            this.pickB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickB.AutoSize = true;
            this.pickB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.pickB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.pickB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pickB.BorderRadius = 0;
            this.pickB.BorderSize = 3;
            this.pickB.FlatAppearance.BorderSize = 0;
            this.pickB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pickB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.pickB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickB.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pickB.Location = new System.Drawing.Point(270, 83);
            this.pickB.Name = "pickB";
            this.pickB.Size = new System.Drawing.Size(204, 37);
            this.pickB.TabIndex = 89;
            this.pickB.Text = "Chọn";
            this.pickB.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pickB.UseVisualStyleBackColor = false;
            this.pickB.Click += new System.EventHandler(this.pinkB_Click);
            // 
            // pickA
            // 
            this.pickA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickA.AutoSize = true;
            this.pickA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.pickA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.pickA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pickA.BorderRadius = 0;
            this.pickA.BorderSize = 3;
            this.pickA.FlatAppearance.BorderSize = 0;
            this.pickA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pickA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.pickA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickA.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pickA.Location = new System.Drawing.Point(270, 14);
            this.pickA.Name = "pickA";
            this.pickA.Size = new System.Drawing.Size(204, 37);
            this.pickA.TabIndex = 89;
            this.pickA.Text = "Chọn";
            this.pickA.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pickA.UseVisualStyleBackColor = false;
            this.pickA.Click += new System.EventHandler(this.pickA_Click);
            // 
            // lbTienDo
            // 
            this.lbTienDo.AutoSize = true;
            this.lbTienDo.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbTienDo.Location = new System.Drawing.Point(626, 41);
            this.lbTienDo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTienDo.Name = "lbTienDo";
            this.lbTienDo.Size = new System.Drawing.Size(70, 26);
            this.lbTienDo.TabIndex = 86;
            this.lbTienDo.Text = "Tiendo";
            // 
            // speaker
            // 
            this.speaker.Image = ((System.Drawing.Image)(resources.GetObject("speaker.Image")));
            this.speaker.Location = new System.Drawing.Point(449, 58);
            this.speaker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speaker.Name = "speaker";
            this.speaker.Size = new System.Drawing.Size(90, 92);
            this.speaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.speaker.TabIndex = 89;
            this.speaker.TabStop = false;
            this.speaker.Visible = false;
            this.speaker.Click += new System.EventHandler(this.speaker_Click);
            // 
            // speakerTA
            // 
            this.speakerTA.Image = ((System.Drawing.Image)(resources.GetObject("speakerTA.Image")));
            this.speakerTA.Location = new System.Drawing.Point(145, 64);
            this.speakerTA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speakerTA.Name = "speakerTA";
            this.speakerTA.Size = new System.Drawing.Size(34, 32);
            this.speakerTA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.speakerTA.TabIndex = 90;
            this.speakerTA.TabStop = false;
            this.speakerTA.Visible = false;
            this.speakerTA.Click += new System.EventHandler(this.speakerTA_Click);
            // 
            // pnAser
            // 
            this.pnAser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnAser.Controls.Add(this.butNext);
            this.pnAser.Controls.Add(this.lbDapAn);
            this.pnAser.Controls.Add(this.lbAser);
            this.pnAser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnAser.Location = new System.Drawing.Point(0, 425);
            this.pnAser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnAser.Name = "pnAser";
            this.pnAser.Size = new System.Drawing.Size(758, 124);
            this.pnAser.TabIndex = 85;
            this.pnAser.Visible = false;
            // 
            // butNext
            // 
            this.butNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.butNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.butNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.butNext.BorderRadius = 15;
            this.butNext.BorderSize = 2;
            this.butNext.FlatAppearance.BorderSize = 0;
            this.butNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.butNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.butNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNext.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.butNext.Location = new System.Drawing.Point(604, 23);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(109, 37);
            this.butNext.TabIndex = 84;
            this.butNext.Text = "Tiếp tục";
            this.butNext.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.butNext.UseVisualStyleBackColor = false;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // lbDapAn
            // 
            this.lbDapAn.AutoSize = true;
            this.lbDapAn.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDapAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbDapAn.Location = new System.Drawing.Point(34, 60);
            this.lbDapAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDapAn.Name = "lbDapAn";
            this.lbDapAn.Size = new System.Drawing.Size(83, 22);
            this.lbDapAn.TabIndex = 83;
            this.lbDapAn.Text = "Chính xác!";
            this.lbDapAn.Visible = false;
            // 
            // lbAser
            // 
            this.lbAser.AutoSize = true;
            this.lbAser.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbAser.Location = new System.Drawing.Point(32, 23);
            this.lbAser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAser.Name = "lbAser";
            this.lbAser.Size = new System.Drawing.Size(98, 26);
            this.lbAser.TabIndex = 74;
            this.lbAser.Text = "Chính xác!";
            // 
            // buthoanthanh
            // 
            this.buthoanthanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.buthoanthanh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.buthoanthanh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.buthoanthanh.BorderRadius = 15;
            this.buthoanthanh.BorderSize = 2;
            this.buthoanthanh.FlatAppearance.BorderSize = 0;
            this.buthoanthanh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.buthoanthanh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.buthoanthanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buthoanthanh.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buthoanthanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buthoanthanh.Location = new System.Drawing.Point(604, 448);
            this.buthoanthanh.Name = "buthoanthanh";
            this.buthoanthanh.Size = new System.Drawing.Size(109, 37);
            this.buthoanthanh.TabIndex = 82;
            this.buthoanthanh.Text = "Kiểm tra";
            this.buthoanthanh.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buthoanthanh.UseVisualStyleBackColor = false;
            this.buthoanthanh.Click += new System.EventHandler(this.buthoanthanh_Click);
            // 
            // buttrove
            // 
            this.buttrove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.buttrove.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.buttrove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.buttrove.BorderRadius = 15;
            this.buttrove.BorderSize = 2;
            this.buttrove.FlatAppearance.BorderSize = 0;
            this.buttrove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.buttrove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.buttrove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttrove.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttrove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buttrove.Location = new System.Drawing.Point(10, 11);
            this.buttrove.Name = "buttrove";
            this.buttrove.Size = new System.Drawing.Size(27, 37);
            this.buttrove.TabIndex = 91;
            this.buttrove.Text = "<";
            this.buttrove.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buttrove.UseVisualStyleBackColor = false;
            this.buttrove.Click += new System.EventHandler(this.buttrove_Click);
            // 
            // ThuThach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(758, 549);
            this.Controls.Add(this.buttrove);
            this.Controls.Add(this.buthoanthanh);
            this.Controls.Add(this.pnAser);
            this.Controls.Add(this.pnKhen);
            this.Controls.Add(this.ChonHinh);
            this.Controls.Add(this.speakerTA);
            this.Controls.Add(this.speaker);
            this.Controls.Add(this.NoiChu);
            this.Controls.Add(this.lbTienDo);
            this.Controls.Add(this.lbCauHoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThuThach";
            this.Text = "ThuThach";
            this.Load += new System.EventHandler(this.ThuThach_Load);
            this.pnKhen.ResumeLayout(false);
            this.pnKhen.PerformLayout();
            this.NoiChu.ResumeLayout(false);
            this.ChonHinh.ResumeLayout(false);
            this.ChonHinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakerTA)).EndInit();
            this.pnAser.ResumeLayout(false);
            this.pnAser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnTop;
        private CustomButton buthoanthanh;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.Panel pnKhen;
        private System.Windows.Forms.Label lbKhen;
        private System.Windows.Forms.Panel pnbut;
        private System.Windows.Forms.Timer choDoi;
        private Guna.UI2.WinForms.Guna2Elipse EpnA;
        private Guna.UI2.WinForms.Guna2Elipse EpnTop;
        private System.Windows.Forms.Timer waitKhenThuong;
        private System.Windows.Forms.Panel NoiChu;
        private System.Windows.Forms.Panel ChonHinh;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label lbTienDo;
        private CustomButton pickA;
        private CustomButton pickC;
        private CustomButton pickB;
        private System.Windows.Forms.PictureBox speaker;
        private System.Windows.Forms.PictureBox speakerTA;
        private System.Windows.Forms.Panel pnAser;
        private System.Windows.Forms.Label lbAser;
        private CustomButton butNext;
        private System.Windows.Forms.Label lbDapAn;
        private CustomButton buttrove;
    }
}