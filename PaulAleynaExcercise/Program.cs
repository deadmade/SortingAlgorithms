using PaulAleynaExcercise.Vererbung;

namespace PaulAleynaExcercise;

class Program
{
    static void Main(string[] args)
    {
        // var collection = new object[] {1, 2.2, 't', true};
        //
        // foreach (var VARIABLE in collection)
        // {
        //     var type = VARIABLE.GetType();
        //     var genericType = typeof(GenericExample5<>).MakeGenericType(type);
        //     dynamic genericExample5 = Activator.CreateInstance(genericType);
        //     genericExample5.GetDefault();
        // }
        //
        // var simpleCollection = new SimpleCollection<int>();
        // simpleCollection.Add(1);
        // simpleCollection.Add(2);
        // simpleCollection.Add(3);
        // simpleCollection.Add(4);
        // simpleCollection.Add(5);
        //
        // foreach (var VARIABLE in simpleCollection)
        // {
        //     Console.WriteLine(VARIABLE);
        // }
        Animal animal = new Cat("Minka", 3, "black");
        Cat cat = new Cat("Minka", 3, "black");
        
        // Da MakeSound in Cat nicht als new markiert ist, wird die Methode der Basisklasse aufgerufen, da sie hier die Statische Typisierung ist
        animal.MakeSound();
        
        // Hier wird die Methode der abgeleiteten Klasse aufgerufen, da sie hier die Statische Typisierung ist
        cat.MakeSound();
        
        Console.WriteLine();
        
        // Sleep benutzt das Schlüsselwort virtual bzw new, daher wird für Animal die Methode der Basisklasse aufgerufen und für Cat die Methode der abgeleiteten Klasse
        // beide Methoden bleiben bestehen
        animal.Sleep();
        cat.Sleep();
        
        Console.WriteLine();
        
        // Eat benutzt das Schlüsselword override wodurch die Methode die Methode der Basisklasse überschreibt, daher wird für Animal die Methode der abgeleiteten Klasse aufgerufen 
        // und für Cat die Methode der abgeleiteten Klasse
        animal.Eat();
        cat.Eat();
        
        
        Cat a = new Cat("Minka", 3, "black");
        Cat b = new Cat("Mauzi", 4, "green");
        
        var superCat = a + b;
        Console.WriteLine(superCat.Name);
    }
}