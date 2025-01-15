using Test2;

internal class Program
{
    private static void Main(string[] args)
    {
        BaterieExterna bat = new BaterieExterna();
        bat.IncarcaDispozitiv(2000);
        //Console.WriteLine(((float)bat.SarcinaCurenta / bat.SarcinaMaxima * 100f) + "%");
        //bat.SarcinaMaxima = 100;
        Console.WriteLine(((float)bat.SarcinaMaxima / bat.SarcinaMaxima * 100f) + "%");
        bat.SarcinaCurenta = 4000;
        Console.WriteLine(((float)bat.SarcinaCurenta / bat.SarcinaMaxima * 100f) + "%");
    }
}