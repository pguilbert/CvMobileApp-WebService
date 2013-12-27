using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace WCF.Interfaces
{
    [ServiceContract]
    public interface ICompetenceGeneraleService
    {
        [OperationContract]
        IEnumerable<CompetenceGenerale> GetCompetencesGenerales(int idCv);
    }
}
