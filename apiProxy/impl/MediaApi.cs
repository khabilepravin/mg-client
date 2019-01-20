using Microsoft.Extensions.Options;
using System.Threading.Tasks;

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
    }
}
