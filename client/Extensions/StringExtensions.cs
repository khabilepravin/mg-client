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
            var stringParts = input.Split("-");
            if(stringParts.Length > 0)
            {
                string modifiedString = "";
                foreach(var str in stringParts)
                {
                    modifiedString += $"{str.First().ToString().ToUpper()}{str.Substring(1)} ";
                }

                return modifiedString;
            }
            else
            {
                return input;
            }
        }
    }
}
