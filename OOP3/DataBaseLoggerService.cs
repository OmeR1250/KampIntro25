using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP3
{
    public class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
