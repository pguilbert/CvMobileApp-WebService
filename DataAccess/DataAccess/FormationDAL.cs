using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using DataAccess.Model;
using Cv = Common.Cv;

namespace DataAccess.DataAccess
{
    public class FormationDAL : DALBase , IReaderOnFilter<Formation, Cv> 
    {
        public IEnumerable<Formation> Get(Cv cv)
        {
            return (from formation in Db.Formations
                    where formation.CvId == cv.Id
                    select formation);
        }
    }
}
