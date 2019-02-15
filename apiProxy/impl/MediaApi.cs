using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace apiProxy.impl
{
    public class MediaApi : ApiProxyBase, IMediaApi
    {
        private readonly ApiProxySetting _apiProxySetting;
        public MediaApi(IOptions<ApiProxySetting> options) : base()
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
