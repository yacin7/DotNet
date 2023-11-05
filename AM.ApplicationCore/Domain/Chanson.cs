using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace festivals.Domain
{
    public class Chanson
    {
        public int ChansonId { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateSortie { get; set; }
        public int duree { get; set; }
        public StyleMusical StyleMusical { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 3)]
        public string Titre { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Veuillez entrer un nombre positif.")]
        public int VuesYoutube { get; set; }
        [ForeignKey("ArtisteFk")]
        public int ArtisteId { get; set; }
        public Artiste Artiste { get; set; }
    }
}
