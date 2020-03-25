using apiProxy.Models;
using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<dynamic>> GetMediaText(string id)
        {
            return await _baseUrl.AppendPathSegment("media").AppendPathSegment(id)
                            .GetJsonAsync<IEnumerable<dynamic>>();
        }

        public async Task<IEnumerable<dynamic>> GetAllMedia()
        {
            return await _baseUrl.AppendPathSegment("media")
                            .GetJsonAsync<IEnumerable<dynamic>>();
        }
    }
}
