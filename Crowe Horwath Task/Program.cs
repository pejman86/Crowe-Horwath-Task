using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Crowe_Horwath_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputClass output = new OutputClass();
            String outputFormat = output.GetOutputFormat();

            switch (outputFormat)
            {
                case "Console":
                    output.OutputFormat = OutputClass.Output.Console;
                    break;
                case "DB":
                    output.OutputFormat = OutputClass.Output.DB;
                    break;
                default:
                    output.OutputFormat = OutputClass.Output.Console;
                    break;
            }

            if (output.OutputFormat == OutputClass.Output.Console)
            {
                Console.WriteLine("Output format is console application based on the App settings in App.config (you can change it there!)");
                Console.WriteLine();
                ConsoleOutput console = new ConsoleOutput();

                Console.Write("Contacting the Web Api to read the output data ");

                for (var i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }


                try
                {
                    console.OutputText = GetOutputText();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }

                Console.WriteLine("Output is: ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine(console.OutputText);
                Console.WriteLine();
                Console.WriteLine("Type "+ console.ExitCommand + " to close the program.");
                while (true)
                {
                    if (Console.ReadLine() == console.ExitCommand)
                        break;
                }
            }
            else if (output.OutputFormat == OutputClass.Output.DB)
            {
                //not going to continue this
                Console.Write("Please enter the DB information ");

                Console.Write("Contacting the Web Api to read the output data ");

                Console.WriteLine("Type exit to close the program.");
                while (true)
                {
                    if (Console.ReadLine() == "exit")
                        break;
                }
            }
        }

        public static string GetOutputText()
        {
            webService1.WebService1 myService = new webService1.WebService1();
            var response = myService.GetOutputText();
            Thread.Sleep(1000);
            Console.WriteLine("\nData Received!");
            return response;
        }
    }
}
