using System;

namespace Seminar7
{
    public class Carte
    {
        public Guid Id { get; set; }
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public int AnAparitie { get; set; }
        public GenCarte Gen { get; set; }
    }
}
