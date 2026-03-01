using System.Collections.Generic;
using System.Linq;

namespace Seminar2
{
    public class CasaBilete
    {
        public List<Bilet> Bilete { get; set; }

        public CasaBilete()
        {
            Bilete = new List<Bilet>();
        }

        public void AdaugaBilet(Bilet bilet)
        {
            Bilete.Add(bilet);
        }

        public double GetIncasariTotale()
        {
            return Bilete.Sum(bilet => bilet.CalculeazaPretFinal());
        }

        public double GetReduceriAcordate()
        {
            return Bilete.Sum(bilet => bilet.GetReducere());
        }

        public int GetNumarBiletePerTip<T>() where T : Bilet
        {
            // Această varianta verifica daca obiectul curent este de tip T sau derivat din T.
            // Din acest motiv, pentru T = Bilet, metoda va numara toate biletele,
            // inclusiv instanțele claselor derivate (BiletStudent, BiletSenior, BiletVip),
            // din moment ce toate subtipurile de Bilet sunt la randul lor bilete
            // return Bilete.OfType<T>().Count();

            return Bilete.Count(bilet => bilet.GetType() == typeof(T));
        }

        public Bilet GetBiletulCelMaiScump()
        {
            return Bilete.OrderByDescending(bilet => bilet.CalculeazaPretFinal()).FirstOrDefault();
        }       
    }
}
