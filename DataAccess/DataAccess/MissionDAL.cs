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
    public class MissionDAL : DALBase, IReaderOnFilter<Mission, Cv>
    {
        public IEnumerable<Mission> Get(Cv cv)
        {
            return (from mission in Db.Missions
                    where mission.Cv.Id == cv.Id
                    select mission);
        }
    }
}
