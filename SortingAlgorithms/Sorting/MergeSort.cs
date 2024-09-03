namespace SortingAlgorythms;

public class MergeSort : IBaseSortingClass
{
    public int[] Sort(int[] arrayToSort)
    {
        Mergesort(arrayToSort, 0, arrayToSort.Length - 1);

        return arrayToSort;
    }

    private static void Mergesort(int[] arrayToSort, int low, int high)
    {
        if ((high - low) !=1)
        {
            
        }
        Mergesort(arrayToSort, low, high/2);
        Mergesort(arrayToSort, high/2+1, high);
    }
    
    
}