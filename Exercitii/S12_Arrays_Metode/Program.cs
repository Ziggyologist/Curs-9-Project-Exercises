Console.WriteLine("CONTINUE loop");
for  (int i = 1; i < 5; i++)
{
    if (i == 3) continue;
    Console.WriteLine(i);
    Console.WriteLine($"Numarul {i} a fost sarit. Executia a continuat cu iteratiile urmatoare");
}

Console.WriteLine("BREAK loop");
for (int i = 1; i < 3; i++)
{
    if (i == 3) continue;
    Console.WriteLine(i);
    Console.WriteLine($"Numarul {i}. Executia iteratiei s-a oprit.");
}