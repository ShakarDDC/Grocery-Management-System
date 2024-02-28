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

namespace supermarket.sys//20
{
    public partial class froshraw : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True"); //connection

        public froshraw()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from FROSHRAW", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_bashi_froshraw.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        private void froshraw_Load(object sender, EventArgs e)
        {
            timer_forshraw.Enabled = true;
            timer_forshraw.Interval = 1;
            /////////////////////////////////
            lbl_name_casher_admin.Text = loginform.cmb;
            count_data();
            dtgv_count();
            editdatagirdview();
        }
        private void count_data()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter("select count (ID) from FROSHRAW", con);
            sa.Fill(dt);
            txt_1.Text = dt.Rows[0][0].ToString();

            DataTable dt2 = new DataTable();
            SqlDataAdapter sa2 = new SqlDataAdapter("select sum (Koy_nrxy_froshtn) from FROSHRAW ", con);
            sa2.Fill(dt2);
            txt_2.Text = dt2.Rows[0][0].ToString();

            DataTable dt1 = new DataTable();
            SqlDataAdapter sa1 = new SqlDataAdapter("select sum (Qazanj) from FROSHRAW ", con);
            sa1.Fill(dt1);
            txt_3.Text = dt1.Rows[0][0].ToString();


            DataTable dt5 = new DataTable();
            SqlDataAdapter sa5 = new SqlDataAdapter("select sum (br_kalla) from FROSHRAW ", con);
            sa5.Fill(dt5);
            textBox_br.Text = dt5.Rows[0][0].ToString();


            try
            {
                txt_3.Text = string.Format("{0:n0}", double.Parse(txt_3.Text));
                txt_2.Text = string.Format("{0:n0}", double.Parse(txt_2.Text));
                textBox_br.Text = string.Format("{0:n0}", double.Parse(textBox_br.Text));
            }
            catch (Exception)
            {
            }

        }
        public void koy_gshte_froshraw_label()
        {
            textBox1.Text = string.Format("{0:n0}", double.Parse(textBox1.Text));
           
        }


        private void editdatagirdview()
        {
            try
            {
                foreach (DataGridViewColumn item in dataGridView_bashi_froshraw.Columns)
                {
                    item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//rizakan daheneteta nawarast
                }
                dataGridView_bashi_froshraw.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//header kan dahenet
                dataGridView_bashi_froshraw.ColumnHeadersDefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//bo font w size dtgv
                dataGridView_bashi_froshraw.Columns["ID"].HeaderText = "ID";
                dataGridView_bashi_froshraw.Columns["Barcode"].HeaderText = "Barcode";
                dataGridView_bashi_froshraw.Columns["Name_kalla"].HeaderText = "Item Name";

                dataGridView_bashi_froshraw.Columns["Nrxy_froshtn"].HeaderText = "Price";
                dataGridView_bashi_froshraw.Columns["br_kalla"].HeaderText = "Item Quantity";
                dataGridView_bashi_froshraw.Columns["Koy_nrxy_froshtn"].HeaderText = "Total Price";


                dataGridView_bashi_froshraw.Columns["Qazanj"].HeaderText = "Profit";
                dataGridView_bashi_froshraw.Columns["Wasl"].HeaderText = "Reciept";
                dataGridView_bashi_froshraw.Columns["Dashkandn"].HeaderText = "Discount";

                dataGridView_bashi_froshraw.Columns["Dinar"].HeaderText = "IQD";
                dataGridView_bashi_froshraw.Columns["Dollar"].HeaderText = "USD";
                dataGridView_bashi_froshraw.Columns["Nrxy_yak_dollar"].HeaderText = "1 USD";

                dataGridView_bashi_froshraw.Columns["Barwary_froshtn"].HeaderText = "Selling Date";
                dataGridView_bashi_froshraw.Columns["Bakarhenar"].HeaderText = "User";


                //design for size !
                DataGridViewColumn column0 = dataGridView_bashi_froshraw.Columns[0];//
                column0.Width = 90;
                DataGridViewColumn column1 = dataGridView_bashi_froshraw.Columns[1];//
                column1.Width = 180;
                DataGridViewColumn column2 = dataGridView_bashi_froshraw.Columns[2];//
                column2.Width = 200;
                DataGridViewColumn column3 = dataGridView_bashi_froshraw.Columns[3];//
                column3.Width = 180;
                DataGridViewColumn column4 = dataGridView_bashi_froshraw.Columns[4];//
                column4.Width = 120;
                DataGridViewColumn column5 = dataGridView_bashi_froshraw.Columns[5];//
                column5.Width = 160;
                DataGridViewColumn column6 = dataGridView_bashi_froshraw.Columns[6];//
                column6.Width = 80;
                DataGridViewColumn column7 = dataGridView_bashi_froshraw.Columns[7];//
                column7.Width = 80;
                DataGridViewColumn column8 = dataGridView_bashi_froshraw.Columns[8];//
                column8.Width = 130;
                DataGridViewColumn column9 = dataGridView_bashi_froshraw.Columns[9];//
                column9.Width = 190;    
                DataGridViewColumn column10 = dataGridView_bashi_froshraw.Columns[10];//
                column10.Width = 150;
                DataGridViewColumn column11 = dataGridView_bashi_froshraw.Columns[11];//
                column11.Width = 250;
                DataGridViewColumn column12 = dataGridView_bashi_froshraw.Columns[12];//
                column12.Width = 200;
                DataGridViewColumn column13 = dataGridView_bashi_froshraw.Columns[13];//
                column13.Width = 200;


                //color design
                dataGridView_bashi_froshraw.EnableHeadersVisualStyles = false;//bo daxstne header la kate click
                dataGridView_bashi_froshraw.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;//gorene range header badlle xoman
                dataGridView_bashi_froshraw.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//gorene range texty header ,
                dataGridView_bashi_froshraw.Columns["ID"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshraw.Columns["Barcode"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//edit krdne font           
                dataGridView_bashi_froshraw.Columns["Name_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);

                dataGridView_bashi_froshraw.Columns["Nrxy_froshtn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshraw.Columns["Br_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshraw.Columns["Koy_nrxy_froshtn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshraw.Columns["Wasl"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);

                dataGridView_bashi_froshraw.Columns["Qazanj"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshraw.Columns["Dashkandn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshraw.Columns["Dinar"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshraw.Columns["Dollar"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);

                dataGridView_bashi_froshraw.Columns["Nrxy_yak_dollar"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshraw.Columns["Barwary_froshtn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshraw.Columns["Bakarhenar"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                ////
                dataGridView_bashi_froshraw.DefaultCellStyle.ForeColor = Color.Black;//bo gorene range texty rizakane dtgv
                dataGridView_bashi_froshraw.DefaultCellStyle.BackColor = Color.White;//bo gorene range rizakane dtgv
                                                                                      //ama hamu desing e datagirdview a ba kamlee
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void search()
        {
            try
            {
                if (comboBox_search_froshraw.Text == "no.")
                {
                    SqlCommand cmd = new SqlCommand("select * from FROSHRAW where ID like N'%" + txt_search_froshraw.Text + "%'", con);
                    DataTable dt = new DataTable();
                    dataGridView_bashi_froshraw.DataSource = dt;
                    SqlDataAdapter sa = new SqlDataAdapter(cmd);
                    sa.Fill(dt);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    editdatagirdview();
                }
                else if (comboBox_search_froshraw.Text == "Search by name")
                {
                    SqlCommand cmd = new SqlCommand("select * from FROSHRAW where Name_kalla like N'" + txt_search_froshraw.Text + "%'", con);
                    DataTable dt = new DataTable();
                    dataGridView_bashi_froshraw.DataSource = dt;
                    SqlDataAdapter sa = new SqlDataAdapter(cmd);
                    sa.Fill(dt);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    editdatagirdview();

                }
                else if (comboBox_search_froshraw.Text == "Search by barcode")
                {
                    SqlCommand cmd = new SqlCommand("select * from FROSHRAW where Barcode like N'" + txt_search_froshraw.Text + "%'", con);
                    DataTable dt = new DataTable();
                   dataGridView_bashi_froshraw.DataSource = dt;
                    SqlDataAdapter sa = new SqlDataAdapter(cmd);
                    sa.Fill(dt);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    editdatagirdview();
                }
                else if (comboBox_search_froshraw.Text == "Search by reciept")
                {
                    SqlCommand cmd = new SqlCommand("select * from FROSHRAW where Wasl like N'" + txt_search_froshraw.Text + "%'", con);
                    DataTable dt = new DataTable();
                    dataGridView_bashi_froshraw.DataSource = dt;
                    SqlDataAdapter sa = new SqlDataAdapter(cmd);
                    sa.Fill(dt);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    editdatagirdview();
                }
                else if (comboBox_search_froshraw.Text == "Search by User")
                {
                    SqlCommand cmd = new SqlCommand("select * from FROSHRAW where Bakarhenar like N'" + txt_search_froshraw.Text + "%'", con);
                    DataTable dt = new DataTable();
                    dataGridView_bashi_froshraw.DataSource = dt;
                    SqlDataAdapter sa = new SqlDataAdapter(cmd);
                    sa.Fill(dt);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    editdatagirdview();
                }

                else if (comboBox_search_froshraw.Text == "Search by date")
                {
                    SqlCommand cmd = new SqlCommand("select * from FROSHRAW where Barwary_froshtn  like N'" + txt_search_froshraw.Text + "%'", con);
                    DataTable dt = new DataTable();
                    dataGridView_bashi_froshraw.DataSource = dt;
                    SqlDataAdapter sa = new SqlDataAdapter(cmd);
                    sa.Fill(dt);
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




        ////////
        private void deleteall()
        {
            
            try
            {
                DialogResult result = MessageBox.Show("All information will be removed permanently.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter sa = new SqlDataAdapter("delete from FROSHRAW ", con);
                    dataGridView_bashi_froshraw.DataSource = dt;
                    sa.Fill(dt);//am coday sarawa bo srynaway hamu datakani table a kaya !!!!!!
                                //am coday xwarawa bo awaya ka hamu datakanman sryawa dwatr la ID 1 kawa dast pe bkatawa

                }
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "DBCC CHECKIDENT('FROSHRAW' , RESEED,0)";         //am coda bakaryat bo eshek ka la sql pewestbka bnusret ballam bmanawet lera benusin
                cmd.ExecuteNonQuery();
                con.Close();
                

            }


            catch
            {

            }
           
        }


        private void deletedata()
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure about deleting the selected data?", "Please choose.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter sa = new SqlDataAdapter("delete from FROSHRAW where ID='" + dataGridView_bashi_froshraw.CurrentRow.Cells[0].Value.ToString() + "'", con);
                    dataGridView_bashi_froshraw.DataSource = dt;
                    sa.Fill(dt);

                    DataTable dtt = new DataTable();
                    SqlCommand cmd = new SqlCommand("select * from FROSHRAW ", con);
                    SqlDataAdapter saa = new SqlDataAdapter(cmd);
                    dataGridView_bashi_froshraw.DataSource = dtt;
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

        private void search_lanewan_2_barwar()//am methoda bakar yat bo gran lanewan 2 barwary jyawaz
        {
            SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True");
            con.Open();
            string sql = "select * from FROSHRAW where Barwary_froshtn Between @date1 and @date2";
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value);
            da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView_bashi_froshraw.DataSource = dt;
            con.Close();


        }

        
        private void timer_forshraw_Tick(object sender, EventArgs e)
        {
            //dway nusene am code a achina bashi form load bo nusini hanek code tr
            //lbl_timer.Text = DateTime.Now.ToString("dd-MMM-yyyy   hh:mm:ss tt");//ama time stampa bo danane barwar w kat
        }

        private void txt_search_froshraw_TextChanged(object sender, EventArgs e)
        {
            search();
            editdatagirdview();
        }

        private void btn_tomarkrdn_Click(object sender, EventArgs e)//btn_pakkrdnawa ya
        {
            deleteall();
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from FROSHRAW", con);
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                dataGridView_bashi_froshraw.DataSource = dt;
                sa.Fill(dt);
                con.Open(); //bo pshandani datagridview hamw katek
                cmd.ExecuteNonQuery();
                con.Close();
                editdatagirdview();
            }
            catch
            {

            }
            editdatagirdview();
        }

        private void comboBox_search_froshraw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_jore_kalla_Click(object sender, EventArgs e)//btn koy gshte froshraw

        {
           
        }
        private void dtgv_count()
        {
            int x = 0, y = 0;
            for (x = 0; x < dataGridView_bashi_froshraw.Rows.Count; ++x)
            {
                y += Convert.ToInt32(dataGridView_bashi_froshraw.Rows[x].Cells[6].Value);
            }
            textBox1.Text = y.ToString();
            koy_gshte_froshraw_label();
        }

        private void btn_nwekrdnawa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from FROSHRAW", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_bashi_froshraw.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();
            txt_search_froshraw.Clear();
            comboBox_search_froshraw.Text = "";
            textBox1.Text = txt_3.Text;
            editdatagirdview();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deletedata();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            search_lanewan_2_barwar();
            count_data();
            dtgv_count();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel_header_tomarkrdn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
