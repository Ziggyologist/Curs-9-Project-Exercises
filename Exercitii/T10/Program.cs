// T10: Cititi 5 numere si afisati cel mai mare dintre ele.


Console.WriteLine("Introduceti 5 numere: ");
string numarIntrodus1 = Console.ReadLine();
int numar1 = getInputNumber(numarIntrodus1,1);

string numarIntrodus2 = Console.ReadLine();
int numar2 = getInputNumber(numarIntrodus2,2);

string numarIntrodus3 = Console.ReadLine();
int numar3 = getInputNumber(numarIntrodus3,3);

string numarIntrodus4 = Console.ReadLine();
int numar4 = getInputNumber(numarIntrodus4,4);

string numarIntrodus5 = Console.ReadLine();
int numar5 = getInputNumber(numarIntrodus5,5);

if (numar1 >= numar2 && numar1 >= numar3 && numar1 >= numar4 && numar1 >= numar5)
{
    Console.WriteLine("Numarul 1 este cel mai mare: " + numar1);
}
else if (numar2 >= numar1 && numar2 >= numar3 && numar2 >= numar4 && numar2 >= numar5)
{
    Console.WriteLine("Numarul 2 este cel mai mare: " + numar2);
} else if (numar3 >= numar2 && numar3 >= numar1 && numar3 >= numar4 && numar3 >= numar5)
{
    Console.WriteLine("Numarul 3 este cel mai mare: " + numar3);
} else if (numar4 >= numar2 && numar4 >= numar3 && numar4 >= numar1 && numar4 >= numar5)
{
    Console.WriteLine("Numarul 4 este cel mai mare: " + numar4);
}
else if (numar5 >= numar2 && numar5 >= numar3 && numar5 >= numar4 && numar5 >= numar1)
{
    Console.WriteLine("Numarul 5 este cel mai mare: " + numar5);
}


int getInputNumber(string number, int order)
{
    int num;
    bool numIsValid = int.TryParse(number, out num);
    while (!numIsValid)
    {
        Console.WriteLine($"Introduceti alt numar. Numarul {order} nu este valid.");
        number = Console.ReadLine();
        numIsValid = int.TryParse(number, out num);
    }
    return num;
}
