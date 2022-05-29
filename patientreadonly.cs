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
    public partial class patientreadonly : Form
    {
        Myconnection db = new Myconnection();
        //DateTime dob;
        //string id;
        //string fname;
        //string lname;
        //string address;
        //string phone;
        //string age;
        //string gender;
        //string blood;
        //string disease;

        public patientreadonly()
        {
            InitializeComponent();
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

        private void patientGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                    hidebtn();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        void hidebtn()
        {
            login.Visible = false;
            btnloadimage.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }
        private void patientreadonly_Load(object sender, EventArgs e)
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
            hidebtn();
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
    }
}
