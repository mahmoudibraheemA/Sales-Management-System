
namespace Sales_Management_System.EPL
{
    partial class Toas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_toasm = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic_toas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_toas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(463, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 100);
            this.panel1.TabIndex = 1;
            // 
            // lb_toasm
            // 
            this.lb_toasm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_toasm.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_toasm.ForeColor = System.Drawing.Color.Black;
            this.lb_toasm.Location = new System.Drawing.Point(100, 0);
            this.lb_toasm.Name = "lb_toasm";
            this.lb_toasm.Size = new System.Drawing.Size(363, 100);
            this.lb_toasm.TabIndex = 8;
            this.lb_toasm.Text = "رساله";
            this.lb_toasm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pic_toas
            // 
            this.pic_toas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_toas.Image = global::Sales_Management_System.Properties.Resources.flag;
            this.pic_toas.Location = new System.Drawing.Point(0, 0);
            this.pic_toas.Name = "pic_toas";
            this.pic_toas.Size = new System.Drawing.Size(100, 100);
            this.pic_toas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_toas.TabIndex = 0;
            this.pic_toas.TabStop = false;
            // 
            // Toas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 100);
            this.Controls.Add(this.lb_toasm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_toas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Toas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Toas";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_toas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pic_toas;
        public System.Windows.Forms.Label lb_toasm;
        public System.Windows.Forms.Timer timer1;
    }
}