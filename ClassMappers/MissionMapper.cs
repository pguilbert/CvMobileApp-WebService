using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using MissionDAO = DataAccess.Model.Mission;
using MissionDTO = Common.Mission;

namespace ClassMappers
{
    public class MissionMapper : IMapper<MissionDAO, MissionDTO>
    {
        public MissionDAO ToDAO(MissionDTO element)
        {
            return new MissionDAO
            {
                Id = element.Id,
                DateDebut = element.DateDebut,
                DateFin = element.DateFin,
                Description = element.Description,
                LibelleMission = element.LibelleMission,
                Poste = element.Poste
            };
        }

        public MissionDTO ToDTO(MissionDAO element)
        {
            return new MissionDTO
            {
                Id = element.Id,
                DateDebut = element.DateDebut,
                DateFin = element.DateFin,
                Description = element.Description,
                LibelleMission = element.LibelleMission,
                Poste = element.Poste
            };
        }
    }
}
