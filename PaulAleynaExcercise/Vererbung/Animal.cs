namespace PaulAleynaExcercise.Vererbung;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }

    public Animal(string name, int age, string color)
    {
        Name = name;
        Age = age;
        Color = color;
    }

    public void MakeSound()
    {
        Console.WriteLine("Animal is making sound");
    }

    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating");
    }

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping");
    }
}