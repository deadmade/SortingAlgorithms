namespace DataStructure;

class Program
{
    static void Main(string[] args)
    {
        BinarySearch.Start();
        Stack.Start();
        Heap s = new Heap();
        
        Console.WriteLine("Heap insertions:");
        s.Insert(42);
        s.PrintTree();
        s.Insert(29);
        s.PrintTree();
        s.Insert(18);
        s.PrintTree();
        s.Insert(14);
        s.PrintTree();
        s.Insert(7);
        s.PrintTree();
        s.Insert(18);
        s.PrintTree();
        s.Insert(12);
        s.PrintTree();
        s.Insert(11);
        s.PrintTree();
        s.Insert(13);
        s.PrintTree();   
        s.Insert(60);
        s.PrintTree();
        
        Console.WriteLine("Heap extractions:");
        s.ExtractMax();
    }
}