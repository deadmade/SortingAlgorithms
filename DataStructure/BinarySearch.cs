namespace DataStructure;

public class BinarySearch
{
    public static void Start()
    {
        int[] arr = { 5, 12, 3, 19, 7, 1, 14, 8, 20, 2, 11, 6, 18, 9, 4, 15, 10, 13, 17, 16 };
        int elementToFind = 5;
        int position = BinarySearchAlgorithm(arr, elementToFind);
        Console.WriteLine($"Element {elementToFind} found at position {position +1}");
        
    }

    private static int BinarySearchAlgorithm(int[] array, int elemmentToFind)
    {
        array = array.OrderBy(x => x).ToArray();
       
        int lowerBound = 0;
        int upperBound = array.Length - 1;
        int middle = (lowerBound + upperBound) / 2;

        while (array[middle] != elemmentToFind)
        {
            
            if (array[middle] < elemmentToFind)
            {
                lowerBound = middle + 1;
            }
            else
            {
                upperBound = middle - 1;
            }
            
            middle = (lowerBound + upperBound) / 2;
        }

        return middle;
    }
}