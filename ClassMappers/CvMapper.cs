using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using CvDAO = DataAccess.Model.Cv;
using CvDTO = Common.Cv;

namespace ClassMappers
{
    public class CvMapper : IMapper<CvDAO, CvDTO>
    {
        public CvDAO ToDAO(CvDTO element)
        {
            return new CvDAO
            {
                Id = element.Id,
                Nom = element.Nom,
                Prenom = element.Prenom,
                Titre = element.Titre
            };
        }

        public CvDTO ToDTO(CvDAO element)
        {
            return new CvDTO
            {
                Id = element.Id,
                Nom = element.Nom,
                Prenom = element.Prenom,
                Titre = element.Titre
            };
        }
    }
}
