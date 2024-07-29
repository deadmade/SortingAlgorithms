namespace SortingAlgorythms;

class Program
{
    private static Random _random = new Random();
    static void Main(string[] args)
    {
        var length = 10;
        var arryToSort = new int[length];
        for (int i = 0; i < length; i++)
        {
            arryToSort[i]= _random.Next(1, length); 
        }

        var sageArray = arryToSort.Where(x => x.ToString() != string.Empty).Select(x => x).ToArray();
        var sort = new SelectionSort().Sort(arryToSort);
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"Before:{sageArray[i]} | After: {sort[i]}");
        }
        
    }
}