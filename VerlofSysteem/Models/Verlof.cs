namespace VerlofSysteem.Models
{
    public class Verlof
    {
        public int Id { get; set; }
        public string Gebruiker { get; set; }
        public DateTime AanvraagDatum { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EindDatum { get; set; }
    }
}
