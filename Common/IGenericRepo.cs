using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common
{
    public interface IGenericRepo<T>
    {
        Task<List<T>> GetAll();
    }
}
