namespace PaulAleynaExcercise.Vererbung;

public class Dog : Cat
{
    public Dog(string name, int age, string color) : base(name, age, color)
    {
    }
    
    // Funktion Eat wird von Cat versiegelt, deshalb kann sie hier nicht überschrieben werden
    // public override void Eat()
    // {
    //     Console.WriteLine("Dog is eating");
    // }
}