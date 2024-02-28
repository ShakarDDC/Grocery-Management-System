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
    public partial class company : Form
    {
        bool drag = false;   //la bashi mouse move la propireties dast kare awash akain
        Point start_point = new Point(0, 0);//bo julla krdn ba form la kate run krdn am codea lagall awaya s
                                            //
        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True"); //connection

        public company()
        {
            InitializeComponent();
            //
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from company1", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_company.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void editdatagirdview()
        {
            try
            {
                foreach (DataGridViewColumn item in dataGridView_company.Columns)
                {
                    item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//rizakan daheneteta nawarast
                }
                dataGridView_company.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//header kan dahenet
                dataGridView_company.ColumnHeadersDefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//bo font w size dtgv
                dataGridView_company.Columns["ID"].HeaderText = "No.";
                dataGridView_company.Columns["name"].HeaderText = "Company";
                dataGridView_company.Columns["mobile_num"].HeaderText = "Tel";
                dataGridView_company.Columns["city"].HeaderText = "Address";
                dataGridView_company.Columns["other"].HeaderText = "Note";

                DataGridViewColumn column0 = dataGridView_company.Columns[0];//index =id
                column0.Width = 90;
                DataGridViewColumn column1 = dataGridView_company.Columns[1];//index =nawe company     //bodastkari krdne size headeary dtgv
                column1.Width = 150;
                DataGridViewColumn column2 = dataGridView_company.Columns[2];//index =phone_num
                column2.Width = 150;
                DataGridViewColumn column3 = dataGridView_company.Columns[3];//index =city
                column3.Width = 150;
                DataGridViewColumn column4 = dataGridView_company.Columns[4];//index =other
                column4.Width = 400;
                dataGridView_company.EnableHeadersVisualStyles = false;//bo daxstne header la kate click
                dataGridView_company.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;//gorene range header badlle xoman
                dataGridView_company.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//gorene range texty header ,
                dataGridView_company.Columns["ID"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);
                dataGridView_company.Columns["name"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);//edit krdne font
                dataGridView_company.Columns["mobile_num"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);
                dataGridView_company.Columns["city"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);
                dataGridView_company.Columns["other"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);

                dataGridView_company.DefaultCellStyle.ForeColor = Color.Black;//bo gorene range texty rizakane dtgv
                dataGridView_company.DefaultCellStyle.BackColor = Color.White;//bo gorene range rizakane dtgv
                                                                              //ama hamu desing e datagirdview a ba kamlee
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void savedata()  //save button or add button
        {  // add krdne data bo db w pshan danway la dtgv                                   //am pita N a bo awaya ka font e kurde bxwnetwa
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into company1 (ID,name,mobile_num,city,other) values(N'" + txt_id.Text + "',N'" +txt_nawe_company.Text + "',N'"+txt_zhmara_mobile.Text+"',N'"+txt_shwen.Text+"',N'"+txt_tebeni.Text+"')", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                MessageBox.Show("Successfully Added", "Add Company");
                txt_id.Clear();//bo pakrdnaway textbox dway eshkrdn
                txt_nawe_company.Clear();//bo pakrdnaway textbox dway eshkrdn
                txt_zhmara_mobile.Clear();
                txt_shwen.Clear();
                txt_tebeni.Clear();

                ////////////////////////
                //am code anay xwarawa bo yaksar pishandanaway dataya la dtgrv w da!

                SqlCommand cmdd = new SqlCommand("select * from company1", con);
                SqlDataAdapter saa = new SqlDataAdapter(cmdd);
                DataTable dtt = new DataTable();
                dataGridView_company.DataSource = dtt;
                saa.Fill(dtt);
                con.Open();
                cmdd.ExecuteNonQuery();
                con.Close();
                editdatagirdview(); //ama lera call krawatwa bo away desing akaman tek nachet hamw shtek lajey xoy bmenet

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //2- lera xoman method drust akain bo eshakan ex/add,delete/update/search
        private void deletedata() //delete button 
        {    // am coday xwarawa prsyar krdna pesh anjam dani karakaman
            DialogResult result = MessageBox.Show("Confirm Deleting? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from company1 where ID=N'" + txt_3.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully deleted.");
                txt_3.Clear(); //bo pakrdnaway textbox dway eshkrdn

                ////////////////////////////////// 24.11
                //am code anay xwarawa bo yaksar pishandanaway dataya la dtgrv w da!

                SqlCommand cmdd = new SqlCommand("select * from company1", con);
                SqlDataAdapter saa = new SqlDataAdapter(cmdd);
                DataTable dtt = new DataTable();
                dataGridView_company.DataSource = dtt;
                saa.Fill(dtt);
                con.Open();
                cmdd.ExecuteNonQuery();
                con.Close();
                txt_id.Clear();//bo pakrdnaway textbox dway eshkrdn
                txt_nawe_company.Clear();//bo pakrdnaway textbox dway eshkrdn
                txt_zhmara_mobile.Clear();
                txt_shwen.Clear();
                txt_tebeni.Clear();
                editdatagirdview(); //ama lera call krawatwa bo away desing akaman tek nachet hamw shtek lajey xoy bmenet
            }
        }

        private void updatedata() //update button
        {
            if (comboBox_search.Text == "No.")
            {
                SqlCommand cmd = new SqlCommand("update company1 set ID=N'" + txt_id.Text + "',name=N'" + txt_nawe_company.Text + "',mobile_num=N'" + txt_zhmara_mobile.Text + "',city=N'" + txt_shwen.Text + "',other=N'" + txt_tebeni.Text + "'  where ID=N'" + txt_3.Text + "'", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                MessageBox.Show("Successfully edited.", "Edit");
                txt_id.Clear();//bo pakrdnaway textbox dway eshkrdn
                txt_nawe_company.Clear();//bo pakrdnaway textbox dway eshkrdn
                txt_zhmara_mobile.Clear();
                txt_shwen.Clear();
                txt_tebeni.Clear();
            }
             if (comboBox_search.Text == "Company")
            {
                SqlCommand cmd = new SqlCommand("update company1 set ID=N'" + txt_id.Text + "',name=N'" + txt_nawe_company.Text + "',mobile_num=N'" + txt_zhmara_mobile.Text + "',city=N'" + txt_shwen.Text + "',other=N'" + txt_tebeni.Text + "'  where name=N'" + txt_3.Text + "'", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                MessageBox.Show("SUccessfully edited.", "Edit");
                txt_id.Clear();//bo pakrdnaway textbox dway eshkrdn
                txt_nawe_company.Clear();//bo pakrdnaway textbox dway eshkrdn
                txt_zhmara_mobile.Clear();
                txt_shwen.Clear();
                txt_tebeni.Clear();
            }

                ////////////////////////
                //am code anay xwarawa bo yaksar pishandanaway dataya la dtgrv w da!

                SqlCommand cmdd = new SqlCommand("select * from company1", con);
                SqlDataAdapter saa = new SqlDataAdapter(cmdd);
                DataTable dtt = new DataTable();
                dataGridView_company.DataSource = dtt;
                saa.Fill(dtt);
                con.Open();
                cmdd.ExecuteNonQuery();
                con.Close();
                editdatagirdview(); //ama lera call krawatwa bo away desing akaman tek nachet hamw shtek lajey xoy bmenet
            
        }

        private void search()
        {      //search laregay id=rezband
            if (comboBox_search.Text == "No.")
            {
                SqlCommand cmd = new SqlCommand("select * from company1 where ID like N'%" + txt_3.Text + "%'", con);
                DataTable dt = new DataTable();
                dataGridView_company.DataSource = dt;
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                editdatagirdview();

            }

            //search laregay username=nawe kasher 

            else if (comboBox_search.Text == "Company")
            {
                SqlCommand cmd = new SqlCommand("select * from company1 where name like N'" + txt_3.Text + "%'", con);
                DataTable dt = new DataTable();
                dataGridView_company.DataSource = dt;
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                editdatagirdview();

            }
        }


        //am methoda bakar yat bo away kate update hamw shtakan nanusinawaw amash charasary awaya ka katek batall jeman ahesht batal abuyawa
        private void select()
        {
            //am coda zor grnga bo away sht babatale nachet bo db la kate update krdn
            string source = @"Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            string selectquery = "select * from company1 where ID=N'" + txt_id.Text + "'";
            SqlCommand cmd = new SqlCommand(selectquery,con );
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_nawe_company.Text = (dr["name"].ToString());
                txt_zhmara_mobile.Text = (dr["mobile_num"].ToString());
                txt_shwen.Text = (dr["city"].ToString());
                txt_tebeni.Text = (dr["other"].ToString());

            }
            else
            {
                txt_nawe_company.Clear();
                txt_zhmara_mobile.Clear();
                txt_shwen.Clear();
                txt_tebeni.Clear();
            }
        }
        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            daxllkrdn_tomarkrdn a = new daxllkrdn_tomarkrdn();
            a.Show();
            this.Hide();//amo coda wata katet amam krd daxllkrdn bretawaw am hide bbe

        }

        private void timer_company_Tick(object sender, EventArgs e)
        {
            //dway nusene am code a achina bashi form load bo nusini hanek code tr
           // lbl_timer_company.Text = DateTime.Now.ToString("dd-MMM-yyyy   hh:mm:ss tt");//ama time stampa bo danane barwar w kat
        }

        private void company_Load(object sender, EventArgs e)
        {
            timer_company.Enabled = true;
           timer_company.Interval = 1;
            editdatagirdview();
        }

        private void panel_header_company_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);//bam codan drust akret dwatr dubara dachinawa m.up/m.down

            }
        }

        private void panel_header_company_MouseDown(object sender, MouseEventArgs e)
        {
            //down
            drag = true;
            start_point = new Point(e.X, e.Y);//la bashi  m/down am code na anusin
        }

        private void panel_header_company_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void btn_tomarkrdn_Click(object sender, EventArgs e)
        {
            editdatagirdview();
            savedata();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deletedata();//am codeay xwarwa bo awa bakar ahenm katek  clickm krd lasar xanayake dtgv aka bom delete bkat
             
            editdatagirdview();
            
        }

        private void btn_gorankary_Click(object sender, EventArgs e)
        {
            editdatagirdview();
            updatedata();
        }

        private void txt_3_TextChanged(object sender, EventArgs e)
        {
            editdatagirdview();
            search();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            select();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            daxllkrdn_tomarkrdn a = new daxllkrdn_tomarkrdn();
            a.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_company_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
