using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace festivals.Domain
{
    public class Artiste
    {
        public int ArtisteId { get; set; }
        public string Contact { get; set; }
        public string DateNaissance { get; set; }
        public string Nationalite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public List<Chanson> Chansons { get; set; }

        public List<Concert> Concerts { get; set; }
    }
}
