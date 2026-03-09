using System;

namespace Seminar3
{
    public static class NotificareService
    {
        public static void NotificaPrinSms(string numarComanda, string mesaj)
        {
            Console.WriteLine($"[SMS] Comanda {numarComanda}: {mesaj}");
        }

        public static void NotificaPrinEmail(string numarComanda, string mesaj)
        {
            Console.WriteLine($"[EMAIL] Comanda {numarComanda}: {mesaj}");
        }

        public static void Log(string numarComanda, string mesaj)
        {
            Console.WriteLine($"[LOG] Comanda {numarComanda}: {mesaj}");
        }
    }
}
