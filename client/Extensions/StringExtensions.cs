using System.Linq;

namespace client.Extensions
{
    public static class StringExtensions
    {
        public static string ToLowerWithKebabCase(string input)
        {
            input = input.Replace(" ", "-");
            return input.ToLowerInvariant();
        }

        public static string ToOriginalText(string input)
        {
            input = input.Replace("-", " ");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }
    }
}
