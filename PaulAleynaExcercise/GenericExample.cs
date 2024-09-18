namespace PaulAleynaExcercise;

/*
 Generics:
Generische Klassen und Methoden werden verwendet, um es zu ermöglichen, das eine Methode für mehrere Typen funktioniert.
Beispielsweise eine Implementation einer API Requests. In welcher jeder Request zwar andere Felder zurückgibt, der Request aber immer gleich ist,
macht es mehr sinn eine Methode zu schreiben, welche alle Requests handelt und die Felder unterschiedlicher Klassen mit den Daten füllt,
als für jede Art der Requests eine eigene Methode zu schreiben.
 */

// Generische Klasse -> T ist ein Platzhalter für den Typen, welcher bei der Instanzierung der Klasse angegeben wird.
// Der Typ muss eine Klasse sein, da wir T auf class beschränkt haben.
public class GenericExample<T> where T : class
{
}

// Hier ist es notwendig, das der T einen Parameterlosen Konstruktor hat. Also keine Abstrakten Klassen oder Interfaces.
public class GenericExample2<T> where T : class, new()
{
}

// Hier ist es notwendig, das der T ein struct ist. Also ein Wertetyp wie int, double, float, etc. (kein String, keine Klasse)
public class GenericExample3<T> where T : struct
{
}

// Hier ist es notwendig, das der T das Interface IInterface implementiert.
public class GenericExample4<T> where T : IInterface
{
}


public class GenericExample5<T> where T : struct
{
    public void GetDefault()
    {
        var defaultValue = default(T);
        Console.WriteLine(defaultValue);
    }
}