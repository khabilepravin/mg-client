using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace apiProxy.impl
{
    public class UserFavoriteApi : ApiProxyBase, IUserFavoriteApi
    {
        public UserFavoriteApi(IOptions<ApiProxySetting> options) : base(options) { }

        public async Task<string> AddToFavorite(string userId, string parsedTextId)
        {
           var response =  await _baseUrl.AppendPathSegment("userfavorite")
                            .PostJsonAsync(new { parsedTextId = parsedTextId, userId = userId })
                            .ReceiveJson<dynamic>();

            return response == null ? string.Empty : response.Id;
        }
    }
}
