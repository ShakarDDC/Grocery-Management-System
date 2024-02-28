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

namespace supermarket.sys//wanay 15 
{
    public partial class tomarkrdn : Form
    {
        bool drag = false;   //la bashi mouse move la propireties dast kare awash akain
        Point start_point = new Point(0, 0);//bo julla krdn ba form la kate run krdn am codea lagall awaya sarawa  
        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True"); //connection

        public tomarkrdn()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_bashi_tomarkrdn.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void tomarkrdn_Load(object sender, EventArgs e)
        {
            editdatagirdview();
            //lera am coda bo awa bakar yat nawe  aw casher yan admin pishan bat ka login e am form ay krdfwa
            lbl_name_casher_admin.Text = loginform.cmb;//amash tawaw kari aw codea ka la forme login nusewmana la methode loginuser w loginadmin
            timer_tomarkrdn.Enabled = true;
            timer_tomarkrdn.Interval = 1;
            //label5.Text=dataGridView_bashi_tomarkrdn.Rows.Count.ToString();
            data();


        }
        private void data()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter("select count (ID) from DAXLLKRDN_KALLA1", con);
            sa.Fill(dt);
            txt_1.Text = dt.Rows[0][0].ToString();

            DataTable dt1 = new DataTable();
            SqlDataAdapter sa1 = new SqlDataAdapter("select sum (Br_kalla) from DAXLLKRDN_KALLA1", con);
            sa1.Fill(dt1);
            txt_2.Text = dt1.Rows[0][0].ToString();


            DataTable dt4 = new DataTable();
            SqlDataAdapter sa4 = new SqlDataAdapter("select sum (Koy_nrxy_kren) from DAXLLKRDN_KALLA1", con);
            sa4.Fill(dt4);
            textBox_kreyn.Text = dt4.Rows[0][0].ToString();




           txt_1.Text = string.Format("{0:n0}", double.Parse(txt_1.Text));
            txt_2.Text = string.Format("{0:n0}", double.Parse(txt_2.Text));
            textBox_kreyn.Text = string.Format("{0:n0}", double.Parse(textBox_kreyn.Text));

        }

        //a///////
        public void editdatagirdview()
        {
            try
            {
                foreach (DataGridViewColumn item in dataGridView_bashi_tomarkrdn.Columns)
                {
                    item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//rizakan daheneteta nawarast
                }
                dataGridView_bashi_tomarkrdn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//header kan dahenet
                dataGridView_bashi_tomarkrdn.ColumnHeadersDefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//bo font w size dtgv
                dataGridView_bashi_tomarkrdn.Columns["ID"].HeaderText = "ID";
                dataGridView_bashi_tomarkrdn.Columns["Barcode"].HeaderText = "Barcode";
                dataGridView_bashi_tomarkrdn.Columns["Wasl"].HeaderText = "Reciept";
                dataGridView_bashi_tomarkrdn.Columns["Name_kalla"].HeaderText = "Item Name";
                dataGridView_bashi_tomarkrdn.Columns["Br_kalla"].HeaderText = "Quantity";
                dataGridView_bashi_tomarkrdn.Columns["Nrxy_kren"].HeaderText = "Purchase Price";
                dataGridView_bashi_tomarkrdn.Columns["Koy_nrxy_kren"].HeaderText = "Total Purchase Price";
                dataGridView_bashi_tomarkrdn.Columns["Qazanj"].HeaderText = "Profit";
                dataGridView_bashi_tomarkrdn.Columns["Jory_kalla"].HeaderText = "Category";
                dataGridView_bashi_tomarkrdn.Columns["Company"].HeaderText = "Company";
                dataGridView_bashi_tomarkrdn.Columns["Bakarhenar"].HeaderText = "User";
                dataGridView_bashi_tomarkrdn.Columns["Nrxy_froshtn"].HeaderText = "Sale Price";
                dataGridView_bashi_tomarkrdn.Columns["Barwary_drustkrdn"].HeaderText = "Manufacturing Date";
                dataGridView_bashi_tomarkrdn.Columns["Barwary_basarchun"].HeaderText = "Expiration Date";
                dataGridView_bashi_tomarkrdn.Columns["Barwary_amro"].HeaderText = "Purchase Date";

                //design for size !
                DataGridViewColumn column0 = dataGridView_bashi_tomarkrdn.Columns[0];//index =id
                column0.Width = 90;
                DataGridViewColumn column1 = dataGridView_bashi_tomarkrdn.Columns[1];//index =barcode     
                column1.Width = 200;
                DataGridViewColumn column2 = dataGridView_bashi_tomarkrdn.Columns[2];//index =wasl
                column2.Width = 80;
                DataGridViewColumn column3 = dataGridView_bashi_tomarkrdn.Columns[3];//index =name_kalla
                column3.Width = 180;
                DataGridViewColumn column4 = dataGridView_bashi_tomarkrdn.Columns[4];//index =br_kalla
                column4.Width = 120;
                DataGridViewColumn column5 = dataGridView_bashi_tomarkrdn.Columns[5];//index =nrxy_kren
                column5.Width = 145;
                DataGridViewColumn column6 = dataGridView_bashi_tomarkrdn.Columns[6];//index =koy_nrxe_kren
                column6.Width = 250;

                DataGridViewColumn column7 = dataGridView_bashi_tomarkrdn.Columns[7];//index =jقازانج
                column7.Width = 150;

                DataGridViewColumn column8 = dataGridView_bashi_tomarkrdn.Columns[8];//index =jory_kalla
                column8.Width = 150;
                DataGridViewColumn column9 = dataGridView_bashi_tomarkrdn.Columns[9];//index =company
                column9.Width = 130;
                DataGridViewColumn column10 = dataGridView_bashi_tomarkrdn.Columns[10];//index =bakarhenar
                column10.Width = 190;
                DataGridViewColumn column11 = dataGridView_bashi_tomarkrdn.Columns[11];//index =nrxy_froshtn
                column11.Width = 200;
                DataGridViewColumn column12 = dataGridView_bashi_tomarkrdn.Columns[12];//index =barwary_drustkrdn
                column12.Width = 250;
                DataGridViewColumn column13 = dataGridView_bashi_tomarkrdn.Columns[13];//index =barwary_basrchun
                column13.Width = 250;
                DataGridViewColumn column14 = dataGridView_bashi_tomarkrdn.Columns[14];//index =barwary_amro
                column14.Width = 270;

                //color design
                dataGridView_bashi_tomarkrdn.EnableHeadersVisualStyles = false;//bo daxstne header la kate click
                dataGridView_bashi_tomarkrdn.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;//gorene range header badlle xoman
                dataGridView_bashi_tomarkrdn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//gorene range texty header ,
                dataGridView_bashi_tomarkrdn.Columns["ID"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Barcode"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//edit krdne font
                dataGridView_bashi_tomarkrdn.Columns["Wasl"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Name_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Br_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Nrxy_kren"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Koy_nrxy_kren"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Qazanj"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Jory_kalla"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Company"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Bakarhenar"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Nrxy_froshtn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Barwary_drustkrdn"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Barwary_basarchun"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                dataGridView_bashi_tomarkrdn.Columns["Barwary_amro"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);
                ////
                dataGridView_bashi_tomarkrdn.DefaultCellStyle.ForeColor = Color.Black;//bo gorene range texty rizakane dtgv
                dataGridView_bashi_tomarkrdn.DefaultCellStyle.BackColor = Color.White;//bo gorene range rizakane dtgv
                                                                                      //ama hamu desing e datagirdview a ba kamlee
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void deleteall()
        {
            DialogResult result = MessageBox.Show("All Data Successfully been deleted.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter("delete from DAXLLKRDN_KALLA1 ", con);
                dataGridView_bashi_tomarkrdn.DataSource = dt;
                sa.Fill(dt);//am coday sarawa bo srynaway hamu datakani table a kaya !!!!!!
                            //am coday xwarawa bo awaya ka hamu datakanman sryawa dwatr la ID 1 kawa dast pe bkatawa

            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DBCC CHECKIDENT('DAXLLKRDN_KALLA1' , RESEED,0)";         //am coda bakaryat bo eshek ka la sql pewestbka bnusret ballam bmanawet lera benusin
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel_header_tomarkrdn_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);//bam codan drust akret dwatr dubara dachinawa m.up/m.down

            }
        }

        private void panel_header_tomarkrdn_MouseDown(object sender, MouseEventArgs e)
        {
            //down
            drag = true;
            start_point = new Point(e.X, e.Y);//la bashi  m/down am code na anusin
        }

        private void panel_header_tomarkrdn_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void timer_tomarkrdn_Tick(object sender, EventArgs e)
        {
            //dway nusene am code a achina bashi form load bo nusini hanek code tr
            //   lbl_timer.Text = DateTime.Now.ToString("dd-MMM-yyyy   hh:mm:ss tt");//ama time stampa bo danane barwar w kat
        }

        private void btn_zyadkrdn_kalla_Click(object sender, EventArgs e)
        {
            daxllkrdn_tomarkrdn a = new daxllkrdn_tomarkrdn();
            a.Show();
        }

        private void btn_nwekrdnawa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_bashi_tomarkrdn.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();
            comboBox_search_tomarkrdn.Text = "";
            data();
            editdatagirdview();
        }
        //
        private void search()
        {
            if (comboBox_search_tomarkrdn.Text == "ID")
            {
                SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1 where ID like N'%" + txt_search_tomarkrdn.Text + "%'", con);
                DataTable dt = new DataTable();
                dataGridView_bashi_tomarkrdn.DataSource = dt;
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                editdatagirdview();
            }

            else if (comboBox_search_tomarkrdn.Text == "Item Name")
            {
                SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1 where Name_kalla like N'" + txt_search_tomarkrdn.Text + "%'", con);
                DataTable dt = new DataTable();
                dataGridView_bashi_tomarkrdn.DataSource = dt;
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                editdatagirdview();

            }
            else if (comboBox_search_tomarkrdn.Text == "Barcode")
            {
                SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1 where Barcode like N'" + txt_search_tomarkrdn.Text + "%'", con);
                DataTable dt = new DataTable();
                dataGridView_bashi_tomarkrdn.DataSource = dt;
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                editdatagirdview();
            }
            else if (comboBox_search_tomarkrdn.Text == "Reciept")
            {
                SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1 where Wasl like N'" + txt_search_tomarkrdn.Text + "%'", con);
                DataTable dt = new DataTable();
                dataGridView_bashi_tomarkrdn.DataSource = dt;
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                editdatagirdview();
            }
            else if (comboBox_search_tomarkrdn.Text == "User")
            {
                SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1 where Bakarhenar like N'" + txt_search_tomarkrdn.Text + "%'", con);
                DataTable dt = new DataTable();
                dataGridView_bashi_tomarkrdn.DataSource = dt;
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                editdatagirdview();
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
                    SqlDataAdapter sa = new SqlDataAdapter("delete from DAXLLKRDN_KALLA1 where ID='" + dataGridView_bashi_tomarkrdn.CurrentRow.Cells[0].Value.ToString() + "'", con);
                    dataGridView_bashi_tomarkrdn.DataSource = dt;
                    sa.Fill(dt);

                    DataTable dtt = new DataTable();
                    SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1 ", con);
                    SqlDataAdapter saa = new SqlDataAdapter(cmd);
                    dataGridView_bashi_tomarkrdn.DataSource = dtt;
                    saa.Fill(dtt);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    editdatagirdview();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void print_tomarkrdn()//am methoda bakar yat bo print krdne kallakan la bashi tomarkrdn
        {
            //am coday xwarawa bo awaya katek wasle kman print krd dway awa delete bkat
            SqlCommand cmd = new SqlCommand("delete from print_tomarkrdn", con);
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            //////////////////////////
            try
            {
                //am forech a bkar ahenin bo aaway hamu value kane dtgv man bo bhenetawa wa lera parametar man bakar henawa 
                foreach (DataGridViewRow row in dataGridView_bashi_tomarkrdn.Rows)
                {
                    string constring = @"Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";

                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        using (SqlCommand cmdd = new SqlCommand("insert into [print_tomarkrdn](ID,Barcode,Wasl,Name_kalla,Br_kalla,Nrxy_kren,Koy_nrxy_kren,Jory_kalla,Company,Bakarhenar,Nrxy_froshtn,Barwary_drustkrdn,Barwary_basarchun,Barwary_amro) values(@ID,@Barcode,@Wasl,@Name_kalla,@Br_kalla,@Nrxy_kren,@Koy_nrxy_kren,@Jory_kalla,@Company,@Bakarhenar,@Nrxy_froshtn,@Barwary_drustkrdn,@Barwary_basarchun,@Barwary_amro) ", con))
                        {
                            cmdd.Parameters.AddWithValue("@ID", row.Cells[0].Value);
                            cmdd.Parameters.AddWithValue("@Barcode", row.Cells[1].Value);
                            cmdd.Parameters.AddWithValue("@Wasl", row.Cells[2].Value);
                            cmdd.Parameters.AddWithValue("@Name_kalla", row.Cells[3].Value);
                            cmdd.Parameters.AddWithValue("@Br_kalla", row.Cells[4].Value);
                            cmdd.Parameters.AddWithValue("@Nrxy_kren", row.Cells[5].Value);
                            cmdd.Parameters.AddWithValue("@Koy_nrxy_kren", row.Cells[6].Value);
                            cmdd.Parameters.AddWithValue("@Jory_kalla", row.Cells[7].Value);
                            cmdd.Parameters.AddWithValue("@Company", row.Cells[8].Value);
                            cmdd.Parameters.AddWithValue("@Bakarhenar", row.Cells[9].Value);
                            cmdd.Parameters.AddWithValue("@Nrxy_froshtn", row.Cells[10].Value);
                            cmdd.Parameters.AddWithValue("@Barwary_drustkrdn", row.Cells[11].Value);
                            cmdd.Parameters.AddWithValue("@Barwary_basarchun", row.Cells[12].Value);
                            cmdd.Parameters.AddWithValue("@Barwary_amro", row.Cells[13].Value);
                            //for excute
                            con.Open();
                            cmdd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deletedata();

        }

        private void txt_search_tomarkrdn_TextChanged(object sender, EventArgs e)
        {
            search();
            editdatagirdview();
        }

        private void btn_gorankare_Click(object sender, EventArgs e)
        {
            gorankary_tomarkrdn fm = new gorankary_tomarkrdn();
            fm.Show();
        }

        private void btn_tomarkrdn_Click(object sender, EventArgs e)
        {
            deleteall();
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from DAXLLKRDN_KALLA1", con);
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                dataGridView_bashi_tomarkrdn.DataSource = dt;
                sa.Fill(dt);
                con.Open(); //bo pshandani datagridview hamw katek
                cmd.ExecuteNonQuery();
                con.Close();
                editdatagirdview();
            }
            catch
            {

            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("Barcode", typeof(string));
            dataTable.Columns.Add("Item Name", typeof(string));
            dataTable.Columns.Add("Purchase Price", typeof(string));
            dataTable.Columns.Add("Sale Price", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(string));
            dataTable.Columns.Add("User", typeof(string));

            for (int i = 0; i < dataGridView_bashi_tomarkrdn.RowCount-1; i++)
            {
                var Id= dataGridView_bashi_tomarkrdn.Rows[i].Cells[0].Value.ToString();
                var barcode= dataGridView_bashi_tomarkrdn.Rows[i].Cells[1].Value.ToString();
                var name= dataGridView_bashi_tomarkrdn.Rows[i].Cells[3].Value.ToString();
                var Quantity= dataGridView_bashi_tomarkrdn.Rows[i].Cells[4].Value.ToString();
                var PurchasePrice= dataGridView_bashi_tomarkrdn.Rows[i].Cells[5].Value.ToString();
                var SalePrice= dataGridView_bashi_tomarkrdn.Rows[i].Cells[11].Value.ToString();
                var User= dataGridView_bashi_tomarkrdn.Rows[i].Cells[10].Value.ToString();

                dataTable.Rows.Add(Id,barcode,name,PurchasePrice,SalePrice,Quantity,User);
            }
            {
                //dataGridView_bashi_tomarkrdn.ColumnHeadersDefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//bo font w size dtgv
                //dataGridView_bashi_tomarkrdn.Columns["ID"].HeaderText = "ID";
                //dataGridView_bashi_tomarkrdn.Columns["Barcode"].HeaderText = "Barcode";
                //dataGridView_bashi_tomarkrdn.Columns["Wasl"].HeaderText = "Reciept";
                //dataGridView_bashi_tomarkrdn.Columns["Name_kalla"].HeaderText = "Item Name";
                //dataGridView_bashi_tomarkrdn.Columns["Br_kalla"].HeaderText = "Quantity";
                //dataGridView_bashi_tomarkrdn.Columns["Nrxy_kren"].HeaderText = "Purchase Price";
                //dataGridView_bashi_tomarkrdn.Columns["Koy_nrxy_kren"].HeaderText = "Total Purchase Price";
                //dataGridView_bashi_tomarkrdn.Columns["Qazanj"].HeaderText = "Profit";
                //dataGridView_bashi_tomarkrdn.Columns["Jory_kalla"].HeaderText = "Category";
                //dataGridView_bashi_tomarkrdn.Columns["Company"].HeaderText = "Company";
                //dataGridView_bashi_tomarkrdn.Columns["Bakarhenar"].HeaderText = "User";
                //dataGridView_bashi_tomarkrdn.Columns["Nrxy_froshtn"].HeaderText = "Sale Price";
                //dataGridView_bashi_tomarkrdn.Columns["Barwary_drustkrdn"].HeaderText = "Manufacturing Date";
                //dataGridView_bashi_tomarkrdn.Columns["Barwary_basarchun"].HeaderText = "Expiration Date";
                //dataGridView_bashi_tomarkrdn.Columns["Barwary_amro"].HeaderText = "Purchase Date"
            }

            print_inventory a = new print_inventory(dataTable);
            a.Show();

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

        private void btn_delete_MouseMove(object sender, MouseEventArgs e)
        {
            //btn_delete.BackColor = Color.DarkRed;
            //btn_delete.ForeColor = Color.White;
        }

        private void btn_delete_MouseLeave(object sender, EventArgs e)
        {
            // btn_delete.BackColor = Color.Transparent;
            //btn_delete.ForeColor = Color.Black;
        }

        private void btn_gorankare_MouseMove(object sender, MouseEventArgs e)
        {
            //btn_gorankare.BackColor = Color.DarkRed;
            //btn_gorankare.ForeColor = Color.White;
        }

        private void btn_gorankare_MouseLeave(object sender, EventArgs e)
        {
            //btn_gorankare.BackColor = Color.Transparent;
            //btn_gorankare.ForeColor = Color.Black;
        }

        private void btn_zyadkrdn_kalla_MouseMove(object sender, MouseEventArgs e)
        {
            //btn_zyadkrdn_kalla.BackColor = Color.DarkRed;
            //btn_zyadkrdn_kalla.ForeColor = Color.White;
        }

        private void btn_zyadkrdn_kalla_MouseLeave(object sender, EventArgs e)
        {
            //btn_zyadkrdn_kalla.BackColor = Color.Transparent;
            //btn_zyadkrdn_kalla.ForeColor = Color.Black;
        }

        private void btn_nwekrdnawa_MouseMove(object sender, MouseEventArgs e)
        {
            //btn_nwekrdnawa.BackColor = Color.DarkRed;
            //btn_nwekrdnawa.ForeColor = Color.White;
        }

        private void btn_nwekrdnawa_MouseLeave(object sender, EventArgs e)
        {
            //btn_nwekrdnawa.BackColor = Color.Transparent;
            //btn_nwekrdnawa.ForeColor = Color.Black;
        }

        private void btn_print_MouseLeave(object sender, EventArgs e)
        {
            //btn_print.BackColor = Color.Transparent;
            //btn_print.ForeColor = Color.Black;
        }

        private void btn_print_MouseMove(object sender, MouseEventArgs e)
        {
            //btn_print.BackColor = Color.DarkRed;
            //btn_print.ForeColor = Color.White;
        }

        private void dataGridView_bashi_tomarkrdn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
                
              gorankary_tomarkrdn f = new gorankary_tomarkrdn();

              f.ShowDialog();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_bashi_tomarkrdn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
