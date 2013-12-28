using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public IEnumerable<CompetenceGenerale> CompetencesGenerales = new List<CompetenceGenerale>();
        public IEnumerable<Formation> Formations = new List<Formation>();
    }
}
