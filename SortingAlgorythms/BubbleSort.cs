namespace SortingAlgorythms;

public class BubbleSort : BaseSortingClass
{
    public override int[] Sort(int[] arrayToSort)
    {
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            for (int j = 0; j < arrayToSort.Length; j++)
            {
                if (arrayToSort[i] < arrayToSort[j])
                {
                    var nextValue = arrayToSort[j];
                    arrayToSort[j] = arrayToSort[i];
                    arrayToSort[i] = nextValue;
                }
            }

        }

        return arrayToSort;
    }
}