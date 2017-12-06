using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.Mediator
{
    public delegate void SignOffEvent(String id, String n, String s, DataGridView d);
    public delegate void StockArrival(String id);
    public delegate bool ValidateStock(String id);
    public delegate void EnterItemDetails(String id, String n);
    public delegate bool ValidateOrder(String id);        
    public delegate bool SignOffOrder(String id);
    public delegate bool UpdateOrders(String id);
    public delegate void NotifyManager(bool r);

    class signOffMediator
    {
        public event SignOffEvent signOff;

        private String ID, name, status;
        private DataGridView data;
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");

        public managerMediator()
        {
            this.signOff += new SignOffEvent(this.signOffEventHandler);
        }

        public void signOffEventHandler(String id, String n, String s, DataGridView d)
        {
            ID = id;
            name = n;
            status = s;
            data = d;

            Mediator m = new Mediator();

            m.
        }
    }

    class Mediator
    {
        public event StockArrival item;
        public event ValidateStock validate;
        public event EnterItemDetails action;
        public event ValidateOrder valAction;
        public event SignOffOrder signOff;
        public event UpdateOrders update;
        public event NotifyManager notify;

        private String ID, name, status;
        private DataGridView data;

        public Mediator()
        {
            this.item += new StockArrival(this.stockPrcoessor);
            this.validate += new ValidateStock(this.stockValidationProcessor);
            this.action += new EnterItemDetails(this.checkProcessor);
            this.valAction += new ValidateOrder(this.validateOrderProcessor);
            this.signOff += new SignOffOrder(this.signOffProcessor);
            this.update += new UpdateOrders(this.updateProcessor);
            this.notify += new NotifyManager(this.notificationProcessor);
        }

        public void stockPrcoessor(String id, DataGridView d){ }

        public bool stockValidationProcessor(String id, DataGridView d)
        {
            openConnection(c);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE (Id = '" + id + "')", c);
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
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

        public void checkProcessor(String id, String n, DataGridView d)
        {
            if (id == String.Empty && n == String.Empty) //Check if textbox empty
            {
                this.notify("Search Critera is missig");
            }
        }

        public void validateOrderProcessor(String id, String n, DataGridView d)
        {
            openConnection(c);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE (Id = '" + id + "')", c);
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
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

        public void signOffProcessor(String id, String n, DataGridView d)
        {
            openConnection(c);
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Stock SET Arrival = True WHERE (Id = '" + id + "')", c);
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
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

        public void updateProcessor(String id, String n, DataGridView d)
        {
            openConnection(c);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE (Id = '" + id + "')", c);
                int result = (int)cmd.ExecuteScalar();

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

        public void notificationProcessor(bool i)
        {
            if (i)
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
