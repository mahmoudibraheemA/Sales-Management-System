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
    public partial class Frm_users: Form
    {
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        Dialog dialog = new Dialog();
        Toas toas = new Toas();
        TB_Users tb_users = new TB_Users();
        int id;
        public Frm_users()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_categeory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_sales_management_systemDataSet8.TB_Users' table. You can move, or remove it, as needed.
            this.tB_UsersTableAdapter.Fill(this.dB_sales_management_systemDataSet8.TB_Users);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FRM_add_user frm_add_user = new PL.FRM_add_user();
            frm_add_user.id = 0;
            frm_add_user.btn_add.Text = "أضافه";
            frm_add_user.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            dataGridView1.DataSource = db.TB_Users.ToList();
        }

        private void btn_edititem_Click(object sender, EventArgs e)
        {
            PL.FRM_add_user frm_add_user = new PL.FRM_add_user();
            Dialog dialog = new Dialog();
            Toas toas = new Toas();

            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                tb_users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                frm_add_user. tb_user_name.Text = tb_users.User_name.ToString();
                frm_add_user.tb_user_pass.Text = tb_users.User_pass.ToString();
                frm_add_user.tb_user_role.Text = tb_users.User_role.ToString();
                frm_add_user.id = id;
                frm_add_user.btn_add.Text = "تعديل";
                frm_add_user.Show();
            }
            catch
            {
                dialog.lb_dialogm.Text = "لا يوجد مستخدم محدد للتعديل";
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
                    tb_users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_users).State = EntityState.Deleted;
                    db.SaveChanges();
                    update_data();
                    toas.lb_toasm.Text = "تم حذف المستخدم";
                    toas.Show();
                }
                catch
                {
                    dialog.lb_dialogm.Text = "لا يوجد مستخدم محدد للحذف";
                    dialog.Show();
                }
                
            }

            
        }

        

        private void update_data()
        {
            dataGridView1.DataSource = db.TB_Users.ToList();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var search = tb_search.Text;
            dataGridView1.DataSource = db.TB_Users.Where(x => x.User_name.Contains(search) || x.User_role.Contains(search) || x.User_state.Contains(search)).ToList();
        }
    }
}
