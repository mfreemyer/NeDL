
using System;

namespace InterfaceNoDI
{
    public class ProductService
    {
        public void Log(string message)
        {
            ILogger logger = new FileLogger();    //Class options include FileLogger and DataBaseLogger (and any new ones)
            logger.Log(message); // in this program, the '.Log' comes from the Log method in the ILogger interface.
            Console.WriteLine(""); // for spacing between the two different logger type outputs.
            ILogger logger2 = new DataBaseLogger();
            logger2.Log(message);
            Console.WriteLine(""); // for spacing between the two different logger type outputs.
            ILogger logger3 = new CloudLogger();
            logger3.Log(message);
        }

    }
}