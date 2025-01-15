// T12: Cititi un numar si afisati tabla inmultirii de la 1 la 10 a acestuia.

Console.WriteLine("Introduceti un numar: ");
string numarIntrodus = Console.ReadLine();
int numar = getInputNumber(numarIntrodus);

Console.WriteLine("Tabla inmultirii de la 1 la 10 a numarului " + numar);
for (int i =  1; i <= 10; i++)
{
    Console.WriteLine($" {numar} x {i} = {numar*i}");
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
