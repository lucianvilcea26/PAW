using System;

namespace Seminar2
{
    public class BiletStudent : Bilet
    {
        private const double _procentReducere = 0.2;

        public string NumarLegitimatie { get; set; }
        public string Facultate { get; set; }

        public BiletStudent(
                string numeFilm, 
                int numarSala, 
                TipFilm tipFilm, 
                DateTime expiraLa, 
                Client client, 
                int numarLoc, 
                double pretBaza,
                string numarLegitimatie,
                string facultate
            ) : base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza)
        {
            NumarLegitimatie = numarLegitimatie;
            Facultate = facultate;
        }

        public override double GetReducere()
        {
            return PretBaza * _procentReducere;
        }

        public override bool EsteValid()
        {
            return base.EsteValid() && !string.IsNullOrWhiteSpace(NumarLegitimatie);
        }
    }
}
