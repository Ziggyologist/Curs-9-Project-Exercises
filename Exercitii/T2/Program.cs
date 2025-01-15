/* T2: Cititi un numar si afisati “Pozitiv” daca numarul este mai mare decat
0, “Negativ” daca este mai mic decat 0 si “Zero” daca este egal cu 0.
 */
int num1;
Console.WriteLine("Introduceti un numar: ");

string num1Input = Console.ReadLine();


num1 = getInputNumber(num1Input, 1);


Console.WriteLine($"Numarul introdus e: {num1}.");

if (num1 > 0)
{
    Console.WriteLine("Numarul e pozitiv.");
}
else if (num1 == 0)
{
    Console.WriteLine("Numarul e Zero.");
} else
{
    Console.WriteLine("Numarul e negativ.");
}

int getInputNumber(string number, int order)
{
    int num;
    bool numIsValid = int.TryParse(number, out num);
    while (!numIsValid)
    {
        Console.WriteLine($"Numarul {order} introdus nu este valid. Introduceti alt numar.");
        number = Console.ReadLine();
        numIsValid = int.TryParse(number, out num);
    }
    Console.WriteLine($"Valoarea pentru numarul {order} este {num}.");
    return num;
}