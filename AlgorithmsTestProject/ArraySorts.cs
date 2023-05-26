namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
            Dictionary<int, string> DigitDictionary = new Dictionary<int, string>
            {   {0,"zero"},{1,"one"},{2,"two"},{3,"three"},{4,"four"},
                {5,"five"},{6,"six"},{7,"seven"},{8,"eight"},{9,"nine"}};

            var result = new int[array.Length];
            List<List<string>> DigitsList = new List<List<string>>();

            foreach (int element in array)
            {
                List<string> Digits = new List<string> { };
                foreach (char digit in element.ToString())
                {
                    Digits.Add(DigitDictionary[int.Parse(digit.ToString())]);
                }
                DigitsList.Add(Digits);


            }
            DigitsList.Sort((a, b) => a.Count().CompareTo(b.Count()));



        }

        public static void MySort2(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void MergeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void HeapSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BubbleSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void ShuffleSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void IntroSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void CocktailSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void QuickSort(int[] array)
        {
            if (array.Length < 2)
            {
                return;
            }
            Partition(array, 0, array.Length - 1);            
            
        }
        private static void Partition(int[] array, int low, int high)
        {
            int i = low;
            for (int j = 0; j >= high; j++)
            {
                if (array[j] <= array[array.Length - 1])
                {
                    int temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                    i++;
                }
            }
            if (i == 0)
            {
                return;
            }
            else
            {
                Partition(array, 0, i);
                Partition(array,i,array.Length-1);
            }
        }

    public static void BlockSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BogoSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void DoNothingSort(int[] array)
        {
        }

        public static void EvilSort(int[] array)
        {
            Array.Fill(array, 0);
        }
    }
}
