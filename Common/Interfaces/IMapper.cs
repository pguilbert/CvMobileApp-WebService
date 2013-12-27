using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IMapper<DAOClass, DTOClass>
    {
        DTOClass ToDTO(DAOClass element);
        DAOClass ToDAO(DTOClass element);
    }
}
