
namespace p12
{
    partial class diagnoseform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diagnoseform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.diagsummary = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.medicinelbl = new System.Windows.Forms.Label();
            this.diagnosislbl = new System.Windows.Forms.Label();
            this.symptomslbl = new System.Windows.Forms.Label();
            this.patientnamelbl = new System.Windows.Forms.Label();
            this.diagnosisGv = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patientidcb = new System.Windows.Forms.ComboBox();
            this.patientname = new System.Windows.Forms.TextBox();
            this.diagid = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.diagnosis = new System.Windows.Forms.RichTextBox();
            this.medicine = new System.Windows.Forms.RichTextBox();
            this.symptoms = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.diagsummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 114);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::p12.Properties.Resources.trex;
            this.pictureBox1.Location = new System.Drawing.Point(805, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 112);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(312, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "DIGNOSIS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(301, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "DERF-REC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(112, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "DIAGNOSIS SUMMARY";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(247, 441);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 29);
            this.button2.TabIndex = 11;
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
            this.button1.Location = new System.Drawing.Point(148, 441);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 12;
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
            this.login.Location = new System.Drawing.Point(49, 441);
            this.login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(93, 29);
            this.login.TabIndex = 13;
            this.login.Text = "Add";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(440, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "DIAGNOSIS LIST";
            // 
            // diagsummary
            // 
            this.diagsummary.Controls.Add(this.label12);
            this.diagsummary.Controls.Add(this.medicinelbl);
            this.diagsummary.Controls.Add(this.diagnosislbl);
            this.diagsummary.Controls.Add(this.symptomslbl);
            this.diagsummary.Controls.Add(this.patientnamelbl);
            this.diagsummary.Controls.Add(this.label1);
            this.diagsummary.Location = new System.Drawing.Point(464, 121);
            this.diagsummary.Name = "diagsummary";
            this.diagsummary.Size = new System.Drawing.Size(477, 187);
            this.diagsummary.TabIndex = 16;
            this.diagsummary.Paint += new System.Windows.Forms.PaintEventHandler(this.diagsummary_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(175, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "DERF-REC";
            // 
            // medicinelbl
            // 
            this.medicinelbl.AutoSize = true;
            this.medicinelbl.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.medicinelbl.ForeColor = System.Drawing.Color.DimGray;
            this.medicinelbl.Location = new System.Drawing.Point(325, 111);
            this.medicinelbl.Name = "medicinelbl";
            this.medicinelbl.Size = new System.Drawing.Size(76, 19);
            this.medicinelbl.TabIndex = 2;
            this.medicinelbl.Text = "Medicines";
            this.medicinelbl.Click += new System.EventHandler(this.label8_Click);
            // 
            // diagnosislbl
            // 
            this.diagnosislbl.AutoSize = true;
            this.diagnosislbl.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.diagnosislbl.ForeColor = System.Drawing.Color.DimGray;
            this.diagnosislbl.Location = new System.Drawing.Point(325, 67);
            this.diagnosislbl.Name = "diagnosislbl";
            this.diagnosislbl.Size = new System.Drawing.Size(73, 19);
            this.diagnosislbl.TabIndex = 2;
            this.diagnosislbl.Text = "Diagnosis";
            this.diagnosislbl.Click += new System.EventHandler(this.label11_Click);
            // 
            // symptomslbl
            // 
            this.symptomslbl.AutoSize = true;
            this.symptomslbl.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.symptomslbl.ForeColor = System.Drawing.Color.DimGray;
            this.symptomslbl.Location = new System.Drawing.Point(20, 115);
            this.symptomslbl.Name = "symptomslbl";
            this.symptomslbl.Size = new System.Drawing.Size(80, 19);
            this.symptomslbl.TabIndex = 2;
            this.symptomslbl.Text = "Symptoms";
            this.symptomslbl.Click += new System.EventHandler(this.label10_Click);
            // 
            // patientnamelbl
            // 
            this.patientnamelbl.AutoSize = true;
            this.patientnamelbl.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.patientnamelbl.ForeColor = System.Drawing.Color.DimGray;
            this.patientnamelbl.Location = new System.Drawing.Point(20, 64);
            this.patientnamelbl.Name = "patientnamelbl";
            this.patientnamelbl.Size = new System.Drawing.Size(97, 19);
            this.patientnamelbl.TabIndex = 2;
            this.patientnamelbl.Text = "Patient name";
            this.patientnamelbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // diagnosisGv
            // 
            this.diagnosisGv.BackgroundColor = System.Drawing.Color.White;
            this.diagnosisGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diagnosisGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.diagnosisGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosisGv.Location = new System.Drawing.Point(418, 383);
            this.diagnosisGv.Name = "diagnosisGv";
            this.diagnosisGv.RowHeadersVisible = false;
            this.diagnosisGv.Size = new System.Drawing.Size(525, 101);
            this.diagnosisGv.TabIndex = 17;
            this.diagnosisGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.diagnosisGv_CellClick);
            this.diagnosisGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.diagnosisGv_CellContentClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(649, 312);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 28);
            this.button4.TabIndex = 18;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Symptoms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Medicines";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Diagnosis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Diagnosis id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Patient name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Patient id";
            // 
            // patientidcb
            // 
            this.patientidcb.BackColor = System.Drawing.Color.PaleGreen;
            this.patientidcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientidcb.FormattingEnabled = true;
            this.patientidcb.Location = new System.Drawing.Point(143, 133);
            this.patientidcb.Name = "patientidcb";
            this.patientidcb.Size = new System.Drawing.Size(125, 21);
            this.patientidcb.TabIndex = 25;
            this.patientidcb.SelectionChangeCommitted += new System.EventHandler(this.patientidcb_SelectionChangeCommitted_1);
            // 
            // patientname
            // 
            this.patientname.BackColor = System.Drawing.Color.PaleGreen;
            this.patientname.Enabled = false;
            this.patientname.Location = new System.Drawing.Point(273, 134);
            this.patientname.Name = "patientname";
            this.patientname.Size = new System.Drawing.Size(125, 20);
            this.patientname.TabIndex = 23;
            // 
            // diagid
            // 
            this.diagid.BackColor = System.Drawing.Color.PaleGreen;
            this.diagid.Location = new System.Drawing.Point(8, 134);
            this.diagid.Name = "diagid";
            this.diagid.Size = new System.Drawing.Size(125, 20);
            this.diagid.TabIndex = 24;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(774, 357);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(167, 20);
            this.txtsearch.TabIndex = 37;
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.PaleGreen;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(705, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 23);
            this.label14.TabIndex = 36;
            this.label14.Text = "Search";
            // 
            // diagnosis
            // 
            this.diagnosis.Location = new System.Drawing.Point(7, 312);
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Size = new System.Drawing.Size(196, 106);
            this.diagnosis.TabIndex = 3;
            this.diagnosis.Text = "";
            // 
            // medicine
            // 
            this.medicine.Location = new System.Drawing.Point(209, 312);
            this.medicine.Name = "medicine";
            this.medicine.Size = new System.Drawing.Size(196, 106);
            this.medicine.TabIndex = 38;
            this.medicine.Text = "";
            // 
            // symptoms
            // 
            this.symptoms.Location = new System.Drawing.Point(99, 187);
            this.symptoms.Name = "symptoms";
            this.symptoms.Size = new System.Drawing.Size(196, 106);
            this.symptoms.TabIndex = 39;
            this.symptoms.Text = "";
            // 
            // diagnoseform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(946, 526);
            this.Controls.Add(this.symptoms);
            this.Controls.Add(this.medicine);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.patientname);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.patientidcb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.diagid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.diagnosisGv);
            this.Controls.Add(this.diagsummary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "diagnoseform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "diagnoseform";
            this.Load += new System.EventHandler(this.diagnoseform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.diagsummary.ResumeLayout(false);
            this.diagsummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisGv)).EndInit();
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
        private System.Windows.Forms.Panel diagsummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label medicinelbl;
        private System.Windows.Forms.Label diagnosislbl;
        private System.Windows.Forms.Label symptomslbl;
        private System.Windows.Forms.Label patientnamelbl;
        private System.Windows.Forms.DataGridView diagnosisGv;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox patientidcb;
        private System.Windows.Forms.TextBox patientname;
        private System.Windows.Forms.TextBox diagid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox diagnosis;
        private System.Windows.Forms.RichTextBox medicine;
        private System.Windows.Forms.RichTextBox symptoms;
    }
}