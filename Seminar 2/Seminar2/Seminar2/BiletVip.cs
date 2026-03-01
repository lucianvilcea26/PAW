using System;

namespace Seminar2
{
    public class BiletVip : Bilet
    {
        public bool IncludePopcorn { get; set; }
        public bool IncludeBautura { get; set; }

        public BiletVip(
                string numeFilm, 
                int numarSala, 
                TipFilm tipFilm, 
                DateTime expiraLa, 
                Client client, 
                int numarLoc, 
                double pretBaza,
                bool includePopcorn,
                bool includeBautura
            ) : base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza)
        {
            IncludePopcorn = includePopcorn;
            IncludeBautura = includeBautura;
        }

        public override double CalculeazaPretFinal()
        {
            return PretBaza + GetExtras();
        }

        public double GetExtras()
        {
            return (IncludePopcorn ? 15 : 0) + (IncludeBautura ? 10 : 0);
        }
    }
}
