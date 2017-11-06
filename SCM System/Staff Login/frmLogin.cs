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

namespace SCM_System.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            txtUsername.KeyPress += new KeyPressEventHandler(CheckEnter);
            txtPassword.KeyPress += new KeyPressEventHandler(CheckEnter);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:" + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtUsername.Text == String.Empty)
                {
                    MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsername.Focus();
                }

                else if (txtPassword.Text == String.Empty)
                {
                    MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                }

                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Staff WHERE username=@uname and password=@pass", Connection);
                        cmd.Parameters.AddWithValue("@uname", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            Main.frmMain main = new Main.frmMain();
                            this.Hide();
                            main.Show();
                            Connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect login, please try again");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            frmRecovery recovery = new frmRecovery();
            this.Hide();
            recovery.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
