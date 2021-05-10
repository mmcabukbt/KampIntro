using System;

namespace OOP3
{
    class DBLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("DataBase e Loglandı!");
        }
    }
}
