using System;
using System.Collections.Generic;

namespace Seminar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client("Popescu", "Ion", "ion.popescu@gmail.com", "0721000001");
            Client c2 = new Client("Ionescu", "Maria", "maria.ionescu@yahoo.com", "0731000002");
            Client c3 = new Client("Marin", "Gheorghe", "gheorghe.marin@gmail.com", "0741000003");
            Client c4 = new Client("Stan", "Elena", "elena.stan@outlook.com", "0751000004");
            Client c5 = new Client("Popa", "Andrei", "andrei.popa@gmail.com", "0761000005");

            DateTime viitor = DateTime.Now.AddDays(7);
            DateTime trecut = DateTime.Now.AddDays(-1);

            Bilet b1 = new Bilet("Dune 2", 1, TipFilm.Actiune, viitor, c1, 14, 30.0);
            BiletStudent b2 = new BiletStudent("Dune 2", 1, TipFilm.Actiune, viitor, c2, 15, 30.0, "ASE-2023-4471", "CSIE");
            BiletSenior b3 = new BiletSenior("Oppenheimer", 3, TipFilm.Istoric, viitor, c3, 22, 28.0, 67);
            BiletVip b4 = new BiletVip("Dune 2", 2, TipFilm.Actiune, viitor, c4, 3, 60.0, true, true);
            BiletVip b5 = new BiletVip("Oppenheimer", 3, TipFilm.Istoric, viitor, c5, 5, 60.0, true, false);
            BiletStudent biletExpirat = new BiletStudent("Avatar", 2, TipFilm.Actiune, trecut, c2, 10, 25.0, "", "CSIE");

            List<Bilet> toateBiletele = new List<Bilet> { b1, b2, b3, b4, b5 };
            CasaBilete casa = new CasaBilete();
            casa.AdaugaBilet(b1);
            casa.AdaugaBilet(b2);
            casa.AdaugaBilet(b3);
            casa.AdaugaBilet(b4);
            casa.AdaugaBilet(b5);

            bool ruleaza = true;

            while (ruleaza)
            {
                Console.Clear();
                Console.WriteLine("=== MENIU PRINCIPAL ===");
                Console.WriteLine("1. Afisare bilete");
                Console.WriteLine("2. Calcul preturi (polimorfism)");
                Console.WriteLine("3. Validare bilete");
                Console.WriteLine("4. Raport casa de bilete");
                Console.WriteLine("5. Identificare tip bilet (is)");
                Console.WriteLine("6. Demonstratie exceptii");
                Console.WriteLine("0. Iesire");
                Console.Write("\nAlege optiunea: ");

                string opt = Console.ReadLine();
                Console.Clear();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("--- BILETE ---");
                        foreach (var b in toateBiletele)
                            Console.WriteLine(b);
                        break;

                    case "2":
                        Console.WriteLine("--- CALCUL PRETURI ---");
                        List<IPretCalculabil> biletePret = new List<IPretCalculabil> { b1, b2, b3, b4, b5 };
                        foreach (var b in biletePret)
                        {
                            Console.WriteLine($"Tip bilet: {b.GetType().Name} | Reducere: {b.GetReducere():F2} RON | Total: {b.CalculeazaPretFinal():F2} RON");
                        }
                        break;

                    case "3":
                        Console.WriteLine("--- VALIDARE BILETE ---");
                        List<IValidabil> bileteValidare = new List<IValidabil> { b1, b2, b3, b4, b5, biletExpirat };

                        foreach (var b in bileteValidare)
                        {
                            Console.WriteLine($"{(b.EsteValid() ? "VALID" : "INVALID")} -> {b}");
                        }
                        break;

                    case "4":
                        Console.WriteLine("--- RAPORT CASA DE BILETE ---");
                        Console.WriteLine($"Total bilete    : {casa.Bilete.Count}");
                        Console.WriteLine($"Studenti        : {casa.GetNumarBiletePerTip<BiletStudent>()}");
                        Console.WriteLine($"Seniori         : {casa.GetNumarBiletePerTip<BiletSenior>()}");
                        Console.WriteLine($"VIP             : {casa.GetNumarBiletePerTip<BiletVip>()}");
                        Console.WriteLine($"Standard        : {casa.GetNumarBiletePerTip<Bilet>()}");
                        Console.WriteLine($"Reduceri totale : {casa.GetReduceriAcordate():F2} RON");
                        Console.WriteLine($"Incasari totale : {casa.GetIncasariTotale():F2} RON");

                        Bilet max = casa.GetBiletulCelMaiScump();
                        Console.WriteLine($"Cel mai scump   : {max.NumeFilm} ({max.CalculeazaPretFinal():F2} RON)");
                        break;

                    case "5":
                        Console.WriteLine("--- IDENTIFICARE TIP BILET ---");
                        foreach (var b in toateBiletele)
                        {
                            if (b is BiletStudent bs)
                                Console.WriteLine($"STUDENT : {b.NumeFilm} | {bs.Facultate} | {bs.NumarLegitimatie}");
                            else if (b is BiletSenior s)
                                Console.WriteLine($"SENIOR  : {b.NumeFilm} | {s.VarstaClient} ani");
                            else if (b is BiletVip v)
                                Console.WriteLine($"VIP     : {b.NumeFilm} | extras {v.GetExtras():F2} RON");
                            else
                                Console.WriteLine($"STANDARD: {b.NumeFilm}");
                        }
                        break;

                    case "6":
                        Console.WriteLine("--- EXCEPTII ---");

                        try
                        {
                            new Client("Test", "User", "gresit", "0700");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Eroare client: " + ex.Message);
                        }

                        try 
                        { 
                            new Bilet("Test", 1, TipFilm.Drama, viitor, c1, 10, -5); 
                        }
                        catch (ArgumentException ex)
                        { 
                            Console.WriteLine("Eroare bilet: " + ex.Message); 
                        }

                        try 
                        { 
                            new BiletSenior("Test", 1, TipFilm.Drama, viitor, c1, 10, 28, 45); 
                        }
                        catch (ArgumentException ex)
                        { 
                            Console.WriteLine("Eroare senior: " + ex.Message); 
                        }

                        try 
                        { 
                            b1.NumarLoc = 999; 
                        }
                        catch (ArgumentException ex)
                        { 
                            Console.WriteLine("Eroare loc: " + ex.Message); 
                        }

                        break;

                    case "0":
                        ruleaza = false;
                        continue;

                    default:
                        Console.WriteLine("Optiune invalida.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Apasa orice tasta pentru a reveni la meniu...");
                Console.ReadKey();
            }
        }
    }
}
