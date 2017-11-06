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
    public partial class frmRecoveryCode : Form
    {
        public frmRecoveryCode()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Manager WHERE recoveryCode=@code", Connection);
                        cmd.Parameters.AddWithValue("@code", txtCode.Text);
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            SqlCommand commandPass = new SqlCommand("SELECT Password, recoveryCode FROM Manager WHERE recoveryCode = '" + txtCode.Text + "'", Connection);

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
    }
}
