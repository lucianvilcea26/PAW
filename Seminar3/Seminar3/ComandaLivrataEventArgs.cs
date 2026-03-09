using System;

namespace Seminar3
{
    public class ComandaLivrataEventArgs : EventArgs
    {
        public Comanda Comanda { get; set; }
        public DateTime DataLivrare { get; set; }
    }
}