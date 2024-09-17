namespace PaulAleynaExcercise.Vererbung;

public class Cat : Animal
{
    bool isLazy {
        get{return true;}
        set{if (value == true) Console.WriteLine("Cat is lazy");}
        
    }
    
    // Base wird dafür verwendet, um den Konstruktor der Basisklasse aufzurufen
    public Cat(string name, int age, string color) : base(name, age, color)
    {
        isLazy = true;
    }
    
    public void MakeSound()
    {
        Console.WriteLine("Meow");
    }   
    
    // Funktion Eat wird von Animal als virtual markiert, deshalb kann sie hier überschrieben werden. Sie wird hier versiegelt durch das Schlüsselwort sealed
    public sealed override void Eat()
    {
        Console.WriteLine("Cat is eating");
    }
    
    public new void Sleep()
    {
        Console.WriteLine("Cat is sleeping");
    }
}