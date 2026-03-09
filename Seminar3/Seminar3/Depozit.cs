using System;
using System.Collections.Generic;
using System.Linq;

namespace Seminar3
{
    public class Depozit
    {
        public string Nume { get; set; }
        public event EventHandler<ComandaSchimbatStareEventArgs> ComandaSchimbatStare;
        public event EventHandler<ComandaLivrataEventArgs> ComandaLivrata;

        private List<Comanda> _comenzi;

        public Depozit(string nume)
        {
            Nume = nume;
            _comenzi = new List<Comanda>();
        }

        public void InregistreazaComanda(Comanda comanda,
            NotificareClient notificator = null)
        {
            _comenzi.Add(comanda);
            notificator?.Invoke(comanda.NumarComanda, "Comanda a fost inregistrata");
        }

        public void AvanseazaComanda(string numarComanda)
        {
            var comanda = _comenzi.FirstOrDefault(c => c.NumarComanda == numarComanda);
            if (comanda == null)
            {
                return;
            }

            if (comanda.Stare == StareComanda.Livrata)
            {
                return;
            }

            var comandaSchimbatStareEventArgs = new ComandaSchimbatStareEventArgs()
            {
                Comanda = comanda,
                StareVeche = comanda.Stare
            };

            comanda.Stare = (StareComanda)((int)comanda.Stare + 1);

            comandaSchimbatStareEventArgs.StareNoua = comanda.Stare;

            OnComandaSchimbatStare(comandaSchimbatStareEventArgs);

            if (comanda.Stare == StareComanda.Livrata)
            {
                var comandaLivrataEventArgs = new ComandaLivrataEventArgs()
                {
                    Comanda = comanda,
                    DataLivrare = DateTime.Now
                };
                OnComandaLivrata(comandaLivrataEventArgs);
            }
        }

        public List<Comanda> GetComenziActive()
        {
            return _comenzi.Where(comanda => comanda.Stare != StareComanda.Livrata).ToList();
        }

        protected virtual void OnComandaSchimbatStare(ComandaSchimbatStareEventArgs eventArgs)
        {
            ComandaSchimbatStare?.Invoke(this, eventArgs);
        }

        protected virtual void OnComandaLivrata(ComandaLivrataEventArgs eventArgs)
        {
            ComandaLivrata?.Invoke(this, eventArgs);
        }
    }
}
