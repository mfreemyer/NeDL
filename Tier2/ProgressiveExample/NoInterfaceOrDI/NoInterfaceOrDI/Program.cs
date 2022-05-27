// this is an example taken (and slightly tweaked) from Alec's GitHub

using System;

namespace NoInterfaceOrDI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService1 = new ProductService();
            productService1.LogToFile("First log to file. (beep boob beep. Pretending info is being logged to some file.)");
            Console.WriteLine(""); // for spacing between the two outputs. 
            productService1.LogToDatabase("First log to database. (beep beep boop. Pretending info is being logged to some db.)");
        }
    }
}