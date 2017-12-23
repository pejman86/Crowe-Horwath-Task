using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowe_Horwath_Task
{
    class ConsoleOutput : OutputClass
    {
        public String ExitCommand { get; set; }

        public ConsoleOutput()
        {
            ExitCommand = "exit";
        }
    }
}
