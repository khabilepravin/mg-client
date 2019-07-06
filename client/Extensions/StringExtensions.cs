namespace client.Extensions
{
    public static class StringExtensions
    {
        public static string ToLowerWithKebabCase(string input)
        {
            input = input.Replace(" ", "-");
            return input.ToLowerInvariant();
        }
    }
}
