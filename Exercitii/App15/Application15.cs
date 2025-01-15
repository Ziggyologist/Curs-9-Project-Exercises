using ITSchool.AppUtilities;

namespace App15;

public class Application15 : ApplicationBase
{
    public Application15()
    {
        Cerinta = "Avem un sir aleatoriu de 100 numere inter 0 si 9. Verificati numarul de aparitii pentru fiecare din aceste numere si afisati rezultaele";
    }
    public override void Launch()
    {
        int[] arrayDeNumere = Utils.GenereazaArrayDeNumereIntregi(100, 0, 9);
        int[] numarator = new int[10];
        for (int i = 0; i < arrayDeNumere.Length; i++) 
        {
            //valoarea gasita la pozitia curenta poate incrementa numaratorul de pe valoare
            numarator[arrayDeNumere[i]]++;
            Console.Write(arrayDeNumere[i] + ",");
        }
        //Afisare
        for (int i = 0; i < numarator.Length; i++) 
        { 
            Console.WriteLine(i + ". " +numarator[i]);
        }

    }
}
