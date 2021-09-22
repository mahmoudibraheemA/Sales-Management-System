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
    public partial class Frm_homepage : Form
    {
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        public Frm_homepage()
        {
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
            InitializeComponent();
            List<TB_cat> list_cat = db.TB_cat.ToList();
            List<TB_Sell> list_sell = db.TB_Sell.ToList();
            List<TB_Supp> list_supp = db.TB_Supp.ToList();
            List<TB_Pur> list_pur = db.TB_Pur.ToList();
            List<TB_Cust> list_cust = db.TB_Cust.ToList();
            lb_cat_num.Text = list_cat.Count.ToString();
            lb_sell_num.Text = list_sell.Count.ToString();
            lb_supp_num.Text = list_supp.Count.ToString();
            lb_pur_num.Text = list_pur.Count.ToString();
            lb_cust_num.Text = list_cust.Count.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PL.FRM_add_pur frm_add_pur = new PL.FRM_add_pur();
            frm_add_pur.id = 0;
            frm_add_pur.btn_add.Text = "أضافه";
            frm_add_pur.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PL.FRM_add_sell frm_add_sell = new PL.FRM_add_sell();
            frm_add_sell.id = 0;
            frm_add_sell.btn_add.Text = "أضافه";
            frm_add_sell.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.FRM_add_cust frm_add_cust = new PL.FRM_add_cust();
            frm_add_cust.id = 0;
            frm_add_cust.btn_add.Text = "أضافه";
            frm_add_cust.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.FRM_add_supp frm_add = new PL.FRM_add_supp();
            frm_add.id = 0;
            frm_add.btn_add.Text = "أضافه";
            frm_add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FRM_add frm_add = new PL.FRM_add();
            frm_add.id = 0;
            frm_add.btn_add.Text = "أضافه";
            frm_add.Show();
        }

        
    }
}
