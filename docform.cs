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
    public partial class Docform : Form
    {
        Myconnection db = new Myconnection();

        string id;
        string fname;
        string lname;
        string user;
        string pass;
        string ty;

        //public static string SafeGetString(this SqlDataReader reader, int colIndex)
        //{
        //    if (!reader.IsDBNull(colIndex))
        //        return reader.GetString(colIndex);
        //    return string.Empty;
        //}

        public Docform()
        {
            InitializeComponent();
            //label6.Text = user;
        }

        //Image ConvertBinaryToImage(byte[] data)
        //{
        //    using (MemoryStream ms = new MemoryStream(data))
        //    {
        //        return Image.FromStream(ms);
        //    }
        //}
        void clearfields()
        {
             Docid.Text = "";
             Docname.Text ="";
             lastname.Text ="";
             username.Text ="";
             password.Text ="";
             usertype.Text = "";
            pictureBox1.Image = null;

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

        void setImageToDefault()
        {
            //pictureBox1.BackgroundImage = Properties.Resources.trex;
            pictureBox1.Image = Properties.Resources.trex;
            var imageSize = pictureBox1.Image.Size;
            var fitSize = pictureBox1.ClientSize;
            pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }

        //public static byte[] ConvertImageToByteBinary(Image imageToConvert)
        //{
        //    using (var ms = new MemoryStream())
        //    {
        //        ImageFormat format;
        //        switch (imageToConvert.GetType))
        //        {
        //            case "image/png":
        //                format = ImageFormat.Png;
        //                break;
        //            case "image/gif":
        //                format = ImageFormat.Gif;
        //                break;
        //            default:
        //                format = ImageFormat.Jpeg;
        //                break;
        //        }

        //        imageToConvert.Save(ms, format);
        //        return ms.ToArray();
        //    }
        //}

        //        string outputFileName = "...";
        // using (MemoryStream memory = new MemoryStream())
        //{
        //    using (FileStream fs = new FileStream(outputFileName, FileMode.Create, FileAccess.ReadWrite))
        //    {
        //        thumbBMP.Save(memory, ImageFormat.Jpeg);
        //        byte[] bytes = memory.ToArray();
        //    fs.Write(bytes, 0, bytes.Length);
        //    }
        //}


        //private void SetPicture()
        //{
        //    var assembly = System.Reflection.Assembly.GetExecutingAssembly();
        //    using (var imgStream = assembly.GetManifestResourceStream("p12.3dalfredlogo.png"))
        //    {
        //        var img = new Bitmap(imgStream);
        //        pictureBox1.Image = img;
        //    }
        //}
        //void hiderow()
        //{
        //    try
        //    {

        //        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[doctorGv.DataSource];
        //        currencyManager1.SuspendBinding();
        //        doctorGv.CurrentCell = null;
        //        doctorGv.Rows[0].Visible = false;
        //        currencyManager1.ResumeBinding();

        //    }
        //    catch
        //    {

        //    }

        //}
        void populate()
        {
            db.con.Open();
            string query = "select * from tblogin";
            SqlDataAdapter da = new SqlDataAdapter(query, db.con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            doctorGv.DataSource = ds.Tables[0];
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[doctorGv.DataSource];
            currencyManager1.SuspendBinding();
            doctorGv.CurrentCell = null;
            doctorGv.Rows[0].Visible = false;
            currencyManager1.ResumeBinding();
            doctorGv.Columns["password"].Visible = false;
            // doctorGv.Rows[0].ReadOnly = true;
            //doctorGv.Rows[0].Visible = false;


            //doctorGv.Rows[0].Visible = false;


            ////doctorGv.SelectedRows[0].Cells[1] = false;
            //string[] column0Array = new string[doctorGv.Rows.Count];
            ////string[] column1Array = new string[doctorGv.Rows.Count];

            //int i = 0;
            //foreach (DataGridViewRow rw in doctorGv.Rows)
            //{
            //    column0Array[i] = rw.Cells[0].Value != null ? rw.Cells[0].Value.ToString() : string.Empty;
            //    //column1Array[i] = rw.Cells[1].Value != null ? rw.Cells[1].Value.ToString() : string.Empty;
            //    i++;
            //}



            db.con.Close();
        }
        private void docform_Load(object sender, EventArgs e)
        {
            //hiderow();
            //doctorGv.Rows.Item(row.Index).Visible = false;
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
            clearfields();
            populate();
            setImageToDefault();

            //// no smaller than design time size
            //this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            //// no larger than screen size
            //// this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (int)System.Windows.SystemParameters.PrimaryScreenHeight);

            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // rest of your code here...

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            id = Docid.Text;
            fname = Docname.Text;
            lname = lastname.Text;
            user = username.Text;
            pass = password.Text;
            ty = usertype.Text;

            if (Docname.Text == "" || password.Text == "" || lastname.Text == "" || username.Text == "")
            {
                MessageBox.Show(" Fill Fields except Id");
            }
            else if (Docid.Text != string.Empty)
            {

                MessageBox.Show("Id is auto generated");
            }
            else
            {

                db.con.Open();
                // string query = "insert into doctor(Docid,Docname,Docexp,Docpass) values("+ Docid.Text +",'"+Docname.Text+"',"+Docexp.Text+"','"+Docpass.Text +"')";
                //string query = "INSERT INTO tblogin values(" + Docid.Text + ",'" + Docname.Text + "','" + lastname.Text + "','" + username.Text + "','" + password.Text + "','" + usertype.Text + "',"+ ConvertImageToBinary(pictureBox1.Image) + ")";
                // SqlCommand cmd = new SqlCommand("INSERT INTO doctor values("+Docid.Text+", '"+Docname.Text+"', "+Docexp.Text+", '"+Docpass.Text+"')", con);
                string query = "INSERT INTO tblogin( firstname, lastname, username, password, type,image) VALUES(@fname, @lname, @username, @passsword,@type, @img)";
                SqlCommand cmd = new SqlCommand(query, db.con);
                // cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@passsword", pass);
                cmd.Parameters.AddWithValue("@type", ty);
                cmd.Parameters.AddWithValue("@img", ConvertImageToBinary(pictureBox1.Image));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Added");
                db.con.Close();
                populate();
                clearfields();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Docid.Text == "")
                MessageBox.Show("Enter The Doctor Id");
            else
            {
                db.con.Open();
                string query = "delete from tblogin where id=" + Docid.Text + "";
                SqlCommand cmd = new SqlCommand(query, db.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");
                db.con.Close();
                populate();
                clearfields();
            }
        }

        private void doctorGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            // Docid.Text =this.doctorGv.SelectedRows[0].Cells[0].Value.ToString();
            //Docname.Text = doctorGv.SelectedRows[1].Cells[1].Value.ToString();
            //Docexp.Text = doctorGv.SelectedRows[1].Cells[2].Value.ToString();
            //Docpass.Text = doctorGv.SelectedRows[1].Cells[3].Value.ToString();
        }




        private void doctorGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // doctorGv.SelectedRows[0].Cells[1]= false;
            //string[] column0Array = new string[doctorGv.Rows.Count];
            //string[] column1Array = new string[doctorGv.Rows.Count];

            //int i = 0;
            //foreach (DataGridViewRow rw in doctorGv.Rows)
            //{
            //    column0Array[i] = rw.Cells[0].Value != null ? rw.Cells[0].Value.ToString() : string.Empty;
            //   column1Array[i] = rw.Cells[1].Value != null ? rw.Cells[1].Value.ToString() : string.Empty;
            //    i++;
            //}

            

            try
            {


                DataGridViewRow row = doctorGv.Rows[doctorGv.CurrentRow.Index] as DataGridViewRow;
                if (e.RowIndex >= 0)
                {
                    Docid.Text = row.Cells[0].Value.ToString();
                    Docname.Text = row.Cells[1].Value.ToString();
                    lastname.Text = row.Cells[2].Value.ToString();
                   // password.Text = row.Cells[4].Value.ToString();
                    username.Text = row.Cells[3].Value.ToString();
                    usertype.Text = row.Cells[5].Value.ToString();
                }
                if (row != null)
                {
                    Docid.Text = row.Cells[0].Value.ToString();
                    Docname.Text = row.Cells[1].Value.ToString();
                    lastname.Text = row.Cells[2].Value.ToString();
                    password.Text = row.Cells[4].Value.ToString();
                    username.Text = row.Cells[3].Value.ToString();
                    usertype.Text = row.Cells[5].Value.ToString();

                    //        //if (myReader["StudPic"] != System.DBNull.Value))
                    //        //{
                    //        //    byte[] imgg = (byte[])(myReader["StudPic"]);
                    //        //    pictureBox1.Image = defaultpic;
                    //        //}

                    //        //db.con.Open();
                    //        //SqlCommand cmd1 = new SqlCommand("sp_GetStaffImage", db.con);
                    //        //cmd1.CommandType = CommandType.StoredProcedure;
                    //        //cmd1.Parameters.AddWithValue("@img", pictureBox1.Image);
                    //        //SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    //        //DataSet ds = new DataSet();
                    //        //sda1.Fill(ds);

                    //        //byte[] byteArray = Encoding.UTF8.GetBytes(Convert.ToString(pictureBox1));
                    //        //cmd1.Parameters.AddWithValue("@img", byteArray);

                    //        //var img = ds.Tables[0].Rows[6].Field<byte[]>(0);

                    byte[] photo = (byte[])row.Cells[6].Value;

                    if (photo.Length > 0)
                    {
                        pictureBox1.Image = ConvertBinaryToImage(photo);
                        var imageSize = pictureBox1.Image.Size;
                        var fitSize = pictureBox1.ClientSize;
                        pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                            PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
                    }
                    //    doctorGv.Rows[0].ReadOnly = true;
                    login.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        

        private void button1_Click(object sender, EventArgs e)
        {
            //db.con.Open();
            //string query = "update tblogin set firstname ='" + Docname.Text + "', lastname ='" + lastname.Text + "',username ='" + username.Text + "',password ='" + password.Text + "',Docpass ='" + password.Text + "' where Docid =" + Docid.Text + "";
            //SqlCommand cmd = new SqlCommand(query, db.con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Doctor Successfully updated");
            //db.con.Close();
            //populate();
            try
            {
                if (Docname.Text == "" || password.Text == "" || lastname.Text == "" || username.Text == "")
                {
                    MessageBox.Show("No Empty Fill Accepted");
                }
                //else if (Docid.Text != string.Empty)
                //{

                //    MessageBox.Show("Please fill except id");
                //}
                else
                {

                    id = Docid.Text;
                    fname = Docname.Text;
                    lname = lastname.Text;
                    user = username.Text;
                    pass = password.Text;
                    ty = usertype.Text;
                    if (db.con.State == ConnectionState.Closed)
                        db.con.Open();
                    string query = "Update tblogin set firstname = @fname, lastname = @lname,username = @username,password= @passsword,type = @type, image= @img where id = @id";
                    SqlCommand cmd = new SqlCommand(query, db.con);

                    DataGridViewRow row = doctorGv.Rows[doctorGv.CurrentRow.Index] as DataGridViewRow;
                    if (row != null)
                    {
                        cmd.Parameters.AddWithValue("@id", row.Cells[0].Value);
                        cmd.Parameters.AddWithValue("@fname", fname);
                        cmd.Parameters.AddWithValue("@lname", lname);
                        cmd.Parameters.AddWithValue("@username", user);
                        cmd.Parameters.AddWithValue("@passsword", pass);
                        cmd.Parameters.AddWithValue("@type", ty);
                        cmd.Parameters.AddWithValue("@img", ConvertImageToBinary(pictureBox1.Image));

                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records Successfully updated");
                    db.con.Close();
                    populate();
                    clearfields();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
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
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from tblogin where id like @Search OR firstname like @Search OR lastname like @Search", db.con);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{txtsearch.Text}%");
                    dataAdapter.Fill(dt);
                    doctorGv.DataSource = dt;
                    db.con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Docname_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Docname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Docname.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                    //Docname.Text.Remove(Docname.Text.Length - 1);
                    Docname.Clear();
                    //Docname.Focus();
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
                //lastname.Text.Remove(lastname.Text.Length - 1);
                    Docname.Clear();
                    //Docname.Focus();
                }

            }
            catch
            {

            }
        }

        private void Docid_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorGv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.doctorGv.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 6)
            {
                e.Value = Properties.Resources.trex;
            }
        }
    }
}
