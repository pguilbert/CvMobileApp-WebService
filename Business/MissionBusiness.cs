using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMappers;
using Common;
using Common.Interfaces;
using DataAccess.DataAccess;
using MissionDAO = DataAccess.Model.Mission;
using MissionDTO = Common.Mission;

namespace Business
{
    public class MissionBusiness  : IReaderOnFilter<MissionDTO, Cv>
    {
        private MissionDAL _missionDAL = new MissionDAL();
        private IMapper<MissionDAO, MissionDTO> _mapper = new MissionMapper();

        public IEnumerable<MissionDTO> Get(Cv cv)
        {
            IEnumerable<MissionDAO> dao = _missionDAL.Get(cv);
            return dao.Select(p => _mapper.ToDTO(p));
        }
    }
}
