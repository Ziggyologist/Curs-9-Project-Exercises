namespace App1;

internal class Program
{
    public static void Main(string[] args)
    {
        Application01 app = new();
        Console.WriteLine(app.Cerinta);
        app.Launch();
    }
}