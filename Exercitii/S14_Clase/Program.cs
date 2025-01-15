using System.Drawing;

Pix pixRosu = new("Pilot", ConsoleColor.Red);
Pix pixNegru = new("BIG", ConsoleColor.Black);
Pix pixVerde = new("Faber", ConsoleColor.Green);
pixRosu.Scrie("Am scris cu pixul rosu.");
pixNegru.Scrie("Am scris cu negru");
pixVerde.Scrie("Am scris cu verde");
pixRosu.Culoare = ConsoleColor.DarkRed;
pixRosu.Scrie("Am scris cu pixul rosu inchis");
Console.ForegroundColor = ConsoleColor.Gray;
pixRosu.CuloareExtra = Color.Green;
pixRosu.Scrie("Am scris cu pixul rosu inchis.");


class Pix
{
    public ConsoleColor Culoare;
    public string Marca;
    public Color CuloareExtra;

    public Pix(string marca, ConsoleColor culoare)
    {
        Culoare = culoare;
        Marca = marca;
    }

    public void Scrie(string ceSaScrie)
    {
        Console.ForegroundColor = Culoare;
        Console.WriteLine(ceSaScrie + "Are culoarea extra: " + CuloareExtra);
    }
}

/*
////////////////////////
Animal caine = new("Wilfred",12);
Animal pisica = new("Georgiana", 5);
Animal arici = new("Gogonel");
Animal liliac = new();

Animal[] animale = [caine, pisica, arici, liliac];
foreach (Animal animal in animale)
{
    if (animal.Nume == null)
    {
        Console.WriteLine($"Animalul nu are nume");
    } else
    {
        Console.WriteLine(animal.Nume);
    }
};
public class Animal
{
    public string Nume;
    public int Varsta;

    public Animal(string nume, int varsta)
    {
        Nume = nume;
        Varsta = varsta;
    }
    public Animal(string nume)
    {
        Nume = nume;
    }

    public Animal()
    {
        
    }

}

*/