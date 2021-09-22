using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;





namespace Sales_Management_System.PL
{
    public partial class FRM_RV : Form
    {
        public FRM_RV()
        {
            InitializeComponent();
        }

        private void FRM_RV_Load(object sender, EventArgs e)
        {
            DB_sales_management_systemEntities db = new DB_sales_management_systemEntities();

            this.reportViewer1.RefreshReport();
            
        }
    }
}
