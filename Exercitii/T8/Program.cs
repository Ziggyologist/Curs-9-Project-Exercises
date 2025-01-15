// T8: Cititi un numar si verificati daca este prim (divizibil doar cu 1 si el insusi).

Console.WriteLine("Introduceti un numar:");
string numarIntrodus = Console.ReadLine();
int numar = getInputNumber(numarIntrodus);

bool estePrim = true;

if (numar <= 1)
{
    Console.WriteLine("Acest numar nu este prim.");
    estePrim = false;
}
else if (numar <= 3)
{
    Console.WriteLine("Acest numar este prim.");
    estePrim = true;
}
else if (numar % 2 == 0 || numar % 3 == 0)
{
    Console.WriteLine("Acest numar nu este prim.");
    estePrim = false;
}
else
{
    for (int i = 5; i * i <= numar; i += 6)
    {
        if (numar % i == 0 || numar % (i + 2) == 0)
        {
            Console.WriteLine("Acest numar nu este prim.");
            estePrim = false;
            break;
        }
    }

    if (estePrim)
    {
        Console.WriteLine("Acest numar este prim.");
    }
}

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
