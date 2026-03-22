namespace Seminar4
{
    public class Contact
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public bool NotificariActive { get; set; }

        public override string ToString()
        {
            return $"{Prenume} {Nume} - {Telefon}";
        }
    }
}
