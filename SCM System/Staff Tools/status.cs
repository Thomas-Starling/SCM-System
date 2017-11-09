using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SCM_System.Staff_Tools
{
    public partial class status : UserControl
    {
        public status()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Visible = false;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string item = row.Cells[0].Value.ToString();
                string quantity = row.Cells[3].Value.ToString();
                string status = row.Cells[8].Value.ToString();

                lblItem.Text = item;
                lblQuantity.Text = quantity;
                lblStatus.Text = status;
                groupBoxResult.Visible = true;
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtID.Text == String.Empty && txtName.Text == String.Empty)
                {
                    MessageBox.Show("Search Critera is Empty");
                }
                else
                {
                    if (txtID.Text != String.Empty && txtName.Text == String.Empty)
                    {
                        try
                        {
                            Connection.Open();
                            SqlCommand cmd = new SqlCommand("SELECT * FROM Stock WHERE (Id = '" + txtID.Text + "')", Connection);
                            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE (Id = '" + txtID.Text + "')", Connection);
                            int result = (int)cmdCheck.ExecuteScalar();

                            if (result > 0)
                            {
                                dataGridView1.Visible = true;

                                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                {
                                    using (DataSet ds = new DataSet())
                                    {
                                        sda.Fill(ds);
                                        dataGridView1.DataSource = ds.Tables[0];
                                    }
                                }
                                Connection.Close();
                            }
                            else
                            {
                                MessageBox.Show("No Record Exists");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unexpected error:" + ex.Message);
                        }
                    }
                    else if (txtName.Text != String.Empty && txtID.Text == String.Empty)
                    {
                        try
                        {
                            Connection.Open();
                            SqlCommand cmd = new SqlCommand("SELECT * FROM Stock WHERE (name = '" + txtName.Text + "')", Connection);
                            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE (name = '" + txtName.Text + "')", Connection);
                            int result = (int)cmdCheck.ExecuteScalar();

                            if (result > 0)
                            {

                                dataGridView1.Visible = true;

                                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                {
                                    using (DataSet ds = new DataSet())
                                    {
                                        sda.Fill(ds);
                                        dataGridView1.DataSource = ds.Tables[0];
                                    }
                                }
                                Connection.Close();
                            }
                            else
                            {
                                MessageBox.Show("No Record Exists");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unexpected error:" + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
