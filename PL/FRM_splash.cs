using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Management_System.PL
{
    public partial class FRM_splash : Form
    {
        TB_Users tb_users = new TB_Users();
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        Main main = new Main();
        PL.FRM_login login = new PL.FRM_login();

        public FRM_splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_users = db.TB_Users.Where(x => x.User_state == "true").FirstOrDefault();
            if(tb_users != null)
            {
                main.lb_profilename.Text = tb_users.User_name;
                main.lb_role.Text = tb_users.User_role;
                main.Show();
            }
            else
            {
                login.Show();
            }
            this.Hide();
            timer1.Enabled = false;
        }

        
    }
}
