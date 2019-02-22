using apiProxy.Models;
using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace apiProxy.impl
{
    public class MediaApi : ApiProxyBase, IMediaApi
    {
        public MediaApi(IOptions<ApiProxySetting> options) : base(options) {}
        public async Task<string> PostMedia(Media mediaObject)
        {
            var response = await _baseUrl.AppendPathSegment("media")
                                .PostMultipartAsync(mp => mp
                                .AddFile(mediaObject.Name, mediaObject.FilesubtitleFile.OpenReadStream(), mediaObject.FilesubtitleFile.FileName)
                                .AddJson("media", mediaObject));

            return Convert.ToString(response.Content);
        }
    }
}
