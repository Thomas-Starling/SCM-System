using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.Mediator
{
    public delegate void SignOffEvent(String id, String n, String s, DataGridView d);
    public delegate void StockArrival(String id, String n, String s, DataGridView d);
    public delegate bool ValidateStock(String id, String n, String s, SqlConnection c, DataGridView d);
    public delegate void EnterItemDetails(String id, String n, String s, DataGridView d);
    public delegate bool ValidateOrder(String id, String n, String s, SqlConnection c, DataGridView d);        
    public delegate bool SignOffOrder(String id, String n, String s, SqlConnection c, DataGridView d);
    public delegate bool UpdateOrders(String id, String n, String s, SqlConnection c, DataGridView d);
    public delegate void NotifyManager(bool r);

    class signOffMediator
    {
        public event SignOffEvent signOff;

        private String ID, name, status;
        private DataGridView data;
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");

        public managerMediator()
        {
            this.signOff += new OrderManagmentEvent(this.signOffEventHandler);
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
        public event EnterItem item;
        public event ValidateItem validate;
        public event PerformAction action;
        public event ValidateAction valAction;
        public event NotifyManager signOff;
        public event UpdateItem update;
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

        public voids stockPrcoessor(String id, String n, DataGridView d)
        {
            
        }

        public voids stockValidationProcessor(String id, String n, DataGridView d)
        {

        }

        public voids checkProcessor(String id, String n, DataGridView d)
        {

        }

        public voids validateOrderProcessor(String id, String n, DataGridView d)
        {

        }

        public voids signOffProcessor(String id, String n, DataGridView d)
        {

        }

        public voids updateProcessor(String id, String n, DataGridView d)
        {

        }

        public voids notificationProcessor(bool i)
        {
            
        }
    }
}
