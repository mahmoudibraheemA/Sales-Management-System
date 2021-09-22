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
    public partial class FRM_login: Form
    {
        //init
        //database
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        //table
        TB_Users tb_users = new TB_Users();
        Main main = new Main();
        

        public int id;

        public FRM_login()
        {
            InitializeComponent();
        }

        private void lb_pagetitle_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog();
            if(tb_user_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.lb_dialogm.Text = "الاسم و كلمة المرور مطلوبين";
                dialog.Show();
            }
            else
            {
                tb_users = db.TB_Users.Where(x => x.User_name == tb_user_name.Text && x.User_pass == tb_user_pass.Text).FirstOrDefault();
                if(tb_users != null)
                {
                    tb_users.User_state = "true";
                    db.Entry(tb_users).State= EntityState.Modified;
                    main.lb_profilename.Text = tb_users.User_name;
                    main.lb_role.Text = tb_users.User_role;
                    main.Enabled = true;
                    db.SaveChanges();
                    main.Show();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("فشل الدخول");
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
