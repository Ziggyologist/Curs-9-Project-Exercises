// T11: Cititi o serie de numere pana la introducerea valorii 0 si afisati media aritmetica a numerelor introduse.

int zero = 0;
int suma = 0;
int index = 0;
int media = 0;
bool runningLoop = true;

int number;
string numberString = Console.ReadLine();
bool numberValid = int.TryParse(numberString, out number);

while (runningLoop)
{
    if(numberValid && number != zero)
    {
        index++;
        suma += number;
        media = suma / index;
        Console.WriteLine($"Iteratia numarul {index}. Ati introdus cu succes numarul {number}. Media numerelor introduse pana acum este {media}.");
        numberString = Console.ReadLine();
        numberValid = int.TryParse(numberString, out number);
    } else if (!numberValid)
    {
        Console.WriteLine("Ati introdus o valoare care nu este numar. Va rugam incercati din nou cu mai mult creier.");
        numberString = Console.ReadLine();
        numberValid = int.TryParse(numberString, out number);
    } else if (number == zero)
    {
        Console.WriteLine("Numarul este zero. Iteratiile se opresc. Media tuturor numerelor, excluzand 0, este: "+ media);
        runningLoop = false;

    }
}
