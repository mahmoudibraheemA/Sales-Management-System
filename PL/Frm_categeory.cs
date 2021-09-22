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
    public partial class Frm_categeory : Form
    {
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        BL.Methods methods = new BL.Methods();
        Dialog dialog = new Dialog();
        Toas toas = new Toas();
        TB_cat tb_cat = new TB_cat();
        int id;
        public Frm_categeory()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_categeory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_sales_management_systemDataSet.TB_cat' table. You can move, or remove it, as needed.
            this.tB_catTableAdapter.Fill(this.dB_sales_management_systemDataSet.TB_cat);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FRM_add frm_add = new PL.FRM_add();
            frm_add.id = 0;
            frm_add.btn_add.Text = "أضافه";
            frm_add.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            dataGridView1.DataSource = db.TB_cat.ToList();
        }

        private void btn_edititem_Click(object sender, EventArgs e)
        {
            PL.FRM_add frm_add = new PL.FRM_add();
            Dialog dialog = new Dialog();
            Toas toas = new Toas();

            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                tb_cat = db.TB_cat.Where(x => x.ID == id).FirstOrDefault();
                frm_add.tb_itemname.Text = tb_cat.Cat_name.ToString();
                methods.by = tb_cat.Cat_cover;
                frm_add.picitemcover.Image = Image.FromStream(methods.convert_image());
                frm_add.id = id;
                frm_add.btn_add.Text = "تعديل";
                frm_add.Show();
            }
            catch
            {
                dialog.lb_dialogm.Text = "لا يوجد صنف محدد للتعديل";
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
                    tb_cat = db.TB_cat.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_cat).State = EntityState.Deleted;
                    db.SaveChanges();
                    update_data();
                    toas.lb_toasm.Text = "تم حذف الصنف";
                    toas.Show();
                }
                catch
                {
                    dialog.lb_dialogm.Text = "لا يوجد صنف محدد للحذف";
                    dialog.Show();
                }
                
            }

            
        }

        

        private void update_data()
        {
            dataGridView1.DataSource = db.TB_cat.ToList();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var search = tb_search.Text;
            dataGridView1.DataSource = db.TB_cat.Where(x => x.Cat_name.Contains(search)).ToList();
        }
    }
}
