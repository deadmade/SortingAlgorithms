namespace SortingAlgorythms;

public class Quicksort : IBaseSortingClass
{
    public int[] Sort(int[] arrayToSort)
    {
        QuickSort(arrayToSort, 0, arrayToSort.Length - 1);

        return arrayToSort;
    }

    private static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            var pivotIndex = Partition(array, low, high);
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        var pivot = array[high];
        var i = low - 1;

        for (var j = low; j < high; j++)
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }

        Swap(array, i + 1, high);
        return i + 1;
    }

    private static void Swap(int[] array, int a, int b)
    {
        var temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
}