
namespace p12
{
    partial class patientform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.patientGv = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.patdob = new System.Windows.Forms.DateTimePicker();
            this.bloodcb = new System.Windows.Forms.ComboBox();
            this.gendercb = new System.Windows.Forms.ComboBox();
            this.majorcb = new System.Windows.Forms.TextBox();
            this.patage = new System.Windows.Forms.TextBox();
            this.patphone = new System.Windows.Forms.TextBox();
            this.pataddress = new System.Windows.Forms.TextBox();
            this.patname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.patid = new System.Windows.Forms.TextBox();
            this.btnloadimage = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 114);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::p12.Properties.Resources.trex;
            this.pictureBox1.Location = new System.Drawing.Point(805, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 112);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(323, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "PATIENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(306, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "DERF-REC";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(223, 475);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(124, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.login.ForeColor = System.Drawing.Color.Transparent;
            this.login.Location = new System.Drawing.Point(25, 475);
            this.login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(93, 29);
            this.login.TabIndex = 9;
            this.login.Text = "Add";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(419, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "PATIENTS LIST";
            // 
            // patientGv
            // 
            this.patientGv.BackgroundColor = System.Drawing.Color.White;
            this.patientGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.patientGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientGv.Location = new System.Drawing.Point(425, 174);
            this.patientGv.Name = "patientGv";
            this.patientGv.RowHeadersVisible = false;
            this.patientGv.Size = new System.Drawing.Size(509, 308);
            this.patientGv.TabIndex = 10;
            this.patientGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientGv_CellClick);
            this.patientGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientGv_CellContentClick);
            this.patientGv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.patientGv_CellFormatting);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Date of Birth";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = " Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(151, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Id";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(206, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = " Last name";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = " First name";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Patient age";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(120, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Major disease";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Gender";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(206, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Blood group";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Patient phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // patdob
            // 
            this.patdob.CalendarMonthBackground = System.Drawing.Color.PaleGreen;
            this.patdob.CalendarTitleBackColor = System.Drawing.Color.PaleGreen;
            this.patdob.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.patdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patdob.Location = new System.Drawing.Point(190, 241);
            this.patdob.Name = "patdob";
            this.patdob.Size = new System.Drawing.Size(176, 22);
            this.patdob.TabIndex = 22;
            this.patdob.ValueChanged += new System.EventHandler(this.patdob_ValueChanged_1);
            // 
            // bloodcb
            // 
            this.bloodcb.BackColor = System.Drawing.Color.PaleGreen;
            this.bloodcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bloodcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodcb.FormattingEnabled = true;
            this.bloodcb.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
            this.bloodcb.Location = new System.Drawing.Point(194, 345);
            this.bloodcb.Name = "bloodcb";
            this.bloodcb.Size = new System.Drawing.Size(176, 24);
            this.bloodcb.TabIndex = 21;
            this.bloodcb.SelectedIndexChanged += new System.EventHandler(this.bloodcb_SelectedIndexChanged);
            // 
            // gendercb
            // 
            this.gendercb.BackColor = System.Drawing.Color.PaleGreen;
            this.gendercb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gendercb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendercb.FormattingEnabled = true;
            this.gendercb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercb.Location = new System.Drawing.Point(12, 345);
            this.gendercb.Name = "gendercb";
            this.gendercb.Size = new System.Drawing.Size(176, 24);
            this.gendercb.TabIndex = 20;
            this.gendercb.SelectedIndexChanged += new System.EventHandler(this.gendercb_SelectedIndexChanged);
            // 
            // majorcb
            // 
            this.majorcb.BackColor = System.Drawing.Color.PaleGreen;
            this.majorcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.majorcb.Location = new System.Drawing.Point(36, 404);
            this.majorcb.Name = "majorcb";
            this.majorcb.Size = new System.Drawing.Size(275, 22);
            this.majorcb.TabIndex = 18;
            this.majorcb.TextChanged += new System.EventHandler(this.majorcb_TextChanged);
            // 
            // patage
            // 
            this.patage.BackColor = System.Drawing.Color.PaleGreen;
            this.patage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patage.Location = new System.Drawing.Point(190, 293);
            this.patage.Name = "patage";
            this.patage.ReadOnly = true;
            this.patage.Size = new System.Drawing.Size(176, 22);
            this.patage.TabIndex = 17;
            this.patage.TextChanged += new System.EventHandler(this.patage_TextChanged);
            // 
            // patphone
            // 
            this.patphone.BackColor = System.Drawing.Color.PaleGreen;
            this.patphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patphone.Location = new System.Drawing.Point(11, 293);
            this.patphone.Name = "patphone";
            this.patphone.Size = new System.Drawing.Size(173, 22);
            this.patphone.TabIndex = 16;
            this.patphone.TextChanged += new System.EventHandler(this.patphone_TextChanged);
            // 
            // pataddress
            // 
            this.pataddress.BackColor = System.Drawing.Color.PaleGreen;
            this.pataddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pataddress.Location = new System.Drawing.Point(11, 241);
            this.pataddress.Name = "pataddress";
            this.pataddress.Size = new System.Drawing.Size(173, 22);
            this.pataddress.TabIndex = 15;
            this.pataddress.TextChanged += new System.EventHandler(this.pataddress_TextChanged);
            // 
            // patname
            // 
            this.patname.BackColor = System.Drawing.Color.PaleGreen;
            this.patname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patname.Location = new System.Drawing.Point(11, 190);
            this.patname.Name = "patname";
            this.patname.Size = new System.Drawing.Size(176, 22);
            this.patname.TabIndex = 14;
            this.patname.TextChanged += new System.EventHandler(this.patname_TextChanged);
            this.patname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patname_KeyPress);
            // 
            // lastname
            // 
            this.lastname.BackColor = System.Drawing.Color.PaleGreen;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(190, 189);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(176, 22);
            this.lastname.TabIndex = 19;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // patid
            // 
            this.patid.BackColor = System.Drawing.Color.PaleGreen;
            this.patid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patid.Location = new System.Drawing.Point(82, 133);
            this.patid.Name = "patid";
            this.patid.Size = new System.Drawing.Size(176, 22);
            this.patid.TabIndex = 13;
            this.patid.TextChanged += new System.EventHandler(this.patid_TextChanged);
            // 
            // btnloadimage
            // 
            this.btnloadimage.Location = new System.Drawing.Point(139, 445);
            this.btnloadimage.Name = "btnloadimage";
            this.btnloadimage.Size = new System.Drawing.Size(75, 23);
            this.btnloadimage.TabIndex = 33;
            this.btnloadimage.Text = "load Image";
            this.btnloadimage.UseVisualStyleBackColor = true;
            this.btnloadimage.Click += new System.EventHandler(this.btnloadimage_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(737, 148);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(188, 20);
            this.txtsearch.TabIndex = 35;
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.PaleGreen;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(668, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 23);
            this.label14.TabIndex = 34;
            this.label14.Text = "Search";
            // 
            // patientform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(946, 526);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnloadimage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patdob);
            this.Controls.Add(this.bloodcb);
            this.Controls.Add(this.gendercb);
            this.Controls.Add(this.majorcb);
            this.Controls.Add(this.patage);
            this.Controls.Add(this.patphone);
            this.Controls.Add(this.pataddress);
            this.Controls.Add(this.patname);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.patid);
            this.Controls.Add(this.patientGv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "patientform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patientform";
            this.Load += new System.EventHandler(this.patientform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView patientGv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker patdob;
        private System.Windows.Forms.ComboBox bloodcb;
        private System.Windows.Forms.ComboBox gendercb;
        private System.Windows.Forms.TextBox majorcb;
        private System.Windows.Forms.TextBox patage;
        private System.Windows.Forms.TextBox patphone;
        private System.Windows.Forms.TextBox pataddress;
        private System.Windows.Forms.TextBox patname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox patid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnloadimage;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label14;
    }
}