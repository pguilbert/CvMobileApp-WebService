using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using CompetenceGeneraleDAO = DataAccess.Model.CompetenceGenerale;
using CompetenceGeneraleDTO = Common.CompetenceGenerale;

namespace ClassMappers 
{
    public class CompetenceGeneraleMapper : IMapper<CompetenceGeneraleDAO, CompetenceGeneraleDTO>
    {
        public CompetenceGeneraleDAO ToDAO(CompetenceGeneraleDTO element)
        {
            return new CompetenceGeneraleDAO
            {
                Id = element.Id,
                Nom = element.Nom,
                Categorie = element.Categorie,
                Description = element.Description
            };
        }

        public CompetenceGeneraleDTO ToDTO(CompetenceGeneraleDAO element)
        {
            return new CompetenceGeneraleDTO
            {
                Id = element.Id,
                Nom = element.Nom,
                Categorie = element.Categorie,
                Description = element.Description,
                Cv = new CvMapper().ToDTO(element.Cv)
            };
        }
    }
}
