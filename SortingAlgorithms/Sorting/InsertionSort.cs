﻿namespace SortingAlgorythms;

public class InsertionSort : IBaseSortingClass
{
    public int[] Sort(int[] array)
    {
        var n = array.Length;
        for (var i = 1; i < n; i++)
        {
            var key = array[i];
            var j = i - 1;

            // Verschieben der Elemente
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }

        return array;
    }
}