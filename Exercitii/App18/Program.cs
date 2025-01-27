namespace App18
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application18 app = new();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(app.Cerinta);
            Console.ForegroundColor = ConsoleColor.White;
            app.Launch();
        }
    }
}

