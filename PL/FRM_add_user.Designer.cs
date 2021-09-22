
namespace Sales_Management_System.PL
{
    partial class FRM_add_user
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
            this.lb_supp_name = new System.Windows.Forms.Label();
            this.tb_user_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_supp_phone = new System.Windows.Forms.Label();
            this.tb_user_pass = new System.Windows.Forms.TextBox();
            this.lb_supp_email = new System.Windows.Forms.Label();
            this.tb_user_role = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_supp_name
            // 
            this.lb_supp_name.AutoSize = true;
            this.lb_supp_name.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supp_name.ForeColor = System.Drawing.Color.Black;
            this.lb_supp_name.Location = new System.Drawing.Point(292, 51);
            this.lb_supp_name.Name = "lb_supp_name";
            this.lb_supp_name.Size = new System.Drawing.Size(186, 45);
            this.lb_supp_name.TabIndex = 7;
            this.lb_supp_name.Text = "أسم المستخدم";
            this.lb_supp_name.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_user_name
            // 
            this.tb_user_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user_name.Location = new System.Drawing.Point(280, 117);
            this.tb_user_name.Name = "tb_user_name";
            this.tb_user_name.Size = new System.Drawing.Size(211, 47);
            this.tb_user_name.TabIndex = 9;
            this.tb_user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lb_supp_phone
            // 
            this.lb_supp_phone.AutoSize = true;
            this.lb_supp_phone.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supp_phone.ForeColor = System.Drawing.Color.Black;
            this.lb_supp_phone.Location = new System.Drawing.Point(292, 182);
            this.lb_supp_phone.Name = "lb_supp_phone";
            this.lb_supp_phone.Size = new System.Drawing.Size(167, 45);
            this.lb_supp_phone.TabIndex = 7;
            this.lb_supp_phone.Text = "كلمة المرور";
            this.lb_supp_phone.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_user_pass
            // 
            this.tb_user_pass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_user_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user_pass.Location = new System.Drawing.Point(280, 247);
            this.tb_user_pass.Name = "tb_user_pass";
            this.tb_user_pass.Size = new System.Drawing.Size(211, 47);
            this.tb_user_pass.TabIndex = 9;
            this.tb_user_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_supp_email
            // 
            this.lb_supp_email.AutoSize = true;
            this.lb_supp_email.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supp_email.ForeColor = System.Drawing.Color.Black;
            this.lb_supp_email.Location = new System.Drawing.Point(311, 313);
            this.lb_supp_email.Name = "lb_supp_email";
            this.lb_supp_email.Size = new System.Drawing.Size(137, 45);
            this.lb_supp_email.TabIndex = 7;
            this.lb_supp_email.Text = "الصلاحيه";
            this.lb_supp_email.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_user_role
            // 
            this.tb_user_role.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_user_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user_role.Location = new System.Drawing.Point(280, 377);
            this.tb_user_role.Name = "tb_user_role";
            this.tb_user_role.Size = new System.Drawing.Size(211, 47);
            this.tb_user_role.TabIndex = 9;
            this.tb_user_role.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRM_add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_user_role);
            this.Controls.Add(this.tb_user_pass);
            this.Controls.Add(this.lb_supp_email);
            this.Controls.Add(this.lb_supp_phone);
            this.Controls.Add(this.tb_user_name);
            this.Controls.Add(this.lb_supp_name);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_add_user";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_add_supp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_supp_name;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.TextBox tb_user_name;
        private System.Windows.Forms.Label lb_supp_phone;
        public System.Windows.Forms.TextBox tb_user_pass;
        private System.Windows.Forms.Label lb_supp_email;
        public System.Windows.Forms.TextBox tb_user_role;
    }
}