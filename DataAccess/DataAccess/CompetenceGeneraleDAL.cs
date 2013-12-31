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
    public class CompetenceGeneraleDAL : DALBase, IReader<CompetenceGenerale>, IReaderOnFilter<CompetenceGenerale, Cv>
    {

        #region IReader Implementation

        public CompetenceGenerale Get(int id)
        {
            return (from competenceGenerale in Db.CompetencesGenerales
                    where competenceGenerale.Id == id
                    select competenceGenerale).First();
        }

        public IEnumerable<CompetenceGenerale> Get()
        {
            return (from competenceGenerale in Db.CompetencesGenerales
                    select competenceGenerale);
        }

        #endregion

        public IEnumerable<CompetenceGenerale> Get(Cv cv)
        {
            return (from competenceGenerale in Db.CompetencesGenerales
                    where competenceGenerale.CvId == cv.Id
                    select competenceGenerale);
        }
    }
}
