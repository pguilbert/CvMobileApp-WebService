using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Mission
    {
        public int Id { get; set; }
        public string Poste { get; set; }
        public string LibelleMission { get; set; }
        public string Description { get; set; }
        public System.DateTime DateDebut { get; set; }
        public System.DateTime DateFin { get; set; }
    }
}
