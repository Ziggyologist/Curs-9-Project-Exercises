namespace App6;
internal class Program
{
    private static void Main(string[] args)
    {
        Application6 app = new();
        app.Cerinta = "Cerinta";
        Console.WriteLine(app.Cerinta);
        app.Launch();
    }
}