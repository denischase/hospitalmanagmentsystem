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

namespace p12
{
    public partial class Form1 : Form
    {
        Myconnection db = new Myconnection();

        public Form1()
        {
            InitializeComponent();
        }

        void clearfields()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void login_Click(object sender, EventArgs e)
        {
                    db.con.Open();
            try
            {
               // using (db.con)
                //{
                    SqlCommand cmd = new SqlCommand("sp_role_login", db.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uname", txtusername.Text);
                    cmd.Parameters.AddWithValue("@upass", txtpassword.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[5].ToString() == "Admin")
                        {
                            Myconnection.type = "A";
                        }
                        else if (rd[5].ToString() == "User")
                        {
                            Myconnection.type = "U";
                        }
                        MDIParent1dashboard f = new MDIParent1dashboard("Hello : "+txtusername.Text);
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                        clearfields();
                    }
                    db.con.Close();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearfields();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
