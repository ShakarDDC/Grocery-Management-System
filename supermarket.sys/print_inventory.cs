using CrystalDecisions.ReportAppServer;
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
    public partial class print_inventory : Form
    {
        public print_inventory()
        {
            InitializeComponent();
        }

        public print_inventory(DataTable dataTable)
        {

            InitializeComponent();
            CrystalReport_inventory reportCarsPrint = new CrystalReport_inventory();
            reportCarsPrint.Database.Tables["Inventory"].SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = reportCarsPrint;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
