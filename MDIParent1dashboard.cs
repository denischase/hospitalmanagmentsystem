using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p12
{
    public partial class MDIParent1dashboard : Form
    {
        private int childFormNumber = 0;

        public MDIParent1dashboard(string user)
        {
            InitializeComponent();
            label1.Text = user;
             foreach (Control ctl in this.Controls)
    {
        if (ctl is MdiClient)
        {
                    ctl.BackgroundImage = Properties.Resources._3dalfredlogo;
            ctl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            break;
        }
    }
            

        }

        protected override void OnSizeChanged(EventArgs e)
        {
           base.OnSizeChanged(e);
            this.Refresh();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        //private patientform userFormInstance;
        //private Docform docFormInstance;
        //private diagnoseform diagnosisFormInstance;
        //private patientreadonly patreadonlyformintance;


        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientform registrationForm = new patientform();

            //set the parent forms of the child class
            registrationForm.MdiParent = this;

            //center form
            //registrationForm.StartPosition = FormStartPosition.CenterScreen;

            //display the new forms
            registrationForm.Show();

            //if (userFormInstance != null)
            //{
            //    userFormInstance.WindowState = FormWindowState.Normal;
            //   // userFormInstance.StartPosition = FormStartPosition.CenterScreen;
            //   // userFormInstance.Dock = DockStyle.Fill;
            //    userFormInstance.Focus();
            //}
            //else
            //{
            //    userFormInstance = new patientform();
            //    userFormInstance.MdiParent = this;
            //    userFormInstance.FormClosed += (o, ea) => userFormInstance = null;
            //  //  userFormInstance.StartPosition = FormStartPosition.CenterScreen;
            //    //userFormInstance.Dock = DockStyle.Fill;
            //    userFormInstance.Show();
            //}




        }

        private void MDIParent1dashboard_Load(object sender, EventArgs e)
        {
            if (Myconnection.type == "A")
            {
                patientbtn.Visible = true;
                doctorbtn.Visible = true;
                diagnosisbtn.Visible = false;
                patbtnreadonly.Visible = false;

            }
            else if (Myconnection.type == "U")
            {
                patientbtn.Visible = false;
                patbtnreadonly.Visible = true;
                doctorbtn.Visible = false;
                diagnosisbtn.Visible = true;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Docform registrationForm = new Docform();
            //set the parent forms of the child class
            registrationForm.MdiParent = this;

            //registrationForm.Dock = DockStyle.Fill;
            //center form
            // registrationForm.StartPosition = FormStartPosition.CenterScreen;

            //display the new forms
            registrationForm.Show();

            //if (docFormInstance != null)
            //{
            //    docFormInstance.WindowState = FormWindowState.Normal;
            //   // docFormInstance.StartPosition = FormStartPosition.CenterScreen;
            //  //  docFormInstance.Dock = DockStyle.Fill;
            //    docFormInstance.Focus();
            //}
            //else
            //{
            //    docFormInstance = new Docform();
            //    docFormInstance.MdiParent = this;
            //    docFormInstance.FormClosed += (o, ea) => docFormInstance = null;
            //  //  docFormInstance.StartPosition = FormStartPosition.CenterScreen;
            //  //  docFormInstance.Dock = DockStyle.Fill;
            //    docFormInstance.Show();
            //}






        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void diagnosisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagnoseform registrationForm = new diagnoseform();
            //set the parent forms of the child class
            registrationForm.MdiParent = this;

            //center form
            //registrationForm.StartPosition = FormStartPosition.CenterScreen;

            //display the new forms
            registrationForm.Show();


            //if (diagnosisFormInstance != null)
            //{
            //    diagnosisFormInstance.WindowState = FormWindowState.Normal;
            //   // diagnosisFormInstance.StartPosition = FormStartPosition.CenterScreen;
            //    diagnosisFormInstance.Focus();
            //}
            //else
            //{
            //    diagnosisFormInstance = new diagnoseform();
            //    diagnosisFormInstance.MdiParent = this;
            //    diagnosisFormInstance.FormClosed += (o, ea) => diagnosisFormInstance = null;
            //    //diagnosisFormInstance.StartPosition = FormStartPosition.CenterScreen;
            //    diagnosisFormInstance.Show();
            //}

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           // this.label1.Anchor = AnchorStyles.Left;
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            patientreadonly registrationForm = new patientreadonly();
            //set the parent forms of the child class
            registrationForm.MdiParent = this;

            //center form
            //registrationForm.StartPosition = FormStartPosition.CenterScreen;

            //display the new forms
            registrationForm.Show();

            //if (patreadonlyformintance != null)
            //{
            //    patreadonlyformintance.WindowState = FormWindowState.Normal;
            //   // patreadonlyformintance.StartPosition = FormStartPosition.CenterScreen;
            //    //  patreadonlyformintance .Dock = DockStyle.Fill;
            //    patreadonlyformintance.Focus();
            //}
            //else
            //{
            //    patreadonlyformintance = new patientreadonly();
            //    patreadonlyformintance.MdiParent = this;
            //    patreadonlyformintance.FormClosed += (o, ea) => docFormInstance = null;
            //   // patreadonlyformintance.StartPosition = FormStartPosition.CenterScreen;
            //    //  patreadonlyformintance .Dock = DockStyle.Fill;
            //    patreadonlyformintance.Show();
            //}
        }
    }
}
