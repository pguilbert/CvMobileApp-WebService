using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Cv
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Titre { get; set; }

        public ICollection<CompetenceGenerale> CompetencesGenerales = new List<CompetenceGenerale>();
        public IEnumerable<Formation> Formations {get; set;}
        public IEnumerable<Mission> Missions { get; set; }
    }
}
