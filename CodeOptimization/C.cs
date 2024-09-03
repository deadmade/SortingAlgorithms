using System;
using System.Collections.Generic;

namespace CodeOptimization
{
    public class C
    {
        public static void Start()
        {
            var array = new double[] { 37.0, 36.6, 36.2, 37.2, 37.1, 37.0, 36.9, 36.7, 36.6, 37.1 };
            var result = SortTemperatures(array);
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        private static double[] SortTemperatures(double[] array)
        {
            // Define the range and precision
            double minValue = 36.1;
            double maxValue = 37.2;
            int precision = 10; // Since we are dealing with one decimal place

            // Create a frequency array
            int[] frequency = new int[(int)((maxValue - minValue) * precision) + 1];

            // Count the occurrences of each temperature
            foreach (var temp in array)
            {
                int index = (int)((temp - minValue) * precision);
                frequency[index]++;
            }

            // Create the sorted result array
            var result = new List<double>();
            for (int i = 0; i < frequency.Length; i++)
            {
                double temp = minValue + (i / (double)precision);
                for (int j = 0; j < frequency[i]; j++)
                {
                    result.Add(temp);
                }
            }

            return result.ToArray();
        }
    }
}