using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using DataAccess.Model;

namespace DataAccess.DataAccess
{
    public class CvDAL : DALBase,  IReader<Cv>
    {

        #region IReader Implementation

        public Cv Get(int id)
        {
            return (from cv in Db.Cvs
                    where cv.Id == id
                    select cv).First();
        }

        public IEnumerable<Cv> Get()
        {
            return (from cv in Db.Cvs
                    select cv);
        }

        #endregion
    }
}
