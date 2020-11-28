using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithmsASP.Models
{
    public static class TextModel
    {
        public static Dictionary<string, int> WordsByHoare = new Dictionary<string, int>();
        public static Dictionary<string, int> WordsByBubble = new Dictionary<string, int>();

        public static Dictionary<string, int> GetDictionarySortedByHoare(string text) => 
            WordsByHoare =
                text.GetTokens()
                    .Where(x => x != "")
                    .LazyHoareSort()
                    .GroupBy(x => x)
                    .ToDictionary(group => group.Key, group => group.Count());

        public static Dictionary<string, int> GetDictionarySortedByBubble(string text) =>
            WordsByBubble = 
                text.GetTokens()
                    .Where(x => x != "")
                    .LazyBubbleSort()
                    .GroupBy(x => x)
                    .ToDictionary(group => group.Key, group => group.Count());
    }
}
