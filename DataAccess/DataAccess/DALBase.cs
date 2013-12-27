using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;

namespace DataAccess.DataAccess
{
    public abstract class DALBase
    {
        protected static CvModelContainer Db = new CvModelContainer();
    }
}
