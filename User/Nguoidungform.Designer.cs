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
            this.maincrn = new System.Windows.Forms.Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnelava = new System.Windows.Forms.Panel();
            this.picedit = new System.Windows.Forms.PictureBox();
            this.labhoten = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradian1 = new Gradian.gradian();
            this.pnelleft = new Guna.UI2.WinForms.Guna2Panel();
            this.pnelava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picedit)).BeginInit();
            this.gradian1.SuspendLayout();
            this.pnelleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this.maincrn;
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
            this.maincrn.Size = new System.Drawing.Size(1010, 676);
            this.maincrn.TabIndex = 2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.pnelava;
            // 
            // pnelava
            // 
            this.pnelava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.pnelava.Controls.Add(this.picedit);
            this.pnelava.Controls.Add(this.labhoten);
            this.pnelava.Location = new System.Drawing.Point(18, 11);
            this.pnelava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnelava.Name = "pnelava";
            this.pnelava.Size = new System.Drawing.Size(235, 148);
            this.pnelava.TabIndex = 0;
            // 
            // picedit
            // 
            this.picedit.Image = ((System.Drawing.Image)(resources.GetObject("picedit.Image")));
            this.picedit.Location = new System.Drawing.Point(63, 58);
            this.picedit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picedit.Name = "picedit";
            this.picedit.Size = new System.Drawing.Size(24, 22);
            this.picedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picedit.TabIndex = 2;
            this.picedit.TabStop = false;
            this.picedit.Click += new System.EventHandler(this.picedit_Click_1);
            this.picedit.MouseEnter += new System.EventHandler(this.picedit_MouseEnter);
            this.picedit.MouseLeave += new System.EventHandler(this.picedit_MouseLeave);
            // 
            // labhoten
            // 
            this.labhoten.AutoSize = true;
            this.labhoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labhoten.Location = new System.Drawing.Point(9, 82);
            this.labhoten.Name = "labhoten";
            this.labhoten.Size = new System.Drawing.Size(61, 24);
            this.labhoten.TabIndex = 0;
            this.labhoten.Text = "labten";
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
            this.pnelleft.Controls.Add(this.pnelava);
            this.pnelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnelleft.Location = new System.Drawing.Point(0, 0);
            this.pnelleft.Margin = new System.Windows.Forms.Padding(4);
            this.pnelleft.Name = "pnelleft";
            this.pnelleft.ShadowDecoration.Parent = this.pnelleft;
            this.pnelleft.Size = new System.Drawing.Size(252, 702);
            this.pnelleft.TabIndex = 3;
            // 
            // Nguoidungfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.gradian1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Nguoidungfrom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnelava.ResumeLayout(false);
            this.pnelava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picedit)).EndInit();
            this.gradian1.ResumeLayout(false);
            this.pnelleft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gradian.gradian gradian1;
        private Guna.UI2.WinForms.Guna2Panel pnelleft;
        private System.Windows.Forms.Panel pnelava;
        private System.Windows.Forms.PictureBox picedit;
        private System.Windows.Forms.Label labhoten;
        private System.Windows.Forms.Panel maincrn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Timer timer1;
    }
}

