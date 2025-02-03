using System;
using System.Linq;

namespace SOLID_Principle
{
    interface INotificationSender
    {
        void Send(string message);
    }

    class EmailNotification : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Enviando Email: {message}");
        }
    }

    class SMSNotification : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Enviando SMS: {message}");
        }
    }

    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Notificación registrada en logs: {message}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Seleccione el tipo de notificación:");
            Console.WriteLine("1. Email");
            Console.WriteLine("2. SMS");
            int opcion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el mensaje: ");
            string mensaje = Console.ReadLine();
            
            INotificationSender sender = opcion == 1 ? new EmailNotification() : new SMSNotification();
            sender.Send(mensaje);

            Logger logger = new Logger();
            logger.Log(mensaje);
        }
    }
}
