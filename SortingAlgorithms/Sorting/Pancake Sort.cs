namespace SortingAlgorythms
{
    public class Pancake_Sort
    {
        public static void Sort(int[] arr)
        {
            for (int currSize = arr.Length; currSize > 1; --currSize)
            {
                int maxIndex = FindMax(arr, currSize);

                if (maxIndex != currSize - 1)
                {
                    Flip(arr, maxIndex);
                    PrintArray(arr);
                    Flip(arr, currSize - 1);
                    PrintArray(arr);
                }
            }
        }

        private static int FindMax(int[] arr, int n)
        {
            int maxIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private static void Flip(int[] arr, int i)
        {
            int start = 0;
            while (start < i)
            {
                int temp = arr[start];
                arr[start] = arr[i];
                arr[i] = temp;
                start++;
                i--;
            }
        }

        private static void PrintArray(int[] arr)
        {
            Console.Clear();
            foreach (int item in arr)
            {
                string pancake = new string('=', item);
                int middle = pancake.Length / 2;
                pancake = pancake.Insert(middle, item.ToString());
                Console.WriteLine(pancake);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}