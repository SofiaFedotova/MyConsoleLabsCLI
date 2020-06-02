using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list_S
{
    interface ICommand
    {
         void Do();
         void Message();
    };
}
