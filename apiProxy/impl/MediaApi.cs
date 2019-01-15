using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Flurl.Util;
using Microsoft.Extensions.Options;

namespace apiProxy.impl
{
    public class MediaApi : IMediaApi
    {
        private readonly ApiProxySetting _apiProxySetting;
        public MediaApi(IOptions<ApiProxySetting> options)
        {
            _apiProxySetting = options.Value;
        }

        public async Task<string> PostMedia(dynamic mediaObject)
        {
            await Task.CompletedTask;
            return "";
        }

        public async Task<IEnumerable<object>> SearchMedia(string searchText)
        {
            var result = await _apiProxySetting.BaseUrl.AppendPathSegment($"search/{searchText}").GetJsonAsync();
            return result;
            
        }
    }
}
