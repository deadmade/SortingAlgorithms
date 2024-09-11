using System.Reflection;

namespace SortingAlgorythms;

public class Program
{
    public static void Main()
    {
        var random = new Random();
        var arrayToSort = new int[20];
        for (var i = 0; i < 20; i++) arrayToSort[i] = random.Next(0, 100);
        
        var sortingAlgorithmType = typeof(IBaseSortingClass);
        var sortingAlgorithmInstances = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => sortingAlgorithmType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .Select(t => Activator.CreateInstance(t) as IBaseSortingClass)
            .ToList();
        
        foreach (var sortingAlgorithm in sortingAlgorithmInstances)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Executing sorting algorithm: " + sortingAlgorithm.GetType().Name);
            Console.WriteLine($"Original: {string.Join(", ", arrayToSort)}");
            var sortedArray = sortingAlgorithm.Sort((int[])arrayToSort.Clone());
            Console.WriteLine($"{sortingAlgorithm.GetType().Name}: {string.Join(", ", sortedArray)}");
        }
        
        // int[] arr = { 3, 6, 2, 7, 4, 1, 5 };
        // Console.WriteLine("Pancake Sort:");
        // Pancake_Sort.Sort(arr);
    }
}