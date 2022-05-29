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
    public partial class patientform : Form
    {
        Myconnection db = new Myconnection();
        DateTime dob;
        string id;
        string fname;
        string lname;
        string address;
        string phone;
        string age;
        string gender;
        string blood;
        string disease;
        public patientform()
        {
            InitializeComponent();
            //pictureBox1.Image = Properties.Resources.trex;
            //pictureBox1.Image = pictureBox1.InitialImage;
            
           
        }

        void setImageToDefault()
        {
            //pictureBox1.BackgroundImage = Properties.Resources.trex;
            pictureBox1.Image = Properties.Resources.trex;
            var imageSize = pictureBox1.Image.Size;
            var fitSize = pictureBox1.ClientSize;
            pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }

        void clearfields()
        {
            patid.Text = "";
            patname.Text ="";
            lastname.Text ="";
            pataddress.Text ="";
            patphone.Text ="";
            pictureBox1.Image = null;
            patage.Text = "";
            gendercb.SelectedIndex = -1;
            bloodcb.SelectedIndex = -1;
            majorcb.Text = "";
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

        //void SetPicture()
        //{
        //    var assembly = System.Reflection.Assembly.GetExecutingAssembly();
        //    using (var imgStream = assembly.GetManifestResourceStream("p12.trex.png"))
        //    {
        //        var img = new Bitmap(imgStream);
        //        pictureBox1.Image = img;
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }
        void populate()
        {
            db.con.Open();
            string query = "select * from patient";
            SqlDataAdapter da = new SqlDataAdapter(query, db.con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            patientGv.DataSource = ds.Tables[0];
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[patientGv.DataSource];
            currencyManager1.SuspendBinding();
            
            currencyManager1.ResumeBinding();
            db.con.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            // dob = patdob.Value;
            id = patid.Text;
            fname = patname.Text;
            lname = lastname.Text;
            address = pataddress.Text;
            phone = patphone.Text;
            dob = patdob.Value;
            age = patage.Text;
            gender = gendercb.SelectedItem.ToString();
            blood = bloodcb.SelectedItem.ToString();
            disease = majorcb.Text;


            if (patname.Text == "" || lastname.Text == "" || pataddress.Text == "" || patphone.Text == "" || patage.Text == "" || majorcb.Text == "" )
                MessageBox.Show("Fill Fields except Id");
            else if (patid.Text != string.Empty)
            {

                MessageBox.Show("Id is auto generated");
            }
            else
            {

               db.con.Open();
                string query = "INSERT INTO patient( patfirstname, patlastname, pataddress, patphone,patdob,patage,patgender,patblood,patdisease,image) VALUES( @firstname, @lastname, @address, @phone,@dob,@age,@gender,@blood,@disease,@image)";
                // string query = "insert into doctor(Docid,Docname,Docexp,Docpass) values("+ Docid.Text +",'"+Docname.Text+"',"+Docexp.Text+"','"+Docpass.Text +"')";
                // string query = "INSERT INTO patient values(" + patid.Text + ",'" + patname.Text + "','" + lastname.Text + "','" + pataddress.Text + "','" + patphone.Text + "','"+ patdob.Value.Date + "','" + patage.Text + "','" + gendercb.SelectedItem.ToString() +"','"+bloodcb.SelectedItem.ToString()+"','"+majorcb.Text+"',)";
                // SqlCommand cmd = new SqlCommand("INSERT INTO doctor values("+Docid.Text+", '"+Docname.Text+"', "+Docexp.Text+", '"+Docpass.Text+"')", con);

                SqlCommand cmd = new SqlCommand(query, db.con);
               // cmd.Parameters.AddWithValue("@patid", id);
                cmd.Parameters.AddWithValue("@firstname", fname);
                cmd.Parameters.AddWithValue("@lastname", lname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@blood", blood);
                cmd.Parameters.AddWithValue("@disease", disease);
                cmd.Parameters.AddWithValue("@image", ConvertImageToBinary(pictureBox1.Image));
                cmd.ExecuteNonQuery();
                MessageBox.Show("patient Successfully Added");
                db.con.Close();
                populate();
                clearfields();
            }
        }

        private void patientform_Load(object sender, EventArgs e)
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
            populate();
            clearfields();
            setImageToDefault();
            ////this.WindowState = FormWindowState.Maximized;
            //this.WindowState.Size = new Size(this.ClientRectangle.Width, this.ClientRectangle.Height);
            // no smaller than design time size
            // this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            // // no larger than screen size
            //// this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (int)System.Windows.SystemParameters.PrimaryScreenHeight);

            // this.AutoSize = true;
            // this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // rest of your code here...

        }




        private void button2_Click(object sender, EventArgs e)
        {
            if (patid.Text == "")
                MessageBox.Show("Enter The Patient Id");
            else
            {
                db.con.Open();
                string query = "delete from patient where patid=" + patid.Text + "";
                SqlCommand cmd = new SqlCommand(query, db.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted");
                db.con.Close();
                populate();
                clearfields();
            }
        }

        private void patientGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = patientGv.Rows[patientGv.CurrentRow.Index] as DataGridViewRow;
                if (row != null)
                {
                    patid.Text = row.Cells[0].Value.ToString();
                    patname.Text = row.Cells[1].Value.ToString();
                    lastname.Text = row.Cells[2].Value.ToString();
                    pataddress.Text = row.Cells[3].Value.ToString();
                    patphone.Text = row.Cells[4].Value.ToString();
                    patdob.Text = row.Cells[5].Value.ToString();
                    patage.Text = row.Cells[6].Value.ToString();
                    gendercb.Text = row.Cells[7].Value.ToString();
                    bloodcb.Text = row.Cells[8].Value.ToString();
                    majorcb.Text = row.Cells[9].Value.ToString();


                    byte[] photo = (byte[])row.Cells[10].Value;

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
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  dob = patdob.Value;
            // con.Open();
            // string query = "update patient set patname ='" + patname.Text + "', pataddress ='" + pataddress.Text + "',patphone ='" + patphone.Text + "',patdob='"+patdob.Text+"',patage ='"+patage.Text+"',patgender = '"+gendercb.SelectedItem.ToString()+"',patblood='"+bloodcb.SelectedItem.ToString()+"',patdisease ='"+majorcb.Text+"' where patid =" +patid.Text+"";
            // SqlCommand cmd = new SqlCommand(query, con);
            // cmd.ExecuteNonQuery();
            // MessageBox.Show("Patient Successfully updated");
            // con.Close();
            //populate();


             fname = patname.Text;
            lname = lastname.Text;
            address = pataddress.Text;
             phone = patphone.Text;
             dob = patdob.Value;
             age = patage.Text;
             gender = gendercb.SelectedItem.ToString();
             blood = bloodcb.SelectedItem.ToString();
             disease = majorcb.Text;
            try
            {
                if (db.con.State == ConnectionState.Closed)
                    db.con.Open();
                string query = "Update patient set patfirstname = @name, patlastname = @lname, pataddress = @address, patphone = @phone, patdob = @dob, patage = @age, patgender = @gender, patblood = @blood, patdisease = @disease, image =@img where patid = @patid";
                SqlCommand cmd = new SqlCommand(query, db.con);

                DataGridViewRow row = patientGv.Rows[patientGv.CurrentRow.Index] as DataGridViewRow;
                    if (row != null)
                    {
                        cmd.Parameters.AddWithValue("@patid", row.Cells[0].Value);
                        cmd.Parameters.AddWithValue("@name", fname);
                        cmd.Parameters.AddWithValue("@lname", lname);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@blood", blood);
                        cmd.Parameters.AddWithValue("@disease", disease);
                        cmd.Parameters.AddWithValue("@img", ConvertImageToBinary(pictureBox1.Image));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient Successfully updated");
                        db.con.Close();
                        populate();
                    clearfields();

                    }
                
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnloadimage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG FILES(*.jpg)|*.jpg|PNG Files(*.png)|*.png|GIF FILES (*.gif)|*.gif|All Files (*.*)| *.*", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                        //insert data to local database

                    var imageSize = pictureBox1.Image.Size;
                    var fitSize = pictureBox1.ClientSize;
                    pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                        PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
                    }
                    //else
                    //{
                    //    DialogResult dr = ofd.ShowDialog();
                    //    if (dr == DialogResult.Cancel && )
                    //        setImageToDefault();
                    //}

                }

                //OpenFileDialog ofd = new OpenFileDialog();
                //ofd.Filter = "image files|*.jpg;*.png;*.gif";
                //DialogResult dr = ofd.ShowDialog();

                //if (dr == DialogResult.Cancel)
                //    return;

                //pictureBox1.Image = Image.FromFile(ofd.FileName);
                ////textBoxPhoto.Text = ofd.FileName;

                //var imageSize = pictureBox1.Image.Size;
                //    var fitSize = pictureBox1.ClientSize;
                //    pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                //       PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void patdob_ValueChanged_1(object sender, EventArgs e)
        {
            int YearBirth = int.Parse(patdob.Value.Year.ToString());

            int CurrentYear = int.Parse(DateTime.Now.Year.ToString());

            int age = CurrentYear - YearBirth;

            if (age < 0)
            {
                MessageBox.Show("Year of Birth can not be greater than current Year");
            }
            else
            {
                patage.Text = age.ToString();
            }
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    db.con.Open();

                    DataTable dt = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from patient where patid like @Search OR patfirstname like @Search OR patlastname like @Search", db.con);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{txtsearch.Text}%");
                    dataAdapter.Fill(dt);
                    patientGv.DataSource = dt;
                    db.con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void patname_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void patname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(patname.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                   // patname.Text.Remove(patname.Text.Length - 1);
                    patname.Clear();
                   // patname.Focus();
                }
            }
            catch
            {

            }
        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(lastname.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                  //  lastname.Text.Remove(lastname.Text.Length - 1);
                    lastname.Clear();
                   // lastname.Focus();
                }
        }
            catch
            {

            }
        }

        private void patid_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bloodcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gendercb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void majorcb_TextChanged(object sender, EventArgs e)
        {

        }

        private void patage_TextChanged(object sender, EventArgs e)
        {

        }

        private void patphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void pataddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientGv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.patientGv.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 10)
            {
                e.Value = Properties.Resources.trex;
            }
        }
    }
}
 