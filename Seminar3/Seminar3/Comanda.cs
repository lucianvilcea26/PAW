using System;
using System.Collections.Generic;
using System.Linq;

namespace Seminar3
{
    public class Comanda
    {
        private static int _counter = 0;
        public string NumarComanda { get; }
        public string NumeClient { get; }
        public string EmailClient { get; }
        public List<Produs> Produse { get; }
        public StareComanda Stare { get; set; }
        public DateTime DataPlasare { get; }

        public Comanda(string numeClient, string emailClient)
        {
            NumarComanda = $"CMD-{++_counter:d3}";
            NumeClient = numeClient;
            EmailClient = emailClient;
            Produse = new List<Produs>();
            Stare = StareComanda.Plasata;
            DataPlasare = DateTime.Now;
        }

        public decimal GetValoareTotala()
        {
            return Produse.Sum(produs => produs.Cantitate * produs.Pret);
        }

        public void AdaugaProdus(Produs produs)
        {
            Produse.Add(produs);
        }

        public override string ToString()
        {
            return $"Numar: {NumarComanda} | Client: {NumeClient} " +
                $"| Valoare: {GetValoareTotala()}";
        }
    }
}
