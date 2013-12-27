using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMappers;
using Common.Interfaces;
using DataAccess.DataAccess;
using CvDAO = DataAccess.Model.Cv;
using CvDTO = Common.Cv;


namespace Business
{
    public class CvBusiness : IReader<CvDTO>
    {
        private CvDAL _cvDAL = new CvDAL();
        private IMapper<CvDAO, CvDTO> _mapper = new CvMapper();
        public CvDTO Get(int id)
        {
             CvDAO dao = _cvDAL.Get(id);
             return _mapper.ToDTO(dao);
        }

        public IEnumerable<CvDTO> Get()
        {
            IEnumerable<CvDAO> dao = _cvDAL.Get();
            return dao.Select(p => _mapper.ToDTO(p));
        }
    }
}
