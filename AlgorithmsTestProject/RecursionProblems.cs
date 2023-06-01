
namespace AlgorithmsTestProject
{
    public static class RecursionProblems
    {
        public static int Factorial(int n)
        {
            throw new NotImplementedException();
        }

        public static int Fibonnaci(int n)
        {
            throw new NotImplementedException();
        }

        public static void ReverseArray<T>(T[] array, int n = 0)
        {
            throw new NotImplementedException();
        }

        public static int Count<T>(IIterator<T> iterator)
        {
            throw new NotImplementedException();
        }

        public static IIterator<T> GetLast<T>(IIterator<T> iterator)
        {
            throw new NotImplementedException();
        }

        public static int Sum(IIterator<int> iterator)
        {
            throw new NotImplementedException();
        }

        public static IList<T> Reverse<T>(IList<T> xs)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<int> MergeSort(IEnumerable<int> values)
        {
            List<int> list1 = new List<int> { };
            List<int> list2 = new List<int> { };
            foreach(var x in values)
            {
                if (list1.Count() < values.Count())
                {
                    list1.Add(x);
                }
                else
                {
                    list2.Add(x);
                }
            }
            if(list1.Count()>2 || list2.Count() > 2)
            {
                MergeSort(list1);
                MergeSort(list2);
            }
            else
            {
                if (list1[0] > list1[1])
                {
                    var tmp = list1[1];
                    list1[1] = list1[0];
                    list1[0] = tmp;

                }
                if (list2[0] > list2[1])
                {
                    var tmp = list2[1];
                    list2[1] = list2[0];
                    list2[0] = tmp;

                }
                return list1.Concat(list2);
            }
            return list1.Concat(list2);
            
        }

        public static IEnumerable<int> Merge(IEnumerable<int> xs, IEnumerable<int> ys)
        {
            foreach (var x in xs)
            {
                while (ys.Any() && ys.First() < x)
                {
                    yield return ys.First();
                    ys = ys.Skip(1);
                }

                yield return x;
            }
        }
    }
}
