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
    public partial class Basarchu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True");
        public Basarchu()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_bashi_basarchwu.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Basarchu_Load(object sender, EventArgs e)
        {
            lbl_name_casher_admin.Text = loginform.cmb;
            //
            timer_basarchu.Enabled = true;
            timer_basarchu.Interval = 1;
            //
            editdatagirdview();
        }

        private void editdatagirdview()
        {
            try
            {
                foreach (DataGridViewColumn item in dataGridView_bashi_basarchwu.Columns)
                {
                    item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//rizakan daheneteta nawarast
                }
                dataGridView_bashi_basarchwu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//header kan dahenet
                dataGridView_bashi_basarchwu.ColumnHeadersDefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//bo font w size dtgv
                dataGridView_bashi_basarchwu.Columns["ID"].HeaderText = "ID";
                dataGridView_bashi_basarchwu.Columns["Barcode"].HeaderText = "Barcode";
                dataGridView_bashi_basarchwu.Columns["Wasl"].HeaderText = "Reciept";
                dataGridView_bashi_basarchwu.Columns["Name_kalla"].HeaderText = "Name";
                dataGridView_bashi_basarchwu.Columns["Br_kalla"].HeaderText = "Quantity";
                dataGridView_bashi_basarchwu.Columns["Nrxy_kren"].HeaderText = "Purchase price";
                dataGridView_bashi_basarchwu.Columns["Koy_nrxy_kren"].HeaderText = "Total Purchase price";
                dataGridView_bashi_basarchwu.Columns["Qazanj"].HeaderText = "Profit";
                dataGridView_bashi_basarchwu.Columns["Jory_kalla"].HeaderText = "Category";
                dataGridView_bashi_basarchwu.Columns["Company"].HeaderText = "Company";
                dataGridView_bashi_basarchwu.Columns["Bakarhenar"].HeaderText = "User";
                dataGridView_bashi_basarchwu.Columns["Nrxy_froshtn"].HeaderText = "Selling price";
                dataGridView_bashi_basarchwu.Columns["Barwary_drustkrdn"].HeaderText = "Manufacturing date";
                dataGridView_bashi_basarchwu.Columns["Barwary_basarchun"].HeaderText = "Expiration date";
                dataGridView_bashi_basarchwu.Columns["Barwary_amro"].HeaderText = "Purchase date";

                //design for size !
                DataGridViewColumn column0 = dataGridView_bashi_basarchwu.Columns[0];//index =id
                column0.Width = 90;
                DataGridViewColumn column1 = dataGridView_bashi_basarchwu.Columns[1];//index =barcode     
                column1.Width = 200;
                DataGridViewColumn column2 = dataGridView_bashi_basarchwu.Columns[2];//index =wasl
                column2.Width = 80;
                DataGridViewColumn column3 = dataGridView_bashi_basarchwu.Columns[3];//index =name_kalla
                column3.Width = 180;
                DataGridViewColumn column4 = dataGridView_bashi_basarchwu.Columns[4];//index =br_kalla
                column4.Width = 120;
                DataGridViewColumn column5 = dataGridView_bashi_basarchwu.Columns[5];//index =nrxy_kren
                column5.Width = 145;
                DataGridViewColumn column6 = dataGridView_bashi_basarchwu.Columns[6];//index =koy_nrxe_kren
                column6.Width = 250;

                DataGridViewColumn column7 = dataGridView_bashi_basarchwu.Columns[7];//index =jقازانج
                column7.Width = 150;

                DataGridViewColumn column8 = dataGridView_bashi_basarchwu.Columns[8];//index =jory_kalla
                column8.Width = 150;
                DataGridViewColumn column9 = dataGridView_bashi_basarchwu.Columns[9];//index =company
                column9.Width = 130;
                DataGridViewColumn column10 = dataGridView_bashi_basarchwu.Columns[10];//index =bakarhenar
                column10.Width = 190;
                DataGridViewColumn column11 = dataGridView_bashi_basarchwu.Columns[11];//index =nrxy_froshtn
                column11.Width = 200;   
                DataGridViewColumn column12 = dataGridView_bashi_basarchwu.Columns[12];//index =barwary_drustkrdn
                column12.Width = 250;
                DataGridViewColumn column13 = dataGridView_bashi_basarchwu.Columns[13];//index =barwary_basrchun
                column13.Width = 250;
                DataGridViewColumn column14 = dataGridView_bashi_basarchwu.Columns[14];//index =barwary_amro
                column14.Width = 270;

                //color design
                dataGridView_bashi_basarchwu.EnableHeadersVisualStyles = false;//bo daxstne header la kate click
                dataGridView_bashi_basarchwu.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;//gorene range header badlle xoman
                dataGridView_bashi_basarchwu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//gorene range texty header ,
                dataGridView_bashi_basarchwu.Columns["ID"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Barcode"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//edit krdne font
                dataGridView_bashi_basarchwu.Columns["Wasl"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Name_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Br_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Nrxy_kren"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Koy_nrxy_kren"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Qazanj"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Jory_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Company"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Bakarhenar"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Nrxy_froshtn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Barwary_drustkrdn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Barwary_basarchun"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_basarchwu.Columns["Barwary_amro"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                ////
                dataGridView_bashi_basarchwu.DefaultCellStyle.ForeColor = Color.Black;//bo gorene range texty rizakane dtgv
                dataGridView_bashi_basarchwu.DefaultCellStyle.BackColor = Color.White;//bo gorene range rizakane dtgv
                                                                                      //ama hamu desing e datagirdview a ba kamlee
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deletedata()
        {//am coda peshtr eshi nakrd la bashi jory kalla balam esa esh akat !!!!!!!!!!!!!!!!  
            try
            {
                DialogResult result = MessageBox.Show("Are you sure about deleting the selected data?", "Please choose", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter sa = new SqlDataAdapter("delete from DAXLLKRDN_KALLA1 where ID='" + dataGridView_bashi_basarchwu.CurrentRow.Cells[0].Value.ToString() + "'", con);
                    dataGridView_bashi_basarchwu.DataSource = dt;
                    sa.Fill(dt);

                    DataTable dtt = new DataTable();
                    SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1 ", con);
                    SqlDataAdapter saa = new SqlDataAdapter(cmd);
                    dataGridView_bashi_basarchwu.DataSource = dtt;
                    saa.Fill(dtt);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    editdatagirdview();
                }

            }
            catch 
            {
                
            }
        }

        private void timer_basarchu_Tick(object sender, EventArgs e)
        {
            //dway nusene am code a achina bashi form load bo nusini hanek code tr
            //lbl_timer.Text = DateTime.Now.ToString("dd-MMM-yyyy   hh:mm:ss tt");//ama time stampa bo danane barwar w kat
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deletedata();
        }

        private void dataGridView_bashi_basarchwu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)//wanay 29
        {
            foreach(DataGridViewRow row in dataGridView_bashi_basarchwu.Rows)
            {//am kodanay era bo zanini basarchuakana
                var now = DateTime.Now;
                var expiredate = DateTime.Parse(row.Cells[12].Value.ToString());
                var seven_day_before = expiredate.AddDays(-7);//am commanda bakar yat bo away ka 7 rozh pesh away expire bet pem bllet
                var two_week_before=expiredate.AddDays(-14);

                if(now>seven_day_before && now < expiredate)//agar 7 rozhe mabw
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }

                else if(now > two_week_before && now < expiredate)//agar 14 rozhe mabw
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }

                else if (now > expiredate)//agar basarchubu
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            
        }


        //am coda sar baw button anay xwarawaya
        ListBox listitem=new ListBox();
        private void btn_expire_barcode_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_bashi_basarchwu.Rows)
            {//am kodanay era bo zanini basarchuakana
                var now = DateTime.Now;
                var expiredate = DateTime.Parse(row.Cells[12].Value.ToString());
                var seven_day_before = expiredate.AddDays(-7);//am commanda bakar yat bo away ka 7 rozh pesh away expire bet pem bllet
                var two_week_before = expiredate.AddDays(-14);

                if (now > seven_day_before && now < expiredate)//agar 7 rozhe mabw
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }

                else if (now > two_week_before && now < expiredate)//agar 14 rozhe mabw
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }

                else if (now > expiredate)//agar basarchubu
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    listBox1.Items.Add(row.Cells[1].Value.ToString());//am coda bo awaya lalist box kaya barcode basarchuakan da bnet
                    listBox2.Items.Add(row.Cells[3].Value.ToString());
                    

                }
            }
        }
        //
        private void search_lanewan_2_barwar()//am methoda bakar yat bo gran lanewan 2 barwary jyawaz
        {
            SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True");
            con.Open();
            string sql = "select * from DAXLLKRDN_KALLA1 where Barwary_amro Between @date1 and @date2";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value);
            da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_bashi_basarchwu.DataSource = dt;
            con.Close();
            editdatagirdview();


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search_lanewan_2_barwar();
        }

        private void btn_gorankare_Click(object sender, EventArgs e)
        {
            gorankary_tomarkrdn fm =new gorankary_tomarkrdn();
            fm.Show();
        }

        private void btn_nwekrdnawa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_bashi_basarchwu.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            editdatagirdview();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
           
            

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
           
        }
    }
}
