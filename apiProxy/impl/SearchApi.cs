using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace apiProxy.impl
{
    public class SearchApi : ApiProxyBase, ISearchApi
    {
        public SearchApi(IOptions<ApiProxySetting> options) : base(options) { }

        public Task<IEnumerable<object>> Search(string searchText)
        {
            var response = _baseUrl.AppendPathSegment("search").AppendPathSegment(searchText)
                .GetAsync();

            return null;
        }
    }
}
