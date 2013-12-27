using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using DataAccess.Model;

namespace DataAccess.DataAccess
{
    public class CvDAL : DALBase, IReader<Cv>
    {
        #region IReader Implementation

        public Cv Get(int id)
        {
            return (from cv in Db.CvSet
                    where cv.Id == id
                    select cv).First();
        }

        public IEnumerable<Cv> Get()
        {
            return (from cv in Db.CvSet
                    select cv);
        }

        #endregion
    }
}
