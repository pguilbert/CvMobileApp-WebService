using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Formation
    {
        public int Id { get; set; }
        public string Periode { get; set; }
        public string Libelle { get; set; }
        public virtual Cv Cv { get; set; }
    }
}
