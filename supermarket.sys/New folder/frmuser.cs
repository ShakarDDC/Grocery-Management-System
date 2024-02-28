using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//connection

namespace supermarket.sys
{
    public partial class frmuser : Form
    {
        public static string cmb = ""; //am methoda drust krawa bo pishan dane nawe aw admin_casher anay ka login akan

        bool drag = false;   //la bashi mouse move la propireties dast kare awash akain
        Point start_point = new Point(0, 0);//bo julla krdn ba form la kate run krdn am codea lagall awaya sarawa 

        SqlConnection con=new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True"); //connection


        public frmuser()
        {
            InitializeComponent();
            console();
           
        }
        
        private void console()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from loginuser", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            dataGridView_kasher.DataSource = dt;
            sa.Fill(dt);
            con.Open(); //bo pshandani datagridview hamw katek
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void editdatagirdview()
        {
            foreach (DataGridViewColumn item in dataGridView_kasher.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//rizakan daheneteta nawarast
            }
            dataGridView_kasher.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;//header kan dahenet
            dataGridView_kasher.ColumnHeadersDefaultCellStyle.Font = new Font("Sakkal Majalla",16,FontStyle.Bold);//bo font w size dtgv
            dataGridView_kasher.Columns["id"].HeaderText = "ID";
            dataGridView_kasher.Columns["username"].HeaderText = "Name";
            dataGridView_kasher.Columns["password1"].HeaderText = "Password";
            //dataGridView_kasher.Columns["bakarhenar"].HeaderText = "User";
            DataGridViewColumn column0 = dataGridView_kasher.Columns[0];//index =id
            column0.Width = 80;
            DataGridViewColumn column1 = dataGridView_kasher.Columns[1];//index =username     //bodastkari krdne size headeary dtgv
            column1.Width = 153;
            DataGridViewColumn column2 = dataGridView_kasher.Columns[2];//index =password
            column2.Width = 153;
            dataGridView_kasher.EnableHeadersVisualStyles = false;//bo daxstne header la kate click
            dataGridView_kasher.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;//gorene range header badlle xoman
            dataGridView_kasher.ColumnHeadersDefaultCellStyle.ForeColor= Color.White;//gorene range texty header ,
            dataGridView_kasher.Columns["id"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);
            dataGridView_kasher.Columns["username"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);//edit krdne font
            dataGridView_kasher.Columns["password1"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);//w size dtgv
            //dataGridView_kasher.Columns["bakarhenar"].DefaultCellStyle.Font = new Font("Sakkal Majalla", 14, FontStyle.Bold);//w size dtgv
            dataGridView_kasher.DefaultCellStyle.ForeColor = Color.Black;//bo gorene range texty rizakane dtgv
            dataGridView_kasher.DefaultCellStyle.BackColor= Color.White;//bo gorene range rizakane dtgv
            

        }

        private void frmuser_Load(object sender, EventArgs e)
        {
            editdatagirdview();                      
            timer_casher.Enabled = true;
            timer_casher.Interval = 1;
            lbl_name_casher_admin.Text = loginform.cmb;
        }
         private void savedata()  
        {  
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into loginuser (username,password1) values(N'" + txt_name_kasher.Text + "',N'" + txt_password_casher.Text + "')", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                MessageBox.Show("Successfully added.", "Add Cashier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_name_kasher.Clear();//bo pakrdnaway textbox dway eshkrdn
                txt_password_casher.Clear();//bo pakrdnaway textbox dway eshkrdn


                SqlCommand cmdd = new SqlCommand("select * from loginuser", con);
                SqlDataAdapter saa = new SqlDataAdapter(cmdd);
                DataTable dtt = new DataTable();
                dataGridView_kasher.DataSource = dtt;
                saa.Fill(dtt);
                con.Open();
                cmdd.ExecuteNonQuery();
                con.Close();
                editdatagirdview(); 

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       
        private void deletedata() 
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter sa2 = new SqlDataAdapter("delete from loginuser where id='" + dataGridView_kasher.CurrentRow.Cells[0].Value.ToString() + "'", con);
            sa2.Fill(dt2);
            dataGridView_kasher.DataSource = dt2;
          
            
        }
        private void updatedata()
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("update loginuser set username=N'" + txt_name_kasher.Text + "',password1=N'" + txt_password_casher.Text + "',bakarhenar=N'"+lbl_name_casher_admin.Text+"'  where id=N'" + txt_3.Text + "'", con);
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter sa = new SqlDataAdapter(cmd);
            //    sa.Fill(dt);
            //    MessageBox.Show("گۆڕانکاری کرا بەسەرکەووتویی", "گۆڕانکاری", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txt_name_kasher.Clear();//bo pakrdnaway textbox dway eshkrdn
            //    txt_password_casher.Clear();//bo pakrdnaway textbox dway eshkrdn

            //    ////////////////////////
            //    //am code anay xwarawa bo yaksar pishandanaway dataya la dtgrv w da!

            //    SqlCommand cmdd = new SqlCommand("select * from loginuser", con);
            //    SqlDataAdapter saa = new SqlDataAdapter(cmdd);
            //    DataTable dtt = new DataTable();
            //    dataGridView_kasher.DataSource = dtt;
            //    saa.Fill(dtt);
            //    con.Open();
            //    cmdd.ExecuteNonQuery();
            //    con.Close();
            //    editdatagirdview(); //ama lera call krawatwa bo away desing akaman tek nachet hamw shtek lajey xoy bmenet

            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void search()
        {      //search laregay id=rezband
           //   if(comboBox_search.Text== "ڕیزبەندی")
           //   { 
           //     SqlCommand cmd = new SqlCommand("select * from loginuser where id like N'%"+txt_3.Text+"%'",con);
           //     DataTable dt = new DataTable();
           //     dataGridView_kasher.DataSource = dt;
           //     SqlDataAdapter sa = new SqlDataAdapter(cmd);
           //     sa.Fill(dt);
           //     con.Open();
           //     cmd.ExecuteNonQuery();
           //     con.Close();

           //   }

           // //search laregay username=nawe kasher 

           //else if (comboBox_search.Text == "ناوی کاشێر")
           // {
           //     SqlCommand cmd = new SqlCommand("select * from loginuser where username like N'" + txt_3.Text + "%'", con);
           //     DataTable dt = new DataTable();
           //     dataGridView_kasher.DataSource = dt;
           //     SqlDataAdapter sa = new SqlDataAdapter(cmd);
           //     sa.Fill(dt);
           //     con.Open();
           //     cmd.ExecuteNonQuery();
           //     con.Close();

           // }
        }

        //am methoda bakar yat bo away kate update hamw shtakan nanusinawaw amash charasary awaya ka katek batall jeman ahesht batal abuyawa
        private void select()
        {
            //am coda zor grnga bo away sht babatale nachet bo db la kate update krdn
            string source = @"Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            string selectquery = "select * from loginuser where username=N'" +txt_name_kasher.Text+ "'";
            SqlCommand cmd = new SqlCommand(selectquery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_password_casher.Text = (dr["password1"].ToString());
                
            }
            else
            {
                txt_password_casher.Clear();
            }
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
            this.Close();//bo daxstnaway aw formay krawatawa
        }

        private void panel_casher_MouseMove(object sender, MouseEventArgs e)// am basha taybata ba jullay formaka
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X ,p.Y - start_point.Y);//bam codan drust akret dwatr dubara dachinawa m.up/m.down

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
            //down
            drag = false;
        }

        private void timer_casher_Tick(object sender, EventArgs e)
        {
            //dway nusene am code a achina bashi form load bo nusini hanek code tr
            //lbl_time.Text = DateTime.Now.ToString("dd-MMM-yyyy   hh:mm:ss tt");//ama time stampa bo danane barwar w kat
        }

        private void txt_password_casher_KeyPress(object sender, KeyPressEventArgs e)
        {
          //nothin
        }

        private void txt_password_casher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  //ka am code bakar hat ladway keys.enter lajey enter atwanin zorbay pitakane keyboardaka daneyn !!!!{
            {
                editdatagirdview();
                //lera method akan bang akainawa  bo away eshakanman bo bkat wa bama awtret oop chunka bakurti eshaka krawa
                savedata();
                
            }
        }

        private void txt_name_kasher_TextChanged(object sender, EventArgs e)
        {
            select();
        }
    }
}
