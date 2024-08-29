namespace SortingAlgorythms;

public class SelectionSort : IBaseSortingClass
{
    public int[] Sort(int[] arrayToSort)
    {
        for (var i = 0; i < arrayToSort.Length; i++)
        {
            var currentSmallestIndex = i;
            for (var j = i; j < arrayToSort.Length; j++)
                if (arrayToSort[j] < arrayToSort[currentSmallestIndex])
                    currentSmallestIndex = j;

            var swapValue = arrayToSort[currentSmallestIndex];
            arrayToSort[currentSmallestIndex] = arrayToSort[i];
            arrayToSort[i] = swapValue;
        }

        return arrayToSort;
    }
}