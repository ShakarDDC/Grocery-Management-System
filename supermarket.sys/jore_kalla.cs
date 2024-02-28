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
    public partial class jore_kalla : Form
    {
        bool drag = false;   //la bashi mouse move la propireties dast kare awash akain
        Point start_point = new Point(0, 0);//bo julla krdn ba form la kate run krdn am codea lagall awaya s
        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True"); //connection
        public jore_kalla()
        {
            InitializeComponent();
            //
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from jorekalla ", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_jore_kalla.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void editdatagirdview()
        {
            foreach (DataGridViewColumn item in dataGridView_jore_kalla.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//rizakan daheneteta nawarast
            }
            dataGridView_jore_kalla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//header kan dahenet
            dataGridView_jore_kalla.ColumnHeadersDefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//bo font w size dtgv
            dataGridView_jore_kalla.Columns["ID"].HeaderText = "ID";
            dataGridView_jore_kalla.Columns["name"].HeaderText = "Category";
            
            DataGridViewColumn column0 = dataGridView_jore_kalla.Columns[0];//index =id
            column0.Width = 85;
            DataGridViewColumn column1 = dataGridView_jore_kalla.Columns[1];//index =username     //bodastkari krdne size headeary dtgv
            column1.Width = 185;
            
            
            dataGridView_jore_kalla.EnableHeadersVisualStyles = false;//bo daxstne header la kate click
            dataGridView_jore_kalla.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;//gorene range header badlle xoman
            dataGridView_jore_kalla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//gorene range texty header ,
            dataGridView_jore_kalla.Columns["ID"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);
            dataGridView_jore_kalla.Columns["name"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);//edit krdne font
            
            dataGridView_jore_kalla.DefaultCellStyle.ForeColor = Color.Black;//bo gorene range texty rizakane dtgv
            dataGridView_jore_kalla.DefaultCellStyle.BackColor = Color.White;//bo gorene range rizakane dtgv
            //ama hamu desing e datagirdview a ba kamlee

        }

        private void savedata()  //save button or add button
        {  // add krdne data bo db w pshan danway la dtgv                                   //am pita N a bo awaya ka font e kurde bxwnetwa
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into jorekalla (ID,name) values(N'" +txt_id.Text+ "',N'" +txt_jore_kalla.Text + "')", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                MessageBox.Show("Successfully added", "Add Item category?!");
                txt_id.Clear();//bo pakrdnaway textbox dway eshkrdn
                txt_jore_kalla.Clear();//bo pakrdnaway textbox dway eshkrdn

                ////////////////////////
                //am code anay xwarawa bo yaksar pishandanaway dataya la dtgrv w da!

                SqlCommand cmdd = new SqlCommand("select * from jorekalla", con);
                SqlDataAdapter saa = new SqlDataAdapter(cmdd);
                DataTable dtt = new DataTable();
                dataGridView_jore_kalla.DataSource = dtt;
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
            DialogResult result = MessageBox.Show("Are you sure?", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from jorekalla where ID=N'" + txt_3.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully deleted.");
                txt_3.Clear(); //bo pakrdnaway textbox dway eshkrdn

                ////////////////////////////////// 24.11
                //am code anay xwarawa bo yaksar pishandanaway dataya la dtgrv w da!

                SqlCommand cmdd = new SqlCommand("select * from jorekalla", con);
                SqlDataAdapter saa = new SqlDataAdapter(cmdd);
                DataTable dtt = new DataTable();
                dataGridView_jore_kalla.DataSource = dtt;
                saa.Fill(dtt);
                con.Open();
                cmdd.ExecuteNonQuery();
                con.Close();
                editdatagirdview(); //ama lera call krawatwa bo away desing akaman tek nachet hamw shtek lajey xoy bmenet
            }
        }

        private void updatedata() //update button
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update jorekalla set ID=N'" +txt_id.Text + "',name=N'" +txt_jore_kalla.Text + "'  where ID=N'" + txt_3.Text + "'", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                MessageBox.Show("Category Successfully edited.", "Edit");
                txt_id.Clear();//bo pakrdnaway textbox dway eshkrdn
                txt_jore_kalla.Clear();//bo pakrdnaway textbox dway eshkrdn

                ////////////////////////
                //am code anay xwarawa bo yaksar pishandanaway dataya la dtgrv w da!

                SqlCommand cmdd = new SqlCommand("select * from jorekalla", con);
                SqlDataAdapter saa = new SqlDataAdapter(cmdd);
                DataTable dtt = new DataTable();
                dataGridView_jore_kalla.DataSource = dtt;
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
        private void search()
        {      //search laregay id=rezband
            if (comboBox_search.Text == "ID")
            {
                SqlCommand cmd = new SqlCommand("select * from jorekalla where ID like N'%" + txt_3.Text + "%'", con);
                DataTable dt = new DataTable();
                dataGridView_jore_kalla.DataSource = dt;
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                editdatagirdview();

            }

            //search laregay username=nawe kasher 

            else if (comboBox_search.Text == "Name")
            {
                SqlCommand cmd = new SqlCommand("select * from jorekalla where name like N'" + txt_3.Text + "%'", con);
                DataTable dt = new DataTable();
                dataGridView_jore_kalla.DataSource = dt;
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

            string selectquery = "select * from jorekalla where ID=N'" + txt_id.Text + "'";
            SqlCommand cmd = new SqlCommand(selectquery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_jore_kalla.Text = (dr["name"].ToString());
                
              
            }
            else
            {
                txt_jore_kalla.Clear();
            }



        }
        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
           daxllkrdn_tomarkrdn a=new daxllkrdn_tomarkrdn();
            a.Show();
            this.Hide();
            // //amo coda wata katet amam krd daxllkrdn bretawaw am hide bbe
        }

        private void panel_header_jore_kalla_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);//bam codan drust akret dwatr dubara dachinawa m.up/m.down

            }
        }

        private void panel_header_jore_kalla_MouseDown(object sender, MouseEventArgs e)
        {
            //down
            drag = true;
            start_point = new Point(e.X, e.Y);//la bashi  m/down am code na anusin
        }

        private void panel_header_jore_kalla_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void jore_kalla_Load(object sender, EventArgs e)
        {
            editdatagirdview();
            timer_jorekalla.Enabled = true;
            timer_jorekalla.Interval = 1;

        }

        private void btn_tomarkrdn_Click(object sender, EventArgs e)
        {
            editdatagirdview();
            savedata();
        }

        

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            deletedata();
            
            //ama eshe nakrdwa balam labashi tomardkrdn eshe krd!!!!!!!!!!!!!!!!!
            //am codeay xwarwa bo awa bakar ahenm katek  clickm krd lasar xanayake dtgv aka bom delete bkat
            /* 
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter("delete from jorekalla where ID='" + dataGridView_jore_kalla.CurrentRow.Cells[0].Value.ToString() +"'",con);
            dataGridView_jore_kalla.DataSource = dt;
            sa.Fill(dt);

            DataTable dtt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from jorekalla",con);
            SqlDataAdapter saa = new SqlDataAdapter(cmd);
            dataGridView_jore_kalla.DataSource = dtt;
            saa.Fill(dtt);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();//21. 21 wany 14
            */
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

        private void txt_jore_kalla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  //ka am code bakar hat ladway keys.enter lajey enter atwanin zorbay pitakane keyboardaka daneyn !!!!{
            {
                //lera method akan bang akainawa  bo away eshakanman bo bkat wa bama awtret oop chunka bakurti eshaka krawa
                editdatagirdview();
                savedata();
            }
        }

        private void timer_jorekalla_Tick(object sender, EventArgs e)
        {
            //dway nusene am code a achina bashi form load bo nusini hanek code tr
            //lbl_timer_jorekalla.Text = DateTime.Now.ToString("dd-MMM-yyyy   hh:mm:ss tt");//ama time stampa bo danane barwar w kat
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            select();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            daxllkrdn_tomarkrdn a=new daxllkrdn_tomarkrdn();
            a.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_jore_kalla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IndexCombo= comboBox_search.SelectedIndex;
            editdatagirdview();
            if (IndexCombo==0)
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from jorekalla ORDER BY Id asc", con);
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                dataGridView_jore_kalla.DataSource = dt;
                sa.Fill(dt);
                con.Open(); //bo pshandani datagridview hamw katek
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from jorekalla ORDER BY Name asc", con);
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                dataGridView_jore_kalla.DataSource = dt;
                sa.Fill(dt);
                con.Open(); //bo pshandani datagridview hamw katek
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
