
namespace Sales_Management_System.PL
{
    partial class Frm_pur
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
            this.catidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purcatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pursuppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purbuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pursellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purqtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purtbuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purtsellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purtrevnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBPurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_sales_management_systemDataSet3 = new Sales_Management_System.DB_sales_management_systemDataSet3();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_deleteitem = new System.Windows.Forms.Button();
            this.btn_edititem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tB_PurTableAdapter = new Sales_Management_System.DB_sales_management_systemDataSet3TableAdapters.TB_PurTableAdapter();
            this.pn_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_sales_management_systemDataSet3)).BeginInit();
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
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.catidDataGridViewTextBoxColumn,
            this.suppidDataGridViewTextBoxColumn,
            this.purnameDataGridViewTextBoxColumn,
            this.purtypeDataGridViewTextBoxColumn,
            this.purcatDataGridViewTextBoxColumn,
            this.pursuppDataGridViewTextBoxColumn,
            this.purdetDataGridViewTextBoxColumn,
            this.purbuyDataGridViewTextBoxColumn,
            this.pursellDataGridViewTextBoxColumn,
            this.purqtDataGridViewTextBoxColumn,
            this.purtbuyDataGridViewTextBoxColumn,
            this.purtsellDataGridViewTextBoxColumn,
            this.purtrevnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBPurBindingSource;
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
            // catidDataGridViewTextBoxColumn
            // 
            this.catidDataGridViewTextBoxColumn.DataPropertyName = "Cat_id";
            this.catidDataGridViewTextBoxColumn.HeaderText = "Cat_id";
            this.catidDataGridViewTextBoxColumn.Name = "catidDataGridViewTextBoxColumn";
            // 
            // suppidDataGridViewTextBoxColumn
            // 
            this.suppidDataGridViewTextBoxColumn.DataPropertyName = "Supp_id";
            this.suppidDataGridViewTextBoxColumn.HeaderText = "Supp_id";
            this.suppidDataGridViewTextBoxColumn.Name = "suppidDataGridViewTextBoxColumn";
            // 
            // purnameDataGridViewTextBoxColumn
            // 
            this.purnameDataGridViewTextBoxColumn.DataPropertyName = "Pur_name";
            this.purnameDataGridViewTextBoxColumn.HeaderText = "Pur_name";
            this.purnameDataGridViewTextBoxColumn.Name = "purnameDataGridViewTextBoxColumn";
            // 
            // purtypeDataGridViewTextBoxColumn
            // 
            this.purtypeDataGridViewTextBoxColumn.DataPropertyName = "Pur_type";
            this.purtypeDataGridViewTextBoxColumn.HeaderText = "Pur_type";
            this.purtypeDataGridViewTextBoxColumn.Name = "purtypeDataGridViewTextBoxColumn";
            // 
            // purcatDataGridViewTextBoxColumn
            // 
            this.purcatDataGridViewTextBoxColumn.DataPropertyName = "Pur_cat";
            this.purcatDataGridViewTextBoxColumn.HeaderText = "Pur_cat";
            this.purcatDataGridViewTextBoxColumn.Name = "purcatDataGridViewTextBoxColumn";
            // 
            // pursuppDataGridViewTextBoxColumn
            // 
            this.pursuppDataGridViewTextBoxColumn.DataPropertyName = "Pur_supp";
            this.pursuppDataGridViewTextBoxColumn.HeaderText = "Pur_supp";
            this.pursuppDataGridViewTextBoxColumn.Name = "pursuppDataGridViewTextBoxColumn";
            // 
            // purdetDataGridViewTextBoxColumn
            // 
            this.purdetDataGridViewTextBoxColumn.DataPropertyName = "Pur_det";
            this.purdetDataGridViewTextBoxColumn.HeaderText = "Pur_det";
            this.purdetDataGridViewTextBoxColumn.Name = "purdetDataGridViewTextBoxColumn";
            // 
            // purbuyDataGridViewTextBoxColumn
            // 
            this.purbuyDataGridViewTextBoxColumn.DataPropertyName = "Pur_buy";
            this.purbuyDataGridViewTextBoxColumn.HeaderText = "Pur_buy";
            this.purbuyDataGridViewTextBoxColumn.Name = "purbuyDataGridViewTextBoxColumn";
            // 
            // pursellDataGridViewTextBoxColumn
            // 
            this.pursellDataGridViewTextBoxColumn.DataPropertyName = "Pur_sell";
            this.pursellDataGridViewTextBoxColumn.HeaderText = "Pur_sell";
            this.pursellDataGridViewTextBoxColumn.Name = "pursellDataGridViewTextBoxColumn";
            // 
            // purqtDataGridViewTextBoxColumn
            // 
            this.purqtDataGridViewTextBoxColumn.DataPropertyName = "Pur_qt";
            this.purqtDataGridViewTextBoxColumn.HeaderText = "Pur_qt";
            this.purqtDataGridViewTextBoxColumn.Name = "purqtDataGridViewTextBoxColumn";
            // 
            // purtbuyDataGridViewTextBoxColumn
            // 
            this.purtbuyDataGridViewTextBoxColumn.DataPropertyName = "Pur_tbuy";
            this.purtbuyDataGridViewTextBoxColumn.HeaderText = "Pur_tbuy";
            this.purtbuyDataGridViewTextBoxColumn.Name = "purtbuyDataGridViewTextBoxColumn";
            // 
            // purtsellDataGridViewTextBoxColumn
            // 
            this.purtsellDataGridViewTextBoxColumn.DataPropertyName = "Pur_tsell";
            this.purtsellDataGridViewTextBoxColumn.HeaderText = "Pur_tsell";
            this.purtsellDataGridViewTextBoxColumn.Name = "purtsellDataGridViewTextBoxColumn";
            // 
            // purtrevnDataGridViewTextBoxColumn
            // 
            this.purtrevnDataGridViewTextBoxColumn.DataPropertyName = "Pur_trevn";
            this.purtrevnDataGridViewTextBoxColumn.HeaderText = "Pur_trevn";
            this.purtrevnDataGridViewTextBoxColumn.Name = "purtrevnDataGridViewTextBoxColumn";
            // 
            // tBPurBindingSource
            // 
            this.tBPurBindingSource.DataMember = "TB_Pur";
            this.tBPurBindingSource.DataSource = this.dB_sales_management_systemDataSet3;
            // 
            // dB_sales_management_systemDataSet3
            // 
            this.dB_sales_management_systemDataSet3.DataSetName = "DB_sales_management_systemDataSet3";
            this.dB_sales_management_systemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tB_PurTableAdapter
            // 
            this.tB_PurTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_pur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 621);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_pur";
            this.Text = "Frm_categeory";
            this.Load += new System.EventHandler(this.Frm_categeory_Load);
            this.pn_cat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_sales_management_systemDataSet3)).EndInit();
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
        private DB_sales_management_systemDataSet3 dB_sales_management_systemDataSet3;
        private System.Windows.Forms.BindingSource tBPurBindingSource;
        private DB_sales_management_systemDataSet3TableAdapters.TB_PurTableAdapter tB_PurTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purcatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pursuppDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purbuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pursellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purqtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purtbuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purtsellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purtrevnDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}