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
using System.Configuration;
using System.IO;
using System.Drawing.Imaging;


namespace p12
{
    public partial class diagnoseform : Form
    {
        Myconnection db = new Myconnection();

        string did;
        string pid;
        string pname;
        string symtoms;
        string diagnose;
        string medicines;

        public diagnoseform()
        {
            InitializeComponent();
        }

        void cleardiagfields()
        {
            patientnamelbl.Text = "";
            diagnosislbl.Text = "";
            symptomslbl.Text = "";
            medicinelbl.Text = "";
        }
        void clearfields()
        {
            diagid.Text = "";
            pictureBox1.Image = null;
            patientidcb.SelectedIndex = -1;
            patientname.Text = "";
            symptoms.Text = "";
            diagnosis.Text = "";
            medicine.Text = "";
           
        }

        byte[] ConvertImageToBinary(Image image)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }

        private Image ConvertBinaryToImage(byte[] byteArray)
        {
            var stream = new MemoryStream(byteArray);
            return Image.FromStream(stream);
        }

        void populatecombo()
        {
            string sql = "select * from patient";
            SqlCommand cmd = new SqlCommand(sql, db.con);
            SqlDataReader rdr;
            try
            {
                db.con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("patid", typeof(int));
               // dt.Columns.Add("image", typeof(Byte));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                patientidcb.ValueMember = "patid";
                
                patientidcb.DataSource = dt;
                db.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fetchimage()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            string mysql = "select image from patient where patid=" + patientidcb.SelectedValue.ToString() + "";
            //SqlCommand cmd = new SqlCommand(@"SELECT Data FROM patient WHERE id = "+patientidcb.SelectedValue.ToString()+", db.con);
            SqlCommand cmd = new SqlCommand(mysql, db.con);
            cmd.CommandType = CommandType.Text;
            if (db.con.State == ConnectionState.Closed)
            {
                db.con.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "patient");
            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0] != System.DBNull.Value)
                    {
                        byte[] photo_aray = (byte[])ds.Tables[0].Rows[0][0];
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        Image img = (Image)converter.ConvertFrom(photo_aray);
                        pictureBox1.Image = img;
                        // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        var imageSize = pictureBox1.Image.Size;
                        var fitSize = pictureBox1.ClientSize;
                        pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                           PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
                        pictureBox1.Refresh();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (db.con.State == ConnectionState.Open)
                    db.con.Close();
            }
        }

        string patname;
        void fetchpatientname()
        {
            try
            {
                db.con.Open();

                string mysql = "select * from patient where patid=" + patientidcb.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(mysql, db.con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    patname = dr["patfirstname"].ToString();
                    patientname.Text = patname;
                }
                db.con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void populate()
        {
            try
            {

               
                db.con.Open();
                
                string query = "select * from diagnosis";
                SqlDataAdapter da = new SqlDataAdapter(query, db.con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                diagnosisGv.DataSource = ds.Tables[0];
                db.con.Close();
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }
       

        private void login_Click(object sender, EventArgs e)
        {
             did= diagid.Text;
             pid= patientidcb.SelectedValue.ToString();
             pname= patientname.Text;
             symtoms= symptoms.Text;
             diagnose= diagnosis.Text;
             medicines= medicine.Text;

            if (medicine.Text == "" || diagnosis.Text == "" || patientname.Text == "" || symptoms.Text == "" )
                MessageBox.Show("Fill Fields except Id");
            else if(diagid.Text != "")
            {
                MessageBox.Show("Id is auto generated");
            }
            else
            {
                //using (db.con)
                //{

                    db.con.Open();
                //// string query = "insert into doctor(Docid,Docname,Docexp,Docpass) values("+ Docid.Text +",'"+Docname.Text+"',"+Docexp.Text+"','"+Docpass.Text +"')";
                //string query = "INSERT INTO diagnosis values(" + diagid.Text + "," + patientidcb.SelectedValue.ToString() + ",'" + patientname.Text + "','" + symptoms.Text + "','" + diagnosis.Text + "','" + medicine.Text + "',@img)";
                //// SqlCommand cmd = new SqlCommand("INSERT INTO doctor values("+Docid.Text+", '"+Docname.Text+"', "+Docexp.Text+", '"+Docpass.Text+"')", con);
                string query = "INSERT INTO diagnosis( patid, patname, symptoms,diagnosis,medicines,img) VALUES( @patid, @patname, @symptoms,@diagnosis,@medicines,@img)";
                SqlCommand cmd = new SqlCommand(query, db.con);
                cmd.Parameters.AddWithValue("@patid", pid);
                cmd.Parameters.AddWithValue("@patname", pname);
                cmd.Parameters.AddWithValue("@symptoms", symtoms);
                cmd.Parameters.AddWithValue("@diagnosis", diagnose);
                cmd.Parameters.AddWithValue("@medicines", medicines);
                cmd.Parameters.AddWithValue("@img", ConvertImageToBinary(pictureBox1.Image));
                

                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Added");
                db.con.Close();
               populate();
                clearfields();
                //}
            }
        }

        private void diagnoseform_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            Point NewLoc = Screen.FromControl(this).WorkingArea.Location;
            //Modifiy the location so any toolbars & taskbar can be easily accessed.
            NewLoc.X += 1;
            NewLoc.Y += 1;
            this.Location = NewLoc;

            Size NewSize = Screen.FromControl(this).WorkingArea.Size;
            //Modifiy the size so any toolbars & taskbar can be easily accessed.
            NewSize.Height -= 1;
            NewSize.Width -= 1;
            this.Size = NewSize;

            this.MinimumSize = this.Size;
            this.MaximumSize = this.MinimumSize;

            populatecombo();
            populate();
            clearfields();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            if (diagid.Text == "")
                MessageBox.Show("Enter The Diagnosis Id");
            else
            {
                db.con.Open();
                string query = "delete from diagnosis where diagid=" + diagid.Text + "";
                SqlCommand cmd = new SqlCommand(query, db.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dignosis Successfully Deleted");
                db.con.Close();
                populate();
                clearfields();
            }
        }

        private void diagnosisGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = diagnosisGv.Rows[diagnosisGv.CurrentRow.Index] as DataGridViewRow;
                if (row != null)
                {
                    diagid.Text = row.Cells[0].Value.ToString();
                    patientidcb.SelectedValue = row.Cells[1].Value.ToString();
                    patientname.Text = row.Cells[2].Value.ToString();
                    symptoms.Text = row.Cells[3].Value.ToString();
                    diagnosis.Text = row.Cells[4].Value.ToString();
                    medicine.Text = row.Cells[5].Value.ToString();
                    patientnamelbl.Text = row.Cells[2].Value.ToString();
                    diagnosislbl.Text = row.Cells[4].Value.ToString();
                    symptomslbl.Text = row.Cells[3].Value.ToString();
                    medicinelbl.Text = row.Cells[5].Value.ToString();

                    byte[] photo = (byte[])row.Cells[6].Value;

                    if (photo.Length > 0)
                    {
                        pictureBox1.Image = ConvertBinaryToImage(photo);
                        var imageSize = pictureBox1.Image.Size;
                        var fitSize = pictureBox1.ClientSize;
                        pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                            PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
                    }

                    login.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.con.Open();
             string query = "update diagnosis set patid =" + patientidcb.SelectedValue.ToString() + ", patname ='" + patientname.Text + "',Symptoms ='" + symptoms.Text + "',diagnosis='"+diagnosis.Text+"', medicines ='"+ medicine.Text+"' where diagid =" +diagid.Text+"";
             SqlCommand cmd = new SqlCommand(query, db.con);
             cmd.ExecuteNonQuery();
             MessageBox.Show("Diagnosis Successfully updated");
             db.con.Close();
            populate();
            clearfields();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label1.Text, new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(230));
            e.Graphics.DrawString(patientnamelbl.Text + "\n" + diagnosislbl.Text + "\n" + symptomslbl.Text + "\n" + medicinelbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(130,150));
            e.Graphics.DrawString(label12.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(230,500));
            cleardiagfields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
            clearfields();
           // cleardiagfields();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void diagnosisGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patientidcb_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            fetchpatientname();
            fetchimage();
        }

        private void diagsummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    db.con.Open();

                    DataTable dt = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from diagnosis where diagid like @Search OR patname like @Search ", db.con);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{txtsearch.Text}%");
                    dataAdapter.Fill(dt);
                    diagnosisGv.DataSource = dt;
                    db.con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
