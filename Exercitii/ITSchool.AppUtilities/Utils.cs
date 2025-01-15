namespace ITSchool.AppUtilities
{
    public static class Utils
    {
        public static int GetIntFromkeyboard(string denumire = "") // parametru optional
        {
            int a;
            bool aValid;

            string nume = "";

            if (!string.IsNullOrEmpty(denumire)) 
            {
                nume = " pentru: " + denumire;
            }

            do
            {
                Console.Write($"Introduceti un numar intreg{nume}.");
                string aInput = Console.ReadLine();
                aValid = int.TryParse(aInput, out a);

                if(!aValid)
                {
                    Console.WriteLine("Datele sunt invalide.");
                }
            } while (!aValid);
            return a;
        }

        public static int[] GenereazaArrayDeNumereIntregi(int dimensiuneArray, int limitaInferioara, int limitaSuperioara)
        {
            Random generatorDeNumareAleatoare = new Random();
            int[] arrayDeNumbere = new int[dimensiuneArray];
            for (int i = 0; i < arrayDeNumbere.Length; i++)
            {
                arrayDeNumbere[i] = generatorDeNumareAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
            }
            return arrayDeNumbere;
        }
    }
}
