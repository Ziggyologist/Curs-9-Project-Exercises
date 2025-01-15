namespace App4;
public class Program
{
    private static void Main(string[] args)
    {
        Application4 application = new();
        application.Cerinta = "cerinta";
        Console.WriteLine(application.Cerinta);
        application.Launch();
    }
}