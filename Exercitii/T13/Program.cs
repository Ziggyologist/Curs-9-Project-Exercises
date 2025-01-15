// T13: Cititi un numar n si afisati tabla inmultirii de la 1 la 10 a tuturor numerelor de la 1 la n.

Console.WriteLine("Introduceti un numar: ");
string numarIntrodus = Console.ReadLine();
int numar = getInputNumber(numarIntrodus);

Console.WriteLine("Tabla inmultirii de la 1 la 10 a tuturor numerelor de la 1 la " + numar);
for (int i = 1; i <= numar; i++)
{
    Console.WriteLine("\n Tabla inmultirii pentru: " + i);
    for (int factor = 1; factor <= 10; factor++)
    {
        Console.WriteLine($" {i} x {factor} = {i * factor}");
    }
}

int getInputNumber(string number)
{
    int num;
    bool numIsValid = int.TryParse(number, out num);
    while (!numIsValid)
    {
        number = Console.ReadLine();
        numIsValid = int.TryParse(number, out num);
    }
    return num;
}
