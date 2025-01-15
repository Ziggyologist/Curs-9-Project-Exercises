//T9: Cititi un numar si afisati suma cifrelor sale.



Console.WriteLine("Introduceti un numar: ");
string numarIntrodus = Console.ReadLine();
int numar = getInputNumber(numarIntrodus);
int suma = 0;


foreach (char unit in numarIntrodus)
{
    //Console.WriteLine(unit);
    int cifra = int.Parse(unit.ToString());
    suma += cifra;
}

Console.WriteLine($"Suma cifrelor este numarului {numar} este: " + suma);


int getInputNumber(string number)
{
    int num;
    bool numIsValid = int.TryParse(number, out num);
    while (!numIsValid)
    {
        Console.WriteLine("Introduceti un numar valid:");
        number = Console.ReadLine();
        numIsValid = int.TryParse(number, out num);
    }
    return num;
}
