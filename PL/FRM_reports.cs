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
    public partial class FRM_reports : Form
    {
        public FRM_reports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sell_report_Click(object sender, EventArgs e)
        {
            PL.FRM_RV frm_rv = new PL.FRM_RV();
            frm_rv.Show();
        }
    }
}
