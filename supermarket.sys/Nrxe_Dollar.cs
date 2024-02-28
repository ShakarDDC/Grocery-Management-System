using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace supermarket.sys
{
    public partial class Nrxe_Dollar : Form
    {

        SqlConnection con = new SqlConnection("Data Source=SHAKAR;Initial Catalog=marketsys;Integrated Security=True");


        public Nrxe_Dollar()
        {
            InitializeComponent();
        }

        private void Nrxe_Dollar_Load(object sender, EventArgs e)
        {



        }

        private void save_draw()
        {

            try
            {
                SqlCommand cmdd = new SqlCommand("Insert into nrxy_draw (Nrxy_dollar,Nrxy_dinar) values(N'" +lbl_nrxy_dollar.Text + "', N'"+txt_nrxe_dinar.Text+"')", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmdd);
                sa.Fill(dt);
                MessageBox.Show("USD price been selected for today", "USD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }

        }

        private void update_draw()
        {

            SqlCommand cmd = new SqlCommand("update nrxy_draw set Nrxy_dinar=N'" + txt_nrxe_dinar.Text + "' where Nrxy_dollar=N'"+lbl_nrxy_dollar.Text+"'", con);
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            MessageBox.Show("USD price been selected for today", "USD", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_tomarkrdn_Click(object sender, EventArgs e)
        {
            save_draw();
            update_draw();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog opf=new OpenFileDialog();
            //if(opf.ShowDialog() == DialogResult.OK)
            //{
            //    Image img=Image.FromFile(opf.FileName);
            //    MemoryStream tmpstream = new MemoryStream();
            //    img.Save(tmpstream, System.Drawing.Imaging.ImageFormat.Png);
            //    tmpstream.Seek(0, SeekOrigin.Begin);
            //    byte[] imagedata=new byte[img.Size.Height * img.Size.Height];
            //    tmpstream.Read(imagedata, 0, img.Size.Height * img.Size.Height);

            //    string con_string = "Data Source=DESKTOP-MGD44PI;Initial Catalog=marketsys;Integrated Security=True";
            //    SqlConnection CN = new SqlConnection(con_string);

            //    string qry = "insert into img (path,logo) values(@path,@logo)";
            //    SqlCommand sqlcom = new SqlCommand(qry, CN);
            //    sqlcom.Parameters.Add(new SqlParameter("@path",opf.FileName));
            //    sqlcom.Parameters.Add(new SqlParameter("@logo", (object)imagedata));
            //    CN.Open();
            //    sqlcom.ExecuteNonQuery();
            //    CN.Close();
                


            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // string con_string = "Data Source=DESKTOP-MGD44PI;Initial Catalog=marketsys;Integrated Security=True";
           // SqlConnection CN = new SqlConnection(con_string);

           // //Initialize SQL adapter.
           // SqlDataAdapter ADAP = new SqlDataAdapter("Select * from img", CN);

           // //Initialize Dataset.
           // DataSet DS = new DataSet();

           // //Fill dataset with ImagesStore table.
           // ADAP.Fill(DS, "img");
           // DataRow Row;
           // Row = DS.Tables["img"].Rows[0];
           // byte[] MyImg = (byte[])Row[1];
           //// label2.Text = (string)Row[0];
           // MemoryStream ms = new MemoryStream(MyImg);
           // ms.Position = 0;
           // Image img = Image.FromStream(ms);
           // pictureBox1.Image = img;
            
            
           // CN.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
