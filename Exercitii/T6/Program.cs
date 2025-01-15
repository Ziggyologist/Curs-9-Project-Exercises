//T6: Cititi un numar si continuati sa cititi numere pana cand se introduce un numar negativ. Afisati suma numerelor introduse.
Console.WriteLine("Introduceti un numar: ");
string numarIntrodus = Console.ReadLine();
int numar = getInputNumber(numarIntrodus);
int suma = 0;
while (numar >= 0)
{
    suma += numar;
    Console.WriteLine("Numar introdus: " + numar +". Suma tuturor numerelor introduse pana acum este: " + suma + ".");
    numarIntrodus = Console.ReadLine();
    numar = getInputNumber(numarIntrodus);
}

if (numar < 0) 
{
    Console.WriteLine("Incetati sa introduceti numere. Suma pana la acest numar este: " + suma);
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
