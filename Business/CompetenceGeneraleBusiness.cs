using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMappers;
using Common;
using Common.Interfaces;
using DataAccess.DataAccess;
using CompetenceGeneraleDAO = DataAccess.Model.CompetenceGenerale;
using CompetenceGeneraleDTO = Common.CompetenceGenerale;

namespace Business
{
    public class CompetenceGeneraleBusiness : IReader<CompetenceGeneraleDTO>, IReaderOnFilter<CompetenceGeneraleDTO, Cv>
    {
        private CompetenceGeneraleDAL _competenceGeneraleDalDAL = new CompetenceGeneraleDAL();
        private IMapper<CompetenceGeneraleDAO, CompetenceGeneraleDTO> _mapper = new CompetenceGeneraleMapper();
        public CompetenceGeneraleDTO Get(int id)
        {
            CompetenceGeneraleDAO dao = _competenceGeneraleDalDAL.Get(id);
            return _mapper.ToDTO(dao);
        }

        public IEnumerable<CompetenceGeneraleDTO> Get()
        {
            IEnumerable<CompetenceGeneraleDAO> dao = _competenceGeneraleDalDAL.Get();
            return dao.Select(p => _mapper.ToDTO(p));
        }

        public IEnumerable<CompetenceGeneraleDTO> Get(Cv cv)
        {
            IEnumerable<CompetenceGeneraleDAO> dao = _competenceGeneraleDalDAL.Get(cv);
            return dao.Select(p => _mapper.ToDTO(p));
        }
    }
}
