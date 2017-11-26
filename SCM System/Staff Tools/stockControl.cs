using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SCM_System.Staff_Tools
{
    public partial class stockControl : UserControl
    {
        public stockControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Visible = false;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                lblStatus.Text = row.Cells[1].Value.ToString();
                lblArrival.Text = row.Cells[4].Value.ToString();
                lblPrice.Text = "£" + row.Cells[2].Value.ToString();
                lblMinimum.Text = row.Cells[5].Value.ToString();
                lblMax.Text = row.Cells[6].Value.ToString();
                lblQuantity.Text = row.Cells[3].Value.ToString();
                lblStaff.Text = row.Cells[7].Value.ToString();
                lblItem.Text = row.Cells[8].Value.ToString();

                if (lblItem.Text == "In Stock")
                {
                    lblItem.ForeColor = System.Drawing.Color.Green;
                }
                else if (lblItem.Text == "Low Stock")
                {
                    lblItem.ForeColor = System.Drawing.Color.Orange;
                }
                else if (lblItem.Text == "Out of Stock")
                {
                    lblItem.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblItem.ForeColor = System.Drawing.Color.Black;
                }

                groupBoxResult.Visible = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtID.Text != String.Empty)
                {
                    connection.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Stock WHERE (Id = '" + txtID.Text + "')", connection);
                        SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE (Id = '" + txtID.Text + "')", connection);
                        int result = (int)cmdCheck.ExecuteScalar();

                        if (result > 0)
                        {
                            dataGridView1.Visible = true;
                            bunifuThinButton22.Visible = true;

                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                using (DataSet ds = new DataSet())
                                {
                                    sda.Fill(ds);
                                    dataGridView1.DataSource = ds.Tables[0];
                                }
                            }
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("No record exists with that information");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
