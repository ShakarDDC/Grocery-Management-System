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
    public partial class frmadmin : Form
    {
        bool drag = false;   //la bashi mouse move la propireties dast kare awash akain
        Point start_point = new Point(0, 0);//bo julla krdn ba form la kate run krdn am codea lagall awaya sarawa 

        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True"); //connection

        public frmadmin()
        {
            InitializeComponent();
            console();

        }
        private void console()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from loginadmin ", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_kasher.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();
        }
       
        private void editdatagirdview()
        {
            try
            {
                foreach (DataGridViewColumn item in dataGridView_kasher.Columns)
                {
                    item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//rizakan daheneteta nawarast
                }
                dataGridView_kasher.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//header kan dahenet
                dataGridView_kasher.ColumnHeadersDefaultCellStyle.Font = new Font("Sakkal Majalla", 16, FontStyle.Bold);//bo font w size dtgv
                dataGridView_kasher.Columns["id"].HeaderText = "ID";
                dataGridView_kasher.Columns["username2"].HeaderText = "Name";
                dataGridView_kasher.Columns["password2"].HeaderText = "Password";
               // dataGridView_kasher.Columns["bakarhenar"].HeaderText = "بەکارهێنەر";
                DataGridViewColumn column0 = dataGridView_kasher.Columns[0];//index =id
                column0.Width = 80;
                DataGridViewColumn column1 = dataGridView_kasher.Columns[1];//index =username     //bodastkari krdne size headeary dtgv
                column1.Width = 188;
                DataGridViewColumn column2 = dataGridView_kasher.Columns[2];//index =password
                column2.Width = 190;
                dataGridView_kasher.EnableHeadersVisualStyles = false;//bo daxstne header la kate click
                dataGridView_kasher.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;//gorene range header badlle xoman
                dataGridView_kasher.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;//gorene range texty header ,
                dataGridView_kasher.Columns["id"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);
                dataGridView_kasher.Columns["username2"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);//edit krdne font
                dataGridView_kasher.Columns["password2"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);//w size dtgv
                //dataGridView_kasher.Columns["bakarhenar"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);//w size dtgv
                dataGridView_kasher.DefaultCellStyle.ForeColor = Color.Black;//bo gorene range texty rizakane dtgv
                dataGridView_kasher.DefaultCellStyle.BackColor = Color.White;//bo gorene range rizakane dtgv
            }
            catch { }

        }

        
        private void savedata()  //save button or add button
        {  
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into loginadmin (username2,password2) values(N'" + txt_name_admin.Text + "',N'" + txt_password_admin.Text + "')", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                MessageBox.Show("Successfully Added", "Add Cashier",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txt_name_admin.Clear();//bo pakrdnaway textbox dway eshkrdn
                txt_password_admin.Clear();//bo pakrdnaway textbox dway eshkrdn

                ////////////////////////
                //am code anay xwarawa bo yaksar pishandanaway dataya la dtgrv w da!

                SqlCommand cmdd = new SqlCommand("select * from loginadmin", con);
                SqlDataAdapter saa = new SqlDataAdapter(cmdd);
                DataTable dtt = new DataTable();
                dataGridView_kasher.DataSource = dtt;
                saa.Fill(dtt);
                con.Open();
                cmdd.ExecuteNonQuery();
                con.Close();
              //  editdatagirdview(); //ama lera call krawatwa bo away desing akaman tek nachet hamw shtek lajey xoy bmenet

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        private void deletedata() //delete button 
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter sa2 = new SqlDataAdapter("delete from loginadmin where id='" + dataGridView_kasher.CurrentRow.Cells[0].Value.ToString() + "'", con);
            sa2.Fill(dt2);
            dataGridView_kasher.DataSource = dt2;

        }


        private void updatedata() //update button
        {

        }

         

        private void search()
        {

        }
        
        private void select()
        {
            //am coda zor grnga bo away sht babatale nachet bo db la kate update krdn
            string source = @"Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            string selectquery = "select * from loginadmin  where username2=N'" +txt_name_admin.Text  + "'";
            SqlCommand cmd = new SqlCommand(selectquery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_password_admin.Text = (dr["password2"].ToString());

            }
            else
            {
                txt_password_admin.Clear();
            }
        }



        private void frmadmin_Load(object sender, EventArgs e)
        {
            editdatagirdview();
            timer_admin.Enabled = true;
            timer_admin.Interval = 1;
            lbl_name_casher_admin.Text = loginform.cmb;
        }

        private void btn_tomarkrdn_Click(object sender, EventArgs e)
        {
            savedata();
            editdatagirdview();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deletedata();
            console();
            editdatagirdview();


        }

        private void btn_gorankary_Click(object sender, EventArgs e)
        {
            updatedata();
            editdatagirdview();
        }

        private void txt_3_TextChanged(object sender, EventArgs e)
        {
            search();
            editdatagirdview();
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_casher_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);//bam codan drust akret dwatr dubara dachinawa m.up/m.down

            }
        }

        private void panel_casher_MouseDown(object sender, MouseEventArgs e)
        {
            //down
            drag = true;
            start_point = new Point(e.X, e.Y);//la bashi  m/down am code na anusin
        }

        private void panel_casher_MouseUp(object sender, MouseEventArgs e)
        {
            
            drag = false;
        }

        private void timer_admin_Tick(object sender, EventArgs e)
        {  
            //dway nusene am code a achina bashi form load bo nusini hanek code tr
            //lbl_time.Text = DateTime.Now.ToString("dd-MMM-yyyy   hh:mm:ss tt");//ama time stampa bo danane barwar w kat
        }

        private void txt_password_casher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  //ka am code bakar hat ladway keys.enter lajey enter atwanin zorbay pitakane keyboardaka daneyn !!!!{
            {
                //lera method akan bang akainawa  bo away eshakanman bo bkat wa bama awtret oop chunka bakurti eshaka krawa
                editdatagirdview();
                savedata();
            }
        }

        private void txt_name_kasher_TextChanged(object sender, EventArgs e)
        {
            select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
