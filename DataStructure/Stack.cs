namespace DataStructure;

public class Stack
{
    public static void Start()
    {
        var syntax = "(var x = 2)";
        var wrongSyntax = "var x = 2)";
        var wrongSyntax2 = "(var x = [1,2,3)]";
        
        Console.WriteLine(CheckSyntax(syntax));
        Console.WriteLine(CheckSyntax(wrongSyntax));
        Console.WriteLine(CheckSyntax(wrongSyntax2));
    }

    private static bool CheckSyntax(string syntax)
    {
        var stack = new System.Collections.Generic.Stack<char>();
        
        var openBrackets = new char[] {'(', '[', '{'};
        var closeBrackets = new char[] {')', ']', '}'};
        
        foreach (var character in syntax)
        {
            if (character == openBrackets[0] || character == openBrackets[1] || character == openBrackets[2])
            {
                stack.Push(character);
            }
            else if (character == closeBrackets[0] || character == closeBrackets[1] || character == closeBrackets[2])
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                
                var lastOpenBracket = stack.Pop();
                if (lastOpenBracket == openBrackets[0] && character != closeBrackets[0])
                {
                    return false;
                }
                if (lastOpenBracket == openBrackets[1] && character != closeBrackets[1])
                {
                    return false;
                }
                if (lastOpenBracket == openBrackets[2] && character != closeBrackets[2])
                {
                    return false;
                }
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}