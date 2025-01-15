// T7: Generati si afisati toate numerele de la 1 la 50 care sunt divizibile cu 3

Console.WriteLine("Generati si afisati toate numerele de la 1 la 50 care sunt divizibile cu 3");

for (int i = 1; i < 50; i++)
{
    if (i % 3 == 0)
    { 
        Console.WriteLine("Acest numar este divizibil cu 3: " + i); 
    }
}

