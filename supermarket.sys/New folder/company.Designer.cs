namespace supermarket.sys
{
    partial class company
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_company = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.comboBox_search = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView_company = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_nawe_company = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_gorankary = new System.Windows.Forms.Button();
            this.btn_tomarkrdn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_header_company = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_shwen = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_zhmara_mobile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tebeni = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_company)).BeginInit();
            this.panel_header_company.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_company
            // 
            this.timer_company.Tick += new System.EventHandler(this.timer_company_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("NRT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(601, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 30);
            this.label7.TabIndex = 66;
            this.label7.Text = "Search";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("NRT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(370, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 65;
            this.label6.Text = "Search by";
            // 
            // txt_3
            // 
            this.txt_3.BackColor = System.Drawing.Color.White;
            this.txt_3.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_3.Location = new System.Drawing.Point(681, 44);
            this.txt_3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_3.MaxLength = 32800;
            this.txt_3.Multiline = true;
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(168, 25);
            this.txt_3.TabIndex = 64;
            this.txt_3.TextChanged += new System.EventHandler(this.txt_3_TextChanged);
            // 
            // comboBox_search
            // 
            this.comboBox_search.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_search.FormattingEnabled = true;
            this.comboBox_search.Items.AddRange(new object[] {
            "No.",
            "Company"});
            this.comboBox_search.Location = new System.Drawing.Point(459, 45);
            this.comboBox_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_search.Name = "comboBox_search";
            this.comboBox_search.Size = new System.Drawing.Size(129, 30);
            this.comboBox_search.TabIndex = 63;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("NRT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(406, -1);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 39);
            this.label19.TabIndex = 70;
            this.label19.Text = "Companies";
            // 
            // dataGridView_company
            // 
            this.dataGridView_company.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_company.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_company.GridColor = System.Drawing.Color.Black;
            this.dataGridView_company.Location = new System.Drawing.Point(29, 84);
            this.dataGridView_company.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView_company.Name = "dataGridView_company";
            this.dataGridView_company.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_company.Size = new System.Drawing.Size(528, 353);
            this.dataGridView_company.TabIndex = 62;
            this.dataGridView_company.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_company_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(681, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 1);
            this.panel3.TabIndex = 61;
            // 
            // txt_nawe_company
            // 
            this.txt_nawe_company.BackColor = System.Drawing.Color.White;
            this.txt_nawe_company.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nawe_company.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nawe_company.Location = new System.Drawing.Point(681, 126);
            this.txt_nawe_company.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_nawe_company.Multiline = true;
            this.txt_nawe_company.Name = "txt_nawe_company";
            this.txt_nawe_company.Size = new System.Drawing.Size(211, 25);
            this.txt_nawe_company.TabIndex = 60;
            this.txt_nawe_company.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(681, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 1);
            this.panel1.TabIndex = 59;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = global::supermarket.sys.Properties.Resources.remove_25px;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(140, 44);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 34);
            this.btn_delete.TabIndex = 58;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_gorankary
            // 
            this.btn_gorankary.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_gorankary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gorankary.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gorankary.ForeColor = System.Drawing.Color.White;
            this.btn_gorankary.Image = global::supermarket.sys.Properties.Resources.available_updates_25px;
            this.btn_gorankary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gorankary.Location = new System.Drawing.Point(249, 44);
            this.btn_gorankary.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_gorankary.Name = "btn_gorankary";
            this.btn_gorankary.Size = new System.Drawing.Size(105, 33);
            this.btn_gorankary.TabIndex = 57;
            this.btn_gorankary.Text = "Edit";
            this.btn_gorankary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gorankary.UseVisualStyleBackColor = false;
            this.btn_gorankary.Click += new System.EventHandler(this.btn_gorankary_Click);
            // 
            // btn_tomarkrdn
            // 
            this.btn_tomarkrdn.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_tomarkrdn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tomarkrdn.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tomarkrdn.ForeColor = System.Drawing.Color.White;
            this.btn_tomarkrdn.Image = global::supermarket.sys.Properties.Resources.add_30px;
            this.btn_tomarkrdn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tomarkrdn.Location = new System.Drawing.Point(29, 44);
            this.btn_tomarkrdn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_tomarkrdn.Name = "btn_tomarkrdn";
            this.btn_tomarkrdn.Size = new System.Drawing.Size(107, 34);
            this.btn_tomarkrdn.TabIndex = 56;
            this.btn_tomarkrdn.Text = "Add";
            this.btn_tomarkrdn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tomarkrdn.UseVisualStyleBackColor = false;
            this.btn_tomarkrdn.Click += new System.EventHandler(this.btn_tomarkrdn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(664, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 35);
            this.label5.TabIndex = 55;
            this.label5.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NRT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(572, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 53;
            this.label1.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NRT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(628, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "No.";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(681, 85);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(211, 25);
            this.txt_id.TabIndex = 52;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(664, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 35);
            this.label4.TabIndex = 54;
            this.label4.Text = ":";
            // 
            // panel_header_company
            // 
            this.panel_header_company.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_header_company.Controls.Add(this.guna2ControlBox2);
            this.panel_header_company.Controls.Add(this.guna2ControlBox1);
            this.panel_header_company.Controls.Add(this.label19);
            this.panel_header_company.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header_company.Location = new System.Drawing.Point(0, 0);
            this.panel_header_company.Name = "panel_header_company";
            this.panel_header_company.Size = new System.Drawing.Size(974, 38);
            this.panel_header_company.TabIndex = 49;
            this.panel_header_company.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_company_MouseDown);
            this.panel_header_company.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_company_MouseMove);
            this.panel_header_company.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_header_company_MouseUp);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(878, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 35);
            this.guna2ControlBox2.TabIndex = 73;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(929, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 35);
            this.guna2ControlBox1.TabIndex = 72;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(681, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 1);
            this.panel4.TabIndex = 69;
            // 
            // txt_shwen
            // 
            this.txt_shwen.BackColor = System.Drawing.Color.White;
            this.txt_shwen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_shwen.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_shwen.Location = new System.Drawing.Point(681, 222);
            this.txt_shwen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_shwen.Multiline = true;
            this.txt_shwen.Name = "txt_shwen";
            this.txt_shwen.Size = new System.Drawing.Size(211, 25);
            this.txt_shwen.TabIndex = 68;
            this.txt_shwen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Location = new System.Drawing.Point(681, 193);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 1);
            this.panel5.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(664, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 35);
            this.label8.TabIndex = 66;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("NRT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(584, 226);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 27);
            this.label9.TabIndex = 64;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("NRT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(630, 171);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 30);
            this.label10.TabIndex = 62;
            this.label10.Text = "Tel";
            // 
            // txt_zhmara_mobile
            // 
            this.txt_zhmara_mobile.BackColor = System.Drawing.Color.White;
            this.txt_zhmara_mobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_zhmara_mobile.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_zhmara_mobile.Location = new System.Drawing.Point(681, 169);
            this.txt_zhmara_mobile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_zhmara_mobile.Multiline = true;
            this.txt_zhmara_mobile.Name = "txt_zhmara_mobile";
            this.txt_zhmara_mobile.Size = new System.Drawing.Size(211, 25);
            this.txt_zhmara_mobile.TabIndex = 63;
            this.txt_zhmara_mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(664, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 35);
            this.label11.TabIndex = 65;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("NRT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(574, 263);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 27);
            this.label12.TabIndex = 70;
            this.label12.Text = "Note";
            // 
            // txt_tebeni
            // 
            this.txt_tebeni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tebeni.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tebeni.Location = new System.Drawing.Point(600, 295);
            this.txt_tebeni.Name = "txt_tebeni";
            this.txt_tebeni.Size = new System.Drawing.Size(300, 142);
            this.txt_tebeni.TabIndex = 71;
            this.txt_tebeni.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(627, 257);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 35);
            this.label13.TabIndex = 72;
            this.label13.Text = ":";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(971, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 443);
            this.panel2.TabIndex = 73;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 440);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 3);
            this.panel6.TabIndex = 57;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SteelBlue;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 3);
            this.panel7.TabIndex = 57;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SteelBlue;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 443);
            this.panel8.TabIndex = 74;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SteelBlue;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 440);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(3, 3);
            this.panel9.TabIndex = 57;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SteelBlue;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(3, 478);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(968, 3);
            this.panel10.TabIndex = 75;
            // 
            // company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 481);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_tebeni);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_shwen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView_company);
            this.Controls.Add(this.txt_zhmara_mobile);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_nawe_company);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_gorankary);
            this.Controls.Add(this.btn_tomarkrdn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel_header_company);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "company";
            this.Text = "company";
            this.Load += new System.EventHandler(this.company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_company)).EndInit();
            this.panel_header_company.ResumeLayout(false);
            this.panel_header_company.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_company;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.ComboBox comboBox_search;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView_company;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_nawe_company;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_gorankary;
        private System.Windows.Forms.Button btn_tomarkrdn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_header_company;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_shwen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_zhmara_mobile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txt_tebeni;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
    }
}