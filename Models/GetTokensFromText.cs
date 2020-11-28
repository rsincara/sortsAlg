using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithmsASP.Models
{
    public static class GetTokensFromText
    {
        private static List<string> separators = new List<string>
        {
            ".", "?", "!", ",", ":", "\\", "/", "(", ")", "\"","\r","\n"
        };
            
        public static IEnumerable<string> GetTokens(this string text)
        {
            foreach (var separator in separators)
                text=text.Replace(separator, " ");
            var result = text.Split(' ')
                .Select(word => word.ToLower())
                .Where(x => x != "")
                .ToList();
            return result;
        }
    }
}
