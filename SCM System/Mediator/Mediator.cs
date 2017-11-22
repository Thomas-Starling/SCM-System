using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Bunifu;

namespace SCM_System.Mediator
{
    class statusMediator
    {
        private SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");

        public class Event
        {
            public String Id, name;

            public Event(String id, String n)
            {
                Id = id;
                name = n;
            }
        }

        public static bool openConnection(Event e, SqlConnection c)
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

        public static bool closeConnection(Event e, SqlConnection c)
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

        public static void returnID(Event e, String id, SqlConnection c, DataGridView d)
        {
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
                    closeConnection(e, c);
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

        public static void returnName(Event e, String name, SqlConnection c, DataGridView d)
        {
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
                    closeConnection(e, c);
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

        public statusMediator(String id, String name, DataGridView d)
        {
            Event e = new Event(id, name);

            if (e.Id != "")
            {
                openConnection(e, Connection);
                returnID(e, id, Connection, d);
            }
            else if (name != "")
            {
                openConnection(e, Connection);
                returnName(e, name, Connection, d);
            }
        }
    }

    class managerMediator
    {
        private SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");

        public class Event
        {
            public String Id, name;

            public Event(String id, String n)
            {
                Id = id;
                name = n;
            }
        }

        public static bool openConnection(Event e, SqlConnection c)
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

        public static bool closeConnection(Event e, SqlConnection c)
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

        public managerMediator(String id, String name, DataGridView d, Bunifu.Framework.UI.BunifuDropdown fil)
        {
            Event e = new Event(id, name);
        }
    }
}
