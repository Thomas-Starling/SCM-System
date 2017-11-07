using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SCM_System.Staff_Login
{
    public partial class frmRecoveryCode : Form
    {
        public frmRecoveryCode()
        {
            InitializeComponent();

            txtCode.KeyPress += new KeyPressEventHandler(CheckEnter);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtCode.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your unique email code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCode.Focus();
                }

                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Staff WHERE recoveryCode=@code", Connection);
                        cmd.Parameters.AddWithValue("@code", txtCode.Text);
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            SqlCommand commandPass = new SqlCommand("SELECT Password, recoveryCode FROM Staff WHERE recoveryCode = '" + txtCode.Text + "'", Connection);

                            string password = ((string)commandPass.ExecuteScalar());
                            MessageBox.Show("Your password is: " + password, "Password Recovered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Connection.Close();
                        }

                        else
                        {
                            MessageBox.Show("Code is incorrect, try again");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                        Connection.Close();
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
            frmRecovery recovery = new frmRecovery();
            recovery.Show();
        }
    }
}
