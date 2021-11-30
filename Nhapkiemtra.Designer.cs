namespace Đồ_án
{
    partial class Nhapkiemtra
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
            this.dtgnhapKT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comloaiCH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnoidung = new Đồ_án.RoundTextbox();
            this.txtmaCH = new Đồ_án.RoundTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgnhapKT)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgnhapKT
            // 
            this.dtgnhapKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgnhapKT.Location = new System.Drawing.Point(38, 406);
            this.dtgnhapKT.Margin = new System.Windows.Forms.Padding(4);
            this.dtgnhapKT.Name = "dtgnhapKT";
            this.dtgnhapKT.Size = new System.Drawing.Size(937, 239);
            this.dtgnhapKT.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(2, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã câu hỏi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(529, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã loại";
            // 
            // comloaiCH
            // 
            this.comloaiCH.BackColor = System.Drawing.Color.Transparent;
            this.comloaiCH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.comloaiCH.BorderRadius = 15;
            this.comloaiCH.BorderThickness = 2;
            this.comloaiCH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comloaiCH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comloaiCH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comloaiCH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comloaiCH.FocusedState.Parent = this.comloaiCH;
            this.comloaiCH.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comloaiCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.comloaiCH.HoverState.Parent = this.comloaiCH;
            this.comloaiCH.ItemHeight = 30;
            this.comloaiCH.ItemsAppearance.Parent = this.comloaiCH;
            this.comloaiCH.Location = new System.Drawing.Point(610, 31);
            this.comloaiCH.Name = "comloaiCH";
            this.comloaiCH.ShadowDecoration.Parent = this.comloaiCH;
            this.comloaiCH.Size = new System.Drawing.Size(233, 36);
            this.comloaiCH.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(23, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 51;
            this.label3.Text = "Nội dung";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(522, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 300);
            this.panel1.TabIndex = 52;
            // 
            // txtnoidung
            // 
            this.txtnoidung.BackColor = System.Drawing.Color.White;
            this.txtnoidung.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.txtnoidung.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtnoidung.BorderRadius = 15;
            this.txtnoidung.BorderSize = 2;
            this.txtnoidung.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoidung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.txtnoidung.Location = new System.Drawing.Point(116, 79);
            this.txtnoidung.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtnoidung.Multiline = true;
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.txtnoidung.PasswordChar = false;
            this.txtnoidung.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtnoidung.PlaceholderText = "";
            this.txtnoidung.Size = new System.Drawing.Size(383, 205);
            this.txtnoidung.TabIndex = 50;
            this.txtnoidung.Texts = "";
            this.txtnoidung.UnderlinedStyle = false;
            // 
            // txtmaCH
            // 
            this.txtmaCH.BackColor = System.Drawing.Color.White;
            this.txtmaCH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.txtmaCH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtmaCH.BorderRadius = 20;
            this.txtmaCH.BorderSize = 2;
            this.txtmaCH.Enabled = false;
            this.txtmaCH.Font = new System.Drawing.Font("000 Chinacat [TeddyBear]", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.txtmaCH.Location = new System.Drawing.Point(117, 25);
            this.txtmaCH.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtmaCH.Multiline = false;
            this.txtmaCH.Name = "txtmaCH";
            this.txtmaCH.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.txtmaCH.PasswordChar = false;
            this.txtmaCH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtmaCH.PlaceholderText = "";
            this.txtmaCH.Size = new System.Drawing.Size(233, 42);
            this.txtmaCH.TabIndex = 25;
            this.txtmaCH.Texts = "";
            this.txtmaCH.UnderlinedStyle = false;
            // 
            // Nhapkiemtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1010, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnoidung);
            this.Controls.Add(this.comloaiCH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgnhapKT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Nhapkiemtra";
            this.Text = "Nhapkiemtra";
            ((System.ComponentModel.ISupportInitialize)(this.dtgnhapKT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgnhapKT;
        private RoundTextbox txtmaCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox comloaiCH;
        private RoundTextbox txtnoidung;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
    }
}