using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business;
using Common;
using Common.Interfaces;
using WCF.Interfaces;
using Cv = Common.Cv;

namespace WCF.Services
{
    public partial class Service : ICvService
    {
        public IEnumerable<Cv> GetCvs()
        {
            IReader<Cv> bussiness = new CvBusiness();
            IEnumerable<Cv> tmpCvs = bussiness.Get().ToList();
            foreach (var tmpCv in tmpCvs)
            {
                tmpCv.Formations = this.GetFormations(tmpCv.Id);
                tmpCv.Missions = this.GetMissions(tmpCv.Id);
            }
            return tmpCvs ;
        }

    }
}
