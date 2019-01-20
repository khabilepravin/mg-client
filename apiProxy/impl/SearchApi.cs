using System.Collections.Generic;
using System.Threading.Tasks;

namespace apiProxy.impl
{
    public class SearchApi : ISearchApi
    {
        public Task<IEnumerable<object>> Search(string searchText)
        {
            throw new System.NotImplementedException();
        }
    }
}
