using apiProxy.Models;
using Flurl;
using Flurl.Http;
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

        public async Task<string> PostMedia(Media mediaObject)
        {
            var endpointUrl = _apiProxySetting.BaseUrl.AppendPathSegment("media");

            var response = await endpointUrl.PostMultipartAsync(mp => mp
            .AddFile(mediaObject.Name, mediaObject.FilesubtitleFile.OpenReadStream(), mediaObject.FilesubtitleFile.FileName)
            .AddJson("media", mediaObject));
                
            return "";
        }
    }
}
