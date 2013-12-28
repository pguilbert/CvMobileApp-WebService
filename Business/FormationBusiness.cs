using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMappers;
using Common;
using Common.Interfaces;
using DataAccess.DataAccess;
using FormationDAO = DataAccess.Model.Formation;
using FormationDTO = Common.Formation;

namespace Business
{
    public class FormationBusiness : IReaderOnFilter<FormationDTO, Cv>
    {
        private FormationDAL _formationDAL = new FormationDAL();
        private IMapper<FormationDAO, FormationDTO> _mapper = new FormationMapper();

        public IEnumerable<FormationDTO> Get(Cv cv)
        {
            IEnumerable<FormationDAO> dao = _formationDAL.Get(cv);
            return dao.Select(p => _mapper.ToDTO(p));
        }
    }
}
