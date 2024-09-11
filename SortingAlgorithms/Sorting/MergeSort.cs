namespace SortingAlgorythms;

public class MergeSort : IBaseSortingClass
{
    public int[] Sort(int[] arrayToSort)
    {
        Mergesort(arrayToSort, 0, arrayToSort.Length - 1);
        return arrayToSort;
    }

    private static void Mergesort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int middle = (low + high) / 2;
            Mergesort(array, low, middle);
            Mergesort(array, middle + 1, high);
            Merge(array, low, middle, high);
        }
    }

    private static void Merge(int[] array, int low, int middle, int high)
    {
        int[] temp = new int[high - low + 1];
        int left = low, right = middle + 1, k = 0;

        while (left <= middle || right <= high)
        {
            if (left <= middle && (right > high || array[left] <= array[right]))
            {
                temp[k++] = array[left++];
            }
            else
            {
                temp[k++] = array[right++];
            }
        }

        for (int i = 0; i < temp.Length; i++)
        {
            array[low + i] = temp[i];
        }
    }
}