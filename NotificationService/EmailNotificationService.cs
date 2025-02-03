using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public class EmailNotificationService : INotificationService

    {
        public void Send(string email, string message)
        {
            Console.WriteLine($"Enviando Email a {email}: {message}");
        }

    }
}
