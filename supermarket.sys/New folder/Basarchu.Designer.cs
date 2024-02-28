namespace supermarket.sys
{
    partial class Basarchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basarchu));
            this.dataGridView_bashi_basarchwu = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.timer_basarchu = new System.Windows.Forms.Timer(this.components);
            this.panel14 = new System.Windows.Forms.Panel();
            this.lbl_name_casher_admin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_header_tomarkrdn = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_gorankare = new System.Windows.Forms.Button();
            this.btn_nwekrdnawa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_expire_barcode = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bashi_basarchwu)).BeginInit();
            this.panel_header_tomarkrdn.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_bashi_basarchwu
            // 
            this.dataGridView_bashi_basarchwu.AllowUserToAddRows = false;
            this.dataGridView_bashi_basarchwu.AllowUserToDeleteRows = false;
            this.dataGridView_bashi_basarchwu.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_bashi_basarchwu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_bashi_basarchwu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bashi_basarchwu.GridColor = System.Drawing.Color.Black;
            this.dataGridView_bashi_basarchwu.Location = new System.Drawing.Point(-35, 195);
            this.dataGridView_bashi_basarchwu.Name = "dataGridView_bashi_basarchwu";
            this.dataGridView_bashi_basarchwu.ReadOnly = true;
            this.dataGridView_bashi_basarchwu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_bashi_basarchwu.Size = new System.Drawing.Size(1389, 452);
            this.dataGridView_bashi_basarchwu.TabIndex = 32;
            this.dataGridView_bashi_basarchwu.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_bashi_basarchwu_RowPrePaint);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("NRT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = global::supermarket.sys.Properties.Resources.remove_25px;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(1158, 96);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(180, 43);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // timer_basarchu
            // 
            this.timer_basarchu.Tick += new System.EventHandler(this.timer_basarchu_Tick);
            // 
            // panel14
            // 
            this.panel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel14.BackgroundImage")));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel14.Location = new System.Drawing.Point(14, 6);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(38, 38);
            this.panel14.TabIndex = 87;
            // 
            // lbl_name_casher_admin
            // 
            this.lbl_name_casher_admin.AutoSize = true;
            this.lbl_name_casher_admin.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_casher_admin.ForeColor = System.Drawing.Color.White;
            this.lbl_name_casher_admin.Location = new System.Drawing.Point(46, 10);
            this.lbl_name_casher_admin.Name = "lbl_name_casher_admin";
            this.lbl_name_casher_admin.Size = new System.Drawing.Size(159, 32);
            this.lbl_name_casher_admin.TabIndex = 9;
            this.lbl_name_casher_admin.Text = "show admin name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NRT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(563, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Expired section";
            // 
            // panel_header_tomarkrdn
            // 
            this.panel_header_tomarkrdn.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_header_tomarkrdn.Controls.Add(this.guna2ControlBox2);
            this.panel_header_tomarkrdn.Controls.Add(this.panel14);
            this.panel_header_tomarkrdn.Controls.Add(this.guna2ControlBox1);
            this.panel_header_tomarkrdn.Controls.Add(this.lbl_name_casher_admin);
            this.panel_header_tomarkrdn.Controls.Add(this.label1);
            this.panel_header_tomarkrdn.Location = new System.Drawing.Point(-4, -6);
            this.panel_header_tomarkrdn.Name = "panel_header_tomarkrdn";
            this.panel_header_tomarkrdn.Size = new System.Drawing.Size(1374, 47);
            this.panel_header_tomarkrdn.TabIndex = 24;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1262, 10);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 35);
            this.guna2ControlBox2.TabIndex = 57;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1313, 10);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 35);
            this.guna2ControlBox1.TabIndex = 56;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(469, 49);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 41);
            this.dateTimePicker2.TabIndex = 39;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(469, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 41);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Sakkal Majalla", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Image = global::supermarket.sys.Properties.Resources.search_30px;
            this.btn_search.Location = new System.Drawing.Point(1056, 96);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(47, 43);
            this.btn_search.TabIndex = 40;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_gorankare
            // 
            this.btn_gorankare.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_gorankare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gorankare.Font = new System.Drawing.Font("NRT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gorankare.ForeColor = System.Drawing.Color.White;
            this.btn_gorankare.Image = global::supermarket.sys.Properties.Resources.available_updates_25px;
            this.btn_gorankare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gorankare.Location = new System.Drawing.Point(1056, 47);
            this.btn_gorankare.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_gorankare.Name = "btn_gorankare";
            this.btn_gorankare.Size = new System.Drawing.Size(282, 43);
            this.btn_gorankare.TabIndex = 44;
            this.btn_gorankare.Text = "Edit";
            this.btn_gorankare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gorankare.UseVisualStyleBackColor = false;
            this.btn_gorankare.Click += new System.EventHandler(this.btn_gorankare_Click);
            // 
            // btn_nwekrdnawa
            // 
            this.btn_nwekrdnawa.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nwekrdnawa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nwekrdnawa.Font = new System.Drawing.Font("NRT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nwekrdnawa.ForeColor = System.Drawing.Color.White;
            this.btn_nwekrdnawa.Image = global::supermarket.sys.Properties.Resources.available_updates_25px;
            this.btn_nwekrdnawa.Location = new System.Drawing.Point(1107, 96);
            this.btn_nwekrdnawa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_nwekrdnawa.Name = "btn_nwekrdnawa";
            this.btn_nwekrdnawa.Size = new System.Drawing.Size(47, 43);
            this.btn_nwekrdnawa.TabIndex = 45;
            this.btn_nwekrdnawa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nwekrdnawa.UseVisualStyleBackColor = false;
            this.btn_nwekrdnawa.Click += new System.EventHandler(this.btn_nwekrdnawa_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.listBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(18, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 104);
            this.listBox1.TabIndex = 42;
            // 
            // btn_expire_barcode
            // 
            this.btn_expire_barcode.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_expire_barcode.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expire_barcode.ForeColor = System.Drawing.Color.White;
            this.btn_expire_barcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_expire_barcode.Location = new System.Drawing.Point(18, 45);
            this.btn_expire_barcode.Name = "btn_expire_barcode";
            this.btn_expire_barcode.Size = new System.Drawing.Size(372, 43);
            this.btn_expire_barcode.TabIndex = 43;
            this.btn_expire_barcode.Text = "Add item";
            this.btn_expire_barcode.UseVisualStyleBackColor = false;
            this.btn_expire_barcode.Click += new System.EventHandler(this.btn_expire_barcode_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.listBox2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(207, 94);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(183, 104);
            this.listBox2.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("NRT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(517, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 30);
            this.label7.TabIndex = 67;
            this.label7.Text = "-- To --";
            // 
            // Basarchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_nwekrdnawa);
            this.Controls.Add(this.btn_gorankare);
            this.Controls.Add(this.btn_expire_barcode);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView_bashi_basarchwu);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.panel_header_tomarkrdn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Basarchu";
            this.Text = "Basarchu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Basarchu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bashi_basarchwu)).EndInit();
            this.panel_header_tomarkrdn.ResumeLayout(false);
            this.panel_header_tomarkrdn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_bashi_basarchwu;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Timer timer_basarchu;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lbl_name_casher_admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_header_tomarkrdn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_search;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Button btn_gorankare;
        private System.Windows.Forms.Button btn_nwekrdnawa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_expire_barcode;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label7;
    }
}