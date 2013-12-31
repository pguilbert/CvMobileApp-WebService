using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Common;
using Common.Interfaces;
using WCF.Interfaces;

namespace WCF.Services
{
    partial class Service : ICompetenceGeneraleService
    {
        public IEnumerable<CompetenceGenerale> GetCompetencesGenerales(int idCv)
        {
            IReaderOnFilter<CompetenceGenerale , Cv> bussiness = new CompetenceGeneraleBusiness();
            return bussiness.Get(new Cv(){ Id = idCv });
        }
    }
}
