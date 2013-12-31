using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Business;
using Common;
using WCF.Interfaces;

namespace WCF.Services
{
    partial class Service : IFormationService
    {
        public IEnumerable<Formation> GetFormations(int idCv)
        {
            var businessFormations = new FormationBusiness();
            return  businessFormations.Get(new Cv() { Id = idCv });
        }
    }
}
