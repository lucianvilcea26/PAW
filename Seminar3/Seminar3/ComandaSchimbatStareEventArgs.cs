using System;

namespace Seminar3
{
    public class ComandaSchimbatStareEventArgs : EventArgs
    {
        public Comanda Comanda { get; set; }
        public StareComanda StareVeche { get; set; }
        public StareComanda StareNoua { get; set; }
    }
}
