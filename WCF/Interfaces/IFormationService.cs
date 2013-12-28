using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace WCF.Interfaces
{
    [ServiceContract]
    public interface IFormationService
    {
        [OperationContract]
        IEnumerable<Formation> GetFormations(int idCv);
    }
}
