/*● T3: Cititi doua numere si afisati-l pe cel mai mare dintre ele.*/


int num1, num2;
Console.WriteLine("Introduceti 2 numere: ");

string num1Input = Console.ReadLine();
string num2Input = Console.ReadLine();


num1 = getInputNumber(num1Input, 1);
num2 = getInputNumber(num2Input, 2);

Console.WriteLine($"Numerele introduse sunt: {num1}, {num2}.");

if (num1 > num2)
{
    Console.WriteLine("Numarul mai mare este: " + num1);    
} else
{
    Console.WriteLine("Numarul mai mare este: " + num2);
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