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
    public partial class Frm_supp : Form
    {
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        Dialog dialog = new Dialog();
        Toas toas = new Toas();
        TB_Supp tb_supp = new TB_Supp();
        int id;
        public Frm_supp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_categeory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_sales_management_systemDataSet1.TB_Supp' table. You can move, or remove it, as needed.
            this.tB_SuppTableAdapter.Fill(this.dB_sales_management_systemDataSet1.TB_Supp);
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FRM_add_supp frm_add = new PL.FRM_add_supp();
            frm_add.id = 0;
            frm_add.btn_add.Text = "أضافه";
            frm_add.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            dataGridView1.DataSource = db.TB_Supp.ToList();
        }

        private void btn_edititem_Click(object sender, EventArgs e)
        {
            PL.FRM_add_supp frm_add_supp = new PL.FRM_add_supp();
            Dialog dialog = new Dialog();
            Toas toas = new Toas();

            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                tb_supp = db.TB_Supp.Where(x => x.ID == id).FirstOrDefault();
                frm_add_supp.tb_supp_name.Text = tb_supp.Supp_name.ToString();
                frm_add_supp.tb_supp_email.Text = tb_supp.Supp_name.ToString();
                frm_add_supp.tb_supp_phone.Text = tb_supp.Supp_phone.ToString();
                frm_add_supp.id = id;
                frm_add_supp.btn_add.Text = "تعديل";
                frm_add_supp.Show();
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
                    tb_supp = db.TB_Supp.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_supp).State = EntityState.Deleted;
                    db.SaveChanges();
                    update_data();
                    toas.lb_toasm.Text = "تم حذف المورد";
                    toas.Show();
                }
                catch
                {
                    dialog.lb_dialogm.Text = "لا يوجد مورد محدد للحذف";
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
            dataGridView1.DataSource = db.TB_Supp.Where(x => x.Supp_name.Contains(search) || x.Supp_phone.Contains(search) || x.Supp_email.Contains(search)).ToList();
        }
    }
}
