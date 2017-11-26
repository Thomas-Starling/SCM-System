using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCM_System.Mediator
{
    public delegate void OrderManagmentEvent(String id, String n, String s, DataGridView d);
    public delegate void EnterItem(String id, String n, DataGridView d);
    public delegate bool ValidateItem(String id, String n, SqlConnection c, DataGridView d);
    public delegate void PerformAction(String id, String n, DataGridView d);
    public delegate bool ValidateAction(String id, String n, SqlConnection c, DataGridView d);
    public delegate bool UpdateItem(String id, String n, SqlConnection c, DataGridView d);
    public delegate void NotifyManager(bool r);

    class managerMediator
    {
        public event OrderManagmentEvent order;

        private String ID, name, status;
        private DataGridView data;
        private SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");

        public managerMediator()
        {
            this.status += new OrderManagmentEvent(this.OrderManagmentEventHandler);
        }

        public void OrderManagmentEventHandler(String id, String n, String s, DataGridView d)
        {
            ID = id;
            name = n;
            data = d;
            status = s;

            Mediator m = new Mediator();

            m.item(ID, n, d, Connection);
            bool i = m.validate(ID, n, Connection, d);
            m.staff(i);
        }
    }

    class Mediator
    {
        public event EnterItem item;
        public event ValidateItem validate;
        public event DisplayResults display;

        public Mediator()
        {
            this.item += new EnterItem(this.itemPrcoessor);
            this.validate += new ValidateItem(this.validateItemPrcoessor);
            this.display += new DisplayResults(this.displayProcessor);
            this.staff += new NotifyStaffMember(this.notifyProcessor);
        }
    }
}
