
namespace Sales_Management_System.PL
{
    partial class FRM_reports
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
            this.pn_reports = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sell_report = new System.Windows.Forms.Button();
            this.pn_reports.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_reports
            // 
            this.pn_reports.BackColor = System.Drawing.Color.DarkRed;
            this.pn_reports.Controls.Add(this.btn_sell_report);
            this.pn_reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_reports.Location = new System.Drawing.Point(0, 0);
            this.pn_reports.Name = "pn_reports";
            this.pn_reports.Padding = new System.Windows.Forms.Padding(15);
            this.pn_reports.Size = new System.Drawing.Size(1023, 621);
            this.pn_reports.TabIndex = 0;
            // 
            // btn_sell_report
            // 
            this.btn_sell_report.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sell_report.BackColor = System.Drawing.Color.White;
            this.btn_sell_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sell_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sell_report.Location = new System.Drawing.Point(35, 35);
            this.btn_sell_report.Margin = new System.Windows.Forms.Padding(20);
            this.btn_sell_report.Name = "btn_sell_report";
            this.btn_sell_report.Size = new System.Drawing.Size(275, 260);
            this.btn_sell_report.TabIndex = 12;
            this.btn_sell_report.Text = "تقرير المبيعات ";
            this.btn_sell_report.UseVisualStyleBackColor = false;
            this.btn_sell_report.Click += new System.EventHandler(this.btn_sell_report_Click);
            // 
            // FRM_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 621);
            this.Controls.Add(this.pn_reports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_reports";
            this.Text = "FRM_reports";
            this.pn_reports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel pn_reports;
        public System.Windows.Forms.Button btn_sell_report;
    }
}