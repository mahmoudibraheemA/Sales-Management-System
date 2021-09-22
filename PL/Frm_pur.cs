using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales_Management_System.EPL;

namespace Sales_Management_System.PL
{
    public partial class Frm_pur: Form
    {
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        Dialog dialog = new Dialog();
        Toas toas = new Toas();
        TB_Pur tb_pur = new TB_Pur();
        int id;
        public Frm_pur()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_categeory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_sales_management_systemDataSet3.TB_Pur' table. You can move, or remove it, as needed.
            this.tB_PurTableAdapter.Fill(this.dB_sales_management_systemDataSet3.TB_Pur);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FRM_add_pur frm_add_pur = new PL.FRM_add_pur();
            frm_add_pur.id = 0;
            frm_add_pur.btn_add.Text = "أضافه";
            frm_add_pur.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            dataGridView1.DataSource = db.TB_Pur.ToList();
        }

        private void btn_edititem_Click(object sender, EventArgs e)
        {
            PL.FRM_add_pur frm_add_pur = new PL.FRM_add_pur();
            Dialog dialog = new Dialog();
            Toas toas = new Toas();

            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                tb_pur = db.TB_Pur.Where(x => x.ID == id).FirstOrDefault();
                frm_add_pur. tb_pur_name.Text = tb_pur.Pur_name.ToString();
                frm_add_pur.tb_cat_name.Text = tb_pur.Pur_cat.ToString();
                frm_add_pur.tb_supp_name.Text = tb_pur.Pur_supp.ToString();
                frm_add_pur.tb_pur_type.Text = tb_pur.Pur_type.ToString();
                frm_add_pur.tb_pur_details.Text = tb_pur.Pur_det.ToString();
                frm_add_pur.tb_pur_buy.Text = tb_pur.Pur_buy.ToString();
                frm_add_pur.tb_pur_sell.Text =tb_pur.Pur_sell.ToString();
                frm_add_pur.tb_pur_qt.Text = tb_pur.Pur_qt.ToString();
                frm_add_pur.tb_cat_id.Text = tb_pur.Cat_id.ToString();
                frm_add_pur.tb_supp_id.Text = tb_pur.Supp_id.ToString();
                frm_add_pur.id = id;
                frm_add_pur.btn_add.Text = "تعديل";
                frm_add_pur.Show();
            }
            catch
            {
                dialog.lb_dialogm.Text = "لا يوجد مورد محدد للتعديل";
                dialog.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            var res = MessageBox.Show("هل انت متأكد من هذه العمليه", "عملية حذف", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                Dialog dialog = new Dialog();
                Toas toas = new Toas();

                try
                {
                    // to pass the id of the selected item
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    tb_pur = db.TB_Pur.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_pur).State = EntityState.Deleted;
                    db.SaveChanges();
                    update_data();
                    toas.lb_toasm.Text = "تم حذف عملية الشراء";
                    toas.Show();
                }
                catch
                {
                    dialog.lb_dialogm.Text = "لا يوجد عملية شراء محدده للحذف";
                    dialog.Show();
                }
                
            }

            
        }

        

        private void update_data()
        {
            dataGridView1.DataSource = db.TB_Supp.ToList();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var search = tb_search.Text;
            dataGridView1.DataSource = db.TB_Pur.Where(x => x.Pur_supp.Contains(search) || x.Pur_name.Contains(search) || x.Pur_cat.Contains(search)).ToList();
        }
    }
}
