using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IReader<out T>
    {
        T Get(int id);
        IEnumerable<T> Get();
    }
}
