using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.Main
{
    class testing
    {
        int testing(EventArgs e)
        {
            event e test;
            this.test += new EnterItem(this.testEvent);
            bool i = this.test();
            return i;
        }

        bool testEvent(Event e)
        {
            EventHandler handler = e;
            Delegate[] delegates = e.GetInvocationList();
            e.Method.Invoke(delegates.Target, e.GetParameters());
            return e.delegates[0];
        }
    }
}
