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
    public partial class FRM_add_pur: Form
    {
        //init
        //database
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        //table
        TB_Pur tb_pur = new TB_Pur();
        PL.Frm_supp frm_supp = new PL.Frm_supp();
        

        public int id;

        public FRM_add_pur()
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
            if (tb_cat_name.Text == "" || tb_supp_name.Text == "" || tb_pur_name.Text == "" || tb_pur_buy.Text == "" || tb_pur_sell.Text == "" || tb_pur_qt.Text == "")
            {
                dialog.Width = this.Width;
                dialog.lb_dialogm.Text = "ادخل بيانات كامله";
                dialog.Show();
            }
            else
            {
                if (id == 0)
                {
                    //add
                    tb_pur.Pur_name = tb_pur_name.Text;
                    tb_pur.Pur_cat = tb_cat_name.Text;
                    tb_pur.Pur_supp = tb_supp_name.Text;
                    tb_pur.Pur_type = tb_pur_type.Text;
                    tb_pur.Pur_det = tb_pur_details.Text;
                    tb_pur.Pur_buy = Convert.ToDouble(tb_pur_buy.Text);
                    tb_pur.Pur_sell = Convert.ToDouble(tb_pur_sell.Text);
                    tb_pur.Pur_qt = Convert.ToDouble(tb_pur_qt.Text);
                    tb_pur.Supp_id = Convert.ToInt32(tb_supp_id.Text);
                    tb_pur.Cat_id = Convert.ToInt32(tb_cat_id.Text);
                    tb_pur.Pur_tbuy = Convert.ToInt32(tb_pur_buy.Text) * Convert.ToInt32(tb_pur_qt.Text);
                    tb_pur.Pur_tsell = Convert.ToInt32(tb_pur_sell.Text) * Convert.ToInt32(tb_pur_qt.Text);
                    tb_pur.Pur_trevn = Convert.ToInt32(tb_pur_sell.Text) * Convert.ToInt32(tb_pur_qt.Text) - Convert.ToInt32(tb_pur_buy.Text) * Convert.ToInt32(tb_pur_qt.Text);
                    db.TB_Pur.Add(tb_pur);
                    db.SaveChanges();
                    this.Close();
                    toas.lb_toasm.Text="تم اضافه عملية شراء جديده";
                    toas.Show();
                    frm_supp.dataGridView1.DataSource = db.TB_Supp.ToList();
                    
                }
                else
                {
                    tb_pur.Pur_name = tb_pur_name.Text;
                    tb_pur.Pur_cat = tb_cat_name.Text;
                    tb_pur.Pur_supp = tb_supp_name.Text;
                    tb_pur.Pur_type = tb_pur_type.Text;
                    tb_pur.Pur_det = tb_pur_details.Text;
                    tb_pur.Pur_buy = Convert.ToDouble(tb_pur_buy.Text);
                    tb_pur.Pur_sell = Convert.ToDouble(tb_pur_sell.Text);
                    tb_pur.Pur_qt = Convert.ToDouble(tb_pur_qt.Text);
                    tb_pur.Pur_tbuy = Convert.ToInt32(tb_pur_buy.Text) * Convert.ToInt32(tb_pur_qt.Text);
                    tb_pur.Pur_tsell = Convert.ToInt32(tb_pur_sell.Text) * Convert.ToInt32(tb_pur_qt.Text);
                    tb_pur.Pur_trevn = Convert.ToInt32(tb_pur_sell.Text) * Convert.ToInt32(tb_pur_qt.Text) - Convert.ToInt32(tb_pur_buy.Text) * Convert.ToInt32(tb_pur_qt.Text);
                    tb_pur.ID = id;
                    db.Entry(tb_pur).State = EntityState.Modified;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
