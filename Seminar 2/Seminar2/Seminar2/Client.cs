using System;
using System.Linq;

namespace Seminar2
{
    public class Client
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Contains('@') && value.Contains('.'))
                    _email = value;
                else
                    throw new ArgumentException("Adresa de email este invalida");
            }
        }

        private string _telefon;
        public string Telefon
        {
            get
            {
                return _telefon;
            }
            set
            {
                if (value.Length == 10)
                    _telefon = value;
                else
                    throw new ArgumentException("Numarul de telefon este invalid");
            }
        }

        public Client(string nume, string prenume, string email, string telefon)
        {
            Nume = nume;
            Prenume = prenume;
            Email = email;
            Telefon = telefon;
        }
    }
}
