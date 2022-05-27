using System;

namespace NoInterfaceOrDI
{
    public class ProductService
    {
        private readonly FileLogger _fileLogger = new FileLogger(); // creating a read-only _filelogger object of the FileLogger class here
        private readonly DatabaseLogger _databaseLogger = new DatabaseLogger(); // doing same, but for db object and dblogger class
        public void LogToFile(string message) // creating a method and passing it a new variable that we're creating called message
        {
            _fileLogger.Log(message); // The '.Log' part is pointing to the Log method in the FileLogger Class.
        }
        public void LogToDatabase(string message)
        {
            _databaseLogger.Log(message); // The '.Log' part is pointing to the Log method in the FileLogger Class.
        }
    }
}
