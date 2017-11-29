using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCM_System.Mediator
{
    public delegate void OrderManagmentEvent(String id, String n, String s, DataGridView d);
    public delegate void EnterItem(String id, String n, String s, DataGridView d);
    public delegate bool ValidateItem(String id, String n, String s, SqlConnection c, DataGridView d);
    public delegate void PerformAction(String id, String n, String s, DataGridView d);
    public delegate bool ValidateAction(String id, String n, String s, SqlConnection c, DataGridView d);
    public delegate bool UpdateItem(String id, String n, String s, SqlConnection c, DataGridView d);
    public delegate void NotifyManager(bool r);

    class managerMediator
    {
        public event OrderManagmentEvent order;

        private String ID, name, status;
        private DataGridView data;
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");

        public managerMediator()
        {
            this.status += new OrderManagmentEvent(this.OrderManagmentEventHandler);
        }

        public void OrderManagmentEventHandler(String id, String n, String s, DataGridView d)
        {
            ID = id;
            name = n;
            status = s;
            data = d;

            Mediator m = new Mediator();

            m.item(id, name, data);
            bool i = m.validate(id, name, status, connection, data);
            bool j = m.action(i, connection, data);
            m.valAction(id, name, data);
            m.update(connection);
            m.notify(j);
        }
    }

    class Mediator
    {
        public event EnterItem item;
        public event ValidateItem validate;
        public event PerformAction action;
        public event ValidateAction valAction;
        public event UpdateItem update;
        public event NotifyManager notify;

        private String ID, name, status;
        private DataGridView data;

        public Mediator()
        {
            this.item += new EnterItem(this.itemPrcoessor);
            this.validate += new ValidateItem(this.validationProcessor);
            this.action += new PerformAction(this.actionProcessor);
            this.valAction += new ValidateAction(this.validationProcessor);
            this.update += new UpdateItem(this.updateProcessor);
            this.notify += new NotifyManager(this.notifyProcessor);
        }

        public void itemPrcoessor(String id, String n, DataGridView d)
        {
            if (id == String.Empty && n == String.Empty)
            {
                MessageBox.Show("Search Critera is missig");
            }
        }

        public bool validateItemPrcoessor(String id, String name, String status, SqlConnection c, DataGridView d)
        {
            if (id != "")
            {
                openConnection(c);
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Stock WHERE (Id = '" + id + "' AND status = '" + status + "')", c);
                    SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE (Id = '" + id + "')", c);
                    int result = (int)cmdCheck.ExecuteScalar();

                    if (result > 0)
                    {
                        this.display(cmd, d);
                        closeConnection(c);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                    return false;
                }
            }
            else if (name != "")
            {
                openConnection(c);
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Stock WHERE (name = '" + name + "' AND status = '" + status + "')", c);
                    SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE (name = '" + name + "')", c);
                    int result = (int)cmdCheck.ExecuteScalar();

                    if (result > 0)
                    {
                        this.display(cmd, d);
                        closeConnection(c);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                    return false;
                }
            }
            return false;
        }

        public void actionProcessor(bool action, SqlConnection c, DataGridView d)
        {
            openConnection(c);

            if(action)
            {
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
                                this.display(cmd, d);
                                closeConnection(c);
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("No record exists with that information");
                                return false;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unexpected error:" + ex.Message);
                            return false;
                        }
                        closeConnection(c);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("No record exists with that information");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                    return false;
                }   
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm", MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM Stock WHERE Id = '" + id + "')", c);
                        int i = cmd.ExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("Product has being added");
                            try
                            {
                                cmd = new SqlCommand("SELECT * FROM Stock WHERE (Id = '" + id + "')", c);
                                SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE (Id = '" + id + "')", c);
                                int result = (int)cmdCheck.ExecuteScalar();

                                if (result > 0)
                                {
                                    this.display(cmd, d);
                                    MessageBox.Show("Record could not be deleted at this time");
                                    closeConnection(c);
                                    return false;
                                }
                                else
                                {
                                    MessageBox.Show("The record has bein deleted");
                                    closeConnection(c);
                                    return true;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Unexpected error:" + ex.Message);
                                return false;
                            }
                            closeConnection(c);
                        }
                        else
                        {
                            MessageBox.Show("No record exists with that information");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                        return false;
                    }  
                }
            }
        }

        public void updateProcessor(SQLTransaction trans)
        {
            trans.Commit();
        }

        public void displayProcessor(SqlCommand cmd, DataGridView d)
        {
            d.Visible = true;
            addBtn.Visible = true;

            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                using (DataSet ds = new DataSet())
                {
                    sda.Fill(ds);
                    d.DataSource = ds.Tables[0];
                }
            }
        }

        public void notifyProcessor(bool r)
        {
            if (r)
            {
                MessageBox.Show("Sucess, the database has being altered.");
            }
            else
            {
                MessageBox.Show("No Record Exists");
            }
        }

        public static bool openConnection(SqlConnection c)
        {
            try
            {
                c.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public static bool closeConnection(SqlConnection c)
        {
            try
            {
                c.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
