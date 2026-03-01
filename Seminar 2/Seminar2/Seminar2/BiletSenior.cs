using System;

namespace Seminar2
{
    public class BiletSenior : Bilet
    {
        private const double _procentReducere = 0.3;

        private int _varstaClient;      
        public int VarstaClient
        {
            get 
            { 
                return _varstaClient; 
            }
            set 
            {
                if (value < 60)
                    throw new ArgumentException("Clientul nu este eligibil pentru eliberarea unui bilet senior");
                _varstaClient = value; 
            }
        }

        public BiletSenior(
                string numeFilm, 
                int numarSala, 
                TipFilm tipFilm, 
                DateTime expiraLa, 
                Client client, 
                int numarLoc, 
                double pretBaza,
                int varstaClient
            ) : base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza)
        {
            VarstaClient = varstaClient;
        }

        public override double GetReducere()
        {
            return PretBaza * _procentReducere;
        }
    }
}
