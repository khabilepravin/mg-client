using System.Collections.Generic;
using System.Threading.Tasks;

namespace apiProxy.impl
{
    public interface ISearchApi
    {
        Task<IEnumerable<object>> Search(string searchText);
    }
}
