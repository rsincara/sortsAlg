using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithmsASP.Models
{
    public static class TextModel
    {
        public static Dictionary<string, int> Words = new Dictionary<string, int>();

        public static Dictionary<string, int> GetDictionarySortedByHoare(string text) => Words =
            text.Split(' ', '.', '?', '!', ',', ':', '(', ')', '\n', '\r')
                .Where(x => x != "")
                .LazyHoareSort()
                .GroupBy(x => x)
                .ToDictionary(group => group.Key, group => group.Count());

        public static Dictionary<string, int> GetDictionarySortedByBubble(string text) =>
            Words = text.Split(' ', '.', '?', '!', ',', ':', '(', ')', '\n', '\r')
                .Where(x => x != "")
                .LazyBubbleSort()
                .GroupBy(x => x)
                .ToDictionary(group => group.Key, group => group.Count());
    }
}
