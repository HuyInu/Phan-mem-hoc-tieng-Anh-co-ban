namespace Đồ_án
{
    partial class formcanhan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formcanhan));
            this.avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbtongdung = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbsai = new System.Windows.Forms.Label();
            this.lbdung = new System.Windows.Forms.Label();
            this.lbsumhoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combaihoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbsai1 = new System.Windows.Forms.Label();
            this.lbdung1 = new System.Windows.Forms.Label();
            this.lbsunhoc1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picava = new System.Windows.Forms.PictureBox();
            this.lbname = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.elipleft = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.right = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.buttrove = new Đồ_án.CustomButton();
            this.buthuy = new Đồ_án.CustomButton();
            this.txtemail = new Đồ_án.RoundTextbox();
            this.txtname = new Đồ_án.RoundTextbox();
            this.butdoiinfo = new Đồ_án.CustomButton();
            this.lbDoiMk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.lbtongdung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picava)).BeginInit();
            this.SuspendLayout();
            // 
            // avatar
            // 
            this.avatar.ImageRotate = 0F;
            this.avatar.Location = new System.Drawing.Point(97, 37);
            this.avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatar.Name = "avatar";
            this.avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.avatar.ShadowDecoration.Parent = this.avatar;
            this.avatar.Size = new System.Drawing.Size(232, 217);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 2;
            this.avatar.TabStop = false;
            // 
            // lbtongdung
            // 
            this.lbtongdung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lbtongdung.Controls.Add(this.chart1);
            this.lbtongdung.Controls.Add(this.lbsai);
            this.lbtongdung.Controls.Add(this.lbdung);
            this.lbtongdung.Controls.Add(this.lbsumhoc);
            this.lbtongdung.Location = new System.Drawing.Point(32, 307);
            this.lbtongdung.Name = "lbtongdung";
            this.lbtongdung.Size = new System.Drawing.Size(469, 346);
            this.lbtongdung.TabIndex = 28;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(105, 153);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            series1.Legend = "Legend1";
            series1.Name = "Salary";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(259, 218);
            this.chart1.TabIndex = 53;
            this.chart1.Text = "chart1";
            // 
            // lbsai
            // 
            this.lbsai.AutoSize = true;
            this.lbsai.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lbsai.Location = new System.Drawing.Point(31, 125);
            this.lbsai.Name = "lbsai";
            this.lbsai.Size = new System.Drawing.Size(151, 28);
            this.lbsai.TabIndex = 52;
            this.lbsai.Text = "Chưa có dữ liệu.";
            // 
            // lbdung
            // 
            this.lbdung.AutoSize = true;
            this.lbdung.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.lbdung.Location = new System.Drawing.Point(31, 86);
            this.lbdung.Name = "lbdung";
            this.lbdung.Size = new System.Drawing.Size(151, 28);
            this.lbdung.TabIndex = 51;
            this.lbdung.Text = "Chưa có dữ liệu.";
            // 
            // lbsumhoc
            // 
            this.lbsumhoc.AutoSize = true;
            this.lbsumhoc.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsumhoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbsumhoc.Location = new System.Drawing.Point(31, 47);
            this.lbsumhoc.Name = "lbsumhoc";
            this.lbsumhoc.Size = new System.Drawing.Size(151, 28);
            this.lbsumhoc.TabIndex = 50;
            this.lbsumhoc.Text = "Chưa có dữ liệu.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(354, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(367, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(2)))));
            this.label4.Location = new System.Drawing.Point(31, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 33);
            this.label4.TabIndex = 53;
            this.label4.Text = "Thành tích của bạn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.combaihoc);
            this.panel1.Controls.Add(this.chart2);
            this.panel1.Controls.Add(this.lbsai1);
            this.panel1.Controls.Add(this.lbdung1);
            this.panel1.Controls.Add(this.lbsunhoc1);
            this.panel1.Location = new System.Drawing.Point(507, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 346);
            this.panel1.TabIndex = 54;
            // 
            // combaihoc
            // 
            this.combaihoc.BackColor = System.Drawing.Color.Transparent;
            this.combaihoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.combaihoc.BorderRadius = 15;
            this.combaihoc.BorderThickness = 2;
            this.combaihoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combaihoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combaihoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combaihoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combaihoc.FocusedState.Parent = this.combaihoc;
            this.combaihoc.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combaihoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.combaihoc.HoverState.Parent = this.combaihoc;
            this.combaihoc.ItemHeight = 30;
            this.combaihoc.ItemsAppearance.Parent = this.combaihoc;
            this.combaihoc.Location = new System.Drawing.Point(243, 12);
            this.combaihoc.Name = "combaihoc";
            this.combaihoc.ShadowDecoration.Parent = this.combaihoc;
            this.combaihoc.Size = new System.Drawing.Size(214, 36);
            this.combaihoc.TabIndex = 54;
            this.combaihoc.SelectedIndexChanged += new System.EventHandler(this.combaihoc_SelectedIndexChanged);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(121, 153);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.2F);
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            series2.Legend = "Legend1";
            series2.Name = "Salary2";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(259, 218);
            this.chart2.TabIndex = 53;
            this.chart2.Text = "chart2";
            // 
            // lbsai1
            // 
            this.lbsai1.AutoSize = true;
            this.lbsai1.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsai1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lbsai1.Location = new System.Drawing.Point(29, 125);
            this.lbsai1.Name = "lbsai1";
            this.lbsai1.Size = new System.Drawing.Size(106, 28);
            this.lbsai1.TabIndex = 52;
            this.lbsai1.Text = "Số lần sai.";
            // 
            // lbdung1
            // 
            this.lbdung1.AutoSize = true;
            this.lbdung1.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdung1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.lbdung1.Location = new System.Drawing.Point(29, 86);
            this.lbdung1.Name = "lbdung1";
            this.lbdung1.Size = new System.Drawing.Size(122, 28);
            this.lbdung1.TabIndex = 51;
            this.lbdung1.Text = "Số lần đúng.";
            // 
            // lbsunhoc1
            // 
            this.lbsunhoc1.AutoSize = true;
            this.lbsunhoc1.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsunhoc1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbsunhoc1.Location = new System.Drawing.Point(29, 47);
            this.lbsunhoc1.Name = "lbsunhoc1";
            this.lbsunhoc1.Size = new System.Drawing.Size(112, 28);
            this.lbsunhoc1.TabIndex = 50;
            this.lbsunhoc1.Text = "Số lần học.";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(100)))), ((int)(((byte)(2)))));
            this.label8.Location = new System.Drawing.Point(501, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 33);
            this.label8.TabIndex = 55;
            this.label8.Text = "Thành tích mỗi bài";
            // 
            // picava
            // 
            this.picava.Image = ((System.Drawing.Image)(resources.GetObject("picava.Image")));
            this.picava.Location = new System.Drawing.Point(276, 228);
            this.picava.Name = "picava";
            this.picava.Size = new System.Drawing.Size(33, 26);
            this.picava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picava.TabIndex = 56;
            this.picava.TabStop = false;
            this.picava.Click += new System.EventHandler(this.picava_Click);
            // 
            // lbname
            // 
            this.lbname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(89)))), ((int)(((byte)(135)))));
            this.lbname.Location = new System.Drawing.Point(422, 169);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(49, 26);
            this.lbname.TabIndex = 57;
            this.lbname.Text = "Tên:";
            // 
            // lbemail
            // 
            this.lbemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(89)))), ((int)(((byte)(135)))));
            this.lbemail.Location = new System.Drawing.Point(422, 219);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(62, 26);
            this.lbemail.TabIndex = 58;
            this.lbemail.Text = "Email:";
            // 
            // elipleft
            // 
            this.elipleft.BorderRadius = 25;
            this.elipleft.TargetControl = this.lbtongdung;
            // 
            // right
            // 
            this.right.BorderRadius = 25;
            this.right.TargetControl = this.panel1;
            // 
            // buttrove
            // 
            this.buttrove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttrove.AutoSize = true;
            this.buttrove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.buttrove.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.buttrove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.buttrove.BorderRadius = 15;
            this.buttrove.BorderSize = 2;
            this.buttrove.FlatAppearance.BorderSize = 0;
            this.buttrove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.buttrove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.buttrove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttrove.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttrove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buttrove.Location = new System.Drawing.Point(10, 13);
            this.buttrove.Margin = new System.Windows.Forms.Padding(4);
            this.buttrove.Name = "buttrove";
            this.buttrove.Size = new System.Drawing.Size(96, 45);
            this.buttrove.TabIndex = 66;
            this.buttrove.Text = "Trở về";
            this.buttrove.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buttrove.UseVisualStyleBackColor = false;
            this.buttrove.Click += new System.EventHandler(this.buttrove_Click);
            // 
            // buthuy
            // 
            this.buthuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(174)))));
            this.buthuy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(174)))));
            this.buthuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.buthuy.BorderRadius = 15;
            this.buthuy.BorderSize = 2;
            this.buthuy.FlatAppearance.BorderSize = 0;
            this.buthuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.buthuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(13)))));
            this.buthuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buthuy.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buthuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.buthuy.Location = new System.Drawing.Point(871, 209);
            this.buthuy.Margin = new System.Windows.Forms.Padding(4);
            this.buthuy.Name = "buthuy";
            this.buthuy.Size = new System.Drawing.Size(110, 45);
            this.buthuy.TabIndex = 65;
            this.buthuy.Text = "Hủy";
            this.buthuy.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(0)))), ((int)(((byte)(16)))));
            this.buthuy.UseVisualStyleBackColor = false;
            this.buthuy.Visible = false;
            this.buthuy.Click += new System.EventHandler(this.buthuy_Click);
            // 
            // txtemail
            // 
            this.txtemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.txtemail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtemail.BorderRadius = 20;
            this.txtemail.BorderSize = 2;
            this.txtemail.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.txtemail.Location = new System.Drawing.Point(424, 208);
            this.txtemail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtemail.Multiline = false;
            this.txtemail.Name = "txtemail";
            this.txtemail.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.txtemail.PasswordChar = false;
            this.txtemail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtemail.PlaceholderText = "";
            this.txtemail.Size = new System.Drawing.Size(257, 42);
            this.txtemail.TabIndex = 64;
            this.txtemail.Texts = "";
            this.txtemail.UnderlinedStyle = false;
            this.txtemail.Visible = false;
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.txtname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtname.BorderRadius = 20;
            this.txtname.BorderSize = 2;
            this.txtname.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.txtname.Location = new System.Drawing.Point(424, 158);
            this.txtname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtname.Multiline = false;
            this.txtname.Name = "txtname";
            this.txtname.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.txtname.PasswordChar = false;
            this.txtname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtname.PlaceholderText = "";
            this.txtname.Size = new System.Drawing.Size(257, 42);
            this.txtname.TabIndex = 63;
            this.txtname.Texts = "";
            this.txtname.UnderlinedStyle = false;
            this.txtname.Visible = false;
            // 
            // butdoiinfo
            // 
            this.butdoiinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butdoiinfo.AutoSize = true;
            this.butdoiinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.butdoiinfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.butdoiinfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.butdoiinfo.BorderRadius = 15;
            this.butdoiinfo.BorderSize = 2;
            this.butdoiinfo.FlatAppearance.BorderSize = 0;
            this.butdoiinfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.butdoiinfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.butdoiinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butdoiinfo.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdoiinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.butdoiinfo.Location = new System.Drawing.Point(793, 159);
            this.butdoiinfo.Margin = new System.Windows.Forms.Padding(4);
            this.butdoiinfo.Name = "butdoiinfo";
            this.butdoiinfo.Size = new System.Drawing.Size(188, 45);
            this.butdoiinfo.TabIndex = 62;
            this.butdoiinfo.Text = "Thay đổi thông tin";
            this.butdoiinfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.butdoiinfo.UseVisualStyleBackColor = false;
            this.butdoiinfo.Click += new System.EventHandler(this.butdoiinfo_Click);
            // 
            // lbDoiMk
            // 
            this.lbDoiMk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDoiMk.AutoSize = true;
            this.lbDoiMk.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoiMk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbDoiMk.Location = new System.Drawing.Point(851, 129);
            this.lbDoiMk.Name = "lbDoiMk";
            this.lbDoiMk.Size = new System.Drawing.Size(130, 26);
            this.lbDoiMk.TabIndex = 67;
            this.lbDoiMk.Text = "Đổi mật khẩu";
            this.lbDoiMk.Click += new System.EventHandler(this.lbDoiMk_Click);
            // 
            // formcanhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1010, 676);
            this.Controls.Add(this.lbDoiMk);
            this.Controls.Add(this.buttrove);
            this.Controls.Add(this.buthuy);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.butdoiinfo);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.picava);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtongdung);
            this.Controls.Add(this.avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formcanhan";
            this.Text = "formcanhan";
            this.Load += new System.EventHandler(this.formcanhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.lbtongdung.ResumeLayout(false);
            this.lbtongdung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox avatar;
        private System.Windows.Forms.Panel lbtongdung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbdung;
        private System.Windows.Forms.Label lbsumhoc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbsai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lbsai1;
        private System.Windows.Forms.Label lbdung1;
        private System.Windows.Forms.Label lbsunhoc1;
        internal Guna.UI2.WinForms.Guna2ComboBox combaihoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picava;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbemail;
        private CustomButton butdoiinfo;
        private Guna.UI2.WinForms.Guna2Elipse elipleft;
        private Guna.UI2.WinForms.Guna2Elipse right;
        private RoundTextbox txtname;
        private RoundTextbox txtemail;
        private CustomButton buthuy;
        private CustomButton buttrove;
        private System.Windows.Forms.Label lbDoiMk;
    }
}