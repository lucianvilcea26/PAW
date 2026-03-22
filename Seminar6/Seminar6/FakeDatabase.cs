using System;
using System.Collections.Generic;

namespace Seminar6
{
    public static class FakeDatabase
    {
        public static List<Carte> Carti = new List<Carte>()
        {
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Mândrie și prejudecată",
                Autor = "Jane Austen",
                AnAparitie = 1813,
                Gen = GenCarte.Roman
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Război și pace",
                Autor = "Lev Tolstoi",
                AnAparitie = 1869,
                Gen = GenCarte.Roman
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Crimă și pedeapsă",
                Autor = "Feodor Dostoievski",
                AnAparitie = 1866,
                Gen = GenCarte.Roman
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Don Quijote",
                Autor = "Miguel de Cervantes",
                AnAparitie = 1605,
                Gen = GenCarte.Roman
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Marele Gatsby",
                Autor = "F. Scott Fitzgerald",
                AnAparitie = 1925,
                Gen = GenCarte.Roman
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Originea speciilor",
                Autor = "Charles Darwin",
                AnAparitie = 1859,
                Gen = GenCarte.Stiinta
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Scurtă istorie a timpului",
                Autor = "Stephen Hawking",
                AnAparitie = 1988,
                Gen = GenCarte.Stiinta
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Dune",
                Autor = "Frank Herbert",
                AnAparitie = 1965,
                Gen = GenCarte.Fictiune
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "1984",
                Autor = "George Orwell",
                AnAparitie = 1949,
                Gen = GenCarte.Fictiune
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Viața mea",
                Autor = "Charlie Chaplin",
                AnAparitie = 1964,
                Gen = GenCarte.Biografie
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Clean Code",
                Autor = "Robert C. Martin",
                AnAparitie = 2008,
                Gen = GenCarte.Tehnic
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Design Patterns",
                Autor = "Erich Gamma",
                AnAparitie = 1994,
                Gen = GenCarte.Tehnic
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Povestiri zen",
                Autor = "Nyogen Senzaki",
                AnAparitie = 1939,
                Gen = GenCarte.Altele
            },
            new Carte()
            {
                Id = Guid.NewGuid(),
                Titlu = "Cartea curiozităților",
                Autor = "National Geographic",
                AnAparitie = 2012,
                Gen = GenCarte.Altele
            }
        };
    }
}
