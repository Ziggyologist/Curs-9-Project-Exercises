using System.ComponentModel.Design;

class Program
{
    private static void Main(string[] args)
    {
        Cat pisica1 = new("Martilda");
        //Animal pisica2 = new Animal("Fas-fas"); //o clasa abstracta nu poate genera obiecte in mod direct
        Animal pisica2 = new Cat("Fas-fas");
        Console.WriteLine(pisica1.Name + " are " + pisica1.GetFeetCount() + " picioare.");
        Console.WriteLine(pisica2.Name + " are " + pisica2.GetFeetCount() + " picioare.");
        pisica1.Scratch();
        //pisica2.Scratch(); // pisica 2 e de tipul animal, deci nu are metoda scratch
        //pisica2 e o variabila de tipul animal
        //pisica1 e o variabila de tipul cat
        

    }
}

abstract class Animal
{
    public string Name;
    public abstract int GetFeetCount();

    public Animal(string name)
    {
        Name = name;
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }
    public void Scratch()
    {
        Console.WriteLine("-10 viata");
    }

    public override int GetFeetCount() {return 4;}
}