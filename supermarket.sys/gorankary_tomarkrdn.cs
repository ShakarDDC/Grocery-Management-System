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
    public partial class gorankary_tomarkrdn : Form
    {
        bool drag = false;   //la bashi mouse move la propireties dast kare awash akain
        Point start_point = new Point(0, 0);//bo julla krdn ba form la kate run krdn am codea lagall awaya s

        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True"); //connection

        public gorankary_tomarkrdn()
        {
            InitializeComponent();
            //ama bo awaya data kane datagirdview la combobox pishan bayn la rey am codawa
            SqlDataAdapter sa = new SqlDataAdapter("select * from jorekalla", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox_jore_kalla.Items.Add(dt.Rows[i]["name"]);
            }
            //ama bo awaya data kane datagirdview la combobox pishan bayn la rey am codawa
            SqlDataAdapter saa = new SqlDataAdapter("select * from company1", con);
            DataTable dtt = new DataTable();
            saa.Fill(dtt);
            for (int x = 0; x < dtt.Rows.Count; x++)
            {
                comboBox_companya.Items.Add(dtt.Rows[x]["name"]);
            }
        }

        private void panel_header_gorankary_tomarkrdn_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);//bam codan drust akret dwatr dubara dachinawa m.up/m.down

            }
        }

        private void panel_header_gorankary_tomarkrdn_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel_header_gorankary_tomarkrdn_MouseDown(object sender, MouseEventArgs e)
        {
            //down
            drag = true;
            start_point = new Point(e.X, e.Y);//la bashi  m/down am code na anusin
        }

        private void timer_gorankary_tomarkrdn_Tick(object sender, EventArgs e)
        {
            //dway nusene am code a achina bashi form load bo nusini hanek code tr
            lbl_timer_gorankary_tomarkrdn.Text = DateTime.Now.ToString("dd-MMM-yyyy   hh:mm:ss tt");//ama time stampa bo danane barwar w kat
        }

        //am methoda bakar yat bo away kate update hamw shtakan nanusinawaw amash charasary awaya ka katek batall jeman ahesht batal abuyawa
        //lera ama bkar ahenin bo kate barcode man nusi hamu datakani trman bo bhenet bo kate update krdnawa!!!
        private void select()
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
                comboBox_jore_kalla.Text = (dr["Jory_kalla"].ToString());
                comboBox_companya.Text = (dr["Company"].ToString());
                txt_nrxe_froshtn.Text = (dr["Nrxy_froshtn"].ToString());
                date_basarchun.Text = (dr["Barwary_basarchun"].ToString());
                txt_pswllay_nwe.Text = (dr["Wasl"].ToString());
                txt_nawe_kalla.Text = (dr["Name_kalla"].ToString());
                txt_bry_kalla.Text = (dr["Br_kalla"].ToString());
                txt_nrxe_kren.Text = (dr["Nrxy_kren"].ToString());
                txt_koy_nrxe_kren.Text = (dr["Koy_nrxy_kren"].ToString());
                 txt_qazanj.Text= (dr["Qazanj"].ToString());
                date_drustkrdn.Text = (dr["Barwary_drustkrdn"].ToString());
            }
            else
            {
                comboBox_jore_kalla.Text = "";
                comboBox_companya.Text = "";
                txt_nrxe_froshtn.Clear();
                date_basarchun.Text = "";
                txt_pswllay_nwe.Clear();
                txt_nawe_kalla.Clear();
                txt_bry_kalla.Clear();
                txt_nrxe_kren.Clear();
                date_drustkrdn.Text = "";
                txt_koy_nrxe_kren.Clear();
                txt_qazanj.Clear();
            }
        }

        private void updatedata() //update button
        {
            try
            {

                SqlCommand cmd = new SqlCommand("update DAXLLKRDN_KALLA1 set Wasl=N'" + txt_pswllay_nwe.Text + "',Name_kalla=N'" + txt_nawe_kalla.Text + "',Br_kalla=N'" + txt_bry_kalla.Text + "',Nrxy_kren=N'" + txt_nrxe_kren.Text + "',Koy_nrxy_kren=N'" + txt_koy_nrxe_kren.Text + "',Qazanj=N'" + txt_qazanj.Text + "',Jory_kalla=N'" + comboBox_jore_kalla.Text + "',Company=N'" + comboBox_companya.Text + "',Bakarhenar=N'" + lbl_name_casher_admin.Text + "',Nrxy_froshtn=N'" + txt_nrxe_froshtn.Text + "',Barwary_drustkrdn=N'" + date_drustkrdn.Text + "',Barwary_basarchun=N'" + date_basarchun.Text + "',Barwary_amro='" + lbl_timer_gorankary_tomarkrdn.Text + "'    where Barcode=N'" + txt_barcode.Text + "'", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                MessageBox.Show("Item successfully edited.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                select();
            }catch
            {
                
            }
        }
        private void cleartxt()
        {
            txt_barcode.Clear();
            txt_nrxe_froshtn.Clear();
            date_basarchun.Text = "";
            txt_pswllay_nwe.Clear();
            txt_nawe_kalla.Clear();
            txt_bry_kalla.Clear();
            txt_nrxe_kren.Clear();
            date_drustkrdn.Text = "";
            txt_koy_nrxe_kren.Clear();
            txt_qazanj.Clear();
        }
       

        private void gorankary_tomarkrdn_Load(object sender, EventArgs e)
        {

            //lera am coda bo awa bakar yat nawe  aw casher yan admin pishan bat ka login e am form ay krdfwa
            lbl_name_casher_admin.Text = loginform.cmb;//amash tawaw kari aw codea ka la forme login nusewmana la methode loginuser w loginadmi
            timer_gorankary_tomarkrdn.Enabled = true;
            timer_gorankary_tomarkrdn.Interval = 1;
        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {
            select();//am methoda kate barcodeman nuse hamu datakanman bo ahene kate update krdn
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txt_barcode.Clear();
          
        }

        private void btn_gorankare_Click(object sender, EventArgs e)
        {
           
            
            updatedata();
            cleartxt();

        }

        private void txt_bry_kalla_TextChanged(object sender, EventArgs e)
        {
            try
            {   //aman bo 7sabatan bo away zh,aray kallaw ntxakay lekdan bkat 
                double x = Convert.ToDouble(txt_bry_kalla.Text);
                double y = Convert.ToDouble(txt_nrxe_kren.Text);
                double z = x * y;
                txt_koy_nrxe_kren.Text = Convert.ToString(z);
            }
            catch
            {

            }
        }

        private void txt_nrxe_kren_TextChanged(object sender, EventArgs e)
        {
            try
            {   //aman bo 7sabatan bo away zh,aray kallaw ntxakay lekdan bkat 
                double x = Convert.ToDouble(txt_bry_kalla.Text);
                double y = Convert.ToDouble(txt_nrxe_kren.Text);
                double z = x * y;
                txt_koy_nrxe_kren.Text = Convert.ToString(z);
            }
            catch
            {

            }
            try
            {   //aman bo 7sabatan bo away zh,aray kallaw ntxakay lekdan bkat 
                double x = Convert.ToDouble(txt_nrxe_froshtn.Text);
                double y = Convert.ToDouble(txt_nrxe_kren.Text);
                double z = x - y;
                txt_qazanj.Text = Convert.ToString(z);
            }
            catch
            {

            }
        }

        private void txt_nrxe_froshtn_TextChanged(object sender, EventArgs e)
        {
            try
            {   //aman bo 7sabatan bo away zh,aray kallaw ntxakay lekdan bkat 
                double x = Convert.ToDouble(txt_nrxe_froshtn.Text);
                double y = Convert.ToDouble(txt_nrxe_kren.Text);
                double z = x - y;
                txt_qazanj.Text = Convert.ToString(z);
            }
            catch
            {

            }
        }

        private void btn_gorankare_MouseLeave(object sender, EventArgs e)
        {
            //btn_gorankare.BackColor = Color.Transparent;
            //btn_gorankare.ForeColor = Color.Black;
        }

        private void btn_gorankare_MouseMove(object sender, MouseEventArgs e)
        {
            //btn_gorankare.BackColor = Color.DarkRed;
            //btn_gorankare.ForeColor = Color.White;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_jore_kalla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
