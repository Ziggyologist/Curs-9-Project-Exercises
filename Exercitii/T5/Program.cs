/*● T5: Cititi varsta unei persoane si afisati daca este minora(sub 18 ani),
pensionara (65 ani sau mai mult), sau adulta. Avertizati la numere care
nu corespund. */
int a = 14;
int b = 3;
Console.WriteLine(a % b);

int varsta;
Console.WriteLine("Introduceti o varsta: ");
string varstaString = Console.ReadLine();
varsta = getInputNumber(varstaString, 1);

Console.WriteLine($"Numarul introdus e: {varsta}.");

if (varsta >=0 && varsta <18)
{
    Console.WriteLine("Persoana este minora.");
} else if (varsta >= 18 && varsta < 65 )
{
    Console.WriteLine("Persoana este adulta.");
} else if (varsta >= 65 && varsta <= 140)
{
    Console.WriteLine("Persoana este pensionara.");
} else
{
    Console.WriteLine("Verificati ca ati introdus o varsta corecta.");
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