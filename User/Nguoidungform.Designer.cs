namespace Đồ_án
{
    partial class Nguoidungfrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nguoidungfrom));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradian1 = new Gradian.gradian();
            this.pnelleft = new Guna.UI2.WinForms.Guna2Panel();
            this.butdangxuat = new Đồ_án.CustomButton();
            this.pnelava = new System.Windows.Forms.Panel();
            this.picava = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labhoten = new System.Windows.Forms.Label();
            this.maincrn = new System.Windows.Forms.Panel();
            this.gradian1.SuspendLayout();
            this.pnelleft.SuspendLayout();
            this.pnelava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this.maincrn;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.pnelava;
            // 
            // timer1
            // 
            this.timer1.Interval = 9000;
            // 
            // gradian1
            // 
            this.gradian1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.gradian1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.gradian1.Controls.Add(this.pnelleft);
            this.gradian1.Controls.Add(this.maincrn);
            this.gradian1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradian1.Location = new System.Drawing.Point(0, 0);
            this.gradian1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradian1.Name = "gradian1";
            this.gradian1.Size = new System.Drawing.Size(1284, 702);
            this.gradian1.TabIndex = 3;
            // 
            // pnelleft
            // 
            this.pnelleft.BackColor = System.Drawing.Color.Transparent;
            this.pnelleft.Controls.Add(this.butdangxuat);
            this.pnelleft.Controls.Add(this.pnelava);
            this.pnelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnelleft.Location = new System.Drawing.Point(0, 0);
            this.pnelleft.Margin = new System.Windows.Forms.Padding(4);
            this.pnelleft.Name = "pnelleft";
            this.pnelleft.ShadowDecoration.Parent = this.pnelleft;
            this.pnelleft.Size = new System.Drawing.Size(252, 702);
            this.pnelleft.TabIndex = 3;
            // 
            // butdangxuat
            // 
            this.butdangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.butdangxuat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.butdangxuat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.butdangxuat.BorderRadius = 15;
            this.butdangxuat.BorderSize = 2;
            this.butdangxuat.FlatAppearance.BorderSize = 0;
            this.butdangxuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.butdangxuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.butdangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butdangxuat.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdangxuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.butdangxuat.Location = new System.Drawing.Point(53, 639);
            this.butdangxuat.Margin = new System.Windows.Forms.Padding(4);
            this.butdangxuat.Name = "butdangxuat";
            this.butdangxuat.Size = new System.Drawing.Size(133, 48);
            this.butdangxuat.TabIndex = 36;
            this.butdangxuat.Text = "Đăng xuất";
            this.butdangxuat.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.butdangxuat.UseVisualStyleBackColor = false;
            this.butdangxuat.Click += new System.EventHandler(this.butdangxuat_Click);
            // 
            // pnelava
            // 
            this.pnelava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnelava.Controls.Add(this.picava);
            this.pnelava.Controls.Add(this.pictureBox1);
            this.pnelava.Controls.Add(this.labhoten);
            this.pnelava.Location = new System.Drawing.Point(19, 11);
            this.pnelava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnelava.Name = "pnelava";
            this.pnelava.Size = new System.Drawing.Size(235, 214);
            this.pnelava.TabIndex = 0;
            // 
            // picava
            // 
            this.picava.ImageRotate = 0F;
            this.picava.Location = new System.Drawing.Point(48, 21);
            this.picava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picava.Name = "picava";
            this.picava.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picava.ShadowDecoration.Parent = this.picava;
            this.picava.Size = new System.Drawing.Size(137, 127);
            this.picava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picava.TabIndex = 0;
            this.picava.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 176);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labhoten
            // 
            this.labhoten.AutoSize = true;
            this.labhoten.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labhoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.labhoten.Location = new System.Drawing.Point(83, 151);
            this.labhoten.Name = "labhoten";
            this.labhoten.Size = new System.Drawing.Size(69, 26);
            this.labhoten.TabIndex = 0;
            this.labhoten.Text = "labten";
            // 
            // maincrn
            // 
            this.maincrn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maincrn.AutoScroll = true;
            this.maincrn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.maincrn.Location = new System.Drawing.Point(259, 11);
            this.maincrn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maincrn.Name = "maincrn";
            this.maincrn.Size = new System.Drawing.Size(1011, 676);
            this.maincrn.TabIndex = 2;
            // 
            // Nguoidungfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.gradian1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Nguoidungfrom";
            this.Text = "Welcome to NekoStu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nguoidungfrom_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradian1.ResumeLayout(false);
            this.pnelleft.ResumeLayout(false);
            this.pnelava.ResumeLayout(false);
            this.pnelava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradian.gradian gradian1;
        private Guna.UI2.WinForms.Guna2Panel pnelleft;
        private System.Windows.Forms.Panel pnelava;
        private System.Windows.Forms.Label labhoten;
        private System.Windows.Forms.Panel maincrn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picava;
        private CustomButton butdangxuat;
    }
}

