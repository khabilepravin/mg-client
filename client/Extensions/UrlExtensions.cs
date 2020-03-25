using System;

namespace client.Extensions
{
    public static class UrlExtensions
    {
        public static string GetPopularQuotesUrl(dynamic media)
        {
            var mediaType = Convert.ToInt32(media["season"]) > 0 ? "tv" : "movies";
            var mediaName = StringExtensions.ToLowerWithKebabCase(Convert.ToString(media["name"]));
            var id = Convert.ToString(media["id"]);

            return $"{mediaType}/{id}/{mediaName}/popularquotes";
        }
    }
}
