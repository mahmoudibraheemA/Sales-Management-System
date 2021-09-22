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
using System.Configuration;

namespace Sales_Management_System.PL
{
    public partial class FRM_settings : Form
    {
        //init
        //database
        DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();
        //table
        TB_cat tb_cat = new TB_cat();
        BL.Methods methods = new BL.Methods();
        PL.Frm_categeory frm_cat = new PL.Frm_categeory();
        

        public int id;

        public FRM_settings()
        {
            InitializeComponent();
        }

        

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            const string qu = "\"";
            var svn = server_name.Text;
            var connstr = @"metadata=res://*/SMSM.csdl|res://*/SMSM.ssdl|res://*/SMSM.msl;provider=System.Data.SqlClient;provider connection string=" + qu + ";data source=" + svn + ";initial catalog=DB_sales_management_system;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" + qu + ";";

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["DB_sales_management_systemEntities"].ConnectionString = connstr;
            config.Save();
            ConfigurationManager.RefreshSection("connectionString");
            var connstrupdated = config.ConnectionStrings.ConnectionStrings["DB_sales_management_systemEntities"].ConnectionString;
            MessageBox.Show(connstrupdated);
            Application.Restart();
        }

        
    }
}
