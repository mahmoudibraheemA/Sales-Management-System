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
        TB_cat tb_cat = new TB_cat();
        BL.Methods methods = new BL.Methods();
        PL.Frm_categeory frm_cat = new PL.Frm_categeory();
        

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
            if (tb_itemname.Text == "")
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
                    picitemcover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.Cat_name = tb_itemname.Text;
                    tb_cat.Cat_cover = methods.convert_byte();
                    db.TB_cat.Add(tb_cat);
                    db.SaveChanges();
                    this.Close();
                    toas.lb_toasm.Text="تم اضافه صنف جديد";
                    toas.Show();
                    frm_cat.dataGridView1.DataSource = db.TB_cat.ToList();
                    
                }
                else
                {
                    picitemcover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.Cat_name = tb_itemname.Text;
                    tb_cat.ID = id;
                    tb_cat.Cat_cover = methods.convert_byte();
                    db.Entry(tb_cat).State = EntityState.Modified;
                    db.SaveChanges();
                    this.Close();
                    toas.lb_toasm.Text = "تم تعديل صنف جديد";
                    toas.Show();
                    frm_cat.dataGridView1.DataSource = db.TB_cat.ToList();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
