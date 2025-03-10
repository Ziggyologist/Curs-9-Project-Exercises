namespace App1;

internal class Program
{
    public static void Main(string[] args)
    {

        var v1 = new Class1(3);
        Console.WriteLine(nameof(v1) + ": " + v1);
        var v2 = v1;
        v2.MyProperty = 1;


        Console.WriteLine(nameof(v1) + ": " + v1);
        Console.WriteLine(nameof(v2) + ": " + v2);



        Application01 app = new();
        Console.WriteLine(app.Cerinta);
        app.Launch();
    }

    class Class1
    {
        public int MyProperty { get; set; }
        public Class1(int value) => MyProperty = value;
        public override string ToString() => $"[{typeof(Class1)}] {MyProperty}";
    }

    class Struct1
    {
        public int MyProperty { get; set; }
        public Struct1(int value) => MyProperty = value;
        public override string ToString() => $"[{typeof(Struct1)}] {MyProperty}";
    }
}