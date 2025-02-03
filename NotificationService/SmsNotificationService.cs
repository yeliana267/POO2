using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public class SmsNotificationService : INotificationService
    {
        public void Send(string phoneNumber, string message)
        {
            Console.WriteLine($"Enviando SMS a {phoneNumber}: {message}");
        }

    }
}
