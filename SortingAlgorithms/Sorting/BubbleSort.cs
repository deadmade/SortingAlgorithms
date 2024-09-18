namespace SortingAlgorythms;

public class BubbleSort : IBaseSortingClass
{
    public int[] Sort(int[] arrayToSort)
    {
        for (var i = 0; i < arrayToSort.Length-1; i++)
        for (var j = 0; j < arrayToSort.Length-i-1; j++)
            if (arrayToSort[j] > arrayToSort[j+1])
            {
                var nextValue = arrayToSort[j];
                arrayToSort[j] = arrayToSort[j+1];
                arrayToSort[j+1] = nextValue;
            }

        return arrayToSort;
    }
}