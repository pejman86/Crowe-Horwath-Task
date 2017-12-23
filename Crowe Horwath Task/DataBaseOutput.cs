using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowe_Horwath_Task
{
    class DataBaseOutput : OutputClass
    {
        public String ServerName { get; set; }
        public String DBName { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }

        public DataBaseOutput()
        {
            ServerName = "name1";
            DBName = "DB1";
            UserName = "User";
            Password = "Pass";
        }
    }
}
