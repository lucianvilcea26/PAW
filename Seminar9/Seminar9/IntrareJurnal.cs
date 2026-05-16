using System;

namespace Seminar9
{
    [Serializable]
    public class IntrareJurnal
    {
        public DateTime Data { get; set; }
        public string Titlu { get; set; }
        public string Continut { get; set; }
        public Dispozitie Dispozitie { get; set; }
        public bool EstePrivata { get; set; }
    }
}
