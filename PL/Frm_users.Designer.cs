
namespace Sales_Management_System.PL
{
    partial class Frm_users
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
            this.pn_cat = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userroleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_sales_management_systemDataSet8 = new Sales_Management_System.DB_sales_management_systemDataSet8();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_deleteitem = new System.Windows.Forms.Button();
            this.btn_edititem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tB_UsersTableAdapter = new Sales_Management_System.DB_sales_management_systemDataSet8TableAdapters.TB_UsersTableAdapter();
            this.pn_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_sales_management_systemDataSet8)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.dataGridView1);
            this.pn_cat.Controls.Add(this.panel1);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(1023, 621);
            this.pn_cat.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.userroleDataGridViewTextBoxColumn,
            this.userstateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBUsersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1023, 521);
            this.dataGridView1.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "User_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "User_name";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // userroleDataGridViewTextBoxColumn
            // 
            this.userroleDataGridViewTextBoxColumn.DataPropertyName = "User_role";
            this.userroleDataGridViewTextBoxColumn.HeaderText = "User_role";
            this.userroleDataGridViewTextBoxColumn.Name = "userroleDataGridViewTextBoxColumn";
            // 
            // userstateDataGridViewTextBoxColumn
            // 
            this.userstateDataGridViewTextBoxColumn.DataPropertyName = "User_state";
            this.userstateDataGridViewTextBoxColumn.HeaderText = "User_state";
            this.userstateDataGridViewTextBoxColumn.Name = "userstateDataGridViewTextBoxColumn";
            // 
            // tBUsersBindingSource
            // 
            this.tBUsersBindingSource.DataMember = "TB_Users";
            this.tBUsersBindingSource.DataSource = this.dB_sales_management_systemDataSet8;
            // 
            // dB_sales_management_systemDataSet8
            // 
            this.dB_sales_management_systemDataSet8.DataSetName = "DB_sales_management_systemDataSet8";
            this.dB_sales_management_systemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_deleteitem);
            this.panel1.Controls.Add(this.btn_edititem);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 100);
            this.panel1.TabIndex = 2;
            // 
            // tb_search
            // 
            this.tb_search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(791, 28);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(211, 47);
            this.tb_search.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = global::Sales_Management_System.Properties.Resources.search1;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(738, 28);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(47, 49);
            this.btn_search.TabIndex = 4;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = global::Sales_Management_System.Properties.Resources.refresh;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(393, 20);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(121, 59);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "تحديث";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_deleteitem
            // 
            this.btn_deleteitem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_deleteitem.BackColor = System.Drawing.Color.White;
            this.btn_deleteitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteitem.Image = global::Sales_Management_System.Properties.Resources.delete;
            this.btn_deleteitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteitem.Location = new System.Drawing.Point(139, 20);
            this.btn_deleteitem.Name = "btn_deleteitem";
            this.btn_deleteitem.Size = new System.Drawing.Size(121, 59);
            this.btn_deleteitem.TabIndex = 3;
            this.btn_deleteitem.Text = "حذف";
            this.btn_deleteitem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteitem.UseVisualStyleBackColor = false;
            this.btn_deleteitem.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_edititem
            // 
            this.btn_edititem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_edititem.BackColor = System.Drawing.Color.White;
            this.btn_edititem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edititem.Image = global::Sales_Management_System.Properties.Resources.edit;
            this.btn_edititem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edititem.Location = new System.Drawing.Point(266, 20);
            this.btn_edititem.Name = "btn_edititem";
            this.btn_edititem.Size = new System.Drawing.Size(121, 59);
            this.btn_edititem.TabIndex = 2;
            this.btn_edititem.Text = "تعديل";
            this.btn_edititem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edititem.UseVisualStyleBackColor = false;
            this.btn_edititem.Click += new System.EventHandler(this.btn_edititem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Sales_Management_System.Properties.Resources.add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "أضافه";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tB_UsersTableAdapter
            // 
            this.tB_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 621);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_users";
            this.Text = "Frm_categeory";
            this.Load += new System.EventHandler(this.Frm_categeory_Load);
            this.pn_cat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_sales_management_systemDataSet8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_deleteitem;
        private System.Windows.Forms.Button btn_edititem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel pn_cat;
        private DB_sales_management_systemDataSet8 dB_sales_management_systemDataSet8;
        private System.Windows.Forms.BindingSource tBUsersBindingSource;
        private DB_sales_management_systemDataSet8TableAdapters.TB_UsersTableAdapter tB_UsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userroleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userstateDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}