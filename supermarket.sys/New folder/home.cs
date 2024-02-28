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

namespace supermarket.sys //koga froshraw basarchu froshtn
{
    public partial class home : Form
    {
      
        //for moveing
        bool drag = false;   //la bashi mouse move la propireties dast kare awash akain
        Point start_point = new Point(0, 0);//bo julla krdn ba form la kate run krdn am codea lagall awaya sarawa 

        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True"); //connection
       


        public home()
        {
            InitializeComponent();
        }
        //for lighting !!!!
        //int counter = 0;
        //int len = 0;
        //string txt;

        private void home_Load(object sender, EventArgs e)
        {
            //lera am coda bo awa bakar yat nawe  aw casher yan admin pishan bat ka login e am form ay krdfwa
            lbl_name_casher_admin.Text = loginform.cmb;//amash tawaw kari aw codea ka la forme login nusewmana la methode loginuser w loginadmin
            //for timestap
            timer_home.Enabled = true;
            timer_home.Interval = 1;
            //for lighting
            //txt = label_1.Text;
            //len = txt.Length;
            //label_1.Text = "";
            //timer_reklam.Start();

         

        }

        private void panel_header_home_Paint(object sender, PaintEventArgs e)
        {
            //for nothing
        }

        private void panel_header_home_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);//bam codan drust akret dwatr dubara dachinawa m.up/m.down

            }
        }

        private void panel_header_home_MouseDown(object sender, MouseEventArgs e)
        {
            //down
            drag = true;
            start_point = new Point(e.X, e.Y);//la bashi  m/down am code na anusin
        }

        private void panel_header_home_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void timer_home_Tick(object sender, EventArgs e)
        {
            //dway nusene am code a achina bashi form load bo nusini hanek code tr
           // lbl_timer.Text = DateTime.Now.ToString("dd-MMM-yyyy   hh:mm:ss tt");//ama time stampa bo danane barwar w kat
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void btn_barewbar_Click(object sender, EventArgs e)
        {
            frmadmin a=new frmadmin();
            a.Show();
        }

        private void pictureBox_barebar_Click(object sender, EventArgs e)
        {
            frmadmin a = new frmadmin();
            a.Show();
        }

        private void btn_andam_Click(object sender, EventArgs e)
        {
            frmuser a=new frmuser();
            a.Show();
        }

        private void pictureBox_andam_Click(object sender, EventArgs e)
        {
            frmuser a = new frmuser();
            a.Show();
        }

        private void btn_tomarkrdn_Click(object sender, EventArgs e)
        {
            tomarkrdn a=new tomarkrdn();
            a.Show();
        }

        private void pictureBox_tomarkrdn_Click(object sender, EventArgs e)
        {
            tomarkrdn a = new tomarkrdn();
            a.Show();
        }

        private void pictureBox_froshtn_Click(object sender, EventArgs e)
        {
            froshtn fm=new froshtn();
            fm.Show();
        }

        private void btn_froshtn_Click(object sender, EventArgs e)
        {
            froshtn fm = new froshtn();
            fm.Show();
        }

        private void timer_reklam_Tick(object sender, EventArgs e)
        {
            //counter++;

            //if (counter > len)
            //{
            //    counter = 0;
            //    label_1.Text = "";

            //}
            //else
            //{
            //    label_1.Text = txt.Substring(0, counter);
            //    if (label_1.ForeColor == Color.White)
            //        label_1.ForeColor = Color.DarkRed;
            //    else
            //        label_1.ForeColor = Color.White;
            //}
        }

        private void btn_tomarkrdn_MouseEnter(object sender, EventArgs e)
        {
        //    btn_tomarkrdn.BackColor = Color.DarkRed;
        }

        private void btn_tomarkrdn_MouseLeave(object sender, EventArgs e)
        {
           // btn_tomarkrdn.BackColor = Color.White;
        }

        private void btn_dashkandn_MouseLeave(object sender, EventArgs e)
        {
           // btn_namaw.BackColor = Color.White;
        }

        private void btn_dashkandn_MouseMove(object sender, MouseEventArgs e)
        {
          //  btn_namaw.BackColor = Color.DarkRed;
        }

        private void btn_barewbar_MouseMove(object sender, MouseEventArgs e)
        {
           // btn_barewbar.BackColor = Color.DarkRed;
        }

        private void btn_barewbar_MouseLeave(object sender, EventArgs e)
        {
            //btn_barewbar.BackColor = Color.White;
        }

        private void btn_basarchu_MouseMove(object sender, MouseEventArgs e)
        {
           // btn_basarchu.BackColor = Color.DarkRed;
        }

        private void btn_basarchu_MouseLeave(object sender, EventArgs e)
        {
           // btn_basarchu.BackColor = Color.White;
        }

        private void btn_andam_MouseMove(object sender, MouseEventArgs e)
        {
           // btn_andam.BackColor = Color.DarkRed;
        }

        private void btn_andam_MouseLeave(object sender, EventArgs e)
        {
           // btn_andam.BackColor = Color.White;
        }   

        private void btn_xarjkrdn_MouseMove(object sender, MouseEventArgs e)
        {
           // btn_dashboard.BackColor = Color.DarkRed;
        }

        private void btn_xarjkrdn_MouseLeave(object sender, EventArgs e)
        {
           // btn_dashboard.BackColor = Color.White;
        }

        private void btn_froshraw_MouseMove(object sender, MouseEventArgs e)
        {
           // btn_froshraw.BackColor = Color.DarkRed;
        }

        private void btn_froshraw_MouseLeave(object sender, EventArgs e)
        {
            //btn_froshraw.BackColor = Color.White;
        }

        private void btn_qazanj_MouseMove(object sender, MouseEventArgs e)
        {
            //btn_qazanj.BackColor = Color.DarkRed;
        }

        private void btn_qazanj_MouseLeave(object sender, EventArgs e)
        {
          //  btn_qazanj.BackColor = Color.White;
        }

        private void btn_kammbu_MouseMove(object sender, MouseEventArgs e)
        {
          //  btn_kammbu.BackColor = Color.DarkRed;
        }

        private void btn_kammbu_MouseLeave(object sender, EventArgs e)
        {
           // btn_kammbu.BackColor = Color.White;
        }

        private void btn_parastn_MouseMove(object sender, MouseEventArgs e)
        {
           // btn_parastn.BackColor = Color.DarkRed;
        }

        private void btn_parastn_MouseLeave(object sender, EventArgs e)
        {
           // btn_parastn.BackColor = Color.White;
        }

        private void btn_froshtn_MouseMove(object sender, MouseEventArgs e)
        {
           // btn_froshtn.BackColor = Color.DarkRed;
        }

        private void btn_froshtn_MouseLeave(object sender, EventArgs e)
        {
           // btn_froshtn.BackColor = Color.White;
        }

        private void btn_psullakan_MouseMove(object sender, MouseEventArgs e)
        {
            //btn_psullakan.BackColor = Color.DarkRed;
        }

        private void btn_psullakan_MouseLeave(object sender, EventArgs e)
        {
            //btn_psullakan.BackColor = Color.White;
        }

        private void label_reklam_MouseMove(object sender, MouseEventArgs e)
        {
           // label_reklam.ForeColor = Color.DarkRed;
        }

        private void label_reklam_MouseLeave(object sender, EventArgs e)
        {
            //label_reklam.ForeColor = Color.White;
        }

        private void btn_froshraw_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_froshraw_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_froshraw_Click_1(object sender, EventArgs e)
        {
           froshraw a=new froshraw();
            a.Show();
        }

        private void pictureBox_froshraw_Click_1(object sender, EventArgs e)
        {
            froshraw a = new froshraw();
            a.Show();
        }

        private void pictureBox_basarchu_Click(object sender, EventArgs e)
        {
            Basarchu s = new Basarchu();
            s.Show();
        }

        private void btn_basarchu_Click(object sender, EventArgs e)
        {
            Basarchu s = new Basarchu();
            s.Show();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox_dashboard_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_kammbu_Click(object sender, EventArgs e)
        {
            kallay_kambu s=new kallay_kambu();
            s.Show();
        }

        private void pictureBox_kambuu_Click(object sender, EventArgs e)
        {
            kallay_kambu s = new kallay_kambu();
            s.Show();
        }

        private void pictureBox_namaw_Click(object sender, EventArgs e)
        {
            Namaw a = new Namaw();
            a.Show();
        }

        private void btn_namaw_Click(object sender, EventArgs e)
        {
            Namaw a = new Namaw();
            a.Show();
        }

        private void panel58_Click(object sender, EventArgs e)
        {
            jore_kalla a=new jore_kalla();
            a.Show();
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            Nrxe_Dollar nrxe_Dollar = new Nrxe_Dollar();
            nrxe_Dollar.Show();
        }

        private void panel38_Click(object sender, EventArgs e)
        {
            company company = new company();
            company.Show();
        }

        private void panel48_Click(object sender, EventArgs e)
        {
            frmuser frmuser = new frmuser();
            frmuser.Show();
        }

        private void pic_koga_Click(object sender, EventArgs e)
        {
            tomarkrdn tomarkrdn = new tomarkrdn();
            tomarkrdn.Show();
        }

        private void panel40_Click(object sender, EventArgs e)
        {
            froshraw froshraw = new froshraw();
            froshraw.Show();
        }

        private void p_froshtny_kaLla_Click(object sender, EventArgs e)
        {
            froshtn froshtn = new froshtn();
            froshtn.Show();
        }

        private void panel29_Click(object sender, EventArgs e)
        {
            Basarchu basarchu = new Basarchu();
            basarchu.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pic_tomary_kalla_Click(object sender, EventArgs e)
        {
            daxllkrdn_tomarkrdn a=new daxllkrdn_tomarkrdn();
            a.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            froshraw a=new froshraw();
            a.Show();
        }

        private void panel54_Click(object sender, EventArgs e)
        {
            frmadmin a=new frmadmin();
            a.Show();
        }

        private void panel44_Click(object sender, EventArgs e)
        {
            kallay_kambu a=new kallay_kambu();  
            a.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            Namaw a=new Namaw();
            a.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            kallay_kambu a=new kallay_kambu();
            a.Show();

        }

        private void panel40_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_my_name_Click(object sender, EventArgs e)
        {

        }
    }
}
