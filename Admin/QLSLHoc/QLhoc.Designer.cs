namespace Đồ_án
{
    partial class QLhoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.week = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbday = new System.Windows.Forms.Label();
            this.pn1 = new System.Windows.Forms.Panel();
            this.sumYear = new System.Windows.Forms.Label();
            this.sumMonth = new System.Windows.Forms.Label();
            this.sumWeek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dtg = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butFull = new Đồ_án.CustomButton();
            this.but1 = new Đồ_án.CustomButton();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // week
            // 
            this.week.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.week.AutoSize = true;
            this.week.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.week.Location = new System.Drawing.Point(217, 173);
            this.week.Name = "week";
            this.week.Size = new System.Drawing.Size(86, 41);
            this.week.TabIndex = 23;
            this.week.Text = "Tuần";
            // 
            // month
            // 
            this.month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.month.AutoSize = true;
            this.month.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.month.Location = new System.Drawing.Point(492, 173);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(102, 41);
            this.month.TabIndex = 24;
            this.month.Text = "Tháng";
            // 
            // year
            // 
            this.year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.year.Location = new System.Drawing.Point(764, 173);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(81, 41);
            this.year.TabIndex = 25;
            this.year.Text = "Năm";
            // 
            // date
            // 
            this.date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.date.BorderRadius = 12;
            this.date.BorderThickness = 2;
            this.date.CheckedState.Parent = this.date;
            this.date.CustomFormat = "dd/MM/yyyy";
            this.date.FillColor = System.Drawing.Color.White;
            this.date.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.HoverState.Parent = this.date;
            this.date.Location = new System.Drawing.Point(794, 107);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.ShadowDecoration.Parent = this.date;
            this.date.Size = new System.Drawing.Size(180, 36);
            this.date.TabIndex = 26;
            this.date.Value = new System.DateTime(2021, 12, 19, 10, 37, 6, 187);
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // lbday
            // 
            this.lbday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbday.AutoSize = true;
            this.lbday.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(146)))), ((int)(((byte)(219)))));
            this.lbday.Location = new System.Drawing.Point(199, 214);
            this.lbday.Name = "lbday";
            this.lbday.Size = new System.Drawing.Size(48, 23);
            this.lbday.TabIndex = 27;
            this.lbday.Text = "date";
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.White;
            this.pn1.Controls.Add(this.sumYear);
            this.pn1.Controls.Add(this.sumMonth);
            this.pn1.Controls.Add(this.sumWeek);
            this.pn1.Controls.Add(this.label1);
            this.pn1.Location = new System.Drawing.Point(36, 248);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(941, 59);
            this.pn1.TabIndex = 28;
            this.pn1.Paint += new System.Windows.Forms.PaintEventHandler(this.pn1_Paint);
            // 
            // sumYear
            // 
            this.sumYear.AutoSize = true;
            this.sumYear.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(146)))), ((int)(((byte)(219)))));
            this.sumYear.Location = new System.Drawing.Point(752, 11);
            this.sumYear.Name = "sumYear";
            this.sumYear.Size = new System.Drawing.Size(121, 33);
            this.sumYear.TabIndex = 31;
            this.sumYear.Text = "tongyear";
            // 
            // sumMonth
            // 
            this.sumMonth.AutoSize = true;
            this.sumMonth.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(146)))), ((int)(((byte)(219)))));
            this.sumMonth.Location = new System.Drawing.Point(488, 11);
            this.sumMonth.Name = "sumMonth";
            this.sumMonth.Size = new System.Drawing.Size(142, 33);
            this.sumMonth.TabIndex = 30;
            this.sumMonth.Text = "tongmonth";
            // 
            // sumWeek
            // 
            this.sumWeek.AutoSize = true;
            this.sumWeek.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(146)))), ((int)(((byte)(219)))));
            this.sumWeek.Location = new System.Drawing.Point(209, 11);
            this.sumWeek.Name = "sumWeek";
            this.sumWeek.Size = new System.Drawing.Size(125, 33);
            this.sumWeek.TabIndex = 29;
            this.sumWeek.Text = "tongweek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tổng";
            // 
            // pn
            // 
            this.pn.BorderRadius = 25;
            this.pn.TargetControl = this.pn1;
            // 
            // dtg
            // 
            this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg.Location = new System.Drawing.Point(34, 370);
            this.dtg.Name = "dtg";
            this.dtg.RowTemplate.Height = 24;
            this.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg.Size = new System.Drawing.Size(941, 272);
            this.dtg.TabIndex = 29;
            this.dtg.SelectionChanged += new System.EventHandler(this.dtg_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(35, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "Chi tiết:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(252, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 41);
            this.label3.TabIndex = 31;
            this.label3.Text = "Thống kê số lần học của người dùng";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(622, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "Chọn thời điểm:";
            // 
            // butFull
            // 
            this.butFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.butFull.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.butFull.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.butFull.BorderRadius = 15;
            this.butFull.BorderSize = 2;
            this.butFull.FlatAppearance.BorderSize = 0;
            this.butFull.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.butFull.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.butFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFull.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFull.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.butFull.Location = new System.Drawing.Point(45, 98);
            this.butFull.Margin = new System.Windows.Forms.Padding(4);
            this.butFull.Name = "butFull";
            this.butFull.Size = new System.Drawing.Size(110, 45);
            this.butFull.TabIndex = 59;
            this.butFull.Text = "In tất cả";
            this.butFull.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.butFull.UseVisualStyleBackColor = false;
            this.butFull.Click += new System.EventHandler(this.butreport_Click);
            // 
            // but1
            // 
            this.but1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.but1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.but1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.but1.BorderRadius = 15;
            this.but1.BorderSize = 2;
            this.but1.Enabled = false;
            this.but1.FlatAppearance.BorderSize = 0;
            this.but1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.but1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.but1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but1.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.but1.Location = new System.Drawing.Point(163, 98);
            this.but1.Margin = new System.Windows.Forms.Padding(4);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(119, 45);
            this.but1.TabIndex = 60;
            this.but1.Text = "In tự chọn";
            this.but1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.but1.UseVisualStyleBackColor = false;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // QLhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1010, 676);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.butFull);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.lbday);
            this.Controls.Add(this.date);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.week);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLhoc";
            this.Text = "QLhoc";
            this.Load += new System.EventHandler(this.QLhoc_Load);
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label week;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label year;
        private Guna.UI2.WinForms.Guna2DateTimePicker date;
        private System.Windows.Forms.Label lbday;
        private System.Windows.Forms.Panel pn1;
        private Guna.UI2.WinForms.Guna2Elipse pn;
        private System.Windows.Forms.Label sumWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Label sumMonth;
        private System.Windows.Forms.Label sumYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomButton butFull;
        private CustomButton but1;
    }
}