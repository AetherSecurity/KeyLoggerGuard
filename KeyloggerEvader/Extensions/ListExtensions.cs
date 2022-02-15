using System;
using System.Collections.Generic;

namespace KeyloggerEvader.Extensions
{
    public static class ListExtensions
    {
        public static bool Remove<T>(this IList<T> list, Predicate<T> predicate)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (predicate(list[i]))
                {
                    list.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}