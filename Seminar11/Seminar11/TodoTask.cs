using System;

namespace Seminar11
{
    public class TodoTask
    {
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public Prioritate Prioritate { get; set; }
        public DateTime DataCreare { get; set; }
        public bool Efectuat { get; set; }
    }
}
