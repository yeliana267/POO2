using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public class LoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine($"Notificación registrada en logs: {message}");
        }

    }
}
