
namespace p12
{
    partial class MDIParent1dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1dashboard));
            this.patientreadonly = new System.Windows.Forms.MenuStrip();
            this.patientbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosisbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.patbtnreadonly = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patientreadonly.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientreadonly
            // 
            this.patientreadonly.BackColor = System.Drawing.Color.PaleGreen;
            this.patientreadonly.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientbtn,
            this.logoutToolStripMenuItem,
            this.doctorbtn,
            this.diagnosisbtn,
            this.patbtnreadonly});
            this.patientreadonly.Location = new System.Drawing.Point(0, 0);
            this.patientreadonly.Name = "patientreadonly";
            this.patientreadonly.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.patientreadonly.Size = new System.Drawing.Size(1094, 24);
            this.patientreadonly.TabIndex = 0;
            this.patientreadonly.Text = "MenuStrip";
            this.patientreadonly.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // patientbtn
            // 
            this.patientbtn.Name = "patientbtn";
            this.patientbtn.Size = new System.Drawing.Size(56, 20);
            this.patientbtn.Text = "Patient";
            this.patientbtn.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // doctorbtn
            // 
            this.doctorbtn.Name = "doctorbtn";
            this.doctorbtn.Size = new System.Drawing.Size(55, 20);
            this.doctorbtn.Text = "Doctor";
            this.doctorbtn.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // diagnosisbtn
            // 
            this.diagnosisbtn.Name = "diagnosisbtn";
            this.diagnosisbtn.Size = new System.Drawing.Size(70, 20);
            this.diagnosisbtn.Text = "Diagnosis";
            this.diagnosisbtn.Click += new System.EventHandler(this.diagnosisToolStripMenuItem_Click);
            // 
            // patbtnreadonly
            // 
            this.patbtnreadonly.Name = "patbtnreadonly";
            this.patbtnreadonly.Size = new System.Drawing.Size(56, 20);
            this.patbtnreadonly.Text = "Patient";
            this.patbtnreadonly.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 615);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1094, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(965, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(841, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MDIParent1dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::p12.Properties.Resources._3dalfredlogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.patientreadonly);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.patientreadonly;
            this.Name = "MDIParent1dashboard";
            this.Load += new System.EventHandler(this.MDIParent1dashboard_Load);
            this.patientreadonly.ResumeLayout(false);
            this.patientreadonly.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip patientreadonly;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem patientbtn;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem diagnosisbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem patbtnreadonly;
    }
}



