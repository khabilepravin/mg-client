using apiProxy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace apiProxy.impl
{
    public interface ITextApi
    {
        Task<IEnumerable<MediaText>> GetMediaPopularTextById(string mediaId);
    }
}
