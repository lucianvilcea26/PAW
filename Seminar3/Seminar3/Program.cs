using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comanda c1 = new Comanda("Lucian Vilcea", "lucian.vilcea@ie.ase.ro");
            c1.AdaugaProdus(new Produs("mouse", 70, 1));
            c1.AdaugaProdus(new Produs("tastatura", 120.99m, 1));

            Depozit d = new Depozit("Stefanesti");

            var optiuni = Console.ReadLine();
            NotificareClient notificator = BuildNotificator(optiuni);

            d.InregistreazaComanda(c1, notificator);

            d.ComandaSchimbatStare +=
                (object sender, ComandaSchimbatStareEventArgs e) =>
                {
                    Console.WriteLine($"Comanda {e.Comanda.NumarComanda} din " +
                        $"{e.StareVeche} in {e.StareNoua} ");
                };

            d.ComandaLivrata += OnComandaLivrata;

            d.AvanseazaComanda("CMD-001");
            d.AvanseazaComanda("CMD-001");
            d.AvanseazaComanda("CMD-001");
        }

        private static void OnComandaLivrata(object sender, ComandaLivrataEventArgs e)
        {
            Console.WriteLine($"Comanda {e.Comanda.NumarComanda} a fost livrata la data de {e.DataLivrare.ToString("dd.MM.yyyy")}");
        }

        private static NotificareClient BuildNotificator(string optiuni)
        {
            NotificareClient notificator = null;
            if (optiuni.Contains("sms"))
                notificator += NotificareService.NotificaPrinSms;
            if (optiuni.Contains("email"))
                notificator += NotificareService.NotificaPrinEmail;
            if (optiuni.Contains("log"))
                notificator += NotificareService.Log;
            return notificator;
        }
    }
}
