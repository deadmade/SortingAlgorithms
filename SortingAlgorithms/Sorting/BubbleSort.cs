namespace SortingAlgorythms;

public class BubbleSort : IBaseSortingClass
{
    public int[] Sort(int[] arrayToSort)
    {
        for (var i = 0; i < arrayToSort.Length; i++)
        for (var j = 0; j < arrayToSort.Length; j++)
            if (arrayToSort[i] < arrayToSort[j])
            {
                var nextValue = arrayToSort[j];
                arrayToSort[j] = arrayToSort[i];
                arrayToSort[i] = nextValue;
            }

        return arrayToSort;
    }
}