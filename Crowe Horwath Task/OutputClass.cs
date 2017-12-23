using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration;

namespace Crowe_Horwath_Task
{
    public class OutputClass
    {
        public String OutputText { get; set; }
        public Output OutputFormat { get; set; }

        public enum Output {
            DB,
            Console
        }
        public String GetOutputFormat()
        {
            NameValueCollection section = (NameValueCollection) ConfigurationManager.GetSection("Settings");
            return section["OutputFormat"];
        }
    }
}
