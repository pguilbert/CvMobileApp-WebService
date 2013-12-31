using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Common;
using WCF.Interfaces;

namespace WCF.Services
{
    partial class Service : IMissionService
    {
        public IEnumerable<Mission> GetMissions(int idCv)
        {
            var bussiness = new MissionBusiness();
            return bussiness.Get(new Cv(){ Id = idCv });
        }
    }
}
