using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list_S.Tasks
{
    class ExitTask : ITask
    {
        public void Do()
        {
            Process.Exit();
        }
    }
}
