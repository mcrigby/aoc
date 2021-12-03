using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._2{
    public static class Extensions
    {
        public static IEnumerable<T> OrdinalGroup<T, C>(this IEnumerable<T> source, Func<T, IComparable<C>> comparitor, 
            Func<T, T, T> aggregate)
        {
            T current = source.First();
            foreach (var item in source.Skip(1))
            {
                if (!comparitor(current).Equals(comparitor(item)))
                {
                    yield return current;
                    current = item;
                    continue;
                }

                current = aggregate(current, item);
            }

            yield return current;
        }
    }
}