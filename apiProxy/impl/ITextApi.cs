using System.Collections.Generic;
using System.Threading.Tasks;

namespace apiProxy.impl
{
    public interface ITextApi
    {
        Task<IEnumerable<dynamic>> GetMediaPopularTextById(string mediaId);
    }
}
