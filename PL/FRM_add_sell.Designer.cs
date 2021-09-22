
namespace Sales_Management_System.PL
{
    partial class FRM_add_sell
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
            this.lb_sell_name = new System.Windows.Forms.Label();
            this.tb_sell_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_cust_name = new System.Windows.Forms.Label();
            this.tb_cust_name = new System.Windows.Forms.TextBox();
            this.lb_sell_price = new System.Windows.Forms.Label();
            this.tb_sell_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_sell_qt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_sell_name
            // 
            this.lb_sell_name.AutoSize = true;
            this.lb_sell_name.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sell_name.ForeColor = System.Drawing.Color.Black;
            this.lb_sell_name.Location = new System.Drawing.Point(718, 72);
            this.lb_sell_name.Name = "lb_sell_name";
            this.lb_sell_name.Size = new System.Drawing.Size(108, 45);
            this.lb_sell_name.TabIndex = 7;
            this.lb_sell_name.Text = "الصنف";
            this.lb_sell_name.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_sell_name
            // 
            this.tb_sell_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_sell_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sell_name.Location = new System.Drawing.Point(487, 73);
            this.tb_sell_name.Name = "tb_sell_name";
            this.tb_sell_name.Size = new System.Drawing.Size(211, 47);
            this.tb_sell_name.TabIndex = 9;
            this.tb_sell_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_sell_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = global::Sales_Management_System.Properties.Resources.add;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(726, 328);
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
            // lb_cust_name
            // 
            this.lb_cust_name.AutoSize = true;
            this.lb_cust_name.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cust_name.ForeColor = System.Drawing.Color.Black;
            this.lb_cust_name.Location = new System.Drawing.Point(291, 69);
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
            this.tb_cust_name.Location = new System.Drawing.Point(42, 67);
            this.tb_cust_name.Name = "tb_cust_name";
            this.tb_cust_name.Size = new System.Drawing.Size(211, 47);
            this.tb_cust_name.TabIndex = 9;
            this.tb_cust_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_sell_price
            // 
            this.lb_sell_price.AutoSize = true;
            this.lb_sell_price.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sell_price.ForeColor = System.Drawing.Color.Black;
            this.lb_sell_price.Location = new System.Drawing.Point(733, 151);
            this.lb_sell_price.Name = "lb_sell_price";
            this.lb_sell_price.Size = new System.Drawing.Size(93, 45);
            this.lb_sell_price.TabIndex = 7;
            this.lb_sell_price.Text = "السعر";
            this.lb_sell_price.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_sell_price
            // 
            this.tb_sell_price.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_sell_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sell_price.Location = new System.Drawing.Point(487, 153);
            this.tb_sell_price.Name = "tb_sell_price";
            this.tb_sell_price.Size = new System.Drawing.Size(211, 47);
            this.tb_sell_price.TabIndex = 9;
            this.tb_sell_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(350, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "الكمية";
            this.label3.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_sell_qt
            // 
            this.tb_sell_qt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_sell_qt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sell_qt.Location = new System.Drawing.Point(42, 145);
            this.tb_sell_qt.Name = "tb_sell_qt";
            this.tb_sell_qt.Size = new System.Drawing.Size(211, 47);
            this.tb_sell_qt.TabIndex = 9;
            this.tb_sell_qt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_sell_qt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Sales_Management_System.Properties.Resources.add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(388, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "أضافه";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FRM_add_sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_sell_qt);
            this.Controls.Add(this.tb_sell_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cust_name);
            this.Controls.Add(this.lb_sell_price);
            this.Controls.Add(this.lb_cust_name);
            this.Controls.Add(this.tb_sell_name);
            this.Controls.Add(this.lb_sell_name);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_add_sell";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_add_supp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_sell_name;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.TextBox tb_sell_name;
        private System.Windows.Forms.Label lb_cust_name;
        public System.Windows.Forms.TextBox tb_cust_name;
        private System.Windows.Forms.Label lb_sell_price;
        public System.Windows.Forms.TextBox tb_sell_price;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_sell_qt;
        public System.Windows.Forms.Button button1;
    }
}