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
            this.gradian1 = new Gradian.gradian();
            this.pnelleft = new Guna.UI2.WinForms.Guna2Panel();
            this.pnelava = new System.Windows.Forms.Panel();
            this.maincrn = new System.Windows.Forms.Panel();
            this.labhoten = new System.Windows.Forms.Label();
            this.radius1 = new Elip.Radius();
            this.radius2 = new Elip.Radius();
            this.gradian1.SuspendLayout();
            this.pnelleft.SuspendLayout();
            this.maincrn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradian1
            // 
            this.gradian1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.gradian1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.gradian1.Controls.Add(this.pnelleft);
            this.gradian1.Controls.Add(this.maincrn);
            this.gradian1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradian1.Location = new System.Drawing.Point(0, 0);
            this.gradian1.Name = "gradian1";
            this.gradian1.Size = new System.Drawing.Size(1284, 702);
            this.gradian1.TabIndex = 4;
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
            this.pnelleft.TabIndex = 5;
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
            this.maincrn.Controls.Add(this.labhoten);
            this.maincrn.Location = new System.Drawing.Point(259, 49);
            this.maincrn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maincrn.Name = "maincrn";
            this.maincrn.Size = new System.Drawing.Size(972, 606);
            this.maincrn.TabIndex = 4;
            // 
            // labhoten
            // 
            this.labhoten.AutoSize = true;
            this.labhoten.Font = new System.Drawing.Font("HL-Comic1unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labhoten.Location = new System.Drawing.Point(277, 199);
            this.labhoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labhoten.Name = "labhoten";
            this.labhoten.Size = new System.Drawing.Size(74, 20);
            this.labhoten.TabIndex = 1;
            this.labhoten.Text = "Họ tên";
            // 
            // radius1
            // 
            this.radius1.CornerRadius = 25;
            this.radius1.TargetControl = this.maincrn;
            // 
            // radius2
            // 
            this.radius2.CornerRadius = 25;
            this.radius2.TargetControl = this.pnelava;
            // 
            // formcanhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.gradian1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formcanhan";
            this.Text = "formcanhan";
            this.gradian1.ResumeLayout(false);
            this.pnelleft.ResumeLayout(false);
            this.maincrn.ResumeLayout(false);
            this.maincrn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Gradian.gradian gradian1;
        private Guna.UI2.WinForms.Guna2Panel pnelleft;
        private System.Windows.Forms.Panel pnelava;
        private System.Windows.Forms.Panel maincrn;
        private System.Windows.Forms.Label labhoten;
        private Elip.Radius radius1;
        private Elip.Radius radius2;
    }
}