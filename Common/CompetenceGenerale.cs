using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CompetenceGenerale
    {
        public int Id { get; set; }
        public string Categorie { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public Cv Cv { get; set; }
    }
}
