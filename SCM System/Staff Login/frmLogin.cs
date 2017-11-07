using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SCM_System.Staff_Login
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
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
                            Connection.Close();
                            Main.frmMain main = new Main.frmMain(txtUsername.Text);
                            this.Hide();
                            main.Show();
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
                bunifuThinButton21_Click(this, new EventArgs());
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            frmRecovery recovery = new frmRecovery();
            this.Hide();
            recovery.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
