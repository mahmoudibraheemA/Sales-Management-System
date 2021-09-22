
namespace Sales_Management_System.PL
{
    partial class FRM_add
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
            this.lb_pagetitle = new System.Windows.Forms.Label();
            this.tb_itemname = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.picitemcover = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picitemcover)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_pagetitle
            // 
            this.lb_pagetitle.AutoSize = true;
            this.lb_pagetitle.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pagetitle.ForeColor = System.Drawing.Color.Black;
            this.lb_pagetitle.Location = new System.Drawing.Point(304, 90);
            this.lb_pagetitle.Name = "lb_pagetitle";
            this.lb_pagetitle.Size = new System.Drawing.Size(163, 45);
            this.lb_pagetitle.TabIndex = 7;
            this.lb_pagetitle.Text = "اسم الصنف";
            this.lb_pagetitle.Click += new System.EventHandler(this.lb_pagetitle_Click);
            // 
            // tb_itemname
            // 
            this.tb_itemname.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_itemname.Location = new System.Drawing.Point(280, 161);
            this.tb_itemname.Name = "tb_itemname";
            this.tb_itemname.Size = new System.Drawing.Size(211, 47);
            this.tb_itemname.TabIndex = 9;
            this.tb_itemname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = global::Sales_Management_System.Properties.Resources.add;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(667, 379);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(121, 59);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "أضافه";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // picitemcover
            // 
            this.picitemcover.ErrorImage = null;
            this.picitemcover.Image = global::Sales_Management_System.Properties.Resources.Items3;
            this.picitemcover.Location = new System.Drawing.Point(280, 234);
            this.picitemcover.Name = "picitemcover";
            this.picitemcover.Size = new System.Drawing.Size(211, 131);
            this.picitemcover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picitemcover.TabIndex = 10;
            this.picitemcover.TabStop = false;
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
            // FRM_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.picitemcover);
            this.Controls.Add(this.tb_itemname);
            this.Controls.Add(this.lb_pagetitle);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_add";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picitemcover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_pagetitle;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.PictureBox picitemcover;
        public System.Windows.Forms.TextBox tb_itemname;
    }
}