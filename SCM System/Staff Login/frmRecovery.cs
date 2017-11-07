using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SCM_System.Staff_Login
{
    public partial class frmRecovery : Form
    {
        public frmRecovery()
        {
            InitializeComponent();

            txtEmail.KeyPress += new KeyPressEventHandler(CheckEnter);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtEmail.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your email address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                }

                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Staff WHERE email=@emailAddress", Connection);
                        cmd.Parameters.AddWithValue("@emailAddress", txtEmail.Text);
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            Connection.Close();
                            frmRecoveryCode code = new frmRecoveryCode();
                            code.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Email does not exist in this system");
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}
