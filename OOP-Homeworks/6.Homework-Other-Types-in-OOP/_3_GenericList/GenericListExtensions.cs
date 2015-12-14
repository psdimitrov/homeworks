using System;
namespace _3_GenericList
{
    public static class GenericListExtensions
    {
        public static T Min<T>(this GenericList<T> list) where T : IComparable<T>
        {
            checkEmpty(list);
            T min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if(min.CompareTo(list[i]) > 0)
                {
                    min = list[i];
                }
            }

            return min;
        }

        public static T Max<T>(this GenericList<T> list) where T : IComparable<T>
        {
            checkEmpty(list);
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (max.CompareTo(list[i]) < 0)
                {
                    max = list[i];
                }
            }
            return max;
        }

        private static void checkEmpty<T>(GenericList<T> list)
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty collection");
            }
        }
    }
}
