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
    public partial class FRM_add_user: Form
    {
        //init
        //database
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        //table
        TB_Users tb_users = new TB_Users();
        PL.Frm_users frm_user = new PL.Frm_users();
        

        public int id;

        public FRM_add_user()
        {
            InitializeComponent();
        }

        private void lb_pagetitle_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog();
            Toas toas = new Toas();
            //check if add or edit
            if (tb_user_name.Text == "" || tb_user_pass.Text == "" || tb_user_role.Text == "")
            {
                dialog.Width = this.Width;
                dialog.lb_dialogm.Text = "أدخل البيانات كاملة";
                dialog.Show();
            }
            else
            {
                if (id == 0)
                {
                    //add
                    tb_users.User_name = tb_user_name.Text;
                    tb_users.User_role = tb_user_role.Text;
                    tb_users.User_pass = tb_user_pass.Text;
                    tb_users.User_state = "false";
                    db.TB_Users.Add(tb_users);
                    db.SaveChanges();
                    this.Close();
                    toas.lb_toasm.Text="تم اضافه مستخدم جديد";
                    toas.Show();
                    frm_user.dataGridView1.DataSource = db.TB_Users.ToList();
                    
                }
                else
                {
                    tb_users.User_name = tb_user_name.Text;
                    tb_users.User_role = tb_user_role.Text;
                    tb_users.User_pass = tb_user_pass.Text;
                    tb_users.ID = id;
                    db.Entry(tb_users).State = EntityState.Modified;
                    db.SaveChanges();
                    this.Close();
                    toas.lb_toasm.Text = "تم تعديل مورد ";
                    toas.Show();
                    frm_user.dataGridView1.DataSource = db.TB_Users.ToList();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_add_supp_Load(object sender, EventArgs e)
        {

        }
    }
}
