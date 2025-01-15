using System.Net.Http.Headers;

int[] sirDeDate1 = new int[5];
sirDeDate1 = [12, 2, 3, 4, 5, 6];
int[] sirDeDate2 = new int[3] { 2, 5, 10 };
int[] arrayData;

int[] sirDeNumereIntregi = { -3, 5, -1, 10, 6, -2, 8, 12, -10 };
string aplicatie = "app3";

//Calculati suma numerelor din sir.
if(aplicatie == "app1")
{
    Console.WriteLine($"App1. Lista contine {sirDeNumereIntregi.Length} elemente.");
    int suma = 0;
    for(int i = 0; i < sirDeNumereIntregi.Length; i++)
    {
        suma += sirDeNumereIntregi[i];
        //Console.WriteLine( suma );
    }
    Console.WriteLine( "Suma tuturor numerelor este: " + suma );
};

//Cautati si afisati cea mai mica valoare si cea mai mare valoare din sir.

if (aplicatie == "app2")
{
    Console.WriteLine($"App2. Lista contine {sirDeNumereIntregi.Length} elemente.");
     int celMaiMic = sirDeNumereIntregi.Min();
     int celMaiMare = sirDeNumereIntregi.Max();

    Console.WriteLine($"Cel mai mic numar este: {celMaiMic} si cel mai mare este {celMaiMare}");
};

//Calculati si afisati media aritmetica a numerelor din sir.

if (aplicatie == "app3")
{
    int suma = 0;
    //float medie = 0;
    for (int i = 0; i < sirDeNumereIntregi.Length; i++)
    {
        suma += sirDeNumereIntregi[i];
        
    }
    Console.WriteLine(suma);
    float medie = (float)suma / sirDeNumereIntregi.Length;

    Console.WriteLine("Media numerelor este: " + medie );
};

//Ordonati sirul crescator (folosind metoda “paharelor”).
