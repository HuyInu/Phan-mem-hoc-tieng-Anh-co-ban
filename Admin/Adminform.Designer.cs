namespace Đồ_án
{
    partial class Adminform
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gradian1 = new Gradian.gradian();
            this.pnelleft = new Guna.UI2.WinForms.Guna2Panel();
            this.customButton1 = new Đồ_án.CustomButton();
            this.pnelava = new System.Windows.Forms.Panel();
            this.maincrn = new System.Windows.Forms.Panel();
            this.gradian1.SuspendLayout();
            this.pnelleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this.maincrn;
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
            this.gradian1.TabIndex = 5;
            // 
            // pnelleft
            // 
            this.pnelleft.BackColor = System.Drawing.Color.Transparent;
            this.pnelleft.Controls.Add(this.customButton1);
            this.pnelleft.Controls.Add(this.pnelava);
            this.pnelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnelleft.Location = new System.Drawing.Point(0, 0);
            this.pnelleft.Margin = new System.Windows.Forms.Padding(4);
            this.pnelleft.Name = "pnelleft";
            this.pnelleft.ShadowDecoration.Parent = this.pnelleft;
            this.pnelleft.Size = new System.Drawing.Size(252, 702);
            this.pnelleft.TabIndex = 5;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(35, 231);
            this.customButton1.Margin = new System.Windows.Forms.Padding(4);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(200, 49);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "customButton1";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // pnelava
            // 
            this.pnelava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.pnelava.Location = new System.Drawing.Point(15, 49);
            this.pnelava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnelava.Name = "pnelava";
            this.pnelava.Size = new System.Drawing.Size(235, 148);
            this.pnelava.TabIndex = 0;
            // 
            // maincrn
            // 
            this.maincrn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maincrn.AutoScroll = true;
            this.maincrn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.maincrn.Location = new System.Drawing.Point(259, 49);
            this.maincrn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maincrn.Name = "maincrn";
            this.maincrn.Size = new System.Drawing.Size(972, 606);
            this.maincrn.TabIndex = 4;
            // 
            // Adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.gradian1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Adminform";
            this.Text = "Adminform";
            this.Load += new System.EventHandler(this.Adminform_Load);
            this.gradian1.ResumeLayout(false);
            this.pnelleft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gradian.gradian gradian1;
        private Guna.UI2.WinForms.Guna2Panel pnelleft;
        private System.Windows.Forms.Panel pnelava;
        private System.Windows.Forms.Panel maincrn;
        private CustomButton customButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}