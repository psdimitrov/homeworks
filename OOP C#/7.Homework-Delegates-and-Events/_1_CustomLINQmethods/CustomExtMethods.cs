using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class CustomExtMethods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (var item in collection)
            {
                if (!predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> func)
            where TSelector : IComparable
        {
            TSelector maxElement = func(collection.FirstOrDefault());
            foreach (var item in collection)
            {
                if(func(item).CompareTo(maxElement) > 0)
                {
                    maxElement = func(item);
                }
            }
            return maxElement;
        }

    }
}
