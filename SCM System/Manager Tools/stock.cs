using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SCM_System.Manager_Tools
{
    public partial class stock : UserControl
    {
        public stock()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if(txtID.Text != String.Empty)
                {
                    connection.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Stock WHERE (Id = '" + txtID.Text + "' AND status = '" + statusDropDown.selectedValue + "')", connection);
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
                else if(txtName.Text != String.Empty)
                {
                    connection.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Stock WHERE (name = '" + txtName.Text + "' AND status = '" + statusDropDown.selectedValue + "')", connection);
                        SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE (name = '" + txtName.Text + "')", connection);
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

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if(groupBoxAddNew.Visible == true)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO Stock ([Id], [name], [price], [quantity], [arrival], [minimum], [maximum], [staffCheck], [status]) VALUES (@productID,@productName, @productPrice, @productQuantity, @productArrival, @productMin, @productMax, @productStaff,  @productStatus);", connection);
                        cmd.Parameters.AddWithValue("@productID", textBoxID.Text);
                        cmd.Parameters.AddWithValue("@productName", textBoxName.Text);
                        cmd.Parameters.AddWithValue("@productPrice", textBoxPrice.Text);
                        cmd.Parameters.AddWithValue("@productQuantity", textBoxQuan.Text);
                        cmd.Parameters.AddWithValue("@productArrival", datePickerArrival.Value);
                        cmd.Parameters.AddWithValue("@productMin", textBoxMin.Text);
                        cmd.Parameters.AddWithValue("@productMax", textBoxMax.Text);
                        cmd.Parameters.AddWithValue("@productStaff", textBoxSignOff.Text);
                        cmd.Parameters.AddWithValue("@productStatus", bunifuDropdownStatus.selectedValue);

                        int i = cmd.ExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("Product has being added");
                            try
                            {
                                cmd = new SqlCommand("SELECT * FROM Stock WHERE (Id = '" + textBoxID.Text + "')", connection);
                                SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE (Id = '" + textBoxID.Text + "')", connection);
                                int result = (int)cmdCheck.ExecuteScalar();

                                if (result > 0)
                                {
                                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                    {
                                        using (DataSet ds = new DataSet())
                                        {
                                            sda.Fill(ds);
                                            dataGridView1.DataSource = ds.Tables[0];
                                        }
                                    }

                                    dataGridView1.Visible = true;
                                    bunifuThinButton22.Visible = true;
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
                            dataGridView1.Visible = true;
                            groupBoxAddNew.Visible = false;
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
            else
            {
                dataGridView1.Visible = false;
                groupBoxAddNew.Visible = true;
            }
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30"))
            {

            }
        }
    }
}
