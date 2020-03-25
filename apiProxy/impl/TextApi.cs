using apiProxy.Models;
using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace apiProxy.impl
{
    public class TextApi : ApiProxyBase, ITextApi
    {
        public TextApi(IOptions<ApiProxySetting> options) : base(options) { }

        public async Task<IEnumerable<MediaText>> GetMediaPopularTextById(string mediaId)
        {
            return await _baseUrl.AppendPathSegment("text/mediatext").AppendPathSegment(mediaId)
                            .GetJsonAsync<IEnumerable<MediaText>>();
        }

        public async Task<IEnumerable<MediaText>> GetSurroundingText(string textId)
        {
            return await _baseUrl.AppendPathSegment($"text/{textId}")
                            .GetJsonAsync<IEnumerable<MediaText>>();
        }
    }
}
