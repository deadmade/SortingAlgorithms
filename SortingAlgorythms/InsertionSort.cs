﻿namespace SortingAlgorythms;

public class InsertionSort : BaseSortingClass
{
    public override int[] Sort(int[] array)
    {
        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

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