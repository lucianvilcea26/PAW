using System;

namespace Seminar2
{
    public class Bilet : IPretCalculabil, IValidabil
    {
        public string NumeFilm { get; set; }
        public int NumarSala { get; set; }
        public TipFilm TipFilm { get; set; }
        public DateTime ExpiraLa { get; set; }
        public Client Client { get; set; }
        
        private int _numarLoc { get; set; }
        public int NumarLoc
        {
            get
            {
                return _numarLoc;
            }
            set
            {
                if (value < 1 || value > 200)
                    throw new ArgumentException("Numarul locului este invalid");
                _numarLoc = value;
            }
        }

        private double _pretBaza { get; set; }
        public double PretBaza
        {
            get
            {
                return _pretBaza;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Pretul de baza este invalid");
                _pretBaza = value;
            }
        }

        public Bilet(string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza)
        {
            NumeFilm = numeFilm;
            NumarSala = numarSala;
            TipFilm = tipFilm;
            ExpiraLa = expiraLa;
            Client = client;
            NumarLoc = numarLoc;
            PretBaza = pretBaza;
        }

        public virtual double CalculeazaPretFinal()
        {
            return PretBaza - GetReducere();
        }

        public virtual double GetReducere()
        {
            return 0;
        }

        public virtual bool EsteValid()
        {
            return ExpiraLa > DateTime.Now;
        }

        public override string ToString()
        {
            return "[" + GetType().Name + "] " + NumeFilm +
                   " | Sala " + NumarSala +
                   " | Loc " + NumarLoc +
                   " | " + ExpiraLa.ToString("dd.MM.yyyy HH:mm") +
                   " | " + Client.Nume + " " + Client.Prenume;
        }
    }
}
