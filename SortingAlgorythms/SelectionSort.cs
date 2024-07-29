﻿namespace SortingAlgorythms;

public class SelectionSort : BaseSortingClass
{
    public override int[] Sort(int[] arrayToSort)
    {
        
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            var currentSmallestIndex = i;
            for (int j = i; j < arrayToSort.Length; j++)
            {
                if (arrayToSort[j] < arrayToSort[currentSmallestIndex])
                {
                    currentSmallestIndex = j;
                }
            }

            var swapValue = arrayToSort[currentSmallestIndex];
            arrayToSort[currentSmallestIndex] = arrayToSort[i];
            arrayToSort[i] = swapValue;
        }

        return arrayToSort;
    }
}