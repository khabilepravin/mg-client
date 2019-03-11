using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json.Linq;

namespace apiProxy.impl
{
    public class SearchApi : ApiProxyBase, ISearchApi
    {
        public SearchApi(IOptions<ApiProxySetting> options) : base(options) { }

        public async Task<IList<dynamic>> SearchText(string searchText)
        {
            return await _baseUrl.AppendPathSegment("search").AppendPathSegment(searchText)
                .GetJsonListAsync();
        }

        public async Task<IList<JObject>> SearchMedia(string mediaText)
        {
            return await _baseUrl.AppendPathSegments("media").AppendPathSegment(mediaText)
                .GetJsonAsync<IList<JObject>>();
        }
    }
}
