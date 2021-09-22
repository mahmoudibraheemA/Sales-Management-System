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
    public partial class Frm_cust : Form
    {
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        Dialog dialog = new Dialog();
        Toas toas = new Toas();
        TB_Cust tb_cust = new TB_Cust();
        int id;
        public Frm_cust()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_categeory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_sales_management_systemDataSet4.TB_Cust' table. You can move, or remove it, as needed.
            this.tB_CustTableAdapter.Fill(this.dB_sales_management_systemDataSet4.TB_Cust);
            
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FRM_add_cust frm_add_cust = new PL.FRM_add_cust();
            frm_add_cust.id = 0;
            frm_add_cust.btn_add.Text = "أضافه";
            frm_add_cust.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            dataGridView1.DataSource = db.TB_Cust.ToList();
        }

        private void btn_edititem_Click(object sender, EventArgs e)
        {
            PL.FRM_add_cust frm_add_cust = new PL.FRM_add_cust();
            Dialog dialog = new Dialog();
            Toas toas = new Toas();

            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                tb_cust = db.TB_Cust.Where(x => x.ID == id).FirstOrDefault();
                frm_add_cust.tb_cust_name.Text = tb_cust.Cust_name.ToString();
                frm_add_cust.tb_cust_email.Text = tb_cust.Cust_name.ToString();
                frm_add_cust.tb_cust_phone.Text = tb_cust.Cust_phine.ToString();
                frm_add_cust.id = id;
                frm_add_cust.btn_add.Text = "تعديل";
                frm_add_cust.Show();
            }
            catch
            {
                dialog.lb_dialogm.Text = "لا يوجد عميل محدد للتعديل";
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
                    tb_cust = db.TB_Cust.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_cust).State = EntityState.Deleted;
                    db.SaveChanges();
                    update_data();
                    toas.lb_toasm.Text = "تم حذف العميل";
                    toas.Show();
                }
                catch
                {
                    dialog.lb_dialogm.Text = "لا يوجد عميل محدد للحذف";
                    dialog.Show();
                }
                
            }

            
        }



        private void update_data()
        {
            dataGridView1.DataSource = db.TB_Cust.ToList();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var search = tb_search.Text;
            dataGridView1.DataSource = db.TB_Cust.Where(x => x.Cust_name.Contains(search) || x.Cust_phine.Contains(search) || x.Cust_email.Contains(search)).ToList();
        }
    }
}
