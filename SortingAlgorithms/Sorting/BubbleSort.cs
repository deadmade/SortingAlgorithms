namespace SortingAlgorythms;

public class BubbleSort : IBaseSortingClass
{
    public int[] Sort(int[] arrayToSort)
    {
        for (var i = 0; i < arrayToSort.Length-1; i++)
        for (var j = i; j < arrayToSort.Length-i-1; j++)
            if (arrayToSort[i] < arrayToSort[j])
            {
                var nextValue = arrayToSort[j];
                arrayToSort[j] = arrayToSort[i];
                arrayToSort[i] = nextValue;
            }

        return arrayToSort;
    }
}