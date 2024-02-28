namespace supermarket.sys
{
    partial class frmadmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin));
            this.dataGridView_kasher = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_tomarkrdn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name_admin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_casher = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lbl_name_casher_admin = new System.Windows.Forms.Label();
            this.timer_admin = new System.Windows.Forms.Timer(this.components);
            this.txt_password_admin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kasher)).BeginInit();
            this.panel_casher.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_kasher
            // 
            this.dataGridView_kasher.AllowUserToAddRows = false;
            this.dataGridView_kasher.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_kasher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_kasher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_kasher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kasher.GridColor = System.Drawing.Color.Black;
            this.dataGridView_kasher.Location = new System.Drawing.Point(11, 164);
            this.dataGridView_kasher.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView_kasher.Name = "dataGridView_kasher";
            this.dataGridView_kasher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_kasher.Size = new System.Drawing.Size(500, 315);
            this.dataGridView_kasher.TabIndex = 24;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("NRT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = global::supermarket.sys.Properties.Resources.remove_25px;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(11, 122);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(213, 36);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_tomarkrdn
            // 
            this.btn_tomarkrdn.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_tomarkrdn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tomarkrdn.Font = new System.Drawing.Font("NRT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tomarkrdn.ForeColor = System.Drawing.Color.White;
            this.btn_tomarkrdn.Image = global::supermarket.sys.Properties.Resources.add_30px;
            this.btn_tomarkrdn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tomarkrdn.Location = new System.Drawing.Point(241, 122);
            this.btn_tomarkrdn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_tomarkrdn.Name = "btn_tomarkrdn";
            this.btn_tomarkrdn.Size = new System.Drawing.Size(270, 36);
            this.btn_tomarkrdn.TabIndex = 21;
            this.btn_tomarkrdn.Text = "Add";
            this.btn_tomarkrdn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tomarkrdn.UseVisualStyleBackColor = false;
            this.btn_tomarkrdn.Click += new System.EventHandler(this.btn_tomarkrdn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NRT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(259, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NRT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // txt_name_admin
            // 
            this.txt_name_admin.BackColor = System.Drawing.Color.White;
            this.txt_name_admin.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_admin.ForeColor = System.Drawing.Color.Black;
            this.txt_name_admin.Location = new System.Drawing.Point(69, 62);
            this.txt_name_admin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_name_admin.Multiline = true;
            this.txt_name_admin.Name = "txt_name_admin";
            this.txt_name_admin.Size = new System.Drawing.Size(157, 25);
            this.txt_name_admin.TabIndex = 16;
            this.txt_name_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_name_admin.TextChanged += new System.EventHandler(this.txt_name_kasher_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NRT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_casher
            // 
            this.panel_casher.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_casher.Controls.Add(this.guna2ControlBox2);
            this.panel_casher.Controls.Add(this.guna2ControlBox1);
            this.panel_casher.Controls.Add(this.panel14);
            this.panel_casher.Controls.Add(this.lbl_name_casher_admin);
            this.panel_casher.Controls.Add(this.label1);
            this.panel_casher.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_casher.Location = new System.Drawing.Point(0, 0);
            this.panel_casher.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_casher.Name = "panel_casher";
            this.panel_casher.Size = new System.Drawing.Size(534, 41);
            this.panel_casher.TabIndex = 14;
            this.panel_casher.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_casher_MouseDown);
            this.panel_casher.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_casher_MouseMove);
            this.panel_casher.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_casher_MouseUp);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(429, 1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 35);
            this.guna2ControlBox2.TabIndex = 55;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(480, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 35);
            this.guna2ControlBox1.TabIndex = 54;
            // 
            // panel14
            // 
            this.panel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel14.BackgroundImage")));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel14.Location = new System.Drawing.Point(5, -1);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(38, 38);
            this.panel14.TabIndex = 87;
            // 
            // lbl_name_casher_admin
            // 
            this.lbl_name_casher_admin.AutoSize = true;
            this.lbl_name_casher_admin.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_casher_admin.ForeColor = System.Drawing.Color.White;
            this.lbl_name_casher_admin.Location = new System.Drawing.Point(50, 4);
            this.lbl_name_casher_admin.Name = "lbl_name_casher_admin";
            this.lbl_name_casher_admin.Size = new System.Drawing.Size(159, 32);
            this.lbl_name_casher_admin.TabIndex = 68;
            this.lbl_name_casher_admin.Text = "show admin name ";
            // 
            // timer_admin
            // 
            this.timer_admin.Tick += new System.EventHandler(this.timer_admin_Tick);
            // 
            // txt_password_admin
            // 
            this.txt_password_admin.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_admin.Location = new System.Drawing.Point(350, 60);
            this.txt_password_admin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_password_admin.Multiline = true;
            this.txt_password_admin.Name = "txt_password_admin";
            this.txt_password_admin.Size = new System.Drawing.Size(144, 25);
            this.txt_password_admin.TabIndex = 31;
            this.txt_password_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password_admin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_casher_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(531, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 450);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 450);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 488);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 3);
            this.panel3.TabIndex = 33;
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 491);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_password_admin);
            this.Controls.Add(this.dataGridView_kasher);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_tomarkrdn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name_admin);
            this.Controls.Add(this.panel_casher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmadmin";
            this.Text = "frmadmin";
            this.Load += new System.EventHandler(this.frmadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kasher)).EndInit();
            this.panel_casher.ResumeLayout(false);
            this.panel_casher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_kasher;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_tomarkrdn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name_admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_casher;
        private System.Windows.Forms.Timer timer_admin;
        private System.Windows.Forms.TextBox txt_password_admin;
        private System.Windows.Forms.Label lbl_name_casher_admin;
        private System.Windows.Forms.Panel panel14;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}