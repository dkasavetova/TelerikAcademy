using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Extension methods for IEnumerable
/// </summary>
public static class IEnumerableExtensions
{
    /// <summary>
    /// Calculates the sum of all elements
    /// </summary>
    /// <param name="selector">Function that maps the generic type T to decimal.</param>
    public static decimal Sum<T>(this IEnumerable<T> collection, Func<T, decimal> selector)
    {
        decimal sum = 0M;

        foreach (var item in collection)
        {
            sum += selector(item);
        }

        return sum;
    }

    /// <summary>
    /// Calculates the product of all elements
    /// </summary>
    /// <param name="selector">Function that maps the generic type T to decimal.</param>
    public static decimal Product<T>(this IEnumerable<T> collection, Func<T, decimal> selector)
    {
        decimal product = 1M;

        foreach (var item in collection)
        {
            product *= selector(item);
        }

        return product;
    }

    /// <summary>
    /// Finds the minimal element of a IEnumerable collection
    /// </summary>
    /// <param name="selector">Function that maps the generic type T to decimal.</param>
    public static T Min<T>(this IEnumerable<T> collection, Func<T, decimal> selector)
    {
        T min = collection.ElementAt(0);

        for (int i = 1; i < collection.Count(); i++)
        {
            if (selector(collection.ElementAt(i)) < selector(min))
            {
                min = collection.ElementAt(i);
            }
        }

        return min;
    }

    /// <summary>
    /// Finds the maximal element of a IEnumerable collection
    /// </summary>
    /// <param name="selector">Function that maps the generic type T to decimal.</param>
    public static T Max<T>(this IEnumerable<T> collection, Func<T, decimal> selector)
    {
        T max = collection.ElementAt(0);

        for (int i = 1; i < collection.Count(); i++)
        {
            if (selector(collection.ElementAt(i)) > selector(max))
            {
                max = collection.ElementAt(i);
            }
        }

        return max;
    }

    /// <summary>
    /// Calculates the average of all elements
    /// </summary>
    /// <param name="selector">Function that maps the generic type T to decimal.</param>
    public static decimal Average<T>(this IEnumerable<T> collection, Func<T, decimal> selector)
    {
        decimal avg = collection.Sum(selector) / collection.Count();
        return avg;
    }
}

