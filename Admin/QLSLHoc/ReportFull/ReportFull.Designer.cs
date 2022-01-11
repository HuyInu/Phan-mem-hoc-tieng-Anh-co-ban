namespace Đồ_án
{
    partial class ReportFull
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportFull));
            this.crystal = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystal
            // 
            this.crystal.ActiveViewIndex = -1;
            this.crystal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal.Location = new System.Drawing.Point(0, 0);
            this.crystal.Name = "crystal";
            this.crystal.Size = new System.Drawing.Size(1122, 671);
            this.crystal.TabIndex = 0;
            // 
            // ReportFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 671);
            this.Controls.Add(this.crystal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportFull";
            this.Text = "Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportFull_FormClosed);
            this.Load += new System.EventHandler(this.ReportFull_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal;
    }
}