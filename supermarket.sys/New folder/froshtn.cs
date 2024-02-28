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
    public partial class froshtn : Form
    {

        SqlConnection con=new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True");
        public froshtn()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from FROSHTN", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_bashi_froshtn.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();
            select_nrxe_draw();
            hsabat();
        }

        private void froshtn_Load(object sender, EventArgs e)
        {
            //WASLL  ama bo drustkrdny psswullay nwe
            SqlDataAdapter sa = new SqlDataAdapter("select isnull(max(cast(Wasl as int)),1) from FROSHRAW ", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            txt_pswlla.Text = dt.Rows[0][0].ToString();
            //////////////////////////////////////////////

            double yaksan_1 = 1;
            txt_bry_kalla.Text = yaksan_1.ToString();
            editdatagirdview();
            /////
            timer_froshtn.Enabled = true;
            timer_froshtn.Interval = 1;
            ////////////
            //lera am coda bo awa bakar yat nawe  aw casher yan admin pishan bat ka login e am form ay krdfwa
            lbl_name_casher_admin.Text = loginform.cmb;//amash tawaw kari aw codea ka la forme login nusewmana la methode loginuser w loginadmin
            select_nrxe_draw();
            hsabat();
            txt_barcode.Focus();
            

        }

        private void hsabat()
        {
            try
            {
                double a = Convert.ToDouble(lbl_dinar.Text);
                double b = Convert.ToDouble(lbl_nrxe_yak_dollar_ba_dinar.Text);
                double c = a / b;//am codana co dabash krdne dinar basar nrxy 1 dollara bakar hatwa 


                //amay xwarwa bo away nrxakaman point warbgret
                lbl_dollar.Text = string.Format("{0:N2} $", c);
                lbl_dinar.Text = string.Format("{0:n0}", double.Parse(lbl_dinar.Text));//ama bataybat bo dinar bakar yat

                //

            }
            catch
            {

            }
        }

        private void editdatagirdview()
        {
            try
            {
                foreach (DataGridViewColumn item in dataGridView_bashi_froshtn.Columns)
                {
                    item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//rizakan daheneteta nawarast
                }
                dataGridView_bashi_froshtn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//header kan dahenet
                dataGridView_bashi_froshtn.ColumnHeadersDefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//bo font w size dtgv
                dataGridView_bashi_froshtn.Columns["ID"].HeaderText = "ID";
                dataGridView_bashi_froshtn.Columns["Barcode"].HeaderText = "Barcode";
                dataGridView_bashi_froshtn.Columns["Name_kalla"].HeaderText = "Item Name";
                dataGridView_bashi_froshtn.Columns["Nrxy_froshtn"].HeaderText = "Selling price";
                dataGridView_bashi_froshtn.Columns["br_kalla"].HeaderText = "Item Quantity";
                dataGridView_bashi_froshtn.Columns["Koy_nrxy_froshtn"].HeaderText = "Total price";
                dataGridView_bashi_froshtn.Columns["Qazanj"].HeaderText = "Profit";
                dataGridView_bashi_froshtn.Columns["koy_qazanj"].HeaderText = "Total profit";

                //design for size !
                DataGridViewColumn column0 = dataGridView_bashi_froshtn.Columns[0];//index =id
                column0.Width = 80;
                DataGridViewColumn column1 = dataGridView_bashi_froshtn.Columns[1];//index =barcode     
                column1.Width = 130;
                DataGridViewColumn column2 = dataGridView_bashi_froshtn.Columns[2];//index =name kalla
                column2.Width = 100;
                DataGridViewColumn column3 = dataGridView_bashi_froshtn.Columns[3];//index =nnrxy froshtn
                column3.Width = 150;
                DataGridViewColumn column4 = dataGridView_bashi_froshtn.Columns[4];//index =br_kalla
                column4.Width = 120;
                DataGridViewColumn column5 = dataGridView_bashi_froshtn.Columns[5];//index =koy nrxy froshtn
                column5.Width =150;
                DataGridViewColumn column6 = dataGridView_bashi_froshtn.Columns[6];//index =br_kalla
                column6.Width = 160;
                DataGridViewColumn column7 = dataGridView_bashi_froshtn.Columns[7];//index =br_kalla
                column7.Width = 160;



                //color design
                dataGridView_bashi_froshtn.EnableHeadersVisualStyles = false;//bo daxstne header la kate click
                dataGridView_bashi_froshtn.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;//gorene range header badlle xoman
                dataGridView_bashi_froshtn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//gorene range texty header ,
                dataGridView_bashi_froshtn.Columns["ID"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshtn.Columns["Barcode"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//edit krdne fon
                dataGridView_bashi_froshtn.Columns["Name_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshtn.Columns["Nrxy_froshtn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshtn.Columns["br_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshtn.Columns["Koy_nrxy_froshtn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshtn.Columns["Qazanj"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_froshtn.Columns["koy_qazanj"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                ////
                dataGridView_bashi_froshtn.DefaultCellStyle.ForeColor = Color.Black;//bo gorene range texty rizakane dtgv
                dataGridView_bashi_froshtn.DefaultCellStyle.BackColor = Color.White;//bo gorene range rizakane dtgv
                                                                                      //ama hamu desing e datagirdview a ba kamlee
            }
            catch 
            {
               
            }

        }


        private void select_barcode()
        {
            //am coda zor grnga bo away sht babatale nachet bo db la kate update krdn
            string source = @"Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            string selectquery = "select * from DAXLLKRDN_KALLA1 where Barcode=N'" + txt_barcode.Text + "'";
            SqlCommand cmd = new SqlCommand(selectquery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_name_kalla.Text = (dr["Name_kalla"].ToString());
                txt_nrxy_kalla.Text = (dr["Nrxy_froshtn"].ToString());
                txt_qazanj.Text = (dr["Qazanj"].ToString());
                //qazanj

            }
            else
            {
              //  txt_bry_kalla.Clear();
                txt_name_kalla.Clear();
                txt_nrxy_kalla.Clear();
                txt_bry_kalla.Text = "1";
                txt_qazanj.Clear();
            }
        }

        private void select_name()
        {
            //am coda zor grnga bo away sht babatale nachet bo db la kate update krdn
            string source = @"Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            string selectquery = "select * from DAXLLKRDN_KALLA1 where Name_kalla=N'" + txt_name_kalla.Text + "'";
            SqlCommand cmd = new SqlCommand(selectquery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_barcode.Text = (dr["Barcode"].ToString());
                txt_nrxy_kalla.Text = (dr["Nrxy_froshtn"].ToString());
            }
            else
            {
                //nothing yet
                // txt_name_kalla.Clear();
                txt_barcode.Clear();
                txt_nrxy_kalla.Clear();
                txt_bry_kalla.Text = "1";
                txt_qazanj.Clear();
            }
        }

        private void savedata_select_barcode()  //save button or add button
        {  // add krdne data bo db w pshan danway la dtgv                                  
            try
            {

                string source = @"Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";
                SqlConnection con = new SqlConnection(source);
                con.Open();

                string selectquery = "select * from DAXLLKRDN_KALLA1 where Barcode=N'" + txt_barcode.Text + "'";
                SqlCommand cmd = new SqlCommand(selectquery, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    con.Close();
                    SqlCommand cmdd = new SqlCommand("Insert into FROSHTN (Barcode,Name_kalla,Nrxy_froshtn,br_kalla,Qazanj) values(N'" + txt_barcode.Text + "',N'" + txt_name_kalla.Text + "',N'" + txt_nrxy_kalla.Text + "',N'" + txt_bry_kalla.Text + "',N'"+txt_qazanj.Text+"')", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sa = new SqlDataAdapter(cmdd);
                    sa.Fill(dt);
                }
               
            }
            catch
            {

            }
        }

        private void updatedata() 
        {

            SqlCommand cmd = new SqlCommand("update FROSHTN set br_kalla=N'" + txt_bry_kalla.Text + "' where Barcode=N'" + txt_barcode.Text + "'", con);
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);



        }

        private void lekdan_colomun()
        {
            //bo lekdane yan dabshkrdn la naw datagird vieww
            try
            {
                foreach (DataGridViewRow row in dataGridView_bashi_froshtn.Rows)
                {
                double a = Convert.ToDouble(row.Cells[dataGridView_bashi_froshtn.Columns[3].Index].Value);
                double b = Convert.ToDouble(row.Cells[dataGridView_bashi_froshtn.Columns[4].Index].Value);
                row.Cells[dataGridView_bashi_froshtn.Columns[5].Index].Value = (a * b);

                }

                int x = 0, y = 0;
                for (x = 0; x < dataGridView_bashi_froshtn.Rows.Count; ++x)
                {
                    y += Convert.ToInt32(dataGridView_bashi_froshtn.Rows[x].Cells[5].Value);
                }
                lbl_dinar.Text=y.ToString();
                int rowidx=dataGridView_bashi_froshtn.Rows.Count - 1;
                dataGridView_bashi_froshtn.Rows[rowidx].Cells[5].Value = y;

                /////////////////////////////////////////////////////////
                ///

                foreach (DataGridViewRow row in dataGridView_bashi_froshtn.Rows)
                {
                    double a1 = Convert.ToDouble(row.Cells[dataGridView_bashi_froshtn.Columns[4].Index].Value);
                    double b1 = Convert.ToDouble(row.Cells[dataGridView_bashi_froshtn.Columns[6].Index].Value);
                    row.Cells[dataGridView_bashi_froshtn.Columns[7].Index].Value = (a1 * b1);

                }

                int x1 = 0, y1 = 0;
                for (x1 = 0; x1 < dataGridView_bashi_froshtn.Rows.Count; ++x1)
                {
                    y1 += Convert.ToInt32(dataGridView_bashi_froshtn.Rows[x1].Cells[7].Value);
                }
                lbl_dinar.Text = y.ToString();
                int rowidx1 = dataGridView_bashi_froshtn.Rows.Count - 1;
                dataGridView_bashi_froshtn.Rows[rowidx1].Cells[7].Value = y1;

            }
            catch 
            {

            }

        }

        private void select_barcod_br()
        {
            //am coda zor grnga bo away sht babatale nachet bo db la kate update krdn
            string source = @"Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            string selectquery = "select * from  FROSHTN where Barcode=N'" + txt_barcode.Text + "'";
            SqlCommand cmd = new SqlCommand(selectquery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                txt_bry_kalla.Text = (dr["br_kalla"].ToString());
                double a = Convert.ToDouble(txt_bry_kalla.Text);
                double b = a + 1;
                txt_bry_kalla.Text = b.ToString();

                //
                //txt_qazanj.Text = (dr["Qazanj"].ToString());
                //double x = Convert.ToDouble(txt_qazanj.Text);
                //double y = x + x;
                //txt_qazanj.Text = y.ToString();

            }

        }

        private void select_nrxe_draw()//ama paiwande haya ba forme nrxe dollarawa
        {
            try
            {
                string source = @"Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";
                SqlConnection con = new SqlConnection(source);

                string selectquery = "select * from nrxy_draw where Nrxy_dollar=N'1 USD Price'";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = selectquery;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lbl_nrxe_yak_dollar_ba_dinar.Text = (dr["Nrxy_dinar"].ToString());
                }
                con.Close();
            }
            catch { }

        }
        private void timer_froshtn_Tick(object sender, EventArgs e)
            {
                  //dway nusene am code a achina bashi form load bo nusini hanek code tr
                  lbl_timer_froshtn.Text = DateTime.Now.ToString("dd-MMM-yyyy   hh:mm:ss tt");//ama time stampa bo danane barwar w kat
            }

      

        private void txt_bry_kalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ema lera bashi key press e txt man krdwatawa bo away way le bkain tanha zhmara bxwenetawa larey am code anwa
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_dashkandn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ema lera bashi key press e txt man krdwatawa bo away way le bkain tanha zhmara bxwenetawa larey am code anwa
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_pswlla_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ema lera bashi key press e txt man krdwatawa bo away way le bkain tanha zhmara bxwenetawa larey am code anwa
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        
        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                select_barcode();
                select_barcod_br();
                savedata_select_barcode();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from FROSHTN", con);
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                dataGridView_bashi_froshtn.DataSource = dt;
                sa.Fill(dt);
                con.Open();                                     //bo pshandani datagridview
                cmd.ExecuteNonQuery();
                con.Close();
                lekdan_colomun();
               
               
            }

            catch 
            {
               
            }
            editdatagirdview();
        }

        private void txt_name_kalla_TextChanged(object sender, EventArgs e)
        {
            select_name();
        }

        private void txt_bry_kalla_TextChanged(object sender, EventArgs e)
        {
            updatedata();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from FROSHTN", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_bashi_froshtn.DataSource = dt;
            sa.Fill(dt);
            con.Open();                                     //bo pshandani datagridview
            cmd.ExecuteNonQuery();
            con.Close();
            lekdan_colomun();

            editdatagirdview();
        }


        private void froshraw()// wanay 24 //fpr adding data for froshraw table in form froshtn !!!  
        {
            try
            {
                //am forech a bkar ahenin bo aaway hamu value kane dtgv man bo bhenetawa wa lera parametar man bakar henawa 
                foreach (DataGridViewRow row in dataGridView_bashi_froshtn.Rows)
                {
                    string constring = @"Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";

                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        using (SqlCommand cmdd = new SqlCommand("INSERT INTO [FROSHRAW](ID,Barcode,Name_kalla,Nrxy_froshtn,br_kalla,Koy_nrxy_froshtn,Qazanj,Wasl,Dashkandn,Dinar,Dollar,Nrxy_yak_dollar,Barwary_froshtn,Bakarhenar) values(@ID,@Barcode,@Name_kalla,@Nrxy_froshtn,@Br_kalla,@Koy_nrxy_froshtn,@Qazanj,@Wasl,@Dashkandn,@Dinar,@Dollar,@Nrxy_yak_dollar,@Barwary_froshtn,@Bakarhenar)", con))
                        {
                            cmdd.Parameters.AddWithValue("@ID", row.Cells[0].Value);
                            cmdd.Parameters.AddWithValue("@Barcode", row.Cells[1].Value);
                            cmdd.Parameters.AddWithValue("@Name_kalla", row.Cells[2].Value);
                            cmdd.Parameters.AddWithValue("@Nrxy_froshtn", row.Cells[3].Value);
                            cmdd.Parameters.AddWithValue("@br_kalla", row.Cells[4].Value);
                            cmdd.Parameters.AddWithValue("@Koy_nrxy_froshtn", row.Cells[5].Value);
                            cmdd.Parameters.AddWithValue("@Qazanj", row.Cells[7].Value);
                            cmdd.Parameters.AddWithValue("@Wasl", txt_pswlla.Text);
                            cmdd.Parameters.AddWithValue("@Dashkandn", textBox1.Text);
                            cmdd.Parameters.AddWithValue("@Dinar", lbl_dinar.Text);
                            cmdd.Parameters.AddWithValue("@Dollar", lbl_dollar.Text);
                            cmdd.Parameters.AddWithValue("@Nrxy_yak_dollar", lbl_nrxe_yak_dollar_ba_dinar.Text);
                            cmdd.Parameters.AddWithValue("@Barwary_froshtn", lbl_timer_froshtn.Text);
                            cmdd.Parameters.AddWithValue("@Bakarhenar", lbl_name_casher_admin.Text);

                            //for excute
                            con.Open();
                            cmdd.ExecuteNonQuery();
                          

                            con.Close();//ama bo awaya katek shtek afroshit la kogay kam bkatawa
                            SqlCommand cmd1 = new SqlCommand("select br_kalla From DAXLLKRDN_KALLA1 where Barcode=@ItemName ", con);
                            cmd1.Parameters.AddWithValue("@ItemName", row.Cells[1].Value);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            //
                            SqlDataAdapter dataAdapter= new SqlDataAdapter();
                            dataAdapter.SelectCommand= cmd1;
                           DataTable dataTable= new DataTable();    
                            dataAdapter.Fill(dataTable);
                            con.Close();
                            int Counter = Convert.ToInt32(dataTable.Rows[0][0]);
                            int CounterInser = Convert.ToInt32(row.Cells[4].Value);
                            int AddCounter = Counter - CounterInser;
                            SqlCommand cmd2 = new SqlCommand("Update DAXLLKRDN_KALLA1 Set br_kalla=@Couter where Barcode=@ItemName ", con);
                            cmd2.Parameters.AddWithValue("@ItemName", row.Cells[1].Value);
                            cmd2.Parameters.AddWithValue("@Couter",AddCounter);

                            con.Open();
                            cmd2.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }
            catch
            {
              
            }
           

        }

        //
        private void print_froshtn()// wanay 24 //for printing  data for froshraw table in form froshtn !!!  
        {
            try
            {
                //am forech a bkar ahenin bo aaway hamu value kane dtgv man bo bhenetawa wa lera parametar man bakar henawa 
                foreach (DataGridViewRow row in dataGridView_bashi_froshtn.Rows)
                {
                    string constring = @"Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";

                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        using (SqlCommand cmdd = new SqlCommand("INSERT INTO [print_froshtn](ID,Barcode,Name_kalla,Nrxy_froshtn,br_kalla,Koy_nrxy_froshtn,Wasl,Dinar,Dollar,Barwary_froshtn) values(@ID,@Barcode,@Name_kalla,@Nrxy_froshtn,@Br_kalla,@Koy_nrxy_froshtn,@Wasl,@Dinar,@Dollar,@Barwary_froshtn)", con))
                        {
                            cmdd.Parameters.AddWithValue("@ID", row.Cells[0].Value);
                            cmdd.Parameters.AddWithValue("@Barcode", row.Cells[1].Value);
                            cmdd.Parameters.AddWithValue("@Name_kalla", row.Cells[2].Value);
                            cmdd.Parameters.AddWithValue("@Nrxy_froshtn", row.Cells[3].Value);
                            cmdd.Parameters.AddWithValue("@br_kalla", row.Cells[4].Value);
                            cmdd.Parameters.AddWithValue("@Koy_nrxy_froshtn", row.Cells[5].Value);
                            cmdd.Parameters.AddWithValue("@Wasl", txt_pswlla.Text);
                            cmdd.Parameters.AddWithValue("@Dinar", lbl_dinar.Text);
                            cmdd.Parameters.AddWithValue("@Dollar", lbl_dollar.Text);
                            cmdd.Parameters.AddWithValue("@Barwary_froshtn", lbl_timer_froshtn.Text);
                         

                            //for excute
                            con.Open();
                            cmdd.ExecuteNonQuery();
                           // MessageBox.Show("ڕاکێشرا بەسەرکەوتویی ", "ڕاکێشان", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                        }
                    }
                }
            }
            catch
            {
                
            }
        }

        private void deleteall_by_pswwlay_nwe()//katek pswlay nwe akait datakane table froshtn asretawa 
        {

                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter("delete from FROSHTN", con);
                dataGridView_bashi_froshtn.DataSource = dt;
                sa.Fill(dt);//am coday sarawa bo srynaway hamu datakani table a kaya !!!!!!


                DataTable dtt = new DataTable();
                SqlDataAdapter saa = new SqlDataAdapter("delete from print_froshtn", con);
                dataGridView_bashi_froshtn.DataSource = dtt;
                saa.Fill(dtt);



            //am coday xwarawa bo awaya ka hamu datakanman sryawa dwatr la ID 1 kawa dast pe bkatawa


            SqlCommand cmd = new SqlCommand();
               cmd.Connection = con;
               con.Open();
               cmd.CommandText = "DBCC CHECKIDENT('FROSHTN' , RESEED,0)";         //am coda bakaryat bo eshek ka la sql pewestbka bnusret ballam bmanawet lera benusin
               cmd.ExecuteNonQuery();
               con.Close();

        }

        private void txt_nrxy_kalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nrxy_kalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ema lera bashi key press e txt man krdwatawa bo away way le bkain tanha zhmara bxwenetawa larey am code anwa
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_barcode_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridView_bashi_froshtn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_nrxe_drawakan_Click(object sender, EventArgs e)
        {
            Nrxe_Dollar fm = new Nrxe_Dollar();
            fm.Show();
        }

        private void froshtn_MouseMove(object sender, MouseEventArgs e)
        {
            select_nrxe_draw();
            hsabat();
        }

        private void btn_pswllay_nwe_MouseMove(object sender, MouseEventArgs e)
        {
            //btn_pswllay_nwe.BackColor = Color.DarkRed;
            //btn_pswllay_nwe.ForeColor = Color.White;
        }

        private void btn_pswllay_nwe_MouseLeave(object sender, EventArgs e)
        {
            //btn_pswllay_nwe.BackColor = Color.Transparent;
            //btn_pswllay_nwe.ForeColor = Color.Black;
        }

        private void btn_rakeshan_MouseMove(object sender, MouseEventArgs e)
        {
            //btn_rakeshan.BackColor = Color.DarkRed;
            //btn_rakeshan.ForeColor = Color.White;
        }

        private void btn_rakeshan_MouseLeave(object sender, EventArgs e)
        {
            //btn_rakeshan.BackColor = Color.Transparent;
            //btn_rakeshan.ForeColor = Color.Black;
        }

        private void btn_tomarkrdn_MouseMove(object sender, MouseEventArgs e)
        {
            //btn_tomarkrdn.BackColor = Color.DarkRed;
            //btn_tomarkrdn.ForeColor = Color.White;
        }

        private void btn_tomarkrdn_MouseLeave(object sender, EventArgs e)
        {
            //btn_tomarkrdn.BackColor = Color.Transparent;
            //btn_tomarkrdn.ForeColor = Color.Black;
        }

        private void btn_garandnaway_pswlla_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void btn_garandnaway_pswlla_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btn_nrxe_drawakan_MouseMove(object sender, MouseEventArgs e)
        {
           //btn_nrxe_drawakan.BackColor = Color.DarkRed;
           // btn_nrxe_drawakan.ForeColor = Color.White;
        }

        private void btn_nrxe_drawakan_MouseLeave(object sender, EventArgs e)
        {
            //btn_nrxe_drawakan.BackColor = Color.Transparent;
            //btn_nrxe_drawakan.ForeColor = Color.Black;
        }

        private void lbl_dollar_Click(object sender, EventArgs e)
        {

        }

        private void panel_kallakan_MouseMove(object sender, MouseEventArgs e)
        {
            select_nrxe_draw();
            hsabat();
        }

        private void panel_dinar_MouseMove(object sender, MouseEventArgs e)
        {
            select_nrxe_draw();
            hsabat();
        }

        private void panel_dollar_MouseMove(object sender, MouseEventArgs e)
        {
            select_nrxe_draw();
            hsabat();
        }

        private void panel_psht_rast_MouseMove(object sender, MouseEventArgs e)
        {
            select_nrxe_draw();
            hsabat();
        }

        private void btn_pswllay_nwe_Click(object sender, EventArgs e)
        {

            deleteall_by_pswwlay_nwe();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from FROSHTN", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_bashi_froshtn.DataSource = dt;
            sa.Fill(dt);
            con.Open(); 
            cmd.ExecuteNonQuery();
            con.Close();
            editdatagirdview();
         


            SqlDataAdapter saa = new SqlDataAdapter("select isnull(max(cast(Wasl as int)),0)+1 from FROSHRAW ", con);
            DataTable dtt = new DataTable();
            saa.Fill(dtt);
            txt_pswlla.Text = dtt.Rows[0][0].ToString();

            
            txt_barcode.Clear();
            txt_bry_kalla.Text = "1";

            

        }

        private void btn_tomarkrdn_Click(object sender, EventArgs e)
        {
            froshraw();
          print_froshtn();
            //
            deleteall_by_pswwlay_nwe();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from FROSHTN", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_bashi_froshtn.DataSource = dt;
            sa.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            editdatagirdview();



            SqlDataAdapter saa = new SqlDataAdapter("select isnull(max(cast(Wasl as int)),0)+1 from FROSHRAW ", con);
            DataTable dtt = new DataTable();
            saa.Fill(dtt);
            txt_pswlla.Text = dtt.Rows[0][0].ToString();


            txt_barcode.Clear();
            txt_bry_kalla.Text = "1";
        }

        private void btn_rakeshan_Click(object sender, EventArgs e)
        {
            froshraw();
            print_froshtn();
            print_froshraw a =new print_froshraw();
            a.Show();
        }

        private void lbl_dinar_Click(object sender, EventArgs e)
        {

        }

        private void panel_psht_rast_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_header_froshtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_dinar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
