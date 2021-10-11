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
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.maincrn = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labhoten = new System.Windows.Forms.Label();
            this.pnelleft = new Guna.UI2.WinForms.Guna2Panel();
            this.pnelava = new System.Windows.Forms.Panel();
            this.pnelback = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.maincrn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.pnelleft.SuspendLayout();
            this.pnelback.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.pnelava;
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
            this.maincrn.Controls.Add(this.labhoten);
            this.maincrn.Controls.Add(this.guna2CirclePictureBox1);
            this.maincrn.Location = new System.Drawing.Point(194, 40);
            this.maincrn.Margin = new System.Windows.Forms.Padding(2);
            this.maincrn.Name = "maincrn";
            this.maincrn.Size = new System.Drawing.Size(729, 492);
            this.maincrn.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(42, 23);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(161, 154);
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // labhoten
            // 
            this.labhoten.AutoSize = true;
            this.labhoten.Font = new System.Drawing.Font("HL-Comic1unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labhoten.Location = new System.Drawing.Point(208, 162);
            this.labhoten.Name = "labhoten";
            this.labhoten.Size = new System.Drawing.Size(58, 15);
            this.labhoten.TabIndex = 1;
            this.labhoten.Text = "Họ tên";
            // 
            // pnelleft
            // 
            this.pnelleft.BackColor = System.Drawing.Color.Transparent;
            this.pnelleft.Controls.Add(this.pnelava);
            this.pnelleft.Location = new System.Drawing.Point(0, 0);
            this.pnelleft.Name = "pnelleft";
            this.pnelleft.ShadowDecoration.Parent = this.pnelleft;
            this.pnelleft.Size = new System.Drawing.Size(189, 540);
            this.pnelleft.TabIndex = 1;
            // 
            // pnelava
            // 
            this.pnelava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.pnelava.Location = new System.Drawing.Point(11, 40);
            this.pnelava.Margin = new System.Windows.Forms.Padding(2);
            this.pnelava.Name = "pnelava";
            this.pnelava.Size = new System.Drawing.Size(176, 120);
            this.pnelava.TabIndex = 0;
            // 
            // pnelback
            // 
            this.pnelback.Controls.Add(this.pnelleft);
            this.pnelback.Controls.Add(this.maincrn);
            this.pnelback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnelback.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.pnelback.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.pnelback.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(123)))), ((int)(((byte)(217)))));
            this.pnelback.Location = new System.Drawing.Point(0, 0);
            this.pnelback.Margin = new System.Windows.Forms.Padding(2);
            this.pnelback.Name = "pnelback";
            this.pnelback.Quality = 3;
            this.pnelback.ShadowDecoration.Parent = this.pnelback;
            this.pnelback.Size = new System.Drawing.Size(963, 570);
            this.pnelback.TabIndex = 2;
            // 
            // formcanhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 570);
            this.Controls.Add(this.pnelback);
            this.Name = "formcanhan";
            this.Text = "formcanhan";
            this.maincrn.ResumeLayout(false);
            this.maincrn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.pnelleft.ResumeLayout(false);
            this.pnelback.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel pnelava;
        private System.Windows.Forms.Panel maincrn;
        private System.Windows.Forms.Label labhoten;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnelleft;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnelback;
    }
}