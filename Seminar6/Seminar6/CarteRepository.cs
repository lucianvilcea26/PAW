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
            return new List<Carte>(FakeDatabase.Carti);
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
            int index = FakeDatabase.Carti.FindIndex(x => x.Id == carte.Id);
            if (index >= 0)
                FakeDatabase.Carti[index] = carte;
        }

        public void Delete(Guid id)
        {
            FakeDatabase.Carti.RemoveAll(c => c.Id == id);
        }
    }
}
