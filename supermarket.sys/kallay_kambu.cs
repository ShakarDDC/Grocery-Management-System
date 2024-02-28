using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket.sys
{
    public partial class kallay_kambu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True");
        public kallay_kambu()
        {
            InitializeComponent();
            kammbu();
        }
        private void kammbu()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1 where Br_kalla <=10", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_kallay_kambu.DataSource = dt;
            sa.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void kallay_kambu_Load(object sender, EventArgs e)
        {
            lbl_name_casher_admin.Text = loginform.cmb;
            //
            editdatagirdview();
        }

        public void editdatagirdview()
        {
            try
            {
                foreach (DataGridViewColumn item in dataGridView_kallay_kambu.Columns)
                {
                    item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//rizakan daheneteta nawarast
                }
                dataGridView_kallay_kambu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//header kan dahenet
                dataGridView_kallay_kambu.ColumnHeadersDefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//bo font w size dtgv
                dataGridView_kallay_kambu.Columns["ID"].HeaderText = "ID";
                dataGridView_kallay_kambu.Columns["Barcode"].HeaderText = "Barcode";
                dataGridView_kallay_kambu.Columns["Wasl"].HeaderText = "Reciept";
                dataGridView_kallay_kambu.Columns["Name_kalla"].HeaderText = "Item Name";
                dataGridView_kallay_kambu.Columns["Br_kalla"].HeaderText = "Quantity";
                dataGridView_kallay_kambu.Columns["Nrxy_kren"].HeaderText = "Purchase Price";
                dataGridView_kallay_kambu.Columns["Koy_nrxy_kren"].HeaderText = "Total Purchase Price";
                dataGridView_kallay_kambu.Columns["Qazanj"].HeaderText = "Profit";
                dataGridView_kallay_kambu.Columns["Jory_kalla"].HeaderText = "Category";
                dataGridView_kallay_kambu.Columns["Company"].HeaderText = "Company";
                dataGridView_kallay_kambu.Columns["Bakarhenar"].HeaderText = "User";
                dataGridView_kallay_kambu.Columns["Nrxy_froshtn"].HeaderText = "Selling price";
                dataGridView_kallay_kambu.Columns["Barwary_drustkrdn"].HeaderText = "Manufacturing date";
                dataGridView_kallay_kambu.Columns["Barwary_basarchun"].HeaderText = "Expiration date";
                dataGridView_kallay_kambu.Columns["Barwary_amro"].HeaderText = "Date of Purchase";

                //design for size !
                DataGridViewColumn column0 = dataGridView_kallay_kambu.Columns[0];//index =id
                column0.Width = 90;
                DataGridViewColumn column1 = dataGridView_kallay_kambu.Columns[1];//index =barcode     
                column1.Width = 200;
                DataGridViewColumn column2 = dataGridView_kallay_kambu.Columns[2];//index =wasl
                column2.Width = 80;
                DataGridViewColumn column3 = dataGridView_kallay_kambu.Columns[3];//index =name_kalla
                column3.Width = 180;
                DataGridViewColumn column4 = dataGridView_kallay_kambu.Columns[4];//index =br_kalla
                column4.Width = 120;
                DataGridViewColumn column5 = dataGridView_kallay_kambu.Columns[5];//index =nrxy_kren
                column5.Width = 145;
                DataGridViewColumn column6 = dataGridView_kallay_kambu.Columns[6];//index =koy_nrxe_kren
                column6.Width = 250;

                DataGridViewColumn column7 = dataGridView_kallay_kambu.Columns[7];//index =jقازانج
                column7.Width = 150;

                DataGridViewColumn column8 = dataGridView_kallay_kambu.Columns[8];//index =jory_kalla
                column8.Width = 150;
                DataGridViewColumn column9 = dataGridView_kallay_kambu.Columns[9];//index =company
                column9.Width = 130;
                DataGridViewColumn column10 = dataGridView_kallay_kambu.Columns[10];//index =bakarhenar
                column10.Width = 190;
                DataGridViewColumn column11 = dataGridView_kallay_kambu.Columns[11];//index =nrxy_froshtn
                column11.Width = 200;
                DataGridViewColumn column12 = dataGridView_kallay_kambu.Columns[12];//index =barwary_drustkrdn
                column12.Width = 250;
                DataGridViewColumn column13 = dataGridView_kallay_kambu.Columns[13];//index =barwary_basrchun
                column13.Width = 250;
                DataGridViewColumn column14 = dataGridView_kallay_kambu.Columns[14];//index =barwary_amro
                column14.Width = 270;

                //color design
                dataGridView_kallay_kambu.EnableHeadersVisualStyles = false;//bo daxstne header la kate click
                dataGridView_kallay_kambu.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;//gorene range header badlle xoman
                dataGridView_kallay_kambu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//gorene range texty header ,
                dataGridView_kallay_kambu.Columns["ID"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Barcode"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//edit krdne font
                dataGridView_kallay_kambu.Columns["Wasl"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Name_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Br_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Nrxy_kren"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Koy_nrxy_kren"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Qazanj"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Jory_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Company"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Bakarhenar"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Nrxy_froshtn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Barwary_drustkrdn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Barwary_basarchun"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kallay_kambu.Columns["Barwary_amro"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                ////
                dataGridView_kallay_kambu.DefaultCellStyle.ForeColor = Color.Black;//bo gorene range texty rizakane dtgv
                dataGridView_kallay_kambu.DefaultCellStyle.BackColor = Color.White;//bo gorene range rizakane dtgv
                                                                                      //ama hamu desing e datagirdview a ba kamlee
            }
            catch 
            {
                
            }

        }

        private void btn_gorankare_Click(object sender, EventArgs e)
        {
            gorankary_tomarkrdn a = new gorankary_tomarkrdn();
            a.Show();
        }

        private void btn_nwekrdnawa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_kallay_kambu.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();
            
            kammbu();
            editdatagirdview();
        }

        private void dataGridView_kallay_kambu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gorankary_tomarkrdn a=new gorankary_tomarkrdn();
            a.Show();
        }

        private void dataGridView_kallay_kambu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
