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

                lblItem.Text = row.Cells[1].Value.ToString();
                lblArrival.Text = row.Cells[4].Value.ToString();
                lblPrice.Text = "£" + row.Cells[2].Value.ToString();
                lblMinimum.Text = row.Cells[5].Value.ToString();
                lblMax.Text = row.Cells[6].Value.ToString();
                lblQuantity.Text = row.Cells[3].Value.ToString();
                lblStaff.Text = row.Cells[7].Value.ToString();
                lblStatus.Text = row.Cells[8].Value.ToString();

                if (lblStatus.Text == "In Stock")
                {
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
                else if (lblStatus.Text == "Low Stock")
                {
                    lblStatus.ForeColor = System.Drawing.Color.Orange;
                }
                else if (lblStatus.Text == "Out of Stock")
                {
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblStatus.ForeColor = System.Drawing.Color.Black;
                }

                groupBoxResult.Visible = true;
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            groupBoxResult.Visible = false;

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
