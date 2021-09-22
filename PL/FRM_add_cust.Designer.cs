
namespace Sales_Management_System.PL
{
    partial class FRM_add_cust
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
            this.lb_cust_name = new System.Windows.Forms.Label();
            this.tb_cust_name = new System.Windows.Forms.TextBox();
            this.lb_supp_phone = new System.Windows.Forms.Label();
            this.tb_cust_phone = new System.Windows.Forms.TextBox();
            this.lb_cust_email = new System.Windows.Forms.Label();
            this.tb_cust_email = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_cust_name
            // 
            this.lb_cust_name.AutoSize = true;
            this.lb_cust_name.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cust_name.ForeColor = System.Drawing.Color.Black;
            this.lb_cust_name.Location = new System.Drawing.Point(308, 53);
            this.lb_cust_name.Name = "lb_cust_name";
            this.lb_cust_name.Size = new System.Drawing.Size(150, 45);
            this.lb_cust_name.TabIndex = 7;
            this.lb_cust_name.Text = "اسم العميل";
            this.lb_cust_name.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_cust_name
            // 
            this.tb_cust_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_cust_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cust_name.Location = new System.Drawing.Point(280, 117);
            this.tb_cust_name.Name = "tb_cust_name";
            this.tb_cust_name.Size = new System.Drawing.Size(211, 47);
            this.tb_cust_name.TabIndex = 9;
            this.tb_cust_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_supp_phone
            // 
            this.lb_supp_phone.AutoSize = true;
            this.lb_supp_phone.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supp_phone.ForeColor = System.Drawing.Color.Black;
            this.lb_supp_phone.Location = new System.Drawing.Point(310, 183);
            this.lb_supp_phone.Name = "lb_supp_phone";
            this.lb_supp_phone.Size = new System.Drawing.Size(147, 45);
            this.lb_supp_phone.TabIndex = 7;
            this.lb_supp_phone.Text = "رقم العميل";
            this.lb_supp_phone.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_cust_phone
            // 
            this.tb_cust_phone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_cust_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cust_phone.Location = new System.Drawing.Point(280, 247);
            this.tb_cust_phone.Name = "tb_cust_phone";
            this.tb_cust_phone.Size = new System.Drawing.Size(211, 47);
            this.tb_cust_phone.TabIndex = 9;
            this.tb_cust_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_cust_email
            // 
            this.lb_cust_email.AutoSize = true;
            this.lb_cust_email.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cust_email.ForeColor = System.Drawing.Color.Black;
            this.lb_cust_email.Location = new System.Drawing.Point(268, 313);
            this.lb_cust_email.Name = "lb_cust_email";
            this.lb_cust_email.Size = new System.Drawing.Size(235, 45);
            this.lb_cust_email.TabIndex = 7;
            this.lb_cust_email.Text = "البريد الالكتروني ";
            this.lb_cust_email.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_cust_email
            // 
            this.tb_cust_email.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_cust_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cust_email.Location = new System.Drawing.Point(280, 377);
            this.tb_cust_email.Name = "tb_cust_email";
            this.tb_cust_email.Size = new System.Drawing.Size(211, 47);
            this.tb_cust_email.TabIndex = 9;
            this.tb_cust_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = global::Sales_Management_System.Properties.Resources.add;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(667, 432);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(121, 59);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "أضافه";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Image = global::Sales_Management_System.Properties.Resources.close;
            this.btn_close.Location = new System.Drawing.Point(713, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 55);
            this.btn_close.TabIndex = 6;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FRM_add_cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_cust_email);
            this.Controls.Add(this.tb_cust_phone);
            this.Controls.Add(this.lb_cust_email);
            this.Controls.Add(this.lb_supp_phone);
            this.Controls.Add(this.tb_cust_name);
            this.Controls.Add(this.lb_cust_name);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_add_cust";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_add_supp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_cust_name;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.TextBox tb_cust_name;
        private System.Windows.Forms.Label lb_supp_phone;
        public System.Windows.Forms.TextBox tb_cust_phone;
        private System.Windows.Forms.Label lb_cust_email;
        public System.Windows.Forms.TextBox tb_cust_email;
    }
}