using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el tipo de notificación:");
            Console.WriteLine("1. Email");
            Console.WriteLine("2. SMS");
            int option = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el mensaje: ");
            string message = Console.ReadLine();

            INotificationService notificationService = null;
            LoggerService logger = new LoggerService();

            switch (option)
            {
                case 1:
                    Console.Write("Ingrese el correo electrónico: ");
                    string email = Console.ReadLine();
                    notificationService = new EmailNotificationService();
                    notificationService.Send(email, message);
                    break;

                case 2:
                    Console.Write("Ingrese el número de teléfono: ");
                    string phoneNumber = Console.ReadLine();
                    notificationService = new SmsNotificationService();
                    notificationService.Send(phoneNumber, message);
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            logger.Log(message);

        }

    }

}