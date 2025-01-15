using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        ClasaStatica.SalutariCuNumarare();
        ClasaStatica.SalutariCuNumarare();
        ClasaStatica.SalutariCuNumarare();
        ClasaStatica.SalutariCuNumarare();
        Console.WriteLine(ClasaStatica.Aduna(2, 10));

        Vector3 directieDeDeplasare = new Vector3(1,0,0);
    }
}

static class ClasaStatica
{
    static int _variabilaStatica = 0;
    public static void SalutariCuNumarare()
    {
        Console.WriteLine($"Salutari IT School de {_variabilaStatica++} ori!");
    }
    public static int Aduna(int stanga, int dreapta)
    {
        return stanga + dreapta;
    }
}

class BaterieExterna
{
    public int CapacitateActuala;
}
class Consumator
{
    public int CapacitateRamasa;
}

static class ActiuniBaterie
{
    static void Incarcare(BaterieExterna baterie, Consumator consumator)
    {
        int capacitateDeIncarcat = consumator.CapacitateRamasa;
        Console.WriteLine("aha");
    }
}