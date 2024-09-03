namespace CodeOptimization;

public class A
{
    public static void Start()
    {
        var array = new int[] {2,3,0,6,1,5};
        var result = Execute(array);
        Console.WriteLine(result);
    }

    private static int Execute(int[] array)
    {
        var max = array.Max();
        var sum =  max * (max + 1) / 2;
        var arraySum = array.Sum();
        return sum - arraySum;

    }
}