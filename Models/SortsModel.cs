using System;
using System.Collections.Generic;
using System.Linq;
namespace SortingAlgorithmsASP.Models
{ 
    internal static class ExtensionClass
    {
        public static void Swap<T>(this List<T> list, int firstIndex, int secondIndex)
        {
            var t = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = t;
        }
    }

    public static class Sort
    {

        public static IEnumerable<T> LazyHoareSort<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            var list = collection.ToList();
            if (list.Count == 0) yield break;
            HoareSort(list, 0, list.Count - 1);
            foreach (var e in list)
                yield return e;
        }
        
        public static void HoareSort<T>(this List<T> array)
            where T : IComparable
        {
            if (array == null || array.Count == 0) return;
            HoareSort(array, 0, array.Count - 1);
        }

        private static void HoareSort<T>(List<T> array, int start, int end)
            where T : IComparable
        {
            if (start == end) return;
            var pivot = array[end];
            var index = start;
            for (var i = start; i <= end - 1; i++)
                if (array[i].CompareTo(pivot) <= 0)
                {
                    array.Swap(i, index);
                    index++;
                }

            array.Swap(index, end);
            if (index > start) HoareSort(array, start, index - 1);
            if (index < end) HoareSort(array, index + 1, end);
        }
        
        public static void BubbleSort<T>(this List<T> list)
            where T : IComparable
        {
            for (var i = 0; i < list.Count; i++)
            for (var j = list.Count - 1; j > i; j--)
                if (list[j - 1].CompareTo(list[j]) > 0)
                    list.Swap(j-1,j);
        }
        
        public static IEnumerable<T> LazyBubbleSort<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            var list = collection.ToList();
            for (var i = 0; i < list.Count; i++)
            for (var j = list.Count - 1; j > i; j--)
                if (list[j - 1].CompareTo(list[j]) > 0)
                    list.Swap(j-1,j);
            foreach (var e in list)
                yield return e;
        }
    }
}

