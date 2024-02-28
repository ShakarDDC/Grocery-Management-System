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
    public partial class loginform : Form
    { // am coday xwarwa yak jar la login form drust akain etr lawani tr bangi akainawa
        public static string cmb = ""; //am methoda drust krawa bo pishan dane nawe aw admin_casher anay ka login akan 
        ////////////////////////////////////
        bool drag = false;   //la bashi mouse move la propireties dast kare awash akain
        Point start_point = new Point(0, 0);//bo julla krdn ba form la kate run krdn am codea lagall awaya sarawa 
        ////////////////////////////////////
        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True"); //connectio
        public loginform()
        {  
            InitializeComponent();
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            //btn_hide.Visible= false;// ama bo awaya ka clickm la yakekyan krd awetrishm bo labat 
         //   btn_show.Visible = true;
            
        }
        /////////////////////////////

        //ama bo login admin
        private void loginadmin() //agar wak admin bchita zhurawa !
        {
            //ba kurte ama form vallidationa ba shewazeke sada w asan ! he taza tr5 azanm !

          if(textBox_wshay_nhene.Text=="" && comboBox_casher_admin.Text == "")
            {
                MessageBox.Show(" Invalid username or password.", "Login failed,", MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox_wshay_nhene.Focus();
                comboBox_casher_admin.Focus();//am 2 coda bakar yan bo pshandani error la kate bune error
                return;
            }
          
          else if (comboBox_casher_admin.Text == "")
            {
                MessageBox.Show("Invalid username or password.", "Login failed,", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_casher_admin.Focus();//am 2 coda bakar yan bo pshandani error la kate bune error
                return;
            }

          else if (textBox_wshay_nhene.Text=="")
            {
                MessageBox.Show("Invalid username or password.", "Login failed,", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_wshay_nhene.Focus();
                //am 2 coda bakar yan bo pshandani error la kate bune error
                return;
            }
            try
            {
                //ama bo masalay login a ba jwane ley tenagashtum anyway !!!!!1
                if (comboBox_casher_admin.Text == "Admin")
                {
                    string s = "Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";
                    SqlConnection myconnection = default(SqlConnection);
                    myconnection = new SqlConnection(s);
                    SqlCommand mycommand = default(SqlCommand);
                    mycommand = new SqlCommand("select username2, password2 from loginadmin where username2=@Username and password2=@Password",myconnection);
                    SqlParameter uname = new SqlParameter("@Username", SqlDbType.NChar);
                    SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.NChar);
                    uname.Value = comboBox_name.Text;
                    uPassword.Value = textBox_wshay_nhene.Text;
                    mycommand.Parameters.Add(uname);
                    mycommand.Parameters.Add(uPassword);
                    mycommand.Connection.Open();
                    SqlDataReader reader=mycommand.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.Read() == true)//agar am coda nay sarawa rast bun am form a dabxarawaw brora forme fome(saraky)
                    {
                        this.Hide();
                        home a = new home();
                        cmb=comboBox_name.Text;//am coda bo pishan dani nawe aw kasay ka daxl bwa wata casher bet yan admin dwatr achia form load e formakay tr !
                        a.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please try again later.", "Error!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        textBox_wshay_nhene.Clear();
                        comboBox_name.Focus();
                    }
                    if (myconnection.State == ConnectionState.Open)
                    {
                        myconnection.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"error");
            }
        }
        ///////////////////////////////////////////////
        //ama bo login user 
        private void loginuser()
        {
            //ba kurte ama form vallidationa ba shewazeke sada w asan ! he taza tr5 azanm !

            if (textBox_wshay_nhene.Text == "" && comboBox_casher_admin.Text == "")
            {
                MessageBox.Show("Invalid username or password.", "Login failed,", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_wshay_nhene.Focus();
                comboBox_casher_admin.Focus();//am 2 coda bakar yan bo pshandani error la kate bune error
                return;
            }

            else if (comboBox_casher_admin.Text == "")
            {
                MessageBox.Show("Invalid username or password.", "Login failed,", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_casher_admin.Focus();//am 2 coda bakar yan bo pshandani error la kate bune error
                return;
            }

            else if (textBox_wshay_nhene.Text == "")
            {
                MessageBox.Show("Invalid username or password.", "Login failed,", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_wshay_nhene.Focus();
                //am 2 coda bakar yan bo pshandani error la kate bune error
                return;
            }
            try
            {
                //ama bo masalay login a ba jwane ley tenagashtum anyway !!!!!1
                if (comboBox_casher_admin.Text == "Cashier")
                {
                    string s = "Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True";
                    SqlConnection myconnection = default(SqlConnection);
                    myconnection = new SqlConnection(s);
                    SqlCommand mycommand = default(SqlCommand);
                    mycommand = new SqlCommand("select username, password1 from loginuser where username=@Username and password1=@Password", myconnection);
                    SqlParameter uname = new SqlParameter("@Username", SqlDbType.NChar);
                    SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.NChar);
                    uname.Value = comboBox_name.Text;
                    uPassword.Value = textBox_wshay_nhene.Text;
                    mycommand.Parameters.Add(uname);
                    mycommand.Parameters.Add(uPassword);
                    mycommand.Connection.Open();
                    SqlDataReader reader = mycommand.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.Read() == true)//agar am coda nay sarawa rast bun am form a dabxarawaw brora forme fome(saraky)
                    {
                        this.Hide();
                        cmb = comboBox_name.Text;//am coda bo pishan dani nawe aw kasay ka daxl bwa wata casher bet yan admin dwatr achia form load e formakay tr !
                        froshtn a = new froshtn();
                        a.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_wshay_nhene.Clear();
                        comboBox_name.Focus();
                    }
                    if (myconnection.State == ConnectionState.Open)
                    {
                        myconnection.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
        ///////////////////////////////////////////////

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            this.Close();//for close
        }
        ///////////////////////////////////////////////

        private void btn_show_Click(object sender, EventArgs e)
        {//am codeana bo hidw show e passworda
            if (textBox_wshay_nhene.UseSystemPasswordChar == true)
            {
                textBox_wshay_nhene.UseSystemPasswordChar= false;
               // btn_show.Visible = false;
               // btn_hide.Visible = true;
            }
        }
        ///////////////////////////////////////////////
        private void btn_hide_Click(object sender, EventArgs e)
        {    //am codeana bo hidw show e passworda wa handek la codakan abaina naw form load
            if (textBox_wshay_nhene.UseSystemPasswordChar == false)
            {
                textBox_wshay_nhene.UseSystemPasswordChar = true;
                
              //  btn_hide.Visible = false;
                //btn_show.Visible = true;
            }
        }
        ///////////////////////////////////////////////
        private void panel_header_marketeyhalabja_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);//bam codan drust akret dwatr dubara dachinawa m.up/m.d
            }
        }
        ///////////////////////////////////////////////
        private void panel_header_marketeyhalabja_MouseUp(object sender, MouseEventArgs e)
        {
            //down
            drag = false;
        }
        ///////////////////////////////////////////////
        private void panel_header_marketeyhalabja_MouseDown(object sender, MouseEventArgs e)
        {
            //down
            drag = true;
            start_point = new Point(e.X, e.Y);//la bashi  m/down am code na anusin
        }
        ///////////////////////////////////////////////
        private void comboBox_casher_admin_SelectedIndexChanged(object sender, EventArgs e)
        {//lera ama akain bo away ba pey hallbzhardne xoman la combobox aka aya casher halabzjerin yan admin
         //wa dway awa loop bakar ahenin boaway username e table casher yan admin man bo bxwenetawa .
            if (comboBox_casher_admin.Text == "Admin")
            {
                comboBox_name.Items.Clear();//bo pakrnaway cmbo ka oesh eshkrdn
                SqlDataAdapter da = new SqlDataAdapter("select * from loginadmin", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox_name.Items.Add(dt.Rows[i]["username2"]);
                }
            }
            ///////////////////////ama bo jyakrdnaway if w else kaya
            else if(comboBox_casher_admin.Text== "Cashier")
            {
                comboBox_name.Items.Clear();//bo pakrnaway cmbo ka oesh eshkrdn
                SqlDataAdapter da = new SqlDataAdapter("select * from loginuser", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox_name.Items.Add(dt.Rows[i]["username"]);
                }
            }
        }
        ///////////////////////////////////////////////
        private void btn_daxllbun_Click(object sender, EventArgs e)
        {
            if (comboBox_casher_admin.Text == "Admin")
            {
                loginadmin();

            }
           else if (comboBox_casher_admin.Text == "Cashier")
            {
                loginuser();
            }   
            else if (comboBox_casher_admin.Text == "")
            {
                loginadmin();//am if aman boya dana agar combobox akaman batall bu har errora kani user w adminman bdate !!!!!!
            }
        }
        ///////////////////////////////////////////////
        private void textBox_wshay_nhene_KeyDown(object sender, KeyEventArgs e)
        {
            //ama txt passwordakaya la bashi event amamn krdwatawaw henawmana

            if (e.KeyCode == Keys.Enter)  //ka am code bakar hat ladway keys.enter lajey enter atwanin zorbay pitakane keyboardaka daneyn !!!!{
            {
                if (comboBox_casher_admin.Text == "Admin")
                {
                    loginadmin();

                }
                if (comboBox_casher_admin.Text == "Cashier")
                {
                    loginuser();
                }   //lera method akan bang akainawa  bo away eshakanman bo bkat wa bama awtret oop chunka bakurti eshaka krawa
            }
        }
        ///////////////////////////////////////////////
        private void panel_header_marketeyhalabja_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_wshay_nhene_KeyPress(object sender, KeyPressEventArgs e)
        {
          // e.Handled= true; // bo away password ba kurdi nabet
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_daxllbun_MouseMove(object sender, MouseEventArgs e)
        {
           // btn_daxllbun.BackColor = Color.Red;
        }

        private void btn_daxllbun_MouseLeave(object sender, EventArgs e)
        {
          //  btn_daxllbun.BackColor = Color.DarkRed;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
