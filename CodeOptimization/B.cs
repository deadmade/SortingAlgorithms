namespace CodeOptimization;

public class B
{
    public static void Start()
    {
        var array = new int[] {10,7,5,8,11,2,6};
        var result = Execute(array);
        Console.WriteLine(result);
    }

    private static int Execute(int[] prices)
    {
        if (prices == null || prices.Length < 2)
            return 0;

        int minPrice = prices[0];
        int maxProfit = 0;

        foreach (var price in prices)
        {
            if (price < minPrice)
            {
                minPrice = price;
            }
            else
            {
                int potentialProfit = price - minPrice;
                if (potentialProfit > maxProfit)
                {
                    maxProfit = potentialProfit;
                }
            }
        }

        return maxProfit;
    }
}