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
            var pivodIndex = Pivod(array, low, high);
            QuickSort(array, low, pivodIndex-1);
            QuickSort(array, pivodIndex+1, high);
        }
    }

    private static int Pivod(int[] array, int low, int high)
    {
        var pivot = array[high];
        int g = low;
        
        for (int i = low; i < high; i++)
        {
            if (array[i] < pivot)
            {
                Swap(array, i, g);

                g++;
            }
        }

        Swap(array, g, high);
        return g;

    }
    
    static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
}