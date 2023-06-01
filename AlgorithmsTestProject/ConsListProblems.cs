using Newtonsoft.Json.Linq;

namespace AlgorithmsTestProject;

public static class ConsListProblems
{
    public static IConsList<T> InsertBefore<T>(this IConsList<T> self, 
        int index, T value)
    {
        var result = new List<T> {};
        var count = 0;
        foreach(T item in self.ToEnumerable())
        {
            if (count == index)
            {
                result.Add(value);
            }

            result.Add(item);
            count++;
        }
        return result.ToConsList();
    }

    public static IConsList<T> RemoveAt<T>(this IConsList<T> self, 
        int index)
    {
        var result = new List<T> { };
        var count = 0;
        foreach (T item in self.ToEnumerable())
        {
            if (count == index)
            {
                count++;
                continue;
            }

            result.Add(item);
            count++;
        }
        return result.ToConsList();
    }
}