using System.Collections.Generic;
using System.Threading.Tasks;

namespace apiProxy.impl
{
    public interface IMediaApi
    {
        Task<string> PostMedia(dynamic mediaObject);
        //Task<IEnumerable<object>> SearchMedia(string searchText);
    }
}
