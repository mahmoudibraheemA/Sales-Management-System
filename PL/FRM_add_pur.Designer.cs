
namespace Sales_Management_System.PL
{
    partial class FRM_add_pur
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
            this.lb_cat_name = new System.Windows.Forms.Label();
            this.tb_cat_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_supp_phone = new System.Windows.Forms.Label();
            this.tb_supp_name = new System.Windows.Forms.TextBox();
            this.lb_pur_name = new System.Windows.Forms.Label();
            this.tb_pur_name = new System.Windows.Forms.TextBox();
            this.lb_pur_type = new System.Windows.Forms.Label();
            this.tb_pur_type = new System.Windows.Forms.TextBox();
            this.lb_pur_details = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pur_buy = new System.Windows.Forms.TextBox();
            this.tb_pur_details = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_pur_sell = new System.Windows.Forms.TextBox();
            this.lb_qt = new System.Windows.Forms.Label();
            this.tb_pur_qt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cat_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_supp_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_cat_name
            // 
            this.lb_cat_name.AutoSize = true;
            this.lb_cat_name.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cat_name.ForeColor = System.Drawing.Color.Black;
            this.lb_cat_name.Location = new System.Drawing.Point(718, 72);
            this.lb_cat_name.Name = "lb_cat_name";
            this.lb_cat_name.Size = new System.Drawing.Size(163, 45);
            this.lb_cat_name.TabIndex = 7;
            this.lb_cat_name.Text = "اسم الصنف";
            this.lb_cat_name.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_cat_name
            // 
            this.tb_cat_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_cat_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cat_name.Location = new System.Drawing.Point(479, 69);
            this.tb_cat_name.Name = "tb_cat_name";
            this.tb_cat_name.Size = new System.Drawing.Size(211, 47);
            this.tb_cat_name.TabIndex = 9;
            this.tb_cat_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_cat_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = global::Sales_Management_System.Properties.Resources.add;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(726, 601);
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
            this.btn_close.Location = new System.Drawing.Point(832, 12);
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
            this.lb_supp_phone.Location = new System.Drawing.Point(291, 69);
            this.lb_supp_phone.Name = "lb_supp_phone";
            this.lb_supp_phone.Size = new System.Drawing.Size(154, 45);
            this.lb_supp_phone.TabIndex = 7;
            this.lb_supp_phone.Text = "أسم المورد";
            this.lb_supp_phone.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_supp_name
            // 
            this.tb_supp_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_supp_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_supp_name.Location = new System.Drawing.Point(58, 69);
            this.tb_supp_name.Name = "tb_supp_name";
            this.tb_supp_name.Size = new System.Drawing.Size(211, 47);
            this.tb_supp_name.TabIndex = 9;
            this.tb_supp_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_pur_name
            // 
            this.lb_pur_name.AutoSize = true;
            this.lb_pur_name.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pur_name.ForeColor = System.Drawing.Color.Black;
            this.lb_pur_name.Location = new System.Drawing.Point(704, 149);
            this.lb_pur_name.Name = "lb_pur_name";
            this.lb_pur_name.Size = new System.Drawing.Size(181, 45);
            this.lb_pur_name.TabIndex = 7;
            this.lb_pur_name.Text = "عملية الشراء";
            this.lb_pur_name.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_pur_name
            // 
            this.tb_pur_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_pur_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pur_name.Location = new System.Drawing.Point(479, 149);
            this.tb_pur_name.Name = "tb_pur_name";
            this.tb_pur_name.Size = new System.Drawing.Size(211, 47);
            this.tb_pur_name.TabIndex = 9;
            this.tb_pur_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_pur_type
            // 
            this.lb_pur_type.AutoSize = true;
            this.lb_pur_type.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pur_type.ForeColor = System.Drawing.Color.Black;
            this.lb_pur_type.Location = new System.Drawing.Point(726, 227);
            this.lb_pur_type.Name = "lb_pur_type";
            this.lb_pur_type.Size = new System.Drawing.Size(155, 45);
            this.lb_pur_type.TabIndex = 7;
            this.lb_pur_type.Text = "نوع العمليه";
            this.lb_pur_type.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_pur_type
            // 
            this.tb_pur_type.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_pur_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pur_type.Location = new System.Drawing.Point(479, 229);
            this.tb_pur_type.Name = "tb_pur_type";
            this.tb_pur_type.Size = new System.Drawing.Size(211, 47);
            this.tb_pur_type.TabIndex = 9;
            this.tb_pur_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_pur_details
            // 
            this.lb_pur_details.AutoSize = true;
            this.lb_pur_details.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pur_details.ForeColor = System.Drawing.Color.Black;
            this.lb_pur_details.Location = new System.Drawing.Point(772, 307);
            this.lb_pur_details.Name = "lb_pur_details";
            this.lb_pur_details.Size = new System.Drawing.Size(109, 45);
            this.lb_pur_details.TabIndex = 7;
            this.lb_pur_details.Text = "تفاصيل";
            this.lb_pur_details.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(288, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "ثمن الشراء";
            this.label3.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_pur_buy
            // 
            this.tb_pur_buy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_pur_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pur_buy.Location = new System.Drawing.Point(58, 147);
            this.tb_pur_buy.Name = "tb_pur_buy";
            this.tb_pur_buy.Size = new System.Drawing.Size(211, 47);
            this.tb_pur_buy.TabIndex = 9;
            this.tb_pur_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pur_buy.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_pur_details
            // 
            this.tb_pur_details.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_pur_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pur_details.Location = new System.Drawing.Point(479, 309);
            this.tb_pur_details.Name = "tb_pur_details";
            this.tb_pur_details.Size = new System.Drawing.Size(211, 47);
            this.tb_pur_details.TabIndex = 9;
            this.tb_pur_details.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Sales_Management_System.Properties.Resources.add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(362, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "أضافه";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(319, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "ثمن البيع";
            this.label5.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_pur_sell
            // 
            this.tb_pur_sell.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_pur_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pur_sell.Location = new System.Drawing.Point(58, 227);
            this.tb_pur_sell.Name = "tb_pur_sell";
            this.tb_pur_sell.Size = new System.Drawing.Size(211, 47);
            this.tb_pur_sell.TabIndex = 9;
            this.tb_pur_sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_qt
            // 
            this.lb_qt.AutoSize = true;
            this.lb_qt.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qt.ForeColor = System.Drawing.Color.Black;
            this.lb_qt.Location = new System.Drawing.Point(354, 307);
            this.lb_qt.Name = "lb_qt";
            this.lb_qt.Size = new System.Drawing.Size(91, 45);
            this.lb_qt.TabIndex = 7;
            this.lb_qt.Text = "الكمية";
            this.lb_qt.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_pur_qt
            // 
            this.tb_pur_qt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_pur_qt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pur_qt.Location = new System.Drawing.Point(58, 309);
            this.tb_pur_qt.Name = "tb_pur_qt";
            this.tb_pur_qt.Size = new System.Drawing.Size(211, 47);
            this.tb_pur_qt.TabIndex = 9;
            this.tb_pur_qt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(726, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "رقم الصنف";
            this.label1.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_cat_id
            // 
            this.tb_cat_id.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_cat_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cat_id.Location = new System.Drawing.Point(479, 388);
            this.tb_cat_id.Name = "tb_cat_id";
            this.tb_cat_id.Size = new System.Drawing.Size(211, 47);
            this.tb_cat_id.TabIndex = 9;
            this.tb_cat_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(294, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "رقم المورد";
            this.label2.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_supp_id
            // 
            this.tb_supp_id.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_supp_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_supp_id.Location = new System.Drawing.Point(58, 392);
            this.tb_supp_id.Name = "tb_supp_id";
            this.tb_supp_id.Size = new System.Drawing.Size(211, 47);
            this.tb_supp_id.TabIndex = 9;
            this.tb_supp_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRM_add_pur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_supp_id);
            this.Controls.Add(this.tb_pur_qt);
            this.Controls.Add(this.tb_pur_sell);
            this.Controls.Add(this.tb_pur_buy);
            this.Controls.Add(this.tb_cat_id);
            this.Controls.Add(this.tb_pur_details);
            this.Controls.Add(this.tb_pur_type);
            this.Controls.Add(this.tb_pur_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_qt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_pur_details);
            this.Controls.Add(this.lb_pur_type);
            this.Controls.Add(this.tb_supp_name);
            this.Controls.Add(this.lb_pur_name);
            this.Controls.Add(this.lb_supp_phone);
            this.Controls.Add(this.tb_cat_name);
            this.Controls.Add(this.lb_cat_name);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_add_pur";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_add_supp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_cat_name;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.TextBox tb_cat_name;
        private System.Windows.Forms.Label lb_supp_phone;
        public System.Windows.Forms.TextBox tb_supp_name;
        private System.Windows.Forms.Label lb_pur_name;
        public System.Windows.Forms.TextBox tb_pur_name;
        private System.Windows.Forms.Label lb_pur_type;
        public System.Windows.Forms.TextBox tb_pur_type;
        private System.Windows.Forms.Label lb_pur_details;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_pur_buy;
        public System.Windows.Forms.TextBox tb_pur_details;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tb_pur_sell;
        private System.Windows.Forms.Label lb_qt;
        public System.Windows.Forms.TextBox tb_pur_qt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_cat_id;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_supp_id;
    }
}