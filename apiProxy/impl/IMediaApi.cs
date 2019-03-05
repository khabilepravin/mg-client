using apiProxy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace apiProxy.impl
{
    public interface IMediaApi
    {
        Task<string> PostMedia(Media mediaObject);
        Task<IEnumerable<dynamic>> GetMediaText(string id);
        //Task<IEnumerable<object>> SearchMedia(string searchText);
    }
}
