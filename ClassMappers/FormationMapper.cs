using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using FormationDAO = DataAccess.Model.Formation;
using FormationDTO = Common.Formation;

namespace ClassMappers
{
    public class FormationMapper : IMapper<FormationDAO, FormationDTO>
    {
        public FormationDAO ToDAO(FormationDTO element)
        {
            return new FormationDAO
            {
            };
        }

        public FormationDTO ToDTO(FormationDAO element)
        {
            return new FormationDTO
            {
                Id = element.Id,
                Periode = element.Periode,
                Libelle = element.Libelle,
                Cv = new CvMapper().ToDTO(element.Cv)
            };
        }
    }
}
