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
    public partial class FRM_add_sell: Form
    {
        //init
        //database
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        //table
        TB_Sell tb_sell = new TB_Sell();
        PL.Frm_sell frm_sell = new PL.Frm_sell();
        

        public int id;

        public FRM_add_sell()
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
            if (tb_sell_name.Text == "" || tb_cust_name.Text == "" || tb_sell_price.Text == "" || tb_sell_qt.Text == "")
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
                    tb_sell.Sell_namme = tb_sell_name.Text;
                    tb_sell.Sell_cust = tb_cust_name.Text;
                    tb_sell.Sell_price =Convert.ToDouble(tb_sell_price.Text);
                    tb_sell.Sell_qt = Convert.ToDouble(tb_sell_qt.Text);
                    tb_sell.Sell_tprice = Convert.ToDouble(tb_sell_price.Text) * Convert.ToDouble(tb_sell_qt.Text);
                    tb_sell.date = DateTime.Now;
                    db.TB_Sell.Add(tb_sell);
                    db.SaveChanges();
                    this.Close();
                    toas.lb_toasm.Text="تم اضافه عملية بيع جديده";
                    toas.Show();
                    frm_sell.dataGridView1.DataSource = db.TB_Sell.ToList();
                    
                }
                else
                {
                    tb_sell.Sell_namme = tb_sell_name.Text;
                    tb_sell.Sell_cust = tb_cust_name.Text;
                    tb_sell.Sell_price = Convert.ToDouble(tb_sell_price.Text);
                    tb_sell.Sell_qt = Convert.ToDouble(tb_sell_qt.Text);
                    tb_sell.Sell_tprice = Convert.ToDouble(tb_sell_price.Text) * Convert.ToDouble(tb_sell_qt.Text);
                    tb_sell.date = DateTime.Now;
                    tb_sell.ID = id;
                    db.Entry(tb_sell).State = EntityState.Modified;
                    db.SaveChanges();
                    this.Close();
                    toas.lb_toasm.Text = "تم تعديل عملية بيع ";
                    toas.Show();
                    frm_sell.dataGridView1.DataSource = db.TB_Sell.ToList();
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
