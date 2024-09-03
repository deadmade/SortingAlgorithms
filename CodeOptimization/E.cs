namespace CodeOptimization;

public class E
{
    public static void Start()
    {
        var basketballPlayers = new[]
        {
            new Player { FirstName = "Paul", LastName = "Wanner", Team = "hsb 1846 Herren I" },
            new Player { FirstName = "Chiara", LastName = "Cedrone", Team = "hsb 1846 Damen" },
            new Player { FirstName = "Leonardo", LastName = "Scienza", Team = "hsb 1846 Herren I" },
            new Player { FirstName = "Max", LastName = "Zeger", Team = "hsb 1846 Herren I" },
            new Player { FirstName = "Priscilla", LastName = "Pianowska", Team = "hsb 1846 Damen" }
        };

        var footballPlayers = new[]
        {
            new Player { FirstName = "Max", LastName = "Breunig", Team = "1. FC HDH" },
            new Player { FirstName = "Lennard", LastName = "Maloney", Team = "1. FC HDH" },
            new Player { FirstName = "Adrian", LastName = "Beck", Team = "1. FC HDH" },
            new Player { FirstName = "Paul", LastName = "Wanner", Team = "1. FC HDH" },
            new Player { FirstName = "Leonardo", LastName = "Scienza", Team = "1. FC HDH" }
        };

        var result = Execute(basketballPlayers, footballPlayers);
        foreach (var player in result)
        {
            Console.WriteLine(player);
        }
    }

    private static List<string> Execute(Player[] arrayOne, Player[] arrayTwo)
    {
        var dictionary = new Dictionary<string, int>();
        for (int i = 0; i < arrayOne.Length; i++)
        {
            dictionary.Add(arrayOne[i].FirstName + " " + arrayOne[i].LastName, 1);
        }
        var result = new List<string>();
        foreach (var player in arrayTwo)
        {
            if (dictionary.TryGetValue(player.FirstName + " " + player.LastName, out var value))
            {
                result.Add(player.FirstName + " " + player.LastName);
            }
        }
        return result;
    }
}

public class Player
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Team { get; set; }
}