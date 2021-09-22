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
    public partial class Frm_sell: Form
    {
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        Dialog dialog = new Dialog();
        Toas toas = new Toas();
        TB_Sell tb_sell = new TB_Sell();
        int id;
        public Frm_sell()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_categeory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_sales_management_systemDataSet5.TB_Sell' table. You can move, or remove it, as needed.
            this.tB_SellTableAdapter.Fill(this.dB_sales_management_systemDataSet5.TB_Sell);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FRM_add_sell frm_add_sell = new PL.FRM_add_sell();
            frm_add_sell.id = 0;
            frm_add_sell.btn_add.Text = "أضافه";
            frm_add_sell.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            dataGridView1.DataSource = db.TB_Sell.ToList();
        }

        private void btn_edititem_Click(object sender, EventArgs e)
        {
            PL.FRM_add_sell frm_add_sell = new PL.FRM_add_sell();
            Dialog dialog = new Dialog();
            Toas toas = new Toas();

            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                tb_sell = db.TB_Sell.Where(x => x.ID == id).FirstOrDefault();
                frm_add_sell.tb_sell_name.Text = tb_sell.Sell_namme.ToString();
                frm_add_sell.tb_cust_name.Text = tb_sell.Sell_cust.ToString();
                frm_add_sell.tb_sell_price.Text = tb_sell.Sell_price.ToString();
                frm_add_sell.tb_sell_qt.Text = tb_sell.Sell_qt.ToString();
                frm_add_sell.id = id;
                frm_add_sell.btn_add.Text = "تعديل";
                frm_add_sell.Show();
            }
            catch
            {
                dialog.lb_dialogm.Text = "لا يوجد عملية بيع محدده للتعديل";
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
                    tb_sell = db.TB_Sell.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_sell).State = EntityState.Deleted;
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
            dataGridView1.DataSource = db.TB_Sell.ToList();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var search = tb_search.Text;
            dataGridView1.DataSource = db.TB_Sell.Where(x => x.Sell_namme.Contains(search) || x.Sell_cust.Contains(search)).ToList();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
