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

namespace supermarket.sys
{
    public partial class Namaw : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True"); //connection

        public Namaw()
        {
            InitializeComponent();
            kammbu();
        }
        private void kammbu()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1 where Br_kalla <=0", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_kalla_namawakan.DataSource = dt;
            sa.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Namaw_Load(object sender, EventArgs e)
        {
            lbl_name_casher_admin.Text = loginform.cmb;
            //
            editdatagirdview();


        }

        public void editdatagirdview()
        {
            try
            {
                foreach (DataGridViewColumn item in dataGridView_kalla_namawakan.Columns)
                {
                    item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//rizakan daheneteta nawarast
                }
                dataGridView_kalla_namawakan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//header kan dahenet
                dataGridView_kalla_namawakan.ColumnHeadersDefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//bo font w size dtgv
                dataGridView_kalla_namawakan.Columns["ID"].HeaderText = "ID";
                dataGridView_kalla_namawakan.Columns["Barcode"].HeaderText = "Barcode";
                dataGridView_kalla_namawakan.Columns["Wasl"].HeaderText = "Reciept";
                dataGridView_kalla_namawakan.Columns["Name_kalla"].HeaderText = "Item Name";
                dataGridView_kalla_namawakan.Columns["Br_kalla"].HeaderText = "Quantity";
                dataGridView_kalla_namawakan.Columns["Nrxy_kren"].HeaderText = "Price";
                dataGridView_kalla_namawakan.Columns["Koy_nrxy_kren"].HeaderText = "Total price";
                dataGridView_kalla_namawakan.Columns["Qazanj"].HeaderText = "Profit";
                dataGridView_kalla_namawakan.Columns["Jory_kalla"].HeaderText = "Category";
                dataGridView_kalla_namawakan.Columns["Company"].HeaderText = "Company";
                dataGridView_kalla_namawakan.Columns["Bakarhenar"].HeaderText = "User";
                dataGridView_kalla_namawakan.Columns["Nrxy_froshtn"].HeaderText = "Selling price";
                dataGridView_kalla_namawakan.Columns["Barwary_drustkrdn"].HeaderText = "Expiration date";
                dataGridView_kalla_namawakan.Columns["Barwary_basarchun"].HeaderText = "Manufacturing date";
                dataGridView_kalla_namawakan.Columns["Barwary_amro"].HeaderText = "Date of purchase";

                //design for size !
                DataGridViewColumn column0 = dataGridView_kalla_namawakan.Columns[0];//index =id
                column0.Width = 90;
                DataGridViewColumn column1 = dataGridView_kalla_namawakan.Columns[1];//index =barcode     
                column1.Width = 200;
                DataGridViewColumn column2 = dataGridView_kalla_namawakan.Columns[2];//index =wasl
                column2.Width = 80;
                DataGridViewColumn column3 = dataGridView_kalla_namawakan.Columns[3];//index =name_kalla
                column3.Width = 180;
                DataGridViewColumn column4 = dataGridView_kalla_namawakan.Columns[4];//index =br_kalla
                column4.Width = 120;
                DataGridViewColumn column5 = dataGridView_kalla_namawakan.Columns[5];//index =nrxy_kren
                column5.Width = 145;
                DataGridViewColumn column6 = dataGridView_kalla_namawakan.Columns[6];//index =koy_nrxe_kren
                column6.Width = 250;

                DataGridViewColumn column7 = dataGridView_kalla_namawakan.Columns[7];//index =jقازانج
                column7.Width = 150;    

                DataGridViewColumn column8 = dataGridView_kalla_namawakan.Columns[8];//index =jory_kalla
                column8.Width = 150;
                DataGridViewColumn column9 = dataGridView_kalla_namawakan.Columns[9];//index =company
                column9.Width = 130;
                DataGridViewColumn column10 = dataGridView_kalla_namawakan.Columns[10];//index =bakarhenar
                column10.Width = 190;
                DataGridViewColumn column11 = dataGridView_kalla_namawakan.Columns[11];//index =nrxy_froshtn
                column11.Width = 200;
                DataGridViewColumn column12 = dataGridView_kalla_namawakan.Columns[12];//index =barwary_drustkrdn
                column12.Width = 250;
                DataGridViewColumn column13 = dataGridView_kalla_namawakan.Columns[13];//index =barwary_basrchun
                column13.Width = 250;
                DataGridViewColumn column14 = dataGridView_kalla_namawakan.Columns[14];//index =barwary_amro
                column14.Width = 270;

                //color design
                dataGridView_kalla_namawakan.EnableHeadersVisualStyles = false;//bo daxstne header la kate click
                dataGridView_kalla_namawakan.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;//gorene range header badlle xoman
                dataGridView_kalla_namawakan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//gorene range texty header ,
                dataGridView_kalla_namawakan.Columns["ID"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Barcode"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//edit krdne font
                dataGridView_kalla_namawakan.Columns["Wasl"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Name_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Br_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Nrxy_kren"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Koy_nrxy_kren"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Qazanj"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Jory_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Company"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Bakarhenar"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Nrxy_froshtn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Barwary_drustkrdn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Barwary_basarchun"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_kalla_namawakan.Columns["Barwary_amro"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                ////
                dataGridView_kalla_namawakan.DefaultCellStyle.ForeColor = Color.Black;//bo gorene range texty rizakane dtgv
                dataGridView_kalla_namawakan.DefaultCellStyle.BackColor = Color.White;//bo gorene range rizakane dtgv
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
            dataGridView_kalla_namawakan.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();

            kammbu();
            editdatagirdview();
        }

        private void dataGridView_kalla_namawakan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gorankary_tomarkrdn a = new gorankary_tomarkrdn();
            a.Show();
        }

        private void dataGridView_kalla_namawakan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_header_home_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
