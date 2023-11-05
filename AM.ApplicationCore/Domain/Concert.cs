namespace festivals.Domain
{
    public class Concert
    {
        public int ConcertId { get; set; }
        public double Cachet { get; set; }
         
        public DateTime DateConcert { get; set; }
        public int Duree { get; set; }

        public int FestivalFk { get; set; }
        public Festival Festival { get; set; }

        public int ArtisteFk { get; set; }
        public Artiste Artiste { get; set; }
    }
}