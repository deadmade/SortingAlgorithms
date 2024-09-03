using System;
using System.Collections.Generic;

namespace CodeOptimization
{
    public class D
    {
        public static void Start()
        {
            var array = new int[] { 10, 5, 12, 3, 55, 30, 4, 11, 2 };
            var result = LongestConsecutiveSequence(array);
            Console.WriteLine(result);
        }

        public static int LongestConsecutiveSequence(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            HashSet<int> numSet = new HashSet<int>(nums);
            int maxLength = 0;

            foreach (int num in nums)
            {
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentLength = 1;

                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentLength++;
                    }

                    maxLength = Math.Max(maxLength, currentLength);
                }
            }

            return maxLength;
        }
    }
}