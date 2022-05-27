using System;
using System.Collections.Generic;
using System.Text;

namespace NoInterfaceOrDI
{
    public class DatabaseLogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside the Log method of the DatabaseLogger class.");
            LogToDatabase(message);
        }
        private void LogToDatabase(string message)
        {
            Console.WriteLine("Method: LogToDatabase, Text: {0}", message);
        }
    }
}
