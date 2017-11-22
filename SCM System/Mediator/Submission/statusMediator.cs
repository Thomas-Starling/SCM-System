using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCM_System.Mediator
{
    public delegate void StatusEvent(String id, String n, DataGridView d);
    public delegate void EnterItem(String id, String n, DataGridView d);
    public delegate bool ValidateItem(String id, String n, SqlConnection c, DataGridView d);
    public delegate void NotifyStaffMember(bool r);

    public class Status
    {
        public event StatusEvent status;

        private String ID, name;
        private DataGridView data;
        private SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");

        public Status()
        {
            this.status += new StatusEvent(this.StatusItemEventHandler);
        }

        public void StatusItemEventHandler(String id, String n, DataGridView d)
        {
            ID = id;
            name = n;
            data = d;

            Mediator m = new Mediator();

            m.item(ID, n, d, Connection);
            bool i = m.validate(ID, n, Connection, d);
            m.staff(i);
        }
    }

    class Mediator
    {
        public event NotifyStaffMember staff;
        public event EnterItem item;
        public event ValidateItem validate;

        public Mediator()
        {
            this.staff += new NotifyStaffMember(this.notifyProcessor);
            this.item += new EnterItem(this.itemPrcoessor);
            this.validate += new ValidateItem(this.validateItemPrcoessor);
        }

        private String ID, name;
        private DataGridView data;

        public void itemPrcoessor(String id, String n, DataGridView d)
        {
            if (id == String.Empty && n == String.Empty)
            {
                MessageBox.Show("Search Critera is missig");
            }
        }

        public bool validateItemPrcoessor(String id, String name, SqlConnection c, DataGridView d)
        {
            if (id != "")
            {
                openConnection(c);
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Stock WHERE (Id = '" + id + "')", c);
                    SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE (Id = '" + id + "')", c);
                    int result = (int)cmdCheck.ExecuteScalar();

                    if (result > 0)
                    {
                        d.Visible = true;

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                d.DataSource = ds.Tables[0];
                            }
                        }
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Stock WHERE (name = '" + name + "')", c);
                    SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE (name = '" + name + "')", c);
                    int result = (int)cmdCheck.ExecuteScalar();

                    if (result > 0)
                    {

                        d.Visible = true;

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                d.DataSource = ds.Tables[0];
                            }
                        }
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

        public void notifyProcessor(bool r)
        {
            if (r)
            {
                MessageBox.Show("Record Found, Select Field...");
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