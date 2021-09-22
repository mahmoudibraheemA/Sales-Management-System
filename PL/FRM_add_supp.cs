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
    public partial class FRM_add_supp: Form
    {
        //init
        //database
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        //table
        TB_Supp tb_supp = new TB_Supp();
        PL.Frm_supp frm_supp = new PL.Frm_supp();
        

        public int id;

        public FRM_add_supp()
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
            if (tb_supp_name.Text == "")
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
                    tb_supp.Supp_name = tb_supp_name.Text;
                    tb_supp.Supp_email = tb_supp_email.Text;
                    tb_supp.Supp_phone = tb_supp_phone.Text;
                    db.TB_Supp.Add(tb_supp);
                    db.SaveChanges();
                    this.Close();
                    toas.lb_toasm.Text="تم اضافه مورد جديد";
                    toas.Show();
                    frm_supp.dataGridView1.DataSource = db.TB_Supp.ToList();
                    
                }
                else
                {
                    tb_supp.Supp_name = tb_supp_name.Text;
                    tb_supp.Supp_email = tb_supp_email.Text;
                    tb_supp.Supp_phone = tb_supp_phone.Text;
                    tb_supp.ID = id;
                    db.Entry(tb_supp).State = EntityState.Modified;
                    db.SaveChanges();
                    this.Close();
                    toas.lb_toasm.Text = "تم تعديل مورد ";
                    toas.Show();
                    frm_supp.dataGridView1.DataSource = db.TB_Supp.ToList();
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
