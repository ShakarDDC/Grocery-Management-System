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
    public partial class daxllkrdn_tomarkrdn : Form
    {
        bool drag = false;   //la bashi mouse move la propireties dast kare awash akain
        Point start_point = new Point(0, 0);//bo julla krdn ba form la kate run krdn am codea lagall awaya s

        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True"); //connection


        public daxllkrdn_tomarkrdn()
        {
            InitializeComponent();
            //ama bo awaya data kane datagirdview la combobox pishan bayn la rey am codawa
            SqlDataAdapter sa=new SqlDataAdapter("select * from jorekalla",con);
            DataTable dt=new DataTable();
            sa.Fill(dt);
            for(int i=0; i<dt.Rows.Count; i++)
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

        private void daxllkrdn_tomarkrdn_Load(object sender, EventArgs e)
        {
            //lera am coda bo awa bakar yat nawe  aw casher yan admin pishan bat ka login e am form ay krdfwa
            lbl_name_casher_admin.Text = loginform.cmb;//amash tawaw kari aw codea ka la forme login nusewmana la methode loginuser w loginadmi
            ////////////////////
            timer_zyadkrdne_kalla.Enabled = true;
            timer_zyadkrdne_kalla.Interval = 1;

            //WASLL 
            SqlDataAdapter sa = new SqlDataAdapter("select isnull(max(cast(Wasl as int)),1) from DAXLLKRDN_KALLA1 ",con);
            DataTable dt= new DataTable();
            sa.Fill(dt);
            txt_pswllay_nwe.Text = dt.Rows[0][0].ToString();



            /////////////////////////////////////////////////
            
        }

        private void timer_zyadkrdne_kalla_Tick(object sender, EventArgs e)
        {
            //dway nusene am code a achina bashi form load bo nusini hanek code tr
            lbl_timer_zyadkrdn_kalla.Text = DateTime.Now.ToString("dd-MMM-yyyy   hh:mm:ss tt");//ama time stampa bo danane barwar w kat
        }

        private void panel_header_zyadkrdn_kalla_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);//bam codan drust akret dwatr dubara dachinawa m.up/m.down

            }
        }

        private void panel_header_zyadkrdn_kalla_MouseDown(object sender, MouseEventArgs e)
        {
            //down
            drag = true;
            start_point = new Point(e.X, e.Y);//la bashi  m/down am code na anusin
        }

        private void panel_header_zyadkrdn_kalla_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

     

        private void txt_bry_kalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ema lera bashi key press e txt man krdwatawa bo away way le bkain tanha zhmara bxwenetawa larey am code anwa
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_nrxe_kren_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ema lera bashi key press e txt man krdwatawa bo away way le bkain tanha zhmara bxwenetawa larey am code anwa
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_nrxe_froshtn_KeyPress(object sender, KeyPressEventArgs e)
        {

            //ema lera bashi key press e txt man krdwatawa bo away way le bkain tanha zhmara bxwenetawa larey am code anwa
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_koy_nrxe_kren_KeyPress(object sender, KeyPressEventArgs e)
        { 
            //ema lera bashi key press e txt man krdwatawa bo away way le bkain tanha zhmara bxwenetawa larey am code anwa
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
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
            //
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

        private void btn_jore_kalla_Click(object sender, EventArgs e)
        {
            jore_kalla a = new jore_kalla();
            a.Show();
            this.Hide();
        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            company a = new company();
            a.Show();
            this.Hide();////amo coda wata katet amam krd daxllkrdn hide bbew company  bkretawa 
        }

        private void comboBox_jore_kalla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_psullay_nwe_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sa = new SqlDataAdapter("select isnull(max(cast(Wasl as int)),1)+1 from DAXLLKRDN_KALLA1 ", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            txt_pswllay_nwe.Text = dt.Rows[0][0].ToString();
        }

        private void savedata()  //save button or add button
        {  // add krdne data bo db w pshan danway la dtgv                                   //am pita N a bo awaya ka font e kurde bxwnetwa
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into DAXLLKRDN_KALLA1 (Barcode,Wasl,Name_kalla,Br_kalla,Nrxy_kren,Koy_nrxy_kren,Qazanj,Jory_kalla,Company,Bakarhenar,Nrxy_froshtn,Barwary_drustkrdn,Barwary_basarchun,Barwary_amro) values(N'" + txt_barcode.Text + "',N'" +txt_pswllay_nwe.Text + "',N'"+txt_nawe_kalla.Text+"',N'"+txt_bry_kalla.Text+"',N'"+txt_nrxe_kren.Text+"',N'"+txt_koy_nrxe_kren.Text+"',N'"+txt_qazanj.Text+"',N'"+comboBox_jore_kalla.Text+"',N'"+comboBox_companya.Text+"',N'"+lbl_name_casher_admin.Text+"',N'"+txt_nrxe_froshtn.Text+"',N'"+date_drustkrdn.Text+"',N'"+date_basarchun.Text+"',N'"+lbl_timer_zyadkrdn_kalla.Text+"')", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                MessageBox.Show("Successfully added.", "Add Item",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txt_nawe_kalla.Clear();
                txt_bry_kalla.Clear();
                txt_nrxe_kren.Clear();
                date_drustkrdn.Text = "";
                date_basarchun.Text = "";
                txt_koy_nrxe_kren.Clear();
                txt_barcode.Clear();
                txt_nrxe_froshtn.Clear();
                txt_qazanj.Clear();

            }
            catch
            {
                
            }
        }

        private void btn_zyadkrdn_kalla_Click(object sender, EventArgs e)
        {
              // 1.25.53 wanay 14

            if (string.IsNullOrEmpty(txt_barcode.Text))
            {
                MessageBox.Show("A piece of information is missing, Please check again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_bry_kalla.Text))
            {
                MessageBox.Show("A piece of information is missing, Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_nawe_kalla.Text))
            {
                MessageBox.Show("A piece of information is missing, Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_nrxe_froshtn.Text))
            {
                MessageBox.Show("A piece of information is missing, Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_nrxe_kren.Text))
            {
                MessageBox.Show("A piece of information is missing, Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(comboBox_companya.Text))
            {
                MessageBox.Show("A piece of information is missing, Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(comboBox_jore_kalla.Text))
            {
                MessageBox.Show("A piece of information is missing, Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                savedata();
            }

       

        }

        private void txt_koy_nrxe_kren_TextChanged(object sender, EventArgs e)
        {

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

        private void txt_qazanj_KeyPress(object sender, KeyPressEventArgs e)
        {
             //ema lera bashi key press e txt man krdwatawa bo away way le bkain tanha zhmara bxwenetawa larey am code anwa
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_jore_kalla_MouseMove(object sender, MouseEventArgs e)
        {
          //  btn_jore_kalla.BackColor = Color.DarkRed;
          //  btn_jore_kalla.ForeColor= Color.White;
        }

        private void btn_jore_kalla_MouseLeave(object sender, EventArgs e)
        {
           // btn_jore_kalla.BackColor = Color.Transparent;
            //btn_jore_kalla.ForeColor = Color.Black;
        }

        private void btn_company_MouseMove(object sender, MouseEventArgs e)
        {
        //    btn_company.BackColor = Color.DarkRed;
           // btn_company.ForeColor = Color.White;
        }

        private void btn_company_MouseLeave(object sender, EventArgs e)
        {
           // btn_company.BackColor = Color.Transparent;
           // btn_company.ForeColor = Color.Black;
        }

        private void btn_psullay_nwe_MouseMove(object sender, MouseEventArgs e)
        {
            //btn_psullay_nwe.BackColor = Color.DarkRed;
            //btn_psullay_nwe.ForeColor = Color.White;
        }

        private void btn_psullay_nwe_MouseLeave(object sender, EventArgs e)
        {
          //  btn_psullay_nwe.BackColor = Color.Transparent;
           // btn_psullay_nwe.ForeColor = Color.Black;
        }

        private void btn_zyadkrdn_kalla_MouseMove(object sender, MouseEventArgs e)
        {
           // btn_zyadkrdn_kalla.BackColor = Color.DarkRed;
          //  btn_zyadkrdn_kalla.ForeColor = Color.White;
        }

        private void btn_zyadkrdn_kalla_MouseLeave(object sender, EventArgs e)
        {
           // btn_zyadkrdn_kalla.BackColor = Color.Transparent;
            //btn_zyadkrdn_kalla.ForeColor = Color.Black;
        }

        private void date_drustkrdn_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
