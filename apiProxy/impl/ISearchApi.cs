using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace apiProxy.impl
{
    public interface ISearchApi
    {
        Task<IList<dynamic>> SearchText(string searchText);
        Task<IList<JObject>> SearchMedia(string mediaText);
        Task<IList<JObject>> SearchTextInMedia(string id, string searchText);
    }
}
