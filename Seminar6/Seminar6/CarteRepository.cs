using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Seminar6
{
    public class CarteRepository
    {
        public List<Carte> GetAll()
        {
            return FakeDatabase.Carti;
        }

        public Carte GetById(Guid id)
        {
            return FakeDatabase.Carti.SingleOrDefault(c => c.Id == id);
        }

        public void Add(Carte carte)
        {
            FakeDatabase.Carti.Add(carte);
        }

        public void Update(Carte carte)
        {
            var carteDb = FakeDatabase.Carti.SingleOrDefault(c => c.Id == carte.Id);
            carteDb = carte;
        }

        public void Delete(Guid id)
        {
            var carteDb = FakeDatabase.Carti.SingleOrDefault(c => c.Id == id);
            FakeDatabase.Carti.Remove(carteDb);
        }
    }
}
