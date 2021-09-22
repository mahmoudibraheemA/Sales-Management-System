using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Sales_Management_System
{
    public partial class Main : Form
    {
        PL.Frm_categeory frm_Categeory = new PL.Frm_categeory();
        PL.Frm_supp frm_supp = new PL.Frm_supp();
        PL.Frm_homepage frm_Homepage = new PL.Frm_homepage();
        PL.Frm_pur frm_pur = new PL.Frm_pur();
        PL.Frm_cust frm_cust = new PL.Frm_cust();
        PL.Frm_sell frm_sell = new PL.Frm_sell();
        PL.FRM_reports frm_reports = new PL.FRM_reports();
        PL.Frm_users frm_users = new PL.Frm_users();
        PL.FRM_settings frm_settings = new PL.FRM_settings();
        TB_Users tb_users = new TB_Users();
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();

        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //close the app
        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //minimize the app
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //maximize app
        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        // collapse navbar
        private void button5_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width == 257)
            {
                pn_navbar.Width = 45;
                pn_profile.Visible = false;
                pn_navbarprofile.Height = 150;
            }
            else
            {
                pn_navbar.Width = 257;
                pn_profile.Visible = true;
                pn_navbarprofile.Height = 208;
            }
        }

        // load home
        private void button6_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_Homepage.pn_homepage);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_Homepage.pn_homepage);
            if(lb_role.Text == "admin")
            {
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
            }
            else
            {
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_Categeory.pn_cat);
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            frm_Categeory.dataGridView1.DataSource = db.TB_cat.ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_supp.pn_cat);
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            frm_supp.dataGridView1.DataSource = db.TB_Supp.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_pur.pn_cat);
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            frm_pur.dataGridView1.DataSource = db.TB_Pur.ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_cust.pn_cat);
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            frm_cust.dataGridView1.DataSource = db.TB_Cust.ToList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_sell.pn_cat);
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            frm_sell.dataGridView1.DataSource = db.TB_Sell.ToList();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_reports.pn_reports);
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_users.pn_cat);
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            frm_users.dataGridView1.DataSource = db.TB_Users.ToList();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            pn_container.Controls.Clear();
            pn_container.Controls.Add(frm_settings.panel1);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            PL.FRM_login login = new PL.FRM_login();
            tb_users = db.TB_Users.Where(x => x.User_state == "true").FirstOrDefault();
            tb_users.User_state = "false";
            db.Entry(tb_users).State = EntityState.Modified;
            db.SaveChanges();
            this.Enabled = false;
            login.Show();
            this.Hide();
        }
    }
}
