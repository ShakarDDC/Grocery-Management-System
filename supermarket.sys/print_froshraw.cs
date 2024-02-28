using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket.sys
{
    public partial class print_froshraw : Form
    {
        public print_froshraw()
        {
            InitializeComponent();
        }

        public print_froshraw(DataTable dataTable)
        {
            InitializeComponent();
            CrystalReport1 reportCarsPrint = new  CrystalReport1();
            reportCarsPrint.Database.Tables["checkout"].SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = reportCarsPrint;
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        public  class test { 
        }
    }
}
