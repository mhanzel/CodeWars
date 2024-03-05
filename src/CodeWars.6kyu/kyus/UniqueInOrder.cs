using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyu.kyus
{
    public static class UniqueInOrder
    {
        public static IEnumerable<T> UniqueInOrderMethod<T>(IEnumerable<T> iterable)
        {
            if (iterable == null || iterable.Count() == 0)
            {
                IEnumerable<T> list = new List<T>() { };
                return list;
            }
            var listToOut = new List<T>() { iterable.First() };
            iterable.ToList().ForEach(element =>
            {
                if (!EqualityComparer<T>.Default.Equals(listToOut.Last(), element))
                {
                    listToOut.Add(element);
                }
            });
            return (IEnumerable<T>)listToOut;
        }
        public static IEnumerable<T> UniqueInOrderBetter<T>(IEnumerable<T> iterable)
        {
            T previous = default(T);
            foreach (T current in iterable)
            {
                if (!current.Equals(previous))
                {
                    previous = current;
                    yield return current;
                }
            }
        }
    }
}
/*
 * 
Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.

For example:

uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
uniqueInOrder([1,2,2,3,3])       == {1,2,3}
 * 
 * 
 */
