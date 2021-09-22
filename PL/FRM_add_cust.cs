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
    public partial class FRM_add_cust: Form
    {
        //init
        //database
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        //table
        TB_Cust tb_cust = new TB_Cust();
        PL.Frm_cust frm_cust = new PL.Frm_cust();
        

        public int id;

        public FRM_add_cust()
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
            if (tb_cust_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.lb_dialogm.Text = "اسم الصنف مطلوب";
                dialog.Show();
            }
            else
            {
                if (id == 0)
                {
                    //add
                    tb_cust.Cust_name = tb_cust_name.Text;
                    tb_cust.Cust_email = tb_cust_email.Text;
                    tb_cust.Cust_phine = tb_cust_phone.Text;
                    db.TB_Cust.Add(tb_cust);
                    db.SaveChanges();
                    this.Close();
                    toas.lb_toasm.Text="تم اضافه عميل جديد";
                    toas.Show();
                    frm_cust.dataGridView1.DataSource = db.TB_Supp.ToList();
                    
                }
                else
                {
                    tb_cust.Cust_name = tb_cust_name.Text;
                    tb_cust.Cust_email = tb_cust_email.Text;
                    tb_cust.Cust_phine = tb_cust_phone.Text;
                    tb_cust.ID = id;
                    db.Entry(tb_cust).State = EntityState.Modified;
                    db.SaveChanges();
                    this.Close();
                    toas.lb_toasm.Text = "تم تعديل مورد ";
                    toas.Show();
                    frm_cust.dataGridView1.DataSource = db.TB_Supp.ToList();
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
