using System.Threading.Tasks;

namespace apiProxy.impl
{
    public interface IUserFavoriteApi
    {
        Task<string> AddToFavorite(string userId, string parsedTextId);
    }
}
